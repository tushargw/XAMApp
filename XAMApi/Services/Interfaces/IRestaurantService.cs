using XAMApi.Models;

namespace XAMApi.Services.Interfaces
{
	public interface IRestaurantService
	{
		IEnumerable<Restaurant> Get();
		Restaurant Add(Restaurant restaurant);
		Restaurant Update(Restaurant hotel);
		void Delete(long id);
	}
}
