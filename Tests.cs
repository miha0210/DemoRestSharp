using System;
using RestSharp;

namespace DemoTests
{
    class Tests
    {
        Helper helper = new Helper();

        //GET Request
        public void executeGetRequest()
        {
            var client = helper.SetUrl("api/users/2"); 
            var requestGet = helper.createGetRequest();
            //RestResponse response = client.Execute(requestGet);
            RestResponse response = helper.GetResponse(client, requestGet);
            var content = response.Content;
            Console.WriteLine(content);
        }

        //POST Request
        public void executePostRequest()
        {
            string payload = @"{""name"": ""mihaela"",""job"": ""QA""}";
            var client = helper.SetUrl("api/users");
            var requestPost = helper.createPostRequest(payload);
            var response = helper.GetResponse(client, requestPost);
            var createUser = helper.getContent(response);
            Console.WriteLine(createUser);
            
        }
        
        //PUT Request
        public void executePutRequest()
        {
            string payloadPut = @"{""name"": ""mihaela update"",""job"": ""QA""}";
            var client = helper.SetUrl("api/users/2");
            var requestPut = helper.createPutRequest(payloadPut);
            var response = helper.GetResponse(client, requestPut);
            var updateUser = helper.getContent(response);
            Console.WriteLine(updateUser);
        }

        //DELETE Request
        public void executeDeleteRequest()
        {
            var client = helper.SetUrl("api/users/2");
            var requestDel = helper.createDeleteRequest(client, "2");
            var result = helper.getContent(requestDel);
            Console.WriteLine(result);
        }
    }
}
