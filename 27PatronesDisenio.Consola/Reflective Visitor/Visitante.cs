﻿using System.Reflection;
using System;

namespace _27PatronesDisenio.Consola.ReflectiveVisitor
{
    public abstract class Visitante
    {
        public void iniciaVisita(Visitable visitable)
        {
            MethodInfo infoMetodo = this.GetType().GetMethod("visita",
             new Type[] { visitable.GetType() });
            infoMetodo.Invoke(this, new object[] { visitable });
        }

        public void visita(Visitable visitable)
        {
            Console.WriteLine("Visita por defecto");
        }
    } 
}