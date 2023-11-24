﻿using POO.Controller;
using System;
using System.Globalization;

namespace POO
{
    internal class Program
    {
        private static void Main()
        {
            // Set culture to use dot as decimal separator
            CultureInfo culture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            bool exit = false;
            Empleado empleado = null;
            Gerente gerente = null;

            do
            {
                Console.Clear(); // Clear the console screen

                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Ingresar datos de Empleado");
                Console.WriteLine("2. Ingresar datos de Gerente");
                Console.WriteLine("3. Mostrar información del Empleado");
                Console.WriteLine("4. Mostrar información del Gerente");
                Console.WriteLine("5. Salir");

                int opcion;
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese un número válido:");
                }

                switch (opcion)
                {
                    case 1:
                        empleado = IngresarDatosEmpleado();
                        break;
                    case 2:
                        gerente = IngresarDatosGerente();
                        break;
                    case 3:
                        MostrarInformacionEmpleado(empleado);
                        break;
                    case 4:
                        MostrarInformacionGerente(gerente);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadLine();

            } while (!exit);
        }

        private static Empleado IngresarDatosEmpleado()
        {
            Console.Clear(); // Clear the console screen

            Console.WriteLine("Ingrese el nombre del Empleado:");
            string nombreEmpleado = Console.ReadLine();

            Console.WriteLine("Ingrese el salario del Empleado:");
            double salarioEmpleado;
            while (!double.TryParse(Console.ReadLine(), out salarioEmpleado))
            {
                Console.WriteLine("Ingrese un salario válido:");
            }

            return new Empleado(nombreEmpleado, salarioEmpleado);
        }

        private static Gerente IngresarDatosGerente()
        {
            Console.Clear(); // Clear the console screen

            Console.WriteLine("\nIngrese el nombre del Gerente:");
            string nombreGerente = Console.ReadLine();

            Console.WriteLine("Ingrese el salario del Gerente:");
            double salarioGerente;
            while (!double.TryParse(Console.ReadLine(), out salarioGerente))
            {
                Console.WriteLine("Ingrese un salario válido:");
            }

            Console.WriteLine("Ingrese el departamento del Gerente:");
            string departamentoGerente = Console.ReadLine();

            return new Gerente(nombreGerente, salarioGerente, departamentoGerente);
        }

        private static void MostrarInformacionEmpleado(Empleado empleado)
        {
            Console.Clear(); // Clear the console screen

            if (empleado != null)
            {
                Console.WriteLine("Datos del Empleado:");
                MostrarInformacion(empleado);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No se ha ingresado información del Empleado.\n");
            }
        }

        private static void MostrarInformacionGerente(Gerente gerente)
        {
            Console.Clear(); // Clear the console screen

            if (gerente != null)
            {
                Console.WriteLine("Datos del Gerente:");
                MostrarInformacion(gerente);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No se ha ingresado información del Gerente.\n");
            }
        }

        private static void MostrarInformacion(IMostrarInformacion entidad)
        {
            entidad.MostrarInformacionGeneral();
        }
    }
}
