namespace UcuzaYemek.Widgets
{
	partial class FoodDetailItem
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelQuantity = new System.Windows.Forms.Label();
			this.labelX = new System.Windows.Forms.Label();
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelMarket = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelQuantity
			// 
			this.labelQuantity.AutoSize = true;
			this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQuantity.Location = new System.Drawing.Point(13, 16);
			this.labelQuantity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(19, 20);
			this.labelQuantity.TabIndex = 0;
			this.labelQuantity.Text = "3";
			// 
			// labelX
			// 
			this.labelX.AutoSize = true;
			this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelX.Location = new System.Drawing.Point(29, 16);
			this.labelX.Margin = new System.Windows.Forms.Padding(0);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(17, 20);
			this.labelX.TabIndex = 0;
			this.labelX.Text = "x";
			// 
			// labelProductName
			// 
			this.labelProductName.AutoSize = true;
			this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProductName.Location = new System.Drawing.Point(46, 16);
			this.labelProductName.Margin = new System.Windows.Forms.Padding(0);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(59, 20);
			this.labelProductName.TabIndex = 0;
			this.labelProductName.Text = "Havuç";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice.Location = new System.Drawing.Point(290, 28);
			this.labelPrice.Margin = new System.Windows.Forms.Padding(0);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(44, 16);
			this.labelPrice.TabIndex = 0;
			this.labelPrice.Text = "12.98";
			// 
			// labelMarket
			// 
			this.labelMarket.AutoSize = true;
			this.labelMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMarket.Location = new System.Drawing.Point(290, 6);
			this.labelMarket.Margin = new System.Windows.Forms.Padding(0);
			this.labelMarket.Name = "labelMarket";
			this.labelMarket.Size = new System.Drawing.Size(55, 16);
			this.labelMarket.TabIndex = 0;
			this.labelMarket.Text = "Migros";
			// 
			// FoodDetailItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.labelMarket);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelProductName);
			this.Controls.Add(this.labelX);
			this.Controls.Add(this.labelQuantity);
			this.Name = "FoodDetailItem";
			this.Size = new System.Drawing.Size(370, 48);
			this.Load += new System.EventHandler(this.FoodDetailItem_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelMarket;
	}
}
