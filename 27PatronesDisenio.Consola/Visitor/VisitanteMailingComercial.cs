using System;

namespace _27PatronesDisenio.Consola.Visitor
{
    public class VisitanteMailingComercial : Visitante
    {
        public void visita(EmpresaSinFilial
          empresa)
        {
            Console.WriteLine("Env�a un email a " +
              empresa.nombre + " direcci�n: " + empresa.email
              + " Propuesta comercial para su empresa");
        }

        public void visita(EmpresaMadre empresa)
        {
            Console.WriteLine("Env�a un email a " +
              empresa.nombre + " direcci�n: " + empresa.email
              + " Propuesta comercial para su grupo");
            Console.WriteLine("Impresi�n de un correo electr�nico para " +
              empresa.nombre + " direcci�n: " +
              empresa.direccion +
              " Propuesta comercial para su grupo");
        }
    } 
}
