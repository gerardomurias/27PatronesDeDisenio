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
            contenido.Add(new VistaVehiculo("vehículo económico"));
            contenido.Add(new VistaVehiculo("vehículo amplio"));
            contenido.Add(new VistaVehiculo("vehículo rápido"));
            contenido.Add(new VistaVehiculo("vehículo confortable"));
            contenido.Add(new VistaVehiculo("vehículo deportivo"));
            this.dibujo = dibujo;
        }

        public void dibuja()
        {
            dibujo.dibuja(contenido);
        }
    } 
}
