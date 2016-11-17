using System;

namespace _27PatronesDisenio.Consola.Builder
{
    public class Vendedor
    {
        protected ConstructorDocumentacionVehiculo constructor;

        public Vendedor(ConstructorDocumentacionVehiculo constructor)
        {
            this.constructor = constructor;
        }

        public Documentacion construye(string nombreCliente)
        {
            constructor.construyeSolicitudPedido(nombreCliente);
            constructor.construyeSolicitudMatriculacion
            (nombreCliente);
            Documentacion documentacion = constructor.resultado();
            return documentacion;
        }
    } 
}
