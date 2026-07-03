using System;
using System.Drawing;

namespace miLibreria{

    class Transporte{
        public int matricula;
        public string color;

        public int capacidad;

        public void arrancar(){

            Console.WriteLine("Arrancando...");
        }

        public void detenerse(){

            Console.WriteLine("Deteniendose...");
        }

        public virtual void mover(){
            Console.WriteLine("Moviendose...");
        }
    }

    class Avion : Transporte{

        public string piloto;


        public void despegar(){

            Console.WriteLine("Despegando...");
        }


        public void aterrizar(){

            Console.WriteLine("Aterrizando...");
        }

        public override void mover()
        {
            Console.WriteLine("Moviendose el avion");
        }

    }


    class Auto : Transporte{

        public bool vtv;
        public int tarjetaVerdeNro;

        public void cambiarAceite(){
            Console.WriteLine("Cambiando aceite...");
        }

         public override void  mover(){
            Console.WriteLine("Moviendo el auto");
        }

    }
}