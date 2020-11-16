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
    public partial class VuelosFinalizados : Form
    {
        public VuelosFinalizados(List<VueloInternacional> vuelosFinalizadosObj)
        {
            this.VuelosFinalizadosObj = vuelosFinalizadosObj;
            InitializeComponent();
        }
        private List<VueloInternacional> VuelosFinalizadosObj;

        private void VuelosFinalizados_Load(object sender, EventArgs e)
        {
            Actualizar(true);
        }

        public void Actualizar(bool isTodo)
        {
            List<object> VuelosFinalizadosSeleccionados = new List<object>();
            if (isTodo)
            {
                VuelosFinalizadosSeleccionados.AddRange(VuelosFinalizadosObj.ToArray()) ;
                dgvVuelosFinalizados.Actualizar(VuelosFinalizadosSeleccionados);
            }
            else
            {
                
                foreach (var vuelo in VuelosFinalizadosObj)
                {
                    if (vuelo.ocupacion <= 40) 
                    {
                        VuelosFinalizadosSeleccionados.Add(vuelo);
                    }
                }
                dgvVuelosFinalizados.Actualizar(VuelosFinalizadosSeleccionados);
            }
        }

        private void btbOcupacion_Click(object sender, EventArgs e)
        {
            Actualizar(false);
        }

        private void btbVerTodo_Click(object sender, EventArgs e)
        {
            Actualizar(true);
        }

   
    }
}
