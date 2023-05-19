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
    public partial class FrmCentro : Form
    {
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtDireccion.Text.Length !=0 && TxtEmail.Text.Length !=0 && TxtNombre.Text.Length !=0 && TxtTelefono.Text.Length != 0)
            {
               
                Centro ct = new Centro();
                ct.Nombre = TxtNombre.Text;
                ct.Dir = TxtDireccion.Text;
                ct.Telf = TxtEmail.Text;
                ct.Email = TxtEmail.Text;
                Datos.Centros.Add(ct);
                TxtDireccion.Clear();
                TxtEmail.Clear();
                TxtNombre.Clear();
                TxtTelefono.Clear();
                MessageBox.Show("Se ha guardado el dato");
                
                
            }
            else
                MessageBox.Show("No puede dejar ningun campo vacio");
        }

        private void FrmCentro_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
