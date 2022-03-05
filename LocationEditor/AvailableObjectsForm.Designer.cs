namespace LocationEditor
{
    partial class AvailableObjectsForm
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
            this.CbLocation = new System.Windows.Forms.ComboBox();
            this.CbLevel = new System.Windows.Forms.ComboBox();
            this.CbSceneObject = new System.Windows.Forms.ComboBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.AvGridV = new System.Windows.Forms.DataGridView();
            this.SceneObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvGridV)).BeginInit();
            this.SuspendLayout();
            // 
            // CbLocation
            // 
            this.CbLocation.Location = new System.Drawing.Point(15, 14);
            this.CbLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbLocation.Name = "CbLocation";
            this.CbLocation.Size = new System.Drawing.Size(273, 30);
            this.CbLocation.TabIndex = 6;
            this.CbLocation.SelectedValueChanged += new System.EventHandler(this.CbLocation_SelectedValueChanged);
            // 
            // CbLevel
            // 
            this.CbLevel.Location = new System.Drawing.Point(296, 14);
            this.CbLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbLevel.Name = "CbLevel";
            this.CbLevel.Size = new System.Drawing.Size(80, 30);
            this.CbLevel.TabIndex = 5;
            this.CbLevel.SelectedValueChanged += new System.EventHandler(this.CbLevel_SelectedValueChanged);
            // 
            // CbSceneObject
            // 
            this.CbSceneObject.Location = new System.Drawing.Point(384, 14);
            this.CbSceneObject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbSceneObject.Name = "CbSceneObject";
            this.CbSceneObject.Size = new System.Drawing.Size(362, 30);
            this.CbSceneObject.TabIndex = 4;
            this.CbSceneObject.SelectedValueChanged += new System.EventHandler(this.CbSceneObject_SelectedValueChanged);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(599, 67);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(148, 39);
            this.Add_btn.TabIndex = 3;
            this.Add_btn.Text = "Добавить";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(599, 419);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(148, 96);
            this.Save_btn.TabIndex = 9;
            this.Save_btn.Text = "Сохранить в файл";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // AvGridV
            // 
            this.AvGridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvGridV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SceneObject,
            this.lvl});
            this.AvGridV.Location = new System.Drawing.Point(15, 67);
            this.AvGridV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvGridV.Name = "AvGridV";
            this.AvGridV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AvGridV.Size = new System.Drawing.Size(576, 448);
            this.AvGridV.TabIndex = 10;
            this.AvGridV.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.AvGridV_ColumnAdded);
            // 
            // SceneObject
            // 
            this.SceneObject.HeaderText = "Продукт";
            this.SceneObject.Name = "SceneObject";
            this.SceneObject.Width = 300;
            // 
            // lvl
            // 
            this.lvl.HeaderText = "Уровень";
            this.lvl.Name = "lvl";
            // 
            // Del_btn
            // 
            this.Del_btn.Location = new System.Drawing.Point(599, 116);
            this.Del_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(148, 39);
            this.Del_btn.TabIndex = 11;
            this.Del_btn.Text = "Удалить";
            this.Del_btn.UseVisualStyleBackColor = true;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // AvailableObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 523);
            this.Controls.Add(this.Del_btn);
            this.Controls.Add(this.AvGridV);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.CbSceneObject);
            this.Controls.Add(this.CbLevel);
            this.Controls.Add(this.CbLocation);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AvailableObjects";
            this.Text = "Настройка продуктов на уровне";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AvailableObjects_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.AvGridV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbLocation;
        private System.Windows.Forms.ComboBox CbLevel;
        private System.Windows.Forms.ComboBox CbSceneObject;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.DataGridView AvGridV;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SceneObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvl;
    }
}