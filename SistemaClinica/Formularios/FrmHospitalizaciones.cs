using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaClinica.Infrastructure;
using SistemaClinica.Entidades;

namespace SistemaClinica.Formularios
{
    public partial class FrmHospitalizaciones : Form
    {
        public FrmHospitalizaciones()
        {
            InitializeComponent();
            Load += FrmHospitalizaciones_Load;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmHospitalizaciones_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Nombres";
            comboBox1.ValueMember = "Cedula";
            comboBox1.DataSource = DataSeeder.Pacientes.ToList();

            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Codigo";
            comboBox2.DataSource = DataSeeder.Inventarios.Select(i => new { Codigo = i.Codigo, Nombre = i.Medicamento }).ToList();

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataSeeder.Hospitalizaciones.Select(h => new { h.Codigo, h.Paciente, h.Habitacion }).ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var h = new Hospitalizacion { Codigo = textBox1.Text.Trim(), Paciente = comboBox1.SelectedValue?.ToString(), Habitacion = comboBox2.Text };
            if (string.IsNullOrEmpty(h.Codigo)) { MessageBox.Show("Codigo es obligatorio"); return; }
            if (DataSeeder.Hospitalizaciones.Any(x => x.Codigo == h.Codigo)) { MessageBox.Show("Codigo ya existe"); return; }
            DataSeeder.Hospitalizaciones.Add(h);
            RefreshGrid();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Hospitalizaciones.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            existing.Paciente = comboBox1.SelectedValue?.ToString();
            existing.Habitacion = comboBox2.Text;
            RefreshGrid();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Hospitalizaciones.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            DataSeeder.Hospitalizaciones.Remove(existing);
            RefreshGrid();
        }
    }
}
