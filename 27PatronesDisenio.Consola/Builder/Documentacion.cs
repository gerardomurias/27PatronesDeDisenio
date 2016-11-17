using System;
using System.Collections.Generic;

namespace _27PatronesDisenio.Consola.Builder
{
    public abstract class Documentacion
    {
        protected IList<string> contenido =
            new List<string>();

        public abstract void agregaDocumento(string documento);
        public abstract void imprime();
    }

}