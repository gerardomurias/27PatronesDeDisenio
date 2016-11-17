using System;
using System.Collections.Generic;

namespace _27PatronesDisenio.Consola.Memento
{
    public class OpcionVehiculo
    {
        protected string nombre;
        public IList<OpcionVehiculo> opcionesIncompatibles
        { get; protected set; }

        public OpcionVehiculo(string nombre)
        {
            opcionesIncompatibles = new List<OpcionVehiculo>();
            this.nombre = nombre;
        }

        public void agregaOpcionIncompatible(OpcionVehiculo
          opcionIncompatible)
        {
            if (!opcionesIncompatibles.Contains(opcionIncompatible))
            {
                opcionesIncompatibles.Add(opcionIncompatible);
                opcionIncompatible.agregaOpcionIncompatible(this);
            }
        }

        public void visualiza()
        {
            Console.WriteLine("opci�n: " + nombre);
        }
    }

}