using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Models.Model;

namespace Authintications.Auth
{
    public class PoliceOwnerHandler : AuthorizationHandler<PoliceOwnerRequirement>
    {
        private readonly UserManager<User> user;

        public PoliceOwnerHandler(
            UserManager<User> user
            )
        {
            this.user = user;
        }

        protected override Task HandleRequirementAsync
            (AuthorizationHandlerContext context,
            PoliceOwnerRequirement requirement)
        {
            throw new NotImplementedException();
        }
    }
}
