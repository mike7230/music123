namespace music
{
    partial class FormMusicOwner
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
            this.Owner_name = new System.Windows.Forms.TextBox();
            this.Owner_sex = new System.Windows.Forms.TextBox();
            this.Owner_info = new System.Windows.Forms.TextBox();
            this.correct = new System.Windows.Forms.Button();
            this.labal1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Owner_name
            // 
            this.Owner_name.Location = new System.Drawing.Point(136, 40);
            this.Owner_name.Name = "Owner_name";
            this.Owner_name.ReadOnly = true;
            this.Owner_name.Size = new System.Drawing.Size(100, 22);
            this.Owner_name.TabIndex = 1;
            // 
            // Owner_sex
            // 
            this.Owner_sex.Location = new System.Drawing.Point(136, 89);
            this.Owner_sex.Name = "Owner_sex";
            this.Owner_sex.ReadOnly = true;
            this.Owner_sex.Size = new System.Drawing.Size(100, 22);
            this.Owner_sex.TabIndex = 2;
            // 
            // Owner_info
            // 
            this.Owner_info.Location = new System.Drawing.Point(136, 142);
            this.Owner_info.Multiline = true;
            this.Owner_info.Name = "Owner_info";
            this.Owner_info.ReadOnly = true;
            this.Owner_info.Size = new System.Drawing.Size(150, 150);
            this.Owner_info.TabIndex = 3;
            // 
            // correct
            // 
            this.correct.Location = new System.Drawing.Point(195, 339);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(75, 23);
            this.correct.TabIndex = 4;
            this.correct.Text = "確認";
            this.correct.UseVisualStyleBackColor = true;
            this.correct.Click += new System.EventHandler(this.correct_Click);
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(66, 40);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(29, 12);
            this.labal1.TabIndex = 5;
            this.labal1.Text = "暱稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "性別";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "個人資料";
            // 
            // FormMusicOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.correct);
            this.Controls.Add(this.Owner_info);
            this.Controls.Add(this.Owner_sex);
            this.Controls.Add(this.Owner_name);
            this.Name = "FormMusicOwner";
            this.Text = "Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Owner_name;
        private System.Windows.Forms.TextBox Owner_sex;
        private System.Windows.Forms.TextBox Owner_info;
        private System.Windows.Forms.Button correct;
        private System.Windows.Forms.Label labal1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}