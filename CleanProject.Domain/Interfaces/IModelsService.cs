using CleanProject.Domain.Models;
using CSharpFunctionalExtensions;

namespace CleanProject.Domain.Interfaces;

public interface IModelsService
{
    Task<Result<int>> Create(Model model);
}
