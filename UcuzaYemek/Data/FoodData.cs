using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzaYemek
{
	public class FoodData
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
					tempProducts.Add(new Product(productName, Math.Round(rand.NextDouble() * 10, 2) + 5, marketName));
				}
				markets.Add(new Market(marketName, tempProducts));
			}
		}

		public void GenerateFoods()
		{
			foods = new List<Food>
			{
				new Food(productNames.OrderBy(arg => Guid.NewGuid()).Take(5).ToList(), "Bademli Şehriyeli Pirinç Pilavi", Properties.Resources.bademli_sehriyeli_pirinc_pilavi, this),
				new Food(productNames.OrderBy(arg => Guid.NewGuid()).Take(5).ToList(), "Bütün Tavuk", Properties.Resources.butun_tavuk, this),
				new Food(productNames.OrderBy(arg => Guid.NewGuid()).Take(5).ToList(), "Eflani Tavuk Tiridi", Properties.Resources.eflani_tavuk_tiridi, this),
				new Food(productNames.OrderBy(arg => Guid.NewGuid()).Take(5).ToList(), "Güllaçtan Lazanya", Properties.Resources.gullactan_lazanya, this),
				new Food(productNames.OrderBy(arg => Guid.NewGuid()).Take(5).ToList(), "Limonlu Dil Balığı", Properties.Resources.limonlu_dil_baligi, this),
				new Food(productNames.OrderBy(arg => Guid.NewGuid()).Take(5).ToList(), "Mor Pilav", Properties.Resources.mor_pilav, this),
				new Food(productNames.OrderBy(arg => Guid.NewGuid()).Take(5).ToList(), "Sebzeli İdeal Bulgur Pilavı", Properties.Resources.sebzeli_ideal_bulgur_pilavi, this),
				new Food(productNames.OrderBy(arg => Guid.NewGuid()).Take(5).ToList(), "Yayla Çorbası", Properties.Resources.yayla_corbasi, this),
				new Food(productNames.OrderBy(arg => Guid.NewGuid()).Take(5).ToList(), "Zeytin Sezimotu Salatası", Properties.Resources.zeytin_sezimotu_salatasi, this),
			};
		}
		

	}
}
