using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace XAMApi.DataAccess
{
	public class BaseRepository<T> where T : new()
	{
		private readonly IConfiguration _configuration;
		private readonly string _connectionString;

		protected BaseRepository(IConfiguration configuration)
		{
			_configuration = configuration;
			_connectionString = _configuration.GetConnectionString("default");
		}

		protected IList<T> GetDataReader(string query)
		{
			SqlConnection con = new SqlConnection(_connectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataReader dr = cmd.ExecuteReader();
			if (!dr.HasRows)
				return null;

			List<T> list = GetListFromReader(dr);
			return list;
		}

		protected int Add(string insertSql, Dictionary<string, object> parameters)
		{
			SqlConnection con = new SqlConnection(_connectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand(insertSql, con);
			cmd.CommandType = CommandType.Text;

			foreach (var key in parameters.Keys)
			{
				cmd.Parameters.AddWithValue(key, parameters[key]);
			}
			int result = cmd.ExecuteNonQuery();
			return result;
		}

		private static List<T> GetListFromReader(SqlDataReader dr)
		{
			PropertyInfo[] propertyInfos = typeof(T).GetProperties();

			var list = new List<T>();

			while (dr.Read())
			{
				var dataClass = new T();
				for (int i = 0; i < dr.FieldCount; i++)
				{
					foreach (PropertyInfo propertyInfo in propertyInfos)
					{
						if (propertyInfo.Name == dr.GetName(i))
						{
							propertyInfo.SetValue(dataClass, Convert.ChangeType(dr.GetValue(i), dr.GetFieldType(i)), null);
							break;
						}
					}
				}
				list.Add(dataClass);
			}

			return list;
		}
	}
}
