using CleanProject.API.Contracts;
using CleanProject.Domain.Interfaces;
using CleanProject.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanProject.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ModelsController : ControllerBase
{
    private readonly IModelsService service;
    private readonly ILogger<ModelsController> logger;

    public ModelsController(IModelsService service, ILogger<ModelsController> logger)
    {
        this.service = service;
        this.logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateModelRequest request)
    {
        var model = Model.Create(request.Number, request.Name, request.Date);
        if (model.IsFailure)
        {
            this.logger.LogError(message: model.Error);
            return BadRequest(model.Error);
        }

        var modelId = this.service.Create(model.Value);
        return Ok(modelId);
    }
}
