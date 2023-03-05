namespace XAMApi.Models
{
	public class Restaurant : Entity
	{
		public string Address { get; set; }
		public double PriceForTwo { get; set; }
	}

	public class Discount
	{
		public long RestaurantId { get; set; }
		public double Percentage { get; set; }
		public DateTime FromDate { get; set; }
		public DateTime ToDate { get; set; }
		public double MinimumAmount { get; set; }
		public double MaximumAmount { get; set; }
	}

	public class Menu : Entity
	{
		public long RestaurantId { get; set; }
	}

	public class DishCategory : Entity
	{
		public long MenuId { get; set; }
	}

	public class Dish : Entity
	{
		public long DishCategoryId { get; set; }
		public string Description { get; set; }
	}

}