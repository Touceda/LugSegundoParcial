using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasObjetos
{
    public class Aerolinea
    {
        private List<Pasajero> pasajeros = new List<Pasajero>();
        public List<Pasajero> Pasajeros { get { return pasajeros; } set { pasajeros = value; } }

        private List<Destino> destinos = new List<Destino>();
        public List<Destino> Destinos { get { return destinos; } set { destinos = value; } }

        private List<Vuelo> vuelosComunes = new List<Vuelo>();
        public List<Vuelo> VuelosComunes { get { return vuelosComunes; } set { vuelosComunes = value; } }

        private List<VueloInternacional> vuelosInternacionales = new List<VueloInternacional>();
        public List<VueloInternacional> VuelosInternacionales { get { return vuelosInternacionales; } set { vuelosInternacionales = value; } }

        public Aerolinea(List<Pasajero> cPasajeros, List<Destino> cDestinos, List<Vuelo> cVuelos) 
        {
            this.pasajeros = cPasajeros;
            this.destinos = cDestinos;
            this.vuelosComunes = cVuelos;
        }

    }
}
