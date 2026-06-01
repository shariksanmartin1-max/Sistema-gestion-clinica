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
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();
            Load += FrmCitas_Load;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
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

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Nombres";
            comboBox1.ValueMember = "Cedula";
            comboBox1.DataSource = DataSeeder.Pacientes.ToList();

            comboBox2.DisplayMember = "Nombres";
            comboBox2.ValueMember = "Codigo";
            comboBox2.DataSource = DataSeeder.Medicos.ToList();

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataSeeder.Citas.Select(c => new { c.Codigo, c.CedulaPaciente, c.CodigoMedico, c.Fecha, c.Estado }).ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var cita = new Cita { Codigo = textBox1.Text.Trim(), CedulaPaciente = comboBox1.SelectedValue?.ToString(), CodigoMedico = comboBox2.SelectedValue?.ToString(), Fecha = dateTimePicker1.Value, Estado = comboBox3.Text };
            if (string.IsNullOrEmpty(cita.Codigo)) { MessageBox.Show("Codigo es obligatorio"); return; }
            if (DataSeeder.Citas.Any(x => x.Codigo == cita.Codigo)) { MessageBox.Show("Codigo ya existe"); return; }
            DataSeeder.Citas.Add(cita);
            RefreshGrid();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Citas.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            existing.CedulaPaciente = comboBox1.SelectedValue?.ToString();
            existing.CodigoMedico = comboBox2.SelectedValue?.ToString();
            existing.Fecha = dateTimePicker1.Value;
            existing.Estado = comboBox3.Text;
            RefreshGrid();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Citas.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            DataSeeder.Citas.Remove(existing);
            RefreshGrid();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var codigo = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(codigo)) return;
            var c = DataSeeder.Citas.FirstOrDefault(x => x.Codigo == codigo);
            if (c == null) return;
            textBox1.Text = c.Codigo;
            comboBox1.SelectedValue = c.CedulaPaciente;
            comboBox2.SelectedValue = c.CodigoMedico;
            dateTimePicker1.Value = c.Fecha;
            comboBox3.Text = c.Estado;
        }
    }
}
