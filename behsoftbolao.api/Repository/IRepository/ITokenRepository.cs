using BehSoft.DataAccess.Repository.IRepository;
using Core.Models;
using Microsoft.AspNetCore.Identity;

namespace BehSoft.DataAccess.Repository.IRepository;

public interface ITokenRepository
{
    string CreateJwtToken( IdentityUser user, List<string> roles);
}
