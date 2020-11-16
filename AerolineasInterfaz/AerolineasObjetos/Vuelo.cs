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
        public int nroVuelo;
        public int NroVuelo { get { return nroVuelo; } set { nroVuelo = value; } }

        private string lugadDestino;
        public string LugarDestino { get { return lugadDestino; } set { lugadDestino = value; } }

        private string partida;//Fecha/Hora de partida
        public string Partida { get { return partida; } set { partida = value; } }

        private string llegada;//Fecha/Hora de llegada
        public string Llegada { get { return llegada; } set { llegada = value; } }

        public int asientos;
        public int Asientos { get { return asientos; } set { asientos = value; } }

        public int ocupacion;
        public int Ocupacion { get { return ocupacion; } set { ocupacion = value; } }
        public Vuelo(string cLugarDestsino, string cPartida, string cLlegada, int cAsientos, int cOcupacion = 0, int cNroVuelo = 0)
        {
            this.nroVuelo = cNroVuelo;
            this.lugadDestino = cLugarDestsino;
            this.partida = cPartida;
            this.llegada = cLlegada;
            this.asientos = cAsientos;
            this.ocupacion = cOcupacion;
        }
    }
    //internacionales en éste último se registra además de la ciudad de destino y el país
    public class VueloInternacional:Vuelo
    {

        private string pais;
        public string Pais { get { return pais; } set { pais = value; } }

        private string ciudad;
        public string Ciudad { get { return ciudad; } set { ciudad = value; } }

        public VueloInternacional(string cLugarDestsino, string cPartida, string cLlegada, int cAsientos, string cPais, string cCiudad, int cNroVuelo = 0, int cOcupacion = 0)
        : base(cLugarDestsino, cPartida, cLlegada, cAsientos, cOcupacion, cNroVuelo)
        {
            this.NroVuelo = cNroVuelo;
            this.LugarDestino = cLugarDestsino;
            this.Partida = cPartida;
            this.Llegada = cLlegada;
            this.Asientos = cAsientos;
            this.Ocupacion = cOcupacion;
            this.pais = cPais;
            this.ciudad = cCiudad;
        }
    }
}
