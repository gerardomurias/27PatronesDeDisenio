using System;

namespace _27PatronesDisenio.Consola.Iterator
{
    public class Vehiculo : Elemento
    {

        public Vehiculo(string descripcion) : base(descripcion) { }

        public void visualiza()
        {
            Console.WriteLine("Descripción del vehículo: " +
              descripcion);
        }
    } 
}
