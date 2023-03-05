using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using XAMApi.Models;

namespace XAMApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PostController : ControllerBase
	{
		private string ConnectionString = @"Data Source=SOCRATES;Initial Catalog=XamarinDB;Persist Security Info=True;User ID=AppUser;Password=appuser";

		private List<Post> list = new List<Post>();

		[HttpGet]
		public List<Post> Get()
		{
			//Ado.net Data Access 
			List<Post> list = new List<Post>();
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("Select * from Post", con);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				int id = Convert.ToInt32(dr["Id"]);
				int userId = Convert.ToInt32(dr["UserId"]);
				list.Add(new Post { Id = id, UserId = userId, Title = dr["Title"].ToString() ?? "No Title", Description = dr["Description"].ToString() ?? "No Description" });
			}
			return list;
		}

		[HttpPost]
		public int Post([FromBody] Post model)
		{
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();
			string inserSQL = "insert into Post(UserId,Title,Description)values(@UserID,@Title,@Desc)";
			SqlCommand cmd = new SqlCommand(inserSQL, con);
			cmd.CommandType = CommandType.Text;
			cmd.Parameters.AddWithValue("@UserID", model.UserId);
			cmd.Parameters.AddWithValue("@Title", model.Title);
			cmd.Parameters.AddWithValue("@Desc", model.Description);
			int result = cmd.ExecuteNonQuery();
			return result;
		}
	}
}