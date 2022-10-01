using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// Token: 0x02000002 RID: 2
internal static class BoneList
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002AE8 File Offset: 0x00000CE8
	public static void Initialize()
	{
		BoneList.List.Add(new Bone("Nearest", 8));
		BoneList.List.Add(new Bone("Head", 8));
		BoneList.List.Add(new Bone("Neck", 7));
		BoneList.List.Add(new Bone("Upper Chest", 6));
		BoneList.List.Add(new Bone("Middle Chest", 5));
		BoneList.List.Add(new Bone("Lower Chest", 4));
	}


	// Token: 0x06000004 RID: 4 RVA: 0x00002BC4 File Offset: 0x00000DC4
	public static void RefreshBones(ListBox listBox)
	{
		listBox.Items.Clear();
		foreach (Bone bone in BoneList.List)
		{
			listBox.Items.Add(bone.GetName() + ": " + bone.GetValue().ToString());
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002C48 File Offset: 0x00000E48
	public static void ScrapeBones(this ListBox listBox, int mode)
	{
		if (mode >= 0)
		{
			string data = string.Empty;
			int num = 0;
			if (mode == 0)
			{
				try
				{
					using (WebClient webClient = new WebClient())
					{
						data = webClient.DownloadString("https://pastebinp.com/raw/dwt2YAe5");
					}
					goto IL_6C;
				}
				catch (Exception)
				{
				}
				MessageBox.Show("An error has occurred while downloading bone data.", "DestroyPremium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
				IL_6C:
				BoneList.ParseBones(BoneList.List, data, ref num);
				BoneList.RefreshBones(listBox);
				MessageBox.Show(num.ToString() + "/" + BoneList.List.Count.ToString() + " bones were parsed and replaced successfully.", "DestroyPremium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
		}
		MessageBox.Show("Please select a valid destination to scrape from.", "DestroyPremium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002D28 File Offset: 0x00000F28
	public static void ParseBones(List<Bone> bones, string data, ref int valid)
	{
		foreach (Bone bone in bones)
		{
			Regex regex = new Regex(bone.GetName() + "=\".*?\"");
			Match match = regex.Match(data);
			if (match.Success)
			{
				string value = match.Value.Split(new char[]
				{
					'"'
				}).GetValue(1).ToString();
				int value2 = Convert.ToInt32(value);
				valid++;
				bone.SetValue(value2);
			}
		}
	}

	public static List<Bone> List = new List<Bone>();
}
