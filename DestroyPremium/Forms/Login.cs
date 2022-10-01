using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DestroyPremium.Properties;

namespace DestroyPremium.Forms
{
	// Token: 0x02000022 RID: 34
	public partial class Login : Form
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00007078 File Offset: 0x00005278
		public Login()
		{
			this.InitializeComponent();
			this.LockSize();
			new PanelTabControl(PanelTabType.ButtonBased, null, true, false);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000070B0 File Offset: 0x000052B0
		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.OpenOther)
			{
				Application.Exit();
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000070D0 File Offset: 0x000052D0
		private void CenterLabel(Label lbl)
		{
			lbl.Left = (base.ClientSize.Width - lbl.Width) / 2;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000070FC File Offset: 0x000052FC
		private void btnLogin_Click(object sender, EventArgs e)
		{
			new Main().Show();
		}

		// Token: 0x04000058 RID: 88
		private bool OpenOther = false;
	}
}
