using AutoMapper;
using XAMApi.DataAccess;
using XAMApi.DataAccess.Interfaces;
using XAMApi.Services;
using XAMApi.Services.Interfaces;

namespace XAMApi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Auto Mapper Configurations
			var mapperConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new AutoMapperProfiles());
			});
			IMapper mapper = mapperConfig.CreateMapper();
			builder.Services.AddSingleton(mapper);

			// Add services to the container.
			builder.Services.AddSingleton<ILoginService, LoginService>();
			builder.Services.AddSingleton<IRestaurantService, RestaurantService>();

			// Add Repositories
			builder.Services.AddSingleton<IRestaurantRepository, RestaurantRepository>();
			builder.Services.AddSingleton<IUserRepository, UserRepository>();

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			// if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}