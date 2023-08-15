namespace Semaforo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.semaforo2 = new System.Windows.Forms.PictureBox();
            this.semaforo3 = new System.Windows.Forms.PictureBox();
            this.semaforo4 = new System.Windows.Forms.PictureBox();
            this.semaforo1 = new System.Windows.Forms.PictureBox();
            this.picPuente2 = new System.Windows.Forms.PictureBox();
            this.picPuente1 = new System.Windows.Forms.PictureBox();
            this.picBase = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picSEMAFORO = new System.Windows.Forms.PictureBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPuente2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPuente1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSEMAFORO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.semaforo2);
            this.groupBox1.Controls.Add(this.semaforo3);
            this.groupBox1.Controls.Add(this.semaforo4);
            this.groupBox1.Controls.Add(this.semaforo1);
            this.groupBox1.Controls.Add(this.picPuente2);
            this.groupBox1.Controls.Add(this.picPuente1);
            this.groupBox1.Controls.Add(this.picBase);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 567);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MONITOR";
            // 
            // semaforo2
            // 
            this.semaforo2.BackColor = System.Drawing.Color.Red;
            this.semaforo2.Location = new System.Drawing.Point(479, 183);
            this.semaforo2.Margin = new System.Windows.Forms.Padding(0);
            this.semaforo2.Name = "semaforo2";
            this.semaforo2.Size = new System.Drawing.Size(10, 40);
            this.semaforo2.TabIndex = 6;
            this.semaforo2.TabStop = false;
            this.semaforo2.Tag = "1";
            this.semaforo2.Click += new System.EventHandler(this.semaforo_Click);
            // 
            // semaforo3
            // 
            this.semaforo3.BackColor = System.Drawing.Color.Red;
            this.semaforo3.Location = new System.Drawing.Point(432, 396);
            this.semaforo3.Margin = new System.Windows.Forms.Padding(0);
            this.semaforo3.Name = "semaforo3";
            this.semaforo3.Size = new System.Drawing.Size(10, 41);
            this.semaforo3.TabIndex = 5;
            this.semaforo3.TabStop = false;
            this.semaforo3.Tag = "2";
            this.semaforo3.Click += new System.EventHandler(this.semaforo_Click);
            // 
            // semaforo4
            // 
            this.semaforo4.BackColor = System.Drawing.Color.Red;
            this.semaforo4.Location = new System.Drawing.Point(442, 437);
            this.semaforo4.Margin = new System.Windows.Forms.Padding(0);
            this.semaforo4.Name = "semaforo4";
            this.semaforo4.Size = new System.Drawing.Size(37, 10);
            this.semaforo4.TabIndex = 4;
            this.semaforo4.TabStop = false;
            this.semaforo4.Tag = "3";
            this.semaforo4.Click += new System.EventHandler(this.semaforo_Click);
            // 
            // semaforo1
            // 
            this.semaforo1.BackColor = System.Drawing.Color.Red;
            this.semaforo1.Location = new System.Drawing.Point(442, 172);
            this.semaforo1.Margin = new System.Windows.Forms.Padding(0);
            this.semaforo1.Name = "semaforo1";
            this.semaforo1.Size = new System.Drawing.Size(35, 10);
            this.semaforo1.TabIndex = 3;
            this.semaforo1.TabStop = false;
            this.semaforo1.Tag = "0";
            this.semaforo1.Click += new System.EventHandler(this.semaforo_Click);
            // 
            // picPuente2
            // 
            this.picPuente2.Image = ((System.Drawing.Image)(resources.GetObject("picPuente2.Image")));
            this.picPuente2.Location = new System.Drawing.Point(6, 316);
            this.picPuente2.Name = "picPuente2";
            this.picPuente2.Size = new System.Drawing.Size(972, 47);
            this.picPuente2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPuente2.TabIndex = 2;
            this.picPuente2.TabStop = false;
            // 
            // picPuente1
            // 
            this.picPuente1.Image = ((System.Drawing.Image)(resources.GetObject("picPuente1.Image")));
            this.picPuente1.Location = new System.Drawing.Point(6, 240);
            this.picPuente1.Margin = new System.Windows.Forms.Padding(1);
            this.picPuente1.Name = "picPuente1";
            this.picPuente1.Size = new System.Drawing.Size(972, 47);
            this.picPuente1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPuente1.TabIndex = 1;
            this.picPuente1.TabStop = false;
            // 
            // picBase
            // 
            this.picBase.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picBase.Image = ((System.Drawing.Image)(resources.GetObject("picBase.Image")));
            this.picBase.Location = new System.Drawing.Point(6, 19);
            this.picBase.Name = "picBase";
            this.picBase.Size = new System.Drawing.Size(972, 539);
            this.picBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBase.TabIndex = 0;
            this.picBase.TabStop = false;
            this.picBase.DoubleClick += new System.EventHandler(this.picBase_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.picSEMAFORO);
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1017, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 352);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEMAFORO";
            // 
            // picSEMAFORO
            // 
            this.picSEMAFORO.Image = global::Semaforo.Properties.Resources.semaforo;
            this.picSEMAFORO.Location = new System.Drawing.Point(6, 19);
            this.picSEMAFORO.Name = "picSEMAFORO";
            this.picSEMAFORO.Size = new System.Drawing.Size(188, 327);
            this.picSEMAFORO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSEMAFORO.TabIndex = 0;
            this.picSEMAFORO.TabStop = false;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.Red;
            this.btnEmpezar.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.Location = new System.Drawing.Point(1017, 370);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(200, 200);
            this.btnEmpezar.TabIndex = 3;
            this.btnEmpezar.Text = "START";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1239, 598);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Semaforo Advanced Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.semaforo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPuente2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPuente1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSEMAFORO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picSEMAFORO;
        private System.Windows.Forms.PictureBox picPuente1;
        private System.Windows.Forms.PictureBox picPuente2;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.PictureBox semaforo2;
        private System.Windows.Forms.PictureBox semaforo3;
        private System.Windows.Forms.PictureBox semaforo4;
        private System.Windows.Forms.PictureBox semaforo1;
    }
}

