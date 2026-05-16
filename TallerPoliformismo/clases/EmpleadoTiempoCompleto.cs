using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPoliformismo.clases
{
    public class EmpleadoTiempoCompleto : IEmpleado
    {
        public string? Nombre { get; protected set; }
        public string? TipoEmpleado { get; protected set; }
        public double SalarioMensual { get; set; }
        public EmpleadoTiempoCompleto(string nombre, string tipoEmpleado, double salarioMensual)
        {
            Nombre = nombre;
            TipoEmpleado = tipoEmpleado;
            SalarioMensual = salarioMensual;
        }
        public double CalcularDescuentos()
        {
            double salarioBruto = CalcularSalarioBruto();
            double salud = salarioBruto * 0.04;
            double pension = salarioBruto * 0.04;
            double totalDescuentos = salud + pension;
            return totalDescuentos;
        }

        public double CalcularBonificacion()
        {
            double bonificacion = SalarioMensual * 0.10;
            return bonificacion;
        }   
        public double CalcularSalarioBruto()
        {
            if (SalarioMensual < 0)
            {
                Console.WriteLine("El salario mensual no puede ser negativo.");
                return 0;
            }
            else
            {
                double salarioBruto = SalarioMensual + CalcularBonificacion();
                return salarioBruto;
            }
        }

        public double CalcularSalarioNeto()
        {
            double salarioNeto = CalcularSalarioBruto() - CalcularDescuentos();
            return salarioNeto;
        }

        public void MostrarInformacion()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("=================================");
            Console.WriteLine("   EMPLEADO TIEMPO COMPLETO");
            Console.WriteLine("=================================");

            Console.ResetColor();

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Tipo de Empleado: {TipoEmpleado}");
            Console.WriteLine($"Salario Mensual: {SalarioMensual}");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("---------------------------------");

            Console.ResetColor();

            Console.WriteLine($"Bonificación: {CalcularBonificacion()}");
            Console.WriteLine($"Salario Bruto: {CalcularSalarioBruto()}");
            Console.WriteLine($"Descuentos: {CalcularDescuentos()}");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Salario Neto: {CalcularSalarioNeto()}");

            Console.ResetColor();

            Console.WriteLine("=================================\n");
        }
    }
}
