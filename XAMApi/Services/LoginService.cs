using XAMApi.DataAccess.Interfaces;
using XAMApi.Models;
using XAMApi.Services.Interfaces;

namespace XAMApi.Services
{
	internal class LoginService : ILoginService
	{
		private readonly IUserRepository _userRepository;

		public LoginService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public User GetUser(string username, string password)
		{
			var encryptedPassword = GetEncryptedPassword(password);
			var user = _userRepository.Get(username, encryptedPassword);
			return user;
		}

		private string GetEncryptedPassword(string password)
		{
			// some simple encryption
			return password + password;
		}
	}
}
