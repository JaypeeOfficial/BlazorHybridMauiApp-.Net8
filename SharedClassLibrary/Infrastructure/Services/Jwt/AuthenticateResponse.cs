using SharedClassLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClassLibrary.Infrastructure.Services.Jwt;
public class AuthenticateResponse
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;


    public AuthenticateResponse(User user, string token)
    {
        Id = user.Id;
        FullName = user.FullName;
        Email = user.Email;
        Password = user.Password;
        Token = token;
    }

}
