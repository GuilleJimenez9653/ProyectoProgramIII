using System;

namespace ProyectoVSC{

    abstract class GenerarContenido{
        public abstract GenerarContenido generar(Condicion c);
    }

    class EnteroSudoku: GenerarContenido{
        public override EnteroSudoku generar(Condicion c){}
    }
}