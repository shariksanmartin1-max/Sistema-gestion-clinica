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
    public partial class FrmLaboratorio : Form
    {
        public FrmLaboratorio()
        {
            InitializeComponent();
            Load += FrmLaboratorio_Load;
            // los botones del diseñador llaman a métodos con los mismos nombres
            // para mantener compatibilidad con el evento que auto-genera el diseñador
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void FrmLaboratorio_Load(object sender, EventArgs e)
        {
            // Cargar combos y grid con datos precargados
            comboBox1.DisplayMember = "Nombres";
            comboBox1.ValueMember = "Cedula";
            comboBox1.DataSource = DataSeeder.Pacientes.ToList();

            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Codigo";
            comboBox2.DataSource = DataSeeder.Examenes.Select(x => x.TipoExamen).Distinct().Select((t, i) => new { Codigo = "TE" + i.ToString("D2"), Nombre = t }).ToList();

            dataGridView1.DataSource = DataSeeder.Examenes.Select(x => new { x.Codigo, x.Paciente, x.TipoExamen }).ToList();
        }

        private void button1_Click(object sender, EventArgs e) => Button1_Click(sender, e);

        private void button2_Click(object sender, EventArgs e) => Button2_Click(sender, e);

        private void button3_Click(object sender, EventArgs e) => Button3_Click(sender, e);

        private void Button1_Click(object sender, EventArgs e)
        {
            // GUARDAR examen
            var ex = new ExamenLaboratorio { Codigo = textBox1.Text.Trim(), Paciente = comboBox1.SelectedValue?.ToString(), TipoExamen = comboBox2.Text };
            if (string.IsNullOrEmpty(ex.Codigo)) { MessageBox.Show("Codigo es obligatorio"); return; }
            if (DataSeeder.Examenes.Any(x => x.Codigo == ex.Codigo)) { MessageBox.Show("Codigo ya existe"); return; }
            DataSeeder.Examenes.Add(ex);
            // opcional: guardar resultado
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                DataSeeder.Resultados.Add(new ResultadoLaboratorio { Codigo = "R" + ex.Codigo, Resultado = textBox2.Text.Trim() });
            }
            RefreshGrid();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // MODIFICAR
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Examenes.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            existing.Paciente = comboBox1.SelectedValue?.ToString();
            existing.TipoExamen = comboBox2.Text;
            // actualizar/añadir resultado
            var r = DataSeeder.Resultados.FirstOrDefault(x => x.Codigo == "R" + codigo);
            if (r == null && !string.IsNullOrWhiteSpace(textBox2.Text)) DataSeeder.Resultados.Add(new ResultadoLaboratorio { Codigo = "R" + codigo, Resultado = textBox2.Text.Trim() });
            if (r != null) r.Resultado = textBox2.Text.Trim();
            RefreshGrid();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // ELIMINAR
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Examenes.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            DataSeeder.Examenes.Remove(existing);
            var r = DataSeeder.Resultados.FirstOrDefault(x => x.Codigo == "R" + codigo);
            if (r != null) DataSeeder.Resultados.Remove(r);
            RefreshGrid();
            // Limpiar formulario después de eliminar
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataSeeder.Examenes.Select(x => new { x.Codigo, x.Paciente, x.TipoExamen }).ToList();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var codigo = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(codigo)) return;
            var ex = DataSeeder.Examenes.FirstOrDefault(x => x.Codigo == codigo);
            if (ex == null) return;
            textBox1.Text = ex.Codigo;
            comboBox1.SelectedValue = ex.Paciente;
            comboBox2.Text = ex.TipoExamen;
            var r = DataSeeder.Resultados.FirstOrDefault(x => x.Codigo == "R" + codigo);
            textBox2.Text = r?.Resultado ?? string.Empty;
        }
    }
}

