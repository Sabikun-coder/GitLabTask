namespace RetroRides.Forms.Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.top_panel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.applabel = new System.Windows.Forms.Label();
            this.min_btn = new System.Windows.Forms.Button();
            this.max_btn = new System.Windows.Forms.Button();
            this.cross_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.slideshowTimer = new System.Windows.Forms.Timer(this.components);
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.logout_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.settings_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.booking_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.galleryPicBox = new System.Windows.Forms.PictureBox();
            this.view_gallery_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ChooseModel = new System.Windows.Forms.LinkLabel();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryPicBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Black;
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.top_panel.Controls.Add(this.pictureBox3);
            this.top_panel.Controls.Add(this.applabel);
            this.top_panel.Controls.Add(this.min_btn);
            this.top_panel.Controls.Add(this.max_btn);
            this.top_panel.Controls.Add(this.cross_btn);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.ForeColor = System.Drawing.Color.Black;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1200, 35);
            this.top_panel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RetroRides.Properties.Resources.panelicon;
            this.pictureBox3.Location = new System.Drawing.Point(2, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // applabel
            // 
            this.applabel.AutoSize = true;
            this.applabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.applabel.Location = new System.Drawing.Point(35, 7);
            this.applabel.Name = "applabel";
            this.applabel.Size = new System.Drawing.Size(79, 23);
            this.applabel.TabIndex = 5;
            this.applabel.Text = "RetroRides";
            // 
            // min_btn
            // 
            this.min_btn.BackColor = System.Drawing.Color.Transparent;
            this.min_btn.BackgroundImage = global::RetroRides.Properties.Resources.Minimize_Window;
            this.min_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.min_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.min_btn.FlatAppearance.BorderSize = 0;
            this.min_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_btn.Location = new System.Drawing.Point(1130, 0);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(23, 35);
            this.min_btn.TabIndex = 2;
            this.min_btn.TabStop = false;
            this.min_btn.UseVisualStyleBackColor = false;
            this.min_btn.Click += new System.EventHandler(this.min_btn_Click);
            // 
            // max_btn
            // 
            this.max_btn.BackColor = System.Drawing.Color.Transparent;
            this.max_btn.BackgroundImage = global::RetroRides.Properties.Resources.Maximize_Button;
            this.max_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.max_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.max_btn.FlatAppearance.BorderSize = 0;
            this.max_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.max_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.max_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.max_btn.Location = new System.Drawing.Point(1153, 0);
            this.max_btn.Name = "max_btn";
            this.max_btn.Size = new System.Drawing.Size(22, 35);
            this.max_btn.TabIndex = 1;
            this.max_btn.TabStop = false;
            this.max_btn.UseVisualStyleBackColor = false;
            // 
            // cross_btn
            // 
            this.cross_btn.BackColor = System.Drawing.Color.Transparent;
            this.cross_btn.BackgroundImage = global::RetroRides.Properties.Resources.Close_Window;
            this.cross_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cross_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cross_btn.FlatAppearance.BorderSize = 0;
            this.cross_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cross_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cross_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross_btn.ForeColor = System.Drawing.Color.Transparent;
            this.cross_btn.Location = new System.Drawing.Point(1175, 0);
            this.cross_btn.Name = "cross_btn";
            this.cross_btn.Size = new System.Drawing.Size(25, 35);
            this.cross_btn.TabIndex = 0;
            this.cross_btn.TabStop = false;
            this.cross_btn.UseVisualStyleBackColor = false;
            this.cross_btn.Click += new System.EventHandler(this.cross_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(201, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 358);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.settings_btn);
            this.panel1.Controls.Add(this.booking_btn);
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 665);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RetroRides.Properties.Resources.Home;
            this.pictureBox4.Location = new System.Drawing.Point(70, 266);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(43, 474);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.logout_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.logout_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.logout_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.logout_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.logout_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.logout_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logout_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_btn.OverrideDefault.Border.Rounding = 20;
            this.logout_btn.OverrideDefault.Border.Width = 1;
            this.logout_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.logout_btn.Size = new System.Drawing.Size(101, 39);
            this.logout_btn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.logout_btn.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.logout_btn.StateCommon.Back.ColorAngle = 45F;
            this.logout_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.logout_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.logout_btn.StateCommon.Border.ColorAngle = 45F;
            this.logout_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logout_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_btn.StateCommon.Border.Rounding = 20;
            this.logout_btn.StateCommon.Border.Width = 1;
            this.logout_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.logout_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.logout_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.logout_btn.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.logout_btn.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.logout_btn.StatePressed.Back.ColorAngle = 130F;
            this.logout_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_btn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.logout_btn.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.logout_btn.StatePressed.Border.ColorAngle = 130F;
            this.logout_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logout_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_btn.StatePressed.Border.Rounding = 20;
            this.logout_btn.StatePressed.Border.Width = 1;
            this.logout_btn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.logout_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.logout_btn.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.logout_btn.StateTracking.Back.ColorAngle = 45F;
            this.logout_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.logout_btn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.logout_btn.StateTracking.Border.ColorAngle = 45F;
            this.logout_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logout_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_btn.StateTracking.Border.Rounding = 20;
            this.logout_btn.StateTracking.Border.Width = 1;
            this.logout_btn.TabIndex = 4;
            this.logout_btn.TabStop = false;
            this.logout_btn.Values.Text = "Logout";
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.Location = new System.Drawing.Point(17, 397);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.settings_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.settings_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.settings_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.settings_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.settings_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.settings_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.settings_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.settings_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.settings_btn.OverrideDefault.Border.Rounding = 20;
            this.settings_btn.OverrideDefault.Border.Width = 1;
            this.settings_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.settings_btn.Size = new System.Drawing.Size(155, 47);
            this.settings_btn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.settings_btn.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.settings_btn.StateCommon.Back.ColorAngle = 45F;
            this.settings_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.settings_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.settings_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.settings_btn.StateCommon.Border.ColorAngle = 45F;
            this.settings_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.settings_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.settings_btn.StateCommon.Border.Rounding = 20;
            this.settings_btn.StateCommon.Border.Width = 1;
            this.settings_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.settings_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.settings_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_btn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.settings_btn.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.settings_btn.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.settings_btn.StatePressed.Back.ColorAngle = 130F;
            this.settings_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.settings_btn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.settings_btn.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.settings_btn.StatePressed.Border.ColorAngle = 130F;
            this.settings_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.settings_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.settings_btn.StatePressed.Border.Rounding = 20;
            this.settings_btn.StatePressed.Border.Width = 1;
            this.settings_btn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.settings_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.settings_btn.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.settings_btn.StateTracking.Back.ColorAngle = 45F;
            this.settings_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.settings_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.settings_btn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.settings_btn.StateTracking.Border.ColorAngle = 45F;
            this.settings_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.settings_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.settings_btn.StateTracking.Border.Rounding = 20;
            this.settings_btn.StateTracking.Border.Width = 1;
            this.settings_btn.TabIndex = 4;
            this.settings_btn.Values.Text = "Settings";
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // booking_btn
            // 
            this.booking_btn.Location = new System.Drawing.Point(17, 323);
            this.booking_btn.Name = "booking_btn";
            this.booking_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.booking_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.booking_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.booking_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.booking_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.booking_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.booking_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.booking_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.booking_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.booking_btn.OverrideDefault.Border.Rounding = 20;
            this.booking_btn.OverrideDefault.Border.Width = 1;
            this.booking_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.booking_btn.Size = new System.Drawing.Size(155, 47);
            this.booking_btn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.booking_btn.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.booking_btn.StateCommon.Back.ColorAngle = 45F;
            this.booking_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.booking_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.booking_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.booking_btn.StateCommon.Border.ColorAngle = 45F;
            this.booking_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.booking_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.booking_btn.StateCommon.Border.Rounding = 20;
            this.booking_btn.StateCommon.Border.Width = 1;
            this.booking_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.booking_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.booking_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_btn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.booking_btn.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.booking_btn.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.booking_btn.StatePressed.Back.ColorAngle = 130F;
            this.booking_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.booking_btn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.booking_btn.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.booking_btn.StatePressed.Border.ColorAngle = 130F;
            this.booking_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.booking_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.booking_btn.StatePressed.Border.Rounding = 20;
            this.booking_btn.StatePressed.Border.Width = 1;
            this.booking_btn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.booking_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.booking_btn.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.booking_btn.StateTracking.Back.ColorAngle = 45F;
            this.booking_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.booking_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.booking_btn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.booking_btn.StateTracking.Border.ColorAngle = 45F;
            this.booking_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.booking_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.booking_btn.StateTracking.Border.Rounding = 20;
            this.booking_btn.StateTracking.Border.Width = 1;
            this.booking_btn.TabIndex = 4;
            this.booking_btn.Values.Text = "Bookings";
            this.booking_btn.Click += new System.EventHandler(this.booking_btn_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.welcomeLabel.Location = new System.Drawing.Point(24, 186);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(131, 28);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome MSG";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.galleryPicBox);
            this.panel2.Controls.Add(this.view_gallery_btn);
            this.panel2.Location = new System.Drawing.Point(829, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 438);
            this.panel2.TabIndex = 4;
            // 
            // galleryPicBox
            // 
            this.galleryPicBox.Image = global::RetroRides.Properties.Resources.Gallerypicbox;
            this.galleryPicBox.Location = new System.Drawing.Point(89, 380);
            this.galleryPicBox.Name = "galleryPicBox";
            this.galleryPicBox.Size = new System.Drawing.Size(33, 39);
            this.galleryPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.galleryPicBox.TabIndex = 5;
            this.galleryPicBox.TabStop = false;
            // 
            // view_gallery_btn
            // 
            this.view_gallery_btn.Location = new System.Drawing.Point(129, 376);
            this.view_gallery_btn.Name = "view_gallery_btn";
            this.view_gallery_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.view_gallery_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.view_gallery_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.view_gallery_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.view_gallery_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.view_gallery_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.view_gallery_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.view_gallery_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.view_gallery_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.view_gallery_btn.OverrideDefault.Border.Rounding = 20;
            this.view_gallery_btn.OverrideDefault.Border.Width = 1;
            this.view_gallery_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.view_gallery_btn.Size = new System.Drawing.Size(133, 45);
            this.view_gallery_btn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.view_gallery_btn.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.view_gallery_btn.StateCommon.Back.ColorAngle = 45F;
            this.view_gallery_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.view_gallery_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.view_gallery_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.view_gallery_btn.StateCommon.Border.ColorAngle = 45F;
            this.view_gallery_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.view_gallery_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.view_gallery_btn.StateCommon.Border.Rounding = 20;
            this.view_gallery_btn.StateCommon.Border.Width = 1;
            this.view_gallery_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.view_gallery_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.view_gallery_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_gallery_btn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.view_gallery_btn.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.view_gallery_btn.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.view_gallery_btn.StatePressed.Back.ColorAngle = 130F;
            this.view_gallery_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.view_gallery_btn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.view_gallery_btn.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.view_gallery_btn.StatePressed.Border.ColorAngle = 130F;
            this.view_gallery_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.view_gallery_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.view_gallery_btn.StatePressed.Border.Rounding = 20;
            this.view_gallery_btn.StatePressed.Border.Width = 1;
            this.view_gallery_btn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.view_gallery_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.view_gallery_btn.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.view_gallery_btn.StateTracking.Back.ColorAngle = 45F;
            this.view_gallery_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.view_gallery_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.view_gallery_btn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.view_gallery_btn.StateTracking.Border.ColorAngle = 45F;
            this.view_gallery_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.view_gallery_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.view_gallery_btn.StateTracking.Border.Rounding = 20;
            this.view_gallery_btn.StateTracking.Border.Width = 1;
            this.view_gallery_btn.TabIndex = 3;
            this.view_gallery_btn.Values.Text = "View Gallery";
            this.view_gallery_btn.Click += new System.EventHandler(this.view_gallery_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.ChooseModel);
            this.panel3.Location = new System.Drawing.Point(214, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 198);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RetroRides.Properties.Resources.Up_Right;
            this.pictureBox2.Location = new System.Drawing.Point(212, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ChooseModel
            // 
            this.ChooseModel.AutoSize = true;
            this.ChooseModel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseModel.LinkColor = System.Drawing.Color.White;
            this.ChooseModel.Location = new System.Drawing.Point(60, 105);
            this.ChooseModel.Name = "ChooseModel";
            this.ChooseModel.Size = new System.Drawing.Size(148, 20);
            this.ChooseModel.TabIndex = 0;
            this.ChooseModel.TabStop = true;
            this.ChooseModel.Text = "Choose your models!";
            this.ChooseModel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChooseModel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImage = global::RetroRides.Properties.Resources.MainForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.top_panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetroRides";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryPicBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button min_btn;
        private System.Windows.Forms.Button max_btn;
        private System.Windows.Forms.Button cross_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer slideshowTimer;
        private System.Windows.Forms.Timer slideTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel ChooseModel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton view_gallery_btn;
        private System.Windows.Forms.Label welcomeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton settings_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton booking_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton logout_btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label applabel;
        private System.Windows.Forms.PictureBox galleryPicBox;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}