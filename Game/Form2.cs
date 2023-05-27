using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //manda a llamar a form 1 iniciando el juego
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 InicioJuego = new Form1();
            //ActiveForm.Hide();
            //InicioJuego.ActiveForm2.Hide ();
            this.Hide();
            InicioJuego.Show();


        }
        //salida del juego
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
