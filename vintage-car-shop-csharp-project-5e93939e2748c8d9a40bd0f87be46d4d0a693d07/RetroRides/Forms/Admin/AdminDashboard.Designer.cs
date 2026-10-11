namespace RetroRides.Forms.Admin
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.top_panel = new System.Windows.Forms.Panel();
            this.applabelpic = new System.Windows.Forms.PictureBox();
            this.applabel = new System.Windows.Forms.Label();
            this.min_btn = new System.Windows.Forms.Button();
            this.max_btn = new System.Windows.Forms.Button();
            this.cross_btn = new System.Windows.Forms.Button();
            this.client_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bookings_info = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.car_info = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.logout_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.admin_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applabelpic)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Black;
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.top_panel.Controls.Add(this.applabelpic);
            this.top_panel.Controls.Add(this.applabel);
            this.top_panel.Controls.Add(this.min_btn);
            this.top_panel.Controls.Add(this.max_btn);
            this.top_panel.Controls.Add(this.cross_btn);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.ForeColor = System.Drawing.Color.Black;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1200, 35);
            this.top_panel.TabIndex = 4;
            // 
            // applabelpic
            // 
            this.applabelpic.Image = global::RetroRides.Properties.Resources.panelicon;
            this.applabelpic.Location = new System.Drawing.Point(2, 4);
            this.applabelpic.Name = "applabelpic";
            this.applabelpic.Size = new System.Drawing.Size(35, 29);
            this.applabelpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.applabelpic.TabIndex = 6;
            this.applabelpic.TabStop = false;
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
            // client_btn
            // 
            this.client_btn.Location = new System.Drawing.Point(106, 450);
            this.client_btn.Name = "client_btn";
            this.client_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.client_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.client_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.client_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.client_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.client_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.client_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.client_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.client_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.client_btn.OverrideDefault.Border.Rounding = 20;
            this.client_btn.OverrideDefault.Border.Width = 1;
            this.client_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.client_btn.Size = new System.Drawing.Size(199, 41);
            this.client_btn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.client_btn.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.client_btn.StateCommon.Back.ColorAngle = 45F;
            this.client_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.client_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.client_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.client_btn.StateCommon.Border.ColorAngle = 45F;
            this.client_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.client_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.client_btn.StateCommon.Border.Rounding = 20;
            this.client_btn.StateCommon.Border.Width = 1;
            this.client_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.client_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.client_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_btn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.client_btn.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.client_btn.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.client_btn.StatePressed.Back.ColorAngle = 130F;
            this.client_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.client_btn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.client_btn.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.client_btn.StatePressed.Border.ColorAngle = 130F;
            this.client_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.client_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.client_btn.StatePressed.Border.Rounding = 20;
            this.client_btn.StatePressed.Border.Width = 1;
            this.client_btn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.client_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.client_btn.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.client_btn.StateTracking.Back.ColorAngle = 45F;
            this.client_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.client_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.client_btn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.client_btn.StateTracking.Border.ColorAngle = 45F;
            this.client_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.client_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.client_btn.StateTracking.Border.Rounding = 20;
            this.client_btn.StateTracking.Border.Width = 1;
            this.client_btn.TabIndex = 36;
            this.client_btn.Values.Text = "Users";
            this.client_btn.Click += new System.EventHandler(this.client_btn_Click);
            // 
            // bookings_info
            // 
            this.bookings_info.Location = new System.Drawing.Point(106, 497);
            this.bookings_info.Name = "bookings_info";
            this.bookings_info.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.bookings_info.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.bookings_info.OverrideDefault.Back.ColorAngle = 45F;
            this.bookings_info.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bookings_info.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.bookings_info.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.bookings_info.OverrideDefault.Border.ColorAngle = 45F;
            this.bookings_info.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookings_info.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bookings_info.OverrideDefault.Border.Rounding = 20;
            this.bookings_info.OverrideDefault.Border.Width = 1;
            this.bookings_info.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.bookings_info.Size = new System.Drawing.Size(199, 43);
            this.bookings_info.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.bookings_info.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.bookings_info.StateCommon.Back.ColorAngle = 45F;
            this.bookings_info.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bookings_info.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.bookings_info.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.bookings_info.StateCommon.Border.ColorAngle = 45F;
            this.bookings_info.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookings_info.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bookings_info.StateCommon.Border.Rounding = 20;
            this.bookings_info.StateCommon.Border.Width = 1;
            this.bookings_info.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.bookings_info.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.bookings_info.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings_info.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.bookings_info.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.bookings_info.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.bookings_info.StatePressed.Back.ColorAngle = 130F;
            this.bookings_info.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bookings_info.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.bookings_info.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.bookings_info.StatePressed.Border.ColorAngle = 130F;
            this.bookings_info.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookings_info.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bookings_info.StatePressed.Border.Rounding = 20;
            this.bookings_info.StatePressed.Border.Width = 1;
            this.bookings_info.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.bookings_info.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bookings_info.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.bookings_info.StateTracking.Back.ColorAngle = 45F;
            this.bookings_info.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bookings_info.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.bookings_info.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.bookings_info.StateTracking.Border.ColorAngle = 45F;
            this.bookings_info.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookings_info.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bookings_info.StateTracking.Border.Rounding = 20;
            this.bookings_info.StateTracking.Border.Width = 1;
            this.bookings_info.TabIndex = 37;
            this.bookings_info.Values.Text = "Bookings";
            this.bookings_info.Click += new System.EventHandler(this.bookings_info_Click);
            // 
            // car_info
            // 
            this.car_info.Location = new System.Drawing.Point(106, 546);
            this.car_info.Name = "car_info";
            this.car_info.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.car_info.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.car_info.OverrideDefault.Back.ColorAngle = 45F;
            this.car_info.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.car_info.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.car_info.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.car_info.OverrideDefault.Border.ColorAngle = 45F;
            this.car_info.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.car_info.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.car_info.OverrideDefault.Border.Rounding = 20;
            this.car_info.OverrideDefault.Border.Width = 1;
            this.car_info.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.car_info.Size = new System.Drawing.Size(199, 43);
            this.car_info.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.car_info.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.car_info.StateCommon.Back.ColorAngle = 45F;
            this.car_info.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.car_info.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.car_info.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.car_info.StateCommon.Border.ColorAngle = 45F;
            this.car_info.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.car_info.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.car_info.StateCommon.Border.Rounding = 20;
            this.car_info.StateCommon.Border.Width = 1;
            this.car_info.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.car_info.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.car_info.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_info.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.car_info.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.car_info.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.car_info.StatePressed.Back.ColorAngle = 130F;
            this.car_info.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.car_info.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.car_info.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.car_info.StatePressed.Border.ColorAngle = 130F;
            this.car_info.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.car_info.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.car_info.StatePressed.Border.Rounding = 20;
            this.car_info.StatePressed.Border.Width = 1;
            this.car_info.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.car_info.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.car_info.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.car_info.StateTracking.Back.ColorAngle = 45F;
            this.car_info.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.car_info.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.car_info.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.car_info.StateTracking.Border.ColorAngle = 45F;
            this.car_info.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.car_info.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.car_info.StateTracking.Border.Rounding = 20;
            this.car_info.StateTracking.Border.Width = 1;
            this.car_info.TabIndex = 38;
            this.car_info.Values.Text = "Vehicle Manager";
            this.car_info.Click += new System.EventHandler(this.car_info_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(1040, 576);
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
            this.logout_btn.TabIndex = 39;
            this.logout_btn.TabStop = false;
            this.logout_btn.Values.Text = "Logout";
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // admin_btn
            // 
            this.admin_btn.Location = new System.Drawing.Point(1009, 519);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.admin_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.admin_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.admin_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.admin_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.admin_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.admin_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.admin_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.admin_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.admin_btn.OverrideDefault.Border.Rounding = 20;
            this.admin_btn.OverrideDefault.Border.Width = 1;
            this.admin_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.admin_btn.Size = new System.Drawing.Size(156, 41);
            this.admin_btn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.admin_btn.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.admin_btn.StateCommon.Back.ColorAngle = 45F;
            this.admin_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.admin_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.admin_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.admin_btn.StateCommon.Border.ColorAngle = 45F;
            this.admin_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.admin_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.admin_btn.StateCommon.Border.Rounding = 20;
            this.admin_btn.StateCommon.Border.Width = 1;
            this.admin_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.admin_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.admin_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.admin_btn.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.admin_btn.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.admin_btn.StatePressed.Back.ColorAngle = 130F;
            this.admin_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.admin_btn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.admin_btn.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.admin_btn.StatePressed.Border.ColorAngle = 130F;
            this.admin_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.admin_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.admin_btn.StatePressed.Border.Rounding = 20;
            this.admin_btn.StatePressed.Border.Width = 1;
            this.admin_btn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.admin_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.admin_btn.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.admin_btn.StateTracking.Back.ColorAngle = 45F;
            this.admin_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.admin_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.admin_btn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.admin_btn.StateTracking.Border.ColorAngle = 45F;
            this.admin_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.admin_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.admin_btn.StateTracking.Border.Rounding = 20;
            this.admin_btn.StateTracking.Border.Width = 1;
            this.admin_btn.TabIndex = 40;
            this.admin_btn.Values.Text = "Management";
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RetroRides.Properties.Resources.adminDashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.car_info);
            this.Controls.Add(this.bookings_info);
            this.Controls.Add(this.client_btn);
            this.Controls.Add(this.top_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applabelpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.PictureBox applabelpic;
        private System.Windows.Forms.Label applabel;
        private System.Windows.Forms.Button min_btn;
        private System.Windows.Forms.Button max_btn;
        private System.Windows.Forms.Button cross_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton client_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bookings_info;
        private ComponentFactory.Krypton.Toolkit.KryptonButton car_info;
        private ComponentFactory.Krypton.Toolkit.KryptonButton logout_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton admin_btn;
    }
}