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
            List<Vuelo> ListaDeVuelos = AerolineaLogica.Vuelos.VuelosComunesLeer();
            List<VueloInternacional> ListaDeVuelosI = AerolineaLogica.Vuelos.VuelosInternacionalesLeer();
            List<VueloInternacional> ListaDeVuelosFinalizados = AerolineaLogica.Vuelos.VuelosFinalizadosLeer();
            Aerolinea = new Aerolinea(ListaDePasajeros, ListaDeDestinos, ListaDeVuelos, ListaDeVuelosI,ListaDeVuelosFinalizados);
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
            List<object> objetos = new List<object>();

            foreach (var obj in Aerolinea.Pasajeros)
            {
                objetos.Add(obj);
            }

            ListadosInfo LI = new ListadosInfo(objetos);
            LI.ShowDialog();
            LI.Close();
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
            List<object> objetos = new List<object>();

            foreach (var dest in Aerolinea.Destinos)
            {
                objetos.Add(dest);
            }

            VerDestinos VD = new VerDestinos(objetos);
            VD.ShowDialog();
            VD.Close();
        }

        #endregion

        #region Interfaz De Vuelos Comunes
        //Alta VComun
        private void comunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarVueloComun AVG = new AgregarVueloComun(Aerolinea, AerolineaLogica);
            AVG.ShowDialog();
            Aerolinea = AVG.aerolinea;
            AerolineaLogica = AVG.aerolineaLogica;
            AVG.Close();
        }

        //Ver Vuelos y finalizar
        private void comunesToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            FinalizarVuelos FV = new FinalizarVuelos(Aerolinea,AerolineaLogica,true);
            FV.ShowDialog();
            Aerolinea = FV.aerolinea;
            AerolineaLogica = FV.aerolineaLogica;
            FV.Close();
        }

        //Llenar Vuelo Comun
        private void comunesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LlenarVuelo LV = new LlenarVuelo(Aerolinea,AerolineaLogica,true);
            LV.ShowDialog();
            Aerolinea = LV.aerolinea;
            AerolineaLogica = LV.aerolineaLogica;
            LV.Close();
        }

        //VerVuelo
        private void comunesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VerVuelosPasajeros VP = new VerVuelosPasajeros(Aerolinea, AerolineaLogica, true);
            VP.ShowDialog();
            Aerolinea = VP.aerolinea;
            AerolineaLogica = VP.aerolineaLogica;
            VP.Close();
        }

        #endregion

        #region Interfaz De Vuelos Internacionales
        //Alta Vuelo Internacional
        private void internacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarVueloInternacional AVI = new AgregarVueloInternacional(Aerolinea, AerolineaLogica);
            AVI.ShowDialog();
            Aerolinea = AVI.aerolinea;
            AerolineaLogica = AVI.aerolineaLogica;
            AVI.Close();
        }
        //Ver vuelos internacionales y finalizar
        private void internacionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalizarVuelos FV = new FinalizarVuelos(Aerolinea, AerolineaLogica,false);
            FV.ShowDialog();
            Aerolinea = FV.aerolinea;
            AerolineaLogica = FV.aerolineaLogica;
            FV.Close();
        }

        //Llenar Vuelo Internacional
        private void internacionalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LlenarVuelo LV = new LlenarVuelo(Aerolinea, AerolineaLogica, false);
            LV.ShowDialog();
            Aerolinea = LV.aerolinea;
            AerolineaLogica = LV.aerolineaLogica;
            LV.Close();
        }
        //VerVuelo
        private void internacionalesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VerVuelosPasajeros VP = new VerVuelosPasajeros(Aerolinea, AerolineaLogica, false);
            VP.ShowDialog();
            Aerolinea = VP.aerolinea;
            AerolineaLogica = VP.aerolineaLogica;
            VP.Close();
        }

        #endregion


        //Muestra y De baja Vuelos tanto Comunes como Internacionales
        private void darDeVajaUnVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarVuelos EV = new EliminarVuelos(Aerolinea, AerolineaLogica);
            EV.ShowDialog();
            Aerolinea = EV.aerolinea;
            AerolineaLogica = EV.aerolineaLogica;
            EV.Close();
        }

        //Ver los vuelos finalizados
        private void verVuelosFinalizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VuelosFinalizados VF = new VuelosFinalizados(Aerolinea.VuelosFinalizados);
            VF.ShowDialog();
            VF.Close();
        }

        //Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
    }
}
