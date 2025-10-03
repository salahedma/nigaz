using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models.Model
{
    public class Catigory: Entity
    {
        public string NameCatigory { get; set; }
        public int Seats { get; set; }
        public List<User> userCatigories { get; set; } = new List<User>();
        public List<Seats> seats { get; set; } = new List<Seats>();
    }
}
