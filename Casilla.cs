using System;
using System.Collections.Generic; 

namespace ProyectoVSC{
    
    class Casilla{
        private List<Casilla> vecindad = new List<Casilla>();
        private Ficha ficha;

        public List<Casilla> getVecindad()
        {
            return this.vecindad;
        }

        public void setVecindad(List<Casilla> vecindad)
        {
            this.vecindad = vecindad;
        }

        public Ficha getFicha()
        {
            return this.ficha;
        }

        public void setFicha(Ficha ficha)
        {
            this.ficha = ficha;
        }


        public bool colocar(Condicion c){return true;}

        public Ficha generarFicha(){
            FichaSudoku ficha = new FichaSudoku();

            return ficha;
        }

        public void agregarVecindad(Condicion c, Vecinos v){}

    }
}