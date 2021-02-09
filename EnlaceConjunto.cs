using System;

namespace ProyectoVSC{
    
    class EnlaceConjunto{

        private Cuadro arriba;
        private Cuadro abajo;
        private Cuadro izquierda;
        private Cuadro derecha;

        public EnlaceConjunto(){
            arriba = null;
            abajo = null;
            izquierda = null;
            derecha = null;
        }

        public Cuadro getArriba()
        {
            return this.arriba;
        }

        public void setArriba(Cuadro arriba)
        {
            this.arriba = arriba;
        }

        public Cuadro getAbajo()
        {
            return this.abajo;
        }

        public void setAbajo(Cuadro abajo)
        {
            this.abajo = abajo;
        }

        public Cuadro getIzquierda()
        {
            return this.izquierda;
        }

        public void setIzquierda(Cuadro izquierda)
        {
            this.izquierda = izquierda;
        }

        public Cuadro getDerecha()
        {
            return this.derecha;
        }

        public void setDerecha(Cuadro derecha)
        {
            this.derecha = derecha;
        }

    }
}