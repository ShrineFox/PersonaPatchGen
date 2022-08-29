using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaPatchGen
{
    public partial class WizardForm
    {
        private void Patch3DSGame()
        {
            Apply3DSPatches();
            FTPCodeBin();
        }

        private void Apply3DSPatches()
        {
            // Copy code.bin to Output

            List<GamePatch> selectedPatches = GetPatchCombos().FirstOrDefault();
            if (selectedPatches.Any(x => x.ShortName.Equals("canonNames")))
            {
                // Modify code.bin with names
                using (PQNameForm form = new PQNameForm())
                {
                    form.Show();

                    //string p3HeroName = form.P3HERO;
                }
            }
        }

        private void FTPCodeBin()
        {
            throw new NotImplementedException();
        }
    }
}
