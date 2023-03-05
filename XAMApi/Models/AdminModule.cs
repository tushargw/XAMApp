using System;
using System.Collections.Generic;
using System.Text;
using XAMApp.AdminModule.Models;

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