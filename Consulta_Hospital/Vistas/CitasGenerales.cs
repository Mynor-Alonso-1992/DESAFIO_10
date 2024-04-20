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
using System.Xml.Linq;

namespace Consulta_Hospital.Vistas
{
    public partial class CitasGenerales : Form
    {
        DataTable dt =new DataTable();
        int x = 0;
        public CitasGenerales()
        {
            InitializeComponent();
            crearvista();
        }

        public void crearvista()
        {
            MCita mCita = new MCita();
            Font replacementFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Reportes reportes = new Reportes();
            mCita.Fecha = dateTimePicker1.Value.Date.ToShortDateString();
            dt= reportes.HorarioGeneral(mCita).Copy();
            Label[] labelarray = new Label[dt.Rows.Count];
            DataTable dttemporal = new DataTable();
            dttemporal = dt.Copy();
            dttemporal.Columns.Remove("Especialista");
            DataGridView dt1 = new DataGridView();
            dt1.DataSource = dt.Rows[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                labelarray[i]=new Label();
                labelarray[i].AutoSize = true;
                labelarray[i].Font = replacementFont;
                x = x + (this.Width / dt.Rows.Count)/2;
                labelarray[i].Location = new System.Drawing.Point(x,5);
                x = x + 50;
                labelarray[i].Text = dt.Rows[i][2].ToString(); ;
                labelarray[i].Show();
                panel1.Controls.Add(labelarray[i]);
                panel1.Controls.Add(dt1);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            crearvista();
        }
    }
}
