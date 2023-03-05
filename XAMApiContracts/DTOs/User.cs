using System.ComponentModel.DataAnnotations;

namespace XAMApiContracts.DTOs
{
	public class User
	{
		public long Id { get; set; }
		public string DisplayName { get; set; }
		public DateTime ModifiedAt { get; set; }
		public long ModifiedBy { get; set; }
		public DateTime CreatedAt { get; set; }
		public long CreatedBy { get; set; }
		public bool IsDeleted { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public bool IsAdmin { get; set; }
	}
}
