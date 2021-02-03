using System;
using System.Collections.Generic;

namespace ProyectoVSC{

    class Cuadro{
        
        private Cuadro arriba;
        private Cuadro abajo;
        private Cuadro izquierda;
        private Cuadro derecha;
        private Cuadro vecinoArriba;
        private Cuadro vecinoAbajo;
        private Cuadro vecinoIzquierda;
        private Cuadro vecinoDerecha;
        private int indice;

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

        public int getIndice()
        {
            return this.indice;
        }

        public void setIndice(int indice)
        {
            this.indice = indice;
        }

        public Cuadro getArriba() {
            return this.arriba;
        }

        public void setArriba(Cuadro arriba) {
            this.arriba = arriba;
        }

        public Cuadro getAbajo() {
            return this.abajo;
        }

        public void setAbajo(Cuadro abajo) {
            this.abajo = abajo;
        }

        public Cuadro getIzquierda() {
            return this.izquierda;
        }

        public void setIzquierda(Cuadro izquierda) {
            this.izquierda = izquierda;
        }

        public Cuadro getDerecha() {
            return this.derecha;
        }

        public void setDerecha(Cuadro derecha) {
            this.derecha = derecha;
        }

        public void combinar(Cuadro c){
            Random r = new Random();
            int aux = r.Next(3);
            
            if(aux == 0){
                if(this.getArriba() == null){
                    this.setArriba(c);
                    c.setAbajo(this); 
                    return;   
                }else{
                    this.getArriba().combinar(c);
                }
            }else if(aux == 1){
                if(this.getDerecha() == null){
                    this.setDerecha(c);
                    c.setIzquierda(this);
                    return;
                }else{
                    this.getDerecha().combinar(c);
                }
            }else if(aux == 2){
                if(this.getAbajo() == null){
                    this.setAbajo(c);
                    c.setArriba(this);
                    return;
                }else{
                    this.getAbajo().combinar(c);
                }
            }else{
                if(this.getIzquierda() == null){
                    this.setIzquierda(c);
                    c.setDerecha(this);
                    return;
                }else{
                    this.getIzquierda().combinar(c);
                }
            }
            
        }

        public void recorrer(int tamano,int indiceActual,List<Cuadro> vicitados){
            vicitados.Add(this);
            if(indiceActual == tamano+1){
                return;
            }
            if(this.getIndice() != indiceActual){
                if((this.getArriba()!= null)&&(!vicitados.Contains(this.getArriba()))){
                    this.getArriba().recorrer(tamano,indiceActual,vicitados);
                }
                if((this.getDerecha()!= null)&&(!vicitados.Contains(this.getDerecha()))){
                    this.getDerecha().recorrer(tamano,indiceActual,vicitados);
                }
                if((this.getAbajo()!=  null)&&(!vicitados.Contains(this.getAbajo()))){
                    this.getAbajo().recorrer(tamano,indiceActual,vicitados);
                }
                if((this.getIzquierda()!= null)&&(!vicitados.Contains(this.getIzquierda()))){
                    this.getIzquierda().recorrer(tamano,indiceActual,vicitados);
                }
            }else{
                indiceActual += 1;
                Console.WriteLine(this.getIndice()+" Indice");
                vicitados.Clear();
                if((this.getArriba()!= null)&&(!vicitados.Contains(this.getArriba()))){
                    this.getArriba().recorrer(tamano,indiceActual,vicitados);
                }
                if((this.getDerecha()!= null)&&(!vicitados.Contains(this.getDerecha()))){
                    this.getDerecha().recorrer(tamano,indiceActual,vicitados);
                }
                if((this.getAbajo()!=  null)&&(!vicitados.Contains(this.getAbajo()))){
                    this.getAbajo().recorrer(tamano,indiceActual,vicitados);
                }
                if((this.getIzquierda()!= null)&&(!vicitados.Contains(this.getIzquierda()))){
                    this.getIzquierda().recorrer(tamano,indiceActual,vicitados);
                }
            }
        }
    
        public bool lugarOcupado(Cuadro c, Cuadro vecino){
            bool estaOcupado = true;
            if((c == null)&&(vecino == null)){
                estaOcupado = false;
            }
            return estaOcupado;
        }
    }
}