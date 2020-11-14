using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasObjetos
{
    public class Destino
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        private string lugarDestino;
        public string LugarDestino { get { return lugarDestino; } set { lugarDestino = value; } }

        private string destinoMaps;
        public string DestinoMaps { get { return destinoMaps; } set { destinoMaps = value; }}

        public Destino(string cProvincia, string cDestinoMaps, int cId = 0)
        {
            this.id = cId;
            this.lugarDestino = cProvincia;
            this.destinoMaps = cDestinoMaps;
        }
    }
}
