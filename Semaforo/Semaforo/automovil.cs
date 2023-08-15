using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class automovil : Form
    {
        Random rnd = new Random();
        int index;
        Image[] carros;
        string[] marca;
        string[] modelo;
        string[] nombres;
        string[] apellidos;

        public automovil(int color)
        {
            InitializeComponent();
            index = color;
        }

        private void automovil_Load(object sender, EventArgs e)
        {
            carros = new Image[] { Properties.Resources.carroAzul, Properties.Resources.carroRojo, Properties.Resources.carroVerde, Properties.Resources.carroAmarilo};
            marca = new string[] {"Ford","Ford", "Chevrolet","Toyota" };
            modelo = new string[] { "Mustang", "Focus", "Spark", "Agya" };
            nombres = new string[] { "Jose Manuel", "Hugo", "Gisel", "Isaac", "Ricardo", "Oswaldo","Mariana" };
            apellidos = new string[] { "Raso Padilla", "Hernandez", "Leon", "Olivas","Tejada","Franco","Ramirez"};

            pictureBox1.Image = carros[index];
            txtPlacas.Text = RandomString(7);
            txtMarca.Text = marca[index];
            txtModelo.Text = modelo[index];
            txtNombre.Text = nombres[rnd.Next(0, 7)];
            txtApellido.Text = apellidos[rnd.Next(0, 7)];
            txtEdad.Text = rnd.Next(18, 43).ToString();
        }


        //dtb (Aug 27 '09)
        //Liam (edit Mar 1 '19)
        //https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}
