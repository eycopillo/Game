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
        }

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
                Player.Image = Properties.Resources.Mob2;
                ContadorMovimientos++;
            }
            if ((ContadorMovimientos > CantidadMovimientos / 2) && (ContadorMovimientos <= CantidadMovimientos * 2))
            {
                Player.Image = Properties.Resources.Mob1;
                ContadorMovimientos++;
            }
            ContadorMovimientos = (ContadorMovimientos > CantidadMovimientos * 2) ? 0 : ContadorMovimientos;

            int ly = Player.Location.Y;
            int lx = Player.Location.X;

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
        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}