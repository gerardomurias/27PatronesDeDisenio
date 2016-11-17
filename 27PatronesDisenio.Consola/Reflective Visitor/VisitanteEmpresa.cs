namespace _27PatronesDisenio.Consola.ReflectiveVisitor
{
    public interface VisitanteEmpresa
    {
        void visita(EmpresaSinFilial empresa);
        void visita(EmpresaMadre empresa);
    } 
}
