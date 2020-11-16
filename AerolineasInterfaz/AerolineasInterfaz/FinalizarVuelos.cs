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
    public partial class FinalizarVuelos : Form
    {
        public FinalizarVuelos(Aerolinea aero, AerolineaLogica aeroLog,bool iSComun)
        {
            this.aerolinea = aero;
            this.aerolineaLogica = aeroLog;
            this.isComun = iSComun;
            InitializeComponent();
        }

        private bool isComun;
        public Aerolinea aerolinea;
        public AerolineaLogica aerolineaLogica;

        private void FinalizarVuelos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            List<object> objetos = new List<object>();

            if (isComun)
            {
                objetos.AddRange(aerolinea.VuelosComunes.ToArray());
            }
            else
            {
                objetos.AddRange(aerolinea.VuelosInternacionales.ToArray());
            }

            dgvVuelos.Actualizar(objetos);
        }

        private void btbFinalizarVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (isComun)
                {
                    FinalizarVueloComun();
                }
                else
                {
                    FinalizarVueloInternacional();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Aerolineas");
                throw;
            }      
        }

        private void FinalizarVueloComun()
        {
            string destino = "";
            string pais = "----";
            string ciudad = "----";
            string partida = "";
            string llegada = "";
            int asiento = 0;
            int ocupacion = 0;


        
        }

        private void FinalizarVueloInternacional()
        {


        }


    }
}
