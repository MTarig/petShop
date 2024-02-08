using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETSHOPcsharp
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(petshopDataSet.cliente);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro salvo!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados!");
                
            }
    
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirme exclusão do registro", "PetShop2024",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(petshopDataSet.cliente);
                }
            }
            catch (Exception)
            {
                clienteTableAdapter.Fill(petshopDataSet.cliente);
                MessageBox.Show("Registro não pode ser excluido!");
                
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Fotos (*.jpg; *.png;) | *.jpg; *.png; ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
            
        }

        private void cli_fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void cli_nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
