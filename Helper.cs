using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTests
{
    public class Helper
    {   
        private RestRequest request;
        private const string baseUrl = "https://reqres.in/";

        public RestClient SetUrl(string endpoint)
        {
            var Url = Path.Combine(baseUrl, endpoint);
            var client = new RestClient(Url);
            return client;
        }
        public RestRequest createGetRequest()
        {   
            request = new RestRequest("", Method.Get);          
            return request;
        }
        public RestRequest createPostRequest(string payload)
        {
            request = new RestRequest("", Method.Post);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", payload, ParameterType.RequestBody);
            return request;
        }

        public RestRequest createPutRequest(string payload)
        {
            request = new RestRequest("", Method.Put);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", payload, ParameterType.RequestBody);
            return request;
        }

        public RestResponse createDeleteRequest(RestClient restClient, string id)
        {
            request = new RestRequest(id, Method.Delete);
            request.AddHeader("Accept", "application/json");
            return restClient.Delete(request);
        }
        public RestResponse GetResponse(RestClient restClient, RestRequest restRequest)
        {
            return restClient.Execute(restRequest);
        }
        public string getContent(RestResponse response)
        {
            var content = response.Content;
            return content;
        }
    }
}
