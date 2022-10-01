using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DestroyPremium.Properties;

namespace DestroyPremium.Forms
{
	// Token: 0x02000024 RID: 36
	public partial class Main : Form
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00007768 File Offset: 0x00005968
		public Main()
		{
			this.InitializeComponent();
			this.LockSize();
			//this.txtLog.MouseDown += this.<.ctor>b__0_0;
			this.pTabMain = new PanelTabControl(PanelTabType.VerticalAttatched, null, true, true);
			this.pTabMain.AddTab(new PanelTab(this.tabAimbot, this.lblAimbot, this.pnlAimbot));
			this.pTabMain.AddTab(new PanelTab(this.tabTriggerbot, this.lblTriggerbot, this.pnlTriggerbot));
			this.pTabMain.AddTab(new PanelTab(this.tabVisuals, this.lblVisuals, this.pnlVisuals));
			this.pTabMain.AddTab(new PanelTab(this.tabMisc, this.lblMisc, this.pnlMisc));
			this.pTabMain.AddTab(new PanelTab(this.tabCompile, this.lblCompile, this.pnlCompile));
			this.pTabMain.SelectTab(0);
			this.pTabValues = new PanelTabControl(PanelTabType.VerticalAttatched, null, true, true);
			this.pTabMisc = new PanelTabControl(PanelTabType.ButtonBased, this.pTabMain, true, true);
			this.pTabMisc.AddTab(new PanelTab(this.tabFeatures, this.lblFeatures, this.pnlFeatures));
			this.pTabMisc.AddTab(new PanelTab(this.tabConfig, this.lblConfig, this.pnlConfig));
			this.pTabMisc.SelectTab(0);
			this.cmb_aimbot_bone.SelectedIndex = 0;
			this.cmb_aimbot_type.SelectedIndex = 0;
			this.cmb_triggerbot_type.SelectedIndex = 0;
			this.cmb_trigger_magnet_bone.SelectedIndex = 0;
			this.txt_build_path.Text = "exelentless.exe";
			OffsetList.Initialize();
			OffsetList.ScrapeOffsets();
			BoneList.Initialize();
			KeyManagement.InitializeKeys();
			Control.CheckForIllegalCrossThreadCalls = false;
			this.lblLoggedIn.Text = Program.currentUser;
			this.lblLoggedIn.Left = this.lblPreLoggedIn.Right;
			this.general_settings = new WeaponSettings(this);
			this.pistol_settings = new WeaponSettings(this);
			this.sniper_settings = new WeaponSettings(this);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000079D4 File Offset: 0x00005BD4
		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.OpenOther)
			{
				Application.Exit();
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000022F0 File Offset: 0x000004F0
		private void ComboDrawItem(object sender, DrawItemEventArgs e)
		{
			FormMethod.DrawComboBoxCentered(sender, e);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000022F9 File Offset: 0x000004F9
		private void btnCompile_Click(object sender, EventArgs e)
		{
			this.CompileCheat();
		}

		private void cb_visuals_teammates_color_Click(object sender, EventArgs e)
		{
			this.lbl_visuals_teammates_color.UseColorDialog(this.cd);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002350 File Offset: 0x00000550
		private void cb_visuals_enemies_color_Click(object sender, EventArgs e)
		{
			this.lbl_visuals_enemies_color.UseColorDialog(this.cd);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002363 File Offset: 0x00000563
		private void cb_trigger_magnetic_CheckedChanged(object sender, EventArgs e)
		{
			this.lblCustomizeTriggerMagnetic.Visible = this.cb_trigger_magnetic.Checked;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000237B File Offset: 0x0000057B
		private void lblCustomizeTriggerMagnetic_Click(object sender, EventArgs e)
		{
			this.pnlTrigger2.BringToFront();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002388 File Offset: 0x00000588
		private void lblBackToTrigger_Click(object sender, EventArgs e)
		{
			this.pnlTrigger1.BringToFront();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002395 File Offset: 0x00000595
		private void btnSelectConfigFile_Click(object sender, EventArgs e)
		{
			this.sfd.SaveFile(this.txtConfigFileSave, "DestroyPremium Files (*.dpm)|*.dpm");
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000023AD File Offset: 0x000005AD
		private void btnSaveConfigFile_Click(object sender, EventArgs e)
		{
			this.SaveConfig(this.txtConfigFileSave.Text);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000023C0 File Offset: 0x000005C0
		private void btnSelectConfigFileLoad_Click(object sender, EventArgs e)
		{
			this.ofd.OpenFile(this.txtConfigFileLoad, "DestroyPremium Files (*.dpm)|*.dpm");
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000023D8 File Offset: 0x000005D8
		private void btnLoadConfigFile_Click(object sender, EventArgs e)
		{
			Configuration.LoadConfigFile(this, this.txtConfigFileLoad.Text);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000023EB File Offset: 0x000005EB
		private void btnLogout_Click(object sender, EventArgs e)
		{
			Process.Start(Program.path);
			Application.Exit();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000079F4 File Offset: 0x00005BF4
		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			this.sfd.Filter = "Executable File (*.exe)|*.exe";
			if (this.sfd.ShowDialog() == DialogResult.OK)
			{
				this.txt_build_path.Text = this.sfd.FileName;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00007A38 File Offset: 0x00005C38
		private void CompileCheat()
		{
			if (this.BuildInProgress)
			{
				this.txtLog.Log("Başka bir derleme işlemi devam etmekte.", Color.Yellow);
			}
			else
			{
				this.BuildInProgress = true;
				string memory = Resources.Memory;
				string offsets = Resources.Offsets;
				string program = Resources.Program;
				string aimbotMath = Resources.AimbotMath;
				string sourceFinal = memory + offsets + program;
				this.txtLog.Log("İşlem başlatıldı!");
				bool flag;
				if (flag = (this.cb_aimbot_enabled.Checked || this.general_settings.trigger_magnetic || this.pistol_settings.trigger_magnetic || this.sniper_settings.trigger_magnetic))
				{
					sourceFinal += aimbotMath;
				}
				for (int i = 0; i < this.cmb_aimbot_type.Items.Count; i++)
				{
					string text = this.cmb_aimbot_type.Items[i].ToString();
					WeaponSettings weaponSettings = null;
					string text2 = text;
					string a = text2;
					if (!(a == "general"))
					{
						if (!(a == "pistols"))
						{
							if (a == "snipers")
							{
								weaponSettings = this.sniper_settings;
							}
						}
						else
						{
							weaponSettings = this.pistol_settings;
						}
					}
					else
					{
						weaponSettings = this.general_settings;
					}
					if (weaponSettings.aimbot_on_key)
					{
						sourceFinal = sourceFinal.ReplaceComment("setting_aimbot_" + text + "_key", KeyManagement.KeyFromText(weaponSettings.aimbot_key_txt).ToString());
					}
					else
					{
						sourceFinal = sourceFinal.ReplaceComment("setting_aimbot_" + text + "_key", "-1");
					}
					sourceFinal = sourceFinal.ReplaceComment("setting_aimbot_" + text + "_bone", 8.ToString());
					sourceFinal = sourceFinal.ReplaceComment("setting_aimbot_" + text + "_fov", weaponSettings.aimbot_fov.ToString(this.format) + "f");
					sourceFinal = sourceFinal.ReplaceComment("setting_aimbot_" + text + "_smooth", weaponSettings.aimbot_smooth.ToString(this.format) + "f");
					sourceFinal = sourceFinal.ReplaceComment("setting_aimbot_" + text + "_rcs", weaponSettings.aimbot_control_recoil.ToString().ToLower());
					sourceFinal = sourceFinal.ReplaceComment("setting_aimbot_" + text + "_enemy", weaponSettings.aimbot_shoot_enemies.ToString().ToLower());
					sourceFinal = sourceFinal.ReplaceComment("setting_aimbot_" + text + "_team", weaponSettings.aimbot_shoot_teammates.ToString().ToLower());
				}
				sourceFinal = sourceFinal.ReplaceComment("setting_aimbot_thread_delay", Convert.ToInt32(this.nud_aimbot_thread_delay.Value).ToString());
				if (!this.cb_aimbot_enabled.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_aimbot");
				}
				if (!flag)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_aimbot/magnet");
				}
				for (int j = 0; j < this.cmb_triggerbot_type.Items.Count; j++)
				{
					string text3 = this.cmb_triggerbot_type.Items[j].ToString();
					WeaponSettings weaponSettings2 = null;
					string text4 = text3;
					string a2 = text4;
					if (!(a2 == "general"))
					{
						if (!(a2 == "pistols"))
						{
							if (a2 == "snipers")
							{
								weaponSettings2 = this.sniper_settings;
							}
						}
						else
						{
							weaponSettings2 = this.pistol_settings;
						}
					}
					else
					{
						weaponSettings2 = this.general_settings;
					}
					if (weaponSettings2.trigger_on_key)
					{
						sourceFinal = sourceFinal.ReplaceComment("setting_triggerbot_" + text3 + "_key", KeyManagement.KeyFromText(weaponSettings2.trigger_key_txt).ToString());
					}
					else
					{
						sourceFinal = sourceFinal.ReplaceComment("setting_triggerbot_" + text3 + "_key", "-1");
					}
					sourceFinal = sourceFinal.ReplaceComment("setting_triggerbot_" + text3 + "_magnetbone", 8.ToString());
					sourceFinal = sourceFinal.ReplaceComment("setting_triggerbot_" + text3 + "_magnetfov", weaponSettings2.trigger_magnet_fov.ToString(this.format) + "f");
					sourceFinal = sourceFinal.ReplaceComment("setting_triggerbot_" + text3 + "_magnetsmooth", weaponSettings2.trigger_magnet_smooth.ToString(this.format) + "f");
					sourceFinal = sourceFinal.ReplaceComment("setting_triggerbot_" + text3 + "_magnetic", weaponSettings2.trigger_magnetic.ToString().ToLower());
					sourceFinal = sourceFinal.ReplaceComment("setting_triggerbot_" + text3 + "_enemy", weaponSettings2.trigger_shoot_enemies.ToString().ToLower());
					sourceFinal = sourceFinal.ReplaceComment("setting_triggerbot_" + text3 + "_team", weaponSettings2.trigger_shoot_teammates.ToString().ToLower());
					sourceFinal = sourceFinal.ReplaceComment("setting_triggerbot_" + text3 + "_delay", weaponSettings2.trigger_delay.ToString());
					sourceFinal = sourceFinal.ReplaceComment("setting_triggerbot_" + text3 + "_overshoot", weaponSettings2.trigger_overshoot.ToString());
				}
				if (this.nud_trigger_thread_delay.Value > 0m)
				{
					sourceFinal = sourceFinal.ReplaceComment("setting_trigger_thread_delay", Convert.ToInt32(this.nud_trigger_thread_delay.Value).ToString());
				}
				if (!this.cb_trigger_enabled.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_triggerbot");
				}
				sourceFinal = sourceFinal.ReplaceComment("setting_visuals_teammate_color_r", this.lbl_visuals_teammates_color.BackColor.R.ToString());
				sourceFinal = sourceFinal.ReplaceComment("setting_visuals_teammate_color_g", this.lbl_visuals_teammates_color.BackColor.G.ToString());
				sourceFinal = sourceFinal.ReplaceComment("setting_visuals_teammate_color_b", this.lbl_visuals_teammates_color.BackColor.B.ToString());
				sourceFinal = sourceFinal.ReplaceComment("setting_visuals_teammate_alpha", Convert.ToInt32(this.nud_visuals_teammates_glowalpha.Value).ToString());
				if (!this.cb_visuals_teammates_visibleonly.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_visuals_teammate_chams_enabled");
				}
				else
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_visuals_teammate_chams_disabled");
				}
				if (!this.cb_visuals_teammates_healthbased.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_teammate_healthbased");
				}
				if (!this.cb_visuals_teammates_enabled.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_visuals_teammate");
				}
				sourceFinal = sourceFinal.ReplaceComment("setting_visuals_enemy_color_r", this.lbl_visuals_enemies_color.BackColor.R.ToString());
				sourceFinal = sourceFinal.ReplaceComment("setting_visuals_enemy_color_g", this.lbl_visuals_enemies_color.BackColor.G.ToString());
				sourceFinal = sourceFinal.ReplaceComment("setting_visuals_enemy_color_b", this.lbl_visuals_enemies_color.BackColor.B.ToString());
				sourceFinal = sourceFinal.ReplaceComment("setting_visuals_enemy_alpha", Convert.ToInt32(this.nud_visuals_enemies_glowalpha.Value).ToString());
				if (!this.cb_visuals_enemies_visibleonly.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_visuals_enemy_chams_enabled");
				}
				else
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_visuals_enemy_chams_disabled");
				}
				if (!this.cb_visuals_enemies_healthbased.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_enemy_healthbased");
				}
				if (!this.cb_visuals_enemies_enabled.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_visuals_enemy");
				}
				if (!this.cb_visuals_teammates_healthbased.Checked && !this.cb_visuals_enemies_healthbased.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_healthbased");
				}
				if (this.nud_visuals_thread_delay.Value > 0m)
				{
					sourceFinal = sourceFinal.ReplaceComment("setting_visuals_thread_delay", Convert.ToInt32(this.nud_visuals_thread_delay.Value).ToString());
				}
				else
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_visuals_thread_delay");
				}
				if (!this.cb_visuals_enabled.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_visuals");
				}
				sourceFinal = sourceFinal.ReplaceComment("setting_bhop_key", KeyManagement.KeyFromText(this.txt_bhop_key.Text).ToString());
				if (!this.cb_bhop_enabled.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_bhop");
				}
				sourceFinal = sourceFinal.ReplaceComment("setting_noflash_percent", this.nud_noflash_percent.Value.ToString());
				if (!this.cb_noflash_enabled.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_noflash");
				}
				sourceFinal = sourceFinal.ReplaceComment("setting_rcs_scale_x", ((float)this.nud_rcs_x_percent.Value * 0.02f).ToString(this.format) + "f");
				sourceFinal = sourceFinal.ReplaceComment("setting_rcs_scale_y", ((float)this.nud_rcs_y_percent.Value * 0.02f).ToString(this.format) + "f");
				if (!this.cb_rcs_enabled.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_rcs");
				}
				if (!this.cb_radar_enabled.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_radar");
				}
				sourceFinal = sourceFinal.ReplaceComment("setting_custom_fov", this.nud_fov_changer.Value.ToString());
				if (!this.cb_fov_changer.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "feature_fov_changer");
				}
				sourceFinal = sourceFinal.ReplaceComment("setting_skinchanger_bat", Randomize.String(8, 16) + ".bat");
				if (!this.cb_aimbot_enabled.Checked && !this.cb_trigger_enabled.Checked)
				{
					sourceFinal = General.EraseComment(sourceFinal, "weapon_type_lists");
				}
				this.txtLog.Log("Seçilen ayarlar işlendi.");
				//sourceFinal = Randomize.RandomizeOrders(sourceFinal);
				this.txtLog.Log("Kod şifrelendi.");
				sourceFinal = Randomize.Code("rnd", sourceFinal);
				sourceFinal = OffsetList.ReplaceOffsets(sourceFinal);
				this.txtLog.Log("Program değişkenleri şifrelendi.");
				sourceFinal = Randomize.ReplaceNumbers(sourceFinal);
				sourceFinal = sourceFinal.Junkify();
				sourceFinal = sourceFinal.ReplaceComment("setting_window_title", Randomize.String(16, 32));
				new Thread(delegate()
				{
					List<string> list = Compiler.Compile(sourceFinal, this.txt_build_path.Text);
					if (list.Count == 0)
					{
						this.txtLog.Log("Hile derlendi: " + Path.GetFileName(this.txt_build_path.Text));
						DialogResult dialogResult = MessageBox.Show("Hile başarıyla derlendi.\nÇalıştırılsın mı?", "DestroyPremium", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
						try
						{
							if (dialogResult == DialogResult.Yes)
							{
								Process.Start(new ProcessStartInfo(this.txt_build_path.Text)
								{
									UseShellExecute = true,
									Verb = "runas"
								});
							}
							return;
						}
						catch (Exception)
						{
							MessageBox.Show("Hile çalıştırılırken bir sorun oluştu.\nLütfen tekrar deneyiniz.", "DestroyPremium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
					}
					this.txtLog.Log("Bir sorun oluştu! " + list.Count.ToString() + " hata bulundu.", Color.Yellow);
					foreach (string text5 in list)
					{
						this.txtLog.Log(text5, Color.Red);
					}
					MessageBox.Show("Build failed!\nWe found some errors :(", "DestroyPremium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}).Start();
				this.BuildInProgress = false;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000023FD File Offset: 0x000005FD


		// Token: 0x04000062 RID: 98
		private PanelTabControl pTabMain;

		// Token: 0x04000063 RID: 99
		private PanelTabControl pTabValues;

		// Token: 0x04000064 RID: 100
		private PanelTabControl pTabMisc;

		// Token: 0x04000065 RID: 101
		private NumberFormatInfo format = new NumberFormatInfo
		{
			NumberGroupSeparator = "."
		};

		// Token: 0x04000066 RID: 102
		public WeaponSettings general_settings;

		// Token: 0x04000067 RID: 103
		public WeaponSettings pistol_settings;

		// Token: 0x04000068 RID: 104
		public WeaponSettings sniper_settings;

		// Token: 0x04000069 RID: 105
		public bool RefreshingTriggerSettings = false;

		// Token: 0x0400006A RID: 106
		public bool RefreshingAimSettings = false;

		// Token: 0x0400006B RID: 107
		private bool OpenOther = false;

		// Token: 0x0400006C RID: 108
		private bool BuildInProgress = false;

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void txt_build_path_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
