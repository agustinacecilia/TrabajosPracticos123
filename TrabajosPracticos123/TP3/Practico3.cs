using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticos123.TP3
{
    public partial class Practico3 : Form
    {
        public Practico3()
        {
            InitializeComponent();
        }



        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                // Si el recurso es un byte[] en lugar de una Image, conviértelo a Image
                byte[] imageData = Properties.Resources.varon;  // Si varon es byte[]
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                byte[] imageData = Properties.Resources.mujer;  // Si mujer es byte[]
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void Practico3_Load(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter no es un número y no es una tecla de control (ej. Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Muestra un MessageBox de alerta
                MessageBox.Show("Solo puede ingresar números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Cancela el evento KeyPress para evitar que el carácter se ingrese en el TextBox
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado no es una letra y no es una tecla de control (ej. Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mostrar un MessageBox de alerta
                MessageBox.Show("Solo puede ingresar letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Cancelar el evento KeyPress para evitar que el carácter se ingrese en el TextBox
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado no es una letra y no es una tecla de control (ej. Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mostrar un MessageBox de alerta
                MessageBox.Show("Solo puede ingresar letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Cancelar el evento KeyPress para evitar que el carácter se ingrese en el TextBox
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TDni.Text) || string.IsNullOrWhiteSpace(TNombre.Text) || string.IsNullOrWhiteSpace(TApellido.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Crear la variable "ask" del tipo MsgBoxResult
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                // Si el usuario selecciona "Sí", se procede con la inserción de los datos
                if (ask == DialogResult.Yes)
                {
                    // Modificar el texto del Label LModificar con Nombre y Apellido
                    string nombreCompleto = $"{TNombre.Text} {TApellido.Text}";
                    LModificar.Text = nombreCompleto;

                    // Mostrar un mensaje de información con el nombre del cliente que se registró
                    MessageBox.Show($"El Cliente: {nombreCompleto} se insertó correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre completo del cliente a eliminar
            string nombreCompleto = $"{TNombre.Text} {TApellido.Text}";
            string mensajeEliminar = $"Está a punto de eliminar el Cliente: {nombreCompleto}".Trim();

            // Mostrar un mensaje de advertencia con el foco en la opción "No"
            DialogResult confirmacion = MessageBox.Show(mensajeEliminar,
                                                        "Confirmar Eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Exclamation,
                                                        MessageBoxDefaultButton.Button2);

            // Si el usuario selecciona "Sí", se procede con la eliminación
            if (confirmacion == DialogResult.Yes)
            {
                // Mostrar un mensaje de confirmación que se eliminó correctamente
                MessageBox.Show($"El Cliente: {nombreCompleto} se eliminó correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos de texto y el Label LModificar
                TDni.Clear();
                TNombre.Clear();
                TApellido.Clear();
                LModificar.Text = string.Empty;
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {
            // Actualizar el texto del Label LModificar con Nombre y Apellido
            ActualizarLabelModificar();
        }

        private void ActualizarLabelModificar()
        {
            // Actualizar el texto del Label LModificar con Nombre y Apellido
            string nombreCompleto = $"{TNombre.Text} {TApellido.Text}";
            LModificar.Text = nombreCompleto;
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {
            // Actualizar el texto del Label LModificar con Nombre y Apellido
            ActualizarLabelModificar();
        }

        private void TDni_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verifica si el carácter no es un número y no es una tecla de control (ej. Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Muestra un MessageBox de alerta
                MessageBox.Show("Solo puede ingresar números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Cancela el evento KeyPress para evitar que el carácter se ingrese en el TextBox
                e.Handled = true;
            }
        }
    }
}
