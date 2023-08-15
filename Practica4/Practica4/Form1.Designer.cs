namespace Practica4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNombresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panTablero = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cuadro23 = new System.Windows.Forms.Label();
            this.cuadro22 = new System.Windows.Forms.Label();
            this.cuadro33 = new System.Windows.Forms.Label();
            this.cuadro32 = new System.Windows.Forms.Label();
            this.cuadro31 = new System.Windows.Forms.Label();
            this.cuadro21 = new System.Windows.Forms.Label();
            this.cuadro13 = new System.Windows.Forms.Label();
            this.cuadro12 = new System.Windows.Forms.Label();
            this.cuadro11 = new System.Windows.Forms.Label();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panTablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.jugadoresToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(355, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoJuegoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // nuevoJuegoToolStripMenuItem
            // 
            this.nuevoJuegoToolStripMenuItem.Name = "nuevoJuegoToolStripMenuItem";
            this.nuevoJuegoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoJuegoToolStripMenuItem.Text = "Nuevo Juego";
            this.nuevoJuegoToolStripMenuItem.Click += new System.EventHandler(this.nuevoJuegoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarNombresToolStripMenuItem});
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.jugadoresToolStripMenuItem.Text = "Jugadores";
            // 
            // cambiarNombresToolStripMenuItem
            // 
            this.cambiarNombresToolStripMenuItem.Name = "cambiarNombresToolStripMenuItem";
            this.cambiarNombresToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cambiarNombresToolStripMenuItem.Text = "Personalizar";
            this.cambiarNombresToolStripMenuItem.Click += new System.EventHandler(this.cambiarNombresToolStripMenuItem_Click);
            // 
            // panTablero
            // 
            this.panTablero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panTablero.Controls.Add(this.btnSiguiente);
            this.panTablero.Controls.Add(this.cuadro23);
            this.panTablero.Controls.Add(this.cuadro22);
            this.panTablero.Controls.Add(this.cuadro33);
            this.panTablero.Controls.Add(this.cuadro32);
            this.panTablero.Controls.Add(this.cuadro31);
            this.panTablero.Controls.Add(this.cuadro21);
            this.panTablero.Controls.Add(this.cuadro13);
            this.panTablero.Controls.Add(this.cuadro12);
            this.panTablero.Controls.Add(this.cuadro11);
            this.panTablero.Location = new System.Drawing.Point(14, 81);
            this.panTablero.Name = "panTablero";
            this.panTablero.Size = new System.Drawing.Size(330, 330);
            this.panTablero.TabIndex = 2;
            this.panTablero.Paint += new System.Windows.Forms.PaintEventHandler(this.panTablero_Paint);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(128, 202);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(87, 37);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cuadro23
            // 
            this.cuadro23.BackColor = System.Drawing.Color.Transparent;
            this.cuadro23.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadro23.Location = new System.Drawing.Point(225, 115);
            this.cuadro23.Margin = new System.Windows.Forms.Padding(5);
            this.cuadro23.Name = "cuadro23";
            this.cuadro23.Size = new System.Drawing.Size(100, 100);
            this.cuadro23.TabIndex = 8;
            this.cuadro23.Tag = "23";
            this.cuadro23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuadro23.Click += new System.EventHandler(this.clickCuadro);
            // 
            // cuadro22
            // 
            this.cuadro22.BackColor = System.Drawing.Color.Transparent;
            this.cuadro22.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadro22.Location = new System.Drawing.Point(115, 115);
            this.cuadro22.Margin = new System.Windows.Forms.Padding(5);
            this.cuadro22.Name = "cuadro22";
            this.cuadro22.Size = new System.Drawing.Size(100, 100);
            this.cuadro22.TabIndex = 7;
            this.cuadro22.Tag = "22";
            this.cuadro22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuadro22.Click += new System.EventHandler(this.clickCuadro);
            // 
            // cuadro33
            // 
            this.cuadro33.BackColor = System.Drawing.Color.Transparent;
            this.cuadro33.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadro33.Location = new System.Drawing.Point(225, 225);
            this.cuadro33.Margin = new System.Windows.Forms.Padding(5);
            this.cuadro33.Name = "cuadro33";
            this.cuadro33.Size = new System.Drawing.Size(100, 100);
            this.cuadro33.TabIndex = 6;
            this.cuadro33.Tag = "33";
            this.cuadro33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuadro33.Click += new System.EventHandler(this.clickCuadro);
            // 
            // cuadro32
            // 
            this.cuadro32.BackColor = System.Drawing.Color.Transparent;
            this.cuadro32.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadro32.Location = new System.Drawing.Point(115, 225);
            this.cuadro32.Margin = new System.Windows.Forms.Padding(5);
            this.cuadro32.Name = "cuadro32";
            this.cuadro32.Size = new System.Drawing.Size(100, 100);
            this.cuadro32.TabIndex = 5;
            this.cuadro32.Tag = "32";
            this.cuadro32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuadro32.Click += new System.EventHandler(this.clickCuadro);
            // 
            // cuadro31
            // 
            this.cuadro31.BackColor = System.Drawing.Color.Transparent;
            this.cuadro31.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadro31.Location = new System.Drawing.Point(5, 225);
            this.cuadro31.Margin = new System.Windows.Forms.Padding(5);
            this.cuadro31.Name = "cuadro31";
            this.cuadro31.Size = new System.Drawing.Size(100, 100);
            this.cuadro31.TabIndex = 4;
            this.cuadro31.Tag = "31";
            this.cuadro31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuadro31.Click += new System.EventHandler(this.clickCuadro);
            // 
            // cuadro21
            // 
            this.cuadro21.BackColor = System.Drawing.Color.Transparent;
            this.cuadro21.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadro21.Location = new System.Drawing.Point(5, 115);
            this.cuadro21.Margin = new System.Windows.Forms.Padding(5);
            this.cuadro21.Name = "cuadro21";
            this.cuadro21.Size = new System.Drawing.Size(100, 100);
            this.cuadro21.TabIndex = 3;
            this.cuadro21.Tag = "21";
            this.cuadro21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuadro21.Click += new System.EventHandler(this.clickCuadro);
            // 
            // cuadro13
            // 
            this.cuadro13.BackColor = System.Drawing.Color.Transparent;
            this.cuadro13.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadro13.Location = new System.Drawing.Point(225, 5);
            this.cuadro13.Margin = new System.Windows.Forms.Padding(5);
            this.cuadro13.Name = "cuadro13";
            this.cuadro13.Size = new System.Drawing.Size(100, 100);
            this.cuadro13.TabIndex = 2;
            this.cuadro13.Tag = "13";
            this.cuadro13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuadro13.Click += new System.EventHandler(this.clickCuadro);
            // 
            // cuadro12
            // 
            this.cuadro12.BackColor = System.Drawing.Color.Transparent;
            this.cuadro12.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadro12.Location = new System.Drawing.Point(115, 5);
            this.cuadro12.Margin = new System.Windows.Forms.Padding(5);
            this.cuadro12.Name = "cuadro12";
            this.cuadro12.Size = new System.Drawing.Size(100, 100);
            this.cuadro12.TabIndex = 1;
            this.cuadro12.Tag = "12";
            this.cuadro12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuadro12.Click += new System.EventHandler(this.clickCuadro);
            // 
            // cuadro11
            // 
            this.cuadro11.BackColor = System.Drawing.Color.Transparent;
            this.cuadro11.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadro11.Location = new System.Drawing.Point(5, 5);
            this.cuadro11.Margin = new System.Windows.Forms.Padding(5);
            this.cuadro11.Name = "cuadro11";
            this.cuadro11.Size = new System.Drawing.Size(100, 100);
            this.cuadro11.TabIndex = 0;
            this.cuadro11.Tag = "11";
            this.cuadro11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuadro11.Click += new System.EventHandler(this.clickCuadro);
            // 
            // lblJugador1
            // 
            this.lblJugador1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJugador1.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador1.Location = new System.Drawing.Point(14, 49);
            this.lblJugador1.Margin = new System.Windows.Forms.Padding(5);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(110, 18);
            this.lblJugador1.TabIndex = 0;
            this.lblJugador1.Text = "Jugador 1";
            this.lblJugador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJugador2
            // 
            this.lblJugador2.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador2.Location = new System.Drawing.Point(229, 49);
            this.lblJugador2.Margin = new System.Windows.Forms.Padding(5);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(110, 18);
            this.lblJugador2.TabIndex = 1;
            this.lblJugador2.Text = "Jugador 2";
            this.lblJugador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.Location = new System.Drawing.Point(161, 21);
            this.lblSeparador.Margin = new System.Windows.Forms.Padding(0);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(40, 55);
            this.lblSeparador.TabIndex = 8;
            this.lblSeparador.Text = "-";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.Location = new System.Drawing.Point(195, 34);
            this.lblScore2.Margin = new System.Windows.Forms.Padding(0);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(34, 39);
            this.lblScore2.TabIndex = 7;
            this.lblScore2.Text = "0";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(135, 34);
            this.lblScore1.Margin = new System.Windows.Forms.Padding(0);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(34, 39);
            this.lblScore1.TabIndex = 6;
            this.lblScore1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 425);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblJugador2);
            this.Controls.Add(this.lblJugador1);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.panTablero);
            this.Controls.Add(this.lblSeparador);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Gato";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panTablero.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombresToolStripMenuItem;
        private System.Windows.Forms.Panel panTablero;
        private System.Windows.Forms.Label cuadro23;
        private System.Windows.Forms.Label cuadro22;
        private System.Windows.Forms.Label cuadro33;
        private System.Windows.Forms.Label cuadro32;
        private System.Windows.Forms.Label cuadro31;
        private System.Windows.Forms.Label cuadro21;
        private System.Windows.Forms.Label cuadro13;
        private System.Windows.Forms.Label cuadro12;
        private System.Windows.Forms.Label cuadro11;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Button btnSiguiente;

    }
}

