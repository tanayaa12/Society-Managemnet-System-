namespace login
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.StaffN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.StaffWork = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.StaffNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.StaffAdd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.StaffSalry = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.staffdata = new Guna.UI.WinForms.GunaDataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.staffdata)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffN
            // 
            this.StaffN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StaffN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffN.HintForeColor = System.Drawing.Color.Empty;
            this.StaffN.HintText = "";
            this.StaffN.isPassword = false;
            this.StaffN.LineFocusedColor = System.Drawing.Color.Blue;
            this.StaffN.LineIdleColor = System.Drawing.Color.Gray;
            this.StaffN.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.StaffN.LineThickness = 3;
            this.StaffN.Location = new System.Drawing.Point(13, 212);
            this.StaffN.Margin = new System.Windows.Forms.Padding(4);
            this.StaffN.Name = "StaffN";
            this.StaffN.Size = new System.Drawing.Size(370, 59);
            this.StaffN.TabIndex = 0;
            this.StaffN.Text = "Staff Name";
            this.StaffN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // StaffWork
            // 
            this.StaffWork.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffWork.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StaffWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffWork.HintForeColor = System.Drawing.Color.Empty;
            this.StaffWork.HintText = "";
            this.StaffWork.isPassword = false;
            this.StaffWork.LineFocusedColor = System.Drawing.Color.Blue;
            this.StaffWork.LineIdleColor = System.Drawing.Color.Gray;
            this.StaffWork.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.StaffWork.LineThickness = 3;
            this.StaffWork.Location = new System.Drawing.Point(13, 290);
            this.StaffWork.Margin = new System.Windows.Forms.Padding(4);
            this.StaffWork.Name = "StaffWork";
            this.StaffWork.Size = new System.Drawing.Size(370, 63);
            this.StaffWork.TabIndex = 1;
            this.StaffWork.Text = "Type Of Work";
            this.StaffWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // StaffNo
            // 
            this.StaffNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StaffNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffNo.HintForeColor = System.Drawing.Color.Empty;
            this.StaffNo.HintText = "";
            this.StaffNo.isPassword = false;
            this.StaffNo.LineFocusedColor = System.Drawing.Color.Blue;
            this.StaffNo.LineIdleColor = System.Drawing.Color.Gray;
            this.StaffNo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.StaffNo.LineThickness = 3;
            this.StaffNo.Location = new System.Drawing.Point(13, 374);
            this.StaffNo.Margin = new System.Windows.Forms.Padding(4);
            this.StaffNo.Name = "StaffNo";
            this.StaffNo.Size = new System.Drawing.Size(370, 61);
            this.StaffNo.TabIndex = 2;
            this.StaffNo.Text = "Mobile Number";
            this.StaffNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StaffNo.OnValueChanged += new System.EventHandler(this.StaffNo_OnValueChanged);
            // 
            // StaffAdd
            // 
            this.StaffAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StaffAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffAdd.HintForeColor = System.Drawing.Color.Empty;
            this.StaffAdd.HintText = "";
            this.StaffAdd.isPassword = false;
            this.StaffAdd.LineFocusedColor = System.Drawing.Color.Blue;
            this.StaffAdd.LineIdleColor = System.Drawing.Color.Gray;
            this.StaffAdd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.StaffAdd.LineThickness = 3;
            this.StaffAdd.Location = new System.Drawing.Point(13, 443);
            this.StaffAdd.Margin = new System.Windows.Forms.Padding(4);
            this.StaffAdd.Name = "StaffAdd";
            this.StaffAdd.Size = new System.Drawing.Size(370, 56);
            this.StaffAdd.TabIndex = 3;
            this.StaffAdd.Text = "Address";
            this.StaffAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // StaffSalry
            // 
            this.StaffSalry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffSalry.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StaffSalry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffSalry.HintForeColor = System.Drawing.Color.Empty;
            this.StaffSalry.HintText = "";
            this.StaffSalry.isPassword = false;
            this.StaffSalry.LineFocusedColor = System.Drawing.Color.Blue;
            this.StaffSalry.LineIdleColor = System.Drawing.Color.Gray;
            this.StaffSalry.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.StaffSalry.LineThickness = 3;
            this.StaffSalry.Location = new System.Drawing.Point(13, 507);
            this.StaffSalry.Margin = new System.Windows.Forms.Padding(4);
            this.StaffSalry.Name = "StaffSalry";
            this.StaffSalry.Size = new System.Drawing.Size(370, 51);
            this.StaffSalry.TabIndex = 4;
            this.StaffSalry.Text = "Salary";
            this.StaffSalry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(27, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(189, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // staffdata
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.staffdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffdata.BackgroundColor = System.Drawing.Color.White;
            this.staffdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffdata.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.staffdata.EnableHeadersVisualStyles = false;
            this.staffdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffdata.Location = new System.Drawing.Point(426, 203);
            this.staffdata.Name = "staffdata";
            this.staffdata.RowHeadersVisible = false;
            this.staffdata.RowHeadersWidth = 62;
            this.staffdata.RowTemplate.Height = 28;
            this.staffdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffdata.Size = new System.Drawing.Size(716, 407);
            this.staffdata.TabIndex = 9;
            this.staffdata.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.staffdata.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.staffdata.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.staffdata.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.staffdata.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.staffdata.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.staffdata.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.staffdata.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffdata.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.staffdata.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.staffdata.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.staffdata.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.staffdata.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.staffdata.ThemeStyle.HeaderStyle.Height = 4;
            this.staffdata.ThemeStyle.ReadOnly = false;
            this.staffdata.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.staffdata.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffdata.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.staffdata.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.staffdata.ThemeStyle.RowsStyle.Height = 28;
            this.staffdata.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffdata.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(316, 567);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 43);
            this.button3.TabIndex = 12;
            this.button3.Text = "HOME";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(139, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "           STAFF";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 112);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.staffdata);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StaffSalry);
            this.Controls.Add(this.StaffAdd);
            this.Controls.Add(this.StaffNo);
            this.Controls.Add(this.StaffWork);
            this.Controls.Add(this.StaffN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffdata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox StaffN;
        private Bunifu.Framework.UI.BunifuMaterialTextbox StaffWork;
        private Bunifu.Framework.UI.BunifuMaterialTextbox StaffNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox StaffAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox StaffSalry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI.WinForms.GunaDataGridView staffdata;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}