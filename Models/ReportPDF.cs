namespace SistGestNotas.Models
{
    public class ReportePDF : IDocumento
    {
        public void GenerarDocumento(Boletin boletin)
        {
            Console.WriteLine("Generando el reporte en formato PDF...");
            
        }

        public void ExportarDocumento(string ruta)
        {
            Console.WriteLine($"Exportando el reporte PDF a la ruta: {ruta}");
            
        }
    }
}
