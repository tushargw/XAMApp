using XAMApi.DataAccess.Interfaces;
using XAMApi.Models;

namespace XAMApi.DataAccess
{
	public class UserRepository : BaseRepository<User>, IUserRepository
	{
		public UserRepository(IConfiguration configuration) : base(configuration)
		{
		}

		public User? Get(string username, string encryptedPassword)
		{
			//Ado.net Data Access 
			var users = GetDataReader("Select [Id],[DisplayName],[Username], Password, [Email],[Address],[IsAdmin],[CreatedAt],[CreatedBy],[ModifiedAt],[ModifiedBy],[IsDeleted] from Users where isDeleted = 0");

			// I could have used this, but thought of keeping this simple. More like LINQ
			////	SqlCommand cmd = new SqlCommand(inserSQL, con);
			////	cmd.CommandType = CommandType.Text;
			////	cmd.Parameters.AddWithValue("@UserID", model.UserId);
			////	cmd.Parameters.AddWithValue("@Title", model.Title);
			////	cmd.Parameters.AddWithValue("@Desc", model.Description);
			////	int result = cmd.ExecuteNonQuery();


			if (users == null)
				return null;

			var user = users.FirstOrDefault(u => u.Username == username && u.Password == encryptedPassword);
			if (user == null) return null;

			user.Password = string.Empty;
			return user;
		}
	}
}
