namespace UcuzaYemek.Widgets
{
	partial class FoodDetail
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
			this.picBoxFood = new System.Windows.Forms.PictureBox();
			this.labelM = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picBoxFood)).BeginInit();
			this.SuspendLayout();
			// 
			// picBoxFood
			// 
			this.picBoxFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picBoxFood.Location = new System.Drawing.Point(0, 0);
			this.picBoxFood.Margin = new System.Windows.Forms.Padding(0);
			this.picBoxFood.Name = "picBoxFood";
			this.picBoxFood.Size = new System.Drawing.Size(370, 250);
			this.picBoxFood.TabIndex = 0;
			this.picBoxFood.TabStop = false;
			// 
			// labelM
			// 
			this.labelM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelM.AutoSize = true;
			this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelM.Location = new System.Drawing.Point(129, 263);
			this.labelM.Name = "labelM";
			this.labelM.Size = new System.Drawing.Size(118, 24);
			this.labelM.TabIndex = 1;
			this.labelM.Text = "Malzemeler";
			this.labelM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FoodDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelM);
			this.Controls.Add(this.picBoxFood);
			this.Name = "FoodDetail";
			this.Size = new System.Drawing.Size(370, 655);
			this.Load += new System.EventHandler(this.FoodDetail_Load);
			((System.ComponentModel.ISupportInitialize)(this.picBoxFood)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picBoxFood;
		private System.Windows.Forms.Label labelM;
	}
}
