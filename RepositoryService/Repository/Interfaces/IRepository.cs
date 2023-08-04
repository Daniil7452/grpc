using RepositoryService.Repository.Models;

namespace RepositoryService.Repository.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Worker> Workers { get; }

        Task CreateWorkerAsync(Worker value);
        Task<Worker?> ReadWorkerAsync(int id);
        Task<bool> UpdateWorkerAsync(Worker value);
        Task<bool> DeleteWorkerAsync(int id);
    }
}
