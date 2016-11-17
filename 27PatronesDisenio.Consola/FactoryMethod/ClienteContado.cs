namespace _27PatronesDisenio.Consola.FactoryMethod
{
    public class ClienteContado : Cliente
    {
        protected override Pedido creaPedido(double importe)
        {
            return new PedidoContado(importe);
        }
    }

}