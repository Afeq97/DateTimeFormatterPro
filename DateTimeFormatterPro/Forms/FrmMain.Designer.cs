namespace DateTimeFormatterPro
{
    partial class FrmMain
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.grpConverter = new System.Windows.Forms.GroupBox();
            this.tblConverter = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.flipFormat = new System.Windows.Forms.FlowLayoutPanel();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.cmbFormatPreset = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.grpConverter.SuspendLayout();
            this.tblConverter.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.flipFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.dgvHistory, 0, 1);
            this.tblMain.Controls.Add(this.grpConverter, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblMain.Size = new System.Drawing.Size(882, 603);
            this.tblMain.TabIndex = 0;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(3, 244);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(876, 356);
            this.dgvHistory.TabIndex = 9;
            // 
            // grpConverter
            // 
            this.grpConverter.Controls.Add(this.tblConverter);
            this.grpConverter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConverter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConverter.Location = new System.Drawing.Point(3, 3);
            this.grpConverter.Name = "grpConverter";
            this.grpConverter.Size = new System.Drawing.Size(876, 235);
            this.grpConverter.TabIndex = 0;
            this.grpConverter.TabStop = false;
            this.grpConverter.Text = "Date Time Converter";
            // 
            // tblConverter
            // 
            this.tblConverter.ColumnCount = 2;
            this.tblConverter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblConverter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblConverter.Controls.Add(this.lblDateTime, 0, 0);
            this.tblConverter.Controls.Add(this.dtpDateTime, 1, 0);
            this.tblConverter.Controls.Add(this.lblFormat, 0, 1);
            this.tblConverter.Controls.Add(this.lblPreview, 0, 2);
            this.tblConverter.Controls.Add(this.txtPreview, 1, 2);
            this.tblConverter.Controls.Add(this.flpButtons, 1, 3);
            this.tblConverter.Controls.Add(this.lblHistory, 0, 4);
            this.tblConverter.Controls.Add(this.flipFormat, 1, 1);
            this.tblConverter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConverter.Location = new System.Drawing.Point(3, 23);
            this.tblConverter.Name = "tblConverter";
            this.tblConverter.Padding = new System.Windows.Forms.Padding(10);
            this.tblConverter.RowCount = 5;
            this.tblConverter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConverter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConverter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConverter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConverter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConverter.Size = new System.Drawing.Size(870, 209);
            this.tblConverter.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(13, 18);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(98, 20);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Date & Time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateTime.UseMnemonic = false;
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(268, 16);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.ShowUpDown = true;
            this.dtpDateTime.Size = new System.Drawing.Size(230, 27);
            this.dtpDateTime.TabIndex = 2;
            // 
            // lblFormat
            // 
            this.lblFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(13, 55);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(118, 20);
            this.lblFormat.TabIndex = 3;
            this.lblFormat.Text = "Custom Format";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFormat.UseMnemonic = false;
            // 
            // lblPreview
            // 
            this.lblPreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(13, 92);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(64, 20);
            this.lblPreview.TabIndex = 5;
            this.lblPreview.Text = "Preview";
            this.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPreview.UseMnemonic = false;
            // 
            // txtPreview
            // 
            this.txtPreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPreview.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.Location = new System.Drawing.Point(268, 88);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(220, 29);
            this.txtPreview.TabIndex = 6;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnConvert);
            this.flpButtons.Controls.Add(this.btnCopy);
            this.flpButtons.Controls.Add(this.btnClear);
            this.flpButtons.Controls.Add(this.btnSave);
            this.flpButtons.Controls.Add(this.btnDelete);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.Location = new System.Drawing.Point(268, 124);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(589, 31);
            this.flpButtons.TabIndex = 7;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(3, 3);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(84, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(165, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(327, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(13, 168);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(61, 20);
            this.lblHistory.TabIndex = 1;
            this.lblHistory.Text = "History";
            this.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flipFormat
            // 
            this.flipFormat.Controls.Add(this.txtFormat);
            this.flipFormat.Controls.Add(this.cmbFormatPreset);
            this.flipFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipFormat.Location = new System.Drawing.Point(268, 50);
            this.flipFormat.Name = "flipFormat";
            this.flipFormat.Size = new System.Drawing.Size(589, 31);
            this.flipFormat.TabIndex = 8;
            // 
            // txtFormat
            // 
            this.txtFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFormat.Location = new System.Drawing.Point(3, 3);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(180, 27);
            this.txtFormat.TabIndex = 9;
            this.txtFormat.Text = "yyyy-MM-dd HH:mm:ss";
            // 
            // cmbFormatPreset
            // 
            this.cmbFormatPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormatPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormatPreset.FormattingEnabled = true;
            this.cmbFormatPreset.Location = new System.Drawing.Point(189, 3);
            this.cmbFormatPreset.Name = "cmbFormatPreset";
            this.cmbFormatPreset.Size = new System.Drawing.Size(180, 28);
            this.cmbFormatPreset.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTime Formatter Pro";
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.grpConverter.ResumeLayout(false);
            this.tblConverter.ResumeLayout(false);
            this.tblConverter.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.flipFormat.ResumeLayout(false);
            this.flipFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.GroupBox grpConverter;
        private System.Windows.Forms.TableLayoutPanel tblConverter;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.FlowLayoutPanel flipFormat;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.ComboBox cmbFormatPreset;
    }
}

