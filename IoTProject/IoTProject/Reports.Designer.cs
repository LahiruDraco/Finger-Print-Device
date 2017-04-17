namespace IoTProject
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.GetFeatureVector = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetFeatureVector
            // 
            this.GetFeatureVector.BackColor = System.Drawing.Color.Green;
            this.GetFeatureVector.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.GetFeatureVector.ForeColor = System.Drawing.Color.White;
            this.GetFeatureVector.Location = new System.Drawing.Point(88, 85);
            this.GetFeatureVector.Name = "GetFeatureVector";
            this.GetFeatureVector.Size = new System.Drawing.Size(170, 150);
            this.GetFeatureVector.TabIndex = 8;
            this.GetFeatureVector.Text = "Reports";
            this.GetFeatureVector.UseVisualStyleBackColor = false;
            this.GetFeatureVector.Click += new System.EventHandler(this.GetFeatureVector_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(344, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 150);
            this.button1.TabIndex = 9;
            this.button1.Text = "Live Statics";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetFeatureVector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetFeatureVector;
        private System.Windows.Forms.Button button1;
    }
}