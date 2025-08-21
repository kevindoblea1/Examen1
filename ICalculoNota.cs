using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1
{
    public interface ICalculoNota
    {
        double CalcularNotaFinal();
    }
}
// This interface defines a method for calculating the final grade, which can be implemented by classes like Matricula.