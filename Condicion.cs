using System;

namespace ProyectoVSC{

    interface Condicion{
        bool condicion();
    }

    class RestriccionSudoku: Condicion{
        
        bool Condicion.condicion(){return true;}
        
        public bool condicionContenido(int num, ConjuntoCuadrado conjunto){
            bool seCumple = true;
            return seCumple;
        }
    }
}