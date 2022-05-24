using CleanProject.Domain.Models;

namespace CleanProject.Domain.Interfaces;

public interface IModelsRepository
{
    Task<int> Add(Model model);
    Task<Model> Get(string name);
}
