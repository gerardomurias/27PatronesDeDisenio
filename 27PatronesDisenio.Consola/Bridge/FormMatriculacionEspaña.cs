using System;

namespace _27PatronesDisenio.Consola.Bridge
{
    public class FormularioMatriculacionEspaña :
FormularioMatriculacion
    {
        public FormularioMatriculacionEspaña(FormularioImpl
        implementacion) : base(implementacion) { }

        protected override bool controlZona(string matricula)
        {
            return matricula.Length == 7;
        }
    } 
}
