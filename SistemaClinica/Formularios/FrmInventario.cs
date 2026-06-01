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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
            Load += FrmInventario_Load;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
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

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Codigo";
            comboBox1.DataSource = DataSeeder.Medicamentos.Select(m => new { m.Codigo, m.Nombre }).ToList();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataSeeder.Inventarios.Select(i => new { i.Codigo, i.Medicamento, i.Existencia }).ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var inv = new Inventario { Codigo = textBox1.Text.Trim(), Medicamento = comboBox1.Text, Existencia = int.TryParse(textBox2.Text, out var ex) ? ex : 0 };
            if (string.IsNullOrEmpty(inv.Codigo)) { MessageBox.Show("Codigo es obligatorio"); return; }
            if (DataSeeder.Inventarios.Any(x => x.Codigo == inv.Codigo)) { MessageBox.Show("Codigo ya existe"); return; }
            DataSeeder.Inventarios.Add(inv);
            RefreshGrid();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Inventarios.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            existing.Medicamento = comboBox1.Text;
            existing.Existencia = int.TryParse(textBox2.Text, out var ex) ? ex : existing.Existencia;
            RefreshGrid();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Inventarios.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            DataSeeder.Inventarios.Remove(existing);
            RefreshGrid();
        }
    }
}
