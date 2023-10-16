using Newtonsoft.Json;
using RestSharp;
using System;
using System.IO;
using System.ServiceProcess;

namespace ServicoWindowsExemplo
{
    partial class MonitoramentoClimaService : ServiceBase
    {
        private string caminhoLog = @"C:\Logs\LogCondicoesClimaticas.txt";

        public MonitoramentoClimaService()
        {
            InitializeComponent();
#if DEBUG
            OnStart(null);
#endif
        }

        protected override void OnStart(string[] args)
        {
            timerMonitoramento.Enabled = true;
            timerMonitoramento_Tick(null, null);
        }

        protected override void OnStop()
        {
            timerMonitoramento.Enabled = false;    
        }

        private async void timerMonitoramento_Tick(object sender, EventArgs e)
        {
            var client = new RestClient("http://apiadvisor.climatempo.com.br/api/v1");
            var request = new RestRequest("weather/locale/5139/current", Method.Get);
            request.AddQueryParameter("token", "SEU_TOKEN");

            var response = await client.GetAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var objClimaAtual = JsonConvert.DeserializeObject<ClimaAtualDto>(response.Content);

                if(objClimaAtual != null)
                    GravarLog($"Temperatura: {objClimaAtual.Data.Temperature}ºC - Condição: {objClimaAtual.Data.Condition}");
            }
        }

        private void GravarLog(string mensagem)
        {
            File.AppendAllText(caminhoLog, $"{DateTime.Now:dd/MM/yyyy 'às' HH:mm:ss} - {mensagem}\n");
        }
    }

    public class ClimaAtualDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("data")]
        public DadosClimaDto Data { get; set; }
    }

    public class DadosClimaDto
    {
        [JsonProperty("temperature")]
        public decimal Temperature { get; set; }

        [JsonProperty("wind_direction")]
        public string WindDirection { get; set; }

        [JsonProperty("wind_velocity")]
        public decimal WindVelocity { get; set; }

        [JsonProperty("humidity")]
        public decimal Humidity { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("pressure")]
        public decimal Pressure { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("sensation")]
        public decimal Sensation { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}