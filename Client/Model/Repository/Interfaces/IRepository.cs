using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Client.Model.Repository.Interfaces
{
    interface IRepository
    {
        Task<IEnumerable<Worker>?> GetWorkersAsync();
        Task<Worker?> ReadWorkerAsync(int id);
        Task<bool> CreateWorkerAsync(Worker value);
        Task<bool> UpdateWorkerAsync(Worker value);
        Task<bool> DeleteWorkerAsync(Worker value);
    }
}
