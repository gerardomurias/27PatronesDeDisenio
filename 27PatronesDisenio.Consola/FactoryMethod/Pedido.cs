using System;

namespace _27PatronesDisenio.Consola.FactoryMethod
{
    public abstract class Pedido
    {
        protected double importe;

        public Pedido(double importe)
        {
            this.importe = importe;
        }

        public abstract bool valida();

        public abstract void paga();
    }

}