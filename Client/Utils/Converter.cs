using Client.Model;
using Google.Protobuf.WellKnownTypes;
using RepositoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Utils
{
    class Converter
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


        internal static WorkerGrpcObj WorkerToWorkerGrpcObj(Worker value)
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

        internal static Worker WorkerGrpcObjToWorker(WorkerGrpcObj value)
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
