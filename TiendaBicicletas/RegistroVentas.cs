using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaBicicletas
{
    public partial class RegistroVentas : Form
    {
        public RegistroVentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ventanaPrincipal = new Form1();
            ventanaPrincipal.Show();
            this.Close();
        }
    }
}
