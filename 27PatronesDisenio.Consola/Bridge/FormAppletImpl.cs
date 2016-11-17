using System;

namespace _27PatronesDisenio.Consola.Bridge
{
    public class FormAppletImpl : FormularioImpl
    {

        public void dibujaTexto(string texto)
        {
            Console.WriteLine("Applet: " + texto);
        }

        public string administraZonaIndicada()
        {
            return Console.ReadLine();
        }
    } 
}
