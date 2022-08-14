var news = new Bootcamp_News.NewsApiGoogle().BuscarNoticiasTermo("Curitiba", DateTime.Now.AddMonths(-1), DateTime.Now);

Console.WriteLine($"Total de Noticias Encontradas {news.totalResults}");
