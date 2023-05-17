using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
/*The following lines of code to add using directives for the
Microsoft.AspNetCore.Mvc, Microsoft.Azure.WebJobs,
Microsoft.AspNetCore.Http, and Microsoft.Extensions.Logging namespaces.*/
public static class Echo
{/*The following code block to create a new public static method
named Run that returns a variable of type IActionResult and that
also takes in variables of type HttpRequest and ILogger as parameters
named request and logger.*/
    [FunctionName("Echo")]
    public static IActionResult Run(
        [HttpTrigger("POST")] HttpRequest request,
        ILogger logger)
    {
        logger.LogInformation("Received a request");
        return new OkObjectResult(request.Body);
        /*The following line of code to echo the body of the HTTP request as the HTTP response.*/
    }
}
