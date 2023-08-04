using Grpc.Net.Client;
using RepositoryService;
using testClient;
using testClient.Model.Repository.gRPC;

namespace testClient
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

    internal class Program
    {
        static async Task Main(string[] args)
        {
            GrpcRepositoryClient grpcClient = new("http://localhost:5246");

            /*
            for (int i = 0; i < 100; i++)
            {
                await grpcClient.CreateWorkerAsync(new Worker()
                {
                    Id = i,
                    Name = $"Name {i}",
                    Surname = $"Surname {i}",
                    Patronymic = $"Patronymic {i}",
                    Birthday = DateTime.Now,
                    Gender = Gender.Male,
                    HavingChildren = true
                });
            }
            */

            var workers = await grpcClient.GetWorkersAsync();

            if(workers != null)
            {
                foreach (Worker worker in workers)
                {
                    Console.WriteLine($"{worker.Id} {worker.Name} {worker.Birthday}");
                }
            }

        }
    }
}