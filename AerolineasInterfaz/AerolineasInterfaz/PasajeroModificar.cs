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
    public partial class PasajeroModificar : Form
    {
        public PasajeroModificar(Aerolinea aero, AerolineaLogica aeroLog)
        {
            this.aerolinea = aero;
            this.aerolineaLogica = aeroLog;
            InitializeComponent();
        }
        public Aerolinea aerolinea;
        public AerolineaLogica aerolineaLogica;
        private void PasajeroModificar_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            txtNuevoDni.Text = "";
            txtNuevoNombre.Text = "";
            txtNuevoApellido.Text = "";

            List<object> lista = new List<object>();
            foreach (var obj in aerolinea.Pasajeros)
            {
                lista.Add(obj);
            }
            dgvModificarPasajero.Actualizar(lista);

            if (lista.Count == 0)
            {
                btbModificar.Enabled = false;
            }
            else
            {
                btbModificar.Enabled = true;
            }
        }
        private void btbModificar_Click(object sender, EventArgs e)
        {
            bool revisarDNI = true;
            int dniViejo = 0;
            int dni = 0;
            string nombre = "";
            string apellido = "";
            try
            {
                dniViejo = int.Parse(dgvModificarPasajero.DevolverInformacion(0,false).ToString());

                if (txtNuevoDni.Text == "") 
                {
                    dni = int.Parse(dgvModificarPasajero.DevolverInformacion(0, false).ToString());

                }
                else
                {
                    dni = int.Parse(txtNuevoDni.Text.ToString());
                }
                
                
                nombre = txtNuevoNombre.Text.ToString();
                apellido = txtNuevoApellido.Text.ToString();

                if (nombre == "")
                {
                    nombre = dgvModificarPasajero.DevolverInformacion(1,true).ToString();
                }

                if (apellido == "")
                {
                    apellido = dgvModificarPasajero.DevolverInformacion(2,true).ToString();
                }

                if (nombre.Length == 2 || apellido.Length <= 2 || dni <= 99)
                {
                    MessageBox.Show("Los datos ingresados son muy cortos para ser datos reales", "ERROR");
                    return;
                }

                if (dni == dniViejo)
                {
                    revisarDNI = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se a ingresado un dato invalido", "ERROR");
                return;
            }

            string MensajePersonalizado = aerolineaLogica.Pasajeros.PasajeroModificar(dniViejo, new Pasajero(dni, nombre, apellido),revisarDNI);
            aerolinea.Pasajeros = aerolineaLogica.Pasajeros.PasajeroLeer();
            Actualizar();
            MessageBox.Show(MensajePersonalizado, "Aerolineas");
        }
    }
}
