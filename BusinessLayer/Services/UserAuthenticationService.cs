using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using BusinessLayer.UIModels;
using DataAccessLayer.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BusinessLayer.Services
{
    public class UserAuthenticationService : BaseService, IUserAuthenticationService
    {
        private readonly IConfiguration _configuration;
        public UserAuthenticationService(IConfiguration configuration, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _configuration = configuration;
        }
        public async Task<AuthenticationResponseModel> AuthenticateLogin(LoginModel model)
        {
            User user = await _unitOfWork.Users.GetUserByUsernameAsync(model.Username);

            // if credentials are not valid
            if (user == null || BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash) == false)
                return AuthenticationResponseModel.Failure("Incorrect username or password.");


            // if credentials are valid then generate a JWT token.
            return await CreateLoginResponse(user);
        }
        public async Task<AuthenticationResponseModel> CreateLoginResponse(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:SecretKey"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Username),
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return AuthenticationResponseModel.Success(tokenString);
        }
    }
}
