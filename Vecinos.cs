using System;

namespace ProyectoVSC{

    abstract class Vecinos{
        public abstract void unirVecinos(Condicion c, Forma f){}

        public abstract bool sonVecinos(Forma f){}
    }

    class VecinoCuadrado{
        public override void unirVecinos(Condicion c, Forma f){}

        public override bool sonVecinos(Forma f){}
    }
}