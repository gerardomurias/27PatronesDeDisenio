using System;

namespace _27PatronesDisenio.Consola.Bridge
{
    public class FormularioMatriculacionPortugal :
FormularioMatriculacion
    {
        public FormularioMatriculacionPortugal(FormularioImpl
        implementacion) : base(implementacion) { }

        protected override bool controlZona(string matricula)
        {
            return matricula.Length == 6;
        }
    } 
}
