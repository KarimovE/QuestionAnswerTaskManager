

using QATask.DomainModels;
using QATask.DomainModels.DTOs;

namespace QATask.Services.Services.Contracts
{
    public interface IAnswerService
    {
        Task<bool> GiveAnswer(AnswerDto answerDto);
    }
}
