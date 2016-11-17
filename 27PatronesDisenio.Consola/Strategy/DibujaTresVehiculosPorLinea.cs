using System;
using System.Collections.Generic;

namespace _27PatronesDisenio.Consola.Strategy
{
    public class DibujaTresVehiculosPorLinea : DibujaCatalogo
    {
        public void dibuja(IList<VistaVehiculo> contenido)
        {
            int contador;
            Console.WriteLine(
              "Dibuja los veh�culos mostrando tres veh�culos por l�nea");
            contador = 0;
            foreach (VistaVehiculo vistaVehiculo in contenido)
            {
                vistaVehiculo.dibuja();
                contador++;
                if (contador == 3)
                {
                    Console.WriteLine();
                    contador = 0;
                }
                else
                    Console.Write(" ");
            }
            if (contador != 0)
                Console.WriteLine();
            Console.WriteLine();
        }
    }

}