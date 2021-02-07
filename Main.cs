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
            for(int i = 1; i<= aux.getTamano();i++){
                List<int> encontrados = new List<int>();
                List<Cuadro> visi = new List<Cuadro>();
                Console.WriteLine("lista columna");
                aux.getPrincipal().buscarCuadro(i,visitados).recorrerColumna(encontrados,visi).ForEach(Console.WriteLine);
            }
            for(int i = 1; i<= aux.getTamano();i++){
                List<int> encontrados = new List<int>();
                List<Cuadro> visi = new List<Cuadro>();
                Console.WriteLine("lista fila");
                aux.getPrincipal().buscarCuadro(i,visitados).recorrerFila(encontrados,visi).ForEach(Console.WriteLine);
            }
        }
    }
}
