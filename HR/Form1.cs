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
    public partial class Form1 : Form
    {
        List<Funcionario> listaFuncionarios;
        public Form1()
        {
            InitializeComponent();
            listaFuncionarios = new List<Funcionario>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(listaFuncionarios.Count + 1, txtNome.Text, txtCPF.Text, new Endereco(txtRua.Text, txtNumero.Text, txtComplemento.Text, txtCEP.Text));
            listaFuncionarios.Add(funcionario);
            cbxFuncionarios.Items.Add(funcionario.nome);
            txtNome.Text = "";
            txtCPF.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtCEP.Text = "";
            MessageBox.Show("Funcionário criado com sucesso!");
        }

        private void btnMaisInfo_Click(object sender, EventArgs e)
        {
            frmMaisInfo frmMaisInformacoes = new frmMaisInfo(listaFuncionarios[cbxFuncionarios.SelectedIndex]);
            frmMaisInformacoes.ShowDialog();
        }
    }
}
