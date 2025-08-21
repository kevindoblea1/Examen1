using System;

namespace examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alumno = new Alumno
            {
                Nombre = "Kevin Alvarenga",
                NumeroCuenta = "2025-12345",
                Email = "kevin.alvarenga@unitec.edu"
            };

            var asignatura = new Asignatura
            {
                NombreAsignatura = "Programacion II",
                NombreDocente = "Ing. Roger Guardian",
                Horario = "Lunes y Miercoles 6:00–8:00 PM"
            };

            var matricula = new Matricula
            {
                Alumno = alumno,
                Asignatura = asignatura
            };

            try
            {
                Console.WriteLine("Ingrese las 3 notas parciales (n1, n2, n3):");

                Console.Write("n1 (recuerde que n1 + n2 <= 30): ");
                double n1 = double.Parse(Console.ReadLine() ?? "");

                Console.Write("n2 (recuerde que n1 + n2 <= 30): ");
                double n2 = double.Parse(Console.ReadLine() ?? "");

                Console.Write("n3 (maximo 40): ");
                double n3 = double.Parse(Console.ReadLine() ?? "");

                matricula.ValidarNotas(n1, n2, n3);

                matricula.NotasParciales.Clear();
                matricula.NotasParciales.Add(n1);
                matricula.NotasParciales.Add(n2);
                matricula.NotasParciales.Add(n3);

                ICalculoNota calculadora = matricula;
                double notaFinalInterfaz = calculadora.CalcularNotaFinal();
                string mensajeInterfaz = matricula.ObtenerMensajeNota(notaFinalInterfaz);

                double notaFinalSobrecarga = matricula.CalcularNotaFinal(n1, n2, n3);
                string mensajeSobrecarga = matricula.ObtenerMensajeNota(notaFinalSobrecarga);

                Console.WriteLine("\n--- Resumen de Matricula ---");
                Console.WriteLine($"Alumno: {alumno.Nombre} | Cuenta: {alumno.NumeroCuenta} | Email: {alumno.Email}");
                Console.WriteLine($"Asignatura: {asignatura.NombreAsignatura} | Docente: {asignatura.NombreDocente} | Horario: {asignatura.Horario}");
                Console.WriteLine($"Notas: n1={n1}, n2={n2}, n3={n3}");

                Console.WriteLine("\nCalculo por interfaz:");
                Console.WriteLine($"Nota final: {notaFinalInterfaz} | Mensaje: {mensajeInterfaz}");

                Console.WriteLine("\nCalculo por metodo sobrecargado:");
                Console.WriteLine($"Nota final: {notaFinalSobrecarga} | Mensaje: {mensajeSobrecarga}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar numeros validos para las notas (use solo digitos y separador decimal correcto).");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Validacion de notas fallida: {ex.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
