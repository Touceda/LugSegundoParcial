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
    public partial class DestinoListado : Form
    {
        public DestinoListado(List<Destino> destinos)
        {
            this.Destinos = destinos;
            InitializeComponent();
        }
        private List<Destino> Destinos;
        private void DestinoListado_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            List<object> lista = new List<object>();
            foreach (var obj in Destinos)
            {
                lista.Add(obj);
            }
            dgvDestinosListados.Actualizar(lista);
        }
    }
}
