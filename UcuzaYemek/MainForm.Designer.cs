namespace UcuzaYemek
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelFoodList = new System.Windows.Forms.Panel();
			this.panelFoodDetail = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panelFoodList
			// 
			this.panelFoodList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panelFoodList.AutoScroll = true;
			this.panelFoodList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panelFoodList.Location = new System.Drawing.Point(12, 12);
			this.panelFoodList.Margin = new System.Windows.Forms.Padding(0);
			this.panelFoodList.Name = "panelFoodList";
			this.panelFoodList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panelFoodList.Size = new System.Drawing.Size(400, 634);
			this.panelFoodList.TabIndex = 0;
			// 
			// panelFoodDetail
			// 
			this.panelFoodDetail.Location = new System.Drawing.Point(418, 12);
			this.panelFoodDetail.Name = "panelFoodDetail";
			this.panelFoodDetail.Size = new System.Drawing.Size(376, 634);
			this.panelFoodDetail.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 658);
			this.Controls.Add(this.panelFoodDetail);
			this.Controls.Add(this.panelFoodList);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelFoodList;
		private System.Windows.Forms.Panel panelFoodDetail;
	}
}

