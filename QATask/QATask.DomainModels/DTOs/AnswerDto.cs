using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QATask.DomainModels.Base;
using QATask.DomainModels.Entites;

namespace QATask.DomainModels.DTOs
{
    public class AnswerDto : IDto
    {
        public string? AnswerText { get; set; }
        public Question? Question { get; set; }

    }
}
