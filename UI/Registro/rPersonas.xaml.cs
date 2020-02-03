using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Drawing;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RegistroPersona.Entidades;
using RegistroPersona.BLL;

using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;



namespace RegistroPersona.UI.Registro
{
    /// <summary>
    /// Interaction logic for rPersonas.xaml
    /// </summary>
    public partial class rPersonas : Window
    {
        public rPersonas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            //IdTextBox.Text = string.Empty;
            IdTextBox.Text = string.Empty;

            //Convert.ToInt32(this.IdTextbox.Text); 
            NombreTextbox.Text = string.Empty;
            TelefonoTextbox.Text = string.Empty;
            CedulaTextbox.Text = string.Empty;
            DireccionTextbox.Text = string.Empty;
           // FechaNacimientoDatePicker.Value = DateTime.Now;
            //FechaNacimientoDatePicker.Text = "";
          ///  textBox3_Direccion.Text = string.Empty;
           // textBox4_Email.Text = string.Empty;
           // textBox5_Balance.Text = textBox5_Balance.Text;
           // dateTimePicker1.Value = DateTime.Now;
          //  comboBox1.SelectedIndex = 0;
           
        }


        private Personas LlenaClase()
        {
           Personas personas = new Personas();
          /*  personas.EstudianteId = Convert.ToInt32(numericUpDown1_id.Value);
            estudiante.Matricula = maskedTextBox1_Matricula.Text;
            estudiante.Nombre = textBox1_Nombre.Text;
            estudiante.Apellidos = textBox2_Apellidos.Text;
            estudiante.Telefono = maskedTextBox2_Telefono.Text;
            estudiante.Cedula = maskedTextBox3_Cedula.Text;
            estudiante.Direccion = textBox3_Direccion.Text;
            estudiante.Email = textBox4_Email.Text;
            estudiante.Balance = Convert.ToDecimal(textBox5_Balance.Text);
            estudiante.Sexo = comboBox1.Text;*/
            return personas;
        }

        private void LlenaCampo(Personas personas)
        {
          /*  numericUpDown1_id.Value = estudiante.EstudianteId;
            maskedTextBox1_Matricula.Text = estudiante.Matricula;
            textBox1_Nombre.Text = estudiante.Nombre;
            textBox2_Apellidos.Text = estudiante.Apellidos;
            maskedTextBox3_Cedula.Text = estudiante.Cedula;
            textBox3_Direccion.Text = estudiante.Direccion;
            textBox4_Email.Text = estudiante.Email;
            textBox5_Balance.Text = estudiante.Balance.ToString();

            dateTimePicker1.Value = estudiante.FechaNacimiento;*/

            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }
    }
}
