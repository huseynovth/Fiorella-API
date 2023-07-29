using Fiorella.Aplication.Abstraction.Services;
using Fiorella.Aplication.DTOs.AuthDTOs;
using Fiorella.Domain.Entities;
using Fiorella.Persistence.Exceptions;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace Fiorella.Persistence.Inplementations.Services;

public class AuthService : IAuthServic
    
    
{
    private readonly UserManager<AppUser> _userManager;

    public AuthService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task Register(Aplication.Abstraction.Services.RegisterDto registerDto)
    {
        AppUser user = new()
        {
            Fullname = registerDto.Fullname,
            UserName = registerDto.Username,

            Email = registerDto.email,
            IsActive = true
        };
        IdentityResult identityResult =  await _userManager.CreateAsync(user, registerDto.password);
        if (!identityResult.Succeeded)
        {
            StringBuilder error = new();
            foreach (var identityError in identityResult.Errors)
            {
                error.AppendLine(identityError.Description);
            }
            throw new UserRegistrationException(error.ToString());
        }
    }

    public Task register(Aplication.Abstraction.Services.RegisterDto registerDto)
    {
        throw new NotImplementedException();
    }
}
