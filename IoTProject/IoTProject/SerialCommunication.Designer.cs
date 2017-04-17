namespace IoTProject
{
    partial class SerialCommunication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialCommunication));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.receiveTextBox = new System.Windows.Forms.TextBox();
            this.portCombo = new System.Windows.Forms.ComboBox();
            this.baudCombo = new System.Windows.Forms.ComboBox();
            this.openPort = new System.Windows.Forms.Button();
            this.closePort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(221, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.sendTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(87, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Here";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(100, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(6, 24);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(160, 121);
            this.sendTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.receiveTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(330, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 192);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive Here";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(99, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.Location = new System.Drawing.Point(6, 24);
            this.receiveTextBox.Multiline = true;
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.Size = new System.Drawing.Size(160, 121);
            this.receiveTextBox.TabIndex = 0;
            // 
            // portCombo
            // 
            this.portCombo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.portCombo.FormattingEnabled = true;
            this.portCombo.Location = new System.Drawing.Point(23, 60);
            this.portCombo.Name = "portCombo";
            this.portCombo.Size = new System.Drawing.Size(121, 25);
            this.portCombo.TabIndex = 7;
            this.portCombo.SelectedIndexChanged += new System.EventHandler(this.portCombo_SelectedIndexChanged);
            // 
            // baudCombo
            // 
            this.baudCombo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.baudCombo.FormattingEnabled = true;
            this.baudCombo.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baudCombo.Location = new System.Drawing.Point(195, 60);
            this.baudCombo.Name = "baudCombo";
            this.baudCombo.Size = new System.Drawing.Size(121, 25);
            this.baudCombo.TabIndex = 8;
            this.baudCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // openPort
            // 
            this.openPort.BackColor = System.Drawing.Color.Green;
            this.openPort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.openPort.ForeColor = System.Drawing.Color.White;
            this.openPort.Location = new System.Drawing.Point(348, 33);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(85, 55);
            this.openPort.TabIndex = 2;
            this.openPort.Text = "Open Port";
            this.openPort.UseVisualStyleBackColor = false;
            this.openPort.Click += new System.EventHandler(this.button3_Click);
            // 
            // closePort
            // 
            this.closePort.BackColor = System.Drawing.Color.Green;
            this.closePort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.closePort.ForeColor = System.Drawing.Color.White;
            this.closePort.Location = new System.Drawing.Point(461, 33);
            this.closePort.Name = "closePort";
            this.closePort.Size = new System.Drawing.Size(88, 55);
            this.closePort.TabIndex = 10;
            this.closePort.Text = "Close Port";
            this.closePort.UseVisualStyleBackColor = false;
            this.closePort.Click += new System.EventHandler(this.button4_Click);
            // 
            // SerialCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 359);
            this.Controls.Add(this.closePort);
            this.Controls.Add(this.openPort);
            this.Controls.Add(this.baudCombo);
            this.Controls.Add(this.portCombo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialCommunication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerialPort";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox receiveTextBox;
        private System.Windows.Forms.ComboBox portCombo;
        private System.Windows.Forms.ComboBox baudCombo;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.Button closePort;
    }
}