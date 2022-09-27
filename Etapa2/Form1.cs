using System.Media;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.AxHost;

namespace Etapa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelIncorrecto.Hide();
            panelCorrecto.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer("C:\\Users\\abuel\\Downloads\\Etapa2 (2)\\Etapa2\\Incorrecto.wav");
            Player.Play();
            panelIncorrecto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer("C:\\Users\\abuel\\Downloads\\Etapa2 (2)\\Etapa2\\Correcto.wav");
            Player.Play();
            panelCorrecto.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer("C:\\Users\\abuel\\Downloads\\Etapa2 (2)\\Etapa2\\Incorrecto.wav");
            Player.Play();
            panelIncorrecto.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}