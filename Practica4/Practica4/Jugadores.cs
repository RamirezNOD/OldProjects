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
    public partial class editJugadores : Form
    {   //Para manipular las propiedades de la forma principal
        public string simbolo1 { get { return txtP1simbolo.Text; } }
        public string simbolo2 { get { return txtP2simbolo.Text; } }
        public string jugador1 { get { return txtP1nombre.Text; } }
        public string jugador2 { get { return txtP2nombre.Text; } }
        public Color colorJ1 { get { return lblP1color.BackColor; } }
        public Color colorJ2 { get { return lblP2color.BackColor; } }

        public editJugadores()
        {
            InitializeComponent();
        }

        private void P1color_click(object sender, EventArgs e)
        {   //Cambiar el color muestra
            lblP1color.BackColor = ((Label)sender).BackColor;
        }

        private void P1simbolo_click(object sender, EventArgs e)
        {   //Cambiar el simbolo muestra
            txtP1simbolo.Text = ((Button)sender).Text;
        }

        private void P2color_click(object sender, EventArgs e)
        {   //Cambiar el color muestra
            lblP2color.BackColor = ((Label)sender).BackColor;
        }

        private void P2simbolo_click(object sender, EventArgs e)
        {   //Cambiar el simbolo muestra
            txtP2simbolo.Text = ((Button)sender).Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {   //Cancelar el cambio
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   //Retornamos un OK al aceptar
            DialogResult = DialogResult.OK;            
        }
    }
}
