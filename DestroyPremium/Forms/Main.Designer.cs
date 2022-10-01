namespace DestroyPremium.Forms
{
	// Token: 0x02000024 RID: 36
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00008740 File Offset: 0x00006940
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00008770 File Offset: 0x00006970
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.tabTriggerbot = new System.Windows.Forms.Panel();
            this.lblTriggerbot = new System.Windows.Forms.Label();
            this.tabVisuals = new System.Windows.Forms.Panel();
            this.lblVisuals = new System.Windows.Forms.Label();
            this.tabMisc = new System.Windows.Forms.Panel();
            this.lblMisc = new System.Windows.Forms.Label();
            this.tabCompile = new System.Windows.Forms.Panel();
            this.lblCompile = new System.Windows.Forms.Label();
            this.lbOffsets = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManuallyModifyOffsets = new System.Windows.Forms.Button();
            this.btnChangeSelectedOffset = new System.Windows.Forms.Button();
            this.cmb_scrape_offsets = new System.Windows.Forms.ComboBox();
            this.btnScrapeOffsets = new System.Windows.Forms.Button();
            this.pnlTriggerbot = new System.Windows.Forms.Panel();
            this.pnlTrigger1 = new System.Windows.Forms.Panel();
            this.lblCustomizeTriggerMagnetic = new System.Windows.Forms.Label();
            this.cb_trigger_magnetic = new System.Windows.Forms.CheckBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_trigger_shoot_enemies = new System.Windows.Forms.CheckBox();
            this.txt_trigger_key = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_trigger_shoot_teammates = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_trigger_onkey = new System.Windows.Forms.CheckBox();
            this.nud_trigger_overshoot = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nud_trigger_delay = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlTrigger2 = new System.Windows.Forms.Panel();
            this.cmb_trigger_magnet_bone = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.nud_trigger_magnet_smooth = new System.Windows.Forms.NumericUpDown();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.nud_trigger_magnet_fov = new System.Windows.Forms.NumericUpDown();
            this.label61 = new System.Windows.Forms.Label();
            this.lblBackToTrigger = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_trigger_thread_delay = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.cb_trigger_enabled = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmb_triggerbot_type = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlVisuals = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.nud_visuals_thread_delay = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.cb_visuals_enemies_healthbased = new System.Windows.Forms.CheckBox();
            this.nud_visuals_enemies_glowalpha = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.lbl_visuals_enemies_color = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cb_visuals_enemies_visibleonly = new System.Windows.Forms.CheckBox();
            this.label80 = new System.Windows.Forms.Label();
            this.cb_visuals_enemies_enabled = new System.Windows.Forms.CheckBox();
            this.label81 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label59 = new System.Windows.Forms.Label();
            this.cb_visuals_teammates_healthbased = new System.Windows.Forms.CheckBox();
            this.nud_visuals_teammates_glowalpha = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_visuals_teammates_color = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_visuals_teammates_visibleonly = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_visuals_teammates_enabled = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_visuals_enabled = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMisc = new System.Windows.Forms.Panel();
            this.pnlFeatures = new System.Windows.Forms.Panel();
            this.label57 = new System.Windows.Forms.Label();
            this.nud_fov_changer = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.cb_fov_changer = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cb_rcs_enabled = new System.Windows.Forms.CheckBox();
            this.nud_rcs_x_percent = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.nud_rcs_y_percent = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_bhop_key = new System.Windows.Forms.TextBox();
            this.cb_radar_enabled = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cb_bhop_enabled = new System.Windows.Forms.CheckBox();
            this.nud_noflash_percent = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.cb_noflash_enabled = new System.Windows.Forms.CheckBox();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.pnlConfigFile = new System.Windows.Forms.Panel();
            this.btnLoadConfigFile = new System.Windows.Forms.Button();
            this.btnSelectConfigFileLoad = new System.Windows.Forms.Button();
            this.btnSaveConfigFile = new System.Windows.Forms.Button();
            this.label72 = new System.Windows.Forms.Label();
            this.txtConfigFileLoad = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.txtConfigFileSave = new System.Windows.Forms.TextBox();
            this.btnSelectConfigFileSave = new System.Windows.Forms.Button();
            this.label75 = new System.Windows.Forms.Label();
            this.tabConfig = new System.Windows.Forms.Panel();
            this.lblConfig = new System.Windows.Forms.Label();
            this.tabFeatures = new System.Windows.Forms.Panel();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.lblRemoveAds = new System.Windows.Forms.Label();
            this.lblAdvertisements = new System.Windows.Forms.Label();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPreAdvertisements = new System.Windows.Forms.Label();
            this.lblPreLoggedIn = new System.Windows.Forms.Label();
            this.pnlCompile = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnCompile = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_build_path = new System.Windows.Forms.TextBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.tabAimbot = new System.Windows.Forms.Panel();
            this.lblAimbot = new System.Windows.Forms.Label();
            this.pnlAimbot = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.nud_aimbot_thread_delay = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.cb_aimbot_enabled = new System.Windows.Forms.CheckBox();
            this.label41 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cmb_aimbot_type = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.cmb_aimbot_bone = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.cb_aimbot_rcs = new System.Windows.Forms.CheckBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.cb_aimbot_target_enemies = new System.Windows.Forms.CheckBox();
            this.txt_aimbot_key = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.cb_aimbot_target_teammates = new System.Windows.Forms.CheckBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.cb_aimbot_onkey = new System.Windows.Forms.CheckBox();
            this.nud_aimbot_smooth = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.nud_aimbot_fov = new System.Windows.Forms.NumericUpDown();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txtDummy = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabTriggerbot.SuspendLayout();
            this.tabVisuals.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.tabCompile.SuspendLayout();
            this.pnlTriggerbot.SuspendLayout();
            this.pnlTrigger1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_overshoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_delay)).BeginInit();
            this.pnlTrigger2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_magnet_smooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_magnet_fov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_thread_delay)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnlVisuals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_thread_delay)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_enemies_glowalpha)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_teammates_glowalpha)).BeginInit();
            this.pnlMisc.SuspendLayout();
            this.pnlFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fov_changer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rcs_x_percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rcs_y_percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_noflash_percent)).BeginInit();
            this.pnlConfig.SuspendLayout();
            this.pnlConfigFile.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabFeatures.SuspendLayout();
            this.pnlCompile.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabAimbot.SuspendLayout();
            this.pnlAimbot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_thread_delay)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_smooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_fov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTriggerbot
            // 
            this.tabTriggerbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabTriggerbot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTriggerbot.Controls.Add(this.lblTriggerbot);
            this.tabTriggerbot.Location = new System.Drawing.Point(37, 185);
            this.tabTriggerbot.Name = "tabTriggerbot";
            this.tabTriggerbot.Size = new System.Drawing.Size(136, 40);
            this.tabTriggerbot.TabIndex = 1;
            // 
            // lblTriggerbot
            // 
            this.lblTriggerbot.AutoSize = true;
            this.lblTriggerbot.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriggerbot.ForeColor = System.Drawing.Color.White;
            this.lblTriggerbot.Location = new System.Drawing.Point(19, 6);
            this.lblTriggerbot.Name = "lblTriggerbot";
            this.lblTriggerbot.Size = new System.Drawing.Size(99, 25);
            this.lblTriggerbot.TabIndex = 1;
            this.lblTriggerbot.Text = "Triggerbot";
            // 
            // tabVisuals
            // 
            this.tabVisuals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabVisuals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabVisuals.Controls.Add(this.lblVisuals);
            this.tabVisuals.Location = new System.Drawing.Point(37, 231);
            this.tabVisuals.Name = "tabVisuals";
            this.tabVisuals.Size = new System.Drawing.Size(136, 40);
            this.tabVisuals.TabIndex = 2;
            // 
            // lblVisuals
            // 
            this.lblVisuals.AutoSize = true;
            this.lblVisuals.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisuals.ForeColor = System.Drawing.Color.White;
            this.lblVisuals.Location = new System.Drawing.Point(39, 6);
            this.lblVisuals.Name = "lblVisuals";
            this.lblVisuals.Size = new System.Drawing.Size(62, 25);
            this.lblVisuals.TabIndex = 2;
            this.lblVisuals.Text = "Görüş";
            // 
            // tabMisc
            // 
            this.tabMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabMisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMisc.Controls.Add(this.lblMisc);
            this.tabMisc.Location = new System.Drawing.Point(37, 277);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Size = new System.Drawing.Size(136, 40);
            this.tabMisc.TabIndex = 3;
            // 
            // lblMisc
            // 
            this.lblMisc.AutoSize = true;
            this.lblMisc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisc.ForeColor = System.Drawing.Color.White;
            this.lblMisc.Location = new System.Drawing.Point(39, 6);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(58, 25);
            this.lblMisc.TabIndex = 2;
            this.lblMisc.Text = "Diğer";
            // 
            // tabCompile
            // 
            this.tabCompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabCompile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCompile.Controls.Add(this.lblCompile);
            this.tabCompile.Location = new System.Drawing.Point(37, 323);
            this.tabCompile.Name = "tabCompile";
            this.tabCompile.Size = new System.Drawing.Size(136, 40);
            this.tabCompile.TabIndex = 4;
            // 
            // lblCompile
            // 
            this.lblCompile.AutoSize = true;
            this.lblCompile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompile.ForeColor = System.Drawing.Color.White;
            this.lblCompile.Location = new System.Drawing.Point(31, 7);
            this.lblCompile.Name = "lblCompile";
            this.lblCompile.Size = new System.Drawing.Size(70, 25);
            this.lblCompile.TabIndex = 2;
            this.lblCompile.Text = "Çalıştır";
            // 
            // lbOffsets
            // 
            this.lbOffsets.Location = new System.Drawing.Point(0, 0);
            this.lbOffsets.Name = "lbOffsets";
            this.lbOffsets.Size = new System.Drawing.Size(120, 95);
            this.lbOffsets.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // btnManuallyModifyOffsets
            // 
            this.btnManuallyModifyOffsets.Location = new System.Drawing.Point(0, 0);
            this.btnManuallyModifyOffsets.Name = "btnManuallyModifyOffsets";
            this.btnManuallyModifyOffsets.Size = new System.Drawing.Size(75, 23);
            this.btnManuallyModifyOffsets.TabIndex = 0;
            // 
            // btnChangeSelectedOffset
            // 
            this.btnChangeSelectedOffset.Location = new System.Drawing.Point(0, 0);
            this.btnChangeSelectedOffset.Name = "btnChangeSelectedOffset";
            this.btnChangeSelectedOffset.Size = new System.Drawing.Size(75, 23);
            this.btnChangeSelectedOffset.TabIndex = 0;
            // 
            // cmb_scrape_offsets
            // 
            this.cmb_scrape_offsets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_scrape_offsets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_scrape_offsets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_scrape_offsets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_scrape_offsets.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_scrape_offsets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cmb_scrape_offsets.FormattingEnabled = true;
            this.cmb_scrape_offsets.Items.AddRange(new object[] {
            "github/hazedumper"});
            this.cmb_scrape_offsets.Location = new System.Drawing.Point(70, 11);
            this.cmb_scrape_offsets.Name = "cmb_scrape_offsets";
            this.cmb_scrape_offsets.Size = new System.Drawing.Size(180, 21);
            this.cmb_scrape_offsets.TabIndex = 102;
            this.cmb_scrape_offsets.TabStop = false;
            this.cmb_scrape_offsets.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // btnScrapeOffsets
            // 
            this.btnScrapeOffsets.Location = new System.Drawing.Point(0, 0);
            this.btnScrapeOffsets.Name = "btnScrapeOffsets";
            this.btnScrapeOffsets.Size = new System.Drawing.Size(75, 23);
            this.btnScrapeOffsets.TabIndex = 106;
            // 
            // pnlTriggerbot
            // 
            this.pnlTriggerbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTriggerbot.Controls.Add(this.pnlTrigger1);
            this.pnlTriggerbot.Controls.Add(this.pnlTrigger2);
            this.pnlTriggerbot.Controls.Add(this.label2);
            this.pnlTriggerbot.Controls.Add(this.nud_trigger_thread_delay);
            this.pnlTriggerbot.Controls.Add(this.label27);
            this.pnlTriggerbot.Controls.Add(this.cb_trigger_enabled);
            this.pnlTriggerbot.Controls.Add(this.label28);
            this.pnlTriggerbot.Controls.Add(this.panel5);
            this.pnlTriggerbot.Location = new System.Drawing.Point(190, 63);
            this.pnlTriggerbot.Name = "pnlTriggerbot";
            this.pnlTriggerbot.Size = new System.Drawing.Size(495, 300);
            this.pnlTriggerbot.TabIndex = 6;
            // 
            // pnlTrigger1
            // 
            this.pnlTrigger1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlTrigger1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrigger1.Controls.Add(this.lblCustomizeTriggerMagnetic);
            this.pnlTrigger1.Controls.Add(this.cb_trigger_magnetic);
            this.pnlTrigger1.Controls.Add(this.label60);
            this.pnlTrigger1.Controls.Add(this.label7);
            this.pnlTrigger1.Controls.Add(this.cb_trigger_shoot_enemies);
            this.pnlTrigger1.Controls.Add(this.txt_trigger_key);
            this.pnlTrigger1.Controls.Add(this.label13);
            this.pnlTrigger1.Controls.Add(this.cb_trigger_shoot_teammates);
            this.pnlTrigger1.Controls.Add(this.label12);
            this.pnlTrigger1.Controls.Add(this.label6);
            this.pnlTrigger1.Controls.Add(this.label10);
            this.pnlTrigger1.Controls.Add(this.cb_trigger_onkey);
            this.pnlTrigger1.Controls.Add(this.nud_trigger_overshoot);
            this.pnlTrigger1.Controls.Add(this.label8);
            this.pnlTrigger1.Controls.Add(this.label11);
            this.pnlTrigger1.Controls.Add(this.nud_trigger_delay);
            this.pnlTrigger1.Controls.Add(this.label9);
            this.pnlTrigger1.Location = new System.Drawing.Point(65, 89);
            this.pnlTrigger1.Name = "pnlTrigger1";
            this.pnlTrigger1.Size = new System.Drawing.Size(319, 166);
            this.pnlTrigger1.TabIndex = 19;
            // 
            // lblCustomizeTriggerMagnetic
            // 
            this.lblCustomizeTriggerMagnetic.AutoSize = true;
            this.lblCustomizeTriggerMagnetic.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomizeTriggerMagnetic.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomizeTriggerMagnetic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblCustomizeTriggerMagnetic.Location = new System.Drawing.Point(133, 145);
            this.lblCustomizeTriggerMagnetic.Name = "lblCustomizeTriggerMagnetic";
            this.lblCustomizeTriggerMagnetic.Size = new System.Drawing.Size(73, 13);
            this.lblCustomizeTriggerMagnetic.TabIndex = 107;
            this.lblCustomizeTriggerMagnetic.Text = "[CUSTOMIZE]";
            this.lblCustomizeTriggerMagnetic.Visible = false;
            this.lblCustomizeTriggerMagnetic.Click += new System.EventHandler(this.lblCustomizeTriggerMagnetic_Click);
            // 
            // cb_trigger_magnetic
            // 
            this.cb_trigger_magnetic.AutoSize = true;
            this.cb_trigger_magnetic.Location = new System.Drawing.Point(117, 145);
            this.cb_trigger_magnetic.Name = "cb_trigger_magnetic";
            this.cb_trigger_magnetic.Size = new System.Drawing.Size(15, 14);
            this.cb_trigger_magnetic.TabIndex = 19;
            this.cb_trigger_magnetic.UseVisualStyleBackColor = true;
            this.cb_trigger_magnetic.CheckedChanged += new System.EventHandler(this.cb_trigger_magnetic_CheckedChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(57, 145);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(55, 13);
            this.label60.TabIndex = 18;
            this.label60.Text = "Manyetik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tuşa basılıyken";
            // 
            // cb_trigger_shoot_enemies
            // 
            this.cb_trigger_shoot_enemies.AutoSize = true;
            this.cb_trigger_shoot_enemies.Checked = true;
            this.cb_trigger_shoot_enemies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_trigger_shoot_enemies.Location = new System.Drawing.Point(117, 126);
            this.cb_trigger_shoot_enemies.Name = "cb_trigger_shoot_enemies";
            this.cb_trigger_shoot_enemies.Size = new System.Drawing.Size(15, 14);
            this.cb_trigger_shoot_enemies.TabIndex = 17;
            this.cb_trigger_shoot_enemies.UseVisualStyleBackColor = true;
            // 
            // txt_trigger_key
            // 
            this.txt_trigger_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_trigger_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_trigger_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_trigger_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trigger_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_trigger_key.Location = new System.Drawing.Point(118, 26);
            this.txt_trigger_key.Name = "txt_trigger_key";
            this.txt_trigger_key.ReadOnly = true;
            this.txt_trigger_key.ShortcutsEnabled = false;
            this.txt_trigger_key.Size = new System.Drawing.Size(130, 20);
            this.txt_trigger_key.TabIndex = 2;
            this.txt_trigger_key.TabStop = false;
            this.txt_trigger_key.Text = "Mouse 5 [0x6]";
            this.txt_trigger_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(49, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Düşmanlar";
            // 
            // cb_trigger_shoot_teammates
            // 
            this.cb_trigger_shoot_teammates.AutoSize = true;
            this.cb_trigger_shoot_teammates.Location = new System.Drawing.Point(117, 107);
            this.cb_trigger_shoot_teammates.Name = "cb_trigger_shoot_teammates";
            this.cb_trigger_shoot_teammates.Size = new System.Drawing.Size(15, 14);
            this.cb_trigger_shoot_teammates.TabIndex = 15;
            this.cb_trigger_shoot_teammates.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(5, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Takım arkadaşları";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(87, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tuş";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(254, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "(ms)";
            // 
            // cb_trigger_onkey
            // 
            this.cb_trigger_onkey.AutoSize = true;
            this.cb_trigger_onkey.Location = new System.Drawing.Point(117, 6);
            this.cb_trigger_onkey.Name = "cb_trigger_onkey";
            this.cb_trigger_onkey.Size = new System.Drawing.Size(15, 14);
            this.cb_trigger_onkey.TabIndex = 7;
            this.cb_trigger_onkey.UseVisualStyleBackColor = true;
            // 
            // nud_trigger_overshoot
            // 
            this.nud_trigger_overshoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_trigger_overshoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_trigger_overshoot.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_trigger_overshoot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_trigger_overshoot.Location = new System.Drawing.Point(118, 81);
            this.nud_trigger_overshoot.Name = "nud_trigger_overshoot";
            this.nud_trigger_overshoot.Size = new System.Drawing.Size(130, 20);
            this.nud_trigger_overshoot.TabIndex = 12;
            this.nud_trigger_overshoot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(64, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Gecikme";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(51, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Overshoot";
            // 
            // nud_trigger_delay
            // 
            this.nud_trigger_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_trigger_delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_trigger_delay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_trigger_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_trigger_delay.Location = new System.Drawing.Point(118, 53);
            this.nud_trigger_delay.Name = "nud_trigger_delay";
            this.nud_trigger_delay.Size = new System.Drawing.Size(130, 20);
            this.nud_trigger_delay.TabIndex = 9;
            this.nud_trigger_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(254, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "(ms)";
            // 
            // pnlTrigger2
            // 
            this.pnlTrigger2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlTrigger2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrigger2.Controls.Add(this.cmb_trigger_magnet_bone);
            this.pnlTrigger2.Controls.Add(this.label62);
            this.pnlTrigger2.Controls.Add(this.nud_trigger_magnet_smooth);
            this.pnlTrigger2.Controls.Add(this.label63);
            this.pnlTrigger2.Controls.Add(this.label64);
            this.pnlTrigger2.Controls.Add(this.nud_trigger_magnet_fov);
            this.pnlTrigger2.Controls.Add(this.label61);
            this.pnlTrigger2.Controls.Add(this.lblBackToTrigger);
            this.pnlTrigger2.Location = new System.Drawing.Point(65, 89);
            this.pnlTrigger2.Name = "pnlTrigger2";
            this.pnlTrigger2.Size = new System.Drawing.Size(319, 166);
            this.pnlTrigger2.TabIndex = 108;
            // 
            // cmb_trigger_magnet_bone
            // 
            this.cmb_trigger_magnet_bone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_trigger_magnet_bone.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_trigger_magnet_bone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_trigger_magnet_bone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_trigger_magnet_bone.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_trigger_magnet_bone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cmb_trigger_magnet_bone.FormattingEnabled = true;
            this.cmb_trigger_magnet_bone.Items.AddRange(new object[] {
            "head",
            "neck",
            "upper chest",
            "middle chest",
            "lower chest"});
            this.cmb_trigger_magnet_bone.Location = new System.Drawing.Point(121, 56);
            this.cmb_trigger_magnet_bone.Name = "cmb_trigger_magnet_bone";
            this.cmb_trigger_magnet_bone.Size = new System.Drawing.Size(131, 21);
            this.cmb_trigger_magnet_bone.TabIndex = 115;
            this.cmb_trigger_magnet_bone.TabStop = false;
            this.cmb_trigger_magnet_bone.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(65, 58);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(49, 15);
            this.label62.TabIndex = 114;
            this.label62.Text = "Target";
            // 
            // nud_trigger_magnet_smooth
            // 
            this.nud_trigger_magnet_smooth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_trigger_magnet_smooth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_trigger_magnet_smooth.DecimalPlaces = 1;
            this.nud_trigger_magnet_smooth.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_trigger_magnet_smooth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_trigger_magnet_smooth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_trigger_magnet_smooth.Location = new System.Drawing.Point(121, 107);
            this.nud_trigger_magnet_smooth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nud_trigger_magnet_smooth.Name = "nud_trigger_magnet_smooth";
            this.nud_trigger_magnet_smooth.Size = new System.Drawing.Size(131, 20);
            this.nud_trigger_magnet_smooth.TabIndex = 113;
            this.nud_trigger_magnet_smooth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_trigger_magnet_smooth.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(90, 86);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(25, 13);
            this.label63.TabIndex = 110;
            this.label63.Text = "FOV";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(72, 111);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(43, 13);
            this.label64.TabIndex = 112;
            this.label64.Text = "Smooth";
            // 
            // nud_trigger_magnet_fov
            // 
            this.nud_trigger_magnet_fov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_trigger_magnet_fov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_trigger_magnet_fov.DecimalPlaces = 1;
            this.nud_trigger_magnet_fov.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_trigger_magnet_fov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_trigger_magnet_fov.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_trigger_magnet_fov.Location = new System.Drawing.Point(121, 82);
            this.nud_trigger_magnet_fov.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.nud_trigger_magnet_fov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_trigger_magnet_fov.Name = "nud_trigger_magnet_fov";
            this.nud_trigger_magnet_fov.Size = new System.Drawing.Size(131, 20);
            this.nud_trigger_magnet_fov.TabIndex = 111;
            this.nud_trigger_magnet_fov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_trigger_magnet_fov.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label61.Location = new System.Drawing.Point(86, 29);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(144, 19);
            this.label61.TabIndex = 109;
            this.label61.Text = "Magnet Settings";
            // 
            // lblBackToTrigger
            // 
            this.lblBackToTrigger.AutoSize = true;
            this.lblBackToTrigger.BackColor = System.Drawing.Color.Transparent;
            this.lblBackToTrigger.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackToTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblBackToTrigger.Location = new System.Drawing.Point(5, 5);
            this.lblBackToTrigger.Name = "lblBackToTrigger";
            this.lblBackToTrigger.Size = new System.Drawing.Size(43, 13);
            this.lblBackToTrigger.TabIndex = 108;
            this.lblBackToTrigger.Text = "[BACK]";
            this.lblBackToTrigger.Click += new System.EventHandler(this.lblBackToTrigger_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(349, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "(ms)";
            this.label2.Visible = false;
            // 
            // nud_trigger_thread_delay
            // 
            this.nud_trigger_thread_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_trigger_thread_delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_trigger_thread_delay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_trigger_thread_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_trigger_thread_delay.Location = new System.Drawing.Point(263, 27);
            this.nud_trigger_thread_delay.Name = "nud_trigger_thread_delay";
            this.nud_trigger_thread_delay.Size = new System.Drawing.Size(80, 20);
            this.nud_trigger_thread_delay.TabIndex = 23;
            this.nud_trigger_thread_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_trigger_thread_delay.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(178, 31);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Thread Delay";
            this.label27.Visible = false;
            // 
            // cb_trigger_enabled
            // 
            this.cb_trigger_enabled.AutoSize = true;
            this.cb_trigger_enabled.Location = new System.Drawing.Point(122, 35);
            this.cb_trigger_enabled.Name = "cb_trigger_enabled";
            this.cb_trigger_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_trigger_enabled.TabIndex = 21;
            this.cb_trigger_enabled.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(64, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 13);
            this.label28.TabIndex = 20;
            this.label28.Text = "Aktif Et";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.cmb_triggerbot_type);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Location = new System.Drawing.Point(65, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 32);
            this.panel5.TabIndex = 18;
            // 
            // cmb_triggerbot_type
            // 
            this.cmb_triggerbot_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_triggerbot_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_triggerbot_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_triggerbot_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_triggerbot_type.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_triggerbot_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cmb_triggerbot_type.FormattingEnabled = true;
            this.cmb_triggerbot_type.Items.AddRange(new object[] {
            "general",
            "pistols",
            "snipers"});
            this.cmb_triggerbot_type.Location = new System.Drawing.Point(150, 3);
            this.cmb_triggerbot_type.Name = "cmb_triggerbot_type";
            this.cmb_triggerbot_type.Size = new System.Drawing.Size(131, 21);
            this.cmb_triggerbot_type.TabIndex = 106;
            this.cmb_triggerbot_type.TabStop = false;
            this.cmb_triggerbot_type.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label19.Location = new System.Drawing.Point(33, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Silah Grubu";
            // 
            // pnlVisuals
            // 
            this.pnlVisuals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlVisuals.Controls.Add(this.label26);
            this.pnlVisuals.Controls.Add(this.nud_visuals_thread_delay);
            this.pnlVisuals.Controls.Add(this.label22);
            this.pnlVisuals.Controls.Add(this.panel3);
            this.pnlVisuals.Controls.Add(this.panel4);
            this.pnlVisuals.Controls.Add(this.panel2);
            this.pnlVisuals.Controls.Add(this.panel1);
            this.pnlVisuals.Controls.Add(this.cb_visuals_enabled);
            this.pnlVisuals.Controls.Add(this.label3);
            this.pnlVisuals.Location = new System.Drawing.Point(190, 63);
            this.pnlVisuals.Name = "pnlVisuals";
            this.pnlVisuals.Size = new System.Drawing.Size(495, 300);
            this.pnlVisuals.TabIndex = 6;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(401, 33);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 13);
            this.label26.TabIndex = 18;
            this.label26.Text = "(ms)";
            this.label26.Visible = false;
            // 
            // nud_visuals_thread_delay
            // 
            this.nud_visuals_thread_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_visuals_thread_delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_visuals_thread_delay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_visuals_thread_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_visuals_thread_delay.Location = new System.Drawing.Point(315, 31);
            this.nud_visuals_thread_delay.Name = "nud_visuals_thread_delay";
            this.nud_visuals_thread_delay.Size = new System.Drawing.Size(80, 20);
            this.nud_visuals_thread_delay.TabIndex = 17;
            this.nud_visuals_thread_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_visuals_thread_delay.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(230, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Thread Delay";
            this.label22.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.cb_visuals_enemies_healthbased);
            this.panel3.Controls.Add(this.nud_visuals_enemies_glowalpha);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.lbl_visuals_enemies_color);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.cb_visuals_enemies_visibleonly);
            this.panel3.Controls.Add(this.label80);
            this.panel3.Controls.Add(this.cb_visuals_enemies_enabled);
            this.panel3.Controls.Add(this.label81);
            this.panel3.Location = new System.Drawing.Point(280, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 164);
            this.panel3.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(65, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Renk";
            // 
            // cb_visuals_enemies_healthbased
            // 
            this.cb_visuals_enemies_healthbased.AutoSize = true;
            this.cb_visuals_enemies_healthbased.Location = new System.Drawing.Point(102, 71);
            this.cb_visuals_enemies_healthbased.Name = "cb_visuals_enemies_healthbased";
            this.cb_visuals_enemies_healthbased.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_enemies_healthbased.TabIndex = 26;
            this.cb_visuals_enemies_healthbased.UseVisualStyleBackColor = true;
            // 
            // nud_visuals_enemies_glowalpha
            // 
            this.nud_visuals_enemies_glowalpha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_visuals_enemies_glowalpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_visuals_enemies_glowalpha.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_visuals_enemies_glowalpha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_visuals_enemies_glowalpha.Location = new System.Drawing.Point(102, 116);
            this.nud_visuals_enemies_glowalpha.Name = "nud_visuals_enemies_glowalpha";
            this.nud_visuals_enemies_glowalpha.Size = new System.Drawing.Size(80, 20);
            this.nud_visuals_enemies_glowalpha.TabIndex = 25;
            this.nud_visuals_enemies_glowalpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(48, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Şeffaflık";
            // 
            // lbl_visuals_enemies_color
            // 
            this.lbl_visuals_enemies_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_visuals_enemies_color.Location = new System.Drawing.Point(103, 94);
            this.lbl_visuals_enemies_color.Name = "lbl_visuals_enemies_color";
            this.lbl_visuals_enemies_color.Size = new System.Drawing.Size(12, 12);
            this.lbl_visuals_enemies_color.TabIndex = 23;
            this.lbl_visuals_enemies_color.Click += new System.EventHandler(this.cb_visuals_enemies_color_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(38, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 22;
            this.label25.Text = "Can Rengi";
            // 
            // cb_visuals_enemies_visibleonly
            // 
            this.cb_visuals_enemies_visibleonly.AutoSize = true;
            this.cb_visuals_enemies_visibleonly.Location = new System.Drawing.Point(102, 49);
            this.cb_visuals_enemies_visibleonly.Name = "cb_visuals_enemies_visibleonly";
            this.cb_visuals_enemies_visibleonly.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_enemies_visibleonly.TabIndex = 21;
            this.cb_visuals_enemies_visibleonly.UseVisualStyleBackColor = true;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Nirmala UI", 7.25F);
            this.label80.ForeColor = System.Drawing.Color.White;
            this.label80.Location = new System.Drawing.Point(9, 49);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(92, 12);
            this.label80.TabIndex = 20;
            this.label80.Text = "Sadece Görünürken";
            // 
            // cb_visuals_enemies_enabled
            // 
            this.cb_visuals_enemies_enabled.AutoSize = true;
            this.cb_visuals_enemies_enabled.Location = new System.Drawing.Point(102, 26);
            this.cb_visuals_enemies_enabled.Name = "cb_visuals_enemies_enabled";
            this.cb_visuals_enemies_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_enemies_enabled.TabIndex = 19;
            this.cb_visuals_enemies_enabled.UseVisualStyleBackColor = true;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label81.ForeColor = System.Drawing.Color.White;
            this.label81.Location = new System.Drawing.Point(48, 26);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(44, 13);
            this.label81.TabIndex = 18;
            this.label81.Text = "Aktif Et";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(280, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 32);
            this.panel4.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label15.Location = new System.Drawing.Point(60, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Düsman";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(21, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 32);
            this.panel2.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(70, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Takım";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label59);
            this.panel1.Controls.Add(this.cb_visuals_teammates_healthbased);
            this.panel1.Controls.Add(this.nud_visuals_teammates_glowalpha);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.lbl_visuals_teammates_color);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.cb_visuals_teammates_visibleonly);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cb_visuals_teammates_enabled);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(21, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 164);
            this.panel1.TabIndex = 7;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(65, 93);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(33, 13);
            this.label59.TabIndex = 17;
            this.label59.Text = "Renk";
            // 
            // cb_visuals_teammates_healthbased
            // 
            this.cb_visuals_teammates_healthbased.AutoSize = true;
            this.cb_visuals_teammates_healthbased.Location = new System.Drawing.Point(102, 71);
            this.cb_visuals_teammates_healthbased.Name = "cb_visuals_teammates_healthbased";
            this.cb_visuals_teammates_healthbased.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_teammates_healthbased.TabIndex = 16;
            this.cb_visuals_teammates_healthbased.UseVisualStyleBackColor = true;
            // 
            // nud_visuals_teammates_glowalpha
            // 
            this.nud_visuals_teammates_glowalpha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_visuals_teammates_glowalpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_visuals_teammates_glowalpha.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_visuals_teammates_glowalpha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_visuals_teammates_glowalpha.Location = new System.Drawing.Point(102, 116);
            this.nud_visuals_teammates_glowalpha.Name = "nud_visuals_teammates_glowalpha";
            this.nud_visuals_teammates_glowalpha.Size = new System.Drawing.Size(80, 20);
            this.nud_visuals_teammates_glowalpha.TabIndex = 14;
            this.nud_visuals_teammates_glowalpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(48, 119);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Şeffaflık";
            // 
            // lbl_visuals_teammates_color
            // 
            this.lbl_visuals_teammates_color.BackColor = System.Drawing.Color.Lime;
            this.lbl_visuals_teammates_color.Location = new System.Drawing.Point(103, 94);
            this.lbl_visuals_teammates_color.Name = "lbl_visuals_teammates_color";
            this.lbl_visuals_teammates_color.Size = new System.Drawing.Size(12, 12);
            this.lbl_visuals_teammates_color.TabIndex = 12;
            this.lbl_visuals_teammates_color.Click += new System.EventHandler(this.cb_visuals_teammates_color_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(37, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Can Rengi";
            // 
            // cb_visuals_teammates_visibleonly
            // 
            this.cb_visuals_teammates_visibleonly.AutoSize = true;
            this.cb_visuals_teammates_visibleonly.Location = new System.Drawing.Point(102, 49);
            this.cb_visuals_teammates_visibleonly.Name = "cb_visuals_teammates_visibleonly";
            this.cb_visuals_teammates_visibleonly.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_teammates_visibleonly.TabIndex = 10;
            this.cb_visuals_teammates_visibleonly.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 7.25F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(9, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 12);
            this.label17.TabIndex = 9;
            this.label17.Text = "Sadece Görünürken";
            // 
            // cb_visuals_teammates_enabled
            // 
            this.cb_visuals_teammates_enabled.AutoSize = true;
            this.cb_visuals_teammates_enabled.Location = new System.Drawing.Point(102, 26);
            this.cb_visuals_teammates_enabled.Name = "cb_visuals_teammates_enabled";
            this.cb_visuals_teammates_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_teammates_enabled.TabIndex = 8;
            this.cb_visuals_teammates_enabled.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(53, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Aktif Et";
            // 
            // cb_visuals_enabled
            // 
            this.cb_visuals_enabled.AutoSize = true;
            this.cb_visuals_enabled.Location = new System.Drawing.Point(75, 37);
            this.cb_visuals_enabled.Name = "cb_visuals_enabled";
            this.cb_visuals_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_enabled.TabIndex = 6;
            this.cb_visuals_enabled.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aktif Et";
            // 
            // pnlMisc
            // 
            this.pnlMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlMisc.Controls.Add(this.pnlFeatures);
            this.pnlMisc.Controls.Add(this.pnlConfig);
            this.pnlMisc.Controls.Add(this.tabConfig);
            this.pnlMisc.Controls.Add(this.tabFeatures);
            this.pnlMisc.Location = new System.Drawing.Point(190, 63);
            this.pnlMisc.Name = "pnlMisc";
            this.pnlMisc.Size = new System.Drawing.Size(495, 300);
            this.pnlMisc.TabIndex = 6;
            // 
            // pnlFeatures
            // 
            this.pnlFeatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFeatures.Controls.Add(this.label57);
            this.pnlFeatures.Controls.Add(this.nud_fov_changer);
            this.pnlFeatures.Controls.Add(this.label58);
            this.pnlFeatures.Controls.Add(this.cb_fov_changer);
            this.pnlFeatures.Controls.Add(this.label29);
            this.pnlFeatures.Controls.Add(this.label35);
            this.pnlFeatures.Controls.Add(this.cb_rcs_enabled);
            this.pnlFeatures.Controls.Add(this.nud_rcs_x_percent);
            this.pnlFeatures.Controls.Add(this.label34);
            this.pnlFeatures.Controls.Add(this.label36);
            this.pnlFeatures.Controls.Add(this.label37);
            this.pnlFeatures.Controls.Add(this.nud_rcs_y_percent);
            this.pnlFeatures.Controls.Add(this.label33);
            this.pnlFeatures.Controls.Add(this.txt_bhop_key);
            this.pnlFeatures.Controls.Add(this.cb_radar_enabled);
            this.pnlFeatures.Controls.Add(this.label38);
            this.pnlFeatures.Controls.Add(this.label52);
            this.pnlFeatures.Controls.Add(this.label4);
            this.pnlFeatures.Controls.Add(this.label32);
            this.pnlFeatures.Controls.Add(this.label53);
            this.pnlFeatures.Controls.Add(this.label30);
            this.pnlFeatures.Controls.Add(this.cb_bhop_enabled);
            this.pnlFeatures.Controls.Add(this.nud_noflash_percent);
            this.pnlFeatures.Controls.Add(this.label31);
            this.pnlFeatures.Controls.Add(this.cb_noflash_enabled);
            this.pnlFeatures.Location = new System.Drawing.Point(34, 51);
            this.pnlFeatures.Name = "pnlFeatures";
            this.pnlFeatures.Size = new System.Drawing.Size(448, 224);
            this.pnlFeatures.TabIndex = 109;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Font = new System.Drawing.Font("Nirmala UI", 12.25F);
            this.label57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label57.Location = new System.Drawing.Point(256, 75);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(122, 23);
            this.label57.TabIndex = 106;
            this.label57.Text = "FOV Değiştirici";
            // 
            // nud_fov_changer
            // 
            this.nud_fov_changer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_fov_changer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_fov_changer.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.nud_fov_changer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_fov_changer.Location = new System.Drawing.Point(325, 100);
            this.nud_fov_changer.Name = "nud_fov_changer";
            this.nud_fov_changer.Size = new System.Drawing.Size(89, 22);
            this.nud_fov_changer.TabIndex = 109;
            this.nud_fov_changer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(254, 105);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(44, 13);
            this.label58.TabIndex = 107;
            this.label58.Text = "Aktif Et";
            // 
            // cb_fov_changer
            // 
            this.cb_fov_changer.AutoSize = true;
            this.cb_fov_changer.Location = new System.Drawing.Point(302, 106);
            this.cb_fov_changer.Name = "cb_fov_changer";
            this.cb_fov_changer.Size = new System.Drawing.Size(15, 14);
            this.cb_fov_changer.TabIndex = 108;
            this.cb_fov_changer.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Nirmala UI", 12.25F);
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label29.Location = new System.Drawing.Point(12, 6);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 23);
            this.label29.TabIndex = 0;
            this.label29.Text = "Bunny Hop";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(10, 89);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 13);
            this.label35.TabIndex = 9;
            this.label35.Text = "Aktif Et";
            // 
            // cb_rcs_enabled
            // 
            this.cb_rcs_enabled.AutoSize = true;
            this.cb_rcs_enabled.Location = new System.Drawing.Point(56, 89);
            this.cb_rcs_enabled.Name = "cb_rcs_enabled";
            this.cb_rcs_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_rcs_enabled.TabIndex = 10;
            this.cb_rcs_enabled.UseVisualStyleBackColor = true;
            // 
            // nud_rcs_x_percent
            // 
            this.nud_rcs_x_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_rcs_x_percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_rcs_x_percent.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.nud_rcs_x_percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_rcs_x_percent.Location = new System.Drawing.Point(91, 107);
            this.nud_rcs_x_percent.Name = "nud_rcs_x_percent";
            this.nud_rcs_x_percent.Size = new System.Drawing.Size(89, 22);
            this.nud_rcs_x_percent.TabIndex = 11;
            this.nud_rcs_x_percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(184, 110);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(22, 13);
            this.label34.TabIndex = 24;
            this.label34.Text = "(%)";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(26, 111);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(52, 13);
            this.label36.TabIndex = 25;
            this.label36.Text = "X ekseni:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(26, 137);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(51, 13);
            this.label37.TabIndex = 26;
            this.label37.Text = "Y ekseni:";
            // 
            // nud_rcs_y_percent
            // 
            this.nud_rcs_y_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_rcs_y_percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_rcs_y_percent.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.nud_rcs_y_percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_rcs_y_percent.Location = new System.Drawing.Point(91, 133);
            this.nud_rcs_y_percent.Name = "nud_rcs_y_percent";
            this.nud_rcs_y_percent.Size = new System.Drawing.Size(89, 22);
            this.nud_rcs_y_percent.TabIndex = 27;
            this.nud_rcs_y_percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Nirmala UI", 12.25F);
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label33.Location = new System.Drawing.Point(253, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(54, 23);
            this.label33.TabIndex = 30;
            this.label33.Text = "Radar";
            // 
            // txt_bhop_key
            // 
            this.txt_bhop_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_bhop_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bhop_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_bhop_key.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.txt_bhop_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_bhop_key.Location = new System.Drawing.Point(83, 34);
            this.txt_bhop_key.Name = "txt_bhop_key";
            this.txt_bhop_key.ReadOnly = true;
            this.txt_bhop_key.ShortcutsEnabled = false;
            this.txt_bhop_key.Size = new System.Drawing.Size(120, 22);
            this.txt_bhop_key.TabIndex = 3;
            this.txt_bhop_key.TabStop = false;
            this.txt_bhop_key.Text = "Space [0x20]";
            this.txt_bhop_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_radar_enabled
            // 
            this.cb_radar_enabled.AutoSize = true;
            this.cb_radar_enabled.Location = new System.Drawing.Point(305, 43);
            this.cb_radar_enabled.Name = "cb_radar_enabled";
            this.cb_radar_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_radar_enabled.TabIndex = 32;
            this.cb_radar_enabled.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(184, 136);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(22, 13);
            this.label38.TabIndex = 28;
            this.label38.Text = "(%)";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(257, 43);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(44, 13);
            this.label52.TabIndex = 31;
            this.label52.Text = "Aktif Et";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aktif Et";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(178, 195);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(22, 13);
            this.label32.TabIndex = 24;
            this.label32.Text = "(%)";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Nirmala UI", 12.25F);
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label53.Location = new System.Drawing.Point(8, 59);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(131, 23);
            this.label53.TabIndex = 29;
            this.label53.Text = "Sekme Kontrolü";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Nirmala UI", 12.25F);
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label30.Location = new System.Drawing.Point(12, 161);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(76, 23);
            this.label30.TabIndex = 0;
            this.label30.Text = "No Flash";
            // 
            // cb_bhop_enabled
            // 
            this.cb_bhop_enabled.AutoSize = true;
            this.cb_bhop_enabled.Location = new System.Drawing.Point(62, 37);
            this.cb_bhop_enabled.Name = "cb_bhop_enabled";
            this.cb_bhop_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_bhop_enabled.TabIndex = 10;
            this.cb_bhop_enabled.UseVisualStyleBackColor = true;
            // 
            // nud_noflash_percent
            // 
            this.nud_noflash_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_noflash_percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_noflash_percent.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.nud_noflash_percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_noflash_percent.Location = new System.Drawing.Point(85, 191);
            this.nud_noflash_percent.Name = "nud_noflash_percent";
            this.nud_noflash_percent.Size = new System.Drawing.Size(89, 22);
            this.nud_noflash_percent.TabIndex = 11;
            this.nud_noflash_percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(13, 194);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "Aktif Et";
            // 
            // cb_noflash_enabled
            // 
            this.cb_noflash_enabled.AutoSize = true;
            this.cb_noflash_enabled.Location = new System.Drawing.Point(59, 194);
            this.cb_noflash_enabled.Name = "cb_noflash_enabled";
            this.cb_noflash_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_noflash_enabled.TabIndex = 10;
            this.cb_noflash_enabled.UseVisualStyleBackColor = true;
            // 
            // pnlConfig
            // 
            this.pnlConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConfig.Controls.Add(this.pnlConfigFile);
            this.pnlConfig.Location = new System.Drawing.Point(34, 51);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(448, 224);
            this.pnlConfig.TabIndex = 113;
            // 
            // pnlConfigFile
            // 
            this.pnlConfigFile.Controls.Add(this.btnLoadConfigFile);
            this.pnlConfigFile.Controls.Add(this.btnSelectConfigFileLoad);
            this.pnlConfigFile.Controls.Add(this.btnSaveConfigFile);
            this.pnlConfigFile.Controls.Add(this.label72);
            this.pnlConfigFile.Controls.Add(this.txtConfigFileLoad);
            this.pnlConfigFile.Controls.Add(this.label73);
            this.pnlConfigFile.Controls.Add(this.label74);
            this.pnlConfigFile.Controls.Add(this.txtConfigFileSave);
            this.pnlConfigFile.Controls.Add(this.btnSelectConfigFileSave);
            this.pnlConfigFile.Controls.Add(this.label75);
            this.pnlConfigFile.Location = new System.Drawing.Point(14, 28);
            this.pnlConfigFile.Name = "pnlConfigFile";
            this.pnlConfigFile.Size = new System.Drawing.Size(424, 157);
            this.pnlConfigFile.TabIndex = 105;
            // 
            // btnLoadConfigFile
            // 
            this.btnLoadConfigFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLoadConfigFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadConfigFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadConfigFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnLoadConfigFile.Location = new System.Drawing.Point(344, 102);
            this.btnLoadConfigFile.Name = "btnLoadConfigFile";
            this.btnLoadConfigFile.Size = new System.Drawing.Size(58, 24);
            this.btnLoadConfigFile.TabIndex = 36;
            this.btnLoadConfigFile.Text = "Load";
            this.btnLoadConfigFile.UseVisualStyleBackColor = false;
            this.btnLoadConfigFile.Click += new System.EventHandler(this.btnLoadConfigFile_Click);
            // 
            // btnSelectConfigFileLoad
            // 
            this.btnSelectConfigFileLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSelectConfigFileLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectConfigFileLoad.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectConfigFileLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSelectConfigFileLoad.Location = new System.Drawing.Point(301, 103);
            this.btnSelectConfigFileLoad.Name = "btnSelectConfigFileLoad";
            this.btnSelectConfigFileLoad.Size = new System.Drawing.Size(37, 22);
            this.btnSelectConfigFileLoad.TabIndex = 35;
            this.btnSelectConfigFileLoad.Text = "...";
            this.btnSelectConfigFileLoad.UseVisualStyleBackColor = false;
            this.btnSelectConfigFileLoad.Click += new System.EventHandler(this.btnSelectConfigFileLoad_Click);
            // 
            // btnSaveConfigFile
            // 
            this.btnSaveConfigFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSaveConfigFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveConfigFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfigFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSaveConfigFile.Location = new System.Drawing.Point(344, 35);
            this.btnSaveConfigFile.Name = "btnSaveConfigFile";
            this.btnSaveConfigFile.Size = new System.Drawing.Size(58, 24);
            this.btnSaveConfigFile.TabIndex = 34;
            this.btnSaveConfigFile.Text = "Save";
            this.btnSaveConfigFile.UseVisualStyleBackColor = false;
            this.btnSaveConfigFile.Click += new System.EventHandler(this.btnSaveConfigFile_Click);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.Transparent;
            this.label72.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(23, 107);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(42, 14);
            this.label72.TabIndex = 32;
            this.label72.Text = "File:";
            // 
            // txtConfigFileLoad
            // 
            this.txtConfigFileLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtConfigFileLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigFileLoad.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfigFileLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtConfigFileLoad.Location = new System.Drawing.Point(66, 104);
            this.txtConfigFileLoad.Name = "txtConfigFileLoad";
            this.txtConfigFileLoad.ReadOnly = true;
            this.txtConfigFileLoad.Size = new System.Drawing.Size(229, 20);
            this.txtConfigFileLoad.TabIndex = 30;
            this.txtConfigFileLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.Color.Transparent;
            this.label73.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label73.Location = new System.Drawing.Point(22, 80);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(108, 19);
            this.label73.TabIndex = 29;
            this.label73.Text = "Load Config";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.Color.Transparent;
            this.label74.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = System.Drawing.Color.White;
            this.label74.Location = new System.Drawing.Point(23, 40);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(42, 14);
            this.label74.TabIndex = 28;
            this.label74.Text = "File:";
            // 
            // txtConfigFileSave
            // 
            this.txtConfigFileSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtConfigFileSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigFileSave.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfigFileSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtConfigFileSave.Location = new System.Drawing.Point(66, 37);
            this.txtConfigFileSave.Name = "txtConfigFileSave";
            this.txtConfigFileSave.ReadOnly = true;
            this.txtConfigFileSave.Size = new System.Drawing.Size(229, 20);
            this.txtConfigFileSave.TabIndex = 26;
            this.txtConfigFileSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSelectConfigFileSave
            // 
            this.btnSelectConfigFileSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSelectConfigFileSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectConfigFileSave.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectConfigFileSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSelectConfigFileSave.Location = new System.Drawing.Point(301, 36);
            this.btnSelectConfigFileSave.Name = "btnSelectConfigFileSave";
            this.btnSelectConfigFileSave.Size = new System.Drawing.Size(37, 22);
            this.btnSelectConfigFileSave.TabIndex = 27;
            this.btnSelectConfigFileSave.Text = "...";
            this.btnSelectConfigFileSave.UseVisualStyleBackColor = false;
            this.btnSelectConfigFileSave.Click += new System.EventHandler(this.btnSelectConfigFile_Click);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.Color.Transparent;
            this.label75.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label75.Location = new System.Drawing.Point(22, 13);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(108, 19);
            this.label75.TabIndex = 25;
            this.label75.Text = "Save Config";
            // 
            // tabConfig
            // 
            this.tabConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabConfig.Controls.Add(this.lblConfig);
            this.tabConfig.Location = new System.Drawing.Point(257, 9);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(138, 30);
            this.tabConfig.TabIndex = 112;
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.BackColor = System.Drawing.Color.Transparent;
            this.lblConfig.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfig.ForeColor = System.Drawing.Color.White;
            this.lblConfig.Location = new System.Drawing.Point(34, 5);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(72, 19);
            this.lblConfig.TabIndex = 0;
            this.lblConfig.Text = "Ayarlar";
            // 
            // tabFeatures
            // 
            this.tabFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabFeatures.Controls.Add(this.lblFeatures);
            this.tabFeatures.Location = new System.Drawing.Point(113, 9);
            this.tabFeatures.Name = "tabFeatures";
            this.tabFeatures.Size = new System.Drawing.Size(138, 30);
            this.tabFeatures.TabIndex = 110;
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.BackColor = System.Drawing.Color.Transparent;
            this.lblFeatures.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatures.ForeColor = System.Drawing.Color.White;
            this.lblFeatures.Location = new System.Drawing.Point(22, 4);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(99, 19);
            this.lblFeatures.TabIndex = 0;
            this.lblFeatures.Text = "Özellikler";
            // 
            // lblRemoveAds
            // 
            this.lblRemoveAds.Location = new System.Drawing.Point(0, 0);
            this.lblRemoveAds.Name = "lblRemoveAds";
            this.lblRemoveAds.Size = new System.Drawing.Size(100, 23);
            this.lblRemoveAds.TabIndex = 0;
            // 
            // lblAdvertisements
            // 
            this.lblAdvertisements.AutoSize = true;
            this.lblAdvertisements.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvertisements.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertisements.ForeColor = System.Drawing.Color.White;
            this.lblAdvertisements.Location = new System.Drawing.Point(167, 45);
            this.lblAdvertisements.Name = "lblAdvertisements";
            this.lblAdvertisements.Size = new System.Drawing.Size(18, 19);
            this.lblAdvertisements.TabIndex = 8;
            this.lblAdvertisements.Text = "-";
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggedIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedIn.ForeColor = System.Drawing.Color.White;
            this.lblLoggedIn.Location = new System.Drawing.Point(121, 15);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(18, 19);
            this.lblLoggedIn.TabIndex = 7;
            this.lblLoggedIn.Text = "-";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnLogout.Location = new System.Drawing.Point(24, 76);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(219, 27);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPreAdvertisements
            // 
            this.lblPreAdvertisements.AutoSize = true;
            this.lblPreAdvertisements.BackColor = System.Drawing.Color.Transparent;
            this.lblPreAdvertisements.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreAdvertisements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblPreAdvertisements.Location = new System.Drawing.Point(23, 45);
            this.lblPreAdvertisements.Name = "lblPreAdvertisements";
            this.lblPreAdvertisements.Size = new System.Drawing.Size(144, 19);
            this.lblPreAdvertisements.TabIndex = 2;
            this.lblPreAdvertisements.Text = "Advertisements:";
            // 
            // lblPreLoggedIn
            // 
            this.lblPreLoggedIn.AutoSize = true;
            this.lblPreLoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.lblPreLoggedIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreLoggedIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblPreLoggedIn.Location = new System.Drawing.Point(23, 15);
            this.lblPreLoggedIn.Name = "lblPreLoggedIn";
            this.lblPreLoggedIn.Size = new System.Drawing.Size(99, 19);
            this.lblPreLoggedIn.TabIndex = 1;
            this.lblPreLoggedIn.Text = "Logged in:";
            // 
            // pnlCompile
            // 
            this.pnlCompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlCompile.Controls.Add(this.panel11);
            this.pnlCompile.Controls.Add(this.btnCompile);
            this.pnlCompile.Controls.Add(this.btnSelectFile);
            this.pnlCompile.Controls.Add(this.label5);
            this.pnlCompile.Controls.Add(this.txt_build_path);
            this.pnlCompile.Location = new System.Drawing.Point(190, 63);
            this.pnlCompile.Name = "pnlCompile";
            this.pnlCompile.Size = new System.Drawing.Size(495, 300);
            this.pnlCompile.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.txtLog);
            this.panel11.Location = new System.Drawing.Point(33, 24);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(426, 191);
            this.panel11.TabIndex = 104;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtLog.Location = new System.Drawing.Point(-1, 0);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(426, 190);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // btnCompile
            // 
            this.btnCompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCompile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnCompile.Location = new System.Drawing.Point(33, 253);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(428, 40);
            this.btnCompile.TabIndex = 103;
            this.btnCompile.Text = "Derle";
            this.btnCompile.UseVisualStyleBackColor = false;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectFile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSelectFile.Location = new System.Drawing.Point(417, 225);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(46, 21);
            this.btnSelectFile.TabIndex = 102;
            this.btnSelectFile.Text = "Seç";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 101;
            this.label5.Text = "Dosya Yolu:";
            // 
            // txt_build_path
            // 
            this.txt_build_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_build_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_build_path.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_build_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_build_path.Location = new System.Drawing.Point(123, 225);
            this.txt_build_path.Name = "txt_build_path";
            this.txt_build_path.Size = new System.Drawing.Size(288, 20);
            this.txt_build_path.TabIndex = 2;
            this.txt_build_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_build_path.TextChanged += new System.EventHandler(this.txt_build_path_TextChanged);
            // 
            // sfd
            // 
            this.sfd.Filter = "*.exe |.exe";
            // 
            // tabAimbot
            // 
            this.tabAimbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabAimbot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAimbot.Controls.Add(this.lblAimbot);
            this.tabAimbot.Location = new System.Drawing.Point(37, 136);
            this.tabAimbot.Name = "tabAimbot";
            this.tabAimbot.Size = new System.Drawing.Size(136, 43);
            this.tabAimbot.TabIndex = 2;
            // 
            // lblAimbot
            // 
            this.lblAimbot.AutoSize = true;
            this.lblAimbot.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAimbot.ForeColor = System.Drawing.Color.White;
            this.lblAimbot.Location = new System.Drawing.Point(30, 9);
            this.lblAimbot.Name = "lblAimbot";
            this.lblAimbot.Size = new System.Drawing.Size(73, 25);
            this.lblAimbot.TabIndex = 1;
            this.lblAimbot.Text = "Aimbot";
            // 
            // pnlAimbot
            // 
            this.pnlAimbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAimbot.Controls.Add(this.label39);
            this.pnlAimbot.Controls.Add(this.nud_aimbot_thread_delay);
            this.pnlAimbot.Controls.Add(this.label40);
            this.pnlAimbot.Controls.Add(this.cb_aimbot_enabled);
            this.pnlAimbot.Controls.Add(this.label41);
            this.pnlAimbot.Controls.Add(this.panel15);
            this.pnlAimbot.Controls.Add(this.panel16);
            this.pnlAimbot.Location = new System.Drawing.Point(190, 63);
            this.pnlAimbot.Name = "pnlAimbot";
            this.pnlAimbot.Size = new System.Drawing.Size(495, 300);
            this.pnlAimbot.TabIndex = 25;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(366, 13);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 13);
            this.label39.TabIndex = 24;
            this.label39.Text = "(ms)";
            this.label39.Visible = false;
            // 
            // nud_aimbot_thread_delay
            // 
            this.nud_aimbot_thread_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_aimbot_thread_delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_aimbot_thread_delay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_aimbot_thread_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_aimbot_thread_delay.Location = new System.Drawing.Point(280, 10);
            this.nud_aimbot_thread_delay.Name = "nud_aimbot_thread_delay";
            this.nud_aimbot_thread_delay.Size = new System.Drawing.Size(80, 20);
            this.nud_aimbot_thread_delay.TabIndex = 23;
            this.nud_aimbot_thread_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_aimbot_thread_delay.Visible = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(165, 13);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(106, 13);
            this.label40.TabIndex = 22;
            this.label40.Text = "| Çalışma Gecikmesi";
            this.label40.Visible = false;
            // 
            // cb_aimbot_enabled
            // 
            this.cb_aimbot_enabled.AutoSize = true;
            this.cb_aimbot_enabled.Location = new System.Drawing.Point(113, 15);
            this.cb_aimbot_enabled.Name = "cb_aimbot_enabled";
            this.cb_aimbot_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_aimbot_enabled.TabIndex = 21;
            this.cb_aimbot_enabled.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(66, 15);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(44, 13);
            this.label41.TabIndex = 20;
            this.label41.Text = "Aktif Et";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.cmb_aimbot_type);
            this.panel15.Controls.Add(this.label42);
            this.panel15.Location = new System.Drawing.Point(65, 37);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(371, 32);
            this.panel15.TabIndex = 18;
            // 
            // cmb_aimbot_type
            // 
            this.cmb_aimbot_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_aimbot_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_aimbot_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_aimbot_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_aimbot_type.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_aimbot_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cmb_aimbot_type.FormattingEnabled = true;
            this.cmb_aimbot_type.Items.AddRange(new object[] {
            "general",
            "pistols",
            "snipers"});
            this.cmb_aimbot_type.Location = new System.Drawing.Point(139, 4);
            this.cmb_aimbot_type.Name = "cmb_aimbot_type";
            this.cmb_aimbot_type.Size = new System.Drawing.Size(131, 21);
            this.cmb_aimbot_type.TabIndex = 105;
            this.cmb_aimbot_type.TabStop = false;
            this.cmb_aimbot_type.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label42.Location = new System.Drawing.Point(47, 4);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(85, 20);
            this.label42.TabIndex = 0;
            this.label42.Text = "Silah Grubu";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.cmb_aimbot_bone);
            this.panel16.Controls.Add(this.label50);
            this.panel16.Controls.Add(this.cb_aimbot_rcs);
            this.panel16.Controls.Add(this.label47);
            this.panel16.Controls.Add(this.label43);
            this.panel16.Controls.Add(this.cb_aimbot_target_enemies);
            this.panel16.Controls.Add(this.txt_aimbot_key);
            this.panel16.Controls.Add(this.label44);
            this.panel16.Controls.Add(this.cb_aimbot_target_teammates);
            this.panel16.Controls.Add(this.label45);
            this.panel16.Controls.Add(this.label46);
            this.panel16.Controls.Add(this.cb_aimbot_onkey);
            this.panel16.Controls.Add(this.nud_aimbot_smooth);
            this.panel16.Controls.Add(this.label48);
            this.panel16.Controls.Add(this.label49);
            this.panel16.Controls.Add(this.nud_aimbot_fov);
            this.panel16.Location = new System.Drawing.Point(65, 71);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(371, 208);
            this.panel16.TabIndex = 19;
            // 
            // cmb_aimbot_bone
            // 
            this.cmb_aimbot_bone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_aimbot_bone.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_aimbot_bone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_aimbot_bone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_aimbot_bone.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_aimbot_bone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cmb_aimbot_bone.FormattingEnabled = true;
            this.cmb_aimbot_bone.Items.AddRange(new object[] {
            "nearest",
            "head",
            "neck",
            "upper chest",
            "middle chest",
            "lower chest"});
            this.cmb_aimbot_bone.Location = new System.Drawing.Point(118, 51);
            this.cmb_aimbot_bone.Name = "cmb_aimbot_bone";
            this.cmb_aimbot_bone.Size = new System.Drawing.Size(131, 21);
            this.cmb_aimbot_bone.TabIndex = 104;
            this.cmb_aimbot_bone.TabStop = false;
            this.cmb_aimbot_bone.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(71, 53);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(38, 13);
            this.label50.TabIndex = 103;
            this.label50.Text = "Hedef";
            // 
            // cb_aimbot_rcs
            // 
            this.cb_aimbot_rcs.AutoSize = true;
            this.cb_aimbot_rcs.Checked = true;
            this.cb_aimbot_rcs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_aimbot_rcs.Location = new System.Drawing.Point(134, 143);
            this.cb_aimbot_rcs.Name = "cb_aimbot_rcs";
            this.cb_aimbot_rcs.Size = new System.Drawing.Size(15, 14);
            this.cb_aimbot_rcs.TabIndex = 21;
            this.cb_aimbot_rcs.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(40, 144);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(88, 13);
            this.label47.TabIndex = 20;
            this.label47.Text = "Sekme Kontrolü";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(4, 7);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(129, 13);
            this.label43.TabIndex = 6;
            this.label43.Text = "Tuşa basınca aktif olsun";
            // 
            // cb_aimbot_target_enemies
            // 
            this.cb_aimbot_target_enemies.AutoSize = true;
            this.cb_aimbot_target_enemies.Checked = true;
            this.cb_aimbot_target_enemies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_aimbot_target_enemies.Location = new System.Drawing.Point(104, 185);
            this.cb_aimbot_target_enemies.Name = "cb_aimbot_target_enemies";
            this.cb_aimbot_target_enemies.Size = new System.Drawing.Size(15, 14);
            this.cb_aimbot_target_enemies.TabIndex = 17;
            this.cb_aimbot_target_enemies.UseVisualStyleBackColor = true;
            // 
            // txt_aimbot_key
            // 
            this.txt_aimbot_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_aimbot_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_aimbot_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_aimbot_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_aimbot_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_aimbot_key.Location = new System.Drawing.Point(118, 26);
            this.txt_aimbot_key.Name = "txt_aimbot_key";
            this.txt_aimbot_key.ReadOnly = true;
            this.txt_aimbot_key.ShortcutsEnabled = false;
            this.txt_aimbot_key.Size = new System.Drawing.Size(131, 20);
            this.txt_aimbot_key.TabIndex = 2;
            this.txt_aimbot_key.TabStop = false;
            this.txt_aimbot_key.Text = "Mouse 1 [0x1]";
            this.txt_aimbot_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(36, 164);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(94, 13);
            this.label44.TabIndex = 16;
            this.label44.Text = "Takım arkadaşları";
            // 
            // cb_aimbot_target_teammates
            // 
            this.cb_aimbot_target_teammates.AutoSize = true;
            this.cb_aimbot_target_teammates.Location = new System.Drawing.Point(134, 164);
            this.cb_aimbot_target_teammates.Name = "cb_aimbot_target_teammates";
            this.cb_aimbot_target_teammates.Size = new System.Drawing.Size(15, 14);
            this.cb_aimbot_target_teammates.TabIndex = 15;
            this.cb_aimbot_target_teammates.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(37, 184);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(62, 13);
            this.label45.TabIndex = 14;
            this.label45.Text = "Düşmanlar";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(87, 29);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(23, 13);
            this.label46.TabIndex = 5;
            this.label46.Text = "Tuş";
            // 
            // cb_aimbot_onkey
            // 
            this.cb_aimbot_onkey.AutoSize = true;
            this.cb_aimbot_onkey.Location = new System.Drawing.Point(135, 7);
            this.cb_aimbot_onkey.Name = "cb_aimbot_onkey";
            this.cb_aimbot_onkey.Size = new System.Drawing.Size(15, 14);
            this.cb_aimbot_onkey.TabIndex = 7;
            this.cb_aimbot_onkey.UseVisualStyleBackColor = true;
            // 
            // nud_aimbot_smooth
            // 
            this.nud_aimbot_smooth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_aimbot_smooth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_aimbot_smooth.DecimalPlaces = 1;
            this.nud_aimbot_smooth.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_aimbot_smooth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_aimbot_smooth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_aimbot_smooth.Location = new System.Drawing.Point(118, 102);
            this.nud_aimbot_smooth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nud_aimbot_smooth.Name = "nud_aimbot_smooth";
            this.nud_aimbot_smooth.Size = new System.Drawing.Size(131, 20);
            this.nud_aimbot_smooth.TabIndex = 12;
            this.nud_aimbot_smooth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_aimbot_smooth.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(87, 81);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(29, 13);
            this.label48.TabIndex = 8;
            this.label48.Text = "FOV";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(51, 106);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(63, 13);
            this.label49.TabIndex = 11;
            this.label49.Text = "Yumuşaklık";
            // 
            // nud_aimbot_fov
            // 
            this.nud_aimbot_fov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_aimbot_fov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_aimbot_fov.DecimalPlaces = 1;
            this.nud_aimbot_fov.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_aimbot_fov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nud_aimbot_fov.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_aimbot_fov.Location = new System.Drawing.Point(118, 77);
            this.nud_aimbot_fov.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.nud_aimbot_fov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_aimbot_fov.Name = "nud_aimbot_fov";
            this.nud_aimbot_fov.Size = new System.Drawing.Size(131, 20);
            this.nud_aimbot_fov.TabIndex = 9;
            this.nud_aimbot_fov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_aimbot_fov.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tip.IsBalloon = true;
            // 
            // ofd
            // 
            this.ofd.Filter = "*.dpm |.dpm";
            // 
            // txtDummy
            // 
            this.txtDummy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDummy.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDummy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtDummy.Location = new System.Drawing.Point(-2, -26);
            this.txtDummy.Name = "txtDummy";
            this.txtDummy.ReadOnly = true;
            this.txtDummy.Size = new System.Drawing.Size(10, 20);
            this.txtDummy.TabIndex = 8;
            this.txtDummy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DestroyPremium.Properties.newres.pictureBox1;
            this.pictureBox1.Location = new System.Drawing.Point(26, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(695, 392);
            this.Controls.Add(this.pnlCompile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMisc);
            this.Controls.Add(this.pnlVisuals);
            this.Controls.Add(this.pnlTriggerbot);
            this.Controls.Add(this.pnlAimbot);
            this.Controls.Add(this.tabAimbot);
            this.Controls.Add(this.txtDummy);
            this.Controls.Add(this.tabCompile);
            this.Controls.Add(this.tabMisc);
            this.Controls.Add(this.tabVisuals);
            this.Controls.Add(this.tabTriggerbot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DestroyPremium cracked by exelent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabTriggerbot.ResumeLayout(false);
            this.tabTriggerbot.PerformLayout();
            this.tabVisuals.ResumeLayout(false);
            this.tabVisuals.PerformLayout();
            this.tabMisc.ResumeLayout(false);
            this.tabMisc.PerformLayout();
            this.tabCompile.ResumeLayout(false);
            this.tabCompile.PerformLayout();
            this.pnlTriggerbot.ResumeLayout(false);
            this.pnlTriggerbot.PerformLayout();
            this.pnlTrigger1.ResumeLayout(false);
            this.pnlTrigger1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_overshoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_delay)).EndInit();
            this.pnlTrigger2.ResumeLayout(false);
            this.pnlTrigger2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_magnet_smooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_magnet_fov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_thread_delay)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlVisuals.ResumeLayout(false);
            this.pnlVisuals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_thread_delay)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_enemies_glowalpha)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_teammates_glowalpha)).EndInit();
            this.pnlMisc.ResumeLayout(false);
            this.pnlFeatures.ResumeLayout(false);
            this.pnlFeatures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fov_changer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rcs_x_percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rcs_y_percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_noflash_percent)).EndInit();
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfigFile.ResumeLayout(false);
            this.pnlConfigFile.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.tabFeatures.ResumeLayout(false);
            this.tabFeatures.PerformLayout();
            this.pnlCompile.ResumeLayout(false);
            this.pnlCompile.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.tabAimbot.ResumeLayout(false);
            this.tabAimbot.PerformLayout();
            this.pnlAimbot.ResumeLayout(false);
            this.pnlAimbot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_thread_delay)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_smooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_fov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400006D RID: 109
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Panel tabTriggerbot;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Panel tabVisuals;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Panel tabMisc;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Panel tabCompile;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Label lblTriggerbot;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label lblVisuals;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label lblMisc;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label lblCompile;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Panel pnlTriggerbot;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Panel pnlVisuals;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Panel pnlMisc;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Panel pnlCompile;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.RichTextBox txtLog;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.TextBox txt_build_path;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Button btnSelectFile;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Button btnCompile;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.SaveFileDialog sfd;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.ListBox lbOffsets;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.ComboBox cmb_scrape_offsets;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Button btnScrapeOffsets;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Button btnChangeSelectedOffset;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Button btnManuallyModifyOffsets;

		// Token: 0x04000086 RID: 134
		public global::System.Windows.Forms.TextBox txt_trigger_key;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000088 RID: 136
		public global::System.Windows.Forms.CheckBox cb_trigger_onkey;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400008B RID: 139
		public global::System.Windows.Forms.NumericUpDown nud_trigger_delay;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400008E RID: 142
		public global::System.Windows.Forms.NumericUpDown nud_trigger_overshoot;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000090 RID: 144
		public global::System.Windows.Forms.CheckBox cb_trigger_shoot_teammates;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000092 RID: 146
		public global::System.Windows.Forms.CheckBox cb_trigger_shoot_enemies;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000094 RID: 148
		public global::System.Windows.Forms.CheckBox cb_visuals_enabled;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400009B RID: 155
		public global::System.Windows.Forms.CheckBox cb_visuals_teammates_enabled;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Label label16;

		// Token: 0x0400009D RID: 157
		public global::System.Windows.Forms.CheckBox cb_visuals_teammates_visibleonly;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Label label17;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040000A0 RID: 160
		public global::System.Windows.Forms.Label lbl_visuals_teammates_color;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Label label20;

		// Token: 0x040000A2 RID: 162
		public global::System.Windows.Forms.NumericUpDown nud_visuals_teammates_glowalpha;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.ColorDialog cd;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Panel pnlTrigger1;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Label label26;

		// Token: 0x040000A9 RID: 169
		public global::System.Windows.Forms.NumericUpDown nud_visuals_thread_delay;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Label label22;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000AC RID: 172
		public global::System.Windows.Forms.NumericUpDown nud_trigger_thread_delay;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.Label label27;

		// Token: 0x040000AE RID: 174
		public global::System.Windows.Forms.CheckBox cb_trigger_enabled;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Label label28;

		// Token: 0x040000B0 RID: 176
		public global::System.Windows.Forms.TextBox txt_bhop_key;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Label label29;

		// Token: 0x040000B2 RID: 178
		public global::System.Windows.Forms.CheckBox cb_bhop_enabled;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.Panel panel11;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.Label label38;

		// Token: 0x040000B6 RID: 182
		public global::System.Windows.Forms.NumericUpDown nud_rcs_y_percent;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.Label label37;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Label label36;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Label label34;

		// Token: 0x040000BA RID: 186
		public global::System.Windows.Forms.NumericUpDown nud_rcs_x_percent;

		// Token: 0x040000BB RID: 187
		public global::System.Windows.Forms.CheckBox cb_rcs_enabled;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.Label label35;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.Label label30;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.Label label32;

		// Token: 0x040000BF RID: 191
		public global::System.Windows.Forms.NumericUpDown nud_noflash_percent;

		// Token: 0x040000C0 RID: 192
		public global::System.Windows.Forms.CheckBox cb_noflash_enabled;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.Label label31;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Panel tabAimbot;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.Label lblAimbot;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.Panel pnlAimbot;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Label label39;

		// Token: 0x040000C6 RID: 198
		public global::System.Windows.Forms.NumericUpDown nud_aimbot_thread_delay;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.Label label40;

		// Token: 0x040000C8 RID: 200
		public global::System.Windows.Forms.CheckBox cb_aimbot_enabled;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.Label label41;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.Panel panel15;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Label label42;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Panel panel16;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.Label label43;

		// Token: 0x040000CE RID: 206
		public global::System.Windows.Forms.CheckBox cb_aimbot_target_enemies;

		// Token: 0x040000CF RID: 207
		public global::System.Windows.Forms.TextBox txt_aimbot_key;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.Label label44;

		// Token: 0x040000D1 RID: 209
		public global::System.Windows.Forms.CheckBox cb_aimbot_target_teammates;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.Label label45;

		// Token: 0x040000D3 RID: 211
		public global::System.Windows.Forms.CheckBox cb_aimbot_onkey;

		// Token: 0x040000D4 RID: 212
		public global::System.Windows.Forms.NumericUpDown nud_aimbot_smooth;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Label label48;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Label label49;

		// Token: 0x040000D7 RID: 215
		public global::System.Windows.Forms.NumericUpDown nud_aimbot_fov;

		// Token: 0x040000D8 RID: 216
		public global::System.Windows.Forms.CheckBox cb_aimbot_rcs;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Label label47;

		// Token: 0x040000DA RID: 218
		public global::System.Windows.Forms.ComboBox cmb_aimbot_bone;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.Label label50;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Label label53;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Label label33;

		// Token: 0x040000DE RID: 222
		public global::System.Windows.Forms.CheckBox cb_radar_enabled;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Label label52;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.ToolTip tip;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.OpenFileDialog ofd;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.Panel pnlFeatures;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Panel tabFeatures;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Label lblFeatures;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Label label46;

		// Token: 0x040000E6 RID: 230
		public global::System.Windows.Forms.ComboBox cmb_aimbot_type;

		// Token: 0x040000E7 RID: 231
		public global::System.Windows.Forms.ComboBox cmb_triggerbot_type;

		// Token: 0x040000E8 RID: 232
		public global::System.Windows.Forms.CheckBox cb_trigger_magnetic;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Label label60;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.Label lblCustomizeTriggerMagnetic;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.Panel pnlTrigger2;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.Label lblBackToTrigger;

		// Token: 0x040000ED RID: 237
		public global::System.Windows.Forms.ComboBox cmb_trigger_magnet_bone;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.Label label62;

		// Token: 0x040000EF RID: 239
		public global::System.Windows.Forms.NumericUpDown nud_trigger_magnet_smooth;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.Label label63;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.Label label64;

		// Token: 0x040000F2 RID: 242
		public global::System.Windows.Forms.NumericUpDown nud_trigger_magnet_fov;

		// Token: 0x040000F3 RID: 243
		private global::System.Windows.Forms.Label label61;

		// Token: 0x040000F4 RID: 244
		private global::System.Windows.Forms.Panel tabConfig;

		// Token: 0x040000F5 RID: 245
		private global::System.Windows.Forms.Label lblConfig;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.Panel pnlConfig;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.Label label57;

		// Token: 0x040000F8 RID: 248
		public global::System.Windows.Forms.NumericUpDown nud_fov_changer;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.Label label58;

		// Token: 0x040000FA RID: 250
		public global::System.Windows.Forms.CheckBox cb_fov_changer;

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.Panel pnlConfigFile;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.Label label72;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.TextBox txtConfigFileLoad;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.Label label73;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.Label label74;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.TextBox txtConfigFileSave;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.Button btnSelectConfigFileSave;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.Label label75;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.Button btnSaveConfigFile;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.Button btnLoadConfigFile;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.Button btnSelectConfigFileLoad;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.Label lblPreAdvertisements;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.Label lblPreLoggedIn;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.Button btnLogout;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.Label lblLoggedIn;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.Label lblAdvertisements;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.Label lblRemoveAds;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400010D RID: 269
		public global::System.Windows.Forms.CheckBox cb_visuals_enemies_healthbased;

		// Token: 0x0400010E RID: 270
		public global::System.Windows.Forms.NumericUpDown nud_visuals_enemies_glowalpha;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000110 RID: 272
		public global::System.Windows.Forms.Label lbl_visuals_enemies_color;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04000112 RID: 274
		public global::System.Windows.Forms.CheckBox cb_visuals_enemies_visibleonly;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.Label label80;

		// Token: 0x04000114 RID: 276
		public global::System.Windows.Forms.CheckBox cb_visuals_enemies_enabled;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.Label label81;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.Label label59;

		// Token: 0x04000117 RID: 279
		public global::System.Windows.Forms.CheckBox cb_visuals_teammates_healthbased;

		// Token: 0x04000118 RID: 280
		public global::System.Windows.Forms.TextBox txtDummy;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
