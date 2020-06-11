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
	public partial class FoodItem : UserControl
	{
		public Food Food { get; private set; }
		public FoodItem(Food food)
		{
			InitializeComponent();
			this.Food = food;

		}

		private void FoodItem_Load(object sender, EventArgs e)
		{
			BackgroundImage = Food.Image;
			lblName.Text = Food.Name;
			lblPrice.Text = Food.TotalPrice.ToString();
		}

		private void FoodItem_MouseClick(object sender, MouseEventArgs e)
		{
			Console.WriteLine("Clicked");
		}
	}
}
