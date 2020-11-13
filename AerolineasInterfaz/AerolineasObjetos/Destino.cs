using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasObjetos
{
    public class Destino
    {
        private string provincia;
        public string Provincia { get { return provincia; } set { provincia = value; } }

        private string destinoMaps;
        public string DestinoMaps { get { return destinoMaps; } set { destinoMaps = value; }}

        public Destino(string cProvincia, string cDestinoMaps)
        {
            this.provincia = cProvincia;
            this.destinoMaps = cDestinoMaps;
        }
    }
}
