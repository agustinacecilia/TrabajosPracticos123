using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticos123.TP1
{
    public partial class Practico1 : Form
    {
        public Practico1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Concatenar los valores de los TextBox de Apellido y Nombre directamente y asignar al TextBox del resultado
            textBox3.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBox3.Clear(); // Limpiar el contenido del TextBox donde muestra el resultado
        }

        private void Practico1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
               Application.Exit(); // Finalizar la aplicacion al presionar Ctrl + S
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Finaliza al presionar el boton Salir
        }
    }
}
