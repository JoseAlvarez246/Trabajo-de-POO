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
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtExp.Text.Length !=0 && TxtTitulacion.Text.Length !=0)
            {
                Alumno Al= new Alumno();
                Al.Exp = TxtExp.Text;
                Al.Tiulacion = TxtTitulacion.Text;
                Datos.Alumnos.Add(Al);
                TxtExp.Clear();
                TxtTitulacion.Clear();
                MessageBox.Show("Se ha guardado el dato");
            }
            else
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
