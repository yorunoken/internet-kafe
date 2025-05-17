using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Kafe_Proje.Utils
{
    class MessageBoxes
    {
        static internal void ErrorBox(string errorDesc)
        {
            MessageBox.Show(errorDesc, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
