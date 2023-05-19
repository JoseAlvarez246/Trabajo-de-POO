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
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtInss.Text.Length !=0 && TxtSalario.Text.Length != 0)
            {
                Profesor Pf = new Profesor();
                Pf.Salario = Convert.ToDouble(TxtSalario.Text);
                Pf.INSS= TxtInss.Text;
                Datos.Profesores.Add(Pf);
                TxtSalario.Clear();
                TxtInss.Clear();
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
