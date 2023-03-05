using System.ComponentModel.DataAnnotations;

namespace XAMApi.Models
{
	public class Entity
	{
		public Entity()
		{
			CreatedAt = ModifiedAt = DateTime.UtcNow;
			DisplayName = string.Empty;
		}

		public string DisplayName { get; set; }

		[Key]
		public long Id { get; set; }

		public DateTime ModifiedAt { get; set; }
		public long ModifiedBy { get; set; }
		public DateTime CreatedAt { get; set; }
		public long CreatedBy { get; set; }
		public bool IsDeleted { get; set; }

		public override string ToString() => DisplayName;
	}
}
