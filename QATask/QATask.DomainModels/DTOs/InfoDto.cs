using System;
using QATask.DomainModels.Base;
using QATask.DomainModels.Entites;

namespace QATask.DomainModels.DTOs
{
    public class InfoDto : IDto
    {
        public object Html { get; set; } = "<div><span>Ivan Ivanov</span><div>Country:<span>UA</span></div><div>Postcode:<b>65000</b></div></div>";

        public Question[] Questions { get; set; }= { new Question { Id = 1, Text = "Where is fullname?" }, new Question { Id = 2, Text = "‘Where is the country?" }, new Question { Id = 3, Text = "Where is the postcode?" } };

    }
}
