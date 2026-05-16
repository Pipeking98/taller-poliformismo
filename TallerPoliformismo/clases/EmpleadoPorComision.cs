using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPoliformismo.clases
{
    public class EmpleadoPorComision : IEmpleado
    {
        public string? Nombre { get; protected set; }

        public string? TipoEmpleado { get; protected set; }
        public double SalarioBase { get; set; }

        public double VentasRealizadas { get; set; }

        public EmpleadoPorComision(string nombre, string tipoEmpleado, double salarioBase, double ventasRealizadas)
        {
            Nombre = nombre;
            TipoEmpleado = tipoEmpleado;
            SalarioBase = salarioBase;
            VentasRealizadas = ventasRealizadas;
        }
        public double CalcularDescuentos()
        {
            double salarioBruto = CalcularSalarioBruto();

            double salud = salarioBruto * 0.04;

            double pension = salarioBruto * 0.04;

            double totalDescuentos = salud + pension;

            return totalDescuentos;
        }

        public double CalcularSalarioBruto()
        {
            if (VentasRealizadas < 0)
            {
                Console.WriteLine("Las ventas no pueden ser negativas.");
                return 0;
            }

            else
            {
                double salarioBruto = SalarioBase + CalcularComision();
                return salarioBruto;
            }
        }

        public double CalcularComision()
        {
            double comision = VentasRealizadas * 0.08;
            return comision;
        }
        public double CalcularSalarioNeto()
        {
            double salarioNeto = CalcularSalarioBruto() - CalcularDescuentos();
            return salarioNeto;
        }

        public void MostrarInformacion()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("=================================");
            Console.WriteLine("    EMPLEADO POR COMISION");
            Console.WriteLine("=================================");

            Console.ResetColor();

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Tipo de Empleado: {TipoEmpleado}");
            Console.WriteLine($"Ventas Realizadas: {VentasRealizadas}");
            Console.WriteLine($"Salario Base: {SalarioBase}");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("---------------------------------");

            Console.ResetColor();

            Console.WriteLine($"Comisión: {CalcularComision()}");
            Console.WriteLine($"Salario Bruto: {CalcularSalarioBruto()}");
            Console.WriteLine($"Descuentos: {CalcularDescuentos()}");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Salario Neto: {CalcularSalarioNeto()}");

            Console.ResetColor();

            Console.WriteLine("=================================\n");
        }
    }
}
