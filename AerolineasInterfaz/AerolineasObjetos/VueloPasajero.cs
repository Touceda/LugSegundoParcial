using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasObjetos
{
    public class VueloPasajero
    {

        private int nroVuelo;
        public int NroVuelo { get { return nroVuelo; } set { nroVuelo = value; } }

        private int dni;
        public int Dni { get { return dni; } set { dni = value; } }

        public VueloPasajero(int cNroVuelo, int cDni)
        {
            this.NroVuelo = cNroVuelo;
            this.dni = cDni;
        }

    }
}
