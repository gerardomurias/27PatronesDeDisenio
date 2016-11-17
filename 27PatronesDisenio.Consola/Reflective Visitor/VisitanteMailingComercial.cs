using System;

namespace _27PatronesDisenio.Consola.ReflectiveVisitor
{
    public class VisitanteMailingComercial : Visitante, VisitanteEmpresa
    {
        public void visita(EmpresaSinFilial empresa)
        {
            Console.WriteLine("Env�a un correo a " +
             empresa.nombre + " direcci�n: " + empresa.email
             + " Propuesta comercial para su empresa");
        }

        public void visita(EmpresaMadre empresa)
        {
            Console.WriteLine("Env�a un correo a " +
          empresa.nombre + " direcci�n: " + empresa.email
          + " Propuesta comercial para su grupo");
            Console.WriteLine("Impresi�n de un correo para " +
             empresa.nombre + " direcci�n: " +
             empresa.direccion +
             " Propuesta comercial para su grupo");
            foreach (Empresa filial in empresa.filiales)
                this.iniciaVisita(filial);
        }
    } 
}
