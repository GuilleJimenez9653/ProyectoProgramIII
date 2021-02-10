using System;
using System.Collections.Generic;

namespace ProyectoVSC{

    class Cuadro{

        private EnlaceConjunto enlaceConjunto;
        private EnlaceVecino enlaceVecino;
        private Posicion posicion;
        private int indice;

        public Cuadro(){
            enlaceVecino = new EnlaceVecino();
            enlaceConjunto = new EnlaceConjunto();
            posicion = new Posicion();
        }

        public EnlaceConjunto getEnlaceConjunto()
        {
            return this.enlaceConjunto;
        }

        public void setEnlaceConjunto(EnlaceConjunto enlaceConjunto)
        {
            this.enlaceConjunto = enlaceConjunto;
        }

        public EnlaceVecino getEnlaceVecino()
        {
            return this.enlaceVecino;
        }

        public void setEnlaceVecino(EnlaceVecino enlaceVecino)
        {
            this.enlaceVecino = enlaceVecino;
        }

        public int getIndice()
        {
            return this.indice;
        }

        public void setIndice(int indice)
        {
            this.indice = indice;
        }

        public Posicion getPosicion()
        {
            return this.posicion;
        }

        public void setPosicion(Posicion posicion)
        {
            this.posicion = posicion;
        }

        public void combinar(Cuadro c,int x, int y){
            Random r = new Random();
            Posicion posicionAux = new Posicion();
            List<Cuadro> visitados = new List<Cuadro>();
            Cuadro cuadro = new Cuadro();
            int aux = r.Next(3);
            
            if(aux == 0){
                y += 1;
                posicionAux.setX(x);
                posicionAux.setY(y);
                if(this.enlaceConjunto.getArriba() == null && this.buscarCoordenadas(posicionAux,visitados, cuadro) == null){
                    this.enlaceConjunto.setArriba(c);
                    c.getEnlaceConjunto().setAbajo(this);
                    c.getPosicion().setX(x);
                    c.getPosicion().setY(y); 
                    return;   
                }else{ 
                    this.enlaceConjunto.getArriba().combinar(c,x,y);
                }
            }else if(aux == 1){
                x += 1;
                posicionAux.setX(x);
                posicionAux.setY(y);
                if(this.enlaceConjunto.getDerecha() == null && this.buscarCoordenadas(posicionAux,visitados, cuadro) == null){
                    this.enlaceConjunto.setDerecha(c);
                    c.getEnlaceConjunto().setIzquierda(this);
                    c.getPosicion().setX(x);
                    c.getPosicion().setY(y);
                    return;
                }else{           
                    this.enlaceConjunto.getDerecha().combinar(c,x,y);
                }
            }else if(aux == 2){
                y -= 1;
                posicionAux.setX(x);
                posicionAux.setY(y);
                if(this.enlaceConjunto.getAbajo() == null && this.buscarCoordenadas(posicionAux,visitados, cuadro) == null){
                    this.enlaceConjunto.setAbajo(c);
                    c.getEnlaceConjunto().setArriba(this);
                    c.getPosicion().setX(x);
                    c.getPosicion().setY(y);
                    return;
                }else{
                    this.enlaceConjunto.getAbajo().combinar(c,x,y);
                }
            }else{
                x -= 1;
                posicionAux.setX(x);
                posicionAux.setY(y);
                if(this.enlaceConjunto.getIzquierda() == null && this.buscarCoordenadas(posicionAux,visitados, cuadro) == null){
                    this.enlaceConjunto.setIzquierda(c);
                    c.getEnlaceConjunto().setDerecha(this);
                    c.getPosicion().setX(x);
                    c.getPosicion().setY(y);
                    return;
                }else{                  
                    this.enlaceConjunto.getIzquierda().combinar(c,x,y);
                }
            }
            
        }

        public void recorrer(int tamano,int indiceActual,List<Cuadro> visitados){
            visitados.Add(this);
            if(indiceActual == tamano+1){
                return;
            }
            if(this.indice != indiceActual){
                if((this.enlaceConjunto.getArriba()!= null)&&(!visitados.Contains(this.enlaceConjunto.getArriba()))){
                    this.enlaceConjunto.getArriba().recorrer(tamano,indiceActual,visitados);
                }
                if((this.enlaceConjunto.getDerecha()!= null)&&(!visitados.Contains(this.enlaceConjunto.getDerecha()))){
                    this.enlaceConjunto.getDerecha().recorrer(tamano,indiceActual,visitados);
                }
                if((this.enlaceConjunto.getAbajo()!=  null)&&(!visitados.Contains(this.enlaceConjunto.getAbajo()))){
                    this.enlaceConjunto.getAbajo().recorrer(tamano,indiceActual,visitados);
                }
                if((this.enlaceConjunto.getIzquierda()!= null)&&(!visitados.Contains(this.enlaceConjunto.getIzquierda()))){
                    this.enlaceConjunto.getIzquierda().recorrer(tamano,indiceActual,visitados);
                }
            }else{
                indiceActual += 1;
                visitados.Clear();
                if((this.enlaceConjunto.getArriba()!= null)&&(!visitados.Contains(this.enlaceConjunto.getArriba()))){
                    this.enlaceConjunto.getArriba().recorrer(tamano,indiceActual,visitados);
                }
                if((this.enlaceConjunto.getDerecha()!= null)&&(!visitados.Contains(this.enlaceConjunto.getDerecha()))){
                    this.enlaceConjunto.getDerecha().recorrer(tamano,indiceActual,visitados);
                }
                if((this.enlaceConjunto.getAbajo()!=  null)&&(!visitados.Contains(this.enlaceConjunto.getAbajo()))){
                    this.enlaceConjunto.getAbajo().recorrer(tamano,indiceActual,visitados);
                }
                if((this.enlaceConjunto.getIzquierda()!= null)&&(!visitados.Contains(this.enlaceConjunto.getIzquierda()))){
                    this.enlaceConjunto.getIzquierda().recorrer(tamano,indiceActual,visitados);
                }
            }
        }
    
