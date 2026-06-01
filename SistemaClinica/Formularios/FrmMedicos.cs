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
    public partial class FrmMedicos : Form
    {
        public FrmMedicos()
        {
            InitializeComponent();
            Load += FrmMedicos_Load;
            // Suscribir botones
            button1.Click += Button1_Click; // NUEVO
            button2.Click += Button2_Click; // GUARDAR
            button3.Click += Button3_Click; // MODIFICAR
            button4.Click += Button4_Click; // ELIMINAR
            button5.Click += Button5_Click; // BUSCAR
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void FrmMedicos_Load(object sender, EventArgs e)
        {
            // Llenar combo de especialidades y grid de medicos
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Codigo";
            comboBox1.DataSource = DataSeeder.Especialidades.ToList();

            dataGridView1.DataSource = DataSeeder.Medicos.Select(m => new { m.Codigo, m.Nombres, m.Apellidos, m.Especialidad, m.Telefono }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var codigo = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(codigo)) return;
            var m = DataSeeder.Medicos.FirstOrDefault(x => x.Codigo == codigo);
            if (m == null) return;
            textBox1.Text = m.Codigo;
            textBox2.Text = m.Nombres;
            textBox3.Text = m.Apellidos;
            comboBox1.Text = m.Especialidad;
            textBox4.Text = m.Telefono;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // NUEVO
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); comboBox1.SelectedIndex = -1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // GUARDAR
            var med = new Medico { Codigo = textBox1.Text.Trim(), Nombres = textBox2.Text.Trim(), Apellidos = textBox3.Text.Trim(), Especialidad = comboBox1.Text, Telefono = textBox4.Text.Trim() };
            if (string.IsNullOrEmpty(med.Codigo)) { MessageBox.Show("Codigo es obligatorio"); return; }
            if (DataSeeder.Medicos.Any(x => x.Codigo == med.Codigo)) { MessageBox.Show("Codigo ya existe"); return; }
            DataSeeder.Medicos.Add(med);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataSeeder.Medicos.Select(m => new { m.Codigo, m.Nombres, m.Apellidos, m.Especialidad, m.Telefono }).ToList();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // MODIFICAR
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Medicos.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            existing.Nombres = textBox2.Text.Trim();
            existing.Apellidos = textBox3.Text.Trim();
            existing.Especialidad = comboBox1.Text;
            existing.Telefono = textBox4.Text.Trim();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataSeeder.Medicos.Select(m => new { m.Codigo, m.Nombres, m.Apellidos, m.Especialidad, m.Telefono }).ToList();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // ELIMINAR
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Medicos.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            DataSeeder.Medicos.Remove(existing);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataSeeder.Medicos.Select(m => new { m.Codigo, m.Nombres, m.Apellidos, m.Especialidad, m.Telefono }).ToList();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // BUSCAR por codigo o nombre
            var q = textBox1.Text.Trim();
            var list = DataSeeder.Medicos.Where(m => m.Codigo.Contains(q) || m.Nombres.Contains(q) || m.Apellidos.Contains(q)).Select(m => new { m.Codigo, m.Nombres, m.Apellidos, m.Especialidad, m.Telefono }).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }
    }
}

