namespace login
{
    partial class maintenance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ResiN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.FlatNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DOP = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.ComboBox();
            this.Building = new System.Windows.Forms.ComboBox();
            this.Maint = new Guna.UI.WinForms.GunaDataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maint)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-4, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1337, 119);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(887, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "         MAINTENANCE";
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
            this.ResiN.Location = new System.Drawing.Point(13, 126);
            this.ResiN.Margin = new System.Windows.Forms.Padding(4);
            this.ResiN.Name = "ResiN";
            this.ResiN.Size = new System.Drawing.Size(243, 64);
            this.ResiN.TabIndex = 1;
            this.ResiN.Text = "RESIDENT NAME";
            this.ResiN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.FlatNo.Location = new System.Drawing.Point(633, 130);
            this.FlatNo.Margin = new System.Windows.Forms.Padding(4);
            this.FlatNo.Name = "FlatNo";
            this.FlatNo.Size = new System.Drawing.Size(200, 64);
            this.FlatNo.TabIndex = 2;
            this.FlatNo.Text = "FLAT NO";
            this.FlatNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Amount
            // 
            this.Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Amount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Amount.HintForeColor = System.Drawing.Color.Empty;
            this.Amount.HintText = "";
            this.Amount.isPassword = false;
            this.Amount.LineFocusedColor = System.Drawing.Color.Blue;
            this.Amount.LineIdleColor = System.Drawing.Color.Gray;
            this.Amount.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Amount.LineThickness = 3;
            this.Amount.Location = new System.Drawing.Point(968, 126);
            this.Amount.Margin = new System.Windows.Forms.Padding(4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(249, 64);
            this.Amount.TabIndex = 4;
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DOP
            // 
            this.DOP.Location = new System.Drawing.Point(330, 227);
            this.DOP.Name = "DOP";
            this.DOP.Size = new System.Drawing.Size(200, 26);
            this.DOP.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(739, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1117, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Paid",
            "Pending"});
            this.Status.Location = new System.Drawing.Point(29, 226);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(188, 28);
            this.Status.TabIndex = 10;
            this.Status.Text = "Status";
            // 
            // Building
            // 
            this.Building.FormattingEnabled = true;
            this.Building.Items.AddRange(new object[] {
            "Wing A",
            "Wing B",
            "Wing C"});
            this.Building.Location = new System.Drawing.Point(330, 142);
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(161, 28);
            this.Building.TabIndex = 11;
            this.Building.Text = "Building";
            // 
            // Maint
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Maint.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Maint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Maint.BackgroundColor = System.Drawing.Color.White;
            this.Maint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Maint.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Maint.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Maint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Maint.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Maint.DefaultCellStyle = dataGridViewCellStyle3;
            this.Maint.EnableHeadersVisualStyles = false;
            this.Maint.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Maint.Location = new System.Drawing.Point(29, 291);
            this.Maint.Name = "Maint";
            this.Maint.RowHeadersVisible = false;
            this.Maint.RowHeadersWidth = 62;
            this.Maint.RowTemplate.Height = 28;
            this.Maint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Maint.Size = new System.Drawing.Size(1223, 348);
            this.Maint.TabIndex = 12;
            this.Maint.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.Maint.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Maint.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Maint.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Maint.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Maint.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Maint.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Maint.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Maint.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Maint.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Maint.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Maint.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Maint.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Maint.ThemeStyle.HeaderStyle.Height = 4;
            this.Maint.ThemeStyle.ReadOnly = false;
            this.Maint.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Maint.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Maint.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Maint.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Maint.ThemeStyle.RowsStyle.Height = 28;
            this.Maint.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Maint.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Maint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Maint_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(887, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(559, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "HOME";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 726);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Maint);
            this.Controls.Add(this.Building);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DOP);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.FlatNo);
            this.Controls.Add(this.ResiN);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "maintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "maintenance";
            this.Load += new System.EventHandler(this.maintenance_Load_1);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ResiN;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FlatNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Amount;
        private System.Windows.Forms.DateTimePicker DOP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.ComboBox Building;
        private Guna.UI.WinForms.GunaDataGridView Maint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}