using System;
using System.Collections;
using System.Collections.Generic;

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
                List<Cuadro> visitados = new List<Cuadro>();
                if (c.condicionContenido(aux,conjunto.getPrincipal().buscarCuadro(i+1,0,visitados))){
                    this.contenidoCuadro.Add(i+1,aux);
                    i++;
                }   
            }
        }
    }
}