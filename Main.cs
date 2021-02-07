using System;
using System.Collections.Generic;
using System.Collections;

namespace ProyectoVSC{

    class Principal{

        static void Main(string[] args){
            Console.WriteLine("Hola");

            FichaSudoku ficha = new FichaSudoku();
            ConjuntoCuadrado aux = new ConjuntoCuadrado();
            aux = (ConjuntoCuadrado)ficha.getForma();
            Console.WriteLine(aux.getTamano()+"tamano");

            List<Cuadro> visitados = new List<Cuadro>();
            aux.getPrincipal().recorrer(aux.getTamano(),1,visitados);

            Entero aux2 = (Entero)ficha.getContenido();
            foreach(DictionaryEntry elemento in aux2.getContenidoCuadro()){
                Console.WriteLine("Indice: "+ elemento.Key+" Contenido: "+ elemento.Value);
            }
            visitados.Clear();
            for(int i = 1; i <= aux.getTamano();i++){
                Console.WriteLine(aux.getPrincipal().buscarCuadro(i,visitados).getIndice()+ " Indice");
                visitados.Clear();
            }
            List<int> encontrados = new List<int>();
            List<Cuadro> visi = new List<Cuadro>();
            for(int i = 1; i<= aux.getTamano();i++){
                encontrados.Clear();
                visi.Clear();
                Console.WriteLine("lista columna, indice: "+ aux.getPrincipal().buscarCuadro(i,visi).getIndice());
                visi.Clear();
                aux.getPrincipal().buscarCuadro(i,visitados).recorrerColumna(encontrados,visi).ForEach(Console.WriteLine);
            }
            for(int i = 1; i<= aux.getTamano();i++){
                encontrados.Clear();
                visi.Clear();
                Console.WriteLine("lista fila, indice: "+aux.getPrincipal().buscarCuadro(i,visi).getIndice());
                visi.Clear();
                aux.getPrincipal().buscarCuadro(i,visitados).recorrerFila(encontrados,visi).ForEach(Console.WriteLine);
            }
        }
    }
}
