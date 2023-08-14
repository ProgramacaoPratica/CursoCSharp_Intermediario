using FastReport;

namespace ProjetoExemplo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string caminhoRelatorio = Path.Combine(Directory.GetCurrentDirectory(), @"Relatorios\PrimeiroRelatorio.frx");
            Report report = Report.FromFile(caminhoRelatorio);

            //Parâmetros do relatório
            report.SetParameterValue("nome", "Gilseone Moraes");
            report.SetParameterValue("email", "contato@programacaopratica.com.br");
            report.SetParameterValue("mensagem", "Eu estou adorando o curso");

            report.Prepare();

            using var pdfExport = new FastReport.Export.PdfSimple.PDFSimpleExport();
            using var reportStream = new MemoryStream();
            pdfExport.Export(report, reportStream);
            File.WriteAllBytes("MeuRelatorio.pdf", reportStream.ToArray());
        }
    }
}