namespace LocationEditor
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
            this.Characters_gb = new System.Windows.Forms.GroupBox();
            this.Characters_panel = new System.Windows.Forms.Panel();
            this.CharacterSettings_gb = new System.Windows.Forms.GroupBox();
            this.CbCharStyle = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.MoveDownCharacter_btn = new System.Windows.Forms.Button();
            this.MoveUpCharacter_btn = new System.Windows.Forms.Button();
            this.CloneCharacter_btn = new System.Windows.Forms.Button();
            this.DelCharacter_btn = new System.Windows.Forms.Button();
            this.AddCharacter_btn = new System.Windows.Forms.Button();
            this.Actions_gb = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Revard_tb = new System.Windows.Forms.TextBox();
            this.unique_time_tb = new System.Windows.Forms.TextBox();
            this.Point_cb = new System.Windows.Forms.ComboBox();
            this.Object_cb = new System.Windows.Forms.ComboBox();
            this.DeleteAction_btn = new System.Windows.Forms.Button();
            this.AddAction_btn = new System.Windows.Forms.Button();
            this.Actions_dgv = new System.Windows.Forms.DataGridView();
            this.Object = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products_gb = new System.Windows.Forms.GroupBox();
            this.AddProduct_btn = new System.Windows.Forms.Button();
            this.DelProduct_btn = new System.Windows.Forms.Button();
            this.Product_count_tb = new System.Windows.Forms.TextBox();
            this.Product_cb = new System.Windows.Forms.ComboBox();
            this.Produtts_dgv = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterMoney_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Spawn_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Character_cb = new System.Windows.Forms.ComboBox();
            this.LevelOptions_gb = new System.Windows.Forms.GroupBox();
            this.SaveAsLevel_btn = new System.Windows.Forms.Button();
            this.Event_cb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Time_tb = new System.Windows.Forms.TextBox();
            this.Goal_tb = new System.Windows.Forms.TextBox();
            this.SaveLevel_btn = new System.Windows.Forms.Button();
            this.MoneyCount_tb = new System.Windows.Forms.TextBox();
            this.LoadLevel_btn = new System.Windows.Forms.Button();
            this.GoalStar_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CharacterCount_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CatTime_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Level_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Location_cb = new System.Windows.Forms.ComboBox();
            this.OpenAv_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Characters_gb.SuspendLayout();
            this.CharacterSettings_gb.SuspendLayout();
            this.Actions_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Actions_dgv)).BeginInit();
            this.Products_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Produtts_dgv)).BeginInit();
            this.LevelOptions_gb.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Characters_gb
            // 
            this.Characters_gb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Characters_gb.Controls.Add(this.Characters_panel);
            this.Characters_gb.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Characters_gb.Location = new System.Drawing.Point(343, 27);
            this.Characters_gb.Name = "Characters_gb";
            this.Characters_gb.Size = new System.Drawing.Size(451, 683);
            this.Characters_gb.TabIndex = 2;
            this.Characters_gb.TabStop = false;
            this.Characters_gb.Text = "Персонажи";
            // 
            // Characters_panel
            // 
            this.Characters_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Characters_panel.AutoScroll = true;
            this.Characters_panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Characters_panel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Characters_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Characters_panel.Location = new System.Drawing.Point(6, 20);
            this.Characters_panel.Name = "Characters_panel";
            this.Characters_panel.Size = new System.Drawing.Size(439, 654);
            this.Characters_panel.TabIndex = 0;
            // 
            // CharacterSettings_gb
            // 
            this.CharacterSettings_gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharacterSettings_gb.Controls.Add(this.CbCharStyle);
            this.CharacterSettings_gb.Controls.Add(this.label17);
            this.CharacterSettings_gb.Controls.Add(this.MoveDownCharacter_btn);
            this.CharacterSettings_gb.Controls.Add(this.MoveUpCharacter_btn);
            this.CharacterSettings_gb.Controls.Add(this.CloneCharacter_btn);
            this.CharacterSettings_gb.Controls.Add(this.DelCharacter_btn);
            this.CharacterSettings_gb.Controls.Add(this.AddCharacter_btn);
            this.CharacterSettings_gb.Controls.Add(this.Actions_gb);
            this.CharacterSettings_gb.Controls.Add(this.Products_gb);
            this.CharacterSettings_gb.Controls.Add(this.CharacterMoney_tb);
            this.CharacterSettings_gb.Controls.Add(this.label11);
            this.CharacterSettings_gb.Controls.Add(this.Spawn_tb);
            this.CharacterSettings_gb.Controls.Add(this.label10);
            this.CharacterSettings_gb.Controls.Add(this.label9);
            this.CharacterSettings_gb.Controls.Add(this.Character_cb);
            this.CharacterSettings_gb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharacterSettings_gb.Location = new System.Drawing.Point(800, 27);
            this.CharacterSettings_gb.Name = "CharacterSettings_gb";
            this.CharacterSettings_gb.Size = new System.Drawing.Size(455, 683);
            this.CharacterSettings_gb.TabIndex = 1;
            this.CharacterSettings_gb.TabStop = false;
            this.CharacterSettings_gb.Text = "Настройки персонажа";
            // 
            // cbCharStyle
            // 
            this.CbCharStyle.FormattingEnabled = true;
            this.CbCharStyle.Location = new System.Drawing.Point(169, 48);
            this.CbCharStyle.Name = "CbCharStyle";
            this.CbCharStyle.Size = new System.Drawing.Size(150, 27);
            this.CbCharStyle.TabIndex = 27;
            this.CbCharStyle.SelectedValueChanged += new System.EventHandler(this.CbCharStyle_SelectedValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(83, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "Стиль";
            // 
            // MoveDownCharacter_btn
            // 
            this.MoveDownCharacter_btn.Location = new System.Drawing.Point(6, 314);
            this.MoveDownCharacter_btn.Name = "MoveDownCharacter_btn";
            this.MoveDownCharacter_btn.Size = new System.Drawing.Size(75, 36);
            this.MoveDownCharacter_btn.TabIndex = 25;
            this.MoveDownCharacter_btn.Text = "down";
            this.MoveDownCharacter_btn.UseVisualStyleBackColor = true;
            this.MoveDownCharacter_btn.Click += new System.EventHandler(this.MoveDownCharacter_btn_Click);
            // 
            // MoveUpCharacter_btn
            // 
            this.MoveUpCharacter_btn.Location = new System.Drawing.Point(6, 272);
            this.MoveUpCharacter_btn.Name = "MoveUpCharacter_btn";
            this.MoveUpCharacter_btn.Size = new System.Drawing.Size(75, 36);
            this.MoveUpCharacter_btn.TabIndex = 24;
            this.MoveUpCharacter_btn.Text = "up";
            this.MoveUpCharacter_btn.UseVisualStyleBackColor = true;
            this.MoveUpCharacter_btn.Click += new System.EventHandler(this.MoveUpCharacter_Click);
            // 
            // CloneCharacter_btn
            // 
            this.CloneCharacter_btn.Location = new System.Drawing.Point(6, 74);
            this.CloneCharacter_btn.Name = "CloneCharacter_btn";
            this.CloneCharacter_btn.Size = new System.Drawing.Size(75, 36);
            this.CloneCharacter_btn.TabIndex = 23;
            this.CloneCharacter_btn.Text = "Clone";
            this.CloneCharacter_btn.UseVisualStyleBackColor = true;
            this.CloneCharacter_btn.Click += new System.EventHandler(this.CloneCharacter_btn_Click);
            // 
            // DelCharacter_btn
            // 
            this.DelCharacter_btn.Location = new System.Drawing.Point(6, 116);
            this.DelCharacter_btn.Name = "DelCharacter_btn";
            this.DelCharacter_btn.Size = new System.Drawing.Size(75, 36);
            this.DelCharacter_btn.TabIndex = 22;
            this.DelCharacter_btn.Text = "Х";
            this.DelCharacter_btn.UseVisualStyleBackColor = true;
            this.DelCharacter_btn.Click += new System.EventHandler(this.DelCharacter_btn_Click);
            // 
            // AddCharacter_btn
            // 
            this.AddCharacter_btn.Location = new System.Drawing.Point(6, 32);
            this.AddCharacter_btn.Name = "AddCharacter_btn";
            this.AddCharacter_btn.Size = new System.Drawing.Size(75, 36);
            this.AddCharacter_btn.TabIndex = 21;
            this.AddCharacter_btn.Text = "Add";
            this.AddCharacter_btn.UseVisualStyleBackColor = true;
            this.AddCharacter_btn.Click += new System.EventHandler(this.AddCharacter_btn_Click);
            // 
            // Actions_gb
            // 
            this.Actions_gb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Actions_gb.Controls.Add(this.label16);
            this.Actions_gb.Controls.Add(this.label15);
            this.Actions_gb.Controls.Add(this.label14);
            this.Actions_gb.Controls.Add(this.label13);
            this.Actions_gb.Controls.Add(this.Revard_tb);
            this.Actions_gb.Controls.Add(this.unique_time_tb);
            this.Actions_gb.Controls.Add(this.Point_cb);
            this.Actions_gb.Controls.Add(this.Object_cb);
            this.Actions_gb.Controls.Add(this.DeleteAction_btn);
            this.Actions_gb.Controls.Add(this.AddAction_btn);
            this.Actions_gb.Controls.Add(this.Actions_dgv);
            this.Actions_gb.Location = new System.Drawing.Point(10, 351);
            this.Actions_gb.Name = "Actions_gb";
            this.Actions_gb.Size = new System.Drawing.Size(427, 323);
            this.Actions_gb.TabIndex = 10;
            this.Actions_gb.TabStop = false;
            this.Actions_gb.Text = "События персонажа";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(160, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 19);
            this.label16.TabIndex = 26;
            this.label16.Text = "Награда";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 19);
            this.label15.TabIndex = 25;
            this.label15.Text = "Время";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(83, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "Точка";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "Продукт";
            // 
            // Revard_tb
            // 
            this.Revard_tb.Location = new System.Drawing.Point(164, 285);
            this.Revard_tb.Name = "Revard_tb";
            this.Revard_tb.Size = new System.Drawing.Size(100, 26);
            this.Revard_tb.TabIndex = 19;
            this.Revard_tb.Text = "0";
            this.Revard_tb.TextChanged += new System.EventHandler(this.Revard_tb_TextChanged);
            // 
            // unique_time_tb
            // 
            this.unique_time_tb.Location = new System.Drawing.Point(10, 284);
            this.unique_time_tb.Name = "unique_time_tb";
            this.unique_time_tb.Size = new System.Drawing.Size(71, 26);
            this.unique_time_tb.TabIndex = 17;
            this.unique_time_tb.Text = "0";
            this.unique_time_tb.TextChanged += new System.EventHandler(this.Unique_time_tb_TextChanged);
            // 
            // Point_cb
            // 
            this.Point_cb.FormattingEnabled = true;
            this.Point_cb.Location = new System.Drawing.Point(87, 284);
            this.Point_cb.Name = "Point_cb";
            this.Point_cb.Size = new System.Drawing.Size(71, 27);
            this.Point_cb.TabIndex = 18;
            // 
            // Object_cb
            // 
            this.Object_cb.FormattingEnabled = true;
            this.Object_cb.Location = new System.Drawing.Point(10, 224);
            this.Object_cb.Name = "Object_cb";
            this.Object_cb.Size = new System.Drawing.Size(222, 27);
            this.Object_cb.TabIndex = 16;
            // 
            // DeleteAction_btn
            // 
            this.DeleteAction_btn.Location = new System.Drawing.Point(368, 205);
            this.DeleteAction_btn.Name = "DeleteAction_btn";
            this.DeleteAction_btn.Size = new System.Drawing.Size(50, 30);
            this.DeleteAction_btn.TabIndex = 3;
            this.DeleteAction_btn.Text = "X";
            this.DeleteAction_btn.UseVisualStyleBackColor = true;
            this.DeleteAction_btn.Click += new System.EventHandler(this.DeleteAction_btn_Click);
            // 
            // AddAction_btn
            // 
            this.AddAction_btn.Location = new System.Drawing.Point(368, 280);
            this.AddAction_btn.Name = "AddAction_btn";
            this.AddAction_btn.Size = new System.Drawing.Size(50, 30);
            this.AddAction_btn.TabIndex = 20;
            this.AddAction_btn.Text = "+";
            this.AddAction_btn.UseVisualStyleBackColor = true;
            this.AddAction_btn.Click += new System.EventHandler(this.AddAction_btn_Click);
            // 
            // Actions_dgv
            // 
            this.Actions_dgv.AllowUserToAddRows = false;
            this.Actions_dgv.AllowUserToDeleteRows = false;
            this.Actions_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Actions_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Object,
            this.time,
            this.Point,
            this.Money});
            this.Actions_dgv.Location = new System.Drawing.Point(6, 28);
            this.Actions_dgv.Name = "Actions_dgv";
            this.Actions_dgv.ReadOnly = true;
            this.Actions_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Actions_dgv.Size = new System.Drawing.Size(414, 171);
            this.Actions_dgv.TabIndex = 1;
            this.Actions_dgv.DoubleClick += new System.EventHandler(this.Actions_dgv_DoubleClick);
            // 
            // Object
            // 
            this.Object.HeaderText = "Продукт";
            this.Object.Name = "Object";
            this.Object.ReadOnly = true;
            this.Object.Width = 150;
            // 
            // time
            // 
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 60;
            // 
            // Point
            // 
            this.Point.HeaderText = "Точка";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            this.Point.Width = 60;
            // 
            // Money
            // 
            this.Money.HeaderText = "Награда";
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            this.Money.Width = 80;
            // 
            // Products_gb
            // 
            this.Products_gb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_gb.Controls.Add(this.AddProduct_btn);
            this.Products_gb.Controls.Add(this.DelProduct_btn);
            this.Products_gb.Controls.Add(this.Product_count_tb);
            this.Products_gb.Controls.Add(this.Product_cb);
            this.Products_gb.Controls.Add(this.Produtts_dgv);
            this.Products_gb.Location = new System.Drawing.Point(87, 90);
            this.Products_gb.Name = "Products_gb";
            this.Products_gb.Size = new System.Drawing.Size(353, 260);
            this.Products_gb.TabIndex = 9;
            this.Products_gb.TabStop = false;
            this.Products_gb.Text = "Продукты";
            // 
            // AddProduct_btn
            // 
            this.AddProduct_btn.Location = new System.Drawing.Point(311, 216);
            this.AddProduct_btn.Name = "AddProduct_btn";
            this.AddProduct_btn.Size = new System.Drawing.Size(38, 36);
            this.AddProduct_btn.TabIndex = 15;
            this.AddProduct_btn.Text = "+";
            this.AddProduct_btn.UseVisualStyleBackColor = true;
            this.AddProduct_btn.Click += new System.EventHandler(this.AddProduct_btn_Click);
            // 
            // DelProduct_btn
            // 
            this.DelProduct_btn.Location = new System.Drawing.Point(305, 28);
            this.DelProduct_btn.Name = "DelProduct_btn";
            this.DelProduct_btn.Size = new System.Drawing.Size(44, 36);
            this.DelProduct_btn.TabIndex = 12;
            this.DelProduct_btn.Text = "X";
            this.DelProduct_btn.UseVisualStyleBackColor = true;
            this.DelProduct_btn.Click += new System.EventHandler(this.DelProduct_btn_Click);
            // 
            // Product_count_tb
            // 
            this.Product_count_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_count_tb.Location = new System.Drawing.Point(260, 223);
            this.Product_count_tb.Name = "Product_count_tb";
            this.Product_count_tb.Size = new System.Drawing.Size(42, 29);
            this.Product_count_tb.TabIndex = 14;
            this.Product_count_tb.Text = "1";
            this.Product_count_tb.TextChanged += new System.EventHandler(this.Product_count_tb_TextChanged);
            // 
            // Product_cb
            // 
            this.Product_cb.FormattingEnabled = true;
            this.Product_cb.Location = new System.Drawing.Point(12, 225);
            this.Product_cb.Name = "Product_cb";
            this.Product_cb.Size = new System.Drawing.Size(242, 27);
            this.Product_cb.TabIndex = 13;
            // 
            // Produtts_dgv
            // 
            this.Produtts_dgv.AllowUserToAddRows = false;
            this.Produtts_dgv.AllowUserToDeleteRows = false;
            this.Produtts_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Produtts_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Count});
            this.Produtts_dgv.Location = new System.Drawing.Point(12, 28);
            this.Produtts_dgv.Name = "Produtts_dgv";
            this.Produtts_dgv.ReadOnly = true;
            this.Produtts_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Produtts_dgv.Size = new System.Drawing.Size(290, 171);
            this.Produtts_dgv.TabIndex = 0;
            this.Produtts_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Produtts_dgv_CellDoubleClick);
            // 
            // Product
            // 
            this.Product.HeaderText = "Продукт";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 150;
            // 
            // Count
            // 
            this.Count.HeaderText = "Кол-во";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 80;
            // 
            // CharacterMoney_tb
            // 
            this.CharacterMoney_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharacterMoney_tb.Location = new System.Drawing.Point(387, 45);
            this.CharacterMoney_tb.Name = "CharacterMoney_tb";
            this.CharacterMoney_tb.Size = new System.Drawing.Size(60, 26);
            this.CharacterMoney_tb.TabIndex = 12;
            this.CharacterMoney_tb.TextChanged += new System.EventHandler(this.CharacterMoney_tb_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(324, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Деньги";
            // 
            // Spawn_tb
            // 
            this.Spawn_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spawn_tb.Location = new System.Drawing.Point(387, 14);
            this.Spawn_tb.Name = "Spawn_tb";
            this.Spawn_tb.Size = new System.Drawing.Size(60, 26);
            this.Spawn_tb.TabIndex = 11;
            this.Spawn_tb.TextChanged += new System.EventHandler(this.Spawn_tb_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(329, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Спавн";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(83, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Персонаж";
            // 
            // Character_cb
            // 
            this.Character_cb.FormattingEnabled = true;
            this.Character_cb.Location = new System.Drawing.Point(169, 17);
            this.Character_cb.Name = "Character_cb";
            this.Character_cb.Size = new System.Drawing.Size(150, 27);
            this.Character_cb.TabIndex = 10;
            this.Character_cb.SelectedValueChanged += new System.EventHandler(this.Character_cb_SelectedValueChanged);
            // 
            // LevelOptions_gb
            // 
            this.LevelOptions_gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LevelOptions_gb.Controls.Add(this.SaveAsLevel_btn);
            this.LevelOptions_gb.Controls.Add(this.Event_cb);
            this.LevelOptions_gb.Controls.Add(this.label12);
            this.LevelOptions_gb.Controls.Add(this.Time_tb);
            this.LevelOptions_gb.Controls.Add(this.Goal_tb);
            this.LevelOptions_gb.Controls.Add(this.SaveLevel_btn);
            this.LevelOptions_gb.Controls.Add(this.MoneyCount_tb);
            this.LevelOptions_gb.Controls.Add(this.LoadLevel_btn);
            this.LevelOptions_gb.Controls.Add(this.GoalStar_tb);
            this.LevelOptions_gb.Controls.Add(this.label8);
            this.LevelOptions_gb.Controls.Add(this.CharacterCount_tb);
            this.LevelOptions_gb.Controls.Add(this.label7);
            this.LevelOptions_gb.Controls.Add(this.CatTime_tb);
            this.LevelOptions_gb.Controls.Add(this.label6);
            this.LevelOptions_gb.Controls.Add(this.label5);
            this.LevelOptions_gb.Controls.Add(this.label4);
            this.LevelOptions_gb.Controls.Add(this.label3);
            this.LevelOptions_gb.Controls.Add(this.Level_cb);
            this.LevelOptions_gb.Controls.Add(this.label2);
            this.LevelOptions_gb.Controls.Add(this.label1);
            this.LevelOptions_gb.Controls.Add(this.Location_cb);
            this.LevelOptions_gb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelOptions_gb.Location = new System.Drawing.Point(6, 27);
            this.LevelOptions_gb.Name = "LevelOptions_gb";
            this.LevelOptions_gb.Size = new System.Drawing.Size(331, 476);
            this.LevelOptions_gb.TabIndex = 0;
            this.LevelOptions_gb.TabStop = false;
            this.LevelOptions_gb.Text = "Настройки уровня";
            // 
            // SaveAsLevel_btn
            // 
            this.SaveAsLevel_btn.Location = new System.Drawing.Point(224, 107);
            this.SaveAsLevel_btn.Name = "SaveAsLevel_btn";
            this.SaveAsLevel_btn.Size = new System.Drawing.Size(95, 45);
            this.SaveAsLevel_btn.TabIndex = 20;
            this.SaveAsLevel_btn.Text = "Save As";
            this.SaveAsLevel_btn.UseVisualStyleBackColor = true;
            this.SaveAsLevel_btn.Click += new System.EventHandler(this.SaveAsLevel_btn_Click);
            // 
            // Event_cb
            // 
            this.Event_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Event_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Event_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Event_cb.FormattingEnabled = true;
            this.Event_cb.Location = new System.Drawing.Point(12, 433);
            this.Event_cb.Name = "Event_cb";
            this.Event_cb.Size = new System.Drawing.Size(268, 28);
            this.Event_cb.TabIndex = 9;
            this.Event_cb.SelectedValueChanged += new System.EventHandler(this.Event_cb_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Спец. событие уровня";
            // 
            // Time_tb
            // 
            this.Time_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_tb.Location = new System.Drawing.Point(259, 190);
            this.Time_tb.Name = "Time_tb";
            this.Time_tb.Size = new System.Drawing.Size(60, 26);
            this.Time_tb.TabIndex = 3;
            this.Time_tb.TextChanged += new System.EventHandler(this.Time_tb_TextChanged);
            // 
            // Goal_tb
            // 
            this.Goal_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Goal_tb.Location = new System.Drawing.Point(258, 225);
            this.Goal_tb.Name = "Goal_tb";
            this.Goal_tb.Size = new System.Drawing.Size(61, 26);
            this.Goal_tb.TabIndex = 4;
            this.Goal_tb.TextChanged += new System.EventHandler(this.Goal_tb_TextChanged);
            // 
            // SaveLevel_btn
            // 
            this.SaveLevel_btn.Location = new System.Drawing.Point(119, 107);
            this.SaveLevel_btn.Name = "SaveLevel_btn";
            this.SaveLevel_btn.Size = new System.Drawing.Size(95, 45);
            this.SaveLevel_btn.TabIndex = 16;
            this.SaveLevel_btn.Text = "Save";
            this.SaveLevel_btn.UseVisualStyleBackColor = true;
            this.SaveLevel_btn.Click += new System.EventHandler(this.SaveLevel_btn_Click);
            // 
            // MoneyCount_tb
            // 
            this.MoneyCount_tb.Enabled = false;
            this.MoneyCount_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyCount_tb.Location = new System.Drawing.Point(258, 365);
            this.MoneyCount_tb.Name = "MoneyCount_tb";
            this.MoneyCount_tb.Size = new System.Drawing.Size(61, 26);
            this.MoneyCount_tb.TabIndex = 8;
            // 
            // LoadLevel_btn
            // 
            this.LoadLevel_btn.Location = new System.Drawing.Point(12, 107);
            this.LoadLevel_btn.Name = "LoadLevel_btn";
            this.LoadLevel_btn.Size = new System.Drawing.Size(95, 45);
            this.LoadLevel_btn.TabIndex = 2;
            this.LoadLevel_btn.Text = "Load";
            this.LoadLevel_btn.UseVisualStyleBackColor = true;
            this.LoadLevel_btn.Click += new System.EventHandler(this.LoadLevelBtn_Click);
            // 
            // GoalStar_tb
            // 
            this.GoalStar_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoalStar_tb.Location = new System.Drawing.Point(259, 260);
            this.GoalStar_tb.Name = "GoalStar_tb";
            this.GoalStar_tb.Size = new System.Drawing.Size(60, 26);
            this.GoalStar_tb.TabIndex = 5;
            this.GoalStar_tb.TextChanged += new System.EventHandler(this.GoalStar_tb_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Сумма за уровень";
            // 
            // CharacterCount_tb
            // 
            this.CharacterCount_tb.Enabled = false;
            this.CharacterCount_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharacterCount_tb.Location = new System.Drawing.Point(259, 330);
            this.CharacterCount_tb.Name = "CharacterCount_tb";
            this.CharacterCount_tb.Size = new System.Drawing.Size(60, 26);
            this.CharacterCount_tb.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Кол-во Персов";
            // 
            // CatTime_tb
            // 
            this.CatTime_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatTime_tb.Location = new System.Drawing.Point(258, 295);
            this.CatTime_tb.Name = "CatTime_tb";
            this.CatTime_tb.Size = new System.Drawing.Size(61, 26);
            this.CatTime_tb.TabIndex = 6;
            this.CatTime_tb.TextChanged += new System.EventHandler(this.CatTime_tb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Интервал кормления кота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Цель для звезды";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Длительность уровня";
            // 
            // Level_cb
            // 
            this.Level_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Level_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Level_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level_cb.FormattingEnabled = true;
            this.Level_cb.Location = new System.Drawing.Point(258, 61);
            this.Level_cb.Name = "Level_cb";
            this.Level_cb.Size = new System.Drawing.Size(61, 28);
            this.Level_cb.TabIndex = 1;
            this.Level_cb.SelectedValueChanged += new System.EventHandler(this.LevelCB_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(120, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Уровень";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Локация";
            // 
            // Location_cb
            // 
            this.Location_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Location_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location_cb.FormattingEnabled = true;
            this.Location_cb.Location = new System.Drawing.Point(96, 29);
            this.Location_cb.Name = "Location_cb";
            this.Location_cb.Size = new System.Drawing.Size(223, 28);
            this.Location_cb.TabIndex = 0;
            this.Location_cb.SelectedValueChanged += new System.EventHandler(this.LocationCB_SelectedValueChanged);
            // 
            // OpenAv_btn
            // 
            this.OpenAv_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenAv_btn.Location = new System.Drawing.Point(16, 659);
            this.OpenAv_btn.Name = "OpenAv_btn";
            this.OpenAv_btn.Size = new System.Drawing.Size(149, 36);
            this.OpenAv_btn.TabIndex = 18;
            this.OpenAv_btn.Text = "Настройка продуктов";
            this.OpenAv_btn.UseVisualStyleBackColor = true;
            this.OpenAv_btn.Click += new System.EventHandler(this.OpenAv_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 717);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1260, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.ReloadMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 739);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.OpenAv_btn);
            this.Controls.Add(this.CharacterSettings_gb);
            this.Controls.Add(this.Characters_gb);
            this.Controls.Add(this.LevelOptions_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Locaton Editor v1.6";
            this.Resize += new System.EventHandler(this.Main_SizeChanged);
            this.Characters_gb.ResumeLayout(false);
            this.CharacterSettings_gb.ResumeLayout(false);
            this.CharacterSettings_gb.PerformLayout();
            this.Actions_gb.ResumeLayout(false);
            this.Actions_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Actions_dgv)).EndInit();
            this.Products_gb.ResumeLayout(false);
            this.Products_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Produtts_dgv)).EndInit();
            this.LevelOptions_gb.ResumeLayout(false);
            this.LevelOptions_gb.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox LevelOptions_gb;
        private System.Windows.Forms.TextBox Time_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Level_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Location_cb;
        private System.Windows.Forms.TextBox CatTime_tb;
        private System.Windows.Forms.TextBox GoalStar_tb;
        private System.Windows.Forms.TextBox Goal_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MoneyCount_tb;
        private System.Windows.Forms.TextBox CharacterCount_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveLevel_btn;
        private System.Windows.Forms.Button LoadLevel_btn;
        private System.Windows.Forms.GroupBox CharacterSettings_gb;
        private System.Windows.Forms.ComboBox Character_cb;
        private System.Windows.Forms.TextBox Spawn_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CharacterMoney_tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox Actions_gb;
        private System.Windows.Forms.GroupBox Products_gb;
        private System.Windows.Forms.ComboBox Event_cb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Characters_gb;
        private System.Windows.Forms.Button OpenAv_btn;
        private System.Windows.Forms.ComboBox Product_cb;
        private System.Windows.Forms.DataGridView Produtts_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridView Actions_dgv;
        private System.Windows.Forms.TextBox Product_count_tb;
        private System.Windows.Forms.Button DelProduct_btn;
        private System.Windows.Forms.Button AddProduct_btn;
        private System.Windows.Forms.Button DeleteAction_btn;
        private System.Windows.Forms.Button AddAction_btn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Revard_tb;
        private System.Windows.Forms.TextBox unique_time_tb;
        private System.Windows.Forms.ComboBox Point_cb;
        private System.Windows.Forms.ComboBox Object_cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Object;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.Button AddCharacter_btn;
        private System.Windows.Forms.Button DelCharacter_btn;
        private System.Windows.Forms.Button CloneCharacter_btn;
        private System.Windows.Forms.Panel Characters_panel;
        private System.Windows.Forms.Button MoveDownCharacter_btn;
        private System.Windows.Forms.Button MoveUpCharacter_btn;
        private System.Windows.Forms.Button SaveAsLevel_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.ComboBox CbCharStyle;
        private System.Windows.Forms.Label label17;
    }
}

