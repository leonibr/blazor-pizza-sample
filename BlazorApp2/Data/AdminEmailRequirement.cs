using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class AdminEmailRequirement : IAuthorizationRequirement
    {
        public string SufixoEmail { get; }

        public AdminEmailRequirement(string email)
        {
            SufixoEmail = email;
        }
    }

    public class AdminEmailAuthHandler : AuthorizationHandler<AdminEmailRequirement>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context, 
            AdminEmailRequirement requirement)
        {
            if (context.User.Identity.IsAuthenticated
                && context.User.Identity.Name.EndsWith(requirement.SufixoEmail)
                )
            {
                
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
