using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasObjetos
{
    public class Pasajero
    {
        private int dni;
        public int Dni { get { return dni; } set { dni = value; } }

        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }

        private string apellido;
        public string Apellido { get { return apellido; } set { apellido = value; } }



        public Pasajero(int cDni, string cNombre, string cApellido)
        {
            this.dni = cDni;
            this.nombre = cNombre;
            this.apellido = cApellido;    
        }
    }
}
