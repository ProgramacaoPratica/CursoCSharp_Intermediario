using System;
using System.IO;
using System.ServiceProcess;

namespace ServicoWindowsExemplo
{
    public partial class MonitoramentoDiretorioService : ServiceBase
    {
        private FileSystemWatcher _fileWatcher;
        private string diretorioMonitorar = @"C:\Arquivos";
        private string caminhoLog = @"C:\Logs\LogArquivos.txt";

        public MonitoramentoDiretorioService()
        {
            InitializeComponent();

#if DEBUG
            OnStart(null);
#endif
        }

        protected override void OnStart(string[] args)
        {
            _fileWatcher = new FileSystemWatcher(diretorioMonitorar);
            _fileWatcher.EnableRaisingEvents = true;
            _fileWatcher.Created += (sender, e) =>
            {
                GravarLog($"Arquivo Criado: {e.FullPath}");
            };
            _fileWatcher.Deleted += (sender, e) =>
            {
                GravarLog($"Arquivo Excluído: {e.FullPath}");
            };
            _fileWatcher.Changed += (sender, e) =>
            {
                GravarLog($"Arquivo Modificado: {e.FullPath}");
            };
            _fileWatcher.Renamed += (sender, e) =>
            {
                GravarLog($"Arquivo Renomeado: {e.FullPath}");
            };
        }

        protected override void OnStop()
        {
            _fileWatcher.Dispose();
        }

        private void GravarLog(string mensagem)
        {
            File.AppendAllText(caminhoLog, $"{DateTime.Now:dd/MM/yyyy 'às' HH:mm:ss} - {mensagem}\n");
        }
    }
}