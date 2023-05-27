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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
        //cerramos el juego por completo
        private void button2_Click(object sender, EventArgs e)
        {
            
                
                Application.Exit();
            
        }
        // desde el boton llamamos a madar el form1 reiniciando asi el juego
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 InicioJuego = new Form1();
            InicioJuego.Show();
        }
    }
}
