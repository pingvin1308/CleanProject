using CleanProject.Domain.Interfaces;
using CleanProject.Domain.Models;
using CSharpFunctionalExtensions;

namespace CleanProject.BusinessLogic;

public class ModelsService : IModelsService
{
    private readonly IModelsRepository modelsRepository;

    public ModelsService(IModelsRepository modelsRepository)
    {
        this.modelsRepository = modelsRepository;
    }

    public async Task<Result<int>> Create(Model newModel)
    {
        var model = await this.modelsRepository.Get(newModel.Name);
        if (model is not null)
        {
            Result.Failure<int>($"Model with name {newModel.Name} already exists");
        }

        var modelId = await this.modelsRepository.Add(newModel);
        return modelId;
    }
}
