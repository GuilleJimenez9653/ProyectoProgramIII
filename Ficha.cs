using System;

namespace ProyectoVSC{
    
    abstract class Ficha{
        private Forma forma;
        private Contenido contenido;

        private bool colocado;

        public Forma getForma() {
            return this.forma;
        }

        public void setForma(Forma forma) {
            this.forma = forma;
        }

        public bool isColocado() {
            return this.colocado;
        }

        public void setColocado(bool colocado) {
            this.colocado = colocado;
        }

        public Contenido getContenido()
        {
            return this.contenido;
        }

        public void setContenido(Contenido contenido)
        {
            this.contenido = contenido;
        }

        public abstract bool estaColocado();
    }

    class FichaSudoku: Ficha{

        public FichaSudoku(){
            ConjuntoCuadrado conjuntoCuadrado = new ConjuntoCuadrado();
            RestriccionSudoku contenidoSudoku = new RestriccionSudoku();
            Entero entero = new Entero();
            conjuntoCuadrado.generarCuadro();
            this.setForma(conjuntoCuadrado);
            entero.llenar(contenidoSudoku,conjuntoCuadrado);
            this.setContenido(entero);
        }

        public override bool estaColocado(){
            return this.isColocado();
        }


    }
}