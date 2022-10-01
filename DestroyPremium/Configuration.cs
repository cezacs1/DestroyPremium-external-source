using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DestroyPremium.Forms;

// Token: 0x02000006 RID: 6
public static class Configuration
{
	// Token: 0x06000011 RID: 17 RVA: 0x00002F38 File Offset: 0x00001138
	public static void SaveConfig(this Main f, string file)
	{
		try
		{
			string contents = Configuration.GenerateConfig(f);
			File.WriteAllText(file, contents);
			MessageBox.Show("Successfully saved your settings to " + Path.GetFileName(file) + ".", "DestroyPremium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Failed to save your settings: " + ex.Message, "DestroyPremium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002FAC File Offset: 0x000011AC
	public static void LoadConfigFile(Main f, string file)
	{
		try
		{
			string data = File.ReadAllText(file);
			f.LoadConfig(data);
			MessageBox.Show("Successfully loaded settings from " + Path.GetFileName(file) + ".", "DestroyPremium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Failed to load selected settings: " + ex.Message, "DestroyPremium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00003020 File Offset: 0x00001220
	public static string GenerateConfig(Main f)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary["aimbot_enabled"] = f.cb_aimbot_enabled.Checked.ToString();
		dictionary["aimbot_thread_delay"] = f.nud_aimbot_thread_delay.Value.ToString();
		for (int i = 0; i < f.cmb_aimbot_type.Items.Count; i++)
		{
			string text = f.cmb_aimbot_type.Items[i].ToString();
			WeaponSettings weaponSettings = null;
			string text2 = text;
			string a = text2;
			if (!(a == "general"))
			{
				if (!(a == "pistols"))
				{
					if (a == "snipers")
					{
						weaponSettings = f.sniper_settings;
					}
				}
				else
				{
					weaponSettings = f.pistol_settings;
				}
			}
			else
			{
				weaponSettings = f.general_settings;
			}
			dictionary["aimbot_" + text + "_onkey"] = weaponSettings.aimbot_on_key.ToString();
			dictionary["aimbot_" + text + "_key"] = weaponSettings.aimbot_key_txt;
			dictionary["aimbot_" + text + "_bone"] = weaponSettings.aimbot_bone_index.ToString();
			dictionary["aimbot_" + text + "_fov"] = weaponSettings.aimbot_fov.ToString(Configuration.format);
			dictionary["aimbot_" + text + "_smooth"] = weaponSettings.aimbot_smooth.ToString(Configuration.format);
			dictionary["aimbot_" + text + "_rcs"] = weaponSettings.aimbot_control_recoil.ToString();
			dictionary["aimbot_" + text + "_shoot_team"] = weaponSettings.aimbot_shoot_teammates.ToString();
			dictionary["aimbot_" + text + "_enemy"] = weaponSettings.aimbot_shoot_enemies.ToString();
		}
		dictionary["trigger_enabled"] = f.cb_trigger_enabled.Checked.ToString();
		dictionary["trigger_thread_delay"] = f.nud_trigger_thread_delay.Value.ToString();
		for (int j = 0; j < f.cmb_triggerbot_type.Items.Count; j++)
		{
			string text3 = f.cmb_triggerbot_type.Items[j].ToString();
			WeaponSettings weaponSettings2 = null;
			string text4 = text3;
			string a2 = text4;
			if (!(a2 == "general"))
			{
				if (!(a2 == "pistols"))
				{
					if (a2 == "snipers")
					{
						weaponSettings2 = f.sniper_settings;
					}
				}
				else
				{
					weaponSettings2 = f.pistol_settings;
				}
			}
			else
			{
				weaponSettings2 = f.general_settings;
			}
			dictionary["trigger_" + text3 + "_onkey"] = weaponSettings2.trigger_on_key.ToString();
			dictionary["trigger_" + text3 + "_key"] = weaponSettings2.trigger_key_txt;
			dictionary["trigger_" + text3 + "_delay"] = weaponSettings2.trigger_delay.ToString();
			dictionary["trigger_" + text3 + "_overshoot"] = weaponSettings2.trigger_overshoot.ToString();
			dictionary["trigger_" + text3 + "_shoot_team"] = weaponSettings2.trigger_shoot_teammates.ToString();
			dictionary["trigger_" + text3 + "_shoot_enemy"] = weaponSettings2.trigger_shoot_enemies.ToString();
			dictionary["trigger_" + text3 + "_magnetic"] = weaponSettings2.trigger_magnetic.ToString();
			dictionary["trigger_" + text3 + "_magnetic_bone"] = weaponSettings2.trigger_magnet_bone_index.ToString();
			dictionary["trigger_" + text3 + "_magnetic_fov"] = weaponSettings2.trigger_magnet_fov.ToString(Configuration.format);
			dictionary["trigger_" + text3 + "_magnetic_smooth"] = weaponSettings2.trigger_magnet_smooth.ToString(Configuration.format);
		}
		dictionary["visuals_enabled"] = f.cb_visuals_enabled.Checked.ToString();
		dictionary["visuals_thread_delay"] = f.nud_visuals_thread_delay.Value.ToString();
		dictionary["visuals_team_enabled"] = f.cb_visuals_teammates_enabled.Checked.ToString();
		dictionary["visuals_team_visibleonly"] = f.cb_visuals_teammates_visibleonly.Checked.ToString();
		dictionary["visuals_team_healthbased"] = f.cb_visuals_teammates_healthbased.Checked.ToString();
		dictionary["visuals_team_color_r"] = f.lbl_visuals_teammates_color.BackColor.R.ToString();
		dictionary["visuals_team_color_g"] = f.lbl_visuals_teammates_color.BackColor.G.ToString();
		dictionary["visuals_team_color_b"] = f.lbl_visuals_teammates_color.BackColor.B.ToString();
		dictionary["visuals_team_alpha"] = f.nud_visuals_teammates_glowalpha.Value.ToString();
		dictionary["visuals_enemy_enabled"] = f.cb_visuals_enemies_enabled.Checked.ToString();
		dictionary["visuals_enemy_visibleonly"] = f.cb_visuals_enemies_visibleonly.Checked.ToString();
		dictionary["visuals_enemy_healthbased"] = f.cb_visuals_enemies_healthbased.Checked.ToString();
		dictionary["visuals_enemy_color_r"] = f.lbl_visuals_enemies_color.BackColor.R.ToString();
		dictionary["visuals_enemy_color_g"] = f.lbl_visuals_enemies_color.BackColor.G.ToString();
		dictionary["visuals_enemy_color_b"] = f.lbl_visuals_enemies_color.BackColor.B.ToString();
		dictionary["visuals_enemy_alpha"] = f.nud_visuals_enemies_glowalpha.Value.ToString();
		dictionary["bhop_enabled"] = f.cb_bhop_enabled.Checked.ToString();
		dictionary["bhop_key"] = f.txt_bhop_key.Text;
		dictionary["rcs_enabled"] = f.cb_rcs_enabled.Checked.ToString();
		dictionary["rcs_factor_x"] = f.nud_rcs_x_percent.Value.ToString();
		dictionary["rcs_factor_y"] = f.nud_rcs_y_percent.Value.ToString();
		dictionary["noflash_enabled"] = f.cb_noflash_enabled.Checked.ToString();
		dictionary["noflash_factor"] = f.nud_noflash_percent.Value.ToString();
		dictionary["radar_enabled"] = f.cb_radar_enabled.Checked.ToString();
		dictionary["fov_changer_enabled"] = f.cb_fov_changer.Checked.ToString();
		dictionary["fov_changer_value"] = f.nud_fov_changer.Value.ToString();
		string text5 = string.Empty;
		foreach (KeyValuePair<string, string> keyValuePair in dictionary)
		{
			text5 = string.Concat(new string[]
			{
				text5,
				keyValuePair.Key,
				"=\"",
				keyValuePair.Value,
				"\"",
				Environment.NewLine
			});
		}
		return text5;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00003814 File Offset: 0x00001A14
	public static void LoadConfig(this Main f, string data)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		Regex regex = new Regex(".*=\".*\"");
		string[] array = data.Split(new char[]
		{
			'\r',
			'\n'
		});
		foreach (string input in array)
		{
			Match match = regex.Match(input);
			if (match.Success)
			{
				string key = match.Value.Split(new char[]
				{
					'='
				}).GetValue(0).ToString();
				string value = match.Value.Split(new char[]
				{
					'"'
				}).GetValue(1).ToString();
				dictionary[key] = value;
			}
		}
		f.cb_aimbot_enabled.Checked = Convert.ToBoolean(dictionary["aimbot_enabled"]);
		f.nud_aimbot_thread_delay.Value = Convert.ToDecimal(dictionary["aimbot_thread_delay"]);
		for (int j = 0; j < f.cmb_aimbot_type.Items.Count; j++)
		{
			string text = f.cmb_aimbot_type.Items[j].ToString();
			WeaponSettings weaponSettings = null;
			string text2 = text;
			string a = text2;
			if (!(a == "general"))
			{
				if (!(a == "pistols"))
				{
					if (a == "snipers")
					{
						weaponSettings = f.sniper_settings;
					}
				}
				else
				{
					weaponSettings = f.pistol_settings;
				}
			}
			else
			{
				weaponSettings = f.general_settings;
			}
			weaponSettings.aimbot_on_key = Convert.ToBoolean(dictionary["aimbot_" + text + "_onkey"]);
			weaponSettings.aimbot_key_txt = dictionary["aimbot_" + text + "_key"];
			weaponSettings.aimbot_bone_index = Convert.ToInt32(dictionary["aimbot_" + text + "_bone"]);
			weaponSettings.aimbot_fov = Convert.ToSingle(dictionary["aimbot_" + text + "_fov"], Configuration.format);
			weaponSettings.aimbot_smooth = Convert.ToSingle(dictionary["aimbot_" + text + "_smooth"], Configuration.format);
			weaponSettings.aimbot_control_recoil = Convert.ToBoolean(dictionary["aimbot_" + text + "_rcs"]);
			weaponSettings.aimbot_shoot_teammates = Convert.ToBoolean(dictionary["aimbot_" + text + "_shoot_team"]);
			weaponSettings.aimbot_shoot_enemies = Convert.ToBoolean(dictionary["aimbot_" + text + "_enemy"]);
		}
		WeaponSettings.RefreshAimSettings(f);
		f.cb_trigger_enabled.Checked = Convert.ToBoolean(dictionary["trigger_enabled"]);
		f.nud_trigger_thread_delay.Value = Convert.ToDecimal(dictionary["trigger_thread_delay"]);
		for (int k = 0; k < f.cmb_triggerbot_type.Items.Count; k++)
		{
			string text3 = f.cmb_triggerbot_type.Items[k].ToString();
			WeaponSettings weaponSettings2 = null;
			string text4 = text3;
			string a2 = text4;
			if (!(a2 == "general"))
			{
				if (!(a2 == "pistols"))
				{
					if (a2 == "snipers")
					{
						weaponSettings2 = f.sniper_settings;
					}
				}
				else
				{
					weaponSettings2 = f.pistol_settings;
				}
			}
			else
			{
				weaponSettings2 = f.general_settings;
			}
			weaponSettings2.trigger_on_key = Convert.ToBoolean(dictionary["trigger_" + text3 + "_onkey"]);
			weaponSettings2.trigger_key_txt = dictionary["trigger_" + text3 + "_key"];
			weaponSettings2.trigger_delay = Convert.ToInt32(dictionary["trigger_" + text3 + "_delay"]);
			weaponSettings2.trigger_overshoot = Convert.ToInt32(dictionary["trigger_" + text3 + "_overshoot"]);
			weaponSettings2.trigger_shoot_teammates = Convert.ToBoolean(dictionary["trigger_" + text3 + "_shoot_team"]);
			weaponSettings2.trigger_shoot_enemies = Convert.ToBoolean(dictionary["trigger_" + text3 + "_shoot_enemy"]);
			weaponSettings2.trigger_magnetic = Convert.ToBoolean(dictionary["trigger_" + text3 + "_magnetic"]);
			weaponSettings2.trigger_magnet_bone_index = Convert.ToInt32(dictionary["trigger_" + text3 + "_magnetic_bone"]);
			weaponSettings2.trigger_magnet_fov = Convert.ToSingle(dictionary["trigger_" + text3 + "_magnetic_fov"]);
			weaponSettings2.trigger_magnet_smooth = Convert.ToSingle(dictionary["trigger_" + text3 + "_magnetic_smooth"]);
		}
		WeaponSettings.RefreshTriggerSettings(f);
		f.cb_visuals_enabled.Checked = Convert.ToBoolean(dictionary["visuals_enabled"]);
		f.nud_visuals_thread_delay.Value = Convert.ToDecimal(dictionary["visuals_thread_delay"]);
		f.cb_visuals_teammates_enabled.Checked = Convert.ToBoolean(dictionary["visuals_team_enabled"]);
		f.cb_visuals_teammates_visibleonly.Checked = Convert.ToBoolean(dictionary["visuals_team_visibleonly"]);
		f.cb_visuals_teammates_healthbased.Checked = Convert.ToBoolean(dictionary["visuals_team_healthbased"]);
		f.lbl_visuals_teammates_color.BackColor = Color.FromArgb(Convert.ToInt32(dictionary["visuals_team_color_r"]), Convert.ToInt32(dictionary["visuals_team_color_g"]), Convert.ToInt32(dictionary["visuals_team_color_b"]));
		f.nud_visuals_teammates_glowalpha.Value = Convert.ToDecimal(dictionary["visuals_team_alpha"]);
		f.cb_visuals_enemies_enabled.Checked = Convert.ToBoolean(dictionary["visuals_enemy_enabled"]);
		f.cb_visuals_enemies_visibleonly.Checked = Convert.ToBoolean(dictionary["visuals_enemy_visibleonly"]);
		f.cb_visuals_enemies_healthbased.Checked = Convert.ToBoolean(dictionary["visuals_enemy_healthbased"]);
		f.lbl_visuals_enemies_color.BackColor = Color.FromArgb(Convert.ToInt32(dictionary["visuals_enemy_color_r"]), Convert.ToInt32(dictionary["visuals_enemy_color_g"]), Convert.ToInt32(dictionary["visuals_enemy_color_b"]));
		f.nud_visuals_enemies_glowalpha.Value = Convert.ToDecimal(dictionary["visuals_enemy_alpha"]);
		f.cb_bhop_enabled.Checked = Convert.ToBoolean(dictionary["bhop_enabled"]);
		f.txt_bhop_key.Text = dictionary["bhop_key"];
		f.cb_rcs_enabled.Checked = Convert.ToBoolean(dictionary["rcs_enabled"]);
		f.nud_rcs_x_percent.Value = Convert.ToDecimal(dictionary["rcs_factor_x"]);
		f.nud_rcs_y_percent.Value = Convert.ToDecimal(dictionary["rcs_factor_y"]);
		f.cb_noflash_enabled.Checked = Convert.ToBoolean(dictionary["noflash_enabled"]);
		f.nud_noflash_percent.Value = Convert.ToDecimal(dictionary["noflash_factor"]);
		f.cb_radar_enabled.Checked = Convert.ToBoolean(dictionary["radar_enabled"]);
		f.cb_fov_changer.Checked = Convert.ToBoolean(dictionary["fov_changer_enabled"]);
		f.nud_fov_changer.Value = Convert.ToDecimal(dictionary["fov_changer_value"]);
	}

	// Token: 0x04000005 RID: 5
	private static NumberFormatInfo format = new NumberFormatInfo
	{
		NumberGroupSeparator = "."
	};
}
