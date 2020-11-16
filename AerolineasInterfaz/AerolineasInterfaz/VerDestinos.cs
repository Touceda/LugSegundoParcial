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
using System.Diagnostics;

namespace AerolineasInterfaz
{
    public partial class VerDestinos : Form
    {
        public VerDestinos(List<object>destinos)
        {
            this.Destinos = destinos;
            InitializeComponent();
        }
        private List<object> Destinos;

        private void VerDestinos_Load(object sender, EventArgs e)
        {
            dgv1.Actualizar(Destinos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string link = dgv1.DevolverInformacion(2, true).ToString();
            Process.Start("chrome",link);
        }

  
    }
}
