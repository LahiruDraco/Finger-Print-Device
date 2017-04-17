namespace IoTProject
{
    partial class Lecture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecture));
            this.studentDatagrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.courseDirector = new System.Windows.Forms.TextBox();
            this.batchName = new System.Windows.Forms.TextBox();
            this.batchCode = new System.Windows.Forms.TextBox();
            this.createBatchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDatagrid
            // 
            this.studentDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDatagrid.Location = new System.Drawing.Point(12, 90);
            this.studentDatagrid.Name = "studentDatagrid";
            this.studentDatagrid.Size = new System.Drawing.Size(394, 320);
            this.studentDatagrid.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(259, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Course Director";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(124, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Batch Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Batch Code";
            // 
            // courseDirector
            // 
            this.courseDirector.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.courseDirector.Location = new System.Drawing.Point(224, 49);
            this.courseDirector.Name = "courseDirector";
            this.courseDirector.Size = new System.Drawing.Size(181, 25);
            this.courseDirector.TabIndex = 13;
            // 
            // batchName
            // 
            this.batchName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.batchName.Location = new System.Drawing.Point(118, 49);
            this.batchName.Name = "batchName";
            this.batchName.Size = new System.Drawing.Size(100, 25);
            this.batchName.TabIndex = 12;
            // 
            // batchCode
            // 
            this.batchCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.batchCode.Location = new System.Drawing.Point(12, 49);
            this.batchCode.Name = "batchCode";
            this.batchCode.Size = new System.Drawing.Size(100, 25);
            this.batchCode.TabIndex = 11;
            // 
            // createBatchButton
            // 
            this.createBatchButton.BackColor = System.Drawing.Color.Green;
            this.createBatchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBatchButton.ForeColor = System.Drawing.Color.White;
            this.createBatchButton.Location = new System.Drawing.Point(449, 90);
            this.createBatchButton.Name = "createBatchButton";
            this.createBatchButton.Size = new System.Drawing.Size(122, 57);
            this.createBatchButton.TabIndex = 10;
            this.createBatchButton.Text = "Create Batch";
            this.createBatchButton.UseVisualStyleBackColor = false;
            // 
            // Lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 453);
            this.Controls.Add(this.studentDatagrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseDirector);
            this.Controls.Add(this.batchName);
            this.Controls.Add(this.batchCode);
            this.Controls.Add(this.createBatchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lecture";
            this.Text = "Lecture";
            ((System.ComponentModel.ISupportInitialize)(this.studentDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentDatagrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseDirector;
        private System.Windows.Forms.TextBox batchName;
        private System.Windows.Forms.TextBox batchCode;
        private System.Windows.Forms.Button createBatchButton;
    }
}