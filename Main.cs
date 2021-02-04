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
            Console.WriteLine(aux.getTamano());

            List<Cuadro> vicitados = new List<Cuadro>();
            aux.getPrincipal().recorrer(aux.getTamano(),1,vicitados);

            Entero aux2 = (Entero)ficha.getContenido();
            foreach(DictionaryEntry elemento in aux2.getContenidoCuadro()){
                Console.WriteLine("Indice: "+ elemento.Key+" Contenido: "+ elemento.Value);
            }
        }
    }
}
