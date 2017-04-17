namespace IoTProject.CrystalReport
{
    partial class BatchInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchInformation));
            this.print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.freeSearch = new System.Windows.Forms.TextBox();
            this.batchListGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Green;
            this.print.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.Location = new System.Drawing.Point(452, 56);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(122, 57);
            this.print.TabIndex = 8;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // freeSearch
            // 
            this.freeSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.freeSearch.Location = new System.Drawing.Point(19, 139);
            this.freeSearch.Name = "freeSearch";
            this.freeSearch.Size = new System.Drawing.Size(570, 25);
            this.freeSearch.TabIndex = 6;
            this.freeSearch.TextChanged += new System.EventHandler(this.freeSearch_TextChanged);
            // 
            // batchListGrid
            // 
            this.batchListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batchListGrid.Location = new System.Drawing.Point(10, 193);
            this.batchListGrid.Name = "batchListGrid";
            this.batchListGrid.Size = new System.Drawing.Size(579, 222);
            this.batchListGrid.TabIndex = 5;
            this.batchListGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.batchListGrid_RowHeaderMouseClick);
            // 
            // BatchInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 435);
            this.Controls.Add(this.print);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.freeSearch);
            this.Controls.Add(this.batchListGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatchInformation";
            this.Text = "BatchInformation";
            this.Load += new System.EventHandler(this.BatchInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button print;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox freeSearch;
        private System.Windows.Forms.DataGridView batchListGrid;
    }
}