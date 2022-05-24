using System.ComponentModel.DataAnnotations;
using CleanProject.Domain.Models;

namespace CleanProject.API.Contracts;

public class CreateModelRequest
{
    public int Number { get; set; }

    [Required]
    [StringLength(Model.NAME_LENGTH)]
    public string Name { get; set; }

    public DateTime Date { get; set; }
}
