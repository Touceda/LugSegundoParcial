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

namespace AerolineasInterfaz
{
    public partial class PasajeroListado : Form
    {
        public PasajeroListado(List<Pasajero> pasajeros)
        {
            this.Pasajeros = pasajeros;
            InitializeComponent();
        }

        private List<Pasajero> Pasajeros;
        private void PasajeroListado_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            List<object> lista = new List<object>();
            foreach (var obj in Pasajeros)
            {
                lista.Add(obj);
            }
            dgvPasajerosLista.Actualizar(lista);
        }
    }
}
