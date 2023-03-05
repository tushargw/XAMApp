using XAMApi.Models;

namespace XAMApi.DataAccess.Interfaces
{
	public interface IRestaurantRepository
	{
		IEnumerable<Restaurant>? Get();
		Restaurant Add(Restaurant restaurant);
		Restaurant Update(Restaurant restaurant);
		void Delete(long id);
	}
}
