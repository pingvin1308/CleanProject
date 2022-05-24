using System.ComponentModel.DataAnnotations;

namespace CleanProject.DataAccess.Postgres.Entities
{
    public class Model
    {
        [StringLength(Domain.Models.Model.NAME_LENGTH)]
        public int Number { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }
    }
}