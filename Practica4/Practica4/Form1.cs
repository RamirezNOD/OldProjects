using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form1 : Form
    {   //Variables editables en la segunda forma
        string simbolo1 = "X";
        string simbolo2 = "O";
        string jugador1 = "Jugador 1";
        string jugador2 = "Jugador 2";
        Color colorJ1 = Color.RoyalBlue;
        Color colorJ2 = Color.Crimson;

        bool turno = true;      //True -> P1; False -> P2
        int contJugadas = 1;
        Label[] cuadros;
        bool ganado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //Crear un arreglo para manejar los cuadros de juego
            cuadros = new Label[10]{ null,
                cuadro11, cuadro12, cuadro13,
                cuadro21, cuadro22, cuadro23,
                cuadro31, cuadro32, cuadro33 };
            actualizarInfo();   //Dar color y nombres a los jugadores
        }

        private void compararTablero()
        {       //Las 8 posibles condiciones de victoria
                //Dependiendo cual sea la combinacion se mandan como parametros las casillas a marcar
            if (cuadro11.Text == cuadro22.Text && cuadro11.Text == cuadro33.Text && cuadro11.Text != "")  //Horizontal "\"
                victoria(1,5,9);
            else if (cuadro31.Text == cuadro22.Text && cuadro31.Text == cuadro13.Text && cuadro31.Text != "")  //Horizontal "/"
                victoria(7,5,3);
            else if (cuadro11.Text == cuadro12.Text && cuadro11.Text == cuadro13.Text && cuadro11.Text != "")   //Horizontal 1
                victoria(1,2,3);
            else if (cuadro21.Text == cuadro22.Text && cuadro21.Text == cuadro23.Text && cuadro21.Text != "")   //Horizontal 2
                victoria(4,5,6);
            else if (cuadro31.Text == cuadro32.Text && cuadro31.Text == cuadro33.Text && cuadro31.Text != "")   //Horizontal 3
                victoria(7,8,9);
            else if (cuadro11.Text == cuadro21.Text && cuadro11.Text == cuadro31.Text && cuadro11.Text != "")  //Vertical 1
                victoria(1,4,7);
            else if (cuadro12.Text == cuadro22.Text && cuadro12.Text == cuadro32.Text && cuadro12.Text != "")  //Vertical 2
                victoria(2,5,8);
            else if (cuadro13.Text == cuadro23.Text && cuadro13.Text == cuadro33.Text && cuadro13.Text != "")  //Vertical 3
                victoria(3,6,9);
            else if (contJugadas > 8)   //Si no hay condicion de victoria, verificamos si ya se acabo el juego
                empate();
        }

        //Si se da una condicion de victoria...
        private void victoria(int c1, int c2, int c3)
        {
            Color colorGanador; //Coloreamos las casillas que dieron victoria del color del jugador ganador
            if (turno)
                colorGanador = colorJ1;
            else
                colorGanador = colorJ2;
            cuadros[c1].BackColor = colorGanador;
            cuadros[c2].BackColor = colorGanador;
            cuadros[c3].BackColor = colorGanador;

            if (turno)  //Mensaje de victoria
            {
                lblScore1.Text = (Convert.ToInt16(lblScore1.Text) + 1).ToString();
                MessageBox.Show("¡ " + jugador1 + " ha ganado!");
            }                
            else
            {
                lblScore2.Text = (Convert.ToInt16(lblScore2.Text) + 1).ToString();
                MessageBox.Show("¡ " + jugador2 + " ha ganado!");
            }
            btnSiguiente.Visible = true;    //El boton para empezar el siguiente juego
            ganado = true;
        }

        private void empate()
        {   //Si es empate solo damos mensaje de ello y habilitamos el boton para pasar al siguiente
            MessageBox.Show("¡Ha sido un empate!");
            btnSiguiente.Visible = true;            
        }

        private void clickCuadro(object sender, EventArgs e)
        {   //Si aun no esta ganado, podemos seguir
            if (!ganado)
            {   //Si el cuadro seleccionado esta vacio
                if (((Label)sender).Text == "")
                {
                    ((Label)sender).Text = (turno) ? simbolo1 : simbolo2;   //Dependiendo del turno, colocamos el simbolo       
                    if (contJugadas > 4)   //Al tengamos mas de 5 jugadas, empezaremos a comparar
                        compararTablero();
                    contJugadas++;                       
                       
                    turno = !turno;
                    if (turno)  //Agregamos un marco al nombre del jugador que tenga el turno
                    {
                        lblJugador1.BorderStyle = BorderStyle.Fixed3D;
                        lblJugador2.BorderStyle = BorderStyle.None;
                    }
                    else
                    {
                        lblJugador1.BorderStyle = BorderStyle.None;
                        lblJugador2.BorderStyle = BorderStyle.Fixed3D;
                    }
                        
                }
            }        
        }

        private void panTablero_Paint(object sender, PaintEventArgs e)
        {
            //Dibujar el #
            Pen pluma = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pluma, 110, 5, 110, 325);
            e.Graphics.DrawLine(pluma, 220, 5, 220, 325);
            e.Graphics.DrawLine(pluma, 5, 110, 325, 110);
            e.Graphics.DrawLine(pluma, 5, 220, 325, 220);
        }

        private void cambiarNombresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (editJugadores editJ = new editJugadores())   //Para llamar a la segunda forma
            {                                                   //Si retorna un OK, cambiaremos las propiedades
                if (editJ.ShowDialog() == DialogResult.OK)
                {
                    this.jugador1 = editJ.jugador1;
                    this.jugador2 = editJ.jugador2;
                    this.simbolo1 = editJ.simbolo1;
                    this.simbolo2 = editJ.simbolo2;
                    this.colorJ1 = editJ.colorJ1;
                    this.colorJ2 = editJ.colorJ2;
                    actualizarInfo();   //Actualizamos la informacion
                }
            }
        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Para empezar un juego desde cero
            empezarNuevo();
        }

        private void empezarNuevo()
        {   //Reiniciara todo el tablero y reseteara el marcador
            reiniciarTablero();
            lblScore1.Text = "0";
            lblScore2.Text = "0";
        }

        private void reiniciarTablero()
        {   //Quitaremos las restricciones de haber ganado            
            ganado = false;
            btnSiguiente.Visible = false;
            contJugadas = 1;
            for (int i = 1; i < 10; i++)    //Reiniciaremos los cuadros del tablero
            {
                cuadros[i].Text = "";
                cuadros[i].BackColor = Color.Transparent;
            }   
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {   //Al pasar al siguiente juego solo reseteamos el trablero
            reiniciarTablero();
        }

        public void actualizarInfo()
        {   //Actualizar los controles con la informacion de las propiedades
            lblJugador1.Text = jugador1 +"("+simbolo1+")";
            lblJugador2.Text = jugador2 +"("+simbolo2+")";
            lblJugador1.ForeColor = colorJ1;
            lblJugador2.ForeColor = colorJ2;
            lblScore1.ForeColor = colorJ1;
            lblScore2.ForeColor = colorJ2;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Cerrar aplicacion
            this.Close();
        }
    }
}
