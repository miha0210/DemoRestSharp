using RestSharp;
using System;

namespace DemoTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing GET, POST, PUT, DELETE Requests
            Tests test = new Tests();

            test.executeGetRequest();
            test.executePostRequest();
            test.executePutRequest();
            test.executeDeleteRequest();
        }
    }
}
