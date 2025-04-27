namespace BusinessLayer.UIModels
{
    public class AuthenticationResponseModel
    {
        public bool IsSuccess { get; set; }
        public string Token { get; set; }
        public string ErrorMessage { get; set; }

        public static AuthenticationResponseModel Success(string token)
        {
            return new AuthenticationResponseModel { IsSuccess = true, Token = token };
        }

        public static AuthenticationResponseModel Failure(string errorMessage)
        {
            return new AuthenticationResponseModel { IsSuccess = false, ErrorMessage = errorMessage };
        }
    }
}
