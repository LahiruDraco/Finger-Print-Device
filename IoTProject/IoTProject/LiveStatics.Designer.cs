namespace IoTProject
{
    partial class LiveStatics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiveStatics));
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // solidGauge1
            // 
            this.solidGauge1.Location = new System.Drawing.Point(2, -18);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(305, 187);
            this.solidGauge1.TabIndex = 12;
            this.solidGauge1.Text = "solidGauge1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(6, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Current Enrollment Count";
            // 
            // LiveStatics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solidGauge1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LiveStatics";
            this.Text = "LiveStatics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private System.Windows.Forms.Label label1;
    }
}