namespace login
{
    partial class visitors
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
            this.VisiN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.VisiP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.DOE = new System.Windows.Forms.DateTimePicker();
            this.VisiT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.VisiD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.add = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.VisiGrid = new Guna.UI.WinForms.GunaDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // VisiN
            // 
            this.VisiN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VisiN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.VisiN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VisiN.HintForeColor = System.Drawing.Color.Empty;
            this.VisiN.HintText = "";
            this.VisiN.isPassword = false;
            this.VisiN.LineFocusedColor = System.Drawing.Color.Blue;
            this.VisiN.LineIdleColor = System.Drawing.Color.Gray;
            this.VisiN.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.VisiN.LineThickness = 3;
            this.VisiN.Location = new System.Drawing.Point(13, 99);
            this.VisiN.Margin = new System.Windows.Forms.Padding(4);
            this.VisiN.Name = "VisiN";
            this.VisiN.Size = new System.Drawing.Size(370, 57);
            this.VisiN.TabIndex = 0;
            this.VisiN.Text = "Visitor\'s Name";
            this.VisiN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // VisiP
            // 
            this.VisiP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VisiP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.VisiP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VisiP.HintForeColor = System.Drawing.Color.Empty;
            this.VisiP.HintText = "";
            this.VisiP.isPassword = false;
            this.VisiP.LineFocusedColor = System.Drawing.Color.Blue;
            this.VisiP.LineIdleColor = System.Drawing.Color.Gray;
            this.VisiP.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.VisiP.LineThickness = 3;
            this.VisiP.Location = new System.Drawing.Point(13, 164);
            this.VisiP.Margin = new System.Windows.Forms.Padding(4);
            this.VisiP.Name = "VisiP";
            this.VisiP.Size = new System.Drawing.Size(370, 53);
            this.VisiP.TabIndex = 1;
            this.VisiP.Text = "Visitors Phone Number";
            this.VisiP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Of Entry:";
            // 
            // DOE
            // 
            this.DOE.Location = new System.Drawing.Point(22, 289);
            this.DOE.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DOE.Name = "DOE";
            this.DOE.Size = new System.Drawing.Size(200, 26);
            this.DOE.TabIndex = 3;
            // 
            // VisiT
            // 
            this.VisiT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VisiT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.VisiT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VisiT.HintForeColor = System.Drawing.Color.Empty;
            this.VisiT.HintText = "";
            this.VisiT.isPassword = false;
            this.VisiT.LineFocusedColor = System.Drawing.Color.Blue;
            this.VisiT.LineIdleColor = System.Drawing.Color.Gray;
            this.VisiT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.VisiT.LineThickness = 3;
            this.VisiT.Location = new System.Drawing.Point(13, 342);
            this.VisiT.Margin = new System.Windows.Forms.Padding(4);
            this.VisiT.Name = "VisiT";
            this.VisiT.Size = new System.Drawing.Size(370, 55);
            this.VisiT.TabIndex = 4;
            this.VisiT.Text = "Entry Time";
            this.VisiT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // VisiD
            // 
            this.VisiD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VisiD.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.VisiD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VisiD.HintForeColor = System.Drawing.Color.Empty;
            this.VisiD.HintText = "";
            this.VisiD.isPassword = false;
            this.VisiD.LineFocusedColor = System.Drawing.Color.Blue;
            this.VisiD.LineIdleColor = System.Drawing.Color.Gray;
            this.VisiD.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.VisiD.LineThickness = 3;
            this.VisiD.Location = new System.Drawing.Point(13, 426);
            this.VisiD.Margin = new System.Windows.Forms.Padding(4);
            this.VisiD.Name = "VisiD";
            this.VisiD.Size = new System.Drawing.Size(370, 58);
            this.VisiD.TabIndex = 5;
            this.VisiD.Text = "Departure Time";
            this.VisiD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Black;
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(13, 515);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 41);
            this.add.TabIndex = 7;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.Black;
            this.UPDATE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UPDATE.Location = new System.Drawing.Point(173, 515);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(102, 41);
            this.UPDATE.TabIndex = 8;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.update_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.Black;
            this.DELETE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DELETE.Location = new System.Drawing.Point(313, 515);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(89, 41);
            this.DELETE.TabIndex = 9;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.delete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, -8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1806, 119);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(923, 126);
            this.label2.TabIndex = 0;
            this.label2.Text = "                  VISITORS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VisiGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.VisiGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VisiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisiGrid.BackgroundColor = System.Drawing.Color.White;
            this.VisiGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VisiGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VisiGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VisiGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VisiGrid.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VisiGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.VisiGrid.EnableHeadersVisualStyles = false;
            this.VisiGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VisiGrid.Location = new System.Drawing.Point(442, 143);
            this.VisiGrid.Name = "VisiGrid";
            this.VisiGrid.RowHeadersVisible = false;
            this.VisiGrid.RowHeadersWidth = 62;
            this.VisiGrid.RowTemplate.Height = 28;
            this.VisiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VisiGrid.Size = new System.Drawing.Size(875, 413);
            this.VisiGrid.TabIndex = 1;
            this.VisiGrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.VisiGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.VisiGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.VisiGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.VisiGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.VisiGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.VisiGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.VisiGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VisiGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.VisiGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VisiGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.VisiGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.VisiGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.VisiGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.VisiGrid.ThemeStyle.ReadOnly = false;
            this.VisiGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.VisiGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VisiGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.VisiGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.VisiGrid.ThemeStyle.RowsStyle.Height = 28;
            this.VisiGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VisiGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.VisiGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(182, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // visitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.VisiGrid);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.add);
            this.Controls.Add(this.VisiD);
            this.Controls.Add(this.VisiT);
            this.Controls.Add(this.DOE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisiP);
            this.Controls.Add(this.VisiN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "visitors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " visitors";
            this.Load += new System.EventHandler(this.visitors_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox VisiN;
        private Bunifu.Framework.UI.BunifuMaterialTextbox VisiP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DOE;
        private Bunifu.Framework.UI.BunifuMaterialTextbox VisiT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox VisiD;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView VisiGrid;
        private System.Windows.Forms.Button button1;
    }
}