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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Player = new PictureBox();
            Barrera = new PictureBox();
            TuvoAbajo = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            Puntaje = new Label();
            TuboArriva = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Barrera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TuvoAbajo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TuboArriva).BeginInit();
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
            Barrera.Image = (Image)resources.GetObject("Barrera.Image");
            Barrera.Location = new Point(-275, 429);
            Barrera.Name = "Barrera";
            Barrera.Size = new Size(779, 24);
            Barrera.SizeMode = PictureBoxSizeMode.StretchImage;
            Barrera.TabIndex = 2;
            Barrera.TabStop = false;
            Barrera.Click += Barrera_Click;
            // 
            // TuvoAbajo
            // 
            TuvoAbajo.BackgroundImage = Properties.Resources.Tubo_de_abajo;
            TuvoAbajo.Image = (Image)resources.GetObject("TuvoAbajo.Image");
            TuvoAbajo.Location = new Point(134, 319);
            TuvoAbajo.Name = "TuvoAbajo";
            TuvoAbajo.Size = new Size(135, 366);
            TuvoAbajo.SizeMode = PictureBoxSizeMode.StretchImage;
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
            // TuboArriva
            // 
            TuboArriva.BackgroundImage = Properties.Resources.Tubo_de_arriva;
            TuboArriva.Image = (Image)resources.GetObject("TuboArriva.Image");
            TuboArriva.Location = new Point(134, -173);
            TuboArriva.Name = "TuboArriva";
            TuboArriva.Size = new Size(135, 366);
            TuboArriva.SizeMode = PictureBoxSizeMode.StretchImage;
            TuboArriva.TabIndex = 5;
            TuboArriva.TabStop = false;
            TuboArriva.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.descarga__3;
            ClientSize = new Size(286, 447);
            Controls.Add(Barrera);
            Controls.Add(TuboArriva);
            Controls.Add(Puntaje);
            Controls.Add(TuvoAbajo);
            Controls.Add(Player);
            Name = "Form1";
            Text = "Juego";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Barrera).EndInit();
            ((System.ComponentModel.ISupportInitialize)TuvoAbajo).EndInit();
            ((System.ComponentModel.ISupportInitialize)TuboArriva).EndInit();
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
        private PictureBox TuboArriva;
    }
}