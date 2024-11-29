namespace QT2_SE
{
    partial class Creditcard
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardholderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnCompletePayment = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pbMoMo = new System.Windows.Forms.PictureBox();
            this.pbVCB = new System.Windows.Forms.PictureBox();
            this.pbVIB = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoMo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVIB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card number";
            // 
            // txtCardholderName
            // 
            this.txtCardholderName.Location = new System.Drawing.Point(130, 272);
            this.txtCardholderName.Name = "txtCardholderName";
            this.txtCardholderName.Size = new System.Drawing.Size(334, 31);
            this.txtCardholderName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cardholder name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expiration date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(721, 270);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 11, 13, 8, 40, 2, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2024, 11, 13, 8, 40, 2, 0);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(130, 417);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(334, 31);
            this.txtCardNumber.TabIndex = 5;
            // 
            // btnCompletePayment
            // 
            this.btnCompletePayment.Location = new System.Drawing.Point(130, 512);
            this.btnCompletePayment.Name = "btnCompletePayment";
            this.btnCompletePayment.Size = new System.Drawing.Size(237, 52);
            this.btnCompletePayment.TabIndex = 6;
            this.btnCompletePayment.Text = "Complete payment";
            this.btnCompletePayment.UseVisualStyleBackColor = true;
            this.btnCompletePayment.Click += new System.EventHandler(this.btnCompletePayment_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(202, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(27, 26);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(503, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(27, 26);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(805, 48);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(27, 26);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // pbMoMo
            // 
            this.pbMoMo.Location = new System.Drawing.Point(265, 27);
            this.pbMoMo.Name = "pbMoMo";
            this.pbMoMo.Size = new System.Drawing.Size(121, 65);
            this.pbMoMo.TabIndex = 10;
            this.pbMoMo.TabStop = false;
            this.pbMoMo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbVCB
            // 
            this.pbVCB.Location = new System.Drawing.Point(594, 27);
            this.pbVCB.Name = "pbVCB";
            this.pbVCB.Size = new System.Drawing.Size(121, 65);
            this.pbVCB.TabIndex = 11;
            this.pbVCB.TabStop = false;
            // 
            // pbVIB
            // 
            this.pbVIB.Location = new System.Drawing.Point(919, 27);
            this.pbVIB.Name = "pbVIB";
            this.pbVIB.Size = new System.Drawing.Size(121, 65);
            this.pbVIB.TabIndex = 12;
            this.pbVIB.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "CVV";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(721, 416);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(200, 31);
            this.txtCVV.TabIndex = 14;
            // 
            // Creditcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 691);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbVIB);
            this.Controls.Add(this.pbVCB);
            this.Controls.Add(this.pbMoMo);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnCompletePayment);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardholderName);
            this.Controls.Add(this.label1);
            this.Name = "Creditcard";
            this.Text = "Creditcard";
            this.Load += new System.EventHandler(this.Creditcard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMoMo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVIB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardholderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Button btnCompletePayment;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.PictureBox pbMoMo;
        private System.Windows.Forms.PictureBox pbVCB;
        private System.Windows.Forms.PictureBox pbVIB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCVV;
    }
}