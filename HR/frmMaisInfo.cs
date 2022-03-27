using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
    public partial class frmMaisInfo : Form
    {
        public Funcionario funcionario { get; private set; }
        public frmMaisInfo(Funcionario generico)
        {
            InitializeComponent();
            lblTeste.Text = generico.nome;
        }
    }
}
