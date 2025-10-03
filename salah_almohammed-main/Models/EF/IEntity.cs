using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.EF
{
    public interface IEntity
    {
        public string Id { get; set; }
        public bool IsAcrive { get; set; }

    }
}
