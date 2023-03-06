using XAMApi.DataAccess.Interfaces;
using XAMApi.Models;
using XAMApi.Services.Interfaces;

namespace XAMApi.Services
{
	public class RestaurantService: IRestaurantService
	{
		private readonly IRestaurantRepository _restaurantRepository;

		public RestaurantService(IRestaurantRepository restaurantRepository)
		{
			_restaurantRepository = restaurantRepository;
		}

		public Restaurant Add(Restaurant restaurant)
		{
			return _restaurantRepository.Add(restaurant);
		}

		public void Delete(long id)
		{
			_restaurantRepository.Delete(id);
		}

		public IEnumerable<Restaurant>? Get()
		{
			return _restaurantRepository.Get();
		}

		public Restaurant? Get(long id)
		{
			return _restaurantRepository.Get(id);
		}

		public Restaurant Update(Restaurant restaurant)
		{
			return _restaurantRepository.Update(restaurant);
		}
	}
}
