using System;

namespace _27PatronesDisenio.Consola.Strategy
{
    public class VistaVehiculo
    {
        protected string descripcion;

        public VistaVehiculo(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public void dibuja()
        {
            Console.Write(descripcion);
        }
    }

}