namespace _27PatronesDisenio.Consola.Visitor
{
    public interface Visitante
    {
        void visita(EmpresaSinFilial empresa);
        void visita(EmpresaMadre empresa);
    }

}