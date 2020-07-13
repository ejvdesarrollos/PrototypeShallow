using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeShallow
{
    //Se implementa una Interfaz
    public class ParaClonar : ICloneable
    {
        public string Nombre {get; set; }
        public int Valor { get; set; }

        //Método que pide implementar por ICloneable
        public object Clone()
        {
            //Es un método de ICloneable que permite crear una copia superficial
            //solo copia el objeto original y no sus dependientes
            //es decir, si un atributo es un objeto, la copia referencia al mismo atributo que el original.
            return MemberwiseClone();
        }
    }
}
