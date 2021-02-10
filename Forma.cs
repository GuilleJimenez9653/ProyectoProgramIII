using System;
using System.Collections.Generic; 

namespace ProyectoVSC{

    abstract class Forma{}

    class ConjuntoCuadrado: Forma{
        private Cuadro principal;
        private int tamano;

        public int getTamano() {
            return this.tamano;
        }

        public void setTamano(int tamano) {
            this.tamano = tamano;
        }


        public Cuadro getPrincipal() {
            return this.principal;
        }

        public void setPrincipal(Cuadro principal) {
            this.principal = principal;
        }

        public void generarCuadro(){
            this.tamano = 0;
            Random r = new Random();
            int aux = r.Next(3+(this.tamano));
            while(aux < 4){
                if(this.principal == null){
                    Cuadro cuadro = new Cuadro();
                    cuadro.getPosicion().setX(0);
                    cuadro.getPosicion().setY(0);
                    cuadro.setIndice(this.tamano);
                    this.principal = cuadro;                    
                }else{
                    Cuadro cuadro = new Cuadro();
                    this.tamano += 1;
                    cuadro.setIndice(this.tamano);
                    this.principal.combinar(cuadro,0,0);
                }
                if (this.tamano == 4){
                    aux = 5;
                }else{
                    aux = r.Next(3+(this.tamano));
                }
            }
            this.tamano += 1;
            for(int i =0; i<=this.tamano;i++){
                this.enlacesConjunto(i);
            }
        }  

        public void enlacesConjunto(int i){
            List<Cuadro> visitados = new List<Cuadro>();
            Posicion posicionAux = new Posicion();
            Cuadro cuadroAux = new Cuadro();
            Cuadro cuadro = new Cuadro();
            cuadro = this.principal.buscarCuadro(i,visitados,cuadroAux);
            visitados.Clear();cuadroAux = null;
            posicionAux.setX(cuadro.getPosicion().getX());
            posicionAux.setY(cuadro.getPosicion().getY());
            if(cuadro.getEnlaceConjunto().getArriba() == null){
                posicionAux.setY(posicionAux.getY()+1);
                if(this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux) != null){
                    visitados.Clear();cuadroAux = null;
                    cuadro.getEnlaceConjunto().setArriba(this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux));
                    visitados.Clear();cuadroAux = null;
                    this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux).getEnlaceConjunto().setAbajo(cuadro);
                }
                visitados.Clear();cuadroAux = null;
                posicionAux.setX(cuadro.getPosicion().getX());
                posicionAux.setY(cuadro.getPosicion().getY());
            }
            if(cuadro.getEnlaceConjunto().getDerecha() == null){
                posicionAux.setX(posicionAux.getX()+1);
                if(this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux) != null){
                    visitados.Clear();cuadroAux = null;
                    cuadro.getEnlaceConjunto().setDerecha(this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux));
                    visitados.Clear();cuadroAux = null;
                    this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux).getEnlaceConjunto().setIzquierda(cuadro);
                }
                visitados.Clear();cuadroAux = null;
                posicionAux.setX(cuadro.getPosicion().getX());
                posicionAux.setY(cuadro.getPosicion().getY());
            }
            if(cuadro.getEnlaceConjunto().getAbajo() == null){
                posicionAux.setY(posicionAux.getY()-1);
                if(this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux) != null){
                    visitados.Clear();cuadroAux = null;
                    cuadro.getEnlaceConjunto().setAbajo(this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux));
                    visitados.Clear();cuadroAux = null;
                    this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux).getEnlaceConjunto().setArriba(cuadro);
                }
                visitados.Clear();cuadroAux = null;
                posicionAux.setX(cuadro.getPosicion().getX());
                posicionAux.setY(cuadro.getPosicion().getY());
            }
            if(cuadro.getEnlaceConjunto().getAbajo() == null){
                posicionAux.setX(posicionAux.getX()-1);
                if(this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux) != null){
                    visitados.Clear();cuadroAux = null;
                    cuadro.getEnlaceConjunto().setIzquierda(this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux));
                    visitados.Clear();cuadroAux = null;
                    this.principal.buscarCoordenadas(posicionAux,visitados,cuadroAux).getEnlaceConjunto().setDerecha(cuadro);
                }
                visitados.Clear();cuadroAux = null;
                posicionAux.setX(cuadro.getPosicion().getX());
                posicionAux.setY(cuadro.getPosicion().getY());
            }
        }
    }
}