using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ConduccionNormal : ITipoConduccion
    {
        public string ObtenerDescripcion()
        {
            return "Conduccion Normal";
        }

        public int ObtenerPotencia(float decilitrosCombustible)
        {
            return (int)(decilitrosCombustible * 0.842) + 3;
        }

        public int ObtenerIncrementoVelocidad(float decilitrosCombustible)
        {
            return (int)(decilitrosCombustible * 0.422) + 2;
        }
    }
}
