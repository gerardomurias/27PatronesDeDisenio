namespace _27PatronesDisenio.Consola.TemplateMethod
{
    public class PedidoEspa�a : Pedido
    {
        protected override void calculaIVA()
        {
            importeIVA = importeSinIVA * 0.18;
        }
    }

}