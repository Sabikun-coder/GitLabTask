namespace RetroRides.Forms.Admin
{

    partial class AdminCarManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCarManager));
            this.top_panel = new System.Windows.Forms.Panel();
            this.applabelpic = new System.Windows.Forms.PictureBox();
            this.applabel = new System.Windows.Forms.Label();
            this.min_btn = new System.Windows.Forms.Button();
            this.max_btn = new System.Windows.Forms.Button();
            this.cross_btn = new System.Windows.Forms.Button();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtModelName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMaxPower = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTopSpeed = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtImagePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDescription = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.dataGridViewCars = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtCarID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.update = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookings_info = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dash_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.client_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.admin_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applabelpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.top_panel.TabIndex = 3;
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
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = global::RetroRides.Properties.Resources.placeHolderCar;
            this.pictureBoxCar.Location = new System.Drawing.Point(57, 32);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(197, 96);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 6;
            this.pictureBoxCar.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(97, 224);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnBrowseImage.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.btnBrowseImage.OverrideDefault.Back.ColorAngle = 45F;
            this.btnBrowseImage.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowseImage.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnBrowseImage.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.btnBrowseImage.OverrideDefault.Border.ColorAngle = 45F;
            this.btnBrowseImage.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBrowseImage.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowseImage.OverrideDefault.Border.Rounding = 20;
            this.btnBrowseImage.OverrideDefault.Border.Width = 1;
            this.btnBrowseImage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnBrowseImage.Size = new System.Drawing.Size(126, 37);
            this.btnBrowseImage.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnBrowseImage.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.btnBrowseImage.StateCommon.Back.ColorAngle = 45F;
            this.btnBrowseImage.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowseImage.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnBrowseImage.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnBrowseImage.StateCommon.Border.ColorAngle = 45F;
            this.btnBrowseImage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBrowseImage.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowseImage.StateCommon.Border.Rounding = 20;
            this.btnBrowseImage.StateCommon.Border.Width = 1;
            this.btnBrowseImage.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnBrowseImage.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.btnBrowseImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.btnBrowseImage.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.btnBrowseImage.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnBrowseImage.StatePressed.Back.ColorAngle = 130F;
            this.btnBrowseImage.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowseImage.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnBrowseImage.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnBrowseImage.StatePressed.Border.ColorAngle = 130F;
            this.btnBrowseImage.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBrowseImage.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowseImage.StatePressed.Border.Rounding = 20;
            this.btnBrowseImage.StatePressed.Border.Width = 1;
            this.btnBrowseImage.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.btnBrowseImage.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBrowseImage.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.btnBrowseImage.StateTracking.Back.ColorAngle = 45F;
            this.btnBrowseImage.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowseImage.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnBrowseImage.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.btnBrowseImage.StateTracking.Border.ColorAngle = 45F;
            this.btnBrowseImage.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBrowseImage.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowseImage.StateTracking.Border.Rounding = 20;
            this.btnBrowseImage.StateTracking.Border.Width = 1;
            this.btnBrowseImage.TabIndex = 14;
            this.btnBrowseImage.Values.Text = "Select";
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(209, 224);
            this.Add.Name = "Add";
            this.Add.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.Add.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.Add.OverrideDefault.Back.ColorAngle = 45F;
            this.Add.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Add.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.Add.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.Add.OverrideDefault.Border.ColorAngle = 45F;
            this.Add.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Add.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Add.OverrideDefault.Border.Rounding = 20;
            this.Add.OverrideDefault.Border.Width = 1;
            this.Add.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Add.Size = new System.Drawing.Size(125, 38);
            this.Add.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Add.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.Add.StateCommon.Back.ColorAngle = 45F;
            this.Add.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Add.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.Add.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.Add.StateCommon.Border.ColorAngle = 45F;
            this.Add.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Add.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Add.StateCommon.Border.Rounding = 20;
            this.Add.StateCommon.Border.Width = 1;
            this.Add.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Add.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.Add.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.Add.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.Add.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.Add.StatePressed.Back.ColorAngle = 130F;
            this.Add.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Add.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.Add.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.Add.StatePressed.Border.ColorAngle = 130F;
            this.Add.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Add.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Add.StatePressed.Border.Rounding = 20;
            this.Add.StatePressed.Border.Width = 1;
            this.Add.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.Add.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Add.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.Add.StateTracking.Back.ColorAngle = 45F;
            this.Add.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Add.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.Add.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.Add.StateTracking.Border.ColorAngle = 45F;
            this.Add.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Add.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Add.StateTracking.Border.Rounding = 20;
            this.Add.StateTracking.Border.Width = 1;
            this.Add.TabIndex = 14;
            this.Add.Values.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(31, 27);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(144, 37);
            this.txtModelName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtModelName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtModelName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtModelName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtModelName.StateCommon.Border.Rounding = 20;
            this.txtModelName.StateCommon.Border.Width = 1;
            this.txtModelName.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtModelName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtModelName.TabIndex = 9;
            this.txtModelName.Text = "Model name";
            this.txtModelName.Enter += new System.EventHandler(this.txtModelName_Enter);
            this.txtModelName.Leave += new System.EventHandler(this.txtModelName_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(380, 27);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(138, 37);
            this.txtPrice.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPrice.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrice.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrice.StateCommon.Border.Rounding = 20;
            this.txtPrice.StateCommon.Border.Width = 1;
            this.txtPrice.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtPrice.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.Text = "Price in BDT";
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtMaxPower
            // 
            this.txtMaxPower.Location = new System.Drawing.Point(105, 70);
            this.txtMaxPower.Name = "txtMaxPower";
            this.txtMaxPower.Size = new System.Drawing.Size(159, 37);
            this.txtMaxPower.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtMaxPower.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaxPower.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaxPower.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaxPower.StateCommon.Border.Rounding = 20;
            this.txtMaxPower.StateCommon.Border.Width = 1;
            this.txtMaxPower.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtMaxPower.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxPower.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtMaxPower.TabIndex = 7;
            this.txtMaxPower.TabStop = false;
            this.txtMaxPower.Text = "Max power (HP)";
            this.txtMaxPower.Enter += new System.EventHandler(this.txtMaxPower_Enter);
            this.txtMaxPower.Leave += new System.EventHandler(this.txtMaxPower_Leave);
            // 
            // txtTopSpeed
            // 
            this.txtTopSpeed.Location = new System.Drawing.Point(277, 70);
            this.txtTopSpeed.Name = "txtTopSpeed";
            this.txtTopSpeed.Size = new System.Drawing.Size(160, 37);
            this.txtTopSpeed.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTopSpeed.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTopSpeed.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTopSpeed.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTopSpeed.StateCommon.Border.Rounding = 20;
            this.txtTopSpeed.StateCommon.Border.Width = 1;
            this.txtTopSpeed.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtTopSpeed.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopSpeed.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtTopSpeed.TabIndex = 11;
            this.txtTopSpeed.Text = "Top speed in km/h";
            this.txtTopSpeed.Enter += new System.EventHandler(this.txtTopSpeed_Enter);
            this.txtTopSpeed.Leave += new System.EventHandler(this.txtTopSpeed_Leave);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(57, 156);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(197, 37);
            this.txtImagePath.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtImagePath.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtImagePath.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtImagePath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtImagePath.StateCommon.Border.Rounding = 20;
            this.txtImagePath.StateCommon.Border.Width = 1;
            this.txtImagePath.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtImagePath.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagePath.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtImagePath.TabIndex = 13;
            this.txtImagePath.Text = "Image path";
            this.txtImagePath.Enter += new System.EventHandler(this.txtImagePath_Enter);
            this.txtImagePath.Leave += new System.EventHandler(this.txtImagePath_Leave);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(205, 27);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(144, 37);
            this.txtYear.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtYear.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtYear.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtYear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtYear.StateCommon.Border.Rounding = 20;
            this.txtYear.StateCommon.Border.Width = 1;
            this.txtYear.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtYear.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtYear.TabIndex = 10;
            this.txtYear.Text = "Year";
            this.txtYear.Enter += new System.EventHandler(this.txtYear_Enter);
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(105, 128);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtDescription.Size = new System.Drawing.Size(332, 90);
            this.txtDescription.StateActive.Border.Color1 = System.Drawing.Color.DimGray;
            this.txtDescription.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txtDescription.StateActive.Border.ColorAngle = 45F;
            this.txtDescription.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDescription.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDescription.StateActive.Border.Rounding = 5;
            this.txtDescription.StateActive.Border.Width = 1;
            this.txtDescription.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.txtDescription.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDescription.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.txtDescription.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txtDescription.StateCommon.Border.ColorAngle = 45F;
            this.txtDescription.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDescription.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDescription.StateCommon.Border.Rounding = 5;
            this.txtDescription.StateCommon.Border.Width = 1;
            this.txtDescription.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtDescription.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.TabIndex = 17;
            this.txtDescription.Text = "Write a short description";
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(17, 19);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dataGridViewCars.Size = new System.Drawing.Size(846, 195);
            this.dataGridViewCars.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewCars.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.dataGridViewCars.StateCommon.Background.ColorAngle = 45F;
            this.dataGridViewCars.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewCars.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataGridViewCars.StateCommon.DataCell.Border.Rounding = 5;
            this.dataGridViewCars.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataGridViewCars.StateCommon.HeaderColumn.Border.Rounding = 2;
            this.dataGridViewCars.StateCommon.HeaderColumn.Border.Width = 1;
            this.dataGridViewCars.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataGridViewCars.StateSelected.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataGridViewCars.StateSelected.DataCell.Border.Rounding = 5;
            this.dataGridViewCars.TabIndex = 18;
            this.dataGridViewCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCars_CellClick);
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(779, 272);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(154, 37);
            this.txtCarID.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCarID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCarID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCarID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCarID.StateCommon.Border.Rounding = 20;
            this.txtCarID.StateCommon.Border.Width = 1;
            this.txtCarID.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtCarID.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtCarID.TabIndex = 11;
            this.txtCarID.Text = "Enter car id to edit";
            this.txtCarID.Enter += new System.EventHandler(this.txtCarID_Enter);
            this.txtCarID.Leave += new System.EventHandler(this.txtCarID_Leave);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(953, 272);
            this.update.Name = "update";
            this.update.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.update.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.update.OverrideDefault.Back.ColorAngle = 45F;
            this.update.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.update.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.update.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.update.OverrideDefault.Border.ColorAngle = 45F;
            this.update.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.update.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.update.OverrideDefault.Border.Rounding = 20;
            this.update.OverrideDefault.Border.Width = 1;
            this.update.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.update.Size = new System.Drawing.Size(101, 37);
            this.update.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.update.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.update.StateCommon.Back.ColorAngle = 45F;
            this.update.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.update.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.update.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.update.StateCommon.Border.ColorAngle = 45F;
            this.update.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.update.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.update.StateCommon.Border.Rounding = 20;
            this.update.StateCommon.Border.Width = 1;
            this.update.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.update.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.update.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.update.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.update.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.update.StatePressed.Back.ColorAngle = 130F;
            this.update.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.update.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.update.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.update.StatePressed.Border.ColorAngle = 130F;
            this.update.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.update.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.update.StatePressed.Border.Rounding = 20;
            this.update.StatePressed.Border.Width = 1;
            this.update.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.update.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.update.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.update.StateTracking.Back.ColorAngle = 45F;
            this.update.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.update.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.update.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.update.StateTracking.Border.ColorAngle = 45F;
            this.update.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.update.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.update.StateTracking.Border.Rounding = 20;
            this.update.StateTracking.Border.Width = 1;
            this.update.TabIndex = 19;
            this.update.Values.Text = "Update";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1074, 272);
            this.delete.Name = "delete";
            this.delete.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.delete.OverrideDefault.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.delete.OverrideDefault.Back.ColorAngle = 45F;
            this.delete.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.delete.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.delete.OverrideDefault.Border.ColorAngle = 45F;
            this.delete.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.delete.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete.OverrideDefault.Border.Rounding = 20;
            this.delete.OverrideDefault.Border.Width = 1;
            this.delete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.delete.Size = new System.Drawing.Size(101, 37);
            this.delete.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.delete.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.delete.StateCommon.Back.ColorAngle = 45F;
            this.delete.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.delete.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.delete.StateCommon.Border.ColorAngle = 45F;
            this.delete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.delete.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete.StateCommon.Border.Rounding = 20;
            this.delete.StateCommon.Border.Width = 1;
            this.delete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.delete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.delete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.delete.StatePressed.Back.Color1 = System.Drawing.Color.Salmon;
            this.delete.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.delete.StatePressed.Back.ColorAngle = 130F;
            this.delete.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.delete.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.delete.StatePressed.Border.ColorAngle = 130F;
            this.delete.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.delete.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete.StatePressed.Border.Rounding = 20;
            this.delete.StatePressed.Border.Width = 1;
            this.delete.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.delete.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete.StateTracking.Back.Color2 = System.Drawing.Color.Snow;
            this.delete.StateTracking.Back.ColorAngle = 45F;
            this.delete.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.delete.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.delete.StateTracking.Border.ColorAngle = 45F;
            this.delete.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.delete.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete.StateTracking.Border.Rounding = 20;
            this.delete.StateTracking.Border.Width = 1;
            this.delete.TabIndex = 19;
            this.delete.Values.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.txtTopSpeed);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtModelName);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtMaxPower);
            this.panel1.Location = new System.Drawing.Point(306, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 281);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dataGridViewCars);
            this.panel2.Location = new System.Drawing.Point(306, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 290);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBoxCar);
            this.panel3.Controls.Add(this.txtImagePath);
            this.panel3.Controls.Add(this.btnBrowseImage);
            this.panel3.Location = new System.Drawing.Point(879, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 281);
            this.panel3.TabIndex = 22;
            // 
            // bookings_info
            // 
            this.bookings_info.Location = new System.Drawing.Point(18, 462);
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
            this.bookings_info.Size = new System.Drawing.Size(152, 43);
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
            this.bookings_info.TabIndex = 23;
            this.bookings_info.Values.Text = "Bookings";
            this.bookings_info.Click += new System.EventHandler(this.Client_info_Click);
            // 
            // dash_btn
            // 
            this.dash_btn.Location = new System.Drawing.Point(38, 530);
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
            this.dash_btn.TabIndex = 24;
            this.dash_btn.TabStop = false;
            this.dash_btn.Values.Text = "Dashboard";
            this.dash_btn.Click += new System.EventHandler(this.dash_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RetroRides.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(74, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Vehicle Manager";
            // 
            // client_btn
            // 
            this.client_btn.Location = new System.Drawing.Point(18, 402);
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
            this.client_btn.Size = new System.Drawing.Size(152, 41);
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
            this.client_btn.TabIndex = 35;
            this.client_btn.Values.Text = "Users";
            this.client_btn.Click += new System.EventHandler(this.client_btn_Click);
            // 
            // admin_btn
            // 
            this.admin_btn.Location = new System.Drawing.Point(18, 345);
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
            this.admin_btn.Size = new System.Drawing.Size(152, 41);
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
            this.admin_btn.TabIndex = 38;
            this.admin_btn.Values.Text = "Management";
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // AdminCarManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::RetroRides.Properties.Resources.carmanager;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.client_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dash_btn);
            this.Controls.Add(this.bookings_info);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCarManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCarDatabase";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applabelpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBrowseImage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Add;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtYear;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtImagePath;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTopSpeed;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMaxPower;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtModelName;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewCars;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCarID;
        private ComponentFactory.Krypton.Toolkit.KryptonButton update;
        private ComponentFactory.Krypton.Toolkit.KryptonButton delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bookings_info;
        private ComponentFactory.Krypton.Toolkit.KryptonButton dash_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton client_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton admin_btn;
    }
}