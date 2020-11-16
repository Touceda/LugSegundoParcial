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
    public partial class EliminarVuelos : Form
    {
        public EliminarVuelos(Aerolinea aero, AerolineaLogica aeroLog)
        {
            this.aerolinea = aero;
            this.aerolineaLogica = aeroLog;
            InitializeComponent();
        }
        public Aerolinea aerolinea;
        public AerolineaLogica aerolineaLogica;
        private void EliminarVueloComun_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            //Vuelo Comun
            List<object> listaComun = new List<object>();
            foreach (var obj in aerolinea.VuelosComunes)
            {
                listaComun.Add(obj);
            }

            dgvBorrarVC.Actualizar(listaComun);

            if (listaComun.Count == 0)
            {
                btbBorrarC.Enabled = false;
            }
            else
            {
                btbBorrarC.Enabled = true;
            }

            //Vuelo Internacional
            List<object> listaInternacional = new List<object>();
            foreach (var obj in aerolinea.VuelosInternacionales)
            {
                listaInternacional.Add(obj);
            }
            dgvBorrarVI.Actualizar(listaInternacional);

            if (listaInternacional.Count == 0)
            {
                btbBorrarI.Enabled = false;
            }
            else
            {
                btbBorrarI.Enabled = true;
            }

        }

        private void btbBorrarC_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvBorrarVC.DevolverInformacion(0, false).ToString());

            if (aerolineaLogica.Vuelos.VueloBorrar(id,true) == false)
            {
                MessageBox.Show("Ocurrio un error, no se pudo eliminar el Vuelo", "Aerolineas");
            }
            else
            {
                aerolinea.VuelosComunes = aerolineaLogica.Vuelos.VuelosComunesLeer();
                Actualizar();
                MessageBox.Show("Vuelo Eliminado con Exito", "Aerolineas");
            }
        }

        private void btbBorrarI_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvBorrarVI.DevolverInformacion(2, false).ToString());

            if (aerolineaLogica.Vuelos.VueloBorrar(id, false) == false)
            {
                MessageBox.Show("Ocurrio un error, no se pudo eliminar el Vuelo", "Aerolineas");
            }
            else
            {
                aerolinea.VuelosInternacionales = aerolineaLogica.Vuelos.VuelosInternacionalesLeer();
                Actualizar();
                MessageBox.Show("Vuelo Eliminado con Exito", "Aerolineas");
            }
        }
    }




}

