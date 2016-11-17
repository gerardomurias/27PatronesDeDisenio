using System;

namespace _27PatronesDisenio.Consola.State
{
    public class Producto
    {
        protected string nombre;

        public Producto(string nombre)
        {
            this.nombre = nombre;
        }

        public void visualiza()
        {
            Console.WriteLine("Producto: " + nombre);
        }
    } 
}
