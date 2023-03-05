using XAMApi.Models;

namespace XAMApi.DataAccess.Interfaces
{
	public interface IUserRepository
	{
		User? Get(string username, string encryptedPassword);
	}
}
