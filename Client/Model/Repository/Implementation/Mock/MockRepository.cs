using Client.Model.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client.Model.Repository.Implementation.Mock
{
    class MockRepository : IRepository
    {
        public MockRepository(string adres) { }

        private List<Worker> _workers = new List<Worker>();
        public async Task<bool> CreateWorkerAsync(Worker value)
        {
            _workers.Add(value);
            return true;
        }

        public async Task<bool> DeleteWorkerAsync(Worker value)
        {
            return _workers.Remove(value);
        }

        public async Task<IEnumerable<Worker>?> GetWorkersAsync()
        {
            return _workers;
        }

        public async Task<Worker?> ReadWorkerAsync(int id)
        {
            return _workers.Find(w => w.Id == id);
        }

        public async Task<bool> UpdateWorkerAsync(Worker value)
        {
            var worker = _workers.Find(w => w.Id == value.Id);
            if (worker == null)
                return false;

            worker = value;
            return true;
        }
    }
}
