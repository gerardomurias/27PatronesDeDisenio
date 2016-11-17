using System;

namespace _27PatronesDisenio.Consola.Prototype
{
    public class CertificadoCesion : Documento
    {
        public override void visualiza()
        {
            Console.WriteLine(
              "Muestra el certificado de cesión: " + contenido);
        }

        public override void imprime()
        {
            Console.WriteLine(
              "Imprime el certificado de cesión: " + contenido);
        }
    } 
}