        public Cuadro buscarCuadro(int indice,List<Cuadro> visitados,Cuadro cuadro){
            visitados.Add(this);
            //Cuadro cuadro = new Cuadro();
            if(this.indice != indice){
                if((this.enlaceConjunto.getArriba()!= null)&&(!visitados.Contains(this.enlaceConjunto.getArriba()))){
                    cuadro = this.enlaceConjunto.getArriba().buscarCuadro(indice,visitados,cuadro);
                }
                if((this.enlaceConjunto.getDerecha()!= null)&&(!visitados.Contains(this.enlaceConjunto.getDerecha()))){
                    cuadro = this.enlaceConjunto.getDerecha().buscarCuadro(indice,visitados,cuadro);
                }
                if((this.enlaceConjunto.getAbajo()!=  null)&&(!visitados.Contains(this.enlaceConjunto.getAbajo()))){
                    cuadro = this.enlaceConjunto.getAbajo().buscarCuadro(indice,visitados,cuadro);
                }
                if((this.enlaceConjunto.getIzquierda()!= null)&&(!visitados.Contains(this.enlaceConjunto.getIzquierda()))){
                    cuadro = this.enlaceConjunto.getIzquierda().buscarCuadro(indice,visitados,cuadro);
                }
            }else{
                return this;
            }
            if(this.indice == indice){
                return this;
            }
            return cuadro;
        }

        public List<int> recorrerFila(List<int> encontrados,List<Cuadro> visitado){
            if(!visitado.Contains(this)){visitado.Add(this);encontrados.Add(this.indice);}
            if((!visitado.Contains(this.enlaceConjunto.getDerecha()))&&(this.enlaceConjunto.getDerecha() != null)){
                this.enlaceConjunto.getDerecha().recorrerFila(encontrados,visitado);
            }
            if((!visitado.Contains(this.enlaceConjunto.getIzquierda()))&&(this.enlaceConjunto.getIzquierda()!= null)){
                this.enlaceConjunto.getIzquierda().recorrerFila(encontrados,visitado);
            }
            if(!visitado.Contains(this.enlaceVecino.getVecinoDerecha())&&(this.enlaceVecino.getVecinoDerecha() != null)){
                this.enlaceVecino.getVecinoDerecha().recorrerFila(encontrados,visitado);
            }
            if((!visitado.Contains(this.enlaceVecino.getVecinoIzquierda()))&&(this.enlaceVecino.getVecinoIzquierda() != null)){
                this.enlaceVecino.getVecinoIzquierda().recorrerFila(encontrados,visitado);
            }
            return encontrados;
        }

        public List<int> recorrerColumna(List<int> encontrados,List<Cuadro> visitado){
            if(!visitado.Contains(this)){visitado.Add(this);encontrados.Add(this.indice);}
            if((!visitado.Contains(this.enlaceConjunto.getArriba()))&&(this.enlaceConjunto.getArriba() != null)){
                this.enlaceConjunto.getArriba().recorrerColumna(encontrados,visitado);
            }
            if((!visitado.Contains(this.enlaceConjunto.getAbajo()))&&(this.enlaceConjunto.getAbajo() != null)){
                this.enlaceConjunto.getAbajo().recorrerColumna(encontrados,visitado);
            }
            if((!visitado.Contains(this.enlaceVecino.getVecinoArriba()))&&(this.enlaceVecino.getVecinoArriba() != null)){
                this.enlaceVecino.getVecinoArriba().recorrerColumna(encontrados,visitado);
            }
            if((!visitado.Contains(this.enlaceVecino.getVecinoAbajo()))&&(this.enlaceVecino.getVecinoAbajo() != null)){
                this.enlaceVecino.getVecinoAbajo().recorrerColumna(encontrados,visitado);
            }
            return encontrados;
        }

        public Cuadro buscarCoordenadas(Posicion posicion,List<Cuadro> visitados,Cuadro cuadro){
            visitados.Add(this);
            if(this.posicion.getX() != posicion.getX() || this.posicion.getY() != posicion.getY()){
                if((this.enlaceConjunto.getArriba()!= null)&&(!visitados.Contains(this.enlaceConjunto.getArriba()))){
                    cuadro = this.enlaceConjunto.getArriba().buscarCoordenadas(posicion,visitados,cuadro);
                }
                if((this.enlaceConjunto.getDerecha()!= null)&&(!visitados.Contains(this.enlaceConjunto.getDerecha()))){
                    cuadro = this.enlaceConjunto.getDerecha().buscarCoordenadas(posicion,visitados,cuadro);
                }
                if((this.enlaceConjunto.getAbajo()!=  null)&&(!visitados.Contains(this.enlaceConjunto.getAbajo()))){
                    cuadro = this.enlaceConjunto.getAbajo().buscarCoordenadas(posicion,visitados,cuadro);
                }
                if((this.enlaceConjunto.getIzquierda()!= null)&&(!visitados.Contains(this.enlaceConjunto.getIzquierda()))){
                    cuadro = this.enlaceConjunto.getIzquierda().buscarCoordenadas(posicion,visitados,cuadro);
                }
            }else{
                return this;
            }
            if(this.posicion.getX() != posicion.getX() && this.posicion.getY() != posicion.getY()){
                return this;
            }
            return null;
        }
    }
}