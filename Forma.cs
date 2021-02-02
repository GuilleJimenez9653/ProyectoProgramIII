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

        

        public Cuadro generarCuadro(){
            Random rnd = new Random();
            if(this.getPrincipal() == null){
                Cuadrado cuadro = new Cuadrado();
                this.setPrincipal(cuadro);
                this.setTamano(1);
            }else{
                
            }
        }

        
    }
}