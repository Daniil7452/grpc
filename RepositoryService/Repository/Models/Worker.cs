using Microsoft.EntityFrameworkCore;
using RepositoryService.Repository.common;

namespace RepositoryService.Repository.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Patronymic { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public bool HavingChildren { get; set; }
    }
}
