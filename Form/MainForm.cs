using System;
using System.Windows.Forms;
using System.Threading;
using Electronic_registry.Action;

namespace Electronic_registry
{
    public partial class MainForm : Form
    {
        // поток для закрытия одной и открытия другой формы
        Thread f1f2;
        
        public MainForm()
        {
            InitializeComponent();
        }

        //закрываем текущую форму и открывает новую
        private void OpenListDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
            f1f2 = new Thread(OpenForm.OpenFormListDoctor);
            f1f2.SetApartmentState(ApartmentState.STA);
            f1f2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
    }
}
