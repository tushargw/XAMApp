using XAMApi.Models;

namespace XAMApi.Services.Interfaces
{
	public interface ILoginService
	{
		User GetUser(string username, string password);
	}
}
