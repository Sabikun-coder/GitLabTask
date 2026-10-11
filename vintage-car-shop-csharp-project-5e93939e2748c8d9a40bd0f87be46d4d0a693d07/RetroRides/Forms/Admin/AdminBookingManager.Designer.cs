namespace RetroRides.Forms.Admin
{
    partial class AdminBookingManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookingManager));
            this.top_panel = new System.Windows.Forms.Panel();
            this.applabelpic = new System.Windows.Forms.PictureBox();
            this.applabel = new System.Windows.Forms.Label();
            this.min_btn = new System.Windows.Forms.Button();
            this.max_btn = new System.Windows.Forms.Button();
            this.cross_btn = new System.Windows.Forms.Button();
            this.bookingsListView = new System.Windows.Forms.ListView();
            this.deleteButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.car_info = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dash_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.client_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.admin_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applabelpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // bookingsListView
            // 
            this.bookingsListView.FullRowSelect = true;
            this.bookingsListView.GridLines = true;
            this.bookingsListView.HideSelection = false;
            this.bookingsListView.Location = new System.Drawing.Point(350, 122);
            this.bookingsListView.MultiSelect = false;
            this.bookingsListView.Name = "bookingsListView";
            this.bookingsListView.Size = new System.Drawing.Size(705, 227);
            this.bookingsListView.TabIndex = 5;
            this.bookingsListView.UseCompatibleStateImageBehavior = false;
            this.bookingsListView.View = System.Windows.Forms.View.Details;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(954, 407);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.deleteButton.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.deleteButton.OverrideDefault.Back.ColorAngle = 45F;
            this.deleteButton.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.deleteButton.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.deleteButton.OverrideDefault.Border.ColorAngle = 45F;
            this.deleteButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteButton.OverrideDefault.Border.Rounding = 20;
            this.deleteButton.OverrideDefault.Border.Width = 1;
            this.deleteButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.deleteButton.Size = new System.Drawing.Size(101, 37);
            this.deleteButton.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.deleteButton.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.deleteButton.StateCommon.Back.ColorAngle = 45F;
            this.deleteButton.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.deleteButton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.deleteButton.StateCommon.Border.ColorAngle = 45F;
            this.deleteButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteButton.StateCommon.Border.Rounding = 20;
            this.deleteButton.StateCommon.Border.Width = 1;
            this.deleteButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.deleteButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.deleteButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.deleteButton.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.deleteButton.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.deleteButton.StatePressed.Back.ColorAngle = 130F;
            this.deleteButton.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteButton.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.deleteButton.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.deleteButton.StatePressed.Border.ColorAngle = 130F;
            this.deleteButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteButton.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteButton.StatePressed.Border.Rounding = 20;
            this.deleteButton.StatePressed.Border.Width = 1;
            this.deleteButton.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.deleteButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteButton.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.deleteButton.StateTracking.Back.ColorAngle = 45F;
            this.deleteButton.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteButton.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.deleteButton.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.deleteButton.StateTracking.Border.ColorAngle = 45F;
            this.deleteButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteButton.StateTracking.Border.Rounding = 20;
            this.deleteButton.StateTracking.Border.Width = 1;
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Values.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RetroRides.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(499, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // car_info
            // 
            this.car_info.Location = new System.Drawing.Point(15, 469);
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
            this.car_info.Size = new System.Drawing.Size(157, 41);
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
            this.car_info.TabIndex = 24;
            this.car_info.Values.Text = "Vehicle Manager";
            this.car_info.Click += new System.EventHandler(this.car_info_Click);
            // 
            // dash_btn
            // 
            this.dash_btn.Location = new System.Drawing.Point(42, 535);
            this.dash_btn.Name = "dash_btn";
            this.dash_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.dash_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.dash_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.dash_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dash_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.dash_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.dash_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.dash_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dash_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dash_btn.OverrideDefault.Border.Rounding = 20;
            this.dash_btn.OverrideDefault.Border.Width = 1;
            this.dash_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dash_btn.Size = new System.Drawing.Size(101, 39);
            this.dash_btn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.dash_btn.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.dash_btn.StateCommon.Back.ColorAngle = 45F;
            this.dash_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dash_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.dash_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.dash_btn.StateCommon.Border.ColorAngle = 45F;
            this.dash_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dash_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dash_btn.StateCommon.Border.Rounding = 20;
            this.dash_btn.StateCommon.Border.Width = 1;
            this.dash_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.dash_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.dash_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_btn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.dash_btn.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.dash_btn.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.dash_btn.StatePressed.Back.ColorAngle = 130F;
            this.dash_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dash_btn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.dash_btn.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.dash_btn.StatePressed.Border.ColorAngle = 130F;
            this.dash_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dash_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dash_btn.StatePressed.Border.Rounding = 20;
            this.dash_btn.StatePressed.Border.Width = 1;
            this.dash_btn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.dash_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dash_btn.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.dash_btn.StateTracking.Back.ColorAngle = 45F;
            this.dash_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dash_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.dash_btn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.dash_btn.StateTracking.Border.ColorAngle = 45F;
            this.dash_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dash_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dash_btn.StateTracking.Border.Rounding = 20;
            this.dash_btn.StateTracking.Border.Width = 1;
            this.dash_btn.TabIndex = 25;
            this.dash_btn.TabStop = false;
            this.dash_btn.Values.Text = "Dashboard";
            this.dash_btn.Click += new System.EventHandler(this.dash_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::RetroRides.Properties.Resources.admin;
            this.pictureBox2.Location = new System.Drawing.Point(74, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Administrator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bookings Manager";
            // 
            // client_btn
            // 
            this.client_btn.Location = new System.Drawing.Point(15, 407);
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
            this.client_btn.Size = new System.Drawing.Size(157, 41);
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
            // admin_btn
            // 
            this.admin_btn.Location = new System.Drawing.Point(15, 346);
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
            this.admin_btn.Size = new System.Drawing.Size(157, 41);
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
            this.admin_btn.TabIndex = 39;
            this.admin_btn.Values.Text = "Management";
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // AdminBookingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::RetroRides.Properties.Resources.clientinfo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.client_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dash_btn);
            this.Controls.Add(this.car_info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.bookingsListView);
            this.Controls.Add(this.top_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminBookingManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminBookingManager";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applabelpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.PictureBox applabelpic;
        private System.Windows.Forms.Label applabel;
        private System.Windows.Forms.Button min_btn;
        private System.Windows.Forms.Button max_btn;
        private System.Windows.Forms.Button cross_btn;
        private System.Windows.Forms.ListView bookingsListView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton car_info;
        private ComponentFactory.Krypton.Toolkit.KryptonButton dash_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton client_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton admin_btn;
    }
}