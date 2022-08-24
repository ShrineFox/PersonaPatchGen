﻿using ShrineFox.IO;
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
        }

        private void PreviousPage()
        {
            tabControl_Main.SelectedIndex -= 1;
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
        }

        private void DownloadLog(string msg)
        {
            rtb_Updates_Log.SyncUI(() => { rtb_Updates_Log.AppendText(msg); }, true);
        }

        private void PatchLog(string msg)
        {
            rtb_Patches_Log.SyncUI(() => { rtb_Patches_Log.AppendText(msg); }, true);
        }

        private void SetProgress(int percent)
        {
            progressBar_Apply.SyncUI(() => { progressBar_Apply.Value = percent; progressBar_Apply.Update(); }, true);
            progressBar_Updates.SyncUI(() => { progressBar_Updates.Value = percent; progressBar_Updates.Update(); }, true);
        }

        private void ExePath_Browse(object sender, EventArgs e)
        {
            string path = ShrineFox.IO.WinFormsEvents.FilePath_Click($"Select your emulator's {selectedPlatform.EmulatorName}.exe");
            txt_ExePath.Text = path;

            AdvanceIfEmuValid();
        }

        private void PKGPath_Browse(object sender, EventArgs e)
        {
            string path = ShrineFox.IO.WinFormsEvents.FilePath_Click($"Select game file");
            txt_PKGPath.Text = path;

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