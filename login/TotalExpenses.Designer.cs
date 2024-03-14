namespace login
{
    partial class TotalExpenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ExAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DOES = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Desc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExpData = new Guna.UI.WinForms.GunaDataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpData)).BeginInit();
            this.SuspendLayout();
            // 
            // ExName
            // 
            this.ExName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ExName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExName.HintForeColor = System.Drawing.Color.Empty;
            this.ExName.HintText = "";
            this.ExName.isPassword = false;
            this.ExName.LineFocusedColor = System.Drawing.Color.Blue;
            this.ExName.LineIdleColor = System.Drawing.Color.Gray;
            this.ExName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ExName.LineThickness = 3;
            this.ExName.Location = new System.Drawing.Point(13, 131);
            this.ExName.Margin = new System.Windows.Forms.Padding(4);
            this.ExName.Name = "ExName";
            this.ExName.Size = new System.Drawing.Size(370, 66);
            this.ExName.TabIndex = 1;
            this.ExName.Text = "Expense Name";
            this.ExName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ExAmount
            // 
            this.ExAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ExAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExAmount.HintForeColor = System.Drawing.Color.Empty;
            this.ExAmount.HintText = "";
            this.ExAmount.isPassword = false;
            this.ExAmount.LineFocusedColor = System.Drawing.Color.Blue;
            this.ExAmount.LineIdleColor = System.Drawing.Color.Gray;
            this.ExAmount.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ExAmount.LineThickness = 3;
            this.ExAmount.Location = new System.Drawing.Point(13, 223);
            this.ExAmount.Margin = new System.Windows.Forms.Padding(4);
            this.ExAmount.Name = "ExAmount";
            this.ExAmount.Size = new System.Drawing.Size(370, 63);
            this.ExAmount.TabIndex = 2;
            this.ExAmount.Text = "Amount";
            this.ExAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DOES
            // 
            this.DOES.Location = new System.Drawing.Point(13, 321);
            this.DOES.Name = "DOES";
            this.DOES.Size = new System.Drawing.Size(200, 26);
            this.DOES.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(164, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Desc
            // 
            this.Desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Desc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Desc.HintForeColor = System.Drawing.Color.Empty;
            this.Desc.HintText = "";
            this.Desc.isPassword = false;
            this.Desc.LineFocusedColor = System.Drawing.Color.Blue;
            this.Desc.LineIdleColor = System.Drawing.Color.Gray;
            this.Desc.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Desc.LineThickness = 3;
            this.Desc.Location = new System.Drawing.Point(6, 365);
            this.Desc.Margin = new System.Windows.Forms.Padding(4);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(370, 55);
            this.Desc.TabIndex = 6;
            this.Desc.Text = "Description";
            this.Desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(6, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "TOTAL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(320, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 48);
            this.button3.TabIndex = 9;
            this.button3.Text = "MAX AMOUNT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(924, 126);
            this.label1.TabIndex = 11;
            this.label1.Text = "        TOTAL EXPENSE";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1320, 112);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // ExpData
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ExpData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ExpData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpData.BackgroundColor = System.Drawing.Color.White;
            this.ExpData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExpData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ExpData.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpData.DefaultCellStyle = dataGridViewCellStyle6;
            this.ExpData.EnableHeadersVisualStyles = false;
            this.ExpData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExpData.Location = new System.Drawing.Point(497, 131);
            this.ExpData.Name = "ExpData";
            this.ExpData.RowHeadersVisible = false;
            this.ExpData.RowHeadersWidth = 62;
            this.ExpData.RowTemplate.Height = 28;
            this.ExpData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpData.Size = new System.Drawing.Size(820, 445);
            this.ExpData.TabIndex = 12;
            this.ExpData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ExpData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ExpData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ExpData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ExpData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ExpData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ExpData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ExpData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExpData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExpData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ExpData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ExpData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ExpData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ExpData.ThemeStyle.HeaderStyle.Height = 4;
            this.ExpData.ThemeStyle.ReadOnly = false;
            this.ExpData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ExpData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExpData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ExpData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ExpData.ThemeStyle.RowsStyle.Height = 28;
            this.ExpData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExpData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(182, 518);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 43);
            this.button4.TabIndex = 14;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TotalExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 617);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ExpData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DOES);
            this.Controls.Add(this.ExAmount);
            this.Controls.Add(this.ExName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TotalExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TotalExpenses";
            this.Load += new System.EventHandler(this.TotalExpenses_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox ExName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ExAmount;
        private System.Windows.Forms.DateTimePicker DOES;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Desc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaDataGridView ExpData;
        private System.Windows.Forms.Button button4;
    }
}