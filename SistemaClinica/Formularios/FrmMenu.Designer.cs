namespace SistemaClinica
{
    partial class FrmMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesPorSexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralDeMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosPorEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasPorEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesHospitalizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesOcupadasYDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosConStockBajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exámenesRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exámenesPorTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "PACIENTES";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "MEDICOS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(451, 103);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 49);
            this.button6.TabIndex = 5;
            this.button6.Text = "CITAS";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(128, 217);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "HOSPITALIZACIONES";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(340, 217);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 49);
            this.button8.TabIndex = 7;
            this.button8.Text = "MEDICAMENTOS";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(141, 340);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(137, 47);
            this.button9.TabIndex = 8;
            this.button9.Text = "LABORATORIO";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(304, 340);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(138, 47);
            this.button10.TabIndex = 9;
            this.button10.Text = "FACTURACION";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(470, 340);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 47);
            this.button11.TabIndex = 10;
            this.button11.Text = "SALIR";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.medicosToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.hospitalizacionesToolStripMenuItem,
            this.medicamentosToolStripMenuItem,
            this.laboratorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoGeneralDePacientesToolStripMenuItem,
            this.pacientesPorSexoToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // listadoGeneralDePacientesToolStripMenuItem
            // 
            this.listadoGeneralDePacientesToolStripMenuItem.Name = "listadoGeneralDePacientesToolStripMenuItem";
            this.listadoGeneralDePacientesToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.listadoGeneralDePacientesToolStripMenuItem.Text = "Listado General de Pacientes";
            this.listadoGeneralDePacientesToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDePacientesToolStripMenuItem_Click);
            this.listadoGeneralDePacientesToolStripMenuItem.Click -= new System.EventHandler(this.listadoGeneralDePacientesToolStripMenuItem_Click);
            this.listadoGeneralDePacientesToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDePacientesToolStripMenuItem_Click_Impl);
            // 
            // pacientesPorSexoToolStripMenuItem
            // 
            this.pacientesPorSexoToolStripMenuItem.Name = "pacientesPorSexoToolStripMenuItem";
            this.pacientesPorSexoToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.pacientesPorSexoToolStripMenuItem.Text = "Pacientes por Sexo";
            this.pacientesPorSexoToolStripMenuItem.Click += new System.EventHandler(this.pacientesPorSexoToolStripMenuItem_Click);
            this.pacientesPorSexoToolStripMenuItem.Click -= new System.EventHandler(this.pacientesPorSexoToolStripMenuItem_Click);
            this.pacientesPorSexoToolStripMenuItem.Click += new System.EventHandler(this.pacientesPorSexoToolStripMenuItem_Click_Impl);
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoGeneralDeMédicosToolStripMenuItem,
            this.médicosPorEspecialidadToolStripMenuItem});
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.medicosToolStripMenuItem.Text = "Medicos";
            // 
            // listadoGeneralDeMédicosToolStripMenuItem
            // 
            this.listadoGeneralDeMédicosToolStripMenuItem.Name = "listadoGeneralDeMédicosToolStripMenuItem";
            this.listadoGeneralDeMédicosToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.listadoGeneralDeMédicosToolStripMenuItem.Text = "Listado General de Médicos";
            this.listadoGeneralDeMédicosToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDeMédicosToolStripMenuItem_Click);
            this.listadoGeneralDeMédicosToolStripMenuItem.Click -= new System.EventHandler(this.listadoGeneralDeMédicosToolStripMenuItem_Click);
            this.listadoGeneralDeMédicosToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDeMédicosToolStripMenuItem_Click_Impl);
            // 
            // médicosPorEspecialidadToolStripMenuItem
            // 
            this.médicosPorEspecialidadToolStripMenuItem.Name = "médicosPorEspecialidadToolStripMenuItem";
            this.médicosPorEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.médicosPorEspecialidadToolStripMenuItem.Text = "Médicos por Especialidad";
            this.médicosPorEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.médicosPorEspecialidadToolStripMenuItem_Click);
            this.médicosPorEspecialidadToolStripMenuItem.Click -= new System.EventHandler(this.médicosPorEspecialidadToolStripMenuItem_Click);
            this.médicosPorEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.médicosPorEspecialidadToolStripMenuItem_Click_Impl);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasPorFechaToolStripMenuItem,
            this.citasPorEstadoToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // citasPorFechaToolStripMenuItem
            // 
            this.citasPorFechaToolStripMenuItem.Name = "citasPorFechaToolStripMenuItem";
            this.citasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.citasPorFechaToolStripMenuItem.Text = "Citas por Fecha";
            this.citasPorFechaToolStripMenuItem.Click += new System.EventHandler(this.citasPorFechaToolStripMenuItem_Click);
            this.citasPorFechaToolStripMenuItem.Click -= new System.EventHandler(this.citasPorFechaToolStripMenuItem_Click);
            this.citasPorFechaToolStripMenuItem.Click += new System.EventHandler(this.citasPorFechaToolStripMenuItem_Click_Impl);
            // 
            // citasPorEstadoToolStripMenuItem
            // 
            this.citasPorEstadoToolStripMenuItem.Name = "citasPorEstadoToolStripMenuItem";
            this.citasPorEstadoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.citasPorEstadoToolStripMenuItem.Text = "Citas por Estado";
            this.citasPorEstadoToolStripMenuItem.Click += new System.EventHandler(this.citasPorEstadoToolStripMenuItem_Click);
            this.citasPorEstadoToolStripMenuItem.Click -= new System.EventHandler(this.citasPorEstadoToolStripMenuItem_Click);
            this.citasPorEstadoToolStripMenuItem.Click += new System.EventHandler(this.citasPorEstadoToolStripMenuItem_Click_Impl);
            // 
            // hospitalizacionesToolStripMenuItem
            // 
            this.hospitalizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesHospitalizadosToolStripMenuItem,
            this.habitacionesOcupadasYDisponiblesToolStripMenuItem});
            this.hospitalizacionesToolStripMenuItem.Name = "hospitalizacionesToolStripMenuItem";
            this.hospitalizacionesToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.hospitalizacionesToolStripMenuItem.Text = "Hospitalizaciones";
            // 
            // pacientesHospitalizadosToolStripMenuItem
            // 
            this.pacientesHospitalizadosToolStripMenuItem.Name = "pacientesHospitalizadosToolStripMenuItem";
            this.pacientesHospitalizadosToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.pacientesHospitalizadosToolStripMenuItem.Text = "Pacientes Hospitalizados";
            this.pacientesHospitalizadosToolStripMenuItem.Click += new System.EventHandler(this.pacientesHospitalizadosToolStripMenuItem_Click);
            this.pacientesHospitalizadosToolStripMenuItem.Click -= new System.EventHandler(this.pacientesHospitalizadosToolStripMenuItem_Click);
            this.pacientesHospitalizadosToolStripMenuItem.Click += new System.EventHandler(this.pacientesHospitalizadosToolStripMenuItem_Click_Impl);
            // 
            // habitacionesOcupadasYDisponiblesToolStripMenuItem
            // 
            this.habitacionesOcupadasYDisponiblesToolStripMenuItem.Name = "habitacionesOcupadasYDisponiblesToolStripMenuItem";
            this.habitacionesOcupadasYDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.habitacionesOcupadasYDisponiblesToolStripMenuItem.Text = "Habitaciones Ocupadas y Disponibles";
            this.habitacionesOcupadasYDisponiblesToolStripMenuItem.Click += new System.EventHandler(this.habitacionesOcupadasYDisponiblesToolStripMenuItem_Click);
            this.habitacionesOcupadasYDisponiblesToolStripMenuItem.Click -= new System.EventHandler(this.habitacionesOcupadasYDisponiblesToolStripMenuItem_Click);
            this.habitacionesOcupadasYDisponiblesToolStripMenuItem.Click += new System.EventHandler(this.habitacionesOcupadasYDisponiblesToolStripMenuItem_Click_Impl);
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeMedicamentosToolStripMenuItem,
            this.medicamentosConStockBajoToolStripMenuItem});
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            this.medicamentosToolStripMenuItem.Click += new System.EventHandler(this.medicamentosToolStripMenuItem_Click);
            // 
            // listadoDeMedicamentosToolStripMenuItem
            // 
            this.listadoDeMedicamentosToolStripMenuItem.Name = "listadoDeMedicamentosToolStripMenuItem";
            this.listadoDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.listadoDeMedicamentosToolStripMenuItem.Text = "Listado de Medicamentos";
            this.listadoDeMedicamentosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeMedicamentosToolStripMenuItem_Click);
            this.listadoDeMedicamentosToolStripMenuItem.Click -= new System.EventHandler(this.listadoDeMedicamentosToolStripMenuItem_Click);
            this.listadoDeMedicamentosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeMedicamentosToolStripMenuItem_Click_Impl);
            // 
            // medicamentosConStockBajoToolStripMenuItem
            // 
            this.medicamentosConStockBajoToolStripMenuItem.Name = "medicamentosConStockBajoToolStripMenuItem";
            this.medicamentosConStockBajoToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.medicamentosConStockBajoToolStripMenuItem.Text = "Medicamentos con Stock Bajo";
            this.medicamentosConStockBajoToolStripMenuItem.Click += new System.EventHandler(this.medicamentosConStockBajoToolStripMenuItem_Click);
            this.medicamentosConStockBajoToolStripMenuItem.Click -= new System.EventHandler(this.medicamentosConStockBajoToolStripMenuItem_Click);
            this.medicamentosConStockBajoToolStripMenuItem.Click += new System.EventHandler(this.medicamentosConStockBajoToolStripMenuItem_Click_Impl);
            // 
            // laboratorioToolStripMenuItem
            // 
            this.laboratorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exámenesRealizadosToolStripMenuItem,
            this.exámenesPorTipoToolStripMenuItem});
            this.laboratorioToolStripMenuItem.Name = "laboratorioToolStripMenuItem";
            this.laboratorioToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.laboratorioToolStripMenuItem.Text = "Laboratorio";
            // 
            // exámenesRealizadosToolStripMenuItem
            // 
            this.exámenesRealizadosToolStripMenuItem.Name = "exámenesRealizadosToolStripMenuItem";
            this.exámenesRealizadosToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exámenesRealizadosToolStripMenuItem.Text = "Exámenes Realizados";
            this.exámenesRealizadosToolStripMenuItem.Click += new System.EventHandler(this.exámenesRealizadosToolStripMenuItem_Click);
            this.exámenesRealizadosToolStripMenuItem.Click -= new System.EventHandler(this.exámenesRealizadosToolStripMenuItem_Click);
            this.exámenesRealizadosToolStripMenuItem.Click += new System.EventHandler(this.exámenesRealizadosToolStripMenuItem_Click_Impl);
            // 
            // exámenesPorTipoToolStripMenuItem
            // 
            this.exámenesPorTipoToolStripMenuItem.Name = "exámenesPorTipoToolStripMenuItem";
            this.exámenesPorTipoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exámenesPorTipoToolStripMenuItem.Text = "Exámenes por Tipo";
            this.exámenesPorTipoToolStripMenuItem.Click += new System.EventHandler(this.exámenesPorTipoToolStripMenuItem_Click);
            this.exámenesPorTipoToolStripMenuItem.Click -= new System.EventHandler(this.exámenesPorTipoToolStripMenuItem_Click);
            this.exámenesPorTipoToolStripMenuItem.Click += new System.EventHandler(this.exámenesPorTipoToolStripMenuItem_Click_Impl);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoGeneralDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesPorSexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoGeneralDeMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosPorEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasPorEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesHospitalizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesOcupadasYDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosConStockBajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exámenesRealizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exámenesPorTipoToolStripMenuItem;
    }
}

