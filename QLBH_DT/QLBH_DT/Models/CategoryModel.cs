using QLBH_DT.Data;

namespace QLBH_DT.Models
{
	public class CategoryModel
	{
		public int CategoryId { get; set; }

		public string CategoryName { get; set; } = null!;

		public virtual ICollection<Product> Products { get; set; } = new List<Product>();
	}
}
