using System;

namespace _27PatronesDisenio.Consola.FactoryMethod
{
    public class PedidoContado : Pedido
    {
        public PedidoContado(double importe) : base(importe) { }

        public override void paga()
        {
            Console.WriteLine(
              "El pago del pedido por importe de: " +
              importe + " se ha realizado.");
        }

        public override bool valida()
        {
            return true;
        }
    }

}