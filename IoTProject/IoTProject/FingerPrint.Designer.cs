namespace IoTProject
{
    partial class FingerPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerPrint));
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GetFeatureVector = new System.Windows.Forms.Button();
            this.SaveFeatureVector = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.featureVectorDataGrid = new System.Windows.Forms.DataGridView();
            this.CreateDataSet = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featureVectorDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.Blue;
            this.Previous.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Previous.ForeColor = System.Drawing.Color.White;
            this.Previous.Location = new System.Drawing.Point(41, 261);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 30);
            this.Previous.TabIndex = 0;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Blue;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Location = new System.Drawing.Point(184, 261);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 30);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(125, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(313, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GetFeatureVector
            // 
            this.GetFeatureVector.BackColor = System.Drawing.Color.Green;
            this.GetFeatureVector.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.GetFeatureVector.ForeColor = System.Drawing.Color.White;
            this.GetFeatureVector.Location = new System.Drawing.Point(37, 141);
            this.GetFeatureVector.Name = "GetFeatureVector";
            this.GetFeatureVector.Size = new System.Drawing.Size(108, 98);
            this.GetFeatureVector.TabIndex = 7;
            this.GetFeatureVector.Text = "Get Feature Vector";
            this.GetFeatureVector.UseVisualStyleBackColor = false;
            this.GetFeatureVector.Click += new System.EventHandler(this.SaveFeatureVector_Click);
            // 
            // SaveFeatureVector
            // 
            this.SaveFeatureVector.BackColor = System.Drawing.Color.Green;
            this.SaveFeatureVector.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaveFeatureVector.ForeColor = System.Drawing.Color.White;
            this.SaveFeatureVector.Location = new System.Drawing.Point(151, 141);
            this.SaveFeatureVector.Name = "SaveFeatureVector";
            this.SaveFeatureVector.Size = new System.Drawing.Size(108, 98);
            this.SaveFeatureVector.TabIndex = 8;
            this.SaveFeatureVector.Text = "Save Feature Vector";
            this.SaveFeatureVector.UseVisualStyleBackColor = false;
            this.SaveFeatureVector.Click += new System.EventHandler(this.SaveFeatureVector_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(202, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Feature Vector :";
            // 
            // featureVectorDataGrid
            // 
            this.featureVectorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.featureVectorDataGrid.Location = new System.Drawing.Point(510, 43);
            this.featureVectorDataGrid.Name = "featureVectorDataGrid";
            this.featureVectorDataGrid.Size = new System.Drawing.Size(241, 367);
            this.featureVectorDataGrid.TabIndex = 10;
            // 
            // CreateDataSet
            // 
            this.CreateDataSet.BackColor = System.Drawing.Color.Green;
            this.CreateDataSet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.CreateDataSet.ForeColor = System.Drawing.Color.White;
            this.CreateDataSet.Location = new System.Drawing.Point(383, 141);
            this.CreateDataSet.Name = "CreateDataSet";
            this.CreateDataSet.Size = new System.Drawing.Size(108, 98);
            this.CreateDataSet.TabIndex = 11;
            this.CreateDataSet.Text = "Create Data Set";
            this.CreateDataSet.UseVisualStyleBackColor = false;
            this.CreateDataSet.Click += new System.EventHandler(this.CreateDataSet_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(41, 89);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(450, 23);
            this.progressBar.TabIndex = 12;
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // FingerPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 420);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.CreateDataSet);
            this.Controls.Add(this.featureVectorDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveFeatureVector);
            this.Controls.Add(this.GetFeatureVector);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FingerPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FingerPrint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featureVectorDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GetFeatureVector;
        private System.Windows.Forms.Button SaveFeatureVector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView featureVectorDataGrid;
        private System.Windows.Forms.Button CreateDataSet;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer progressTimer;
    }
}