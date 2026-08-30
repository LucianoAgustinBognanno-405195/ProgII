using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1._1.Domain
{
    public interface ICollection
    {
        public bool estaVacio();
        public object extraer();
        public object primero(); 
        public bool aniadir(object oObjeto);
        
    }
}
