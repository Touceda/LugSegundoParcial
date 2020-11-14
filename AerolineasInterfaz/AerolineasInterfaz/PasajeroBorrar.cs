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
    public partial class PasajeroBorrar : Form
    {
        public PasajeroBorrar(Aerolinea aero, AerolineaLogica aeroLog)
        {
            this.aerolinea = aero;
            this.aerolineaLogica = aeroLog;
            InitializeComponent();
        }

        public Aerolinea aerolinea;
        public AerolineaLogica aerolineaLogica;
        private void PasajeroBorrar_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            List<object> lista = new List<object>();         
            foreach (var obj in aerolinea.Pasajeros)
            {
                lista.Add(obj);
            }
            dgvBorrarPasajero.Actualizar(lista);

            if (lista.Count == 0)
            {
                btbBorrar.Enabled = false;
            }
            else
            {
                btbBorrar.Enabled = true;
            }
        }

        private void btbBorrar_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(dgvBorrarPasajero.DevolverInformacion(0,false).ToString());

            if (aerolineaLogica.Pasajeros.PasajeroBorrar(dni) == false)
            {
                MessageBox.Show("Ocurrio un error, no se pudo eliminar el pasajero", "Aerolineas");
            }
            else
            {
                aerolinea.Pasajeros = aerolineaLogica.Pasajeros.PasajeroLeer();
                Actualizar();
                MessageBox.Show("Pasajero Eliminado con Exito", "Aerolineas");
            }
        }
    }
}
