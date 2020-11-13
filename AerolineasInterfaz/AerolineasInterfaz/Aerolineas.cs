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
            List<Pasajero> ListaDePasajeros = AerolineaLogica.Pasajero.PasajeroLeer();
            Aerolinea = new Aerolinea(ListaDePasajeros);
            
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
            }

            string MensajePersonalizado = AerolineaLogica.Pasajero.PasajeroAñadir(new Pasajero(dni, nombre, apellido));
            MessageBox.Show(MensajePersonalizado, "Aerolineas");

        }

        #endregion

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            string MensajePersonalizado = AerolineaLogica.Pasajero.PasajeroModificar();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AerolineaLogica.Pasajero.PasajeroBorrar(200);
            
        }
    }
}
