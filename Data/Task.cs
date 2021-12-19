using System.ComponentModel.DataAnnotations.Schema;

namespace TasksAPI.Data
{
    [Table("Task")]
    public record Task(int Id, string Name, string Status);
}
