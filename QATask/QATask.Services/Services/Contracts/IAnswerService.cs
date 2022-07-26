
using QATask.DomainModels.DTOs;

namespace QATask.Services.Services.Contracts
{
    public interface IAnswerService
    {
        bool GiveAnswer(AnswerDto answerDto);
    }
}
