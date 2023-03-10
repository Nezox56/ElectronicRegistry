using Electronic_registry.Action;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_registry
{
    public partial class FListDoctor : Form
    {
        Thread f1f2;
        public FListDoctor()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f1f2 = new Thread(OpenForm.OpenMainForm);
            f1f2.SetApartmentState(ApartmentState.STA);
            f1f2.Start();
        }
    }
}
