using covid.Core.Entities;
using covid.Core.Entities.Generated;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace covid.Core.Services
{
    public class MZCRCovidInfoProvider : ICovidInfoProvider
    {
        private const string URL = "https://onemocneni-aktualne.mzcr.cz/api/v2/covid-19/zakladni-prehled.json";

        private readonly HttpClient _httpClient;
        private readonly ILogger<MZCRCovidInfoProvider> _logger;

        public MZCRCovidInfoProvider(ILogger<MZCRCovidInfoProvider> logger,
            IHttpClientProvider httpClientProvider)
        {
            _logger = logger;
            _httpClient = httpClientProvider.Get();
        }

        public async Task<Overview> GetOverview()
        {
            _logger.LogInformation($"Getting overview from {nameof(MZCRCovidInfoProvider)}, url: {URL}...");

            var result = await _httpClient.GetStringAsync(URL);

            _logger.LogInformation(result);

            var o = (OverviewJson)JsonSerializer.Deserialize(result, typeof(OverviewJson));
            var item = o.data.First();

            _logger.LogInformation($"Creating overview from (first) item {item}");

            return new Overview(
                item.datum,
                item.provedene_antigenni_testy_celkem,
                item.potvrzene_pripady_celkem,
                item.aktivni_pripady,
                item.umrti,
                item.vyleceni,
                item.aktualne_hospitalizovani,
                item.provedene_testy_vcerejsi_den,
                item.potvrzene_pripady_vcerejsi_den,
                item.vykazana_ockovani_celkem,
                item.vykazana_ockovani_vcerejsi_den);
        }
    }
}
