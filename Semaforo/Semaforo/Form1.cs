using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

//Ramirez Gonzalez Leonardo
//[28/04/19]

namespace Semaforo
{
    public partial class Form1 : Form
    {        
        //Este objeto se usa para sincronizar los hilos que manejan los 4 semaforos
        ManualResetEvent[] mre = new ManualResetEvent[4] {new ManualResetEvent(true) , new ManualResetEvent(true) , new ManualResetEvent(true) , new ManualResetEvent(true)}; //en un arreglo sera mas sencillo
        //Se usara para mover los carros que se vayan generando
        List<PictureBox>[] carrosMovimiento = new List<PictureBox>[4] { new List<PictureBox>(), new List<PictureBox>(), new List<PictureBox>(), new List<PictureBox>() };
        
        Image[,] carro;         //Arreglo con los Sprites        
        Point[] inicioCarro;    //Puntos de inicio de los carros generados        
        PictureBox[] semaforos; //Arreglo para controlar los semaforos        
        Random rnd = new Random();  //Un Random global
        int avance = 10;            //El avance de los carros
        int nSemaforo;              //numero del semaforo comparado

        //Hilos para mover los carros
        Thread thread_moverCarros1;
        Thread thread_moverCarros2;
        Thread thread_moverCarros3;
        Thread thread_moverCarros4;
        //Hilos para controlar los semaforos
        Thread thread_semaforo1;
        Thread thread_semaforo2;
        Thread thread_semaforo3;
        Thread thread_semaforo4;
        //Hilos para controlar el trafico del puente
        Thread thread_puente1;
        Thread thread_puente2;
        //Hilo para la imagen
        Thread vigilarSemaforo;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarArreglos();   //Para cargar los arreglos y tener esto limpio
        }        

        private void btnEmpezar_Click(object sender, EventArgs e)
        {   //Inhabilitamos el boton
            btnEmpezar.Enabled = false;
            btnEmpezar.Text = "...";

            //Comenzamos hilos para mover
            thread_moverCarros1 = new Thread(() => moverCarros(0));
            thread_moverCarros2 = new Thread(() => moverCarros(1));
            thread_moverCarros3 = new Thread(() => moverCarros(2));
            thread_moverCarros4 = new Thread(() => moverCarros(3));
            thread_moverCarros3.Start();
            thread_moverCarros2.Start();
            thread_moverCarros1.Start();
            thread_moverCarros4.Start();
            //Comenzamos los hilos de los semaforos
            thread_semaforo1 = new Thread(() => hilo_semaforos(0));
            thread_semaforo2 = new Thread(() => hilo_semaforos(1));
            thread_semaforo3 = new Thread(() => hilo_semaforos(2));
            thread_semaforo4 = new Thread(() => hilo_semaforos(3));
            thread_semaforo1.Start();
            thread_semaforo2.Start();
            thread_semaforo3.Start();
            thread_semaforo4.Start();
            //Comenzamos el hilo para los puentes
            thread_puente1 = new Thread(() => puente(true));            
            thread_puente2 = new Thread(() => puente(false));
            thread_puente1.Start();
            thread_puente2.Start();
            //Mandamos Set para empezar
            mre[3].Set();
        }

