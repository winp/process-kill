using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using sw_Terminate.Properties;

namespace sw_Terminate
{
	public partial class MainWin : Form
	{
		public MainWin()
		{
			InitializeComponent();
			TerminationListText.Text = (string) Settings.Default["TerminationList"];
			if ( TerminationListText.Text != "" ) TerminateButton.Select();
			StatusLabel.Text = "Settings loaded";
		}

		private void TerminationListText_Leave(object sender, EventArgs e)
		{
			Settings.Default["TerminationList"] = TerminationListText.Text;
			Settings.Default.Save();
			StatusLabel.Text = "Settings saved";
		}
		private void TerminateButton_Click(object sender, EventArgs e)
		{
			int count = 0;
			string[] process_names = TerminationListText.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
			if ( process_names == null ) return;
			foreach ( string process_name in process_names )
			{
				if ( process_name == "this" ) this.Close();
				Process[] processes = Process.GetProcessesByName(process_name.Replace(".exe", ""));
				if ( processes == null ) continue;
				foreach ( Process process in processes )
				{
					try
					{
						process.Kill();
						count++;
					}
					catch ( Exception ) { }
				}
			}
			StatusLabel.Text = count + " process(es) terminated";
		}
	}
}
