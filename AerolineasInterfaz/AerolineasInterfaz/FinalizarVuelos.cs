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
    public partial class FinalizarVuelos : Form
    {
        public FinalizarVuelos(Aerolinea aero, AerolineaLogica aeroLog,bool iSComun)
        {
            this.aerolinea = aero;
            this.aerolineaLogica = aeroLog;
            this.isComun = iSComun;
            InitializeComponent();
        }

        private bool isComun;
        public Aerolinea aerolinea;
        public AerolineaLogica aerolineaLogica;

        private void FinalizarVuelos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            List<object> objetos = new List<object>();

            if (isComun)
            {
                objetos.AddRange(aerolinea.VuelosComunes.ToArray());
            }
            else
            {
                objetos.AddRange(aerolinea.VuelosInternacionales.ToArray());
            }

            dgvVuelos.Actualizar(objetos);
        }

        private void btbFinalizarVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (isComun)
                {
                    FinalizarVueloComun();
                }
                else
                {
                    FinalizarVueloInternacional();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Aerolineas");
                throw;
            }      
        }

        private void FinalizarVueloComun()
        {
            int nroVuelo = 0;
            string destino = "";
            string pais = "----";
            string ciudad = "----";
            string partida = "";
            string llegada = "";
            int asiento = 0;
            int ocupacion = 0;

            nroVuelo = int.Parse(dgvVuelos.DevolverInformacion(0, false).ToString());
            destino = dgvVuelos.DevolverInformacion(1, true).ToString();
            partida = dgvVuelos.DevolverInformacion(2, true).ToString();
            llegada = dgvVuelos.DevolverInformacion(3, true).ToString();
            asiento = int.Parse(dgvVuelos.DevolverInformacion(4, false).ToString());
            ocupacion = int.Parse(dgvVuelos.DevolverInformacion(5, false).ToString());

            string mensaje = aerolineaLogica.Vuelos.VueloFinalizado(new VueloInternacional(destino, partida, llegada, asiento, pais, ciudad, nroVuelo, ocupacion), true);
            aerolinea.VuelosFinalizados = aerolineaLogica.Vuelos.VuelosFinalizadosLeer();
            aerolinea.VuelosComunes = aerolineaLogica.Vuelos.VuelosComunesLeer();
            MessageBox.Show(mensaje, "Aerolineas");
            Actualizar();
        }

        private void FinalizarVueloInternacional()
        {
            int nroVuelo = 0;
            string destino = "";
            string pais = "----";
            string ciudad = "----";
            string partida = "";
            string llegada = "";
            int asiento = 0;
            int ocupacion = 0;

            pais = dgvVuelos.DevolverInformacion(0, true).ToString();
            ciudad = dgvVuelos.DevolverInformacion(1, true).ToString();
            nroVuelo = int.Parse(dgvVuelos.DevolverInformacion(2, false).ToString());
            destino = dgvVuelos.DevolverInformacion(3, true).ToString();
            partida = dgvVuelos.DevolverInformacion(4, true).ToString();
            llegada = dgvVuelos.DevolverInformacion(5, true).ToString();
            asiento = int.Parse(dgvVuelos.DevolverInformacion(6, false).ToString());
            ocupacion = int.Parse(dgvVuelos.DevolverInformacion(7, true).ToString());


            string mensaje = aerolineaLogica.Vuelos.VueloFinalizado(new VueloInternacional(destino, partida, llegada, asiento, pais, ciudad, nroVuelo, ocupacion), false);
            aerolinea.VuelosFinalizados = aerolineaLogica.Vuelos.VuelosFinalizadosLeer();
            aerolinea.VuelosInternacionales = aerolineaLogica.Vuelos.VuelosInternacionalesLeer();
            MessageBox.Show(mensaje, "Aerolineas");
            Actualizar();
        }


    }
}
