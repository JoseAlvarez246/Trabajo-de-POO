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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentro Fc = new FrmCentro();
            this.Hide();
            Fc.Show();

        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCentros Lc = new ListaCentros();
            this.Hide();
            Lc.Show();

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfesor Fc = new FrmProfesor();
            this.Hide();
            Fc.Show();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProfesor Fc = new ListaProfesor();
            this.Hide();
            Fc.Show();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEstudiante Es = new FrmEstudiante();
            this.Hide();
            Es.Show();

        }

        private void listarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEstudiantes Es = new ListaEstudiantes();
            this.Hide();
            Es.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPersonal Pe = new FrmPersonal();
            this.Hide();
            Pe.Show();

        }

        private void listaDeTarbajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPersonal Pe = new ListaPersonal();
            this.Hide();
            Pe.Show();
        }
    }
}
