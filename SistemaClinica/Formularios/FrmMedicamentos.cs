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
    public partial class FrmMedicamentos : Form
    {
        public FrmMedicamentos()
        {
            InitializeComponent();
            Load += FrmMedicamentos_Load;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
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

        private void FrmMedicamentos_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataSeeder.Medicamentos.Select(m => new { m.Codigo, m.Nombre, m.Stock, m.Precio }).ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // GUARDAR
            var med = new Medicamento { Codigo = textBox1.Text.Trim(), Nombre = textBox2.Text.Trim(), Stock = int.TryParse(textBox3.Text, out var s) ? s : 0, Precio = decimal.TryParse(textBox4.Text, out var p) ? p : 0m };
            if (string.IsNullOrEmpty(med.Codigo)) { MessageBox.Show("Codigo es obligatorio"); return; }
            if (DataSeeder.Medicamentos.Any(x => x.Codigo == med.Codigo)) { MessageBox.Show("Codigo ya existe"); return; }
            DataSeeder.Medicamentos.Add(med);
            RefreshGrid();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // MODIFICAR
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Medicamentos.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            existing.Nombre = textBox2.Text.Trim();
            existing.Stock = int.TryParse(textBox3.Text, out var s) ? s : existing.Stock;
            existing.Precio = decimal.TryParse(textBox4.Text, out var p) ? p : existing.Precio;
            RefreshGrid();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // ELIMINAR
            var codigo = textBox1.Text.Trim();
            var existing = DataSeeder.Medicamentos.FirstOrDefault(x => x.Codigo == codigo);
            if (existing == null) { MessageBox.Show("No encontrado"); return; }
            DataSeeder.Medicamentos.Remove(existing);
            RefreshGrid();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // BUSCAR
            var qCode = textBox1.Text.Trim();
            var qName = textBox2.Text.Trim();
            var list = DataSeeder.Medicamentos.Where(m => m.Codigo.Contains(qCode) || m.Nombre.Contains(qName)).Select(m => new { m.Codigo, m.Nombre, m.Stock, m.Precio }).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }
    }
}
