namespace MobleRechargeServicesApp
{
    partial class MobileRechargeUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mobileNoTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rechargeTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showUsedBalanceTextBox = new System.Windows.Forms.TextBox();
            this.showCurrentbalanceTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.rechargeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.balanceTextBox);
            this.groupBox1.Controls.Add(this.mobileNoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MobileShop";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rechargeButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rechargeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(54, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 148);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transection";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showCurrentbalanceTextBox);
            this.groupBox3.Controls.Add(this.showUsedBalanceTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.showButton);
            this.groupBox3.Location = new System.Drawing.Point(455, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 386);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mobile Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance";
            // 
            // mobileNoTextBox
            // 
            this.mobileNoTextBox.Location = new System.Drawing.Point(134, 36);
            this.mobileNoTextBox.Name = "mobileNoTextBox";
            this.mobileNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobileNoTextBox.TabIndex = 2;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(134, 110);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recharge Amount";
            // 
            // rechargeTextBox
            // 
            this.rechargeTextBox.Location = new System.Drawing.Point(134, 44);
            this.rechargeTextBox.Name = "rechargeTextBox";
            this.rechargeTextBox.Size = new System.Drawing.Size(100, 20);
            this.rechargeTextBox.TabIndex = 5;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(219, 30);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Show Balance";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Used Balance";
            // 
            // showUsedBalanceTextBox
            // 
            this.showUsedBalanceTextBox.Location = new System.Drawing.Point(115, 210);
            this.showUsedBalanceTextBox.Name = "showUsedBalanceTextBox";
            this.showUsedBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.showUsedBalanceTextBox.TabIndex = 9;
            // 
            // showCurrentbalanceTextBox
            // 
            this.showCurrentbalanceTextBox.Location = new System.Drawing.Point(115, 117);
            this.showCurrentbalanceTextBox.Name = "showCurrentbalanceTextBox";
            this.showCurrentbalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.showCurrentbalanceTextBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(258, 160);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // rechargeButton
            // 
            this.rechargeButton.Location = new System.Drawing.Point(258, 81);
            this.rechargeButton.Name = "rechargeButton";
            this.rechargeButton.Size = new System.Drawing.Size(75, 23);
            this.rechargeButton.TabIndex = 5;
            this.rechargeButton.Text = "Recharge";
            this.rechargeButton.UseVisualStyleBackColor = true;
            this.rechargeButton.Click += new System.EventHandler(this.rechargeButton_Click);
            // 
            // MobileRechargeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MobileRechargeUI";
            this.Text = "MobileRechargeUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox mobileNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rechargeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rechargeTextBox;
        private System.Windows.Forms.TextBox showCurrentbalanceTextBox;
        private System.Windows.Forms.TextBox showUsedBalanceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showButton;
    }
}

