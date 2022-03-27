using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HR
{
    public partial class frmMaisInfo : Form
    {
        Thread thread;
        public Funcionario funcionario { get; private set; }
        public frmMaisInfo(Funcionario generico)
        {
            InitializeComponent();
            lblGen.Text = generico.nome;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
            /*
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
            */
        }
        private void OpenForm()
        {
            Application.Run(new Form1());
        }
    }
}
