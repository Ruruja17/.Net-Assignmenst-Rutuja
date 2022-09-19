namespace ATMApp
{
    partial class BalanceCheck
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
            this.lblPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnBalanceCheck = new System.Windows.Forms.Button();
            this.lblBalnace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(233, 43);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(91, 16);
            this.lblPin.TabIndex = 0;
            this.lblPin.Text = "Enter Your Pin";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(236, 76);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(204, 22);
            this.txtPin.TabIndex = 1;
            // 
            // btnBalanceCheck
            // 
            this.btnBalanceCheck.Location = new System.Drawing.Point(236, 133);
            this.btnBalanceCheck.Name = "btnBalanceCheck";
            this.btnBalanceCheck.Size = new System.Drawing.Size(132, 33);
            this.btnBalanceCheck.TabIndex = 2;
            this.btnBalanceCheck.Text = "Check";
            this.btnBalanceCheck.UseVisualStyleBackColor = true;
            this.btnBalanceCheck.Click += new System.EventHandler(this.btnBalanceCheck_Click);
            // 
            // lblBalnace
            // 
            this.lblBalnace.AutoSize = true;
            this.lblBalnace.Location = new System.Drawing.Point(208, 250);
            this.lblBalnace.Name = "lblBalnace";
            this.lblBalnace.Size = new System.Drawing.Size(0, 16);
            this.lblBalnace.TabIndex = 3;
            // 
            // BalanceCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBalnace);
            this.Controls.Add(this.btnBalanceCheck);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPin);
            this.Name = "BalanceCheck";
            this.Text = "BalanceCheck";
            this.Load += new System.EventHandler(this.BalanceCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnBalanceCheck;
        private System.Windows.Forms.Label lblBalnace;
    }
}