using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using XAMApi.Services.Interfaces;
using XAMApiContracts.DTOs;

namespace XAMApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RestaurantsController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IRestaurantService _restaurantService;

		public RestaurantsController(IMapper mapper, IRestaurantService restaurantService)
		{
			_mapper = mapper;
			_restaurantService = restaurantService;
		}

		[HttpGet]
		public IEnumerable<Restaurant> Get()
		{
			var hotels = _restaurantService.Get()?.ToList();
			if (hotels == null)
				Response.StatusCode = (int)HttpStatusCode.NoContent;
			var restaurants = _mapper.Map<IEnumerable<Restaurant>>(hotels);
			return restaurants;
		}

		[HttpPost]
		public Restaurant Add(Restaurant restaurant)
		{
			if (restaurant.Id != 0)
				throw new InvalidDataException("Id in this object should be 0.");

			var hotel = _mapper.Map<XAMApi.Models.Restaurant>(restaurant);
			hotel = _restaurantService.Add(hotel);
			Response.StatusCode = (int)HttpStatusCode.Created;
			restaurant = _mapper.Map<Restaurant>(hotel);
			return restaurant;
		}

		[HttpPut]
		public Restaurant Update(Restaurant restaurant)
		{
			if (restaurant.Id == 0)
				throw new InvalidDataException("Id in this object should not be 0.");

			var hotel = _mapper.Map<XAMApi.Models.Restaurant>(restaurant);
			hotel = _restaurantService.Update(hotel);
			restaurant = _mapper.Map<Restaurant>(hotel);
			return restaurant;
		}


		[HttpDelete("{id:long}")]
		public void Delete(long id)
		{
			if (id == 0)
				throw new InvalidDataException("Id is required.");

			_restaurantService.Delete(id);
		}
	}
}
