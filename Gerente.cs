using System;

namespace POO
{
    public class Gerente : Empleado , IMostrarInformacion
    {
        public string Departamento { get; set; }

        //base(nombre, salario) es el llamado al constructor de la clase Empleado
        public Gerente(string nombre, double salario, string departamento) : base(nombre, salario)
        {
            Departamento = departamento;
        }
        public void MostrarInformacionGeneral()
        {
            // Acceder a las propiedades heredadas de la clase Empleado
            Console.WriteLine($"Nombre del Gerente: {Nombre}");
            Console.WriteLine($"Salario del Gerente: {Salario:C}"); // La "C" formatea el salario como moneda

            // Mostrar la información específica de la clase Gerente
            Console.WriteLine($"Departamento del Gerente: {Departamento}");

        }
    }
}
