using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace Bookify.Infrastructure.Authorization
{
    internal sealed class PermissionAuthorizationPolicyProvider : DefaultAuthorizationPolicyProvider
    {
        private readonly AuthorizationOptions _authorizationOpions;
        public PermissionAuthorizationPolicyProvider(IOptions<AuthorizationOptions> options) : base(options)
        {
            _authorizationOpions = options.Value;
        }

        public override async Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
        {
            var policy = await base.GetPolicyAsync(policyName);

            if (policy is not null)
            {
                return policy;
            }

            var permissionPolicy = new AuthorizationPolicyBuilder()
                .AddRequirements(new PermissionRequirement(policyName))
                .Build();

            _authorizationOpions.AddPolicy(policyName, permissionPolicy);

            return permissionPolicy;
        }
    }
}
