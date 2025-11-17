using ProyectoArbolGrafo.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoArbolGrafo.Modelos;
namespace ProyectoArbolGrafo
{
    public partial class Form1 : Form
    {
        private object miGrafoForm1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGRAFO_Click(object sender, EventArgs e)
        {
            GrafoForm grafoForm = new GrafoForm(miGrafoForm1); 
            grafoForm.Show(); // para que se abra en ventana independiente
        }
    }
}
