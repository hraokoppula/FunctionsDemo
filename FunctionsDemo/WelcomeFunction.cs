using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionsDemo;

public class WelcomeFunction
{
    private readonly ILogger<WelcomeFunction> _logger;

    public WelcomeFunction(ILogger<WelcomeFunction> logger)
    {
        _logger = logger;
    }

    [Function("WelcomeFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}