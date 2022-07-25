

using AutoMapper;
using QATask.DomainModels;
using QATask.DomainModels.DTOs;
using QATask.DomainModels.Entities;
using QATask.Services.Services.Contracts;

namespace QATask.Services.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly Answer[]? answers = { new Answer { Id = 1, AnswerText = "Ivan Ivanov", QuestionID=1 }, new Answer { Id = 2, AnswerText = "UA", QuestionID=2 }, new Answer { Id = 3, AnswerText = "65000", QuestionID = 2 } };

        private readonly IMapper _mapper;
        public AnswerService(IMapper mapper)
        {
            _mapper = mapper;
        }
        static void Main()
        {
        }
        public async Task<bool> GiveAnswer(AnswerDto? answerDto)
        {
            var answer =  answers.FirstOrDefault(x => x.AnswerText == answerDto.AnswerText && x.QuestionID==answerDto.Question.Id);

            if (answer == null)
                return false;

            return true;

        }

    }
}
