using Microsoft.EntityFrameworkCore;
using WebGear.Models;

namespace WebGear.Repository
{
	public class SeedData
	{
		public static void SeedingData(DataContext _context)
		{
			_context.Database.Migrate();
			if( !_context.Products.Any() )
			{
				CategoryModel macbook = new CategoryModel {Name="macbook", Slug="macbook" , Description= "macbook is the best ", Status=1 };
				CategoryModel pc = new CategoryModel { Name = "pc", Slug = "pc", Description = "pc nothing ", Status = 1 };
				BrandModel apple = new BrandModel { Name = "Apple", Slug = "Apple", Description = "Apple is the best ", Status = 1 };
				BrandModel samsung = new BrandModel { Name = "Samsung", Slug = "Samsung", Description = "Samsung nothing ", Status = 1 };
				_context.Products.AddRange(
					new ProductModel { Name = "macbook", Slug = "macbook", Description = "macbook is gud", Image = "1.jpg", Category = macbook, Brand = apple, Price = 1222 },
					new ProductModel { Name = "pc", Slug = "pc", Description = "pc is gud", Image = "1.jpg", Category = pc, Brand = samsung, Price = 1232 }
				);
				_context.SaveChanges();
			}
		}

	}
}
