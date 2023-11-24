using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Controller
{
    internal class Empleado : IMostrarInformacion
    {
        //El get y set generan automáticamente y simplifica la sintáxis
        public string Nombre { get; set; }
        public double Salario { get; set; }

        //constructor vacío
        public Empleado()
        {
        }

        // Constructor para inicializar Nombre y Salario
        public Empleado(string nombre, double salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        // Método para calcular el salario anual
        public double CalcularSalarioAnual()
        {
            return Salario * 12;
        }

        public void MostrarInformacionGeneral()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario: {Salario:C}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
        }
    }
}



