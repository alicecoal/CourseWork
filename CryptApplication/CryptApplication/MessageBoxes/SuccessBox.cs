using CryptApplication.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptApplication.MessageBoxes
{
    class SuccessBox
    {
        public SuccessBox(string msg)
        {
            DialogResult result = MessageBox.Show(msg,
                "Успешно",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);

            if(result == DialogResult.OK)
            {
                CustomProgressBar.update(0);
            }
            
        }
    }
}
