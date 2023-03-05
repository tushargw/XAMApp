using Microsoft.AspNetCore.Mvc;
using System.Net;
using XAMApi.Models;
using XAMApi.Services.Interfaces;
using XAMApiContracts.DTOs;

namespace XAMApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class LoginController : Controller
	{
		private readonly ILoginService _loginService;

		public LoginController(ILoginService loginService)
		{
			_loginService = loginService;
		}

		[HttpPost]
		public User? Login([FromBody] Login login)
		{
			var user = _loginService.GetUser(login.Username, login.Password);
			if (user == null)
				Response.StatusCode = (int)HttpStatusCode.NotFound;
			return user;
		}
	}
}