using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzaYemek
{
	public class Product
	{
		public String ProductName { get; private set; }
		public String MarketName { get; private set; }
		public double Price { get; private set; }
		public Product(String productName, double price, String marketName)
		{
			this.ProductName = productName;
			this.Price = price;
			this.MarketName = marketName;
		}
		
	}
}
