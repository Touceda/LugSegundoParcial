using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasImplementacion
{
    public class AerolineaLogica
    {

        private PasajeroLogica pasajeros;
        public PasajeroLogica Pasajeros { get { return pasajeros; } }

        private DestinoLogica destinos;
        public DestinoLogica Destinos { get { return destinos; } }

        private VueloLogica vuelos;
        public VueloLogica Vuelos { get { return vuelos; } }

        public AerolineaLogica()
        {
            this.pasajeros = new PasajeroLogica();
            this.destinos = new DestinoLogica();
            this.vuelos = new VueloLogica();
        }

    }
}
