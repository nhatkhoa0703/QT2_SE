namespace QT2_SE
{
    partial class UserInfoForm
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
            this.lb_FullName = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_FullName
            // 
            this.lb_FullName.AutoSize = true;
            this.lb_FullName.Location = new System.Drawing.Point(251, 112);
            this.lb_FullName.Name = "lb_FullName";
            this.lb_FullName.Size = new System.Drawing.Size(109, 25);
            this.lb_FullName.TabIndex = 0;
            this.lb_FullName.Text = "Full Name";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(251, 180);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(65, 25);
            this.lb_Email.TabIndex = 1;
            this.lb_Email.Text = "Email";
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Location = new System.Drawing.Point(251, 252);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(155, 25);
            this.lb_PhoneNumber.TabIndex = 2;
            this.lb_PhoneNumber.Text = "Phone Number";
            // 
            // txt_FullName
            // 
            this.txt_FullName.Location = new System.Drawing.Point(473, 112);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(184, 31);
            this.txt_FullName.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(473, 180);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(184, 31);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(473, 246);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(184, 31);
            this.txt_PhoneNumber.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(651, 348);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 41);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 642);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.lb_PhoneNumber);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_FullName);
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            this.Load += new System.EventHandler(this.UserInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_FullName;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Button btn_Save;
    }
}