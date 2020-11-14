using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineasInterfaz
{
    public partial class DGV : UserControl
    {
        public DGV()
        {
            InitializeComponent();
        }

        private void DGV_Load(object sender, EventArgs e)
        {
            
        }

        public void Actualizar(List<object>Lista)
        {
            dgvInformacion.DataSource = null;
            dgvInformacion.DataSource = Lista;
        }

        public object DevolverInformacion(int indice,bool isString)
        {
            var fila = dgvInformacion.CurrentRow.Index;
            if (isString)
            {
                object dato = dgvInformacion.Rows[fila].Cells[indice].Value.ToString();
                return dato;
            }
            else
            {
                object dato = int.Parse(dgvInformacion.Rows[fila].Cells[indice].Value.ToString());
                return dato;
            }       
        }


    }
}
