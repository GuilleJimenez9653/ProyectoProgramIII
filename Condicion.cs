using System;
using System.Collections.Generic;

namespace ProyectoVSC{

    interface Condicion{
        bool condicion();
    }

    class RestriccionSudoku: Condicion{
        
        bool Condicion.condicion(){return true;}
        
        public bool condicionContenido(int num, Cuadro cuadro){
            bool seCumple = true;
            List<int> fila = new List<int>();
            List<int> columna = new List<int>();
            List<Cuadro> visitados = new List<Cuadro>();
            fila = cuadro.recorrerFila(fila,visitados);
            visitados.Clear();
            columna = cuadro.recorrerColumna(columna,visitados);
            if(fila.Contains(num)&&columna.Contains(num)){
                seCumple = false;
            }
            return seCumple;
        }
    }
}