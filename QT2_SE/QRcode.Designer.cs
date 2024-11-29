namespace QT2_SE
{
    partial class QRcode
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_PaymentComplete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(317, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(595, 548);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_PaymentComplete
            // 
            this.btn_PaymentComplete.Location = new System.Drawing.Point(826, 708);
            this.btn_PaymentComplete.Name = "btn_PaymentComplete";
            this.btn_PaymentComplete.Size = new System.Drawing.Size(235, 72);
            this.btn_PaymentComplete.TabIndex = 2;
            this.btn_PaymentComplete.Text = "Payment complete";
            this.btn_PaymentComplete.UseVisualStyleBackColor = true;
            this.btn_PaymentComplete.Click += new System.EventHandler(this.btn_PaymentComplete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scan the QR code to complete your payment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 819);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PaymentComplete);
            this.Controls.Add(this.pictureBox2);
            this.Name = "QRcode";
            this.Text = "QRcode";
            this.Load += new System.EventHandler(this.QRcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_PaymentComplete;
        private System.Windows.Forms.Label label1;
    }
}