using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class ListaPersonal : Form
    {
        public ListaPersonal()
        {
            InitializeComponent();
        }

        private void ListaPersonal_Load(object sender, EventArgs e)
        {
            DgvPersonal.DataSource = null;
            DgvPersonal.DataSource = Datos.Personanles.ToList();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
