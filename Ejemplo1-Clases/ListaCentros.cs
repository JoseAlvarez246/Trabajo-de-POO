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
    public partial class ListaCentros : Form
    {
        public ListaCentros()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
           
            
        }

        private void ListaCentros_Load(object sender, EventArgs e)
        {
           
            DgvCentros.DataSource = null;
            DgvCentros.DataSource = Datos.Centros.ToList();
 
        }

        private void DgvCentros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
