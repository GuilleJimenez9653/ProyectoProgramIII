using System;

namespace ProyectoVSC{

    abstract class Forma{

    }

    class ConjuntoCuadrado: Forma{
        private Cuadro principal;

        public Cuadro getPrincipal() {
            return this.principal;
        }

        public void setPrincipal(Cuadro principal) {
            this.principal = principal;
        }

        public void combinar(){}

        public Cuadro generarCuadro(){}

    }
}