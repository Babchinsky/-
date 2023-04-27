using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using RestSharp;
using RestSharp.Authenticators;

namespace CryptoMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            var binanceApi = new BinanceApi("7jp33mErccyk0kzHXO9LLU1WG96mPzj2i8gy3eJXXEJ7OglbQQ4BauS2HTaCrJPu", // API Key
                "HnW0GjsxqWKSbu0eJw1f0CiKAXDdSXJYBQWKs6LSwFRLFwlm5NyyxaXT7WeGGmBM");                 // Secret Key

            var price = binanceApi.GetPrice("BTCUSDT");

            Console.WriteLine($"Price: {price}");
        }
    }




    public class BinanceApi
    {
        private const string baseUrl = "https://api.binance.com/api/v3";

        private readonly RestClient client;

        public BinanceApi(string apiKey, string apiSecret)
        {
            client = new RestClient(baseUrl);
            client.AddDefaultHeader("X-MBX-APIKEY", apiKey);
        }

        public decimal GetPrice(string symbol)
        {
            var request = new RestRequest($"/ticker/price?symbol={symbol}", RestSharp.Method.GET);

            var response = client.Execute<BinancePrice>(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception($"Failed to get price for {symbol}: {response.Content}");
            }

            return response.Data.Price;
        }

        private class BinancePrice
        {
            public decimal Price { get; set; }
        }
    }

}
