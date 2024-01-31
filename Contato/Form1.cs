using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de contatos 1.0.\nDesenvolvido por: Tiago Panis", "Sobre");
        }

        private void pessoasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contatoDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contatoDBDataSet.pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.contatoDBDataSet.pessoas);

        }

        private void contatoIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void contatoIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empresaLabel_Click(object sender, EventArgs e)
        {

        }

        private void empresaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void clienteCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void última_LigaçãoLabel_Click(object sender, EventArgs e)
        {

        }

        private void última_LigaçãoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
