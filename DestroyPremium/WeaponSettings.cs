using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DestroyPremium.Forms;

// Token: 0x0200000E RID: 14
public class WeaponSettings
{
	// Token: 0x06000036 RID: 54 RVA: 0x0000507C File Offset: 0x0000327C
	public WeaponSettings(Main parent)
	{
		this.index = WeaponSettings.indexTracker;
		WeaponSettings.indexTracker++;
		parent.cmb_triggerbot_type.SelectedIndexChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.RefreshTriggerSettings(parent);
		};
		parent.cb_trigger_onkey.CheckedChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateTriggerSettings(parent);
		};
		parent.txt_trigger_key.TextChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateTriggerSettings(parent);
		};
		parent.nud_trigger_delay.ValueChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateTriggerSettings(parent);
		};
		parent.nud_trigger_overshoot.ValueChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateTriggerSettings(parent);
		};
		parent.cb_trigger_shoot_teammates.CheckedChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateTriggerSettings(parent);
		};
		parent.cb_trigger_shoot_enemies.CheckedChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateTriggerSettings(parent);
		};
		parent.cb_trigger_magnetic.CheckedChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateTriggerSettings(parent);
		};
		parent.cmb_trigger_magnet_bone.SelectedIndexChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateTriggerSettings(parent);
		};
		parent.nud_trigger_magnet_fov.ValueChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateTriggerSettings(parent);
		};
		parent.nud_trigger_magnet_smooth.ValueChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateTriggerSettings(parent);
		};
		parent.cmb_aimbot_type.SelectedIndexChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.RefreshAimSettings(parent);
		};
		parent.cb_aimbot_onkey.CheckedChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateAimSettings(parent);
		};
		parent.txt_aimbot_key.TextChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateAimSettings(parent);
		};
		parent.cmb_aimbot_bone.SelectedIndexChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateAimSettings(parent);
		};
		parent.nud_aimbot_fov.ValueChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateAimSettings(parent);
		};
		parent.nud_aimbot_smooth.ValueChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateAimSettings(parent);
		};
		parent.cb_aimbot_rcs.CheckedChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateAimSettings(parent);
		};
		parent.cb_aimbot_target_teammates.CheckedChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateAimSettings(parent);
		};
		parent.cb_aimbot_target_enemies.CheckedChanged += delegate(object sender, EventArgs e)
		{
			WeaponSettings.UpdateAimSettings(parent);
		};
		WeaponSettings.types.Add(this);
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00005384 File Offset: 0x00003584
	public static WeaponSettings Selected(ComboBox c)
	{
		return WeaponSettings.Selected(c.SelectedIndex);
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000053A0 File Offset: 0x000035A0
	public static WeaponSettings Selected(int index)
	{
		return WeaponSettings.types.Find((WeaponSettings i) => i.index == index);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x000053D4 File Offset: 0x000035D4
	public static void RefreshAimSettings(Main main)
	{
		main.RefreshingAimSettings = true;
		WeaponSettings weaponSettings = WeaponSettings.Selected(main.cmb_aimbot_type);
		main.cb_aimbot_onkey.Checked = weaponSettings.aimbot_on_key;
		main.txt_aimbot_key.Text = weaponSettings.aimbot_key_txt;
		main.cmb_aimbot_bone.SelectedIndex = weaponSettings.aimbot_bone_index;
		main.nud_aimbot_fov.Value = Convert.ToDecimal(weaponSettings.aimbot_fov);
		main.nud_aimbot_smooth.Value = Convert.ToDecimal(weaponSettings.aimbot_smooth);
		main.cb_aimbot_rcs.Checked = weaponSettings.aimbot_control_recoil;
		main.cb_aimbot_target_teammates.Checked = weaponSettings.aimbot_shoot_teammates;
		main.cb_aimbot_target_enemies.Checked = weaponSettings.aimbot_shoot_enemies;
		main.RefreshingAimSettings = false;
		main.txtDummy.Focus();
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000549C File Offset: 0x0000369C
	public static void UpdateAimSettings(Main main)
	{
		if (!main.RefreshingAimSettings)
		{
			WeaponSettings weaponSettings = WeaponSettings.Selected(main.cmb_aimbot_type);
			weaponSettings.aimbot_on_key = main.cb_aimbot_onkey.Checked;
			weaponSettings.aimbot_key_txt = main.txt_aimbot_key.Text;
			weaponSettings.aimbot_bone_index = main.cmb_aimbot_bone.SelectedIndex;
			weaponSettings.aimbot_fov = Convert.ToSingle(main.nud_aimbot_fov.Value);
			weaponSettings.aimbot_smooth = Convert.ToSingle(main.nud_aimbot_smooth.Value);
			weaponSettings.aimbot_control_recoil = main.cb_aimbot_rcs.Checked;
			weaponSettings.aimbot_shoot_teammates = main.cb_aimbot_target_teammates.Checked;
			weaponSettings.aimbot_shoot_enemies = main.cb_aimbot_target_enemies.Checked;
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00005554 File Offset: 0x00003754
	public static void RefreshTriggerSettings(Main main)
	{
		main.RefreshingTriggerSettings = true;
		WeaponSettings weaponSettings = WeaponSettings.Selected(main.cmb_triggerbot_type);
		main.cb_trigger_onkey.Checked = weaponSettings.trigger_on_key;
		main.txt_trigger_key.Text = weaponSettings.trigger_key_txt;
		main.nud_trigger_delay.Value = Convert.ToDecimal(weaponSettings.trigger_delay);
		main.nud_trigger_overshoot.Value = Convert.ToDecimal(weaponSettings.trigger_overshoot);
		main.cb_trigger_shoot_teammates.Checked = weaponSettings.trigger_shoot_teammates;
		main.cb_trigger_shoot_enemies.Checked = weaponSettings.trigger_shoot_enemies;
		main.cb_trigger_magnetic.Checked = weaponSettings.trigger_magnetic;
		main.cmb_trigger_magnet_bone.SelectedIndex = weaponSettings.trigger_magnet_bone_index;
		main.nud_trigger_magnet_fov.Value = Convert.ToDecimal(weaponSettings.trigger_magnet_fov);
		main.nud_trigger_magnet_smooth.Value = Convert.ToDecimal(weaponSettings.trigger_magnet_smooth);
		main.RefreshingTriggerSettings = false;
		main.txtDummy.Focus();
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00005648 File Offset: 0x00003848
	public static void UpdateTriggerSettings(Main main)
	{
		if (!main.RefreshingTriggerSettings)
		{
			WeaponSettings weaponSettings = WeaponSettings.Selected(main.cmb_triggerbot_type);
			weaponSettings.trigger_on_key = main.cb_trigger_onkey.Checked;
			weaponSettings.trigger_key_txt = main.txt_trigger_key.Text;
			weaponSettings.trigger_delay = Convert.ToInt32(main.nud_trigger_delay.Value);
			weaponSettings.trigger_overshoot = Convert.ToInt32(main.nud_trigger_overshoot.Value);
			weaponSettings.trigger_shoot_teammates = main.cb_trigger_shoot_teammates.Checked;
			weaponSettings.trigger_shoot_enemies = main.cb_trigger_shoot_enemies.Checked;
			weaponSettings.trigger_magnetic = main.cb_trigger_magnetic.Checked;
			weaponSettings.trigger_magnet_bone_index = main.cmb_trigger_magnet_bone.SelectedIndex;
			weaponSettings.trigger_magnet_fov = Convert.ToSingle(main.nud_trigger_magnet_fov.Value);
			weaponSettings.trigger_magnet_smooth = Convert.ToSingle(main.nud_trigger_magnet_smooth.Value);
		}
	}

	// Token: 0x04000009 RID: 9
	public static List<WeaponSettings> types = new List<WeaponSettings>();

	// Token: 0x0400000A RID: 10
	private static int indexTracker = 0;

	// Token: 0x0400000B RID: 11
	public int index;

	// Token: 0x0400000C RID: 12
	public bool trigger_on_key = false;

	// Token: 0x0400000D RID: 13
	public string trigger_key_txt = "Mouse 5 [0x6]";

	// Token: 0x0400000E RID: 14
	public int trigger_delay = 0;

	// Token: 0x0400000F RID: 15
	public int trigger_overshoot = 0;

	// Token: 0x04000010 RID: 16
	public bool trigger_shoot_teammates = false;

	// Token: 0x04000011 RID: 17
	public bool trigger_shoot_enemies = false;

	// Token: 0x04000012 RID: 18
	public bool trigger_magnetic = false;

	// Token: 0x04000013 RID: 19
	public int trigger_magnet_bone_index = 0;

	// Token: 0x04000014 RID: 20
	public float trigger_magnet_fov = 0.1f;

	// Token: 0x04000015 RID: 21
	public float trigger_magnet_smooth = 1f;

	// Token: 0x04000016 RID: 22
	public bool aimbot_on_key = false;

	// Token: 0x04000017 RID: 23
	public string aimbot_key_txt = "Mouse 1 [0x1]";

	// Token: 0x04000018 RID: 24
	public int aimbot_bone_index = 0;

	// Token: 0x04000019 RID: 25
	public float aimbot_fov = 0.1f;

	// Token: 0x0400001A RID: 26
	public float aimbot_smooth = 1f;

	// Token: 0x0400001B RID: 27
	public bool aimbot_control_recoil = false;

	// Token: 0x0400001C RID: 28
	public bool aimbot_shoot_teammates = false;

	// Token: 0x0400001D RID: 29
	public bool aimbot_shoot_enemies = false;
}
