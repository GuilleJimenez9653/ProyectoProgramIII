using System;
using System.Collections.Generic;

namespace ProyectoVSC{

    abstract class Vecinos{
        public abstract void unirVecinos(Condicion c, Forma f);

        public abstract bool sonVecinos(Forma f);
    }

    class VecinoCuadrado: Vecinos{
        public override void unirVecinos(Condicion c, Forma f){}

        public override bool sonVecinos(Forma f){
            bool son_vecinos = false;

            return son_vecinos;
        }
        public void unir(ConjuntoCuadrado conjunto1, ConjuntoCuadrado conjunto2){
            List<Cuadro> visitados = new List<Cuadro>();
            List<Posicion> posiciones1 = new List<Posicion>();
            List<Posicion> posiciones2 = new List<Posicion>();
            Cuadro cuadroAux = new Cuadro();
            Posicion posicionAux = new Posicion();
            posiciones1 = conjunto1.listaPosiciones();
            posiciones2 = conjunto2.listaPosiciones();
            foreach(Posicion lugar in posiciones1){
                Cuadro cuadro = new Cuadro();
                cuadro = conjunto1.getPrincipal().buscarCoordenadas(lugar,visitados,cuadroAux);
                posicionAux.setX(cuadro.getPosicion().getX());
                posicionAux.setY(cuadro.getPosicion().getY()+1);
                if(conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux) != null){
                    visitados.Clear();
                    cuadro.getEnlaceVecino().setVecinoArriba(conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux));
                    visitados.Clear();
                    conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux).getEnlaceVecino().setVecinoAbajo(cuadro);
                }
                visitados.Clear();
                posicionAux.setX(cuadro.getPosicion().getX());
                posicionAux.setY(cuadro.getPosicion().getY()-2);
                if(conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux) != null){
                    visitados.Clear();
                    cuadro.getEnlaceVecino().setVecinoAbajo(conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux));
                    visitados.Clear();
                    conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux).getEnlaceVecino().setVecinoArriba(cuadro);
                }
                visitados.Clear();
                posicionAux.setX(cuadro.getPosicion().getX()+1);
                posicionAux.setY(cuadro.getPosicion().getY()+1);
                if(conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux) != null){
                    visitados.Clear();
                    cuadro.getEnlaceVecino().setVecinoDerecha(conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux));
                    visitados.Clear();
                    conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux).getEnlaceVecino().setVecinoIzquierda(cuadro);
                }
                visitados.Clear();
                posicionAux.setX(cuadro.getPosicion().getX()-2);
                posicionAux.setY(cuadro.getPosicion().getY());
                if(conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux) != null){
                    visitados.Clear();
                    cuadro.getEnlaceVecino().setVecinoIzquierda(conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux));
                    visitados.Clear();
                    conjunto2.getPrincipal().buscarCoordenadas(posicionAux,visitados,cuadroAux).getEnlaceVecino().setVecinoDerecha(cuadro);
                }
                visitados.Clear();
            }
        }

        public void vincularVecinos(ConjuntoCuadrado conjunto1, ConjuntoCuadrado conjunto2,int i){
            List<Cuadro> visitados = new List<Cuadro>();
            List<Posicion> posiciones1 = new List<Posicion>();
            List<Posicion> posiciones2 = new List<Posicion>();
            Cuadro cuadroAux = new Cuadro();
            Cuadro cuadro1 = new Cuadro();
            Cuadro cuadro2 = new Cuadro();
            bool puedeUnir = true;
            cuadro1 = conjunto1.getPrincipal().buscarCuadro(i,visitados,cuadroAux);visitados.Clear();
            cuadro2 = conjunto2.getPrincipal().buscarCuadro(i,visitados,cuadroAux);visitados.Clear();
            posiciones1 = conjunto1.listaPosiciones();
            posiciones2 = conjunto2.listaPosiciones();
            if(cuadro1.getEnlaceConjunto().getArriba() == null && cuadro2.getEnlaceConjunto().getAbajo() == null){
                foreach(Posicion lugar in posiciones2){
                    lugar.setY(lugar.getY()+1);
                }
                foreach(Posicion lugar in posiciones2){
                    if(posiciones1.Contains(lugar)){
                        puedeUnir = false;
                    }
                }
                if(puedeUnir){
                    this.unir(conjunto1,conjunto2);
                }
                foreach(Posicion lugar in posiciones2){
                    lugar.setY(lugar.getY()-1);
                }
            }else if(cuadro1.getEnlaceConjunto().getAbajo() ==  null && cuadro2.getEnlaceConjunto().getArriba() == null){
                foreach(Posicion lugar in posiciones2){
                    lugar.setY(lugar.getY()-1);
                }
                foreach(Posicion lugar in posiciones2){
                    if(posiciones1.Contains(lugar)){
                        puedeUnir = false;
                    }
                }
                if(puedeUnir){
                    this.unir(conjunto1,conjunto2);
                }
                foreach(Posicion lugar in posiciones2){
                    lugar.setY(lugar.getY()+1);
                }
            }else if(cuadro1.getEnlaceConjunto().getDerecha() == null && cuadro2.getEnlaceConjunto().getIzquierda() == null){
                foreach(Posicion lugar in posiciones2){
                    lugar.setX(lugar.getX()+1);
                }
                foreach(Posicion lugar in posiciones2){
                    if(posiciones1.Contains(lugar)){
                        puedeUnir = false;
                    }
                }
                if(puedeUnir){
                    this.unir(conjunto1,conjunto2);
                }
                foreach(Posicion lugar in posiciones2){
                    lugar.setX(lugar.getX()-1);
                }
            }else if(cuadro1.getEnlaceConjunto().getIzquierda() == null && cuadro2.getEnlaceConjunto().getDerecha() == null){
                foreach(Posicion lugar in posiciones2){
                    lugar.setX(lugar.getX()-1);
                }
                foreach(Posicion lugar in posiciones2){
                    if(posiciones1.Contains(lugar)){
                        puedeUnir = false;
                    }
                }
                if(puedeUnir){
                    this.unir(conjunto1,conjunto2);
                }
                foreach(Posicion lugar in posiciones2){
                    lugar.setX(lugar.getX()+1);
                }
            }
        }
    }   
}

