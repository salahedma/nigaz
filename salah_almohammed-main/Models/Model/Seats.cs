using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;

namespace Models.Model
{
    public class Seats:Entity
    {
        public required int Index_Seats  { get; set; }
        public User? User { get; set; }
        public string UserId { get; set; }
        public Catigory? Catigory { get; set; }
        public string CatigoryId { get; set; }
    }
}
