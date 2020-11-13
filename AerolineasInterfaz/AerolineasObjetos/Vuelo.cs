using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasObjetos
{
    //la fecha/hora de partida y llegada 
    public class Vuelo
    {
        private Destino lugadDestino;
        public Destino LugarDestino { get { return lugadDestino; } set { lugadDestino = value; } }

        private string partida;//Fecha/Hora de partida
        public string Partida { get { return partida; } set { partida = value; } }

        private string llegada;//Fecha/Hora de llegada
        public string Llegada { get { return llegada; } set { llegada = value; } }

        public int asientosDisponibles;
        public int AsientosDisponibles { get { return asientosDisponibles; } set { asientosDisponibles = value; } }
        public Vuelo(Destino cLugarDestsino, string cPartida, string cLlegada, int cAsientosDisponibles)
        {
            this.lugadDestino = cLugarDestsino;
            this.partida = cPartida;
            this.llegada = cLlegada;
            this.asientosDisponibles = cAsientosDisponibles;
        }
    }
    //internacionales en éste último se registra además de la ciudad de destino y el país
    public class VueloInternacional:Vuelo
    {

        private string pais;
        public string Pais { get { return pais; } set { pais = value; } }

        private string ciudad;
        public string Ciudad { get { return ciudad; } set { ciudad = value; } }

        public VueloInternacional(Destino cLugarDestsino, string cPartida, string cLlegada, int cAsientosDisponibles, string cPais, string cCiudad)
        : base(cLugarDestsino, cPartida, cLlegada, cAsientosDisponibles)
        {
            this.LugarDestino = cLugarDestsino;
            this.Partida = cPartida;
            this.Llegada = cLlegada;
            this.AsientosDisponibles = cAsientosDisponibles;
            this.pais = cPais;
            this.ciudad = cCiudad;
        }
    }
}
