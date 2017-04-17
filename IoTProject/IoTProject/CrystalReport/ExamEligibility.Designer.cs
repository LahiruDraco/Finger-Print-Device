namespace IoTProject.CrystalReport
{
    partial class ExamEligibility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamEligibility));
            this.studentDatagrid = new System.Windows.Forms.DataGridView();
            this.courseDirector = new System.Windows.Forms.TextBox();
            this.batchName = new System.Windows.Forms.TextBox();
            this.batchCode = new System.Windows.Forms.TextBox();
            this.print = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDatagrid
            // 
            this.studentDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDatagrid.Location = new System.Drawing.Point(199, 42);
            this.studentDatagrid.Name = "studentDatagrid";
            this.studentDatagrid.Size = new System.Drawing.Size(394, 427);
            this.studentDatagrid.TabIndex = 14;
            // 
            // courseDirector
            // 
            this.courseDirector.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.courseDirector.Location = new System.Drawing.Point(12, 196);
            this.courseDirector.Name = "courseDirector";
            this.courseDirector.Size = new System.Drawing.Size(181, 25);
            this.courseDirector.TabIndex = 13;
            // 
            // batchName
            // 
            this.batchName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.batchName.Location = new System.Drawing.Point(12, 123);
            this.batchName.Name = "batchName";
            this.batchName.Size = new System.Drawing.Size(173, 25);
            this.batchName.TabIndex = 12;
            // 
            // batchCode
            // 
            this.batchCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.batchCode.Location = new System.Drawing.Point(12, 42);
            this.batchCode.Name = "batchCode";
            this.batchCode.Size = new System.Drawing.Size(169, 25);
            this.batchCode.TabIndex = 11;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Green;
            this.print.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.Location = new System.Drawing.Point(12, 325);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(122, 57);
            this.print.TabIndex = 10;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Course Director";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Batch Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Batch Code";
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.Green;
            this.select.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select.ForeColor = System.Drawing.Color.White;
            this.select.Location = new System.Drawing.Point(12, 249);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(122, 57);
            this.select.TabIndex = 18;
            this.select.Text = "Import Excel";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // ExamEligibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 481);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentDatagrid);
            this.Controls.Add(this.courseDirector);
            this.Controls.Add(this.batchName);
            this.Controls.Add(this.batchCode);
            this.Controls.Add(this.print);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExamEligibility";
            this.Text = "ExamEligibility";
            ((System.ComponentModel.ISupportInitialize)(this.studentDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentDatagrid;
        private System.Windows.Forms.TextBox courseDirector;
        private System.Windows.Forms.TextBox batchName;
        private System.Windows.Forms.TextBox batchCode;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}