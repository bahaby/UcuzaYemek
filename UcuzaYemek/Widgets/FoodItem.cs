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
		private Panel panel;
		public FoodItem(Food food, Panel panel)
		{
			InitializeComponent();
			this.Food = food;
			this.panel = panel;
		}

		private void FoodItem_Load(object sender, EventArgs e)
		{
			BackgroundImage = Food.Image;
			lblName.Text = Food.Name;
			lblPrice.Text = Food.TotalPrice.ToString();
		}

		private void FoodItem_MouseClick(object sender, MouseEventArgs e)
		{
			panel.Controls.Clear();
			panel.Controls.Add(new FoodDetail(Food));
		}
	}
}
