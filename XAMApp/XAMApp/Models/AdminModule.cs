using System;
using System.Collections.Generic;
using System.Text;
using XAMApp.AdminModule.Models;

namespace XAMApp.AdminModule.Models
{
	public class Entity
	{
		public Entity()
		{
			CreatedAt = ModifiedAt = DateTime.UtcNow;
		}

		public string DisplayName { get; set; }

		[PrimaryKey]
		public long Id { get; set; }

		public DateTime ModifiedAt { get; set; }
		public long ModifiedBy { get; set; }
		public DateTime CreatedAt { get; set; }
		public long CreatedBy { get; set; }
		public bool IsDeleted { get; set; }

		public override string ToString() => DisplayName;
	}

	public class User : Entity
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string UserName { get; set; }
		public string Address { get; set; }
		public bool IsAdmin { get; set; }
	}

	public class Restaurant : Entity
	{
		public string Address { get; set; }
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

	public class DishCategory: Entity
	{
		public long MenuId { get; set; }
	}

	public class Dish: Entity
	{
		public long DishCategoryId { get; set; }
		public string Description { get; set; }
	}
}

namespace XAMApp.AdminModule.Services
{
	public interface IEntityManagement<T>
	{
		T Create(T entity);
		IEnumerable<T> Read();
		bool Update(T entity);
		bool Delete(T entity);
	}

	public class UserManagement : IEntityManagement<User> { }

	public class RestaurantManagement : IEntityManagement<Restaurant> { }

	public class DiscountManagement : IEntityManagement<Discount> { }

	public class MenuManagement : IEntityManagement<Menu>, IEntityManagement<DishCategory>, IEntityManagement<Dish>
	{ }
}