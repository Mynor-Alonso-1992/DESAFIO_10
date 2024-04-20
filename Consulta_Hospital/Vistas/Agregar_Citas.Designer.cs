namespace Consulta_Hospital.Vistas
{
    partial class Agregar_Citas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.APReloj = new System.Windows.Forms.Label();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.LHora = new System.Windows.Forms.Label();
            this.TBHora = new System.Windows.Forms.TextBox();
            this.TBDpi = new System.Windows.Forms.TextBox();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.CBEspecialidad = new System.Windows.Forms.ComboBox();
            this.LEspecialidad = new System.Windows.Forms.Label();
            this.LEspecialista = new System.Windows.Forms.Label();
            this.CBEspecialista = new System.Windows.Forms.ComboBox();
            this.TBSintomas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(13, 9);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "02",
            "03",
            "04",
            "05"});
            this.comboBox1.Location = new System.Drawing.Point(611, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(56, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.comboBox2.Location = new System.Drawing.Point(685, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(56, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(668, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // APReloj
            // 
            this.APReloj.BackColor = System.Drawing.Color.Transparent;
            this.APReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APReloj.Location = new System.Drawing.Point(747, 51);
            this.APReloj.Name = "APReloj";
            this.APReloj.Size = new System.Drawing.Size(46, 23);
            this.APReloj.TabIndex = 5;
            this.APReloj.Text = "AM";
            // 
            // TBFecha
            // 
            this.TBFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFecha.Location = new System.Drawing.Point(395, 139);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(163, 22);
            this.TBFecha.TabIndex = 6;
            this.TBFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.Transparent;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.Location = new System.Drawing.Point(297, 142);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(85, 16);
            this.LFecha.TabIndex = 7;
            this.LFecha.Text = "Fecha Cita:";
            // 
            // LHora
            // 
            this.LHora.AutoSize = true;
            this.LHora.BackColor = System.Drawing.Color.Transparent;
            this.LHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHora.Location = new System.Drawing.Point(299, 173);
            this.LHora.Name = "LHora";
            this.LHora.Size = new System.Drawing.Size(76, 16);
            this.LHora.TabIndex = 8;
            this.LHora.Text = "Hora Cita:";
            // 
            // TBHora
            // 
            this.TBHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBHora.Location = new System.Drawing.Point(395, 170);
            this.TBHora.Name = "TBHora";
            this.TBHora.ReadOnly = true;
            this.TBHora.Size = new System.Drawing.Size(98, 22);
            this.TBHora.TabIndex = 9;
            this.TBHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBDpi
            // 
            this.TBDpi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDpi.Location = new System.Drawing.Point(337, 230);
            this.TBDpi.MaxLength = 13;
            this.TBDpi.Name = "TBDpi";
            this.TBDpi.Size = new System.Drawing.Size(145, 22);
            this.TBDpi.TabIndex = 10;
            this.TBDpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBDpi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TBDpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDpi_KeyPress);
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.Color.Transparent;
            this.Lbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.Location = new System.Drawing.Point(296, 199);
            this.Lbuscar.Name = "Lbuscar";
            this.Lbuscar.Size = new System.Drawing.Size(269, 22);
            this.Lbuscar.TabIndex = 11;
            this.Lbuscar.Text = "Buscar Paciente por DPI";
            this.Lbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Consulta_Hospital.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(492, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 39);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBNombre
            // 
            this.TBNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNombre.Location = new System.Drawing.Point(307, 264);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.ReadOnly = true;
            this.TBNombre.Size = new System.Drawing.Size(248, 22);
            this.TBNombre.TabIndex = 13;
            // 
            // CBEspecialidad
            // 
            this.CBEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEspecialidad.FormattingEnabled = true;
            this.CBEspecialidad.Items.AddRange(new object[] {
            "",
            "Neurocirugía",
            "Cardiología",
            "Dermatología",
            "Endocrinología",
            "Gastroenterología",
            "Medicina Interna",
            "Nefrología",
            "Neumología",
            "Obstetricia y Ginecología",
            "Oftalmología",
            "Oncología",
            "Otorrinolaringología",
            "Pediatría",
            "Psiquiatría",
            "Radiología",
            "Reumatología",
            "Traumatología y Ortopedia",
            "Urología"});
            this.CBEspecialidad.Location = new System.Drawing.Point(445, 291);
            this.CBEspecialidad.Name = "CBEspecialidad";
            this.CBEspecialidad.Size = new System.Drawing.Size(113, 24);
            this.CBEspecialidad.TabIndex = 14;
            this.CBEspecialidad.SelectedIndexChanged += new System.EventHandler(this.CBEspecialidad_SelectedIndexChanged);
            // 
            // LEspecialidad
            // 
            this.LEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.LEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEspecialidad.Location = new System.Drawing.Point(296, 291);
            this.LEspecialidad.Name = "LEspecialidad";
            this.LEspecialidad.Size = new System.Drawing.Size(143, 23);
            this.LEspecialidad.TabIndex = 15;
            this.LEspecialidad.Text = "Especialidad:";
            this.LEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LEspecialista
            // 
            this.LEspecialista.BackColor = System.Drawing.Color.Transparent;
            this.LEspecialista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEspecialista.Location = new System.Drawing.Point(297, 325);
            this.LEspecialista.Name = "LEspecialista";
            this.LEspecialista.Size = new System.Drawing.Size(142, 23);
            this.LEspecialista.TabIndex = 16;
            this.LEspecialista.Text = "Especialista:";
            this.LEspecialista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBEspecialista
            // 
            this.CBEspecialista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEspecialista.FormattingEnabled = true;
            this.CBEspecialista.Location = new System.Drawing.Point(445, 324);
            this.CBEspecialista.Name = "CBEspecialista";
            this.CBEspecialista.Size = new System.Drawing.Size(113, 24);
            this.CBEspecialista.TabIndex = 17;
            // 
            // TBSintomas
            // 
            this.TBSintomas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBSintomas.Location = new System.Drawing.Point(304, 379);
            this.TBSintomas.Multiline = true;
            this.TBSintomas.Name = "TBSintomas";
            this.TBSintomas.Size = new System.Drawing.Size(248, 71);
            this.TBSintomas.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sintomas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(358, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Agregar Cita";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agregar_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Consulta_Hospital.Properties.Resources._9131696;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBSintomas);
            this.Controls.Add(this.CBEspecialista);
            this.Controls.Add(this.LEspecialista);
            this.Controls.Add(this.LEspecialidad);
            this.Controls.Add(this.CBEspecialidad);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbuscar);
            this.Controls.Add(this.TBDpi);
            this.Controls.Add(this.TBHora);
            this.Controls.Add(this.LHora);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.TBFecha);
            this.Controls.Add(this.APReloj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Calendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Citas";
            this.Text = "Agregar_Citas";
            this.Load += new System.EventHandler(this.Agregar_Citas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label APReloj;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LHora;
        private System.Windows.Forms.TextBox TBHora;
        private System.Windows.Forms.TextBox TBDpi;
        private System.Windows.Forms.Label Lbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.ComboBox CBEspecialidad;
        private System.Windows.Forms.Label LEspecialidad;
        private System.Windows.Forms.Label LEspecialista;
        private System.Windows.Forms.ComboBox CBEspecialista;
        private System.Windows.Forms.TextBox TBSintomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}