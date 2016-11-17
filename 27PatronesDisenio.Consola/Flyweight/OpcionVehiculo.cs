using System;

public class OpcionVehiculo
{
    protected string nombre;
    protected string descripcion;
    protected int precioEstandar;

    public OpcionVehiculo(string nombre)
    {
        this.nombre = nombre;
        this.descripcion = "Descripci�n de " + nombre;
        this.precioEstandar = 100;
    }

    public void visualiza(int precioDeVenta)
    {
        Console.WriteLine("Opci�n");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine(descripcion);
        Console.WriteLine("Precio est�ndar: " + precioEstandar);
        Console.WriteLine("Precio de venta: " + precioDeVenta);
    }
}
