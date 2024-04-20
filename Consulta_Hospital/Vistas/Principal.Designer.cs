namespace Consulta_Hospital
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEspecialistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEspecialistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackgroundImage = global::Consulta_Hospital.Properties.Resources._360_F_360513715_BEbDvSencBZV1KrQtOf8k2RX91T70pq2;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.especialistasToolStripMenuItem,
            this.historialMedicoToolStripMenuItem,
            this.serviciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(233, 525);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarCitaToolStripMenuItem});
            this.citasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citasToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.chequeo;
            this.citasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(226, 36);
            this.citasToolStripMenuItem.Text = "Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // ingresarCitaToolStripMenuItem
            // 
            this.ingresarCitaToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.agregar__1_;
            this.ingresarCitaToolStripMenuItem.Name = "ingresarCitaToolStripMenuItem";
            this.ingresarCitaToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.ingresarCitaToolStripMenuItem.Text = "Ingresar Cita";
            this.ingresarCitaToolStripMenuItem.Click += new System.EventHandler(this.ingresarCitaToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agrearPacienteToolStripMenuItem,
            this.modificarPacienteToolStripMenuItem});
            this.pacienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacienteToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.paciente;
            this.pacienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(226, 36);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            // 
            // agrearPacienteToolStripMenuItem
            // 
            this.agrearPacienteToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.cita_medica;
            this.agrearPacienteToolStripMenuItem.Name = "agrearPacienteToolStripMenuItem";
            this.agrearPacienteToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.agrearPacienteToolStripMenuItem.Text = "Agrear Paciente";
            this.agrearPacienteToolStripMenuItem.Click += new System.EventHandler(this.agrearPacienteToolStripMenuItem_Click);
            // 
            // modificarPacienteToolStripMenuItem
            // 
            this.modificarPacienteToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.editar;
            this.modificarPacienteToolStripMenuItem.Name = "modificarPacienteToolStripMenuItem";
            this.modificarPacienteToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.modificarPacienteToolStripMenuItem.Text = "Modificar Paciente";
            this.modificarPacienteToolStripMenuItem.Click += new System.EventHandler(this.modificarPacienteToolStripMenuItem_Click);
            // 
            // especialistasToolStripMenuItem
            // 
            this.especialistasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEspecialistaToolStripMenuItem,
            this.modificarEspecialistaToolStripMenuItem});
            this.especialistasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.especialistasToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.medico;
            this.especialistasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.especialistasToolStripMenuItem.Name = "especialistasToolStripMenuItem";
            this.especialistasToolStripMenuItem.Size = new System.Drawing.Size(226, 36);
            this.especialistasToolStripMenuItem.Text = "Especialistas";
            this.especialistasToolStripMenuItem.Click += new System.EventHandler(this.especialistasToolStripMenuItem_Click);
            // 
            // agregarEspecialistaToolStripMenuItem
            // 
            this.agregarEspecialistaToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.doctor;
            this.agregarEspecialistaToolStripMenuItem.Name = "agregarEspecialistaToolStripMenuItem";
            this.agregarEspecialistaToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.agregarEspecialistaToolStripMenuItem.Text = "Agregar Especialista";
            this.agregarEspecialistaToolStripMenuItem.Click += new System.EventHandler(this.agregarEspecialistaToolStripMenuItem_Click);
            // 
            // modificarEspecialistaToolStripMenuItem
            // 
            this.modificarEspecialistaToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.editar;
            this.modificarEspecialistaToolStripMenuItem.Name = "modificarEspecialistaToolStripMenuItem";
            this.modificarEspecialistaToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.modificarEspecialistaToolStripMenuItem.Text = "Modificar Especialista";
            this.modificarEspecialistaToolStripMenuItem.Click += new System.EventHandler(this.modificarEspecialistaToolStripMenuItem_Click);
            // 
            // historialMedicoToolStripMenuItem
            // 
            this.historialMedicoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.historialMedicoToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.carpeta;
            this.historialMedicoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.historialMedicoToolStripMenuItem.Name = "historialMedicoToolStripMenuItem";
            this.historialMedicoToolStripMenuItem.Size = new System.Drawing.Size(226, 36);
            this.historialMedicoToolStripMenuItem.Text = "Historial Medico";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.serviciosToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.edificio_del_hospital;
            this.serviciosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(226, 36);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(236, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 522);
            this.panel1.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio Medico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrearPacienteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem modificarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEspecialistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEspecialistaToolStripMenuItem;
    }
}

