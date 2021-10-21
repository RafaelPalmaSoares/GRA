using GRA.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GRA.Test
{
    [Collection(nameof(IntegrationApiTestFixtureCollection))]
    public class FixturesTest
    {
        private readonly IntegrationTestFixture<StartupApiTests> _integrationTestFixture;
        public FixturesTest(IntegrationTestFixture<StartupApiTests> integrationTestFixture)
        {
            _integrationTestFixture = integrationTestFixture;
        }

        [Fact(DisplayName = "Busca Intervalo de Prêmios")]
        public async Task GetWinnersInteval()
        {

            var requisicao = await _integrationTestFixture.Client.GetAsync($"api/movie/getwinnersinterval");
            var resposta = await requisicao.Content.ReadAsStringAsync();

            Assert.True(requisicao.IsSuccessStatusCode);
        }
    }
}
