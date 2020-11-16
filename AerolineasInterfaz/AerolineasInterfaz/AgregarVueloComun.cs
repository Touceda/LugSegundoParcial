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
    public partial class AgregarVueloComun : Form
    {
        public AgregarVueloComun(Aerolinea aero, AerolineaLogica aeroLogica)
        {
            this.aerolinea = aero;
            this.aerolineaLogica = aeroLogica;
            this.destinos = aerolinea.Destinos;
            InitializeComponent();
        }

        public Aerolinea aerolinea;
        public AerolineaLogica aerolineaLogica;
        public List<Destino> destinos;
        private void AgregarVueloComun_Load(object sender, EventArgs e)
        {
            if (destinos.Count == 0)
            {
                MessageBox.Show("No se puede crear un vuelo, ya que no hay destinos cargados en nuestra base de datos", "Aerolineas");
                this.Close();
            }
            rellenarListas();
        }


        public void rellenarListas()
        {
            foreach (var destino in destinos)
            {
                string item = destino.Id.ToString() + " " + destino.LugarDestino.ToString();
                lbDestinos.Items.Add(item);
            }

            var horarios = CrearHorarios();

            lbH1.Items.AddRange(horarios.ToArray());
            lbH2.Items.AddRange(horarios.ToArray());

        }
        private List<string> CrearHorarios()
        {
            List<string> Horarios = new List<string>();
            Horarios.Add("00:00");
            Horarios.Add("00:30");
            Horarios.Add("01:00");
            Horarios.Add("01:30");
            Horarios.Add("02:00");
            Horarios.Add("02:30");
            Horarios.Add("03:00");
            Horarios.Add("03:30");
            Horarios.Add("04:00");
            Horarios.Add("04:30");
            Horarios.Add("05:00");
            Horarios.Add("05:30");
            Horarios.Add("06:00");
            Horarios.Add("06:30");
            Horarios.Add("07:00");
            Horarios.Add("07:30");
            Horarios.Add("08:00");
            Horarios.Add("08:30");
            Horarios.Add("09:00");
            Horarios.Add("09:30");
            Horarios.Add("10:00");
            Horarios.Add("10:30");
            Horarios.Add("11:00");
            Horarios.Add("11:30");
            Horarios.Add("12:00");
            Horarios.Add("12:30");
            Horarios.Add("13:00");
            Horarios.Add("13:30");
            Horarios.Add("14:00");
            Horarios.Add("14:30");
            Horarios.Add("15:00");
            Horarios.Add("15:30");
            Horarios.Add("16:00");
            Horarios.Add("16:30");
            Horarios.Add("17:00");
            Horarios.Add("17:30");
            Horarios.Add("18:00");
            Horarios.Add("18:30");
            Horarios.Add("19:00");
            Horarios.Add("19:30");
            Horarios.Add("20:00");
            Horarios.Add("20:30");
            Horarios.Add("21:00");
            Horarios.Add("21:30");
            Horarios.Add("22:00");
            Horarios.Add("22:30");
            Horarios.Add("23:00");
            Horarios.Add("23:30");
            return Horarios;
        }

        private void btbAltaVuelo_Click(object sender, EventArgs e)
        {
            if (lbDestinos.SelectedItem == null || lbH1.SelectedItem == null || lbH2.SelectedItem == null)
            {
                MessageBox.Show("Ocurruo un Error, Dejaste algo sin marcar?, o ingresaste un dato invalido?, Intentelo nuevamente mas tarde", "Aerolineas");
                return;
            }

            try
            {
                string destino = lbDestinos.SelectedItem.ToString();
                int id = BuscarIdDestino(destino);
                foreach (var dest in destinos)
                {
                    if (dest.Id == id)
                    {
                        destino = dest.LugarDestino;
                    }
                }

                DateTime fehcaPartida = dtbFechaSalida.Value;
                DateTime fehcaLlegada = dtpFechaLlegada.Value;

                string partida = dtbFechaSalida.Value.Day.ToString() + "/" + dtbFechaSalida.Value.Month + "/" + dtbFechaSalida.Value.Year + " " + lbH1.SelectedItem.ToString();
                string llegada = dtpFechaLlegada.Value.Day.ToString() + "/" + dtpFechaLlegada.Value.Month + "/" + dtpFechaLlegada.Value.Year + " " + lbH2.SelectedItem.ToString();

                int asientos = int.Parse(txtNroAsientos.Text.ToString());

                var vuelo = new Vuelo(destino, partida, llegada, asientos, 0, 0);

                string mensaje = aerolineaLogica.Vuelos.VueloAñadir(vuelo);
                aerolinea.VuelosComunes = aerolineaLogica.Vuelos.VuelosComunesLeer();
                MessageBox.Show(mensaje, "Aerolineas");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurruo un Error, Dejaste algo sin marcar?, o ingresaste un dato invalido?, Intentelo nuevamente mas tarde", "Aerolineas");
            } 
          
        }

        private int BuscarIdDestino(string destino)
        {
            string id = "";
            for (int i = 0; i < destino.Length; i++)
            {
                switch (destino[i].ToString())
                {
                    case "1": { id += "1"; break; }
                    case "2": { id += "2"; break; }
                    case "3": { id += "3"; break; }
                    case "4": { id += "4"; break; }
                    case "5": { id += "5"; break; }
                    case "6": { id += "6"; break; }
                    case "7": { id += "7"; break; }
                    case "8": { id += "8"; break; }
                    case "9": { id += "9"; break; }
                    case "0": { id += "0"; break; }
                    default:
                        {
                            return int.Parse(id.ToString());
                        }
                }
            }
            return int.Parse(id.ToString());
        }

    }
}
