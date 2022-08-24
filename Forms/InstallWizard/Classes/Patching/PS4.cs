using ShrineFox.IO;
using PersonaPatchGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaPatchGen
{
    public partial class WizardForm
    {

        private void PatchPS4Game()
        {
            SetProgress(0);

            if (Python3Installed())
            {
                if (selectedGame.ShortName != "P5R" || CheckP5RUpdateFiles())
                {
                    string outputDir = Path.Combine(Exe.Directory(), $"Output\\{selectedGame.TitleID}");
                    if (!Directory.Exists($"{outputDir}\\base_extracted"))
                        Directory.CreateDirectory($"{outputDir}\\base_extracted");

                    if (!File.Exists($"{outputDir}\\base_extracted\\Sc0\\nptitle.dat") || !File.Exists($"{outputDir}\\base_extracted\\Sc0\\npbind.dat")
                        || !File.Exists($"{outputDir}\\base_extracted\\Sc0\\param.sfo") || !File.Exists($"{outputDir}\\base_extracted\\Image0\\eboot.bin"))
                        ExtractPKG(outputDir);

                    List<List<GamePatch>> patchCombos = GetPatchCombos();

                    for (int i = 0; i < patchCombos.Count; i++)
                    {
                        PatchLog($"Creating PKG ({i + 1}/{patchCombos.Count()}, please be patient as this can take a very long time...");
                        Thread.Sleep(200);
                        CreateUpdatePKG(patchCombos[i], outputDir);
                    }
                }
            }
        }

        private bool CheckP5RUpdateFiles()
        {
            bool fileMissing = false;
            string updateFilesDir = Path.Combine(Exe.Directory(), $"Dependencies\\PS4\\GenGP4\\{selectedGame.TitleID}-patch\\USRDIR");

            foreach (var file in new string[] { "patch2R.cpk", "patch2R_F.cpk", "patch2R_G.cpk", "patch2R_I.cpk", "patch2R_S.cpk" })
            {
                if (!File.Exists(Path.Combine(updateFilesDir, file)))
                    fileMissing = true;
            }
            if (fileMissing)
            {
                MessageBox.Show($"Please place the extracted CPKs from the P5R v1.02 update in the following directory and try again: {updateFilesDir}");
                return false;
            }
            return true;
        }

        private void ExtractPKG(string outputDir)
        {
            PatchLog("Extracting PKG. Please wait, this may take a long time. This step only needs to be performed once...");
            Thread.Sleep(200);
            Exe.Run("Dependencies\\PS4\\orbis-pub-cmd.exe", $"img_extract --passcode 00000000000000000000000000000000 \"{txt_PKGPath.Text}\" \"{outputDir}\"");
            PatchLog("Successfully extracted files from Base Game FPKG!");
        }

        private void CreateUpdatePKG(List<GamePatch> patchCombo, string outputDir)
        {
            List<string> patchNames = new List<string>();
            List<string> patchShortNames = new List<string>();
            foreach (var patch in patchCombo)
            {
                patchNames.Add(patch.Name);
                patchShortNames.Add(patch.ShortName);
            }

            PatchLog($"\t{String.Join("+", patchNames)}");

            SetProgress(1);

            // Update path in gp4 to PKG
            string gp4Path = Path.Combine(Exe.Directory(), $"Dependencies\\PS4\\GenGP4\\{selectedGame.TitleID}-patch.gp4");
            var gp4Text = File.ReadAllLines(gp4Path);
            for (int i = 0; i < gp4Text.Count(); i++)
                if (gp4Text[i].Contains("app_path="))
                    gp4Text[i] = $"      app_path=\"{txt_PKGPath.Text}\"";

            SetProgress(5);

            // Create working dir from dependencies folder (updated with extracted files from base game PKG)
            string genGP4Dir = Path.Combine(Exe.Directory(), $"Dependencies\\PS4\\GenGP4\\{selectedGame.TitleID}-patch");
            string patchDir = Path.Combine(outputDir, $"{selectedGame.TitleID}-patch");
            if (File.Exists($"{outputDir}\\base_extracted\\Sc0\\nptitle.dat"))
                File.Copy($"{outputDir}\\base_extracted\\Sc0\\nptitle.dat", Path.Combine(genGP4Dir, "sce_sys\\nptitle.dat"), true);
            if (File.Exists($"{outputDir}\\base_extracted\\Sc0\\npbind.dat"))
                File.Copy($"{outputDir}\\base_extracted\\Sc0\\npbind.dat", Path.Combine(genGP4Dir, "sce_sys\\npbind.dat"), true);
            if (File.Exists($"{outputDir}\\base_extracted\\Sc0\\param.sfo"))
                File.Copy($"{outputDir}\\base_extracted\\Sc0\\param.sfo", Path.Combine(genGP4Dir, "sce_sys\\param.sfo"), true);
            if (File.Exists($"{outputDir}\\base_extracted\\Image0\\eboot.bin"))
                File.Copy($"{outputDir}\\base_extracted\\Image0\\eboot.bin", Path.Combine(genGP4Dir, "eboot.bin"), true);
            FileSys.CopyDir(genGP4Dir, patchDir);
            File.Copy(gp4Path, Path.Combine(Path.GetDirectoryName(patchDir), $"{selectedGame.TitleID}-patch.gp4"), true);

            SetProgress(10);

            // Patch EBOOT
            if (PatchEBOOTWithPPP(Path.Combine(genGP4Dir, "eboot.bin"), patchShortNames))
            {
                PatchLog($"Patched EBOOT successfully.");

                SetProgress(20);

                // Update PKG description
                File.WriteAllText($"{genGP4Dir}\\sce_sys\\changeinfo\\changeinfo.xml", $"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<changeinfo>\n  <changes app_ver=\"01.01\">\n    <![CDATA[\nPatched using ShrineFox's PersonaPatcher2 Software\n(based on zarroboogs's ppp):\n\n - {string.Join("\n - ", patchNames)}\n    ]]>\n  </changes>\n</changeinfo>");
                PatchLog("Edited Update PKG description.");

                SetProgress(30);

                if (BuildPKG(patchShortNames, genGP4Dir))
                    PatchLog("Update PKG created successfully!");
                else
                    PatchLog("Update PKG creation failed.");
            }
            else
                PatchLog("Patched EBOOT creation failed.");
        }

        private bool BuildPKG(List<string> patchShortNames, string genGP4Dir)
        {
            // (Re)create temp dir
            string tempPKGDir = Path.Combine(genGP4Dir, "Dependencies\\PS4\\temp");
            Exe.CloseProcess("orbis-pub-cmd", true);
            if (Directory.Exists(tempPKGDir))
                Directory.Delete(tempPKGDir, true);
            Directory.CreateDirectory(tempPKGDir);

            // Generate new PKG file
            string args = $"img_create --oformat pkg --tmp_path ./temp ./{selectedGame.TitleID}-patch.gp4 ./temp";
            Exe.Run(Path.Combine(Exe.Directory(), $"Dependencies\\PS4\\orbis-pub-cmd.exe"), args, true, Path.GetDirectoryName(genGP4Dir));

            // Copy PKG/EBOOT to Output folder
            string pkgPath = $"Dependencies\\PS4\\{selectedGame.PKGName}";
            using (FileSys.WaitForFile(pkgPath)) { };
            if (File.Exists(pkgPath))
            {
                string outputEboot = $"{Exe.Directory()}\\Output\\EBOOT\\{string.Join("\\", patchShortNames)}";
                string outputPKG = $"{Exe.Directory()}\\Output\\PKG\\{string.Join("\\", patchShortNames)}";
                Directory.CreateDirectory(Path.Combine(outputEboot));
                Directory.CreateDirectory(Path.Combine(outputPKG));
                string newEbootPath = Path.Combine(outputEboot, "eboot.bin");
                if (File.Exists(newEbootPath))
                    File.Delete(newEbootPath);
                File.Move(Path.Combine(genGP4Dir, "eboot.bin"), newEbootPath);
                string newPKGPath = Path.Combine(outputPKG, selectedGame.PKGName);
                PatchLog("Patched EBOOT moved to Output folder");
                if (File.Exists(newPKGPath))
                    File.Delete(newPKGPath);
                File.Move(pkgPath, newPKGPath);
                PatchLog("Update PKG moved to Output folder");
                return true;
            }
            return false;
        }

        private bool PatchEBOOTWithPPP(string ebootPath, List<string> patchShortNames)
        {
            // Make sure xdelta.exe is in PATH
            string xdelta = Path.Combine(Exe.Directory(), @"Dependencies\xdelta.exe");
            Directory.CreateDirectory(@"C:\.bin");
            File.Copy(xdelta, @"C:\.bin\xdelta.exe", true);
            var oldValue = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            if (!oldValue.Contains(@"C:\.bin"))
                Environment.SetEnvironmentVariable("PATH", oldValue + @";C:\.bin", EnvironmentVariableTarget.User);

            string pyPath = Path.Combine(Exe.Directory(), @"Dependencies\PS4\ppp\patch.py");
            string args = $"{pyPath} {Path.GetFileName(ebootPath)} --patch {string.Join(" ", patchShortNames)}";
            using (FileSys.WaitForFile(ebootPath)) { };
            Exe.Run(pythonPath, args, true, Path.GetDirectoryName(ebootPath));
            string patchedEbootPath = ebootPath + "--patched";
            using (FileSys.WaitForFile(patchedEbootPath)) { };
            if (File.Exists(patchedEbootPath))
            {
                using (FileSys.WaitForFile(ebootPath)) { };
                File.Copy(patchedEbootPath, ebootPath, true);

                return true;
            }
            return false;
        }
    }
}
