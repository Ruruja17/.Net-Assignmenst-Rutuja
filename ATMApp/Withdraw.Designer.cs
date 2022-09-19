namespace ATMApp
{
    partial class Withdraw
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
            this.lblPIn = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPIn
            // 
            this.lblPIn.AutoSize = true;
            this.lblPIn.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblPIn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPIn.Location = new System.Drawing.Point(131, 60);
            this.lblPIn.Name = "lblPIn";
            this.lblPIn.Size = new System.Drawing.Size(94, 16);
            this.lblPIn.TabIndex = 0;
            this.lblPIn.Text = "Enter Your PIN";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(259, 54);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(154, 22);
            this.txtPin.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblAmount.ForeColor = System.Drawing.Color.Coral;
            this.lblAmount.Location = new System.Drawing.Point(131, 116);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(115, 16);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Enter your Amount";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnWithdraw.ForeColor = System.Drawing.Color.Violet;
            this.btnWithdraw.Location = new System.Drawing.Point(259, 185);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(154, 46);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(259, 116);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(154, 22);
            this.txtAmount.TabIndex = 4;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPIn);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPIn;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtAmount;
    }
}