using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRepository.BaseRules
{
    public class BaseEntity : IBaseEntity
    {
        public long ID { get; set; }
    }
}
