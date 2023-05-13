namespace Game
{
    public partial class Form1 : Form
    {
        int ContadorMovimientos = 1;
        bool VolarArriva = false;
        int Distancia = 0;
        Random PosicionRandom = new Random();
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            IniciarJuego();
        }

        public void IniciarJuego()
        {
            Player.Location = new Point(19, 225);
            Distancia = PosicionRandom.Next(-160, 118);
            TuboArriva.Location = new Point(270, -173 - Distancia);
            TuvoAbajo.Location = new Point(270, 319 - Distancia);
            Puntaje.Text = "0";
        }
        // lkdsa
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TuvoAbajo_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int CantidadMovimientos = 5;
            if (ContadorMovimientos <= CantidadMovimientos)
            {
                Player.Image = Properties.Resources.Bicho_2;
                ContadorMovimientos++;
            }
            if ((ContadorMovimientos > CantidadMovimientos / 2) && (ContadorMovimientos <= CantidadMovimientos * 2))
            {
                Player.Image = Properties.Resources.Bicho_1;
                ContadorMovimientos++;
            }
            ContadorMovimientos = (ContadorMovimientos > CantidadMovimientos * 2) ? 0 : ContadorMovimientos;

            int ly = Player.Location.Y;
            int lx = Player.Location.X;

            //Volar
            if (VolarArriva)
            {
                ly = ly - 15;
                VolarArriva = false;
            }
            else
            {
                ly++;
            }
            Player.Location = new Point(Player.Location.X, ly);

            if ((Player.Bounds.IntersectsWith(Barrera.Bounds)) || (Player.Bounds.IntersectsWith(TuboArriva.Bounds)) || (Player.Bounds.IntersectsWith(TuvoAbajo.Bounds)))

            {
                IniciarJuego();
            }
            Puntaje.Location = new Point(Player.Location.X + 30, Player.Location.Y - 25);
            Puntaje.Text = (TuboArriva.Location.X == Player.Location.X) ? Convert.ToString((Convert.ToInt32(Puntaje.Text) + 1)).ToString() : Puntaje.Text;
        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Para mover el tubo mientras sea mayor al limite del escenario    
            if (TuvoAbajo.Location.X > -140)
            {
                TuvoAbajo.Location = new Point((TuvoAbajo.Location.X) - 1, TuvoAbajo.Location.Y);
                TuboArriva.Location = new Point((TuboArriva.Location.X) - 1, TuboArriva.Location.Y);
            }

            else
            {
                Distancia = PosicionRandom.Next(-170, 118);
                TuvoAbajo.Location = new Point(400, 319 + Distancia);
                TuboArriva.Location = new Point(400, -173 + Distancia);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                VolarArriva = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Barrera.Location = (Barrera.Location.X > -480) ? new Point((Barrera.Location.X) - 1, Barrera.Location.Y) : Barrera.Location = new Point(-9, Barrera.Location.Y);
        }

        private void Barrera_Click(object sender, EventArgs e)
        {

        }

        private void TuboArriva_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}