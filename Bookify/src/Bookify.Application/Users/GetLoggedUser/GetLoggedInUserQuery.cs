using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Users.GetLoggedUser
{
    public sealed record GetLoggedInUserQuery : IQuery<UserResponse>;
}
