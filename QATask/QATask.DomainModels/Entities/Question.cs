using QATask.DomainModels.Base;
using QATask.DomainModels.Base;

namespace QATask.DomainModels.Entites
{
    public class Question : TimestampableObject, IEntity
    {
        public int Id { get; set; }
        public string? Text { get; set; }
    }
}