using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaPatchGen
{
    public partial class WizardForm
    {
        private void PatchPS2Game()
        {
            ExtractISO();
            CreatePNACH();
            if (radio_Console.Checked)
            {
                PatchExecutable();
                RepackISO();
            }
            else
            {
                UpdatePCSX2Settings();
            }
        }

        private void ExtractISO()
        {
            throw new NotImplementedException();
        }

        private void CreatePNACH()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
