using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcuzaYemek.Widgets;

namespace UcuzaYemek
{
	public partial class MainForm : Form
	{
		private FoodData foodData = new FoodData();
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Point position = new Point(0, 0);
			foreach (var food in foodData.Foods)
			{
				FoodItem foodItem = new FoodItem(food);
				foodItem.Location = position;
				position.Y += 125;
				panelFoodList.Controls.Add(foodItem);
			}
			Console.WriteLine(panelFoodList.Controls.Count);
		}
	}
}
