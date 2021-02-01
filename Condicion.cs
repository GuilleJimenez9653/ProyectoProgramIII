using System;

namespace ProyectoVSC{

    abstract class Condicion{
        public abstract boolean condicion(){}
    }

    class RestriccionSudoku: Condicion{
        public override boolean condicion(){}
    }

    class ContenidoSudoku: Condicion{
        public override boolean condicion(){}
    }

    class VecindadSudoku: Condicion{
        public override boolean condicion(){}
    }
}