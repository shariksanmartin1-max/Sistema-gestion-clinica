using System.Collections.Generic;
using System.Linq;
using SistemaClinica.Entidades;

namespace SistemaClinica.Infrastructure
{
    public static class DataSeeder
    {
        public static List<Paciente> Pacientes { get; } = new List<Paciente>();
        public static List<Medico> Medicos { get; } = new List<Medico>();
        public static List<Especialidad> Especialidades { get; } = new List<Especialidad>();
        public static List<Medicamento> Medicamentos { get; } = new List<Medicamento>();
        public static List<Inventario> Inventarios { get; } = new List<Inventario>();
        public static List<Laboratorio> Laboratorios { get; } = new List<Laboratorio>();
        public static List<ExamenLaboratorio> Examenes { get; } = new List<ExamenLaboratorio>();
        public static List<ResultadoLaboratorio> Resultados { get; } = new List<ResultadoLaboratorio>();
        public static List<Cita> Citas { get; } = new List<Cita>();
        public static List<Hospitalizacion> Hospitalizaciones { get; } = new List<Hospitalizacion>();
        public static List<Factura> Facturas { get; } = new List<Factura>();
        public static List<Aseguradora> Aseguradoras { get; } = new List<Aseguradora>();

        public static void Seed()
        {
            if (Pacientes.Any()) return; // ya sembrado

            Especialidades.AddRange(new[] {
                new Especialidad { Codigo = "E01", Nombre = "Cardiologia" },
                new Especialidad { Codigo = "E02", Nombre = "Pediatria" },
                new Especialidad { Codigo = "E03", Nombre = "Medicina General" }
            });

            Medicos.AddRange(new[] {
                new Medico { Codigo = "M01", Nombres = "Juan", Apellidos = "Perez", Especialidad = "Cardiologia", Telefono = "555-0101" },
                new Medico { Codigo = "M02", Nombres = "Ana", Apellidos = "Gomez", Especialidad = "Pediatria", Telefono = "555-0202" }
            });

            Pacientes.AddRange(new[] {
                new Paciente { Cedula = "01010101", Nombres = "Carlos", Apellidos = "Lopez", FechaNacimiento = new System.DateTime(1980,1,1), Sexo = "M", Direccion = "Calle 1", Telefono = "300-1111", Correo = "carlos@ej.com" },
                new Paciente { Cedula = "02020202", Nombres = "Maria", Apellidos = "Rodriguez", FechaNacimiento = new System.DateTime(1990,5,5), Sexo = "F", Direccion = "Calle 2", Telefono = "300-2222", Correo = "maria@ej.com" }
            });

            Medicamentos.AddRange(new[] {
                new Medicamento { Codigo = "MED01", Nombre = "Paracetamol", Stock = 100, Precio = 1.5m },
                new Medicamento { Codigo = "MED02", Nombre = "Ibuprofeno", Stock = 50, Precio = 2.0m }
            });

            Inventarios.AddRange(new[] {
                new Inventario { Codigo = "I01", Medicamento = "Paracetamol", Existencia = 100 },
                new Inventario { Codigo = "I02", Medicamento = "Ibuprofeno", Existencia = 50 }
            });

            Laboratorios.AddRange(new[] {
                new Laboratorio { Codigo = "L01", Nombre = "Laboratorio Central" },
                new Laboratorio { Codigo = "L02", Nombre = "Laboratorio Norte" }
            });

            Examenes.AddRange(new[] {
                new ExamenLaboratorio { Codigo = "EX01", Paciente = "01010101", TipoExamen = "Hemograma" },
                new ExamenLaboratorio { Codigo = "EX02", Paciente = "02020202", TipoExamen = "Quimica Sanguinea" }
            });

            Resultados.AddRange(new[] {
                new ResultadoLaboratorio { Codigo = "R01", Resultado = "Normal" },
                new ResultadoLaboratorio { Codigo = "R02", Resultado = "Anormal" }
            });

            Citas.AddRange(new[] {
                new Cita { Codigo = "C01", CedulaPaciente = "01010101", CodigoMedico = "M01", Fecha = System.DateTime.Today.AddDays(1), Estado = "Pendiente" },
                new Cita { Codigo = "C02", CedulaPaciente = "02020202", CodigoMedico = "M02", Fecha = System.DateTime.Today.AddDays(2), Estado = "Pendiente" }
            });

            Hospitalizaciones.AddRange(new[] {
                new Hospitalizacion { Codigo = "H01", Paciente = "01010101", Habitacion = "101" },
                new Hospitalizacion { Codigo = "H02", Paciente = "02020202", Habitacion = "102" }
            });

            Facturas.AddRange(new[] {
                new Factura { Numero = "F001", Paciente = "01010101", Fecha = System.DateTime.Today, Total = 150.0m },
                new Factura { Numero = "F002", Paciente = "02020202", Fecha = System.DateTime.Today, Total = 200.0m }
            });

            Aseguradoras.AddRange(new[] {
                new Aseguradora { Codigo = "AS01", Nombre = "Seguro A", Cobertura = 0.8m },
                new Aseguradora { Codigo = "AS02", Nombre = "Seguro B", Cobertura = 0.6m }
            });
        }
    }
}
