using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaPatchGen
{
    public partial class WizardForm
    {
        private void MainTab_Changed(object sender, EventArgs e)
        {
            SetupPageButtons();
        }
        private void Back_Clicked(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void Action_Clicked(object sender, EventArgs e)
        {
            PerformAction();
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            NextPage();
        }

        private void NextPage()
        {
            tabControl_Main.SelectedIndex += 1;
            // Skip Updates page
            if (tabControl_Main.SelectedIndex == 1)
                tabControl_Main.SelectedIndex = 2;
        }

        private void PreviousPage()
        {
            tabControl_Main.SelectedIndex -= 1;
            // Skip Updates page
            if (tabControl_Main.SelectedIndex == 1)
                tabControl_Main.SelectedIndex = 0;
        }

        private void Platform_Changed(object sender, EventArgs e)
        {
            UpdateSelectedPlatform();
        }
        private void Region_Changed(object sender, EventArgs e)
        {
            UpdateSelectedRegion();
        }

        private void Game_Changed(object sender, EventArgs e)
        {
            UpdateSelectedGame();

            // Deselect unfakesign for P5R by default
            if (selectedGame.ShortName == "P5R")
                chk_Unfakesign.Checked = false;
        }

        private void DownloadLog(string msg)
        {
            rtb_Updates_Log.SyncUI(() => { rtb_Updates_Log.AppendText($"\n[{DateTime.Now.ToString("MM/dd/yyyy HH:mm tt")}] {msg}"); }, true);
        }

        private void PatchLog(string msg)
        {
            rtb_Apply_Log.SyncUI(() => { rtb_Apply_Log.AppendText($"\n[{DateTime.Now.ToString("MM/dd/yyyy HH:mm tt")}] {msg}"); }, true);
        }

        private void SetProgress(int percent)
        {
            progressBar_Apply.SyncUI(() => { progressBar_Apply.Value = percent; progressBar_Apply.Update(); }, true);
            progressBar_Updates.SyncUI(() => { progressBar_Updates.Value = percent; progressBar_Updates.Update(); }, true);
        }

        private void ExePath_Browse(object sender, EventArgs e)
        {
            var files = WinFormsEvents.FilePath_Click($"Select {selectedPlatform.EmulatorName}.exe");
            if (files.Count > 0)
                txt_ExePath.Text = files.FirstOrDefault();

            AdvanceIfEmuValid();
        }

        private void PKGPath_Browse(object sender, EventArgs e)
        {
            var files = WinFormsEvents.FilePath_Click($"Select game file");
            if (files.Count > 0)
                txt_PKGPath.Text = files.FirstOrDefault();

            AdvanceIfPKGValid();
        }

        private void Path_TextChanged(object sender, EventArgs e)
        {
            AdvanceIfPKGValid();
            AdvanceIfEmuValid();
        }

        private void Checked_Changed(object sender, EventArgs e)
        {
            ResetPatches();
        }

        private void SelectedPatch_Changed(object sender, EventArgs e)
        {
            if (chkListBox_Patches.SelectedItem != null &&
                selectedGame.Patches.Any(x => x.Name.Equals(chkListBox_Patches.SelectedItem.ToString())))
            {
                var selectedPatch = selectedGame.Patches.Single(x => x.Name.Equals(chkListBox_Patches.SelectedItem.ToString()));

                rtb_Patches_Log.Clear();
                rtb_Patches_Log.AppendText($"{selectedPatch.Name} {selectedPatch.Version} by {selectedPatch.Author}\n\n" +
                    $"{selectedPatch.Description}");
            }
        }
    }
}
