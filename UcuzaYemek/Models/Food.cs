using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzaYemek
{
	public class Food
	{
		public List<String> Products { get; private set; }
		public String Name { get; private set; }
		public Image Image { get; private set; }
		public FoodData FoodData { get; private set; }
		public Food(List<String> products, String name, Image image, FoodData foodData)
		{
			this.Products = products;
			this.Name = name;
			this.Image = image;
			this.FoodData = foodData;
		}

		public List<Product> GetProduct
		{
			get 
			{
				List<Product> temp = new List<Product>();
				foreach (var product in Products)
				{
					Product cheapProduct = null;
					double bestPrice = 100000000;
					foreach (var market in FoodData.Markets)
					{
						if (market.GetProduct(product).Price < bestPrice)
						{
							cheapProduct = market.GetProduct(product);
							bestPrice = market.GetProduct(product).Price;
						}
					}
					temp.Add(cheapProduct);
				}
				return temp;
			}
		}
		public Double TotalPrice
		{
			get
			{
				Double total = 0;
				foreach (var product in GetProduct)
				{
					total += product.Price;
				}
				return total;
			}
		}
	}
}
