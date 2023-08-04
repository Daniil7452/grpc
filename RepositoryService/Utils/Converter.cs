using Google.Protobuf.WellKnownTypes;
using RepositoryService.Repository.common;
using RepositoryService.Repository.Models;

namespace RepositoryService.Utils
{
    /// <summary>
    /// Для конвертации типов данных
    /// </summary>
    public static class Converter
    {
        static Gender ToGender(int value)
        {
            try
            {
                return (Gender)value;
            }
            catch
            {
                return Gender.UNKNOWN;
            }
        }
        public static WorkerGrpcObj WorkerToWorkerGrpcObj(Worker value)
        {
            return new()
            {
                Id = value.Id,
                Name = value.Name,
                Surname = value.Surname,
                Patronymic = value.Patronymic,
                Birthday = Timestamp.FromDateTimeOffset(value.Birthday),
                Gender = (int)value.Gender,
                HavingChildren = value.HavingChildren,
            };
        }

        public static Worker WorkerGrpcObjToWorker(WorkerGrpcObj value)
        {
            return new()
            {
                Id = value.Id,
                Name = value.Name,
                Surname = value.Surname,
                Patronymic = value.Patronymic,
                Birthday = value.Birthday.ToDateTime(),
                Gender = ToGender(value.Gender),
                HavingChildren = value.HavingChildren,
            };
        }
    }
}
