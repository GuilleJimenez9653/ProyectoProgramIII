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
                Cuadro cuadro = new Cuadro();
                aux2 = conjunto.getPrincipal().buscarCuadro(i,visitados,cuadro).recorrerFila(encontrados,visitados).Count;
                visitados.Clear();
                aux3 = conjunto.getPrincipal().buscarCuadro(i,visitados,cuadro).recorrerColumna(listaAux,visitados).Count;
                if(aux2 < aux3){
                    aux = r.Next(aux2);
                }else if(aux2 > aux3){
                    aux = r.Next(aux3);
                }else{
                    aux = r.Next(aux3);
                }
                aux = r.Next(aux3);
                visitados.Clear();
                if (c.condicionContenido(aux,conjunto.getPrincipal().buscarCuadro(i+1,visitados,cuadro)) && aux!=0){
                    this.contenidoCuadro.Add(i,aux);
                    i++;
                }
                visitados.Clear();
            }
        }
    }
}