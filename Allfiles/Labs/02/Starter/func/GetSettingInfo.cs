/*The following lines of code to add using directives for the
    Microsoft.AspNetCore.Http, Microsoft.AspNetCore.Mvc, and
    Microsoft.Azure.WebJobs namespaces.*/
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;

public static class GetSettingInfo
{
    [FunctionName("GetSettingInfo")]
    //Specify that the name of the Azure Function is "GetSettingInfo".
    public static IActionResult Run(
        [HttpTrigger("GET")] HttpRequest request,
        [Blob("content/settings.json")] string json)
        => new OkObjectResult(json);

        /*The following code to update the Run expression-bodied method
         to return a new instance of the OkObjectResult class passing
         in the value of the json method parameter as the sole
         constructor parameter.*/
}
