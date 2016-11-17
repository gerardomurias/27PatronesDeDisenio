using System.Collections.Generic;

namespace _27PatronesDisenio.Consola.Memento
{
    public class MementoImpl : Memento
    {
        protected IList<OpcionVehiculo> opciones =
            new List<OpcionVehiculo>();

        public IList<OpcionVehiculo> estado
        {
            get
            {
                return opciones;
            }
            set
            {
                this.opciones.Clear();
                foreach (OpcionVehiculo opcion in value)
                    this.opciones.Add(opcion);
            }
        }
    } 
}
