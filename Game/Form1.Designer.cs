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
            TuboArriva = new PictureBox();
            Player = new PictureBox();
            Barrera = new PictureBox();
            TuvoAbajo = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            Puntaje = new Label();
            ((System.ComponentModel.ISupportInitialize)TuboArriva).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Barrera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TuvoAbajo).BeginInit();
            SuspendLayout();
            // 
            // TuboArriva
            // 
            TuboArriva.BackgroundImage = Properties.Resources.Tubo_de_arriva;
            TuboArriva.Location = new Point(220, 12);
            TuboArriva.Name = "TuboArriva";
            TuboArriva.Size = new Size(54, 159);
            TuboArriva.TabIndex = 0;
            TuboArriva.TabStop = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.descarga__3;
            ClientSize = new Size(286, 447);
            Controls.Add(Puntaje);
            Controls.Add(TuvoAbajo);
            Controls.Add(Barrera);
            Controls.Add(Player);
            Controls.Add(TuboArriva);
            Name = "Form1";
            Text = "Juego";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)TuboArriva).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Barrera).EndInit();
            ((System.ComponentModel.ISupportInitialize)TuvoAbajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox TuboArriva;
        private PictureBox Player;
        private PictureBox Barrera;
        private PictureBox TuvoAbajo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label Puntaje;
    }
}