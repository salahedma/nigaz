using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;

namespace Models.Model
{
    public class UserCatigory:Entity
    {
        public string UserId { get; set; }
        [NotMapped]
        public User? User { get; set; }
        public string CatigoryId { get; set; }
        [NotMapped]
        public Catigory Catigory { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
