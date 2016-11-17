using System;

namespace _27PatronesDisenio.Consola.Builder
{
    public class DocumentacionPdf : Documentacion
    {
        public override void agregaDocumento(string documento)
        {
            if (documento.StartsWith("<PDF>"))
                contenido.Add(documento);
        }

        public override void imprime()
        {
            Console.WriteLine("Documentaci�n PDF");
            foreach (string s in contenido)
                Console.WriteLine(s);
        }
    } 
}
