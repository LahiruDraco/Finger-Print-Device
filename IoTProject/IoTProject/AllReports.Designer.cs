namespace IoTProject
{
    partial class AllReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllReports));
            this.examEligibility = new System.Windows.Forms.Button();
            this.batchList = new System.Windows.Forms.Button();
            this.lecturerInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // examEligibility
            // 
            this.examEligibility.Location = new System.Drawing.Point(33, 24);
            this.examEligibility.Name = "examEligibility";
            this.examEligibility.Size = new System.Drawing.Size(163, 128);
            this.examEligibility.TabIndex = 0;
            this.examEligibility.Text = "Exam Eligibility";
            this.examEligibility.UseVisualStyleBackColor = true;
            // 
            // batchList
            // 
            this.batchList.Location = new System.Drawing.Point(223, 24);
            this.batchList.Name = "batchList";
            this.batchList.Size = new System.Drawing.Size(163, 128);
            this.batchList.TabIndex = 1;
            this.batchList.Text = "Batch Information";
            this.batchList.UseVisualStyleBackColor = true;
            this.batchList.Click += new System.EventHandler(this.batchList_Click);
            // 
            // lecturerInfo
            // 
            this.lecturerInfo.Location = new System.Drawing.Point(402, 24);
            this.lecturerInfo.Name = "lecturerInfo";
            this.lecturerInfo.Size = new System.Drawing.Size(163, 128);
            this.lecturerInfo.TabIndex = 2;
            this.lecturerInfo.Text = "Lecturer Information";
            this.lecturerInfo.UseVisualStyleBackColor = true;
            // 
            // AllReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 216);
            this.Controls.Add(this.lecturerInfo);
            this.Controls.Add(this.batchList);
            this.Controls.Add(this.examEligibility);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllReports";
            this.Text = "AllReports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button examEligibility;
        private System.Windows.Forms.Button batchList;
        private System.Windows.Forms.Button lecturerInfo;
    }
}