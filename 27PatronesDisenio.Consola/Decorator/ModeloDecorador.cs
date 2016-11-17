using System;

public class ModeloDecorador : Decorador
{
    public ModeloDecorador(ComponenteGraficoVehiculo
    componente)
        : base(componente) { }

    protected void visualizaInformacionTecnica()
    {
        Console.WriteLine("Informaci�n t�cnica del modelo");
    }

    public override void visualiza()
    {
        base.visualiza();
        this.visualizaInformacionTecnica();
    }
}
