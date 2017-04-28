namespace music
{
    partial class FormChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancel = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.modify = new System.Windows.Forms.Button();
            this.password_Label = new System.Windows.Forms.Label();
            this.email_Label = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(250, 150);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Location = new System.Drawing.Point(125, 95);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(200, 22);
            this.password.TabIndex = 12;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(125, 45);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 22);
            this.email.TabIndex = 11;
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(125, 150);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(75, 23);
            this.modify.TabIndex = 10;
            this.modify.Text = "送出";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Location = new System.Drawing.Point(50, 100);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(41, 12);
            this.password_Label.TabIndex = 9;
            this.password_Label.Text = "新密碼";
            // 
            // email_Label
            // 
            this.email_Label.AutoSize = true;
            this.email_Label.Location = new System.Drawing.Point(50, 50);
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(29, 12);
            this.email_Label.TabIndex = 8;
            this.email_Label.Text = "信箱";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(50, 200);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 12);
            this.message.TabIndex = 14;
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.message);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.email_Label);
            this.KeyPreview = true;
            this.Name = "FormChangePassword";
            this.Text = "FormChangePassword";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormChangePassword_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.Label email_Label;
        private System.Windows.Forms.Label message;
    }
}