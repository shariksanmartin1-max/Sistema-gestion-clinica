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
using SistemaClinica.Infrastructure;
using System.Text;

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

        private void listadoGeneralDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesPorSexoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoGeneralDeMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void médicosPorEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void citasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void citasPorEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesHospitalizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void habitacionesOcupadasYDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicamentosConStockBajoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exámenesRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exámenesPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Report implementations
        private void listadoGeneralDePacientesToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Listado General de Pacientes");
            sb.AppendLine("--------------------------------");
            foreach (var p in DataSeeder.Pacientes)
            {
                sb.AppendLine($"{p.Cedula} | {p.Nombres} {p.Apellidos} | {p.Sexo} | {p.FechaNacimiento:d} | {p.Telefono} | {p.Correo}");
            }
            new FrmReportViewer("Listado General de Pacientes", sb.ToString()).ShowDialog();
        }

        private void pacientesPorSexoToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Pacientes por Sexo");
            sb.AppendLine("--------------------");
            var grp = DataSeeder.Pacientes.GroupBy(p => p.Sexo ?? "Desconocido").Select(g => new { Sexo = g.Key, Count = g.Count() });
            foreach (var g in grp) sb.AppendLine($"{g.Sexo}: {g.Count}");
            new FrmReportViewer("Pacientes por Sexo", sb.ToString()).ShowDialog();
        }

        private void listadoGeneralDeMédicosToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Listado General de Médicos");
            sb.AppendLine("---------------------------");
            foreach (var m in DataSeeder.Medicos) sb.AppendLine($"{m.Codigo} | {m.Nombres} {m.Apellidos} | {m.Especialidad} | {m.Telefono}");
            new FrmReportViewer("Listado General de Médicos", sb.ToString()).ShowDialog();
        }

        private void médicosPorEspecialidadToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Médicos por Especialidad");
            sb.AppendLine("------------------------");
            var grp = DataSeeder.Medicos.GroupBy(m => m.Especialidad ?? "Sin Especialidad");
            foreach (var g in grp)
            {
                sb.AppendLine($"Especialidad: {g.Key}");
                foreach (var m in g) sb.AppendLine($"  - {m.Codigo} {m.Nombres} {m.Apellidos}");
            }
            new FrmReportViewer("Médicos por Especialidad", sb.ToString()).ShowDialog();
        }

        private void citasPorFechaToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Citas por Fecha");
            sb.AppendLine("--------------");
            foreach (var c in DataSeeder.Citas.OrderBy(x => x.Fecha)) sb.AppendLine($"{c.Codigo} | {c.Fecha:g} | Paciente: {c.CedulaPaciente} | Medico: {c.CodigoMedico} | Estado: {c.Estado}");
            new FrmReportViewer("Citas por Fecha", sb.ToString()).ShowDialog();
        }

        private void citasPorEstadoToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Citas por Estado");
            sb.AppendLine("--------------");
            var grp = DataSeeder.Citas.GroupBy(c => c.Estado ?? "Desconocido");
            foreach (var g in grp)
            {
                sb.AppendLine($"Estado: {g.Key}");
                foreach (var c in g) sb.AppendLine($"  - {c.Codigo} | {c.Fecha:g} | Paciente: {c.CedulaPaciente} | Medico: {c.CodigoMedico}");
            }
            new FrmReportViewer("Citas por Estado", sb.ToString()).ShowDialog();
        }

        private void pacientesHospitalizadosToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Pacientes Hospitalizados");
            sb.AppendLine("------------------------");
            foreach (var h in DataSeeder.Hospitalizaciones)
            {
                var p = DataSeeder.Pacientes.FirstOrDefault(x => x.Cedula == h.Paciente);
                sb.AppendLine($"{h.Codigo} | Habitacion: {h.Habitacion} | Paciente: {p?.Nombres} {p?.Apellidos} ({h.Paciente})");
            }
            new FrmReportViewer("Pacientes Hospitalizados", sb.ToString()).ShowDialog();
        }

        private void habitacionesOcupadasYDisponiblesToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Habitaciones Ocupadas");
            sb.AppendLine("----------------------");
            var ocupadas = DataSeeder.Hospitalizaciones.Select(h => h.Habitacion).Distinct().ToList();
            foreach (var oc in ocupadas) sb.AppendLine($"- {oc}");
            sb.AppendLine();
            sb.AppendLine("Disponibles: no hay catálogo de habitaciones en el sistema; mostrar sólo ocupadas.");
            new FrmReportViewer("Habitaciones Ocupadas y Disponibles", sb.ToString()).ShowDialog();
        }

        private void listadoDeMedicamentosToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Listado de Medicamentos");
            sb.AppendLine("------------------------");
            foreach (var m in DataSeeder.Medicamentos) sb.AppendLine($"{m.Codigo} | {m.Nombre} | Stock: {m.Stock} | Precio: {m.Precio:C}");
            new FrmReportViewer("Listado de Medicamentos", sb.ToString()).ShowDialog();
        }

        private void medicamentosConStockBajoToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Medicamentos con Stock Bajo (umbral 20)");
            sb.AppendLine("-------------------------------------");
            foreach (var m in DataSeeder.Medicamentos.Where(x => x.Stock < 20)) sb.AppendLine($"{m.Codigo} | {m.Nombre} | Stock: {m.Stock}");
            new FrmReportViewer("Medicamentos con Stock Bajo", sb.ToString()).ShowDialog();
        }

        private void exámenesRealizadosToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Exámenes Realizados");
            sb.AppendLine("--------------------");
            foreach (var ex in DataSeeder.Examenes) sb.AppendLine($"{ex.Codigo} | Paciente: {ex.Paciente} | Tipo: {ex.TipoExamen}");
            new FrmReportViewer("Exámenes Realizados", sb.ToString()).ShowDialog();
        }

        private void exámenesPorTipoToolStripMenuItem_Click_Impl(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Exámenes por Tipo");
            sb.AppendLine("------------------");
            var grp = DataSeeder.Examenes.GroupBy(x => x.TipoExamen ?? "Desconocido");
            foreach (var g in grp)
            {
                sb.AppendLine($"Tipo: {g.Key}");
                foreach (var ex in g) sb.AppendLine($"  - {ex.Codigo} | Paciente: {ex.Paciente}");
            }
            new FrmReportViewer("Exámenes por Tipo", sb.ToString()).ShowDialog();
        }
    }
}
