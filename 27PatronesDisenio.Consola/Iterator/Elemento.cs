using System;

namespace _27PatronesDisenio.Consola.Iterator
{
    public abstract class Elemento
    {
        protected string descripcion;

        public Elemento(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public bool palabraClaveValida(string palabraClave)
        {
            return descripcion.IndexOf(palabraClave) != -1;
        }
    }

}