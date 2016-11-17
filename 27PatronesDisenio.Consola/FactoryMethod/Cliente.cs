using System.Collections.Generic;

namespace _27PatronesDisenio.Consola.FactoryMethod
{
    public abstract class Cliente
    {
        protected IList<Pedido> pedidos =
            new List<Pedido>();

        protected abstract Pedido creaPedido(double importe);

        public void nuevoPedido(double importe)
        {
            Pedido pedido = this.creaPedido(importe);
            if (pedido.valida())
            {
                pedido.paga();
                pedidos.Add(pedido);
            }
        }
    }

}