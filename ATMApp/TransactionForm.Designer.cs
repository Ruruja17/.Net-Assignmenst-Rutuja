namespace ATMApp
{
    partial class TransactionForm
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
            this.lblTransaction = new System.Windows.Forms.Label();
            this.btnBalanceCheck = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposite = new System.Windows.Forms.Button();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransaction.Location = new System.Drawing.Point(212, 24);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(305, 42);
            this.lblTransaction.TabIndex = 0;
            this.lblTransaction.Text = "ATM SERVICES ";
            // 
            // btnBalanceCheck
            // 
            this.btnBalanceCheck.BackColor = System.Drawing.Color.Purple;
            this.btnBalanceCheck.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBalanceCheck.Location = new System.Drawing.Point(183, 127);
            this.btnBalanceCheck.Name = "btnBalanceCheck";
            this.btnBalanceCheck.Size = new System.Drawing.Size(140, 55);
            this.btnBalanceCheck.TabIndex = 1;
            this.btnBalanceCheck.Text = "Balance";
            this.btnBalanceCheck.UseVisualStyleBackColor = false;
            this.btnBalanceCheck.Click += new System.EventHandler(this.btnBalanceCheck_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Purple;
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(489, 127);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(143, 55);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposite
            // 
            this.btnDeposite.BackColor = System.Drawing.Color.Purple;
            this.btnDeposite.ForeColor = System.Drawing.Color.White;
            this.btnDeposite.Location = new System.Drawing.Point(180, 240);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.Size = new System.Drawing.Size(143, 55);
            this.btnDeposite.TabIndex = 3;
            this.btnDeposite.Text = "Deposite";
            this.btnDeposite.UseVisualStyleBackColor = false;
            this.btnDeposite.Click += new System.EventHandler(this.btnDeposite_Click);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.BackColor = System.Drawing.Color.Purple;
            this.btnTransactionHistory.ForeColor = System.Drawing.Color.White;
            this.btnTransactionHistory.Location = new System.Drawing.Point(489, 240);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(143, 55);
            this.btnTransactionHistory.TabIndex = 4;
            this.btnTransactionHistory.Text = "TransactionHistory";
            this.btnTransactionHistory.UseVisualStyleBackColor = false;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.btnDeposite);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnBalanceCheck);
            this.Controls.Add(this.lblTransaction);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Button btnBalanceCheck;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposite;
        private System.Windows.Forms.Button btnTransactionHistory;
    }
}