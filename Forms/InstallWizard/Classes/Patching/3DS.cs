using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShrineFox.IO;

namespace PersonaPatchGen
{
    public partial class WizardForm
    {
        private static long startPos = 5619776;
        int lengthWritten = 0;

        private void Patch3DSGame()
        {
            Apply3DSPatches();
            //FTPCodeBin();
        }

        private void Apply3DSPatches()
        {
            // Copy code.bin to Output
            SetProgress(25);

            List<GamePatch> selectedPatches = GetPatchCombos().FirstOrDefault();
            string dirPath = Path.Combine(Exe.Directory(), $"Dependencies\\3DS\\{selectedGame.ShortName}\\ModCpk");
            string outputDir = Path.Combine(Exe.Directory(), $"Output\\3DS\\{selectedGame.ShortName}\\{selectedRegion}");
            bool canonNames = selectedPatches.Any(x => x.ShortName.Equals("canonNames"));
            bool useCustomNames = false;
            bool isPQ2 = (selectedGame.ShortName == "PQ2");
            PQNameForm form = new PQNameForm(isPQ2);

            if (canonNames)
            {
                dirPath += "\\CanonNames";
                // Get custom character names
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    useCustomNames = true;
                else
                    PatchLog("User cancelled custom name entry, using default names.");
            }

            SetProgress(50);

            // Copy dependencies to output + dummy mod.cpk
            FileSys.CopyDir(dirPath, outputDir);
            string canonNamesDir = Path.Combine(outputDir, "CanonNames");
            if (!canonNames)
                if (Directory.Exists(canonNamesDir))
                    Directory.Delete(canonNamesDir, true);
            File.Copy(Path.Combine(Exe.Directory(), "Dependencies\\3DS\\mod.cpk"), Path.Combine(outputDir, "mod.cpk"), true);

            PatchLog("Copied selected patch files to Output.");

            SetProgress(75);

            // Modify code.bin with names
            string codeBinPath = Path.Combine(outputDir, "code.bin");
            using (FileSys.WaitForFile(codeBinPath)) { }
            if (useCustomNames)
            {
                using (FileStream stream = new FileStream(codeBinPath, FileMode.Open))
                    using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    if (isPQ2)
                        startPos = 6390016;
                    writer.BaseStream.Position = startPos;
                    if (!isPQ2)
                    {
                        WriteFirstLastNames(writer, form.P3HERO_First, form.P3HERO_Last);
                        WriteSingleName(writer, form.P3HERO_Last);
                        WriteSingleName(writer, form.P3HERO_First);
                        WriteFirstLastNames(writer, form.P4HERO_First, form.P4HERO_Last);
                        WriteSingleName(writer, form.P4HERO_Last);
                        WriteSingleName(writer, form.P4HERO_First);
                    }
                    else
                    {
                        WriteSingleName(writer, form.P5HERO_First);
                        WriteSingleName(writer, form.P5HERO_Last);
                        WriteFirstLastNames(writer, form.P5HERO_First, form.P5HERO_Last);
                        WriteSingleName(writer, form.P4HERO_First);
                        WriteSingleName(writer, form.P4HERO_Last);
                        WriteFirstLastNames(writer, form.P4HERO_First, form.P4HERO_Last);
                        WriteSingleName(writer, form.P3HERO_First);
                        WriteSingleName(writer, form.P3HERO_Last);
                        WriteFirstLastNames(writer, form.P3HERO_First, form.P3HERO_Last);
                        WriteSingleName(writer, form.P3PHERO_First);
                        WriteSingleName(writer, form.P3PHERO_Last);
                        WriteFirstLastNames(writer, form.P3PHERO_First, form.P3PHERO_Last);
                    }
                }
                PatchLog("Edited code.bin with your preferred custom names.");
            }

            SetProgress(100);
        }

        private void WriteFirstLastNames(BinaryWriter writer, string firstName, string lastName)
        {
            writer.Write(Encoding.ASCII.GetBytes(firstName));
            if (firstName.Length < 14 || lastName.Length < 14)
                writer.Write(Encoding.ASCII.GetBytes(" "));
            writer.Write(Encoding.ASCII.GetBytes(lastName));
            writer.Write(new byte[28 - (writer.BaseStream.Position - (startPos + lengthWritten))]);
            lengthWritten += 28;
        }

        private void WriteSingleName(BinaryWriter writer, string name)
        {
            writer.Write(Encoding.ASCII.GetBytes(name));
            writer.Write(new byte[14 - (writer.BaseStream.Position - (startPos + lengthWritten))]);
            lengthWritten += 14;
        }

        private void FTPCodeBin()
        {
            throw new NotImplementedException();
        }
    }
}
