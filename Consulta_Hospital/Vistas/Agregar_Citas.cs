using Consulta_Hospital.Controladores;
using Consulta_Hospital.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Hospital.Vistas
{
    public partial class Agregar_Citas : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = null;
        public Agregar_Citas()
        {
            InitializeComponent();
            int dia = DateTime.Today.Day;
            int mes = DateTime.Today.Month;
            int ano = DateTime.Today.Year;
            Calendario.MinDate = new System.DateTime(ano, mes, dia, 0, 0, 0, 0);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex=0;
            TBFecha.Text= Calendario.SelectionStart.ToShortDateString();
            TBHora.Text = comboBox1.Text + ":" + comboBox2.Text+APReloj.Text;
        }

        private void Agregar_Citas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(int.Parse(comboBox1.SelectedItem.ToString()) > 5 && int.Parse(comboBox1.SelectedItem.ToString()) <12) 
            {
                APReloj.Text = "AM";

            }else
            {
                APReloj.Text = "PM";
            }
            TBHora.Text = comboBox1.Text + ":" + comboBox2.Text + APReloj.Text;
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            TBFecha.Text = e.Start.ToShortDateString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBHora.Text = comboBox1.Text + ":" + comboBox2.Text + APReloj.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se evalua que las teclas presionadas sean digitos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // si se cumple la condicion se escribe en el textbox
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!TBDpi.Text.Equals(""))
            {  
                MAgregar_Paciente paciente = new MAgregar_Paciente();
                paciente.DPI = TBDpi.Text;
                CAgregar_Pacientes Cpaciente=new CAgregar_Pacientes();
                if(Cpaciente.ListaPaciente(paciente).Rows.Count==0)
                {
                    MessageBox.Show("No se encontro el DPI, Por favor Inserta el Paciente", "Cuadro Informativo");
                }
                else
                {
                    TBNombre.Text = Cpaciente.ListaPaciente(paciente).Rows[0][1].ToString();
                }

        }
            else
            {
                MessageBox.Show("Campo DPI esta Vacio, Ingrese un DPI", "Cuadro Informativo");
            }
    }
        //se rellena el combo box especialista dependiente de la especialidad que se escoja
        private void CBEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            MEspecialista especialista = new MEspecialista();
            CEspecialista especialista1 = new CEspecialista();
            especialista.Especialidad=CBEspecialidad.Text;
            dt = especialista1.ListarEspecialistas2(especialista);
            //se coloca la tabla al combo box
            CBEspecialista.DataSource=dt;
            //se coloca el nombre del diplay
            CBEspecialista.DisplayMember = "Nombre_Completo";
            //se coloca el valor de la columna
            CBEspecialista.ValueMember = "Nombre_Completo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CCita cCita = new CCita();
            MCita mCita = new MCita();
            mCita.Fecha=TBFecha.Text;
            mCita.Hora=TBHora.Text;
            mCita.DPI = TBDpi.Text;
            mCita.Sintomas = TBSintomas.Text;
            mCita.Codigo_Especialista = int.Parse(dt.Rows[CBEspecialista.SelectedIndex][0].ToString());
            MessageBox.Show(cCita.InsertarCita(mCita), "Cuadro Informativo");
            int dia = DateTime.Today.Day;
            int mes = DateTime.Today.Month;
            int ano = DateTime.Today.Year;
            Calendario.MinDate = new System.DateTime(ano, mes, dia, 0, 0, 0, 0);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            TBFecha.Text = Calendario.SelectionStart.ToShortDateString();
            TBHora.Text = comboBox1.Text + ":" + comboBox2.Text + APReloj.Text;
            TBNombre.Text = "";
            TBDpi.Text = "";
            CBEspecialidad.Text = "";
            TBSintomas.Text = "";

        }
    }
}
