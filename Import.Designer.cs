namespace LeadManager
{
    partial class Import
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_banks = new System.Windows.Forms.ComboBox();
            this.lbl_SelectFile = new System.Windows.Forms.Label();
            this.txt_selectFile = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_loadData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_importData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Bank";
            // 
            // cmb_banks
            // 
            this.cmb_banks.FormattingEnabled = true;
            this.cmb_banks.Location = new System.Drawing.Point(115, 18);
            this.cmb_banks.Name = "cmb_banks";
            this.cmb_banks.Size = new System.Drawing.Size(154, 21);
            this.cmb_banks.TabIndex = 1;
            // 
            // lbl_SelectFile
            // 
            this.lbl_SelectFile.AutoSize = true;
            this.lbl_SelectFile.Location = new System.Drawing.Point(39, 58);
            this.lbl_SelectFile.Name = "lbl_SelectFile";
            this.lbl_SelectFile.Size = new System.Drawing.Size(56, 13);
            this.lbl_SelectFile.TabIndex = 2;
            this.lbl_SelectFile.Text = "Select File";
            // 
            // txt_selectFile
            // 
            this.txt_selectFile.Location = new System.Drawing.Point(115, 54);
            this.txt_selectFile.Name = "txt_selectFile";
            this.txt_selectFile.Size = new System.Drawing.Size(285, 20);
            this.txt_selectFile.TabIndex = 3;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(401, 53);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 4;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_loadData
            // 
            this.btn_loadData.Location = new System.Drawing.Point(42, 97);
            this.btn_loadData.Name = "btn_loadData";
            this.btn_loadData.Size = new System.Drawing.Size(75, 23);
            this.btn_loadData.TabIndex = 5;
            this.btn_loadData.Text = "Load Data";
            this.btn_loadData.UseVisualStyleBackColor = true;
            this.btn_loadData.Click += new System.EventHandler(this.btn_loadData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 202);
            this.dataGridView1.TabIndex = 6;
            // 
            // btn_importData
            // 
            this.btn_importData.Location = new System.Drawing.Point(42, 362);
            this.btn_importData.Name = "btn_importData";
            this.btn_importData.Size = new System.Drawing.Size(75, 23);
            this.btn_importData.TabIndex = 7;
            this.btn_importData.Text = "Import Data";
            this.btn_importData.UseVisualStyleBackColor = true;
            this.btn_importData.Click += new System.EventHandler(this.btn_importData_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_importData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_loadData);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_selectFile);
            this.Controls.Add(this.lbl_SelectFile);
            this.Controls.Add(this.cmb_banks);
            this.Controls.Add(this.label1);
            this.Name = "Import";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_banks;
        private System.Windows.Forms.Label lbl_SelectFile;
        private System.Windows.Forms.TextBox txt_selectFile;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_loadData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_importData;
    }
}