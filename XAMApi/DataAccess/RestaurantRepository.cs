using XAMApi.DataAccess.Interfaces;
using XAMApi.Models;

namespace XAMApi.DataAccess
{
	public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
	{
		public RestaurantRepository(IConfiguration configuration) : base(configuration)
		{
		}

		public Restaurant Add(Restaurant restaurant)
		{
			var insertSQL = "INSERT INTO [dbo].[Restaurants] ([DisplayName] ,[Address] ,[PriceForTwo], [CreatedBy], [ModifiedBy]) VALUES (@Displayname, @Address, @PriceForTwo, @CreatedBy, @ModifiedBy)";
			var parameters = new Dictionary<string, object>() { { "@Displayname", restaurant.DisplayName }, { "@Address", restaurant.Address }, { "@PriceForTwo", restaurant.PriceForTwo }, { "@CreatedBy", restaurant.CreatedBy }, { "@ModifiedBy", restaurant.ModifiedBy } };
			var rowCountAffected = Add(insertSQL, parameters);
			if (rowCountAffected != 1)
				throw new InvalidOperationException($"One record was not inserted - {restaurant}");

			var hotel = Get(restaurant);
			return hotel;
		}

		private Restaurant Get(Restaurant restaurant)
		{
			var restaurants = Get();

			var hotel = restaurants?.FirstOrDefault(r => r.Id == restaurant.Id || (r.DisplayName == restaurant.DisplayName && r.Address == restaurant.Address));
			if (hotel == null)
				throw new InvalidOperationException($"Inserted record could not be retrieved = {restaurant}");
			return hotel;
		}

		public IEnumerable<Restaurant>? Get()
		{
			//Ado.net Data Access 
			var restaurants = GetDataReader("Select [Id], [DisplayName], [Address], [PriceForTwo], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [IsDeleted] from Restaurants where [IsDeleted] = 0 order by [DisplayName]");

			if (restaurants == null)
				return null;

			return restaurants;
		}

		public Restaurant Update(Restaurant restaurant)
		{
			var updateSQL = "Update [dbo].[Restaurants] set [DisplayName] = @Displayname, [Address] = @Address, [PriceForTwo] = @PriceForTwo, [ModifiedAt] = GetUTCDate(), [ModifiedBy] = @ModifiedBy where Id = @Id";
			var parameters = new Dictionary<string, object>() { { "@Displayname", restaurant.DisplayName }, { "@Address", restaurant.Address }, { "@PriceForTwo", restaurant.PriceForTwo }, { "@ModifiedBy", restaurant.ModifiedBy }, { "@Id", restaurant.Id } };
			var rowCountAffected = Add(updateSQL, parameters);
			if (rowCountAffected == 0)
				throw new InvalidOperationException($"No record was updated");

			var hotel = Get(restaurant);
			return hotel;
		}

		public void Delete(long id)
		{
			var deleteSQL = "Delete from [dbo].[Restaurants] where Id = @Id";
			var parameters = new Dictionary<string, object>() { { "@Id", id } };
			var rowCountAffected = Add(deleteSQL, parameters);
			if (rowCountAffected == 0)
				throw new InvalidOperationException($"No record was deleted.");
		}

		public Restaurant? Get(long id)
		{
			var restaurants = Get();
			var restaurant = restaurants?.FirstOrDefault(r => r.Id == id);
			return restaurant;
		}
	}
}
