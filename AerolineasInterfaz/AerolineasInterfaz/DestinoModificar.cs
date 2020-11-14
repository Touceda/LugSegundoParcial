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

namespace AerolineasInterfaz
{
    public partial class DestinoModificar : Form
    {
        public DestinoModificar(Aerolinea aero, AerolineaLogica aeroLog)
        {
            this.aerolinea = aero;
            this.aerolineaLogica = aeroLog;
            InitializeComponent();
        }
        public Aerolinea aerolinea;
        public AerolineaLogica aerolineaLogica;
        private void DestinoModificar_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            List<object> lista = new List<object>();
            foreach (var obj in aerolinea.Destinos)
            {
                lista.Add(obj);
            }
            dgvModificarDestinos.Actualizar(lista);

            if (lista.Count == 0)
            {
                btbModificar.Enabled = false;
            }
            else
            {
                btbModificar.Enabled = true;
            }
        }

        private void btbModificar_Click_1(object sender, EventArgs e)
        {
            int id = 0;
            string destino = "";
            string ubicacion = "";
            try
            {
                id = int.Parse(dgvModificarDestinos.DevolverInformacion(0, false).ToString());
                destino = txtNuevoDestino.Text.ToString();
                ubicacion = txtNuevaUbicacion.Text.ToString();

                if (destino == "")
                {
                    destino = dgvModificarDestinos.DevolverInformacion(1, true).ToString();
                }

                if (ubicacion == "")
                {
                    ubicacion = dgvModificarDestinos.DevolverInformacion(2, true).ToString();
                }


                if (destino.Length <= 2 || ubicacion.Length <= 2)
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

            string MensajePersonalizado = aerolineaLogica.Destinos.DestinoModificar(new Destino(destino, ubicacion, id));
            aerolinea.Destinos = aerolineaLogica.Destinos.DestinosLeer();
            Actualizar();
            MessageBox.Show(MensajePersonalizado, "Aerolineas");
        }
    }
}



