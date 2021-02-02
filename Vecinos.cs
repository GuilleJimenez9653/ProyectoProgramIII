using System;

namespace ProyectoVSC{

    abstract class Vecinos{
        public abstract void unirVecinos(Condicion c, Forma f);

        public abstract bool sonVecinos(Forma f);
    }

    class VecinoCuadrado{
        public void unirVecinos(Condicion c, Forma f){}

        public bool sonVecinos(Forma f){
            bool son_vecinos = false;

            return son_vecinos;
        }
    }
}