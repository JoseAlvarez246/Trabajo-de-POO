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
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtCategoria.Text.Length !=0 && TxtUnidad.Text.Length != 0)
            {
                Personal Pe = new Personal();
                Pe.Categoria = TxtCategoria.Text;
                Pe.Unidad = TxtUnidad.Text;
                Datos.Personanles.Add( Pe );
                TxtCategoria.Clear();
                TxtUnidad.Clear();
                MessageBox.Show("Se ha guardado el dato");
            }
            MessageBox.Show("No puede dejar ningun campo vacio");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
