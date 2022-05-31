using System.Text.Json;

namespace Logic
{
    public class CurrencyConverter
    {
        private double exchangeRate;

        public double ExchangeRate
        {
            get
            {
                return exchangeRate;
            }
            set
            {
                if(value > 0)
                {
                    exchangeRate = value;
                }
            }
        }

        public async void SetExchangeRate()
        {
            using(var client = new HttpClient())
            {
                var request = client.GetAsync("https://www.cbr-xml-daily.ru/daily_json.js").Result;
                var json = await request.Content.ReadAsStringAsync();
                CurrencyExchange currencies = JsonSerializer.Deserialize<CurrencyExchange>(json)!;
                if(currencies.Valute != null)
                ExchangeRate = currencies.Valute["USD"].Value;
            }
        }

        public CurrencyConverter() { }
    }
}
