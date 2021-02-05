using System;
using System.Collections;

namespace ProyectoVSC{

    abstract class Contenido{}

    class Entero: Contenido{
        private Hashtable contenidoCuadro = new Hashtable();

        public Hashtable getContenidoCuadro()
        {
            return this.contenidoCuadro;
        }

        public void setContenidoCuadro(Hashtable contenidoCuadro)
        {
            this.contenidoCuadro = contenidoCuadro;
        }

        public void llenar(RestriccionSudoku c, ConjuntoCuadrado conjunto){
            Random r = new Random();
            int aux,i=0;
            while(i<conjunto.getTamano()){
                aux = r.Next(9);
                if (c.condicionContenido(aux,conjunto)){
                    this.contenidoCuadro.Add(i+1,aux);
                    i++;
                }   
            }
        }
    }
}