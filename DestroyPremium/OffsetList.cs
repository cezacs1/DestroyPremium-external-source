using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// Token: 0x0200001C RID: 28
internal static class OffsetList
{
	// Token: 0x06000088 RID: 136 RVA: 0x0000633C File Offset: 0x0000453C
	public static void Initialize()
	{
		OffsetList.List.Add(new Offset("m_bDormant", 0));
		OffsetList.List.Add(new Offset("m_zoomLevel", 0));
		OffsetList.List.Add(new Offset("m_iFOV", 0));
		OffsetList.List.Add(new Offset("dwLocalPlayer", 0));
		OffsetList.List.Add(new Offset("m_iHealth", 0));
		OffsetList.List.Add(new Offset("m_iTeamNum", 0));
		OffsetList.List.Add(new Offset("m_flFlashMaxAlpha", 0));
		OffsetList.List.Add(new Offset("m_iCrosshairId", 0));
		OffsetList.List.Add(new Offset("m_bIsScoped", 0));
		OffsetList.List.Add(new Offset("dwEntityList", 0));
		OffsetList.List.Add(new Offset("dwForceAttack", 0));
		OffsetList.List.Add(new Offset("dwForceJump", 0));
		OffsetList.List.Add(new Offset("dwGlowObjectManager", 0));
		OffsetList.List.Add(new Offset("m_iGlowIndex", 0));
		OffsetList.List.Add(new Offset("m_fFlags", 0));
		OffsetList.List.Add(new Offset("m_aimPunchAngle", 0));
		OffsetList.List.Add(new Offset("dwClientState", 0));
		OffsetList.List.Add(new Offset("dwClientState_ViewAngles", 0));
		OffsetList.List.Add(new Offset("m_iShotsFired", 0));
		OffsetList.List.Add(new Offset("m_dwBoneMatrix", 0));
		OffsetList.List.Add(new Offset("m_vecOrigin", 0));
		OffsetList.List.Add(new Offset("m_vecViewOffset", 0));
		OffsetList.List.Add(new Offset("m_bSpotted", 0));
		OffsetList.List.Add(new Offset("m_hActiveWeapon", 0));
		OffsetList.List.Add(new Offset("m_iItemDefinitionIndex", 0));
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00006558 File Offset: 0x00004758
	public static void RefreshOffsets(this ListBox listBox)
	{
		listBox.Items.Clear();
		foreach (Offset offset in OffsetList.List)
		{
			listBox.Items.Add(offset.GetName() + ": 0x" + offset.GetValue().ToString("X"));
		}
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000065E0 File Offset: 0x000047E0
	public static string ReplaceOffsets(string source)
	{
		source = source.ReplaceComment("offset_Dormant", "0x" + OffsetList.List[0].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_ZoomLevel", "0x" + OffsetList.List[1].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_FOV", "0x" + OffsetList.List[2].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_LocalPlayer", "0x" + OffsetList.List[3].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_Health", "0x" + OffsetList.List[4].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_Team", "0x" + OffsetList.List[5].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_FlashMaxAlpha", "0x" + OffsetList.List[6].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_CrosshairID", "0x" + OffsetList.List[7].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_IsScoped", "0x" + OffsetList.List[8].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_EntityList", "0x" + OffsetList.List[9].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_ForceAttack", "0x" + OffsetList.List[10].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_ForceJump", "0x" + OffsetList.List[11].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_GlowObject", "0x" + OffsetList.List[12].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_GlowIndex", "0x" + OffsetList.List[13].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_Flags", "0x" + OffsetList.List[14].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_AimPunch", "0x" + OffsetList.List[15].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_ClientState", "0x" + OffsetList.List[16].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_ViewAngles", "0x" + OffsetList.List[17].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_ShotsFired", "0x" + OffsetList.List[18].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_BoneMatrix", "0x" + OffsetList.List[19].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_VectorOrigin", "0x" + OffsetList.List[20].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_VectorView", "0x" + OffsetList.List[21].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_Spotted", "0x" + OffsetList.List[22].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_ActiveWeapon", "0x" + OffsetList.List[23].GetValue().ToString("X"));
		source = source.ReplaceComment("offset_ItemDefinitionIndex", "0x" + OffsetList.List[24].GetValue().ToString("X"));
		return source;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00006B14 File Offset: 0x00004D14
	public static void ScrapeOffsets()
	{
		string data = string.Empty;
		int num = 0;
		try
		{
			using (WebClient webClient = new WebClient())
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				data = webClient.DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.cs");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString(), null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		OffsetList.ParseOffsets(OffsetList.List, data, ref num);
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00006B90 File Offset: 0x00004D90
	public static void ParseOffsets(List<Offset> offsets, string data, ref int valid)
	{
		foreach (Offset offset in OffsetList.List)
		{
			Regex regex = new Regex("public const Int32 " + offset.GetName() + " = 0x.*?;");
			Match match = regex.Match(data);
			if (match.Success)
			{
				string value = match.Value.Split(new char[]
				{
					'='
				}).GetValue(1).ToString().Replace(" ", "").Replace(";", "");
				int value2 = Convert.ToInt32(value, 16);
				valid++;
				offset.SetValue(value2);
			}
		}
	}

	// Token: 0x0400004A RID: 74
	public static List<Offset> List = new List<Offset>();
}
