using System;
using System.Collections.Generic;

namespace ProyectoVSC{

    abstract class GenerarContenido{
        public abstract GenerarContenido generar(Condicion c,Ficha f);
    }

    class EnteroSudoku: GenerarContenido{
        
        public override EnteroSudoku generar(Condicion c,Ficha f){
            EnteroSudoku entero_sudoku = new EnteroSudoku();
            FichaSudoku ficha = (FichaSudoku)f;


            return entero_sudoku;
        }    
    }
}