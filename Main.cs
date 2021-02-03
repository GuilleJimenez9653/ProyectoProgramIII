using System;
using System.Collections.Generic;

namespace ProyectoVSC{

    class Principal{

        static void Main(string[] args){
            Console.WriteLine("Hola");

            FichaSudoku ficha = new FichaSudoku();
            ConjuntoCuadrado aux = new ConjuntoCuadrado();
            aux = (ConjuntoCuadrado)ficha.getForma();
            Console.WriteLine(aux.getTamano());

            int total = 0;
            List<Cuadro> vicitados = new List<Cuadro>();
            aux.getPrincipal().recorrer(vicitados,total,aux.getTamano());
        }
    }
}
