using PersonaGameLib;
using ShrineFox.IO;
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
        private void PatchPS3Game()
        {
            if (!radio_Console.Checked)
                GetPPUHash();

            CreateYML();

            if (radio_Console.Checked)
            {
                PatchPS3Eboot();
                PatchLog($"Transfer the patched EBOOT to your PS3's dev_hdd0\\game\\{selectedGame.TitleID}\\USRDIR folder using FTP");
                PatchLog($"More info: https://shrinefox.com/blog/2019/06/12/persona-5-ps3-eboot-patching/");
            }
            else
            {
                PatchLog($"Enable patches in RPCS3 settings. Don't auto-update patches when asked!");
                PatchLog($"More info: https://shrinefox.com/blog/2019/04/19/persona-5-rpcs3-modding-guide-1-downloads-and-setup/");
            }
        }

        private void GetPPUHash()
        {
            Exe.Run(txt_ExePath.Text, $"--no-gui \"%RPCS3_GAMEID%:{selectedGame.TitleID}\"", hideWindow:false);
            Thread.Sleep(1000); // Wait for RPCS3 to hopefully load PPU hash
            Exe.CloseProcess("rpcs3");

            string logPath = Path.Combine(Path.GetDirectoryName(txt_ExePath.Text), "RPCS3.log");
            if (File.Exists(logPath))
            {
                var logLines = File.ReadAllLines(logPath);
                var ppuLine = logLines.FirstOrDefault(line => line.Contains("PPU executable"));
                if (ppuLine.Contains("PPU executable"))
                {
                    // sanitize the PPU hash
                }
            }
            else
                MessageBox.Show($"Could not find RPCS3.log at:\r\n{logPath}", "Fetching PPU Hash Failed");
        }

        private void CreateYML()
        {
            string ymlText = "";
            if (radio_Console.Checked)
                ymlText = PatchYML_OldFormat();
            else
                ymlText = PatchYML_NewFormat();

            string outDir = Path.Combine(txt_OutputDir.Text, "patch.yml");
            File.WriteAllText(outDir, ymlText);
        }

        private void PatchPS3Eboot()
        {
            throw new NotImplementedException();
        }

        private string PatchYML_NewFormat()
        {
            List<GamePatch> selectedPatches = GetPatchCombos().FirstOrDefault();
            PatchLog($"Creating New Format patch.yml with {selectedPatches.Count} patches");
            
            StringBuilder sb = new StringBuilder();
            sb.Append("Version: 1.2" +
                "\n# Patch.yml generated using ShrineFox's PersonaPatcher2 Software: https://shrinefox.com");
            foreach (var patch in selectedPatches)
                    sb.Append($"\n\n{PPUHash}:" +
                    $"\n  {patch.Name}:" +
                    $"\n    Games:" +
                    $"\n      \"Persona 5\":" +
                    $"\n        BLES02247: [ All ]" +
                    $"\n        NPEB02436: [ All ]" +
                    $"\n        BLUS31604: [ All ]" +
                    $"\n        NPUB31848: [ All ]" +
                    $"\n    Author: {patch.Author}" +
                    $"\n    Notes: {patch.Description}" +
                    $"\n    Patch Version: {patch.Version}" +
                    $"\n    Patch:" +
                    $"\n    {patch.Text.Replace("\n  ", "\n      ")}");

            return sb.ToString();
        }

        private string PatchYML_OldFormat()
        {
            List<GamePatch> selectedPatches = GetPatchCombos().FirstOrDefault();
            PatchLog($"Creating Old Format patch.yml with {selectedPatches.Count} patches");

            StringBuilder sb = new StringBuilder();
            sb.Append("# Patch.yml using ShrineFox's PersonaPatcher2 Software: https://shrinefox.com");
            foreach (GamePatch patch in selectedPatches)
            {
                string patchID = "p5_" + patch.Name.ToLower().Replace(" ", "_");
                sb.Append($"# {patch.Name} v{patch.Version} by {patch.Author}" +
                    $"\n# {patch.Description}" +
                    $"\n{patchID}: &{patchID}");

                // Update file path to SPRX for hardware
                if (patch.Name.Equals("Mod SPRX"))
                    sb.Append($"\n{patch.Text.Replace("- [ be32, 0xa3bed0, 0x2f617070 ]", "- [ be32, 0xa3bed0, 0x2F646576 ]").Replace("- [ be32, 0xa3bed4, 0x5f686f6d ]", "- [ be32, 0xa3bed4, 0x5F686464 ]").Replace("- [ be32, 0xa3bed8, 0x652f6d6f ]", "- [ be32, 0xa3bed8, 0x302F7035 ]").Replace("- [ be32, 0xa3bedc, 0x642e7370 ]", "- [ be32, 0xa3bedc, 0x65782F6D ]").Replace("- [ be32, 0xa3bee0, 0x72780000 ]", "- [ be32, 0xa3bee0, 0x6F642E73 ]").Replace("- [ be32, 0xa3bee4, 0x0 ]", "- [ be32, 0xa3bee4, 0x70727800 ]")}");
                else
                    sb.Append($"\n{patch.Text}");
            }
            sb.Append($"{PPUHash}:");
            foreach (GamePatch patch in selectedPatches)
            {
                string patchID = "p5_" + patch.Name.ToLower().Replace(" ", "_");
                sb.Append($"\n- [ load, {patchID} ]");
            }

            return sb.ToString();
        }

    }
}
