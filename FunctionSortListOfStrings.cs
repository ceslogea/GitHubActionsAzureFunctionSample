using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Strings.Function
{
    public static class FunctionSortListOfStrings
    {
        [FunctionName("FunctionSortListOfStrings")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function 'FunctionSortListOfStrings', processed a request. Started");
            log.LogInformation("C# HTTP trigger function 'FunctionSortListOfStrings', processed a request. Executed successfully");

            return new OkObjectResult("Function FunctionSortListOfStrings called");
        }
    }
}
