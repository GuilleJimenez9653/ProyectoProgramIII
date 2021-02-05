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

        public void setContenidoCuadro(Hashtable contenidoCuadro)
        {
            this.contenidoCuadro = contenidoCuadro;
        }

        public void llenar(RestriccionSudoku c, ConjuntoCuadrado conjunto){
            Random r = new Random();
            Hashtable tablaAux = new Hashtable();
            int aux,i=0;
            while(i<conjunto.getTamano()){
                aux = r.Next(9);
                if (c.condicionContenido(aux)){
                    tablaAux.Add(i+1,aux);
                    i++;
                }   
            }
            this.setContenidoCuadro(tablaAux);
        }
    }
}