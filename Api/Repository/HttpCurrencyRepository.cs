using System;
using RestSharp;

public class HttpCurrencyRpository
{
    public NBPResponse GetExchangeRate(CurrencyRequestModel model)
    {
        var client = new RestClient("http://api.nbp.pl");
        // client.Authenticator = new HttpBasicAuthenticator(username, password);

        var request = new RestRequest("api/exchangerates/rates/A/{currency}/{date}", Method.GET);
        request.AddParameter("format", "json"); // adds to POST or URL querystring based on Method
        request.AddUrlSegment("currency", model.currency); // replaces matching token in request.Resource
        request.AddUrlSegment("date", model.date.ToString("yyyy-MM-dd"));
        var response = client.Execute<NBPResponse>(request);
        return response.Data;
    }


}