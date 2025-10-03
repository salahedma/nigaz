using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Models.Model
{
    public class User:IdentityUser
    {
        public List<Catigory> userCatigories { get; set; } = new List<Catigory>();
        public List<Seats> seats { get; set; } = new List<Seats>();
    }
}
