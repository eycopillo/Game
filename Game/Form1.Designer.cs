namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Player = new PictureBox();
            Barrera = new PictureBox();
            TuvoAbajo = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            Puntaje = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Barrera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TuvoAbajo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.BackgroundImage = Properties.Resources.Bicho4;
            Player.Location = new Point(19, 225);
            Player.Name = "Player";
            Player.Size = new Size(65, 52);
            Player.SizeMode = PictureBoxSizeMode.AutoSize;
            Player.TabIndex = 1;
            Player.TabStop = false;
            Player.Click += Player_Click;
            // 
            // Barrera
            // 
            Barrera.BackgroundImage = Properties.Resources.barra1;
            Barrera.Location = new Point(-264, 437);
            Barrera.Name = "Barrera";
            Barrera.Size = new Size(562, 10);
            Barrera.TabIndex = 2;
            Barrera.TabStop = false;
            Barrera.Click += Barrera_Click;
            // 
            // TuvoAbajo
            // 
            TuvoAbajo.BackgroundImage = Properties.Resources.Tubo_de_abajo;
            TuvoAbajo.Location = new Point(220, 327);
            TuvoAbajo.Name = "TuvoAbajo";
            TuvoAbajo.Size = new Size(54, 83);
            TuvoAbajo.TabIndex = 3;
            TuvoAbajo.TabStop = false;
            TuvoAbajo.Click += TuvoAbajo_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 1;
            timer3.Tick += timer3_Tick;
            // 
            // Puntaje
            // 
            Puntaje.AutoSize = true;
            Puntaje.Location = new Point(52, 198);
            Puntaje.Name = "Puntaje";
            Puntaje.Size = new Size(22, 25);
            Puntaje.TabIndex = 4;
            Puntaje.Text = "0";
            Puntaje.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Tubo_de_arriva;
            pictureBox1.Location = new Point(134, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.descarga__3;
            ClientSize = new Size(286, 447);
            Controls.Add(pictureBox1);
            Controls.Add(Puntaje);
            Controls.Add(TuvoAbajo);
            Controls.Add(Barrera);
            Controls.Add(Player);
            Name = "Form1";
            Text = "Juego";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Barrera).EndInit();
            ((System.ComponentModel.ISupportInitialize)TuvoAbajo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Player;
        private PictureBox Barrera;
        private PictureBox TuvoAbajo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label Puntaje;
        private PictureBox pictureBox1;
    }
}