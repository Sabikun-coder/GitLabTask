namespace RetroRides.Forms.Client
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.min_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.applabel = new System.Windows.Forms.Label();
            this.CarComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.book_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.yearLabel = new System.Windows.Forms.Label();
            this.topSpeedLabel = new System.Windows.Forms.Label();
            this.maxPowerLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.carNameLabel = new System.Windows.Forms.Label();
            this.bookingsListView = new System.Windows.Forms.ListView();
            this.Bookings_label = new System.Windows.Forms.Label();
            this.goback_btn = new System.Windows.Forms.Button();
            this.settingsPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.home_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.settings_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancelBooking_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.reservationDatePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.min_btn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.applabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 35);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // min_btn
            // 
            this.min_btn.BackColor = System.Drawing.Color.Transparent;
            this.min_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("min_btn.BackgroundImage")));
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1153, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 35);
            this.button2.TabIndex = 5;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_btn.BackgroundImage")));
            this.cancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancel_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.Transparent;
            this.cancel_btn.Location = new System.Drawing.Point(1175, 0);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(25, 35);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.TabStop = false;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // applabel
            // 
            this.applabel.AutoSize = true;
            this.applabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.applabel.Location = new System.Drawing.Point(36, 6);
            this.applabel.Name = "applabel";
            this.applabel.Size = new System.Drawing.Size(79, 23);
            this.applabel.TabIndex = 3;
            this.applabel.Text = "RetroRides";
            // 
            // CarComboBox
            // 
            this.CarComboBox.DropDownWidth = 177;
            this.CarComboBox.Location = new System.Drawing.Point(348, 233);
            this.CarComboBox.Name = "CarComboBox";
            this.CarComboBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.CarComboBox.Size = new System.Drawing.Size(212, 29);
            this.CarComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.CarComboBox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray;
            this.CarComboBox.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.DarkGray;
            this.CarComboBox.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.CarComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CarComboBox.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.CarComboBox.StateCommon.ComboBox.Border.Rounding = 7;
            this.CarComboBox.StateCommon.ComboBox.Border.Width = 1;
            this.CarComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarComboBox.StateCommon.DropBack.Color1 = System.Drawing.Color.BurlyWood;
            this.CarComboBox.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.CarComboBox.StateCommon.DropBack.ColorAngle = 45F;
            this.CarComboBox.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.CarComboBox.TabIndex = 3;
            this.CarComboBox.Text = "Select available cars";
            this.CarComboBox.SelectedIndexChanged += new System.EventHandler(this.CarComboBox_SelectedIndexChanged_1);
            // 
            // carPictureBox
            // 
            this.carPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.carPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("carPictureBox.Image")));
            this.carPictureBox.Location = new System.Drawing.Point(363, 99);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(182, 88);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPictureBox.TabIndex = 11;
            this.carPictureBox.TabStop = false;
            // 
            // book_btn
            // 
            this.book_btn.Location = new System.Drawing.Point(1001, 497);
            this.book_btn.Name = "book_btn";
            this.book_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.book_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.book_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.book_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.book_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.book_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.book_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.book_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_btn.OverrideDefault.Border.Rounding = 20;
            this.book_btn.OverrideDefault.Border.Width = 1;
            this.book_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.book_btn.Size = new System.Drawing.Size(125, 38);
            this.book_btn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.book_btn.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.book_btn.StateCommon.Back.ColorAngle = 45F;
            this.book_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.book_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.book_btn.StateCommon.Border.ColorAngle = 45F;
            this.book_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.book_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_btn.StateCommon.Border.Rounding = 20;
            this.book_btn.StateCommon.Border.Width = 1;
            this.book_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.book_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.book_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_btn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.book_btn.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.book_btn.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.book_btn.StatePressed.Back.ColorAngle = 130F;
            this.book_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_btn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.book_btn.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.book_btn.StatePressed.Border.ColorAngle = 130F;
            this.book_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.book_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_btn.StatePressed.Border.Rounding = 20;
            this.book_btn.StatePressed.Border.Width = 1;
            this.book_btn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.book_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.book_btn.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.book_btn.StateTracking.Back.ColorAngle = 45F;
            this.book_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.book_btn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.book_btn.StateTracking.Border.ColorAngle = 45F;
            this.book_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.book_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_btn.StateTracking.Border.Rounding = 20;
            this.book_btn.StateTracking.Border.Width = 1;
            this.book_btn.TabIndex = 15;
            this.book_btn.Values.Text = "Book";
            this.book_btn.Click += new System.EventHandler(this.book_btn_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yearLabel.Location = new System.Drawing.Point(484, 387);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(54, 23);
            this.yearLabel.TabIndex = 16;
            this.yearLabel.Text = "X X X X";
            // 
            // topSpeedLabel
            // 
            this.topSpeedLabel.AutoSize = true;
            this.topSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.topSpeedLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topSpeedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topSpeedLabel.Location = new System.Drawing.Point(412, 410);
            this.topSpeedLabel.Name = "topSpeedLabel";
            this.topSpeedLabel.Size = new System.Drawing.Size(44, 23);
            this.topSpeedLabel.TabIndex = 16;
            this.topSpeedLabel.Text = "KM/H";
            // 
            // maxPowerLabel
            // 
            this.maxPowerLabel.AutoSize = true;
            this.maxPowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxPowerLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPowerLabel.ForeColor = System.Drawing.Color.White;
            this.maxPowerLabel.Location = new System.Drawing.Point(420, 434);
            this.maxPowerLabel.Name = "maxPowerLabel";
            this.maxPowerLabel.Size = new System.Drawing.Size(27, 23);
            this.maxPowerLabel.TabIndex = 16;
            this.maxPowerLabel.Text = "HP";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.priceLabel.Location = new System.Drawing.Point(380, 458);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 23);
            this.priceLabel.TabIndex = 16;
            this.priceLabel.Text = "$$$";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionLabel.Location = new System.Drawing.Point(421, 483);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(500, 400);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(80, 23);
            this.descriptionLabel.TabIndex = 16;
            this.descriptionLabel.Text = "_ _ _ _ _ ";
            // 
            // carNameLabel
            // 
            this.carNameLabel.AutoSize = true;
            this.carNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.carNameLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.carNameLabel.Location = new System.Drawing.Point(422, 362);
            this.carNameLabel.Name = "carNameLabel";
            this.carNameLabel.Size = new System.Drawing.Size(60, 23);
            this.carNameLabel.TabIndex = 16;
            this.carNameLabel.Text = "_____";
            // 
            // bookingsListView
            // 
            this.bookingsListView.FullRowSelect = true;
            this.bookingsListView.GridLines = true;
            this.bookingsListView.HideSelection = false;
            this.bookingsListView.Location = new System.Drawing.Point(661, 84);
            this.bookingsListView.Name = "bookingsListView";
            this.bookingsListView.Size = new System.Drawing.Size(465, 180);
            this.bookingsListView.TabIndex = 17;
            this.bookingsListView.UseCompatibleStateImageBehavior = false;
            this.bookingsListView.View = System.Windows.Forms.View.Details;
            // 
            // Bookings_label
            // 
            this.Bookings_label.AutoSize = true;
            this.Bookings_label.BackColor = System.Drawing.Color.Transparent;
            this.Bookings_label.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookings_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Bookings_label.Location = new System.Drawing.Point(250, 47);
            this.Bookings_label.Name = "Bookings_label";
            this.Bookings_label.Size = new System.Drawing.Size(110, 37);
            this.Bookings_label.TabIndex = 19;
            this.Bookings_label.Text = "Bookings";
            // 
            // goback_btn
            // 
            this.goback_btn.BackColor = System.Drawing.Color.Transparent;
            this.goback_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goback_btn.BackgroundImage")));
            this.goback_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goback_btn.FlatAppearance.BorderSize = 0;
            this.goback_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.goback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_btn.ForeColor = System.Drawing.Color.Transparent;
            this.goback_btn.Location = new System.Drawing.Point(213, 47);
            this.goback_btn.Name = "goback_btn";
            this.goback_btn.Size = new System.Drawing.Size(40, 32);
            this.goback_btn.TabIndex = 18;
            this.goback_btn.UseVisualStyleBackColor = false;
            this.goback_btn.Click += new System.EventHandler(this.goback_btn_Click);
            // 
            // settingsPicBox
            // 
            this.settingsPicBox.BackColor = System.Drawing.Color.Transparent;
            this.settingsPicBox.Image = global::RetroRides.Properties.Resources.New_Ticket;
            this.settingsPicBox.Location = new System.Drawing.Point(24, 229);
            this.settingsPicBox.Name = "settingsPicBox";
            this.settingsPicBox.Size = new System.Drawing.Size(32, 32);
            this.settingsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsPicBox.TabIndex = 22;
            this.settingsPicBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(56, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bookings";
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(12, 333);
            this.home_btn.Name = "home_btn";
            this.home_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.home_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.home_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.home_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.home_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.home_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.home_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.home_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.home_btn.OverrideDefault.Border.Rounding = 20;
            this.home_btn.OverrideDefault.Border.Width = 1;
            this.home_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.home_btn.Size = new System.Drawing.Size(160, 41);
            this.home_btn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.home_btn.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.home_btn.StateCommon.Back.ColorAngle = 45F;
            this.home_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.home_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.home_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.home_btn.StateCommon.Border.ColorAngle = 45F;
            this.home_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.home_btn.StateCommon.Border.Rounding = 20;
            this.home_btn.StateCommon.Border.Width = 1;
            this.home_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.home_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.home_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.home_btn.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.home_btn.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.home_btn.StatePressed.Back.ColorAngle = 130F;
            this.home_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.home_btn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.home_btn.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.home_btn.StatePressed.Border.ColorAngle = 130F;
            this.home_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.home_btn.StatePressed.Border.Rounding = 20;
            this.home_btn.StatePressed.Border.Width = 1;
            this.home_btn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.home_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.home_btn.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.home_btn.StateTracking.Back.ColorAngle = 45F;
            this.home_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.home_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.home_btn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.home_btn.StateTracking.Border.ColorAngle = 45F;
            this.home_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.home_btn.StateTracking.Border.Rounding = 20;
            this.home_btn.StateTracking.Border.Width = 1;
            this.home_btn.TabIndex = 20;
            this.home_btn.Values.Text = "Home";
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(694, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Past bookings:";
            // 
            // settings_btn
            // 
            this.settings_btn.Location = new System.Drawing.Point(12, 401);
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
            this.settings_btn.Size = new System.Drawing.Size(160, 43);
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
            this.settings_btn.TabIndex = 23;
            this.settings_btn.Values.Text = "Settings";
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // cancelBooking_btn
            // 
            this.cancelBooking_btn.Location = new System.Drawing.Point(1001, 541);
            this.cancelBooking_btn.Name = "cancelBooking_btn";
            this.cancelBooking_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.cancelBooking_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.cancelBooking_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.cancelBooking_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBooking_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.cancelBooking_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.cancelBooking_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.cancelBooking_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelBooking_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBooking_btn.OverrideDefault.Border.Rounding = 20;
            this.cancelBooking_btn.OverrideDefault.Border.Width = 1;
            this.cancelBooking_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cancelBooking_btn.Size = new System.Drawing.Size(125, 40);
            this.cancelBooking_btn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.cancelBooking_btn.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.cancelBooking_btn.StateCommon.Back.ColorAngle = 45F;
            this.cancelBooking_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBooking_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.cancelBooking_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.cancelBooking_btn.StateCommon.Border.ColorAngle = 45F;
            this.cancelBooking_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelBooking_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBooking_btn.StateCommon.Border.Rounding = 20;
            this.cancelBooking_btn.StateCommon.Border.Width = 1;
            this.cancelBooking_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cancelBooking_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.cancelBooking_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBooking_btn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.cancelBooking_btn.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.cancelBooking_btn.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.cancelBooking_btn.StatePressed.Back.ColorAngle = 130F;
            this.cancelBooking_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBooking_btn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.cancelBooking_btn.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.cancelBooking_btn.StatePressed.Border.ColorAngle = 130F;
            this.cancelBooking_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelBooking_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBooking_btn.StatePressed.Border.Rounding = 20;
            this.cancelBooking_btn.StatePressed.Border.Width = 1;
            this.cancelBooking_btn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.cancelBooking_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelBooking_btn.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.cancelBooking_btn.StateTracking.Back.ColorAngle = 45F;
            this.cancelBooking_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBooking_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.cancelBooking_btn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.cancelBooking_btn.StateTracking.Border.ColorAngle = 45F;
            this.cancelBooking_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelBooking_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBooking_btn.StateTracking.Border.Rounding = 20;
            this.cancelBooking_btn.StateTracking.Border.Width = 1;
            this.cancelBooking_btn.TabIndex = 24;
            this.cancelBooking_btn.Values.Text = "Cancel Booking";
            this.cancelBooking_btn.Click += new System.EventHandler(this.cancelBooking_btn_Click);
            // 
            // reservationDatePicker
            // 
            this.reservationDatePicker.Location = new System.Drawing.Point(956, 372);
            this.reservationDatePicker.Name = "reservationDatePicker";
            this.reservationDatePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.reservationDatePicker.ShowCheckBox = true;
            this.reservationDatePicker.Size = new System.Drawing.Size(170, 25);
            this.reservationDatePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.reservationDatePicker.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.reservationDatePicker.StateCommon.Border.Rounding = 7;
            this.reservationDatePicker.StateCommon.Border.Width = 1;
            this.reservationDatePicker.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(953, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "PICK RESERVATION DATE:";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 635);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reservationDatePicker);
            this.Controls.Add(this.cancelBooking_btn);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.settingsPicBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bookings_label);
            this.Controls.Add(this.goback_btn);
            this.Controls.Add(this.bookingsListView);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.maxPowerLabel);
            this.Controls.Add(this.topSpeedLabel);
            this.Controls.Add(this.carNameLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.book_btn);
            this.Controls.Add(this.carPictureBox);
            this.Controls.Add(this.CarComboBox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Booking";
            this.Text = "Booking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button min_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label applabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CarComboBox;
        private System.Windows.Forms.PictureBox carPictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton book_btn;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label topSpeedLabel;
        private System.Windows.Forms.Label maxPowerLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label carNameLabel;
        private System.Windows.Forms.ListView bookingsListView;
        private System.Windows.Forms.Label Bookings_label;
        private System.Windows.Forms.Button goback_btn;
        private System.Windows.Forms.PictureBox settingsPicBox;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton home_btn;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton settings_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelBooking_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker reservationDatePicker;
        private System.Windows.Forms.Label label3;
    }
}