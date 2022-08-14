using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bootcamp_News
{
    public class NewsApiGoogle
    {
        private const string newsApiGoogle = $"https://newsapi.org/v2/everything";
        private const string token = "a6b4a886693649f9ae4aa9f8653147df";
        private const string language = "pt";

        public Bootcamp_Domain.GoogleApiNewsDomain.News BuscarNoticiasTermo(string termo, DateTime dataInicial, DateTime dataFinal)
        {
            HttpClient client = new HttpClient();
            var endpoint = $"{newsApiGoogle}?q={termo}&language={language}&from={dataInicial.ToString("yyyy-MM-dd")}&to={dataFinal.ToString("yyyy-MM-dd")}&apiKey={token}";
            client.BaseAddress = new Uri(newsApiGoogle);

            var response = client.GetAsync(endpoint).Result;
            if (response.IsSuccessStatusCode)
            {
                using var contentStream = response.Content.ReadAsStreamAsync().Result;
                var noticias = JsonSerializer.DeserializeAsync<Bootcamp_Domain.GoogleApiNewsDomain.News>(contentStream).Result;
                return noticias;
            }

            return null;
        }
    }
}
