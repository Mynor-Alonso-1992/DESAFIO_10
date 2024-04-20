using Consulta_Hospital.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Consulta_Hospital
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void agrearPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VAgregarPaciente Fpaciente = new VAgregarPaciente();
            panel1.Controls.Clear();
            Fpaciente.TopLevel = false;
            panel1.Controls.Add(Fpaciente);
            Fpaciente.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitasGenerales CG = new CitasGenerales();
            panel1.Controls.Clear();
            CG.TopLevel = false;
            panel1.Controls.Add(CG);
            CG.Show();
        }

        private void modificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificar_paciente mpaciente = new modificar_paciente();
            panel1.Controls.Clear();
            mpaciente.TopLevel = false;
            panel1.Controls.Add(mpaciente);
            mpaciente.Show();
        }

        private void especialistasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarEspecialistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Especialista aEspecialista = new Agregar_Especialista();
            panel1.Controls.Clear();
            aEspecialista.TopLevel = false;
            panel1.Controls.Add(aEspecialista);
            aEspecialista.Show();
        }

        private void modificarEspecialistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Especialista aEspecialista = new Modificar_Especialista();
            panel1.Controls.Clear();
            aEspecialista.TopLevel = false;
            panel1.Controls.Add(aEspecialista);
            aEspecialista.Show();
        }

        private void ingresarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Citas AgregarCita = new Agregar_Citas();
            panel1.Controls.Clear();
            AgregarCita.TopLevel = false;
            panel1.Controls.Add(AgregarCita);
            AgregarCita.Show();
        }
    }
}
