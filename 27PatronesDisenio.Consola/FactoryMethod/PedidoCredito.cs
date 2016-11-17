using System;

namespace _27PatronesDisenio.Consola.FactoryMethod
{
    public class PedidoCredito : Pedido
    {
        public PedidoCredito(double importe) : base(importe) { }

        public override void paga()
        {
            Console.WriteLine(
              "El pago del pedido a cr�dito de: " +
              importe + " se ha realizado.");
        }

        public override bool valida()
        {
            return (importe >= 1000.0) && (importe <= 5000.0);
        }
    } 
}