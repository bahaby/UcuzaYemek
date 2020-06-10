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
		private List<Market> markets;
		public FoodData()
		{
			generateMarkets();
		}

		public void generateMarkets()
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

		public List<Market> Markets
		{
			get { return markets; }
		}

	}
}
