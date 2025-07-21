using PersonaGameLib;
using SevenZipExtractor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaPatchGen
{
    public partial class WizardForm
    {
        private void PatchPS2Game()
        {
            CreatePNACH();
            string crc = GetGameCRC(ExtractELF(txt_GamePath.Text));

            if (radio_Console.Checked)
            {
                PatchExecutable();
                RepackISO();
            }
            else
            {
                UpdatePCSX2Settings();
                PatchLog("Setup complete! Run the game in PCSX2 and the patches should work.");
            }
        }

        private string ExtractELF(string isoPath)
        {
            string elfOutPath = "";
            using (ArchiveFile archiveFile = new ArchiveFile(isoPath))
            {
                archiveFile.Entries
                    .Where(entry => entry.FileName.StartsWith("SL", StringComparison.OrdinalIgnoreCase))
                    .ToList()
                    .ForEach(entry =>
                    {
                        elfOutPath = Path.Combine(txt_OutputDir.Text, entry.FileName);
                        Directory.CreateDirectory(Path.GetDirectoryName(elfOutPath));
                        entry.Extract(elfOutPath);
                        PatchLog($"Extracted ELF: {elfOutPath}");
                    });
            }

            return elfOutPath;
        }

        private string GetGameCRC(string filePath)
        {
            byte[] data = File.ReadAllBytes(filePath);

            // Pad with zeroes if length is not a multiple of 4
            if (data.Length % 4 != 0)
            {
                int paddedLength = data.Length + (4 - data.Length % 4);
                Array.Resize(ref data, paddedLength);
            }

            uint crc = 0;
            for (int i = 0; i < data.Length; i += 4)
            {
                //uint word = BitConverter.ToUInt32(data, i);
                uint word = BitConverter.IsLittleEndian
                    ? BitConverter.ToUInt32(data, i)
                    : BitConverter.ToUInt32(data.Skip(i).Take(4).Reverse().ToArray(), 0);

                crc ^= word;
            }

            return crc.ToString("X");
        }

        private void ExtractISO()
        {
            throw new NotImplementedException();
        }

        private void CreatePNACH()
        {
            List<GamePatch> selectedPatches = GetPatchCombos().FirstOrDefault();
            StringBuilder sb = new StringBuilder();

            PatchLog("Creating .PNACH File...");

            // Add enabled patches to text file
            sb.Append("// PNACH generated at https://shrinefox.com\n");
            foreach (GamePatch patch in selectedPatches)
                sb.Append($"\n// Title: {patch.Name}" +
                    $"\n// Author: {patch.Author}" +
                    $"\n// Game: {selectedGame.Name} ({selectedGame.Region})" +
                    $"\n// Notes: {patch.Description}" +
                    $"\n{patch.Text}\n");

            string pnachPath = Path.Combine(txt_OutputDir.Text, $"{selectedGame.TitleID}.pnach");
            File.WriteAllText(pnachPath, sb.ToString());
            PatchLog($"Created file: {pnachPath}");
        }

        private void PatchExecutable()
        {
            throw new NotImplementedException();
        }

        private void RepackISO()
        {
            throw new NotImplementedException();
        }

        private void UpdatePCSX2Settings()
        {
            string pcsx2DocsDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PCSX2");
            string iniPath = Path.Combine(pcsx2DocsDir, "inis", "PCSX2.ini");

            if (File.Exists(iniPath))
            {
                var lines = File.ReadAllLines(iniPath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (line.StartsWith("HostFs"))
                    {
                        lines[i] = $"HostFs = true";
                        PatchLog($"Enabled HostFs in PCSX2");
                    }
                }
                File.WriteAllLines(iniPath, lines);
                PatchLog($"Saved PCSX2.ini");
            }
            else
            {
                MessageBox.Show($"Could not find PCSX2.ini at path:\r\n\r\n" +
                    iniPath);
                PatchLog($"Failed to update PCSX2 settings. PCSX2.ini not found.");
            }

            string pnachPath = Path.Combine(txt_OutputDir.Text, $"{selectedGame.TitleID}.pnach");

            if (File.Exists(pnachPath))
            {
                string pnachDestination = Path.Combine(pcsx2DocsDir, "cheats", $"{selectedGame.TitleID}.pnach");
                File.Copy(pnachPath, pnachDestination, true);
                PatchLog($"Copied .PNACH file to PCSX2 cheats directory.");
            }
            else
            {
                MessageBox.Show($"Could not find .PNACH file at path:\r\n\r\n" +
                    pnachPath);
                PatchLog($"Failed to add patches to PCSX2. PNACH file not found.");
            }
        }
    }
}
