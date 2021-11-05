
namespace CsvConvertion
{
    partial class CSVConverter
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
            this.Dgv_CsvFile = new System.Windows.Forms.DataGridView();
            this.Btn_SelectFile = new System.Windows.Forms.Button();
            this.Txt_File = new System.Windows.Forms.TextBox();
            this.Btn_AddReeksId = new System.Windows.Forms.Button();
            this.Rb_Reeks30 = new System.Windows.Forms.RadioButton();
            this.Rb_Reeks50 = new System.Windows.Forms.RadioButton();
            this.Rb_Reeks70 = new System.Windows.Forms.RadioButton();
            this.Rb_Reeks85 = new System.Windows.Forms.RadioButton();
            this.Rb_Reeks95 = new System.Windows.Forms.RadioButton();
            this.Rb_Reeks105 = new System.Windows.Forms.RadioButton();
            this.Rb_Reeks115 = new System.Windows.Forms.RadioButton();
            this.Btn_ExportCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CsvFile)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_CsvFile
            // 
            this.Dgv_CsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_CsvFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CsvFile.Location = new System.Drawing.Point(12, 12);
            this.Dgv_CsvFile.Name = "Dgv_CsvFile";
            this.Dgv_CsvFile.Size = new System.Drawing.Size(744, 578);
            this.Dgv_CsvFile.TabIndex = 0;
            // 
            // Btn_SelectFile
            // 
            this.Btn_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_SelectFile.Location = new System.Drawing.Point(775, 12);
            this.Btn_SelectFile.Name = "Btn_SelectFile";
            this.Btn_SelectFile.Size = new System.Drawing.Size(109, 23);
            this.Btn_SelectFile.TabIndex = 1;
            this.Btn_SelectFile.Text = "Importeer CSV";
            this.Btn_SelectFile.UseVisualStyleBackColor = true;
            this.Btn_SelectFile.Click += new System.EventHandler(this.Btn_SelectFile_Click);
            // 
            // Txt_File
            // 
            this.Txt_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_File.Location = new System.Drawing.Point(775, 41);
            this.Txt_File.Name = "Txt_File";
            this.Txt_File.Size = new System.Drawing.Size(109, 20);
            this.Txt_File.TabIndex = 2;
            // 
            // Btn_AddReeksId
            // 
            this.Btn_AddReeksId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddReeksId.Location = new System.Drawing.Point(775, 130);
            this.Btn_AddReeksId.Name = "Btn_AddReeksId";
            this.Btn_AddReeksId.Size = new System.Drawing.Size(109, 38);
            this.Btn_AddReeksId.TabIndex = 3;
            this.Btn_AddReeksId.Text = "Wedstrijd nummer toevoegen";
            this.Btn_AddReeksId.UseVisualStyleBackColor = true;
            this.Btn_AddReeksId.Click += new System.EventHandler(this.Btn_AddReeksId_Click);
            // 
            // Rb_Reeks30
            // 
            this.Rb_Reeks30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rb_Reeks30.AutoCheck = false;
            this.Rb_Reeks30.AutoSize = true;
            this.Rb_Reeks30.Location = new System.Drawing.Point(775, 174);
            this.Rb_Reeks30.Name = "Rb_Reeks30";
            this.Rb_Reeks30.Size = new System.Drawing.Size(88, 17);
            this.Rb_Reeks30.TabIndex = 4;
            this.Rb_Reeks30.TabStop = true;
            this.Rb_Reeks30.Text = "Reeks 30 cm";
            this.Rb_Reeks30.UseVisualStyleBackColor = true;
            this.Rb_Reeks30.CheckedChanged += new System.EventHandler(this.Rb_Reeks30_CheckedChanged);
            // 
            // Rb_Reeks50
            // 
            this.Rb_Reeks50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rb_Reeks50.AutoCheck = false;
            this.Rb_Reeks50.AutoSize = true;
            this.Rb_Reeks50.Location = new System.Drawing.Point(775, 197);
            this.Rb_Reeks50.Name = "Rb_Reeks50";
            this.Rb_Reeks50.Size = new System.Drawing.Size(109, 17);
            this.Rb_Reeks50.TabIndex = 5;
            this.Rb_Reeks50.TabStop = true;
            this.Rb_Reeks50.Text = "Reeks 50 - 65 cm";
            this.Rb_Reeks50.UseVisualStyleBackColor = true;
            this.Rb_Reeks50.CheckedChanged += new System.EventHandler(this.Rb_Reeks50_CheckedChanged);
            // 
            // Rb_Reeks70
            // 
            this.Rb_Reeks70.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rb_Reeks70.AutoCheck = false;
            this.Rb_Reeks70.AutoSize = true;
            this.Rb_Reeks70.Location = new System.Drawing.Point(775, 221);
            this.Rb_Reeks70.Name = "Rb_Reeks70";
            this.Rb_Reeks70.Size = new System.Drawing.Size(88, 17);
            this.Rb_Reeks70.TabIndex = 6;
            this.Rb_Reeks70.TabStop = true;
            this.Rb_Reeks70.Text = "Reeks 70 cm";
            this.Rb_Reeks70.UseVisualStyleBackColor = true;
            this.Rb_Reeks70.CheckedChanged += new System.EventHandler(this.Rb_Reeks70_CheckedChanged);
            // 
            // Rb_Reeks85
            // 
            this.Rb_Reeks85.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rb_Reeks85.AutoCheck = false;
            this.Rb_Reeks85.AutoSize = true;
            this.Rb_Reeks85.Location = new System.Drawing.Point(775, 245);
            this.Rb_Reeks85.Name = "Rb_Reeks85";
            this.Rb_Reeks85.Size = new System.Drawing.Size(88, 17);
            this.Rb_Reeks85.TabIndex = 7;
            this.Rb_Reeks85.TabStop = true;
            this.Rb_Reeks85.Text = "Reeks 85 cm";
            this.Rb_Reeks85.UseVisualStyleBackColor = true;
            this.Rb_Reeks85.CheckedChanged += new System.EventHandler(this.Rb_Reeks85_CheckedChanged);
            // 
            // Rb_Reeks95
            // 
            this.Rb_Reeks95.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rb_Reeks95.AutoCheck = false;
            this.Rb_Reeks95.AutoSize = true;
            this.Rb_Reeks95.Location = new System.Drawing.Point(775, 269);
            this.Rb_Reeks95.Name = "Rb_Reeks95";
            this.Rb_Reeks95.Size = new System.Drawing.Size(88, 17);
            this.Rb_Reeks95.TabIndex = 8;
            this.Rb_Reeks95.TabStop = true;
            this.Rb_Reeks95.Text = "Reeks 95 cm";
            this.Rb_Reeks95.UseVisualStyleBackColor = true;
            this.Rb_Reeks95.CheckedChanged += new System.EventHandler(this.Rb_Reeks95_CheckedChanged);
            // 
            // Rb_Reeks105
            // 
            this.Rb_Reeks105.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rb_Reeks105.AutoCheck = false;
            this.Rb_Reeks105.AutoSize = true;
            this.Rb_Reeks105.Location = new System.Drawing.Point(775, 293);
            this.Rb_Reeks105.Name = "Rb_Reeks105";
            this.Rb_Reeks105.Size = new System.Drawing.Size(85, 17);
            this.Rb_Reeks105.TabIndex = 9;
            this.Rb_Reeks105.TabStop = true;
            this.Rb_Reeks105.Text = "Reeks 1m05";
            this.Rb_Reeks105.UseVisualStyleBackColor = true;
            this.Rb_Reeks105.CheckedChanged += new System.EventHandler(this.Rb_Reeks105_CheckedChanged);
            // 
            // Rb_Reeks115
            // 
            this.Rb_Reeks115.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rb_Reeks115.AutoCheck = false;
            this.Rb_Reeks115.AutoSize = true;
            this.Rb_Reeks115.Location = new System.Drawing.Point(775, 317);
            this.Rb_Reeks115.Name = "Rb_Reeks115";
            this.Rb_Reeks115.Size = new System.Drawing.Size(85, 17);
            this.Rb_Reeks115.TabIndex = 10;
            this.Rb_Reeks115.TabStop = true;
            this.Rb_Reeks115.Text = "Reeks 1m15";
            this.Rb_Reeks115.UseVisualStyleBackColor = true;
            this.Rb_Reeks115.CheckedChanged += new System.EventHandler(this.Rb_Reeks115_CheckedChanged);
            // 
            // Btn_ExportCSV
            // 
            this.Btn_ExportCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ExportCSV.Location = new System.Drawing.Point(775, 566);
            this.Btn_ExportCSV.Name = "Btn_ExportCSV";
            this.Btn_ExportCSV.Size = new System.Drawing.Size(109, 23);
            this.Btn_ExportCSV.TabIndex = 11;
            this.Btn_ExportCSV.Text = "Exporteer CSV";
            this.Btn_ExportCSV.UseVisualStyleBackColor = true;
            this.Btn_ExportCSV.Click += new System.EventHandler(this.Btn_ExportCSV_Click);
            // 
            // CSVConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 602);
            this.Controls.Add(this.Btn_ExportCSV);
            this.Controls.Add(this.Rb_Reeks115);
            this.Controls.Add(this.Rb_Reeks105);
            this.Controls.Add(this.Rb_Reeks95);
            this.Controls.Add(this.Rb_Reeks85);
            this.Controls.Add(this.Rb_Reeks70);
            this.Controls.Add(this.Rb_Reeks50);
            this.Controls.Add(this.Rb_Reeks30);
            this.Controls.Add(this.Btn_AddReeksId);
            this.Controls.Add(this.Txt_File);
            this.Controls.Add(this.Btn_SelectFile);
            this.Controls.Add(this.Dgv_CsvFile);
            this.Name = "CSVConverter";
            this.Text = "Edit and Convert csv File";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CsvFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_CsvFile;
        private System.Windows.Forms.Button Btn_SelectFile;
        private System.Windows.Forms.TextBox Txt_File;
        private System.Windows.Forms.Button Btn_AddReeksId;
        private System.Windows.Forms.RadioButton Rb_Reeks30;
        private System.Windows.Forms.RadioButton Rb_Reeks50;
        private System.Windows.Forms.RadioButton Rb_Reeks70;
        private System.Windows.Forms.RadioButton Rb_Reeks85;
        private System.Windows.Forms.RadioButton Rb_Reeks95;
        private System.Windows.Forms.RadioButton Rb_Reeks105;
        private System.Windows.Forms.RadioButton Rb_Reeks115;
        private System.Windows.Forms.Button Btn_ExportCSV;
    }
}

