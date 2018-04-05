using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Contatos'. Você pode movê-la ou removê-la conforme necessário.
            this.contatosTableAdapter.Fill(this.database1DataSet.Contatos);
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Contatos'. Você pode movê-la ou removê-la conforme necessário.
            this.contatosTableAdapter.Fill(this.database1DataSet.Contatos);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agenda versão 1.0.0 \n Written for TLEDS Corporation.");
        }

        private void contatosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contatosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void contatosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contatosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.contatosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void contatosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
