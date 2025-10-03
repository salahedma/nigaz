using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.EF
{
    public class Entity: IEntity
    {
        public string Id { get; set; }
        public bool IsAcrive { get; set; }
        public Entity()
        {
            Id= Guid.NewGuid().ToString();
            IsAcrive = true;
        }
    }
}
