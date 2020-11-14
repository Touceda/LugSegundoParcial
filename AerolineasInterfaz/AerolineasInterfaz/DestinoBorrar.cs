using AerolineasImplementacion;
using AerolineasObjetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineasInterfaz
{
    public partial class DestinoBorrar : Form
    {
        public DestinoBorrar(Aerolinea aero, AerolineaLogica aeroLog)
        {
            this.aerolinea = aero;
            this.aerolineaLogica = aeroLog;
            InitializeComponent();
        }
        public Aerolinea aerolinea;
        public AerolineaLogica aerolineaLogica;
        private void DestinoBorrar_Load(object sender, EventArgs e)
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
            dgvBorrarDestino.Actualizar(lista);

            if (lista.Count == 0) 
            {
                btbBorrar.Enabled = false;
            }
            else
            {
                btbBorrar.Enabled = true;
            }
        }

        private void btbBorrar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvBorrarDestino.DevolverInformacion(0, false).ToString());

            if (aerolineaLogica.Destinos.DestinoBorrar(id) == false)
            {
                MessageBox.Show("Ocurrio un error, no se pudo eliminar el Destino", "Aerolineas");
            }
            else
            {
                aerolinea.Destinos = aerolineaLogica.Destinos.DestinosLeer();
                Actualizar();
                MessageBox.Show("Destino Eliminado con Exito", "Aerolineas");
            }
        }
    }
}
