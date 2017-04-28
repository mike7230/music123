namespace music
{
    partial class FormMusicInfo
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
            this.correct = new System.Windows.Forms.Button();
            this.Singer = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // correct
            // 
            this.correct.Location = new System.Drawing.Point(192, 348);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(75, 23);
            this.correct.TabIndex = 0;
            this.correct.Text = "確認";
            this.correct.UseVisualStyleBackColor = true;
            this.correct.Click += new System.EventHandler(this.correct_Click);
            // 
            // Singer
            // 
            this.Singer.Location = new System.Drawing.Point(192, 48);
            this.Singer.Name = "Singer";
            this.Singer.ReadOnly = true;
            this.Singer.Size = new System.Drawing.Size(100, 22);
            this.Singer.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(192, 100);
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Size = new System.Drawing.Size(100, 22);
            this.Type.TabIndex = 2;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(192, 156);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Size = new System.Drawing.Size(150, 150);
            this.Info.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "歌手";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "類型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "音樂簡介";
            // 
            // FormMusicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Singer);
            this.Controls.Add(this.correct);
            this.Name = "FormMusicInfo";
            this.Text = "FormMusicInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button correct;
        private System.Windows.Forms.TextBox Singer;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}