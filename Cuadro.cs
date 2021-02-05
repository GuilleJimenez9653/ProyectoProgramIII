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
                if(this.arriba == null){
                    this.arriba = c;
                    c.setAbajo(this); 
                    return;   
                }else{
                    this.arriba.combinar(c);
                }
            }else if(aux == 1){
                if(this.derecha == null){
                    this.derecha = c;
                    c.setIzquierda(this);
                    return;
                }else{
                    this.derecha.combinar(c);
                }
            }else if(aux == 2){
                if(this.abajo == null){
                    this.abajo = c;
                    c.setArriba(this);
                    return;
                }else{
                    this.abajo.combinar(c);
                }
            }else{
                if(this.izquierda == null){
                    this.izquierda = c;
                    c.setDerecha(this);
                    return;
                }else{
                    this.izquierda.combinar(c);
                }
            }
            
        }

        public void recorrer(int tamano,int indiceActual,List<Cuadro> visitados){
            visitados.Add(this);
            if(indiceActual == tamano+1){
                return;
            }
            if(this.indice != indiceActual){
                if((this.arriba!= null)&&(!visitados.Contains(this.arriba))){
                    this.arriba.recorrer(tamano,indiceActual,visitados);
                }
                if((this.derecha!= null)&&(!visitados.Contains(this.derecha))){
                    this.derecha.recorrer(tamano,indiceActual,visitados);
                }
                if((this.abajo!=  null)&&(!visitados.Contains(this.abajo))){
                    this.abajo.recorrer(tamano,indiceActual,visitados);
                }
                if((this.izquierda!= null)&&(!visitados.Contains(this.izquierda))){
                    this.izquierda.recorrer(tamano,indiceActual,visitados);
                }
            }else{
                indiceActual += 1;
                Console.WriteLine(this.indice+" Indice");
                visitados.Clear();
                if((this.arriba!= null)&&(!visitados.Contains(this.arriba))){
                    this.arriba.recorrer(tamano,indiceActual,visitados);
                }
                if((this.derecha!= null)&&(!visitados.Contains(this.derecha))){
                    this.derecha.recorrer(tamano,indiceActual,visitados);
                }
                if((this.abajo!=  null)&&(!visitados.Contains(this.abajo))){
                    this.abajo.recorrer(tamano,indiceActual,visitados);
                }
                if((this.izquierda!= null)&&(!visitados.Contains(this.izquierda))){
                    this.izquierda.recorrer(tamano,indiceActual,visitados);
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