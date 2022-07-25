using QATask.DomainModels.Base;
using QATask.DomainModels.Entites;
using QATask.DomainModels.Base;

namespace QATask.DomainModels.Entities
{
    public class Answer : TimestampableObject, IEntity
    {
        public int Id { get; set; }
        public string? AnswerText { get; set; }
        public int QuestionID { get; set; }
        public Question Question { get; set; }
        public bool IsCorrect { get; set; }

    }
}