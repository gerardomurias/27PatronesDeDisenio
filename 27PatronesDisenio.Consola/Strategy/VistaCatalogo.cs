using System.Collections.Generic;

namespace _27PatronesDisenio.Consola.Strategy
{
    public class VistaCatalogo
    {
        protected IList<VistaVehiculo> contenido =
            new List<VistaVehiculo>();
        protected DibujaCatalogo dibujo;

        public VistaCatalogo(DibujaCatalogo dibujo)
        {
            contenido.Add(new VistaVehiculo("veh�culo econ�mico"));
            contenido.Add(new VistaVehiculo("veh�culo amplio"));
            contenido.Add(new VistaVehiculo("veh�culo r�pido"));
            contenido.Add(new VistaVehiculo("veh�culo confortable"));
            contenido.Add(new VistaVehiculo("veh�culo deportivo"));
            this.dibujo = dibujo;
        }

        public void dibuja()
        {
            dibujo.dibuja(contenido);
        }
    } 
}
