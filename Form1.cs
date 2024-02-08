using PETSHOPcsharp.petshopDataSetTableAdapters;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(cliente);
            cliente.Show();


            panelSelect.Top = btnCliente.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();

            panelSelect.Top = btnHome.Top;
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            frmCadRaca Raca = new frmCadRaca();
            Raca.TopLevel = false;
            Raca.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(Raca);
            Raca.Show();

            panelSelect.Top = btnRaca.Top;
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            frmCadAnimal Animal = new frmCadAnimal();
            Animal.TopLevel = false;
            Animal.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(Animal);
            Animal.Show();

            panelSelect.Top = btnAnimal.Top;
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            frmCadServico servico = new frmCadServico();
            servico.TopLevel = false;
            servico.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(servico);
            servico.Show();

            panelSelect.Top = btnServico.Top;
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmCadAgendamento Agendamento = new frmCadAgendamento();
            Agendamento.TopLevel = false;
            Agendamento.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(Agendamento);
            Agendamento.Show();

            panelSelect.Top = btnAgenda.Top;
        }
    }
}
