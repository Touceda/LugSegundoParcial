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
    public partial class VerVuelosPasajeros : Form
    {
        public VerVuelosPasajeros(Aerolinea aero, AerolineaLogica aeroLog,bool isComun)
        {
            this.aerolinea = aero;
            this.aerolineaLogica = aeroLog;
            this.IsComun = isComun;
            InitializeComponent();
        }
        public Aerolinea aerolinea;
        public AerolineaLogica aerolineaLogica;
        private bool IsComun;

        private void VerVuelosPasajeros_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            List<object> vuelos = new List<object>();
            if (IsComun)
            {
                vuelos.AddRange(aerolinea.VuelosComunes.ToArray());
                dgv1.Actualizar(vuelos);
            }
            else
            {
                vuelos.AddRange(aerolinea.VuelosInternacionales.ToArray());
                dgv1.Actualizar(vuelos);
            }     
        }

        private void btbVerVuelo_Click(object sender, EventArgs e)
        {
            Actualizar2();
        }

        private void Actualizar2()
        {
            List<object> pasajeros = new List<object>();
            List<VueloPasajero> vueloPasajero = new List<VueloPasajero>();
            if (IsComun)
            {
                int id = int.Parse(dgv1.DevolverInformacion(0,false).ToString());
                vueloPasajero = aerolineaLogica.Vuelos.BuscarVueloPasajeros(true);

                foreach (var vueloP in vueloPasajero)
                {
                    if (id == vueloP.NroVuelo) 
                    {
                        int dni = vueloP.Dni;
                        foreach (var pasajero in aerolinea.Pasajeros)
                        {
                            if (dni == pasajero.Dni)
                            {
                                pasajeros.Add(pasajero);
                            }
                        }
                        
                    }            
                }
                dgv2.Actualizar(pasajeros);
            }
            else
            {
                int id = int.Parse(dgv1.DevolverInformacion(2, false).ToString());
                vueloPasajero = aerolineaLogica.Vuelos.BuscarVueloPasajeros(false);

                foreach (var vueloP in vueloPasajero)
                {
                    if (id == vueloP.NroVuelo)
                    {
                        int dni = vueloP.Dni;
                        foreach (var pasajero in aerolinea.Pasajeros)
                        {
                            if (dni == pasajero.Dni)
                            {
                                pasajeros.Add(pasajero);
                            }
                        }
                    }
                }
                dgv2.Actualizar(pasajeros);
            }
        
        }

    }
}
