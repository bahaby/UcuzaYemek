using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcuzaYemek.Widgets
{
	public partial class FoodDetail : UserControl
	{
		private Food food;
		public FoodDetail(Food food)
		{
			InitializeComponent();
			this.food = food;
		}

		private void FoodDetail_Load(object sender, EventArgs e)
		{
			this.picBoxFood.Image = food.Image;
			Point position = new Point(0, 300);
			foreach (var product in food.GetProduct)
			{
				FoodDetailItem foodDetailItem = new FoodDetailItem(product);
				foodDetailItem.Location = position;
				this.Controls.Add(foodDetailItem);
				position.Y += 60;
			}
		}
	}
}
