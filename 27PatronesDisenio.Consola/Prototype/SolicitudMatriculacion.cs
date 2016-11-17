using System;

namespace _27PatronesDisenio.Consola.Prototype
{
    public class SolicitudMatriculacion : Documento
    {
        public override void visualiza()
        {
            Console.WriteLine(
              "Muestra la solicitud de matriculaci�n: " + contenido);
        }

        public override void imprime()
        {
            Console.WriteLine(
              "Imprime la solicitud de matriculaci�n: " + contenido);
        }
    }

}