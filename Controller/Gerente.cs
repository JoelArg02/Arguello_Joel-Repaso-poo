using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Controller
{
    internal class Gerente : Empleado , IMostrarInformacion
    {
        public string Departamento { get; set; }

        //base(nombre, salario) es el llamado al constructor de la clase Empleado
        public Gerente(string nombre, double salario, string departamento) : base(nombre, salario)
        {
            Departamento = departamento;
        }

        public new void MostrarInformacionGeneral()
        {
            base.MostrarInformacionGeneral();
            Console.WriteLine($"Departamento: {Departamento}");
        }

    }
}
