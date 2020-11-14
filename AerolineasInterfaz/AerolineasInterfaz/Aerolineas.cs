using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineasObjetos;
using AerolineasImplementacion;
using Microsoft.VisualBasic;


namespace AerolineasInterfaz
{
    public partial class Aerolineas : Form
    {
        public Aerolineas()
        {
            InitializeComponent();
        }

        Aerolinea Aerolinea;
        AerolineaLogica AerolineaLogica;
        private void Aerolineas_Load(object sender, EventArgs e)
        {
            AerolineaLogica = new AerolineaLogica();
            List<Pasajero> ListaDePasajeros = AerolineaLogica.Pasajeros.PasajeroLeer();
            List<Destino> ListaDeDestinos = AerolineaLogica.Destinos.DestinosLeer();
            List<Vuelo> ListaDeVuelos = AerolineaLogica.Vuelos.DestinosLeer(true);
            Aerolinea = new Aerolinea(ListaDePasajeros, ListaDeDestinos, ListaDeVuelos);
            Refresh();
            
        }

        private void Aerolineas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Aerolineas, new Rectangle(new Point(-20, 20), new Size(this.Width, this.Height)));
        }

        #region Interfaz De Pasajero
        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int dni = 0;
            string nombre = "";
            string apellido = "";
            try
            {
                dni = int.Parse(Interaction.InputBox("Cual es su Dni?", "Subscripción"));
                nombre = Interaction.InputBox("Cual es su nombre?", "Subscripción");
                apellido = Interaction.InputBox("Cual es su apellido?", "Subscripción");

                if (nombre.Length <= 2 || apellido.Length <= 2 || dni <= 99) 
                {
                    MessageBox.Show("Los datos ingresados son muy cortos para ser datos reales", "ERROR");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se a ingresado un dato invalido", "ERROR");
                return;
            }

            string MensajePersonalizado = AerolineaLogica.Pasajeros.PasajeroAñadir(new Pasajero(dni, nombre, apellido));
            Aerolinea.Pasajeros = AerolineaLogica.Pasajeros.PasajeroLeer();
            MessageBox.Show(MensajePersonalizado, "Aerolineas");

        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasajeroModificar PM = new PasajeroModificar(Aerolinea, AerolineaLogica);
            PM.ShowDialog();
            Aerolinea = PM.aerolinea;
            AerolineaLogica = PM.aerolineaLogica;
            PM.Close();
        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasajeroBorrar PB = new PasajeroBorrar(Aerolinea, AerolineaLogica);
            PB.ShowDialog();
            Aerolinea = PB.aerolinea;
            AerolineaLogica = PB.aerolineaLogica;
            PB.Close();
            AerolineaLogica.Pasajeros.PasajeroBorrar(200);

        }
        private void verListadoDePasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasajeroListado PL = new PasajeroListado(Aerolinea.Pasajeros);
            PL.ShowDialog();
            PL.Close();
        }

        #endregion

        #region Interfaz De Destinos
        private void añadirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string lugarDestino = "";
            string ubicacionMaps = "";
            try
            {
                lugarDestino = Interaction.InputBox("Cual es el nuevo lugar Destino?", "Nuevo Destino");
                ubicacionMaps = Interaction.InputBox("Coloque el Link del maps para poder ver los destinos EJ: https://www.google.com.ar/maps/@-34.6342485,-58.469787,14z", "Nuevo Destino");

                if (lugarDestino.Length <= 2 || ubicacionMaps.Length <= 2)
                {
                    MessageBox.Show("Los datos ingresados son muy cortos para ser datos reales", "ERROR");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se a ingresado un dato invalido", "ERROR");
                return;
            }

            string MensajePersonalizado = AerolineaLogica.Destinos.DestinoAñadir(new Destino(lugarDestino, ubicacionMaps));
            Aerolinea.Destinos = AerolineaLogica.Destinos.DestinosLeer();
            MessageBox.Show(MensajePersonalizado, "Aerolineas");
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DestinoModificar DM = new DestinoModificar(Aerolinea, AerolineaLogica);
            DM.ShowDialog();
            Aerolinea = DM.aerolinea;
            AerolineaLogica = DM.aerolineaLogica;
            DM.Close();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DestinoBorrar DB = new DestinoBorrar(Aerolinea, AerolineaLogica);
            DB.ShowDialog();
            Aerolinea = DB.aerolinea;
            AerolineaLogica = DB.aerolineaLogica;
            DB.Close();
        }

        private void verListadoDeDestinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DestinoListado DL = new DestinoListado(Aerolinea.Destinos);
            DL.ShowDialog();
            DL.Close();
        }

        #endregion

        #region Interfaz De Vuelos Comunes

        #endregion

        #region Interfaz De Vuelos Comunes

        #endregion

    }
}
