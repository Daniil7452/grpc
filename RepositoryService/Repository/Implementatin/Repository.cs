using RepositoryService.Repository.Interfaces;
using RepositoryService.Repository.Models;

namespace RepositoryService.Repository.Implementatin
{
    public class Repository : IRepository
    {
        private AppDbContext _DBContext = new();

        public Repository() 
        { 
            
        }

        public IEnumerable<Worker> Workers => _DBContext.Workers;

        public async Task CreateWorkerAsync(Worker value)
        {
            await _DBContext.Workers.AddAsync(value);
            await _DBContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteWorkerAsync(int id)
        {
            var worker = await _DBContext.Workers.FindAsync(id);
            if (worker == null)
            {
                return false;
            }
            _DBContext.Workers.Remove(worker);
            return true;
        }

        public async Task<Worker?> ReadWorkerAsync(int id)
        {
            return await _DBContext.Workers.FindAsync(id);
        }

        public async Task<bool> UpdateWorkerAsync(Worker value)
        {
            var worker = await _DBContext.Workers.FindAsync(value.Id);
            if (worker == null)
            {
                return false;
            }
            worker.Name = value.Name;
            worker.Surname = value.Surname;
            worker.Patronymic = value.Patronymic;
            worker.Birthday = value.Birthday;
            worker.Gender = value.Gender;
            worker.HavingChildren = value.HavingChildren;
            await _DBContext.SaveChangesAsync();
            return true;
        }
    }
}
