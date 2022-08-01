using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPerro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Perro perro = new Perro();
            perro.Nombre = txtNombre.Text;
            perro.Raza = txtRaza.Text;
            perro.Color = txtColor.Text;
            perro.Edad = Convert.ToInt32(mtxtEdad.Text);
            MessageBox.Show("Datos guardados correctamente."+perro.Nombre+" "+perro.Raza+" "+perro.Color+" "+perro.Edad);
        }
    }
}
