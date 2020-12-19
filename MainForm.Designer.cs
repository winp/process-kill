namespace ProcessKill
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
			if ( disposing && (components != null) )
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.LKillList = new System.Windows.Forms.Label();
      this.TKillList = new System.Windows.Forms.TextBox();
      this.BKill = new System.Windows.Forms.Button();
      this.LStatus = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // LKillList
      // 
      this.LKillList.AutoSize = true;
      this.LKillList.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LKillList.Location = new System.Drawing.Point(12, 9);
      this.LKillList.Name = "LKillList";
      this.LKillList.Size = new System.Drawing.Size(206, 40);
      this.LKillList.TabIndex = 0;
      this.LKillList.Text = "Termination List";
      // 
      // TKillList
      // 
      this.TKillList.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TKillList.Location = new System.Drawing.Point(19, 52);
      this.TKillList.Multiline = true;
      this.TKillList.Name = "TKillList";
      this.TKillList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.TKillList.Size = new System.Drawing.Size(450, 240);
      this.TKillList.TabIndex = 1;
      this.TKillList.Leave += new System.EventHandler(this.TKillList_Leave);
      // 
      // BKill
      // 
      this.BKill.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BKill.Location = new System.Drawing.Point(343, 12);
      this.BKill.Name = "BKill";
      this.BKill.Size = new System.Drawing.Size(126, 34);
      this.BKill.TabIndex = 2;
      this.BKill.Text = "Kill";
      this.BKill.UseVisualStyleBackColor = true;
      this.BKill.Click += new System.EventHandler(this.BKill_Click);
      // 
      // LStatus
      // 
      this.LStatus.AutoSize = true;
      this.LStatus.Location = new System.Drawing.Point(16, 295);
      this.LStatus.Name = "LStatus";
      this.LStatus.Size = new System.Drawing.Size(40, 13);
      this.LStatus.TabIndex = 3;
      this.LStatus.Text = "Status:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(481, 317);
      this.Controls.Add(this.LStatus);
      this.Controls.Add(this.BKill);
      this.Controls.Add(this.TKillList);
      this.Controls.Add(this.LKillList);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "ProcessKill";
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LKillList;
		private System.Windows.Forms.TextBox TKillList;
		private System.Windows.Forms.Button BKill;
		private System.Windows.Forms.Label LStatus;
	}
}

