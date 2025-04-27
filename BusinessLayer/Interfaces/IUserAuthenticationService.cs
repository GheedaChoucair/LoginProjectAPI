using BusinessLayer.DTOs;
using BusinessLayer.UIModels;
using DataAccessLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IUserAuthenticationService
    {
        Task<AuthenticationResponseModel> AuthenticateLogin(LoginModel model);
        Task<AuthenticationResponseModel> CreateLoginResponse(User user);
    }
}
