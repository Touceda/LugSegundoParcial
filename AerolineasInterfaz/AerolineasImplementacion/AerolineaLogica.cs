using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasImplementacion
{
    public class AerolineaLogica
    {
        private PasajeroLogica pasajero;
        public PasajeroLogica Pasajero { get { return pasajero; } }

        private DestinoLogica destino;
        public DestinoLogica Destino { get { return destino; } }

        private VueloLogica vuelo;
        public VueloLogica Vuelo { get { return vuelo; } }

        public AerolineaLogica()
        {
            this.pasajero = new PasajeroLogica();
            this.destino = new DestinoLogica();
            this.vuelo = new VueloLogica();
        }

    }
}
