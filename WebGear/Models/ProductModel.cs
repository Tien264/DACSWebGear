using System.ComponentModel.DataAnnotations;

namespace WebGear.Models
{
	public class ProductModel
	{
		[Key]
		public int Id { get; set; }
		[Required, MinLength(4, ErrorMessage = " Yêu cầu nhập tên Sảm Phẩm ")]
		public string Name { get; set; }
		
		public string Slug { get; set; }
		[Required, MinLength(4, ErrorMessage = " Yêu cầu nhập mô tả Sảm Phẩm ")]
		public string Description { get; set; }
		[Required, MinLength(4, ErrorMessage = " Yêu cầu nhập giá Sảm Phẩm ")]

		public decimal Price { get; set; }

		public int BranId { get; set; }
		public int CategoryId { get; set;}

		public CategoryModel Category { get; set; }
		public BrandModel Brand { get; set; }

		public string Image { get; set; }
	}
}
