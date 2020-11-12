using RestSharp;
using System;
using System.Net.Http;

namespace WeatherSystem
{
    class WeatherCaller
    {
        private RestClient m_Client;
        private RestRequest m_Request;
        private const string m_BaseUrl= "http://api.openweathermap.org/data/2.5/weather";

        public WeatherCaller()
        {
            client = new RestClient();
            client.BaseUrl = new Uri(baseUrl);
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

        public string baseUrl
        {
            get { return m_BaseUrl; }
        }
        public string get(string city)
        {
            request.AddParameter("q", city);
            request.AddParameter("appid", "20e124111194612d954f92a809b3f487");
            var response = client.Execute(request);
            if (!response.IsSuccessful)
            {
                throw new HttpRequestException();
            }
           return response.Content.ToString();
        }
    }
}
