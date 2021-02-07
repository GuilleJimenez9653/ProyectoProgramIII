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
                Cuadro cuadro = new Cuadro();
                Console.WriteLine(aux.getPrincipal().buscarCuadro(i,visitados,cuadro).getIndice()+ " Indice");
                visitados.Clear();
            }
            visitados.Clear();
            //Console.WriteLine(aux.getPrincipal().buscarCuadro(aux.getTamano(),visitados).getIndice()+ " Indice tamano");
            List<int> encontrados = new List<int>();
            List<Cuadro> visi = new List<Cuadro>();
        }
    }
}
