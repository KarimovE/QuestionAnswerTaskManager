

using QATask.DomainModels;
using QATask.DomainModels.DTOs;

namespace QATask.Services.Services.Contracts
{
    public interface IInfoService
    {
        Task<InfoDto> GetInfo();
    }
}
