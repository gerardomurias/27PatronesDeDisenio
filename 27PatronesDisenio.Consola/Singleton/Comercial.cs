using System;

namespace _27PatronesDisenio.Consola.Singleton
{
    public class Comercial
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }

        private static Comercial _instance = null;

        private Comercial() { }

        public static Comercial Instance()
        {
            if (_instance == null)
                _instance = new Comercial();
            return _instance;
        }

        public void visualiza()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Direcci�n: " + direccion);
            Console.WriteLine("Email: " + email);
        }

    } 
}
