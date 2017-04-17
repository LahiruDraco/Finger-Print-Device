namespace IoTProject
{
    partial class batchInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(batchInfo));
            this.batchListGrid = new System.Windows.Forms.DataGridView();
            this.freeSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerDataWrite = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.batchListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // batchListGrid
            // 
            this.batchListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batchListGrid.Location = new System.Drawing.Point(12, 150);
            this.batchListGrid.Name = "batchListGrid";
            this.batchListGrid.Size = new System.Drawing.Size(579, 222);
            this.batchListGrid.TabIndex = 0;
            this.batchListGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.batchListGrid_RowHeaderMouseClick);
            this.batchListGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.batchListGrid_RowHeaderMouseDoubleClick);
            // 
            // freeSearch
            // 
            this.freeSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.freeSearch.Location = new System.Drawing.Point(21, 96);
            this.freeSearch.Name = "freeSearch";
            this.freeSearch.Size = new System.Drawing.Size(570, 25);
            this.freeSearch.TabIndex = 1;
            this.freeSearch.TextChanged += new System.EventHandler(this.freeSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(99, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Free Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // headerDataWrite
            // 
            this.headerDataWrite.BackColor = System.Drawing.Color.Green;
            this.headerDataWrite.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.headerDataWrite.ForeColor = System.Drawing.Color.White;
            this.headerDataWrite.Location = new System.Drawing.Point(454, 13);
            this.headerDataWrite.Name = "headerDataWrite";
            this.headerDataWrite.Size = new System.Drawing.Size(122, 57);
            this.headerDataWrite.TabIndex = 4;
            this.headerDataWrite.Text = "Write Header Data to SD Card";
            this.headerDataWrite.UseVisualStyleBackColor = false;
            this.headerDataWrite.Click += new System.EventHandler(this.headerDataWrite_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // batchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 384);
            this.Controls.Add(this.headerDataWrite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.freeSearch);
            this.Controls.Add(this.batchListGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "batchInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportBatch";
            this.Load += new System.EventHandler(this.ImportBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batchListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView batchListGrid;
        private System.Windows.Forms.TextBox freeSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createBatchButton;
        private System.Windows.Forms.Button headerDataWrite;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}