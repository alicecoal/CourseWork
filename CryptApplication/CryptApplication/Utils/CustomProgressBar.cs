using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Utils
{
    class CustomProgressBar
    {
        static System.Windows.Forms.ProgressBar progress;

        internal static void setProgress(System.Windows.Forms.ProgressBar progress2)
        {
            progress = progress2;
        }

        internal static void update(int Value)
        {
            progress.Value = Value;
        }
    }
}
