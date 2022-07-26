using QATask.DomainModels.Base;
using QATask.DomainModels.Entites;

namespace QATask.DomainModels.DTOs
{
    public class AnswerDto : IDto
    {
        public string? AnswerText { get; set; }
        public int? QuestionId { get; set; }

    }
}
