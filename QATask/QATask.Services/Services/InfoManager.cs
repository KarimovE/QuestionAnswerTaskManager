
using QATask.DomainModels.DTOs;
using QATask.DomainModels.Entites;
using QATask.Services.Services.Contracts;

namespace QATask.Services.Services
{
    public class InfoManager : IInfoService
    {
        static void Main()
        {
        }
        public InfoDto GetInfo()
        {
            InfoDto info = new InfoDto();
            return info;
        }

    }
}
