using System;

namespace _27PatronesDisenio.Consola.Interpreter
{
    public class PalabraClave : Expresion
    {
        protected string palabraClave;

        public PalabraClave(string palabraClave)
        {
            this.palabraClave = palabraClave;
        }

        public override bool evalua(string descripcion)
        {
            return descripcion.IndexOf(palabraClave) != -1;
        }

        // parte an�lisis sint�ctico
        public static new Expresion parsea()
        {
            Expresion resultado;
            resultado = new PalabraClave(pieza);
            siguientePieza();
            return resultado;
        }
    }

}