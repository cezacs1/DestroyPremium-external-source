using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000017 RID: 23
public static class FormMethod
{
	// Token: 0x0600006E RID: 110
	[DllImport("user32.dll")]
	public static extern long ShowCaret(IntPtr hwnd);

	// Token: 0x0600006F RID: 111
	[DllImport("user32.dll")]
	public static extern long HideCaret(IntPtr hwnd);

	// Token: 0x06000070 RID: 112 RVA: 0x00005E8C File Offset: 0x0000408C
	public static void OpenFile(this OpenFileDialog ofd, TextBox txt, string filter)
	{
		ofd.Filter = filter;
		if (ofd.ShowDialog() == DialogResult.OK)
		{
			txt.Text = ofd.FileName;
		}
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00005E8C File Offset: 0x0000408C
	public static void SaveFile(this SaveFileDialog sfd, TextBox txt, string filter)
	{
		sfd.Filter = filter;
		if (sfd.ShowDialog() == DialogResult.OK)
		{
			txt.Text = sfd.FileName;
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00005EB8 File Offset: 0x000040B8
	public static void LockSize(this Form form)
	{
		Size size = form.Size;
		form.MinimumSize = size;
		form.MaximumSize = size;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00005EDC File Offset: 0x000040DC
	public static void UnlockSize(this Form form)
	{
		Size size = new Size(0, 0);
		form.MinimumSize = size;
		form.MaximumSize = size;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00005F00 File Offset: 0x00004100
	public static void ChangeSize(this Form form, int w, int h)
	{
		form.UnlockSize();
		Size size = new Size(w, h);
		form.MinimumSize = size;
		form.MaximumSize = size;
		form.LockSize();
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00005F30 File Offset: 0x00004130
	public static void CenterAlign(this Form f, Label l)
	{
		l.SizeChanged += delegate(object sender, EventArgs e)
		{
			l.Left = (f.ClientSize.Width - l.Size.Width) / 2;
		};
	}

	public static void AppendText(this RichTextBox box, string text, Color color)
	{
		box.SelectionStart = box.TextLength;
		box.SelectionLength = 0;
		box.SelectionColor = color;
		box.AppendText(text);
		box.SelectionColor = box.ForeColor;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00006018 File Offset: 0x00004218
	public static void Log(this RichTextBox box, string text, Color color)
	{
		string str = DateTime.Now.ToString("h:mm:ss tt");
		box.AppendText(" [" + str + "]: ", Color.FromArgb(51, 153, 255));
		box.AppendText(text + Environment.NewLine, color);
		box.SelectionStart = box.Text.Length;
		box.ScrollToCaret();
		FormMethod.HideCaret(box.Handle);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x0000223D File Offset: 0x0000043D
	public static void Log(this RichTextBox box, string text)
	{
		box.Log(text, Color.White);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00006094 File Offset: 0x00004294
	public static void DrawComboBoxCentered(object sender, DrawItemEventArgs e)
	{
		ComboBox comboBox = (ComboBox)sender;
		if (comboBox != null)
		{
			e.DrawBackground();
			if (e.Index >= 0)
			{
				StringFormat stringFormat = new StringFormat();
				stringFormat.LineAlignment = StringAlignment.Center;
				stringFormat.Alignment = StringAlignment.Center;
				Brush brush = new SolidBrush(comboBox.ForeColor);
				if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
				{
					brush = SystemBrushes.HighlightText;
				}
				e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), comboBox.Font, brush, e.Bounds, stringFormat);
			}
		}
	}

	// Token: 0x0600007B RID: 123 RVA: 0x0000612C File Offset: 0x0000432C
	public static void UseColorDialog(this Label lbl, ColorDialog cd)
	{
		cd.Color = lbl.BackColor;
		if (cd.ShowDialog() == DialogResult.OK)
		{
			lbl.BackColor = cd.Color;
		}
	}

}
