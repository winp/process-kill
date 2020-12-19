using System;
using System.Windows.Forms;
using System.Diagnostics;
using ProcessKill.Properties;


namespace ProcessKill {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
      TKillList.Text = (string) Settings.Default["TerminationList"];
      if (TKillList.Text != "") BKill.Select();
      LStatus.Text = "Settings loaded";
    }

    private void TKillList_Leave(object sender, EventArgs e) {
      Settings.Default["TerminationList"] = TKillList.Text;
      Settings.Default.Save();
      LStatus.Text = "Settings saved";
    }

    private void BKill_Click(object sender, EventArgs e) {
      int n = 0;
      string[] names = TKillList.Text.Split(new string[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
      if (names == null) return;
      foreach (string name in names) {
        if (name == "this") this.Close();
        n += TryKillByName(name.Replace(".exe", ""));
      }
      LStatus.Text = n + " process(es) terminated";
    }

    private int TryKillByName(string name) {
      int n = 0;
      Process[] processes = Process.GetProcessesByName(name);
      if (processes == null) return n;
      foreach (Process p in processes) {
        try { p.Kill(); n++; }
        catch (Exception) {}
      }
      return n;
    }
  }
}
