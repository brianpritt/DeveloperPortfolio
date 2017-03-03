using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DeveloperProfile.Models;
using static DeveloperProfile.Models.GitClass;

namespace DeveloperProfile.Models
{
    public class GitReuslt
    {
        public GitReuslt()
        {

        }
            
        public RootObject[] GitCall()
        {
            var client = new RestClient("http://api.github.com/");
          
             
            var request = new RestRequest("users/brianpritt/starred?client_id=3e2eb44c3c59aeb6d168&client_secret=5b550b47780f00603d1d8b3393062ae636311693");
            request.AddHeader("User-Agent", "BrianPritt");
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            RootObject[] jsonResponse = JsonConvert.DeserializeObject<RootObject[]>(response.Content);
           
            return jsonResponse;


        }
        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
    }
}
