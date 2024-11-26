namespace SistGestNotas.Models
{
    public interface IDocumento
    {
        void GenerarDocumento(Boletin boletin);
        void ExportarDocumento(string ruta);
    }
}
