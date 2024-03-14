namespace login
{
    partial class residents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add = new System.Windows.Forms.Button();
            this.FlatNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ResiN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Building = new System.Windows.Forms.ComboBox();
            this.YouAre = new System.Windows.Forms.ComboBox();
            this.Residentsdta = new Guna.UI.WinForms.GunaDataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Residentsdta)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Black;
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(13, 458);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(85, 54);
            this.add.TabIndex = 2;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // FlatNo
            // 
            this.FlatNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FlatNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FlatNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FlatNo.HintForeColor = System.Drawing.Color.Empty;
            this.FlatNo.HintText = "";
            this.FlatNo.isPassword = false;
            this.FlatNo.LineFocusedColor = System.Drawing.Color.Blue;
            this.FlatNo.LineIdleColor = System.Drawing.Color.Gray;
            this.FlatNo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.FlatNo.LineThickness = 3;
            this.FlatNo.Location = new System.Drawing.Point(2, 232);
            this.FlatNo.Margin = new System.Windows.Forms.Padding(4);
            this.FlatNo.Name = "FlatNo";
            this.FlatNo.Size = new System.Drawing.Size(370, 89);
            this.FlatNo.TabIndex = 1;
            this.FlatNo.Text = "FlatNo";
            this.FlatNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FlatNo.OnValueChanged += new System.EventHandler(this.FlatNo_OnValueChanged);
            // 
            // ResiN
            // 
            this.ResiN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResiN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ResiN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResiN.HintForeColor = System.Drawing.Color.Empty;
            this.ResiN.HintText = "";
            this.ResiN.isPassword = false;
            this.ResiN.LineFocusedColor = System.Drawing.Color.Blue;
            this.ResiN.LineIdleColor = System.Drawing.Color.Gray;
            this.ResiN.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ResiN.LineThickness = 3;
            this.ResiN.Location = new System.Drawing.Point(2, 146);
            this.ResiN.Margin = new System.Windows.Forms.Padding(4);
            this.ResiN.Name = "ResiN";
            this.ResiN.Size = new System.Drawing.Size(370, 78);
            this.ResiN.TabIndex = 0;
            this.ResiN.Text = "ResiN";
            this.ResiN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Building
            // 
            this.Building.FormattingEnabled = true;
            this.Building.Items.AddRange(new object[] {
            "Wing A",
            "Wing B",
            "Wing C"});
            this.Building.Location = new System.Drawing.Point(13, 337);
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(121, 28);
            this.Building.TabIndex = 3;
            this.Building.Text = "Building";
            this.Building.SelectedIndexChanged += new System.EventHandler(this.Building_SelectedIndexChanged);
            // 
            // YouAre
            // 
            this.YouAre.FormattingEnabled = true;
            this.YouAre.Items.AddRange(new object[] {
            "On Rent",
            "Permanent"});
            this.YouAre.Location = new System.Drawing.Point(13, 401);
            this.YouAre.Name = "YouAre";
            this.YouAre.Size = new System.Drawing.Size(121, 28);
            this.YouAre.TabIndex = 4;
            this.YouAre.Text = "You Are";
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
            this.Residentsdta.Location = new System.Drawing.Point(427, 187);
            this.Residentsdta.Name = "Residentsdta";
            this.Residentsdta.RowHeadersVisible = false;
            this.Residentsdta.RowHeadersWidth = 62;
            this.Residentsdta.RowTemplate.Height = 28;
            this.Residentsdta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Residentsdta.Size = new System.Drawing.Size(834, 402);
            this.Residentsdta.TabIndex = 5;
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
            this.Residentsdta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Residentsdta_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1664, 98);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(820, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "           RESIDENTS";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Black;
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(151, 458);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(95, 54);
            this.update.TabIndex = 8;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Black;
            this.Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete.Location = new System.Drawing.Point(308, 458);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 54);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(912, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nametb
            // 
            this.Nametb.Location = new System.Drawing.Point(697, 132);
            this.Nametb.Name = "Nametb";
            this.Nametb.Size = new System.Drawing.Size(161, 26);
            this.Nametb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "SEARCH HERE ---->>";
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Black;
            this.home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.home.Location = new System.Drawing.Point(141, 535);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(105, 54);
            this.home.TabIndex = 13;
            this.home.Text = "HOME";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // residents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 601);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nametb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Residentsdta);
            this.Controls.Add(this.YouAre);
            this.Controls.Add(this.Building);
            this.Controls.Add(this.add);
            this.Controls.Add(this.FlatNo);
            this.Controls.Add(this.ResiN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "residents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "residents";
            this.Load += new System.EventHandler(this.residents_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Residentsdta)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FlatNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ResiN;
        private System.Windows.Forms.ComboBox Building;
        private System.Windows.Forms.ComboBox YouAre;
        private Guna.UI.WinForms.GunaDataGridView Residentsdta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Timer timer1;
    }
}