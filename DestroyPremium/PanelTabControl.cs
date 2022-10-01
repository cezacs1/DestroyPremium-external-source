using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000012 RID: 18
public class PanelTabControl
{

	public event EventHandler TabChanged;

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000057 RID: 87 RVA: 0x0000218E File Offset: 0x0000038E
	// (set) Token: 0x06000058 RID: 88 RVA: 0x00002196 File Offset: 0x00000396
	public PanelTab SelectedTab { get; set; }

	// Token: 0x06000059 RID: 89 RVA: 0x0000579C File Offset: 0x0000399C
	public PanelTabControl(PanelTabType type, PanelTabControl parent = null, bool hoverCheck = true, bool drawBorders = true)
	{
		this.type = type;
		this.parent = parent;
		this.drawBorders = drawBorders;
		if (hoverCheck)
		{
			this.hoverChecker = new Timer();
			this.hoverChecker.Tick += delegate(object sender, EventArgs e)
			{
				this.UpdateHovers();
			};
			this.hoverChecker.Interval = 10;
			this.hoverChecker.Start();
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00005810 File Offset: 0x00003A10
	protected virtual void OnTabChanged(EventArgs e)
	{
		if (this.TabChanged != null)
		{
			this.TabChanged(this, e);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00005838 File Offset: 0x00003A38
	public void AddTab(PanelTab tab)
	{
		this.tabs.Add(tab);
		tab.lblButton.Click += delegate(object sender, EventArgs e)
		{
			this.SelectTab(tab, e);
		};
		tab.pnlButton.Click += delegate(object sender, EventArgs e)
		{
			this.SelectTab(tab, e);
		};
		tab.pnlButton.Paint += delegate(object sender, PaintEventArgs e)
		{
			this.DrawButton(sender, e);
		};
		tab.pnlBox.Paint += delegate(object sender, PaintEventArgs e)
		{
			this.DrawPanel(sender, e);
		};
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000058DC File Offset: 0x00003ADC
	public void DrawPanel(object sender, PaintEventArgs e)
	{
		Panel p = (Panel)sender;
		if (p != null)
		{
			PanelTab panelTab = this.tabs.Find((PanelTab tab) => tab.pnlBox == p);
			int y = panelTab.pnlBox.Location.Y;
			Pen pen = new Pen(PanelTabControl.Color_PanelBackground);
			if (this.drawBorders)
			{
				ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, PanelTabControl.Color_PanelOutline, ButtonBorderStyle.Solid);
			}
			if (this.type == PanelTabType.VerticalAttatched)
			{
				e.Graphics.DrawLine(pen, 0, panelTab.pnlButton.Top - (y - 1), 0, panelTab.pnlButton.Bottom - (y + 2));
			}
			else if (this.type == PanelTabType.ButtonBased && (!this.parent.IsNull() && this.parent.type == PanelTabType.VerticalAttatched))
			{
				e.Graphics.DrawLine(pen, 1, 0, panelTab.pnlBox.Width - 1, 0);
				PanelTab selectedTab = this.parent.SelectedTab;
				int y2 = selectedTab.pnlBox.Location.Y;
				int y3 = selectedTab.pnlButton.Top - (y2 - 1) - y;
				int y4 = selectedTab.pnlButton.Bottom - (y2 + 2) - y;
				e.Graphics.DrawLine(pen, 0, y3, 0, y4);
			}
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00005A4C File Offset: 0x00003C4C
	public void DrawButton(object sender, PaintEventArgs e)
	{
		Panel p = (Panel)sender;
		if (p != null)
		{
			PanelTab panelTab = this.tabs.Find((PanelTab tab) => tab.pnlButton == p);
			if (panelTab == this.SelectedTab)
			{
				ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, PanelTabControl.Color_ButtonOutlineSelected, ButtonBorderStyle.Solid);
			}
			else if (panelTab.isHovered)
			{
				p.BackColor = PanelTabControl.Color_ButtonBackgroundHovered;
				panelTab.lblButton.ForeColor = PanelTabControl.Color_ButtonTextHovered;
				ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, PanelTabControl.Color_ButtonOutlineSelected, ButtonBorderStyle.Solid);
			}
			else
			{
				p.BackColor = PanelTabControl.Color_ButtonBackground;
				panelTab.lblButton.ForeColor = PanelTabControl.Color_ButtonText;
				ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, PanelTabControl.Color_ButtonOutline, ButtonBorderStyle.Solid);
			}
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00005B40 File Offset: 0x00003D40
	public void SelectTab(PanelTab tab, EventArgs e = null)
	{
		if ((e == null || ((MouseEventArgs)e).Button == MouseButtons.Left) && this.SelectedTab != tab)
		{
			foreach (PanelTab panelTab in this.tabs)
			{
				if (panelTab != tab)
				{
					panelTab.pnlBox.Visible = false;
					if (this.type == PanelTabType.VerticalAttatched)
					{
						panelTab.pnlButton.Size = new Size(tab.btnOriginalWidth, panelTab.pnlButton.Size.Height);
					}
					panelTab.pnlButton.BackColor = PanelTabControl.Color_ButtonBackground;
					panelTab.lblButton.ForeColor = PanelTabControl.Color_ButtonText;
				}
			}
			tab.pnlBox.Visible = true;
			if (this.type == PanelTabType.VerticalAttatched)
			{
				tab.pnlButton.Size = new Size(tab.btnOriginalWidth + (tab.pnlBox.Location.X - tab.pnlButton.Right) + 1, tab.pnlButton.Size.Height);
			}
			tab.pnlButton.BackColor = PanelTabControl.Color_PanelBackground;
			tab.lblButton.ForeColor = PanelTabControl.Color_ButtonTextSelected;
			tab.pnlButton.BringToFront();
			tab.pnlBox.BringToFront();
			this.SelectedTab = tab;
			this.OnTabChanged(new EventArgs());
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x0000219F File Offset: 0x0000039F
	public void SelectTab(int tab)
	{
		this.SelectTab(this.tabs[tab], null);
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00005CD0 File Offset: 0x00003ED0
	public void UpdateHovers()
	{
		foreach (PanelTab panelTab in this.tabs)
		{
			try
			{
				panelTab.UpdateHover();
			}
			catch (ObjectDisposedException)
			{
				this.hoverChecker.Stop();
				break;
			}
		}
	}

	// Token: 0x04000023 RID: 35
	private static Color Color_PanelOutline = Color.FromArgb(100, 100, 100);

	// Token: 0x04000024 RID: 36
	private static Color Color_PanelBackground = Color.FromArgb(40, 40, 40);

	// Token: 0x04000025 RID: 37
	private static Color Color_ButtonBackgroundHovered = Color.FromArgb(45, 45, 45);

	// Token: 0x04000026 RID: 38
	private static Color Color_ButtonBackground = Color.FromArgb(35, 35, 35);

	// Token: 0x04000027 RID: 39
	private static Color Color_ButtonText = Color.FromArgb(255, 255, 255);

	// Token: 0x04000028 RID: 40
	private static Color Color_ButtonTextHovered = Color.FromArgb(230, 230, 230);

	// Token: 0x04000029 RID: 41
	private static Color Color_ButtonTextSelected = Color.FromArgb(174, 0, 255);

	// Token: 0x0400002A RID: 42
	private static Color Color_ButtonOutline = Color.FromArgb(19, 19, 19);

	// Token: 0x0400002B RID: 43
	private static Color Color_ButtonOutlineSelected = PanelTabControl.Color_PanelOutline;

	// Token: 0x0400002D RID: 45
	private List<PanelTab> tabs = new List<PanelTab>();

	// Token: 0x0400002F RID: 47
	public PanelTabType type;

	// Token: 0x04000030 RID: 48
	private PanelTabControl parent;

	// Token: 0x04000031 RID: 49
	private Timer hoverChecker;

	// Token: 0x04000032 RID: 50
	private bool drawBorders;
}
