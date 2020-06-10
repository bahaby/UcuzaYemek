using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzaYemek
{
	class Food
	{
		public List<String> Products { get; private set; }
		public String Name { get; private set; }
		public Food(List<String> products, String name)
		{
			this.Products = products;
			this.Name = name;
		}
	}
}
