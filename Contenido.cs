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
            List<int> listaAux = new List<int>();
            List<int> encontrados = new List<int>();
            List<Cuadro> visitados = new List<Cuadro>();
            int aux,i=0;
            int aux2=0;
            int aux3=0;
            while(i<conjunto.getTamano()){
                //listaAux = conjunto.getPrincipal().buscarCuadro(i+1,1,visitados).recorrerFila(encontrados,visitados);
                aux2 = conjunto.getPrincipal().buscarCuadro(i+1,visitados).recorrerFila(encontrados,visitados).Count;
                visitados.Clear();
                aux3 = conjunto.getPrincipal().buscarCuadro(i+1,visitados).recorrerColumna(listaAux,visitados).Count;
                //Console.WriteLine(aux2);
                aux = r.Next(1,aux3);
                visitados.Clear();
                if (c.condicionContenido(aux,conjunto.getPrincipal().buscarCuadro(i+1,visitados))){
                    this.contenidoCuadro.Add(i+1,aux);
                    i++;
                }
                visitados.Clear();
                 
            }
        }
    }
}