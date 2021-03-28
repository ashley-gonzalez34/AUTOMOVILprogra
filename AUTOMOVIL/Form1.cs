using System.Media;
using AUTOMOVIL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AUTOMOVIL
{
    public partial class Form1 : Form
    {
        ClsAutomovil carrito;




        public Form1()
        {
            InitializeComponent();
        }

       


        private void buttonInicio_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.ENCENDER_CARRO);
            logout.Play();


            carrito = new ClsAutomovil("Meches", 150);
            carrito.color = "ROJO";




        }




        private void buttonEncender_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.CARRO_EN_MOVIMIENTO);
            logout.Play();



            string respuesta = carrito.EncenderMotor();
            label2Datos.Text = respuesta;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.CARRO_FRENANDO);
            logout.Play();


            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.Acelerar();

            }
            else
            {
                MessageBox.Show($"Lo siento el carro{carrito} esta apagado");
            }






        }








        private void TocarBocina_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.CARRO_PITANDO);
            logout.Play();


        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.CARRO_APAGANDOSE);
            logout.Play();
            label1Apagar.Text = carrito.ApagarMotor();
            label2Datos.Text = "";
            labelVelocidad.Text = "";
            label2frenar.Text = "";
            label1izqui.Text = "";
            label2Derecha.Text = "";
            labelcambio1.Text = "";

        }



        private void buttonFrenar_Click(object sender, EventArgs e)

        {
            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.CARRO_FRENANDO);
            logout.Play();
            string frenarmax = carrito.FrenarMotor();
            label2frenar.Text = frenarmax;

        }



        private void buttoncambio_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.ACELERAR2);
            logout.Play();

            string cambiovel = carrito.cambioMotor();
            labelcambio1.Text = cambiovel;



        }

        private void buttongirar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.SONIDOINTERMITENTE);
            logout.Play();

            string girarlados = carrito.GiraralaDerechayIzquierda();
            label1izqui.Text = girarlados;

            




        }

        private void button3_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.SONIDOINTERMITENTE);
            logout.Play();
            string girarderecha = carrito.GiraralaDerechayIzquierda();
            label2Derecha.Text = girarderecha;

        }

        private void buttoncambio2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.ACELERAR2);
            logout.Play();

            string cambiovel2 = carrito.cambioMotor2();
            labelcambio1.Text = cambiovel2;

        }


        private void button1Frenar_Click(object sender, EventArgs e)
        {
            string frenar = carrito.FrenarMotor();
            label2frenar.Text = frenar;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            
                System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.ACELERAR2);
                logout.Play();

                string cambiovel2 = carrito.cambioMotor3();
                labelcambio1.Text = cambiovel2;

            
        }
    }
}
