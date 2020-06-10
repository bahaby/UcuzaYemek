using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzaYemek
{
	class Product
	{
		public String ProductName { get; private set; }
		public double Price { get; private set; }
		public Product(String productName, double price)
		{
			this.ProductName = productName;
			this.Price = price;
		}
	}
}
