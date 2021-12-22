using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface ITipoConduccion
    {
        string ObtenerDescripcion();
        int ObtenerPotencia(float decilitrosCombustible);
        int ObtenerIncrementoVelocidad(float decilitrosCombustible);
    }
}