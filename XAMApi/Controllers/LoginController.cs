using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using XAMApi.Services.Interfaces;
using XAMApiContracts.DTOs;

namespace XAMApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class LoginController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly ILoginService _loginService;

		public LoginController(IMapper mapper, ILoginService loginService)
		{
			_mapper = mapper;
			_loginService = loginService;
		}

		[HttpPost]
		public User? Login([FromBody] Login login)
		{
			var user = _loginService.GetUser(login.Username, login.Password);
			if (user == null)
				Response.StatusCode = (int)HttpStatusCode.NotFound;
			var dto = _mapper.Map<User>(user);
			return dto;
		}
	}
}