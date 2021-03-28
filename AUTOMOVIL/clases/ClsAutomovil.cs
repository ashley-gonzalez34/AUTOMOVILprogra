
using System.Media;
using System;
using System.Collections.Generic;
using System.Text;



namespace AUTOMOVIL.clases
{
    class ClsAutomovil
    {

        public String marca { get; }


        public int vel_max { get; }
        private int velocidadActual { get; set; }
        public bool encendido { get; private set; }
        private int frenarm { get; set; }
        public bool frenar { get; private set; }
        public bool apagado { get; private set; }
        private int cambio { get; set; }
        
        public bool GirarD { get; private set; }
        public bool GirarIz { get; private set; }



        public String color { get; set; }






        public String Acelerar()
        {
            velocidadActual = velocidadActual + 10;


            if (velocidadActual > vel_max)
            {
                return "Lo lamento , llegaste a la velocidad maxima";
            }
            else
            {
                return $" Vas a {velocidadActual}K/H";


            }


        }


        public ClsAutomovil(string marcaCarro, int VelocidadMx)
        {

            this.marca = marcaCarro;
            this.vel_max = VelocidadMx;




        }

        public bool EstaEncendido()
        {
            return encendido;

        }






        public string EncenderMotor()
        {

            if (encendido)
            {

                return " Listo!! el carro está Encendido";


            }
            else
            {


                encendido = true;
                velocidadActual = 0;

                return "En unos minutos estara encendido el carro";



            }


        }









        public string ApagarMotor()
        {

            if (apagado)
            {

                return " Listo!! el carro se Apago";


            }
            else
            {


                apagado = true;
                velocidadActual = 0;
                return "En unos minutos estara apagado el carro";



            }



        }

        public string FrenarMotor()

        {
            if (frenar)
            {


                return "El auto frenara en un momento";

            }
            else
            {
                frenar = true;
                velocidadActual = 0;
                return "El auto frena";
            }




        }

        public String cambioMotor()

        {
            if (cambio == 10)
            {
                return "Debe de cambiar a la segunda velocidad";

            }
            if (cambio == 30)
            {
                return "Debe de cambiar a segunda velocidad";

            }
            if (cambio == 50)
            {
                return "Debe de cambiar a tercera velocidad";

            }
            else
            {
               




                return "Debe de cambiar a primera";
            }
        }


        public String GiraralaDerechayIzquierda()
        {
            if (GirarD)

            {
                return "Girar ala Derecha";

            }
            else
            {

                return "Girar ala Izquierda";
            }
        }


        public String cambioMotor2()

        {
            if (cambio == 10)
            {
                return "Debe de cambiar a la segunda velocidad";

            }
            if (cambio == 30)
            {
                return "Debe de cambiar a segunda velocidad";

            }
            if (cambio == 50)
            {
                return "Debe de cambiar a tercera velocidad";

            }
            else
            {





                return "Debe de cambiar a segunda velocidad";
            }
        }

        public String cambioMotor3()

        {
            if (cambio == 10)
            {
                return "Debe de cambiar a la segunda velocidad";

            }
            if (cambio == 30)
            {
                return "Debe de cambiar a segunda velocidad";

            }
            if (cambio == 50)
            {
                return "Debe de cambiar a tercera velocidad";

            }
            else
            {
               




                return "Debe de cambiar a tercera";
            }
        }

    }
}





