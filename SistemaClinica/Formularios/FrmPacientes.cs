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
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
            Load += FrmPacientes_Load;
            // Suscribir eventos que no vienen del diseñador
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            // Llenar grid con pacientes precargados
            dataGridView1.DataSource = DataSeeder.Pacientes.Select(p => new { p.Cedula, p.Nombres, p.Apellidos, p.FechaNacimiento, p.Sexo, p.Direccion, p.Telefono, p.Correo }).ToList();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataSeeder.Pacientes.Select(p => new { p.Cedula, p.Nombres, p.Apellidos, p.FechaNacimiento, p.Sexo, p.Direccion, p.Telefono, p.Correo }).ToList();
        }

        private Paciente ReadInputs()
        {
            return new Paciente
            {
                Cedula = textBox1.Text.Trim(),
                Nombres = textBox2.Text.Trim(),
                Apellidos = textBox3.Text.Trim(),
                FechaNacimiento = dateTimePicker1.Value.Date,
                Sexo = comboBox1.Text,
                Direccion = textBox4.Text.Trim(),
                Telefono = textBox5.Text.Trim(),
                Correo = textBox6.Text.Trim()
            };
        }

        private void FillInputs(Paciente p)
        {
            if (p == null) return;
            textBox1.Text = p.Cedula;
            textBox2.Text = p.Nombres;
            textBox3.Text = p.Apellidos;
            dateTimePicker1.Value = p.FechaNacimiento == default ? DateTime.Today : p.FechaNacimiento;
            comboBox1.Text = p.Sexo;
            textBox4.Text = p.Direccion;
            textBox5.Text = p.Telefono;
            textBox6.Text = p.Correo;
        }

        private void ClearInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.SelectedIndex = -1;
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // NUEVO
            ClearInputs();
            textBox1.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // GUARDAR (agrega si no existe)
            var paciente = ReadInputs();
            if (string.IsNullOrEmpty(paciente.Cedula))
            {
                MessageBox.Show("La cédula es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var exists = DataSeeder.Pacientes.FirstOrDefault(p => p.Cedula == paciente.Cedula);
            if (exists != null)
            {
                MessageBox.Show("Ya existe un paciente con esa cédula. Use Modificar para cambiarlo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataSeeder.Pacientes.Add(paciente);
            RefreshGrid();
            ClearInputs();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // MODIFICAR (basado en cédula)
            var paciente = ReadInputs();
            if (string.IsNullOrEmpty(paciente.Cedula))
            {
                MessageBox.Show("La cédula es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = DataSeeder.Pacientes.FirstOrDefault(p => p.Cedula == paciente.Cedula);
            if (existing == null)
            {
                MessageBox.Show("Paciente no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            existing.Nombres = paciente.Nombres;
            existing.Apellidos = paciente.Apellidos;
            existing.FechaNacimiento = paciente.FechaNacimiento;
            existing.Sexo = paciente.Sexo;
            existing.Direccion = paciente.Direccion;
            existing.Telefono = paciente.Telefono;
            existing.Correo = paciente.Correo;

            RefreshGrid();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // ELIMINAR (por cédula)
            var ced = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(ced))
            {
                MessageBox.Show("Ingrese la cédula del paciente a eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = DataSeeder.Pacientes.FirstOrDefault(p => p.Cedula == ced);
            if (existing == null)
            {
                MessageBox.Show("Paciente no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resp = MessageBox.Show($"¿Eliminar paciente {existing.Nombres} {existing.Apellidos}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                DataSeeder.Pacientes.Remove(existing);
                RefreshGrid();
                ClearInputs();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // BUSCAR por cédula o nombre
            var q = textBox1.Text.Trim();
            var list = DataSeeder.Pacientes.Where(p => p.Cedula.Contains(q) || p.Nombres.Contains(q) || p.Apellidos.Contains(q)).Select(p => new { p.Cedula, p.Nombres, p.Apellidos, p.FechaNacimiento, p.Sexo, p.Direccion, p.Telefono, p.Correo }).ToList();
            dataGridView1.DataSource = list;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var ced = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(ced)) return;
            var p = DataSeeder.Pacientes.FirstOrDefault(x => x.Cedula == ced);
            FillInputs(p);
        }

        // Métodos llamados por el diseñador -> delegan a la implementación central
        private void button1_Click(object sender, EventArgs e) => Button1_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => Button2_Click(sender, e);
        private void button3_Click(object sender, EventArgs e) => Button3_Click(sender, e);
        private void button4_Click(object sender, EventArgs e) => Button4_Click(sender, e);
        private void button5_Click(object sender, EventArgs e) => Button5_Click(sender, e);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

