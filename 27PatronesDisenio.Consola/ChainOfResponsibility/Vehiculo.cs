using System;

namespace _27PatronesDisenio.Consola.ChainOfResponsibility
{
    public class Vehiculo : ObjetoBasico
    {
        protected string laDescripcion;

        public Vehiculo(string descripcion)
        {
            this.laDescripcion = descripcion;
        }

        protected override string descripcion
        {
            get
            {
                return laDescripcion;
            }
        }
    } 
}
