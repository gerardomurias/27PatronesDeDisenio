using System;

namespace _27PatronesDisenio.Consola.Adapter
{
    public interface Documento
    {
        string contenido { set; }
        void dibuja();
        void imprime();
    }

}