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
    public partial class ListaProfesor : Form
    {
        public ListaProfesor()
        {
            InitializeComponent();
        }

        private void ListaProfesor_Load(object sender, EventArgs e)
        {
            DgvProfesor.DataSource = null;
            DgvProfesor.DataSource = Datos.Profesores.ToList();

        }

        private void DgvProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
