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
	public partial class FoodDetailItem : UserControl
	{
		private Product product;
		public FoodDetailItem(Product product)
		{
			InitializeComponent();
			this.product = product;
		}

		private void FoodDetailItem_Load(object sender, EventArgs e)
		{
			labelQuantity.Text = product.Quantity.ToString();
			labelProductName.Text = product.ProductName;
			labelPrice.Text = (product.Price * product.Quantity).ToString() + " TL";
			labelMarket.Text = product.MarketName;
		}
	}
}
