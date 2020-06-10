using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzaYemek
{
	class FoodData
	{

		private List<String> marketNames = new List<String> 
		{ 
			"Şok",
			"A101",
			"Bim",
			"Migros",
			"Kilpa"
		};
		private List<String> productNames = new List<String>
		{
			"Yumurta",
			"Tuz",
			"Sarımsak",
			"Domates",
			"Baharat",
			"Tavuk Eti",
			"Dana Eti",
			"Soğan",
			"Salça",
			"Sıvı Yağ",
			"Biber",
			"Un",
			"Yoğurt"
		};

		private List<String> foodNames = new List<string>
		{
			"Izgara sebze",
			"Fırında tavuk but",
			"Kumru",
			"Tavuklu şiş mantısı",
			"Füme somonlu kabak ruloları",
			"Kaşkarikas",
			"Bamya kızartması"
		};

		public FoodData()
		{
			GenerateMarkets();
			GenerateFoods();
		}

		private List<Market> markets;
		public List<Market> Markets
		{
			get { return markets; }
		}
		private List<Food> foods;
		public List<Food> Foods
		{
			get { return foods; }
		}

		public void GenerateMarkets()
		{
			var rand = new Random();
			markets = new List<Market>();
			foreach (var marketName in marketNames)
			{
				List<Product> tempProducts = new List<Product>();
				foreach (var productName in productNames)
				{
					tempProducts.Add(new Product(productName, Math.Round(rand.NextDouble() * 10, 2) + 5));
				}
				markets.Add(new Market(marketName, tempProducts));
			}
		}

		public void GenerateFoods()
		{
			foods = new List<Food>();
			foreach (var foodName in foodNames)
			{
				foods.Add(new Food(productNames.OrderBy(arg => Guid.NewGuid()).Take(5).ToList(), foodName));
			}
		}
		

	}
}