        public void puente(bool puen1)
        {
            PictureBox nuevoCarro;
            List<PictureBox> carrosActuales = new List<PictureBox>();
            int color = 0;
            bool listo = true;

            int avanzar = 0;
            int posInicial = 0;
            int direccion = 0;
            PictureBox picPuente;
            if (puen1)  //Si es puente 1...
            {
                avanzar = -avance;
                posInicial = picPuente1.Width + 50;
                direccion = 1;
                picPuente = picPuente1;
            }
            else   //Si es puente 2...
            {
                avanzar = avance;
                posInicial = -50;
                direccion = 2;
                picPuente = picPuente2;
            }

            while (true)
            {
                listo = true;
                for (int i = 0; i < carrosActuales.Count; i++)
                {
                    carrosActuales[i].Left += avanzar;

                    if ((carrosActuales[i].Left > picPuente1.Width * 0.75 && puen1) || (carrosActuales[i].Left < picPuente1.Width * 0.25 && !puen1))
                        listo = false;
                    if ((carrosActuales[i].Left < -50 && puen1) || carrosActuales[i].Left > picPuente2.Width + 50 && !puen1)
                    {
                        picPuente.Controls.Remove(carrosActuales[i]);
                        carrosActuales.RemoveAt(i);
                    }
                }

                if (rnd.Next(0, 10) == 0 && listo)
                {
                    try
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            color = rnd.Next(0, 4);
                            nuevoCarro = new PictureBox();
                            picPuente.Controls.Add(nuevoCarro);
                            nuevoCarro.BackColor = Color.Transparent;
                            nuevoCarro.SizeMode = PictureBoxSizeMode.StretchImage;
                            nuevoCarro.Location = new Point(posInicial, 4);
                            nuevoCarro.Size = new Size(40, 40);
                            nuevoCarro.Image = carro[color, direccion];
                            carrosActuales.Add(nuevoCarro);
                            nuevoCarro.Tag = "0,"+color.ToString();
                            nuevoCarro.Click += new EventHandler(carro_Click);  //Se le agrega un evento click
                        });
                    }
                    catch { }
                }

                Thread.Sleep(30);
            }
        }

        public void hilo_semaforos(int nSem)
        {
            int mreWait = 0;    //el ManualResetEvent que esperara
            int mreSet = nSem;  //el ManualResetEvent que activara

            if (nSem == 0)      //Se espera al anterior siempre,
                mreWait = 3;    //Con esta excepcion
            else
                mreWait = nSem - 1;

            while (true)    //Ciclo eterno
            {
                mre[mreWait] = new ManualResetEvent(false); //Esperaremos a que se active el MRE
                mre[mreWait].WaitOne(); 
                semaforos[nSem].BackColor = Color.DarkSeaGreen; //Cambiamos a verde
                Thread.Sleep(3000);                             //3 segundos...
                semaforos[nSem].BackColor = Color.Yellow;       //Cambias a amarillo
                Thread.Sleep(2000);                             //2 segundos
                semaforos[nSem].BackColor = Color.Red;          //Cambiar a rojo
                Thread.Sleep(1000);                             //1 segundo, para dar margen
                if (nSem == 0)      //Si estamos con el semaforo 0
                {                   //Activamos los siguientes dos semaforos
                    mre[0].Set();
                    mre[1].Set();
                }
                else
                    mre[mreSet].Set();  //Activamos el semaforo siguiente
            }
        }

        //¡YA ME CANSE DE COMENTAR!

        public void moverCarros(int nCalle) //Mover los carros, segun su calle
        {
            PictureBox nuevoCarro;  //los carros que generaremos
            Point posInicial = inicioCarro[nCalle]; //posicion inicial segun la calle

            //Lista de Arrelgos para los obstaculos que se presenten
            List<PictureBox> ultimoObstaculo = new List<PictureBox>() {semaforos[nCalle]};  

            //Variables poderosas
            int color = 0;
            int avanzarX = 0;
            int avanzarY = 0;
            int colorCarro = 0;
            int ruta = 0;
            int carroContado = 0;
            bool generar = true;

            switch (nCalle)
            {
                case 0:
                    avanzarY = avance; break;
                case 1:
                    avanzarX = -avance; break;
                case 2:
                    avanzarX = avance; break;
                case 3:
                    avanzarY = -avance; break;
            }

            while (true)
            {
                generar = true;
                if (carrosMovimiento[nCalle] != null)   //Si hay carros moviendose...
                {
                    for (int i = 0; i < carrosMovimiento[nCalle].Count; i++)    //Para mover carros
                    {
                        //Datos sacados del TAG
                        ruta = Convert.ToInt16((carrosMovimiento[nCalle][i].Tag.ToString()).Split(',')[0]);
                        colorCarro = Convert.ToInt16((carrosMovimiento[nCalle][i].Tag.ToString()).Split(',')[1]);
                        carroContado = Convert.ToInt16((carrosMovimiento[nCalle][i].Tag.ToString()).Split(',')[2]);

                        if (ruta != 0)  //Si aun no esta por terminar la ruta...
                        {   //Mover el carro
                            carrosMovimiento[nCalle][i].Left += avanzarX;
                            carrosMovimiento[nCalle][i].Top += avanzarY;

                            switch (ruta) //Calcular final de la ruta segun la calle
                            {
                                case 1:
                                    if (carrosMovimiento[0][i].Top >= inicioCarro[1].Y)     //Si llega a la otra calle...
                                    {
                                        carrosMovimiento[0][i].Image = carro[colorCarro, 1];                //Cambiamos la direccion
                                        carrosMovimiento[0][i].Top = inicioCarro[1].Y;                      //Alineamos el carro
                                        carrosMovimiento[0][i].Tag = "5," + colorCarro.ToString() + ",1";   //Cambiamos el tag
                                        carrosMovimiento[1].Add(carrosMovimiento[0][i]);                    //Añadimos a la lista de la otra calle
                                        carrosMovimiento[0].RemoveAt(i);                                    //Lo quitamos de la lista anterior
                                    }
                                    break;
                                case 2:
                                    if (carrosMovimiento[0][i].Top >= inicioCarro[2].Y)                     //Lo mismo
                                    {
                                        carrosMovimiento[0][i].Image = carro[colorCarro, 2];
                                        carrosMovimiento[0][i].Top = inicioCarro[2].Y;
                                        carrosMovimiento[0][i].Tag = "6," + colorCarro.ToString() + ",1";
                                        carrosMovimiento[2].Add(carrosMovimiento[0][i]);
                                        carrosMovimiento[0].RemoveAt(i);
                                    }
                                    break;
                                case 3:
                                    if (carrosMovimiento[3][i].Top <= inicioCarro[2].Y)                     //Lo mismo
                                    {
                                        carrosMovimiento[3][i].Image = carro[colorCarro, 2];
                                        carrosMovimiento[3][i].Top = inicioCarro[2].Y;
                                        carrosMovimiento[3][i].Tag = "6," + colorCarro.ToString() + ",1";
                                        carrosMovimiento[2].Add(carrosMovimiento[3][i]);
                                        carrosMovimiento[3].RemoveAt(i);
                                    }
                                    break;
                                case 4:
                                    if (carrosMovimiento[3][i].Top <= inicioCarro[1].Y)                     //Lo mismo
                                    {
                                        carrosMovimiento[3][i].Image = carro[colorCarro, 1];
                                        carrosMovimiento[3][i].Top = inicioCarro[1].Y;
                                        carrosMovimiento[3][i].Tag = "5," + colorCarro.ToString() + ",1";
                                        carrosMovimiento[1].Add(carrosMovimiento[3][i]);
                                        carrosMovimiento[3].RemoveAt(i);
                                    }
                                    break;
                                case 5:
                                    if (carrosMovimiento[1][i].Left <= -50)                                 //Si sale de la calle principal
                                    {
                                        picBase.Controls.Remove(carrosMovimiento[1][i]);
                                        carrosMovimiento[1].RemoveAt(i);
                                    }
                                    break;
                                case 6:
                                    if (carrosMovimiento[2][i].Left >= picBase.Width + 50)                  //Si sale de la calle principal
                                    {
                                        picBase.Controls.Remove(carrosMovimiento[2][i]);    //Si sale, se borra el carro
                                        carrosMovimiento[2].RemoveAt(i);
                                    }
                                    break;
                            }
                        }
                        else  //Aun no pasa el semaforo:
                        {
                            switch (nCalle) 
                            {
                                case 0:                                                 //Si pasa el semaforo...
                                    if (carrosMovimiento[0][i].Top + carrosMovimiento[0][i].Height >= ultimoObstaculo[ultimoObstaculo.Count-1].Top - 20)
                                    {
                                        if (semaforo1.BackColor == Color.DarkSeaGreen)  //Si esta en verde
                                        {
                                            carrosMovimiento[0][i].Tag = rnd.Next(1, 3).ToString() + "," + colorCarro.ToString() + ",0";
                                            if (ultimoObstaculo.Count != 1)             //Como el carro ya se fue, ya no sera un obstaculo
                                                ultimoObstaculo.Remove(carrosMovimiento[0][i]);
                                        }
                                        else
                                        {
                                            if (carroContado == 0)  //Si no esta contado el carro al estar formado...
                                            {
                                                ultimoObstaculo.Add(carrosMovimiento[0][i]);
                                                carrosMovimiento[0][i].Tag = ruta + "," + colorCarro + ",1";
                                            }
                                                
                                        }
                                    }
                                    else
                                    {   //Si no ha llegado al semaforo solo lo moveremos...
                                        carrosMovimiento[0][i].Left += avanzarX;
                                        carrosMovimiento[0][i].Top += avanzarY;
                                    }
                                    break;
                                case 1: 
                                    if (carrosMovimiento[1][i].Left <= ultimoObstaculo[ultimoObstaculo.Count - 1].Left + ultimoObstaculo[ultimoObstaculo.Count - 1].Width + 15)
                                    {                                        
                                        if (semaforo2.BackColor == Color.DarkSeaGreen)
                                        {                                            
                                            carrosMovimiento[1][i].Tag = "5," + colorCarro.ToString() + ",0";
                                            if (ultimoObstaculo.Count != 1)
                                                ultimoObstaculo.Remove(carrosMovimiento[1][i]);
                                        }
                                        else
                                        {
                                            if (carroContado == 0)
                                            {
                                                ultimoObstaculo.Add(carrosMovimiento[1][i]);
                                                carrosMovimiento[1][i].Tag = ruta + "," + colorCarro + ",1";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        carrosMovimiento[1][i].Left += avanzarX;
                                        carrosMovimiento[1][i].Top += avanzarY;
                                    }
                                    break;
                                case 2:
                                    if (carrosMovimiento[2][i].Left + carrosMovimiento[2][i].Width >= ultimoObstaculo[ultimoObstaculo.Count - 1].Left - 15)
                                    {
                                        if (semaforo3.BackColor == Color.DarkSeaGreen)
                                        {
                                            carrosMovimiento[2][i].Tag = "6," + colorCarro.ToString() + ",0";
                                            if (ultimoObstaculo.Count != 1)
                                                ultimoObstaculo.Remove(carrosMovimiento[2][i]);
                                        }
                                        else
                                        {
                                            if (carroContado == 0)
                                            {
                                                ultimoObstaculo.Add(carrosMovimiento[2][i]);
                                                carrosMovimiento[2][i].Tag = ruta + "," + colorCarro + ",1";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        carrosMovimiento[2][i].Left += avanzarX;
                                        carrosMovimiento[2][i].Top += avanzarY;
                                    }
                                    break;
                                case 3:
                                    if (carrosMovimiento[3][i].Top <= ultimoObstaculo[ultimoObstaculo.Count - 1].Top + ultimoObstaculo[ultimoObstaculo.Count - 1].Height + 10)
                                    {
                                        if (semaforo4.BackColor == Color.DarkSeaGreen)
                                        {
                                            carrosMovimiento[3][i].Tag = rnd.Next(3, 5).ToString() + "," + colorCarro.ToString() + ",0";
                                            if (ultimoObstaculo.Count != 1)
                                                ultimoObstaculo.Remove(carrosMovimiento[3][i]);
                                        }
                                        else
                                        {
                                            if (carroContado == 0)
                                            {
                                                ultimoObstaculo.Add(carrosMovimiento[3][i]);
                                                carrosMovimiento[3][i].Tag = ruta + "," + colorCarro + ",1";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        carrosMovimiento[3][i].Left += avanzarX;
                                        carrosMovimiento[3][i].Top += avanzarY;
                                    }
                                    break;
                            }
                        }
                    }
                }

                switch (nCalle) //Para poner limites de generacion
                {
                    case 0:
                        if (ultimoObstaculo.Count >= 3)
                            generar = false;
                        break;
                    case 1:
                        if (ultimoObstaculo.Count >= 10)
                            generar = false;
                        break;
                    case 2:
                        if (ultimoObstaculo.Count >= 7)
                            generar = false;
                        break;
                    case 3:
                        if (ultimoObstaculo.Count >= 2)
                            generar = false;
                        break;
                }

                if (rnd.Next(0, 100) == 0 && generar)   //Con una probabilidad y si se puede generar...
                {
                    try
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()     //Se genera otro auto
                        {                                               //Igual que el anterior
                            color = rnd.Next(0, 4);
                            nuevoCarro = new PictureBox();
                            picBase.Controls.Add(nuevoCarro);
                            nuevoCarro.BackColor = Color.Transparent;
                            nuevoCarro.SizeMode = PictureBoxSizeMode.StretchImage;
                            nuevoCarro.Location = posInicial;
                            nuevoCarro.Size = new Size(40, 40);
                            nuevoCarro.Image = carro[color, nCalle];
                            nuevoCarro.Tag = "0," + color.ToString()+",0";
                            carrosMovimiento[nCalle].Add(nuevoCarro);
                            nuevoCarro.Click += new EventHandler(carro_Click);  //Se le agrega un evento click
                        });
                    }
                    catch { }
                }

                Thread.Sleep(50);   //Esperamos un ratito
            }
        }

        public void carro_Click(object sender, EventArgs e) //Al dar click en un carro
        {
            int color = Convert.ToInt16((((PictureBox)sender).Tag.ToString()).Split(',')[1]);            
            automovil consulta = new automovil(color);  //Mandaremos como paremetro el color
            consulta.Show();
        }

        private void semaforo_Click(object sender, EventArgs e) //Al dar click a un semaforo
        {
            nSemaforo = Convert.ToInt16(((PictureBox)sender).Tag);

            vigilarSemaforo = new Thread(() => {     //Abriremos otro hilo que vigile al semaforo seleccionado
                while(true)
                {
                    if (semaforos[nSemaforo].BackColor == Color.DarkSeaGreen)
                        picSEMAFORO.Image = Properties.Resources.semaforoV;
                    else if (semaforos[nSemaforo].BackColor == Color.Yellow)
                        picSEMAFORO.Image = Properties.Resources.semaforoA;
                    else
                        picSEMAFORO.Image = Properties.Resources.semaforoR;
                    Thread.Sleep(1000);
                }                
            }) ;
            vigilarSemaforo.Start();
        }

        

        private void picBase_DoubleClick(object sender, EventArgs e)
        {
            Mapa verMapa = new Mapa();
            verMapa.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   //Al cerrar tenemos que abortar todos los hilos
        {
            thread_moverCarros1.Abort();
            thread_moverCarros2.Abort();
            thread_moverCarros3.Abort();
            thread_moverCarros4.Abort();
            thread_semaforo1.Abort();
            thread_semaforo2.Abort();
            thread_semaforo3.Abort();
            thread_semaforo4.Abort();            
            thread_puente1.Abort();
            thread_puente2.Abort();
            if (btnEmpezar.Text != "...")
                vigilarSemaforo.Abort();
        }

        private void cargarArreglos()   //Solo carga los arreglos a usar...
        {
            semaforos = new PictureBox[4] { semaforo1, semaforo2, semaforo3, semaforo4 };
            inicioCarro = new Point[4] { new Point(440, -50), new Point(990, 160), new Point(-50, 375), new Point(442, 570) };

            carro = new Image[4, 4];
            carro[0, 0] = Properties.Resources.AzulS;
            carro[0, 1] = Properties.Resources.azulA;
            carro[0, 2] = Properties.Resources.azulD;
            carro[0, 3] = Properties.Resources.azulW;

            carro[1, 0] = Properties.Resources.rojoS;
            carro[1, 1] = Properties.Resources.rojoA;
            carro[1, 2] = Properties.Resources.rojoD;
            carro[1, 3] = Properties.Resources.rojoW;

            carro[2, 0] = Properties.Resources.verdeS;
            carro[2, 1] = Properties.Resources.verdeA;
            carro[2, 2] = Properties.Resources.verdeD;
            carro[2, 3] = Properties.Resources.verdeW;

            carro[3, 0] = Properties.Resources.amarilloS;
            carro[3, 1] = Properties.Resources.amarilloA;
            carro[3, 2] = Properties.Resources.amarilloD;
            carro[3, 3] = Properties.Resources.amarilloW;
        }
    }
}
