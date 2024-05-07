using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore
{
    public class MyBook : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
    }
}
