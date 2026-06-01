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
    public partial class FrmFacturacion : Form
    {
        public FrmFacturacion()
        {
            InitializeComponent();
            Load += FrmFacturacion_Load;
            button1.Click += Button1_Click; // CALCULAR
            button2.Click += Button2_Click; // GUARDAR
            button3.Click += Button3_Click; // IMPRIMIR
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Nombres";
            comboBox1.ValueMember = "Cedula";
            comboBox1.DataSource = DataSeeder.Pacientes.ToList();

            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Codigo";
            comboBox2.DataSource = DataSeeder.Aseguradoras.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // CALCULAR: sumar por inventario usando precio del medicamento si está disponible
            decimal subtotal = 0m;
            var lines = DataSeeder.Inventarios.Select(i =>
            {
                var med = DataSeeder.Medicamentos.FirstOrDefault(m => m.Nombre == i.Medicamento || m.Codigo == i.Medicamento);
                var precio = med?.Precio ?? 0m;
                var lineTotal = precio * i.Existencia;
                return new { i.Codigo, i.Medicamento, i.Existencia, Precio = precio, LineTotal = lineTotal };
            }).ToList();

            subtotal = lines.Sum(l => l.LineTotal);

            // cobertura por aseguradora
            decimal cobertura = 0m;
            if (comboBox2.SelectedItem is Aseguradora a)
            {
                cobertura = a.Cobertura; // fracción, por ejemplo 0.8
            }

            var coberturaMonto = subtotal * cobertura;
            var total = subtotal - coberturaMonto;

            textBox2.Text = subtotal.ToString("F2");
            textBox3.Text = coberturaMonto.ToString("F2");
            textBox4.Text = total.ToString("F2");

            // mostrar líneas en el grid
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lines.Select(l => new { l.Codigo, l.Medicamento, l.Existencia, Precio = l.Precio.ToString("F2"), LineTotal = l.LineTotal.ToString("F2") }).ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // GUARDAR factura simple
            var factura = new Factura { Numero = textBox1.Text.Trim(), Paciente = comboBox1.SelectedValue?.ToString(), Fecha = System.DateTime.Today, Total = decimal.TryParse(textBox4.Text, out var t) ? t : 0m };
            if (string.IsNullOrEmpty(factura.Numero)) { MessageBox.Show("Numero es obligatorio"); return; }
            DataSeeder.Facturas.Add(factura);
            MessageBox.Show("Factura guardada");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimir no implementado en este ejemplo.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
