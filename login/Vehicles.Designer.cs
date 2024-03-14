namespace login
{
    partial class Vehicles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Residentsdta = new Guna.UI.WinForms.GunaDataGridView();
            this.VehiName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.VehiID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.VehiOwner = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ParkingSlot = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Residentsdta)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-299, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1664, 114);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1188, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "                          VEHICLES";
            // 
            // Residentsdta
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.Residentsdta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Residentsdta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Residentsdta.BackgroundColor = System.Drawing.Color.White;
            this.Residentsdta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Residentsdta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Residentsdta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Residentsdta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Residentsdta.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Residentsdta.DefaultCellStyle = dataGridViewCellStyle9;
            this.Residentsdta.EnableHeadersVisualStyles = false;
            this.Residentsdta.GridColor = System.Drawing.Color.LightSkyBlue;
            this.Residentsdta.Location = new System.Drawing.Point(421, 144);
            this.Residentsdta.Name = "Residentsdta";
            this.Residentsdta.RowHeadersVisible = false;
            this.Residentsdta.RowHeadersWidth = 62;
            this.Residentsdta.RowTemplate.Height = 28;
            this.Residentsdta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Residentsdta.Size = new System.Drawing.Size(834, 402);
            this.Residentsdta.TabIndex = 8;
            this.Residentsdta.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.Residentsdta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Residentsdta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Residentsdta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Residentsdta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Residentsdta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Residentsdta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Residentsdta.ThemeStyle.GridColor = System.Drawing.Color.LightSkyBlue;
            this.Residentsdta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Residentsdta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Residentsdta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Residentsdta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Residentsdta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Residentsdta.ThemeStyle.HeaderStyle.Height = 4;
            this.Residentsdta.ThemeStyle.ReadOnly = false;
            this.Residentsdta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Residentsdta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Residentsdta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Residentsdta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Residentsdta.ThemeStyle.RowsStyle.Height = 28;
            this.Residentsdta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Residentsdta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // VehiName
            // 
            this.VehiName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VehiName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.VehiName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VehiName.HintForeColor = System.Drawing.Color.Empty;
            this.VehiName.HintText = "";
            this.VehiName.isPassword = false;
            this.VehiName.LineFocusedColor = System.Drawing.Color.Blue;
            this.VehiName.LineIdleColor = System.Drawing.Color.Gray;
            this.VehiName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.VehiName.LineThickness = 3;
            this.VehiName.Location = new System.Drawing.Point(13, 218);
            this.VehiName.Margin = new System.Windows.Forms.Padding(4);
            this.VehiName.Name = "VehiName";
            this.VehiName.Size = new System.Drawing.Size(370, 78);
            this.VehiName.TabIndex = 9;
            this.VehiName.Text = "VehiName";
            this.VehiName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // VehiID
            // 
            this.VehiID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VehiID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.VehiID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VehiID.HintForeColor = System.Drawing.Color.Empty;
            this.VehiID.HintText = "";
            this.VehiID.isPassword = false;
            this.VehiID.LineFocusedColor = System.Drawing.Color.Blue;
            this.VehiID.LineIdleColor = System.Drawing.Color.Gray;
            this.VehiID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.VehiID.LineThickness = 3;
            this.VehiID.Location = new System.Drawing.Point(12, 121);
            this.VehiID.Margin = new System.Windows.Forms.Padding(4);
            this.VehiID.Name = "VehiID";
            this.VehiID.Size = new System.Drawing.Size(370, 89);
            this.VehiID.TabIndex = 10;
            this.VehiID.Text = "VehiID";
            this.VehiID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.VehiID.OnValueChanged += new System.EventHandler(this.VehicleID_OnValueChanged);
            // 
            // VehiOwner
            // 
            this.VehiOwner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VehiOwner.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.VehiOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VehiOwner.HintForeColor = System.Drawing.Color.Empty;
            this.VehiOwner.HintText = "";
            this.VehiOwner.isPassword = false;
            this.VehiOwner.LineFocusedColor = System.Drawing.Color.Blue;
            this.VehiOwner.LineIdleColor = System.Drawing.Color.Gray;
            this.VehiOwner.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.VehiOwner.LineThickness = 3;
            this.VehiOwner.Location = new System.Drawing.Point(12, 304);
            this.VehiOwner.Margin = new System.Windows.Forms.Padding(4);
            this.VehiOwner.Name = "VehiOwner";
            this.VehiOwner.Size = new System.Drawing.Size(370, 78);
            this.VehiOwner.TabIndex = 11;
            this.VehiOwner.Text = "VehiOwner";
            this.VehiOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ParkingSlot
            // 
            this.ParkingSlot.FormattingEnabled = true;
            this.ParkingSlot.Items.AddRange(new object[] {
            "A100",
            "A101",
            "1102",
            "A103",
            "A104",
            "A105",
            "B100",
            "B101",
            "B102",
            "B103",
            "B104",
            "B105",
            "C101",
            "C102",
            "C103",
            "C104",
            "C105",
            "D101",
            "D102",
            "D103",
            "D104",
            "D105",
            "E101",
            "E102",
            "E103",
            "E104",
            "E105"});
            this.ParkingSlot.Location = new System.Drawing.Point(12, 407);
            this.ParkingSlot.Name = "ParkingSlot";
            this.ParkingSlot.Size = new System.Drawing.Size(163, 28);
            this.ParkingSlot.TabIndex = 12;
            this.ParkingSlot.Text = "ParkingSlot";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Black;
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(12, 492);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(107, 54);
            this.add.TabIndex = 13;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Black;
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(141, 492);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(123, 54);
            this.update.TabIndex = 14;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Black;
            this.Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete.Location = new System.Drawing.Point(290, 492);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 54);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Black;
            this.home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.home.Location = new System.Drawing.Point(141, 568);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(123, 54);
            this.home.TabIndex = 16;
            this.home.Text = "HOME";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 666);
            this.Controls.Add(this.home);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.ParkingSlot);
            this.Controls.Add(this.VehiOwner);
            this.Controls.Add(this.VehiID);
            this.Controls.Add(this.VehiName);
            this.Controls.Add(this.Residentsdta);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Residentsdta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView Residentsdta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox VehiName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox VehiID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox VehiOwner;
        private System.Windows.Forms.ComboBox ParkingSlot;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button home;
    }
}