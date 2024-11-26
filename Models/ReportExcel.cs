

namespace SistGestNotas.Models
{
    public class ReporteExcel : IDocumento
    {
        public void GenerarDocumento(Boletin boletin)
        {
            Console.WriteLine("Generando el reporte en formato Excel...");
            
        }

        public void ExportarDocumento(string ruta)
        {
            Console.WriteLine($"Exportando el reporte Excel a la ruta: {ruta}");
            
        }
    }
}
