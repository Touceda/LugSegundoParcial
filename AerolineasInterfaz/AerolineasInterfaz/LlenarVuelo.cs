using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineasImplementacion;
using AerolineasObjetos;

namespace AerolineasInterfaz
{
    public partial class LlenarVuelo : Form
    {
        public LlenarVuelo(Aerolinea aero, AerolineaLogica aeroLog, bool isComun)
        {
            this.aerolinea = aero;
            this.aerolineaLogica = aeroLog;
            this.esVueloComun = isComun;
            this.pasajeros = aerolinea.Pasajeros;
            InitializeComponent();
        }

        private bool esVueloComun;
        public Aerolinea aerolinea;
        public AerolineaLogica aerolineaLogica;
        private List<Pasajero> pasajeros;
        private List<VueloPasajero> vuelosPasajeros;
        private void LlenarVuelo_Load(object sender, EventArgs e)
        {
            MandarAActualizar();
        }

        private void MandarAActualizar()
        {
            if (esVueloComun)
            {
                Actualizar(aerolinea.VuelosComunes, pasajeros);
            }
            else
            {
                Actualizar(aerolinea.VuelosInternacionales, pasajeros);
            }
        }
        private void Actualizar(List<Vuelo> vuelos, List<Pasajero> pasajeros)
        {
            vuelosPasajeros = aerolineaLogica.Vuelos.BuscarVueloPasajeros(true);

            List<object> vuelosobject = new List<object>();
            List<object> pasajerosobject = new List<object>();

            vuelosobject.AddRange(vuelos.ToArray());
            pasajerosobject.AddRange(pasajeros.ToArray());

            dgvVuelos.Actualizar(vuelosobject);
            dgvPasajeros.Actualizar(pasajerosobject);
      
        }

        private void Actualizar(List<VueloInternacional> vuelos, List<Pasajero> pasajeros)
        {

            vuelosPasajeros = aerolineaLogica.Vuelos.BuscarVueloPasajeros(false);

            List<object> vuelosobject = new List<object>();
            List<object> pasajerosobject = new List<object>();

            vuelosobject.AddRange(vuelos.ToArray());
            pasajerosobject.AddRange(pasajeros.ToArray());

            dgvVuelos.Actualizar(vuelosobject);
            dgvPasajeros.Actualizar(pasajerosobject);
        }

        private void btbAñadirPasajero_Click(object sender, EventArgs e)
        {
            try
            {


                int index1 = 0;
                int index2 = 0;
                int index3 = 0;
                if (esVueloComun)
                {
                    index1 = 0;
                    index2 = 4;
                    index3 = 5;
                }
                else
                {
                    index1 = 2;
                    index2 = 6;
                    index3 = 7;
                }

                int nroVuelo = int.Parse(dgvVuelos.DevolverInformacion(index1, esVueloComun).ToString());
                int dni = int.Parse(dgvPasajeros.DevolverInformacion(0, esVueloComun).ToString());
                int asientos = int.Parse(dgvVuelos.DevolverInformacion(index2, esVueloComun).ToString());
                int Ocupacion = int.Parse(dgvVuelos.DevolverInformacion(index3, esVueloComun).ToString());

                if (Ocupacion >= 100)
                {
                    MessageBox.Show("Este Avion ya esta completo, espere el siguiente vuelo", "Aerolineas");
                    return;
                }

                if (ValidarPasajeroNoRepetido(nroVuelo, dni))
                {
                    MessageBox.Show("Este Pasajero ya esta registrado en este vuelo", "Aerolineas");
                    return;
                }

              
                ActualizarOcupacion(nroVuelo, asientos);
                string mensaje = aerolineaLogica.Vuelos.VueloPasajerosAñadir(nroVuelo, dni, esVueloComun);
                MandarAActualizar();
                MessageBox.Show(mensaje, "Aerolineas");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio Algun Error, Intente mas tarde", "Aerolineas");
            }
        }

        public bool ValidarPasajeroNoRepetido(int nroVuelo,int dni)
        {
            foreach (var vuelospasajeros in vuelosPasajeros)
            {
                if (vuelospasajeros.NroVuelo == nroVuelo && vuelospasajeros.Dni == dni) 
                {
                    return true;
                }
            }          
            return false;
        }

        public void ActualizarOcupacion(int nroVuelo, int asientos)
        {
            int count = 1;
            foreach (var vuelopasajero in vuelosPasajeros)
            {
                if (vuelopasajero.NroVuelo == nroVuelo)
                {
                    count++;
                }
            }

            int porcentaje = (100 * count) / asientos;

            aerolineaLogica.Vuelos.VuelosModificar(nroVuelo, porcentaje, esVueloComun);
            if (esVueloComun)
            {
                aerolinea.VuelosComunes = aerolineaLogica.Vuelos.VuelosComunesLeer();
            }
            else
            {
                aerolinea.VuelosInternacionales = aerolineaLogica.Vuelos.VuelosInternacionalesLeer();
            }
        }

    }
}
