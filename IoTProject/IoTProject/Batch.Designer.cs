namespace IoTProject
{
    partial class Batch
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
            this.createBatchButton = new System.Windows.Forms.Button();
            this.importBatchButton = new System.Windows.Forms.Button();
            this.batchCode = new System.Windows.Forms.TextBox();
            this.batchName = new System.Windows.Forms.TextBox();
            this.courseDirector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uploadExcel = new System.Windows.Forms.Button();
            this.studentDatagrid = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.enrollFingerPrintButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // createBatchButton
            // 
            this.createBatchButton.Location = new System.Drawing.Point(476, 32);
            this.createBatchButton.Name = "createBatchButton";
            this.createBatchButton.Size = new System.Drawing.Size(122, 57);
            this.createBatchButton.TabIndex = 0;
            this.createBatchButton.Text = "Create Batch";
            this.createBatchButton.UseVisualStyleBackColor = true;
            this.createBatchButton.Click += new System.EventHandler(this.createBatchButton_Click);
            // 
            // importBatchButton
            // 
            this.importBatchButton.Location = new System.Drawing.Point(476, 115);
            this.importBatchButton.Name = "importBatchButton";
            this.importBatchButton.Size = new System.Drawing.Size(122, 57);
            this.importBatchButton.TabIndex = 1;
            this.importBatchButton.Text = "Import Batch";
            this.importBatchButton.UseVisualStyleBackColor = true;
            this.importBatchButton.Click += new System.EventHandler(this.importBatchButton_Click);
            // 
            // batchCode
            // 
            this.batchCode.Location = new System.Drawing.Point(42, 48);
            this.batchCode.Name = "batchCode";
            this.batchCode.Size = new System.Drawing.Size(100, 20);
            this.batchCode.TabIndex = 2;
            // 
            // batchName
            // 
            this.batchName.Location = new System.Drawing.Point(188, 48);
            this.batchName.Name = "batchName";
            this.batchName.Size = new System.Drawing.Size(100, 20);
            this.batchName.TabIndex = 3;
            // 
            // courseDirector
            // 
            this.courseDirector.Location = new System.Drawing.Point(336, 48);
            this.courseDirector.Name = "courseDirector";
            this.courseDirector.Size = new System.Drawing.Size(100, 20);
            this.courseDirector.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Batch Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Batch Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Course Director";
            // 
            // uploadExcel
            // 
            this.uploadExcel.Location = new System.Drawing.Point(476, 206);
            this.uploadExcel.Name = "uploadExcel";
            this.uploadExcel.Size = new System.Drawing.Size(122, 60);
            this.uploadExcel.TabIndex = 8;
            this.uploadExcel.Text = "Upload Students";
            this.uploadExcel.UseVisualStyleBackColor = true;
            this.uploadExcel.Click += new System.EventHandler(this.uploadExcel_Click);
            // 
            // studentDatagrid
            // 
            this.studentDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDatagrid.Location = new System.Drawing.Point(42, 89);
            this.studentDatagrid.Name = "studentDatagrid";
            this.studentDatagrid.Size = new System.Drawing.Size(394, 320);
            this.studentDatagrid.TabIndex = 9;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // enrollFingerPrintButton
            // 
            this.enrollFingerPrintButton.Location = new System.Drawing.Point(476, 293);
            this.enrollFingerPrintButton.Name = "enrollFingerPrintButton";
            this.enrollFingerPrintButton.Size = new System.Drawing.Size(122, 57);
            this.enrollFingerPrintButton.TabIndex = 10;
            this.enrollFingerPrintButton.Text = "Enroll Finger Print";
            this.enrollFingerPrintButton.UseVisualStyleBackColor = true;
            this.enrollFingerPrintButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 519);
            this.Controls.Add(this.enrollFingerPrintButton);
            this.Controls.Add(this.studentDatagrid);
            this.Controls.Add(this.uploadExcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseDirector);
            this.Controls.Add(this.batchName);
            this.Controls.Add(this.batchCode);
            this.Controls.Add(this.importBatchButton);
            this.Controls.Add(this.createBatchButton);
            this.Name = "Batch";
            this.Text = "Batch";
            ((System.ComponentModel.ISupportInitialize)(this.studentDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBatchButton;
        private System.Windows.Forms.Button importBatchButton;
        private System.Windows.Forms.TextBox batchCode;
        private System.Windows.Forms.TextBox batchName;
        private System.Windows.Forms.TextBox courseDirector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uploadExcel;
        private System.Windows.Forms.DataGridView studentDatagrid;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button enrollFingerPrintButton;
    }
}