using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzaYemek
{
	public class Market
	{
		public List<Product> Products { get; private set; }
		public String Name { get; private set; }
		public Market(String name, List<Product> products)
		{
			this.Products = products;
			this.Name = name;
		}

		public Product GetProduct(String product)
		{
			foreach (var prod in Products)
			{
				if (prod.ProductName == product) return prod;
			}
			return null;
		}
	}
}
