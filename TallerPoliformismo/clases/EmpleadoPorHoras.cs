using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPoliformismo.clases
{
        public class EmpleadoPorHoras : IEmpleado
        {
            public string? Nombre { get; protected set; }

            public string? TipoEmpleado { get; protected set; }
            public double HorasTrabajadas { get; set; }

            public double TarifaPorHora { get; set; }

            public EmpleadoPorHoras(string nombre, string tipoempleado, double horasTrabajadas, double tarifaPorHora)
            {
                Nombre = nombre;

                TipoEmpleado = tipoempleado;

                HorasTrabajadas = horasTrabajadas;

                TarifaPorHora = tarifaPorHora;
        }

        public double CalcularSalarioBruto()
        {
            
            if (HorasTrabajadas < 0)
            {
                Console.WriteLine("Las horas trabajadas no pueden ser negativas.");
                return 0;
            }


            else if (HorasTrabajadas <= 160)
            {
                double salarioBruto = HorasTrabajadas * TarifaPorHora;
                return salarioBruto;
            }


            else
            {
                double salarioBruto = (160 * TarifaPorHora) + CalcularHorasExtras();
                return salarioBruto;
            }
        }

        public double CalcularDescuentos()
        {
            double salarioBruto = CalcularSalarioBruto();

            double salud = salarioBruto * 0.04;

            double pension = salarioBruto * 0.04;

            double totalDescuentos = salud + pension;

            return totalDescuentos;


        }
        public double CalcularHorasExtras()
        {
            if (HorasTrabajadas > 160)
            {
                double horasExtras = HorasTrabajadas - 160;

                double valorHoraExtra = TarifaPorHora + (TarifaPorHora * 0.15);

                double pagoHorasExtras = horasExtras * valorHoraExtra;

                return pagoHorasExtras;
            }
            else
            {
                return 0;
            }
        }

        public double CalcularSalarioNeto()
        {
            double salarioNeto = CalcularSalarioBruto() - CalcularDescuentos();
            return salarioNeto;

        }

        public void MostrarInformacion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=================================");
            Console.WriteLine("      EMPLEADO POR HORAS");
            Console.WriteLine("=================================");

            Console.ResetColor();

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Tipo de Empleado: {TipoEmpleado}");
            Console.WriteLine($"Horas Trabajadas: {HorasTrabajadas}");
            Console.WriteLine($"Tarifa por Hora: {TarifaPorHora}");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("---------------------------------");

            Console.ResetColor();

            Console.WriteLine($"Salario Bruto: {CalcularSalarioBruto()}");
            Console.WriteLine($"Horas Extras: {CalcularHorasExtras()}");
            Console.WriteLine($"Descuentos: {CalcularDescuentos()}");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Salario Neto: {CalcularSalarioNeto()}");

            Console.ResetColor();

            Console.WriteLine("=================================\n");
        }
    }
}
