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
            return MemberwiseClone();
        }
    }
}
