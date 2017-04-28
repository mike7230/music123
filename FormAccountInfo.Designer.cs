namespace music
{
    partial class FormAccountInfo
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
            this.name_Label = new System.Windows.Forms.Label();
            this.sex_Label = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.info_Label = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(50, 50);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(29, 12);
            this.name_Label.TabIndex = 0;
            this.name_Label.Text = "暱稱";
            // 
            // sex_Label
            // 
            this.sex_Label.AutoSize = true;
            this.sex_Label.Location = new System.Drawing.Point(50, 100);
            this.sex_Label.Name = "sex_Label";
            this.sex_Label.Size = new System.Drawing.Size(29, 12);
            this.sex_Label.TabIndex = 1;
            this.sex_Label.Text = "性別";
            // 
            // sex
            // 
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "",
            "男性",
            "女性"});
            this.sex.Location = new System.Drawing.Point(125, 95);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(200, 20);
            this.sex.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(125, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 22);
            this.name.TabIndex = 3;
            // 
            // info_Label
            // 
            this.info_Label.AutoSize = true;
            this.info_Label.Location = new System.Drawing.Point(50, 150);
            this.info_Label.Name = "info_Label";
            this.info_Label.Size = new System.Drawing.Size(53, 12);
            this.info_Label.TabIndex = 4;
            this.info_Label.Text = "個人資料";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(50, 175);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.info.Size = new System.Drawing.Size(275, 150);
            this.info.TabIndex = 5;
            this.info.WordWrap = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(125, 375);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 6;
            this.save.Text = "儲存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(250, 375);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(50, 425);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 12);
            this.message.TabIndex = 15;
            // 
            // FormAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.message);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.info);
            this.Controls.Add(this.info_Label);
            this.Controls.Add(this.name);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.sex_Label);
            this.Controls.Add(this.name_Label);
            this.Name = "FormAccountInfo";
            this.Text = "FormAccountInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label sex_Label;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label info_Label;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label message;
    }
}