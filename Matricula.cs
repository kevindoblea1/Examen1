using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace examen1
{
    public class Matricula : ICalculoNota
    {
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public List<double> NotasParciales { get; set; }

        public Matricula()
        {
            Alumno = new Alumno();
            Asignatura = new Asignatura();
            NotasParciales = new List<double>(3);
        }

        public void ValidarNotas(double n1, double n2, double n3)
        {
            if (n1 + n2 > 30)
                throw new ArgumentException("La suma de n1 y n2 no puede ser mayor a 30.");
            if (n3 > 40)
                throw new ArgumentException("La nota del tercer parcial (n3) no puede ser mayor a 40.");
        }

        public double CalcularNotaFinal()
        {
            double suma = 0;
            foreach (var n in NotasParciales)
            {
                suma += n;
            }
            return suma;
        }

        public double CalcularNotaFinal(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }

        public string ObtenerMensajeNota(double notaFinal)
        {
            if (notaFinal <= 59) return "Reprobado";
            if (notaFinal <= 79) return "Bueno";
            if (notaFinal <= 89) return "Muy Bueno";
            return "Sobresaliente";
        }
    }
}
 //Console.WriteLine($"\nNota Final (Interfaz): {notaFinalInterfaz} - {mensajeInterfaz}");