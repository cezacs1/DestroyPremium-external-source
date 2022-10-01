using System;
using System.Windows.Forms;

// Token: 0x02000016 RID: 22
public class PanelTab
{
	// Token: 0x0600006C RID: 108 RVA: 0x00005DF0 File Offset: 0x00003FF0
	public PanelTab(Panel pnlButton, Label lblButton, Panel pnlBox)
	{
		this.pnlButton = pnlButton;
		this.lblButton = lblButton;
		this.pnlBox = pnlBox;
		this.btnOriginalWidth = pnlButton.Size.Width;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00005E2C File Offset: 0x0000402C
	public void UpdateHover()
	{
		this.isHovered = this.pnlButton.ClientRectangle.Contains(this.pnlButton.PointToClient(Control.MousePosition));
		if (this.isHovered != this.old_isHovered)
		{
			this.pnlButton.Refresh();
		}
		this.old_isHovered = this.isHovered;
	}

	// Token: 0x04000037 RID: 55
	public Panel pnlButton;

	// Token: 0x04000038 RID: 56
	public Label lblButton;

	// Token: 0x04000039 RID: 57
	public Panel pnlBox;

	// Token: 0x0400003A RID: 58
	public int btnOriginalWidth;

	// Token: 0x0400003B RID: 59
	public bool isHovered;

	// Token: 0x0400003C RID: 60
	private bool old_isHovered;
}
