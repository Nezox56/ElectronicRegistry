using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Electronic_registry.Action
{
    internal class OpenForm
    {
        public static void OpenFormListDoctor()
        {
            Application.Run(new FListDoctor());
        }

        public static void OpenMainForm() 
        {
            Application.Run(new MainForm());
        }
    }
}
