using Service.Model;

namespace Service
{
    public class UserService : IUserService
    {
        public async Task<UserResponseModel> LoginAsync(string username, string password)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);

            if (user == null || !VerifyPassword(user.Password, password))
            {
                return null;
            }

            return new UserResponseModel
            {
                Username = user.Username
            };
        }

        void IUserService.Logout()
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserService.RegisterAsync(RegisterRequestModel model)
        {
            throw new NotImplementedException();
        }
        private bool VerifyPassword(string hashedPassword, string password)
        {
            return password == hashedPassword;
        }
    }


}
