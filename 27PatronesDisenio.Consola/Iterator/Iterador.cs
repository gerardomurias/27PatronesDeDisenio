using System;
using System.Collections.Generic;

namespace _27PatronesDisenio.Consola.Iterator
{
    public abstract class Iterador<TElemento>
where TElemento : Elemento
    {
        public string palabraClaveConsulta { protected get; set; }
        protected int indice;
        public IList<TElemento> contenido { protected get; set; }


        public void inicio()
        {
            indice = 0;
            int tama�o = contenido.Count;
            while ((indice < tama�o) &&
              (!contenido[indice].palabraClaveValida(palabraClaveConsulta)))
                indice++;
        }

        public void siguiente()
        {
            int tama�o = contenido.Count;
            indice++;
            while ((indice < tama�o) &&
              (!contenido[indice].palabraClaveValida(palabraClaveConsulta)))
                indice++;
        }

        public TElemento item()
        {
            if (indice < contenido.Count)
                return contenido[indice];
            else
                return null;
        }
    } 
}
