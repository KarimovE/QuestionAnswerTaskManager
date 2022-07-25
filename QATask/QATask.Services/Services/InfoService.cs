

using QATask.DomainModels;
using QATask.DomainModels.DTOs;
using QATask.DomainModels.Entites;
using QATask.Services.Services.Contracts;

namespace QATask.Services.Services
{
    public class InfoService : IInfoService
    {
        private readonly Question[]? questions = { new Question { Id = 1, Text = "Where is fullname?" }, new Question { Id = 2, Text = "‘Where is the country?" }, new Question { Id = 3, Text = "Where is the postcode?" } };

        static void Main()
        {
        }
        public async Task<InfoDto> GetInfo()
        {
            InfoDto  info = new InfoDto
            {
                 Questions = questions,
            };
            if (info == null) { throw new Exception("Info not found!"); }
            return  info;
        }
    }
}
