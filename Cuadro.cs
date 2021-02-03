using System;
using System.Collections.Generic;

namespace ProyectoVSC{

    class Cuadro{
        
        private Cuadro arriba;
        private Cuadro abajo;
        private Cuadro izquierda;
        private Cuadro derecha;
        private Cuadro vecino;
        private string posicionVecino;

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

        public Cuadro getVecino() {
            return this.vecino;
        }

        public void setVecino(Cuadro vecino) {
            this.vecino = vecino;
        }

        public string getPosicionVecino() {
            return this.posicionVecino;
        }

        public void setPosicionVecino(string posicionVecino) {
            this.posicionVecino = posicionVecino;
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

        public void recorrer2(List<Cuadro> vicitados, int total,int tamano){
            if(total == tamano){
                Console.WriteLine(total);
                return;
            }
            if((!vicitados.Contains(this.getArriba()))&&(this.getArriba()!=null)){
                vicitados.Add(this);
                total += 1;
                this.getArriba().recorrer2(vicitados,total,tamano);
            }else if((!vicitados.Contains(this.getDerecha()))&&(this.getDerecha()!=null)){
                vicitados.Add(this);
                total += 1;
                this.getDerecha().recorrer2(vicitados,total,tamano);
            }else if((!vicitados.Contains(this.getAbajo()))&&(this.getAbajo()!=null)){
                vicitados.Add(this);
                total += 1;
                this.getAbajo().recorrer2(vicitados,total,tamano);
            }else if((!vicitados.Contains(this.getIzquierda()))&&(this.getIzquierda()!=null)){
                vicitados.Add(this);
                total += 1;
                this.getIzquierda().recorrer2(vicitados,total,tamano);
            }else if((vicitados.Contains(this.getIzquierda()))&&(this.getIzquierda()!=null)){
                this.getIzquierda().recorrer2(vicitados,total,tamano);
            }else if((vicitados.Contains(this.getAbajo()))&&(this.getAbajo()!=null)){
                this.getAbajo().recorrer2(vicitados,total,tamano);
            }else if((vicitados.Contains(this.getDerecha()))&&(this.getDerecha()!=null)){
                this.getDerecha().recorrer2(vicitados,total,tamano);
            }else if((vicitados.Contains(this.getArriba()))&&(this.getArriba()!=null)){
                this.getArriba().recorrer2(vicitados,total,tamano);
            }
        }

    }
}