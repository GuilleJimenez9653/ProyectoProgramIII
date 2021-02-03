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
                    this.setTamano(1);
                    cuadro.setIndice(this.getTamano());
                    this.setPrincipal(cuadro);                    
                }else{
                    Cuadro cuadro = new Cuadro();
                    this.setTamano(this.getTamano()+1);
                    cuadro.setIndice(this.getTamano());
                    this.getPrincipal().combinar(cuadro);
                }
                aux = r.Next(3+(this.getTamano()));
            }
        } 

        
    }
}