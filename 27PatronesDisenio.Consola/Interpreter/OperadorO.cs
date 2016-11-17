using System;

namespace _27PatronesDisenio.Consola.Interpreter
{
    public class OperadorO : OperadorBinario
    {
        public OperadorO(Expresion operandoIzquierdo,
        Expresion operandoDerecho)
            : base(operandoIzquierdo,
        operandoDerecho)
        { }

        public override bool evalua(string descripcion)
        {
            return operandoIzquierdo.evalua(descripcion) ||
            operandoDerecho.evalua(descripcion);
        }

        // parte an�lisis sint�ctico
        public static new Expresion parsea()
        {
            Expresion resultadoIzquierdo, resultadoDerecho;
            resultadoIzquierdo = OperadorY.parsea();
            while ((pieza != null) && (pieza == "o"))
            {
                siguientePieza();
                resultadoDerecho = OperadorY.parsea();
                resultadoIzquierdo = new OperadorO(resultadoIzquierdo,
                  resultadoDerecho);
            }
            return resultadoIzquierdo;
        }
    }

}