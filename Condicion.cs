using System;

namespace ProyectoVSC{

    abstract class Condicion{
        public abstract bool condicion();
    }

    class RestriccionSudoku: Condicion{
        public override bool condicion(){}
    }

    class ContenidoSudoku: Condicion{
        public override bool condicion(){}
    }

    class VecindadSudoku: Condicion{
        public override bool condicion(){}
    }
}