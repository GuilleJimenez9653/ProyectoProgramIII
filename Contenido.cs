using System;
using System.Collections;

namespace ProyectoVSC{

    abstract class Contenido{

    }

    class Entero: Contenido{
        private Hashtable contenidoCuadro;

        public Hashtable getContenidoCuadro()
        {
            return this.contenidoCuadro;
        }

        public void setContenidoCuadro(int indice, int valor)
        {
            this.contenidoCuadro.Add(indice, valor);
        }

        public void llenar(ContenidoSudoku c, ConjuntoCuadrado conjunto){
            Random r = new Random();
            int aux,i=0;
            while(i<conjunto.getTamano()){
                aux = r.Next(9);
                if (c.condicionEntero(aux)){
                    this.setContenidoCuadro(i,aux);
                    i++;
                }   
            }
        }
    }
}