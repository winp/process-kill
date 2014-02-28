namespace sw_Terminate
{
	partial class MainWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
			this.TerminationListLabel = new System.Windows.Forms.Label();
			this.TerminationListText = new System.Windows.Forms.TextBox();
			this.TerminateButton = new System.Windows.Forms.Button();
			this.StatusLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TerminationListLabel
			// 
			this.TerminationListLabel.AutoSize = true;
			this.TerminationListLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TerminationListLabel.Location = new System.Drawing.Point(12, 9);
			this.TerminationListLabel.Name = "TerminationListLabel";
			this.TerminationListLabel.Size = new System.Drawing.Size(206, 40);
			this.TerminationListLabel.TabIndex = 0;
			this.TerminationListLabel.Text = "Termination List";
			// 
			// TerminationListText
			// 
			this.TerminationListText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TerminationListText.Location = new System.Drawing.Point(19, 52);
			this.TerminationListText.Multiline = true;
			this.TerminationListText.Name = "TerminationListText";
			this.TerminationListText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TerminationListText.Size = new System.Drawing.Size(450, 240);
			this.TerminationListText.TabIndex = 1;
			this.TerminationListText.Leave += new System.EventHandler(this.TerminationListText_Leave);
			// 
			// TerminateButton
			// 
			this.TerminateButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TerminateButton.Location = new System.Drawing.Point(343, 12);
			this.TerminateButton.Name = "TerminateButton";
			this.TerminateButton.Size = new System.Drawing.Size(126, 34);
			this.TerminateButton.TabIndex = 2;
			this.TerminateButton.Text = "Terminate";
			this.TerminateButton.UseVisualStyleBackColor = true;
			this.TerminateButton.Click += new System.EventHandler(this.TerminateButton_Click);
			// 
			// StatusLabel
			// 
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.Location = new System.Drawing.Point(16, 295);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(40, 13);
			this.StatusLabel.TabIndex = 3;
			this.StatusLabel.Text = "Status:";
			// 
			// MainWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 317);
			this.Controls.Add(this.StatusLabel);
			this.Controls.Add(this.TerminateButton);
			this.Controls.Add(this.TerminationListText);
			this.Controls.Add(this.TerminationListLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWin";
			this.Text = "Process Terimate";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TerminationListLabel;
		private System.Windows.Forms.TextBox TerminationListText;
		private System.Windows.Forms.Button TerminateButton;
		private System.Windows.Forms.Label StatusLabel;
	}
}

