namespace ATMApp
{
    partial class TransactionHistory
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
            this.historyDatagrid = new System.Windows.Forms.DataGridView();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.historyDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // historyDatagrid
            // 
            this.historyDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDatagrid.Location = new System.Drawing.Point(137, 188);
            this.historyDatagrid.Name = "historyDatagrid";
            this.historyDatagrid.RowHeadersWidth = 51;
            this.historyDatagrid.RowTemplate.Height = 24;
            this.historyDatagrid.Size = new System.Drawing.Size(504, 188);
            this.historyDatagrid.TabIndex = 0;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblPin.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblPin.Location = new System.Drawing.Point(158, 40);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(91, 16);
            this.lblPin.TabIndex = 1;
            this.lblPin.Text = "Enter Your Pin";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(286, 40);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(210, 22);
            this.txtPin.TabIndex = 2;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnHistory.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnHistory.Location = new System.Drawing.Point(286, 96);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(132, 39);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // TransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.historyDatagrid);
            this.Name = "TransactionHistory";
            this.Text = "TransactionHistory";
            ((System.ComponentModel.ISupportInitialize)(this.historyDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView historyDatagrid;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnHistory;
    }
}