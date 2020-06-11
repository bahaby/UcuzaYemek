namespace UcuzaYemek.Widgets
{
	partial class FoodItem
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
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.BackColor = System.Drawing.SystemColors.Info;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblPrice.ForeColor = System.Drawing.Color.Brown;
			this.lblPrice.Location = new System.Drawing.Point(48, 70);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(0, 24);
			this.lblPrice.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.AllowDrop = true;
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.SystemColors.Info;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblName.ForeColor = System.Drawing.Color.Black;
			this.lblName.Location = new System.Drawing.Point(46, 21);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(0, 25);
			this.lblName.TabIndex = 0;
			// 
			// FoodItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.lblName);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "FoodItem";
			this.Size = new System.Drawing.Size(380, 116);
			this.Load += new System.EventHandler(this.FoodItem_Load);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FoodItem_MouseClick);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblName;
	}
}
