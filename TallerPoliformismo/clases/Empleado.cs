using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPoliformismo.clases
{

    public interface IEmpleado
    {
        double CalcularSalarioBruto();

        double CalcularDescuentos();

        double CalcularSalarioNeto();

        void MostrarInformacion();
    }
}

