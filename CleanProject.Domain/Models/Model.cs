using CSharpFunctionalExtensions;

namespace CleanProject.Domain.Models;

public record Model
{
    public const int NAME_LENGTH = 200;

    private Model(int number, string name, DateTime date)
    {
        Number = number;
        Name = name;
        Date = date;
    }

    public int Number { get; }

    public string Name { get; }

    public DateTime Date { get; }

    public static Result<Model> Create(int number, string name, DateTime date)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Result.Failure<Model>("Name cannot be null or whitespace");
        }

        if (name.Length > NAME_LENGTH)
        {
            return Result.Failure<Model>($"Name should be less then {NAME_LENGTH}");
        }

        return new Model(number, name, date);
    }
}
