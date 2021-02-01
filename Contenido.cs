using System;

namespace ProyectoVSC{

    abstract class Contenido{

    }

    class Entero: Contenido{
        private int valor;

        public int getValor() {
            return this.valor;
        }

        public void setValor(int valor) {
            this.valor = valor;
        }
    }
}