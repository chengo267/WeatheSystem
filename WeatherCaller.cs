using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherSystem
{
    class WeatherCaller
    {
        private RestClient m_Client;
        private RestRequest m_Request;

        public WeatherCaller()
        {
            client = new RestClient();
            client.BaseUrl = new Uri("http://api.openweathermap.org/data/2.5/weather");
            request = new RestRequest(Method.GET);
        }

        public RestClient client
        {
            get { return m_Client; }
            set { m_Client = value; }
        }
        public RestRequest request
        {
            get { return m_Request; }
            set { m_Request = value; }
        }

        public async Task<string> get(string city)
        {
            request.AddParameter("q", city);
            request.AddParameter("appid", "20e124111194612d954f92a809b3f487");
            var response = await client.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                throw new HttpRequestException();
            }
           return response.Content.ToString();
        }
    }
}
