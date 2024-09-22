namespace mvc_project_camp.Models
{
	public class JwtBearerModel
	{
		public string Token { get; set; }
		public DateTime ExpiryDate { get; set; }
	}
}
