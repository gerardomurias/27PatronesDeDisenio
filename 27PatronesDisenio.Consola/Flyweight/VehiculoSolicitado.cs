using System;
using System.Collections.Generic;

public class VehiculoSolicitado
{
    protected IList<OpcionVehiculo> opciones =
        new List<OpcionVehiculo>();
    protected IList<int> precioDeVentaOpciones =
        new List<int>();

    public void agregaOpciones(string nombre, int precioDeVenta,
      FabricaOpcion fabrica)
    {
        opciones.Add(fabrica.getOption(nombre));
        precioDeVentaOpciones.Add(precioDeVenta);
    }

    public void muestraOpciones()
    {
        int indice, tama�o;
        tama�o = opciones.Count;
        for (indice = 0; indice < tama�o; indice++)
        {
            opciones[indice].visualiza(
            precioDeVentaOpciones[indice]);
            Console.WriteLine();
        }
    }
}
