using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaClinica.Formularios;

namespace SistemaClinica
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            // Suscribir botones a acciones simples
            button1.Click += (s,e) => { new FrmPacientes().ShowDialog(); };
            button2.Click += (s,e) => { new FrmMedicos().ShowDialog(); };
            button6.Click += (s,e) => { new FrmCitas().ShowDialog(); };
            button7.Click += (s,e) => { new FrmHospitalizaciones().ShowDialog(); };
            button8.Click += (s,e) => { new FrmMedicamentos().ShowDialog(); };
            button9.Click += (s,e) => { new FrmLaboratorio().ShowDialog(); };
            button10.Click += (s,e) => { new FrmFacturacion().ShowDialog(); };
            button11.Click += (s,e) => { Application.Exit(); };
        }

        // Métodos esperados por el diseñador (InitializeComponent los referencia)
        private void button1_Click(object sender, EventArgs e) { new FrmPacientes().ShowDialog(); }
        private void button2_Click(object sender, EventArgs e) { new FrmMedicos().ShowDialog(); }
        private void button3_Click(object sender, EventArgs e) { MessageBox.Show("Formulario Enfermeros no implementado en esta versión."); }
        private void button4_Click(object sender, EventArgs e) { MessageBox.Show("Formulario Departamentos no implementado en esta versión."); }
        private void button5_Click(object sender, EventArgs e) { MessageBox.Show("Formulario Especialidades: revisar FrmMedicos para asociados."); }
        private void button6_Click(object sender, EventArgs e) { new FrmCitas().ShowDialog(); }
        private void button7_Click(object sender, EventArgs e) { new FrmHospitalizaciones().ShowDialog(); }
        private void button8_Click(object sender, EventArgs e) { new FrmMedicamentos().ShowDialog(); }
        private void button9_Click(object sender, EventArgs e) { new FrmLaboratorio().ShowDialog(); }
        private void button10_Click(object sender, EventArgs e) { new FrmFacturacion().ShowDialog(); }
        private void button11_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
