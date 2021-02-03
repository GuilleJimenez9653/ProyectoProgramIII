using System;
using System.Collections.Generic; 

namespace ProyectoVSC{

    abstract class Forma{

    }

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
            this.setTamano(0);
            Random r = new Random();
            int aux = r.Next(3+(this.getTamano()));
            while(aux < 5){
                if(this.getPrincipal() == null){
                    Cuadro cuadro = new Cuadro();
                    this.setPrincipal(cuadro);
                    this.setTamano(1);
                }else{
                    Cuadro cuadro = new Cuadro();
                    this.getPrincipal().combinar(cuadro);
                    this.setTamano(this.getTamano()+1);
                }
                aux = r.Next(3+(this.getTamano()));
            }
        } 

        
    }
}