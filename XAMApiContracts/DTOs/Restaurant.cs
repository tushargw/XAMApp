namespace XAMApiContracts.DTOs
{
	public class Restaurant
	{
		public long Id { get; set; }
		public string DisplayName { get; set; }
		public string Address { get; set; }
		public double PriceForTwo { get; set; }

		public long AdminId { get; set; }
	}
}
