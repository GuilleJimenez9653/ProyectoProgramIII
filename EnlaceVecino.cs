using System;

namespace ProyectoVSC{

    class EnlaceVecino{

        private Cuadro vecinoArriba;
        private Cuadro vecinoAbajo;
        private Cuadro vecinoIzquierda;
        private Cuadro vecinoDerecha;

        public EnlaceVecino(){
            vecinoArriba = null;
            vecinoAbajo = null;
            vecinoDerecha = null;
            vecinoIzquierda = null;
        }

        public Cuadro getVecinoArriba()
        {
            return this.vecinoArriba;
        }

        public void setVecinoArriba(Cuadro vecinoArriba)
        {
            this.vecinoArriba = vecinoArriba;
        }

        public Cuadro getVecinoAbajo()
        {
            return this.vecinoAbajo;
        }

        public void setVecinoAbajo(Cuadro vecinoAbajo)
        {
            this.vecinoAbajo = vecinoAbajo;
        }

        public Cuadro getVecinoIzquierda()
        {
            return this.vecinoIzquierda;
        }

        public void setVecinoIzquierda(Cuadro vecinoIzquierda)
        {
            this.vecinoIzquierda = vecinoIzquierda;
        }

        public Cuadro getVecinoDerecha()
        {
            return this.vecinoDerecha;
        }

        public void setVecinoDerecha(Cuadro vecinoDerecha)
        {
            this.vecinoDerecha = vecinoDerecha;
        }



    }
}