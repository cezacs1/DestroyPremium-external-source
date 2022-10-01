using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x0200000C RID: 12
public static class KeyManagement
{
	// Token: 0x0600002C RID: 44
	[DllImport("user32.dll")]
	private static extern short GetAsyncKeyState(int vKey);

	// Token: 0x0600002D RID: 45 RVA: 0x000047C4 File Offset: 0x000029C4
	public static void KeyThread(ref TextBox txt)
	{
		while (KeyManagement.GetPressedKey() != -1)
		{
			Thread.Sleep(1);
		}
		int num;
		for (num = -1; num == -1; num = KeyManagement.GetPressedKey())
		{
		}
		txt.Text = KeyManagement.GetKeyString(num);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00004804 File Offset: 0x00002A04
	private static int GetPressedKey()
	{
		for (int i = 1; i < 255; i++)
		{
			if (KeyManagement.GetAsyncKeyState(i) != 0)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00004838 File Offset: 0x00002A38
	public static int KeyFromText(string text)
	{
		int result;
		try
		{
			string[] array = text.Split(new char[]
			{
				'[',
				']'
			});
			result = Convert.ToInt32(array[1], 16);
		}
		catch (Exception)
		{
			result = -1;
		}
		return result;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00004880 File Offset: 0x00002A80
	private static string GetKeyString(int key)
	{
		string text = string.Empty;
		string text2 = "0x" + key.ToString("X").ToUpper();
		foreach (Tuple<int, string> tuple in KeyManagement.KeyList)
		{
			if (tuple.Item1 == key)
			{
				text = tuple.Item2;
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			text = text + " [" + text2 + "]";
		}
		else
		{
			text = "Unknown [" + text2 + "]";
		}
		return text;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00004938 File Offset: 0x00002B38
	public static void InitializeKeys()
	{
		KeyManagement.KeyList.Add(new Tuple<int, string>(32, "Space"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(8, "BackSpace"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(18, "Alt"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(164, "Left Alt"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(165, "Right Alt"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(1, "Mouse 1"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(2, "Mouse 2"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(4, "Middle Mouse"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(5, "Mouse 4"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(6, "Mouse 5"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(16, "Shift"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(160, "Left Shift"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(161, "Right Shift"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(65, "A"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(66, "B"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(67, "C"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(68, "D"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(69, "E"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(70, "F"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(71, "G"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(72, "H"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(73, "I"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(74, "J"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(75, "K"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(76, "L"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(77, "M"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(78, "N"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(79, "O"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(80, "P"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(81, "Q"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(82, "R"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(83, "S"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(84, "T"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(85, "U"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(86, "V"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(87, "W"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(88, "X"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(89, "Y"));
		KeyManagement.KeyList.Add(new Tuple<int, string>(90, "Z"));
	}

	// Token: 0x04000008 RID: 8
	private static List<Tuple<int, string>> KeyList = new List<Tuple<int, string>>();
}
