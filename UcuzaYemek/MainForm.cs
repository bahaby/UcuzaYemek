using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcuzaYemek
{
	public partial class MainForm : Form
	{
		FoodData fd = new FoodData();
		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Console.WriteLine(fd.Foods[0].Products[0]);
		}
	}
}
