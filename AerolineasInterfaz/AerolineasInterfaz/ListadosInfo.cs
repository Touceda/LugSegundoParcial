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
    public partial class ListadosInfo : Form
    {
        public ListadosInfo(List<object> objetos)
        {
            this.Objetos = objetos;
            InitializeComponent();
        }
        public List<object> Objetos;
        private void ListadosInfo_Load(object sender, EventArgs e)
        {
            dgvInfo.Actualizar(Objetos);
        }
    }
}
