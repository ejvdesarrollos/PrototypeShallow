using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDeep
{
    //Se implementa una Interfaz
    public class ParaClonar : ICloneable
    {
        public string Nombre {get; set; }
        public int Valor { get; set; }

        //Si es Shallow, no clona los objeto dentro del principal
        public Detalle detalle;

        //Método que pide implementar por ICloneable
        public object Clone()
        {
            ParaClonar objClon = this.MemberwiseClone() as ParaClonar;
            objClon.Nombre = this.Nombre;
            objClon.Valor = this.Valor;
            objClon.detalle = new Detalle();
            objClon.detalle.Clase = this.detalle.Clase;
            //Es un método de ICloneable que permite crear una copia superficial
            return objClon;
        }
    }

    public class Detalle
    {
        public string Clase { get; set; }
    }
}
