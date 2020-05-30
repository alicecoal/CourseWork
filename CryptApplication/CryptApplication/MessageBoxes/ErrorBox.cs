using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptApplication.MessageBoxes
{
    class ErrorBox
    {
        public ErrorBox()
        {
            MessageBox.Show("Вы не выбрали уровень защиты",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
