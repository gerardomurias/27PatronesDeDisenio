namespace _27PatronesDisenio.Consola.Iterator
{
    public class CatalogoVehiculo : Catalogo<Vehiculo,
IteradorVehiculo>
    {

        public CatalogoVehiculo()
        {
            contenido.Add(new Vehiculo("veh�culo econ�mino"));
            contenido.Add(new Vehiculo("peque�o veh�culo econ�mico"));
            contenido.Add(new Vehiculo("veh�culo de gran calidad"));
        }
    }

}