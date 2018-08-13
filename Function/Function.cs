using System;
using Core;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;

namespace Function
{
    public static class Function
    {
        [FunctionName(nameof(Function))]
        public static void Run([QueueTrigger("queue", Connection = "AzureWebJobsStorage")]string message, TraceWriter log)
        {
            log.Info($"C# Queue trigger function processed: {message}");

            var item = JsonConvert.DeserializeObject<Base>(message, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
        }
    }
}
