using System;

namespace ProyectoVSC{

    abstract class Condicion{
        public abstract bool condicion();
    }

    class RestriccionSudoku: Condicion{
        public override bool condicion(){
            bool seCumple = false;

            return seCumple;
        }
    }

    class ContenidoSudoku: Condicion{
        public override bool condicion(){
            bool seCumple = false;

            return seCumple;
        }
    }

    class VecindadSudoku: Condicion{
        public override bool condicion(){
            bool seCumple = false;

            return seCumple;
        }
    }
}