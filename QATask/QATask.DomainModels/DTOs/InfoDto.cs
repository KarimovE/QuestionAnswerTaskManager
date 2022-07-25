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
    public class InfoDto : IDto
    {
        public object html { get; set; } = "<div><span>Ivan Ivanov</span><div>Country:<span>UA</span></div><div>Postcode:<b>65000</b></div></div>";

        public ICollection<Question>? Questions { get; set; }

    }
}
