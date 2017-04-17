namespace IoTProject
{
    partial class ImportData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportData));
            this.uploadFile = new System.Windows.Forms.Button();
            this.studentDatagrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseDirector = new System.Windows.Forms.TextBox();
            this.batchName = new System.Windows.Forms.TextBox();
            this.batchCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveStudent = new System.Windows.Forms.Button();
            this.folderTreeView = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.session = new System.Windows.Forms.TextBox();
            this.indexGridView = new System.Windows.Forms.DataGridView();
            this.detectIndexNumbers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadFile
            // 
            this.uploadFile.BackColor = System.Drawing.Color.Green;
            this.uploadFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.uploadFile.ForeColor = System.Drawing.Color.White;
            this.uploadFile.Location = new System.Drawing.Point(760, 38);
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.Size = new System.Drawing.Size(216, 60);
            this.uploadFile.TabIndex = 9;
            this.uploadFile.Text = "Get Students Attendance";
            this.uploadFile.UseVisualStyleBackColor = false;
            this.uploadFile.Click += new System.EventHandler(this.uploadFile_Click);
            // 
            // studentDatagrid
            // 
            this.studentDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDatagrid.Location = new System.Drawing.Point(209, 38);
            this.studentDatagrid.Name = "studentDatagrid";
            this.studentDatagrid.Size = new System.Drawing.Size(234, 370);
            this.studentDatagrid.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Course Director";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Batch Name";
            // 
            // courseDirector
            // 
            this.courseDirector.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.courseDirector.Location = new System.Drawing.Point(29, 205);
            this.courseDirector.Name = "courseDirector";
            this.courseDirector.Size = new System.Drawing.Size(147, 25);
            this.courseDirector.TabIndex = 12;
            // 
            // batchName
            // 
            this.batchName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.batchName.Location = new System.Drawing.Point(30, 146);
            this.batchName.Name = "batchName";
            this.batchName.Size = new System.Drawing.Size(144, 25);
            this.batchName.TabIndex = 11;
            // 
            // batchCode
            // 
            this.batchCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.batchCode.Location = new System.Drawing.Point(29, 87);
            this.batchCode.Name = "batchCode";
            this.batchCode.Size = new System.Drawing.Size(147, 25);
            this.batchCode.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Subject";
            // 
            // subject
            // 
            this.subject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.subject.Location = new System.Drawing.Point(29, 259);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(147, 25);
            this.subject.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Batch Code";
            // 
            // saveStudent
            // 
            this.saveStudent.BackColor = System.Drawing.Color.Green;
            this.saveStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.saveStudent.ForeColor = System.Drawing.Color.White;
            this.saveStudent.Location = new System.Drawing.Point(760, 114);
            this.saveStudent.Name = "saveStudent";
            this.saveStudent.Size = new System.Drawing.Size(216, 60);
            this.saveStudent.TabIndex = 21;
            this.saveStudent.Text = "Save Students Attendance";
            this.saveStudent.UseVisualStyleBackColor = false;
            this.saveStudent.Click += new System.EventHandler(this.saveStudent_Click);
            // 
            // folderTreeView
            // 
            this.folderTreeView.Location = new System.Drawing.Point(760, 180);
            this.folderTreeView.Name = "folderTreeView";
            this.folderTreeView.Size = new System.Drawing.Size(227, 216);
            this.folderTreeView.TabIndex = 22;
            this.folderTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.folderTreeView_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(30, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Session No";
            // 
            // session
            // 
            this.session.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.session.Location = new System.Drawing.Point(29, 323);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(147, 25);
            this.session.TabIndex = 23;
            // 
            // indexGridView
            // 
            this.indexGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indexGridView.Location = new System.Drawing.Point(501, 38);
            this.indexGridView.Name = "indexGridView";
            this.indexGridView.Size = new System.Drawing.Size(253, 370);
            this.indexGridView.TabIndex = 25;
            // 
            // detectIndexNumbers
            // 
            this.detectIndexNumbers.Location = new System.Drawing.Point(455, 118);
            this.detectIndexNumbers.Name = "detectIndexNumbers";
            this.detectIndexNumbers.Size = new System.Drawing.Size(37, 60);
            this.detectIndexNumbers.TabIndex = 26;
            this.detectIndexNumbers.Text = "> >";
            this.detectIndexNumbers.UseVisualStyleBackColor = true;
            this.detectIndexNumbers.Click += new System.EventHandler(this.detectIndexNumbers_Click);
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 437);
            this.Controls.Add(this.detectIndexNumbers);
            this.Controls.Add(this.indexGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.session);
            this.Controls.Add(this.folderTreeView);
            this.Controls.Add(this.saveStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.studentDatagrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseDirector);
            this.Controls.Add(this.batchName);
            this.Controls.Add(this.batchCode);
            this.Controls.Add(this.uploadFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportData";
            ((System.ComponentModel.ISupportInitialize)(this.studentDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadFile;
        private System.Windows.Forms.DataGridView studentDatagrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseDirector;
        private System.Windows.Forms.TextBox batchName;
        private System.Windows.Forms.TextBox batchCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveStudent;
        private System.Windows.Forms.TreeView folderTreeView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox session;
        private System.Windows.Forms.DataGridView indexGridView;
        private System.Windows.Forms.Button detectIndexNumbers;
    }
}