using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_1._1.Domain
{
    public class Pila : ICollection
    {
        private object [] elementos = new object [10];
        private int posicion = 0;
            
        public bool estaVacio()
        {
            if (posicion == 0)
            {
                return true;
            }
            return false;
        }

        public object extraer()
        {
            if (posicion == 0)
                return false;

            else
            {
                object temp = elementos[posicion];
                elementos[posicion] = null;
                posicion--;
                return temp;
            }      
        }

        public object primero()
        {
            return elementos[posicion];
        }

        public bool aniadir(object oObjeto)
        {
            if (posicion <= 9)
            {
                elementos [posicion] = oObjeto;
                posicion++;
                return true;
            }
            return false;
        }

    }
}
