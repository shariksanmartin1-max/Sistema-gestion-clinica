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

            // Datos adicionales precargados
            Especialidades.AddRange(new[] {
                new Especialidad { Codigo = "E04", Nombre = "Neurologia" },
                new Especialidad { Codigo = "E05", Nombre = "Dermatologia" },
                new Especialidad { Codigo = "E06", Nombre = "Ortopedia" }
            });

            Medicos.AddRange(new[] {
                new Medico { Codigo = "M03", Nombres = "Luis", Apellidos = "Martinez", Especialidad = "Neurologia", Telefono = "555-0303" },
                new Medico { Codigo = "M04", Nombres = "Elena", Apellidos = "Santos", Especialidad = "Dermatologia", Telefono = "555-0404" },
                new Medico { Codigo = "M05", Nombres = "Diego", Apellidos = "Rojas", Especialidad = "Ortopedia", Telefono = "555-0505" }
            });

            Pacientes.AddRange(new[] {
                new Paciente { Cedula = "03030303", Nombres = "Ana Maria", Apellidos = "Vega", FechaNacimiento = new System.DateTime(1975,3,3), Sexo = "F", Direccion = "Av 3", Telefono = "300-3333", Correo = "anamaria@ej.com" },
                new Paciente { Cedula = "04040404", Nombres = "Roberto", Apellidos = "Gomez", FechaNacimiento = new System.DateTime(1965,7,10), Sexo = "M", Direccion = "Av 4", Telefono = "300-4444", Correo = "roberto@ej.com" },
                new Paciente { Cedula = "05050505", Nombres = "Lucia", Apellidos = "Fernandez", FechaNacimiento = new System.DateTime(2000,12,12), Sexo = "F", Direccion = "Calle 5", Telefono = "300-5555", Correo = "lucia@ej.com" }
            });

            Medicamentos.AddRange(new[] {
                new Medicamento { Codigo = "MED03", Nombre = "Amoxicilina", Stock = 200, Precio = 3.5m },
                new Medicamento { Codigo = "MED04", Nombre = "Aspirina", Stock = 150, Precio = 1.0m }
            });

            Inventarios.AddRange(new[] {
                new Inventario { Codigo = "I03", Medicamento = "Amoxicilina", Existencia = 200 },
                new Inventario { Codigo = "I04", Medicamento = "Aspirina", Existencia = 150 }
            });

            Laboratorios.AddRange(new[] {
                new Laboratorio { Codigo = "L03", Nombre = "Laboratorio Sur" }
            });

            Examenes.AddRange(new[] {
                new ExamenLaboratorio { Codigo = "EX03", Paciente = "03030303", TipoExamen = "Cultivo" },
                new ExamenLaboratorio { Codigo = "EX04", Paciente = "04040404", TipoExamen = "Hemograma" },
                new ExamenLaboratorio { Codigo = "EX05", Paciente = "05050505", TipoExamen = "PCR" },
                new ExamenLaboratorio { Codigo = "EX06", Paciente = "01010101", TipoExamen = "Perfil Lipidico" }
            });

            Resultados.AddRange(new[] {
                new ResultadoLaboratorio { Codigo = "R03", Resultado = "Positivo" },
                new ResultadoLaboratorio { Codigo = "R04", Resultado = "Negativo" },
                new ResultadoLaboratorio { Codigo = "R05", Resultado = "Normal" },
                new ResultadoLaboratorio { Codigo = "R06", Resultado = "Atípico" }
            });

            Citas.AddRange(new[] {
                new Cita { Codigo = "C03", CedulaPaciente = "03030303", CodigoMedico = "M03", Fecha = System.DateTime.Today.AddDays(3), Estado = "Confirmada" },
                new Cita { Codigo = "C04", CedulaPaciente = "04040404", CodigoMedico = "M04", Fecha = System.DateTime.Today.AddDays(4), Estado = "Pendiente" },
                new Cita { Codigo = "C05", CedulaPaciente = "05050505", CodigoMedico = "M05", Fecha = System.DateTime.Today.AddDays(5), Estado = "Pendiente" }
            });

            Hospitalizaciones.AddRange(new[] {
                new Hospitalizacion { Codigo = "H03", Paciente = "03030303", Habitacion = "201" },
                new Hospitalizacion { Codigo = "H04", Paciente = "04040404", Habitacion = "202" }
            });

            Facturas.AddRange(new[] {
                new Factura { Numero = "F003", Paciente = "03030303", Fecha = System.DateTime.Today.AddDays(-2), Total = 75.0m },
                new Factura { Numero = "F004", Paciente = "04040404", Fecha = System.DateTime.Today.AddDays(-1), Total = 120.0m },
                new Factura { Numero = "F005", Paciente = "05050505", Fecha = System.DateTime.Today, Total = 45.0m }
            });

            Aseguradoras.AddRange(new[] {
                new Aseguradora { Codigo = "AS03", Nombre = "Seguro C", Cobertura = 0.5m }
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
