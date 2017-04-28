namespace music
{
    partial class FormMusicUpload
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
            this.name_label = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.singer_label = new System.Windows.Forms.Label();
            this.singer = new System.Windows.Forms.TextBox();
            this.lyrics_button = new System.Windows.Forms.Button();
            this.music_button = new System.Windows.Forms.Button();
            this.upload_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.tag_label1 = new System.Windows.Forms.Label();
            this.tag3 = new System.Windows.Forms.CheckBox();
            this.tag4 = new System.Windows.Forms.CheckBox();
            this.tag1 = new System.Windows.Forms.CheckBox();
            this.tag2 = new System.Windows.Forms.CheckBox();
            this.tag5 = new System.Windows.Forms.CheckBox();
            this.tag6 = new System.Windows.Forms.CheckBox();
            this.tag7 = new System.Windows.Forms.CheckBox();
            this.tag8 = new System.Windows.Forms.CheckBox();
            this.tag_label2 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.info_label = new System.Windows.Forms.Label();
            this.music = new System.Windows.Forms.TextBox();
            this.lyrics = new System.Windows.Forms.TextBox();
            this.lyrics_label = new System.Windows.Forms.Label();
            this.tag = new System.Windows.Forms.GroupBox();
            this.message = new System.Windows.Forms.Label();
            this.tag.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(50, 50);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(53, 12);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "歌曲名稱";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(125, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 22);
            this.name.TabIndex = 1;
            // 
            // singer_label
            // 
            this.singer_label.AutoSize = true;
            this.singer_label.Location = new System.Drawing.Point(50, 100);
            this.singer_label.Name = "singer_label";
            this.singer_label.Size = new System.Drawing.Size(68, 12);
            this.singer_label.TabIndex = 4;
            this.singer_label.Text = "創作者/團體";
            // 
            // singer
            // 
            this.singer.Location = new System.Drawing.Point(125, 95);
            this.singer.Name = "singer";
            this.singer.Size = new System.Drawing.Size(200, 22);
            this.singer.TabIndex = 5;
            // 
            // lyrics_button
            // 
            this.lyrics_button.Location = new System.Drawing.Point(250, 620);
            this.lyrics_button.Name = "lyrics_button";
            this.lyrics_button.Size = new System.Drawing.Size(75, 23);
            this.lyrics_button.TabIndex = 6;
            this.lyrics_button.Text = "從文字檔";
            this.lyrics_button.UseVisualStyleBackColor = true;
            this.lyrics_button.Click += new System.EventHandler(this.lyrics_button_Click);
            // 
            // music_button
            // 
            this.music_button.Location = new System.Drawing.Point(250, 575);
            this.music_button.Name = "music_button";
            this.music_button.Size = new System.Drawing.Size(75, 23);
            this.music_button.TabIndex = 8;
            this.music_button.Text = "選擇音樂";
            this.music_button.UseVisualStyleBackColor = true;
            this.music_button.Click += new System.EventHandler(this.music_button_Click);
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(125, 1000);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(75, 23);
            this.upload_button.TabIndex = 10;
            this.upload_button.Text = "上傳";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(250, 1000);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 11;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // tag_label1
            // 
            this.tag_label1.AutoSize = true;
            this.tag_label1.Location = new System.Drawing.Point(5, 25);
            this.tag_label1.Name = "tag_label1";
            this.tag_label1.Size = new System.Drawing.Size(73, 12);
            this.tag_label1.TabIndex = 12;
            this.tag_label1.Text = "分類(二擇一)";
            // 
            // tag3
            // 
            this.tag3.AutoSize = true;
            this.tag3.Location = new System.Drawing.Point(5, 100);
            this.tag3.Name = "tag3";
            this.tag3.Size = new System.Drawing.Size(60, 16);
            this.tag3.TabIndex = 13;
            this.tag3.Text = "純音樂";
            this.tag3.UseVisualStyleBackColor = true;
            // 
            // tag4
            // 
            this.tag4.AutoSize = true;
            this.tag4.Location = new System.Drawing.Point(145, 100);
            this.tag4.Name = "tag4";
            this.tag4.Size = new System.Drawing.Size(48, 16);
            this.tag4.TabIndex = 14;
            this.tag4.Text = "搖滾";
            this.tag4.UseVisualStyleBackColor = true;
            // 
            // tag1
            // 
            this.tag1.AutoSize = true;
            this.tag1.Location = new System.Drawing.Point(5, 50);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(48, 16);
            this.tag1.TabIndex = 15;
            this.tag1.Text = "原創";
            this.tag1.UseVisualStyleBackColor = true;
            this.tag1.CheckedChanged += new System.EventHandler(this.tag1_CheckedChanged);
            // 
            // tag2
            // 
            this.tag2.AutoSize = true;
            this.tag2.Location = new System.Drawing.Point(75, 50);
            this.tag2.Name = "tag2";
            this.tag2.Size = new System.Drawing.Size(48, 16);
            this.tag2.TabIndex = 16;
            this.tag2.Text = "翻唱";
            this.tag2.UseVisualStyleBackColor = true;
            this.tag2.CheckedChanged += new System.EventHandler(this.tag2_CheckedChanged);
            // 
            // tag5
            // 
            this.tag5.AutoSize = true;
            this.tag5.Location = new System.Drawing.Point(215, 100);
            this.tag5.Name = "tag5";
            this.tag5.Size = new System.Drawing.Size(48, 16);
            this.tag5.TabIndex = 17;
            this.tag5.Text = "爵士";
            this.tag5.UseVisualStyleBackColor = true;
            // 
            // tag6
            // 
            this.tag6.AutoSize = true;
            this.tag6.Location = new System.Drawing.Point(5, 125);
            this.tag6.Name = "tag6";
            this.tag6.Size = new System.Drawing.Size(60, 16);
            this.tag6.TabIndex = 18;
            this.tag6.Text = "輕音樂";
            this.tag6.UseVisualStyleBackColor = true;
            // 
            // tag7
            // 
            this.tag7.AutoSize = true;
            this.tag7.Location = new System.Drawing.Point(75, 125);
            this.tag7.Name = "tag7";
            this.tag7.Size = new System.Drawing.Size(72, 16);
            this.tag7.TabIndex = 19;
            this.tag7.Text = "流行音樂";
            this.tag7.UseVisualStyleBackColor = true;
            // 
            // tag8
            // 
            this.tag8.AutoSize = true;
            this.tag8.Location = new System.Drawing.Point(75, 100);
            this.tag8.Name = "tag8";
            this.tag8.Size = new System.Drawing.Size(60, 16);
            this.tag8.TabIndex = 20;
            this.tag8.Text = "重金屬";
            this.tag8.UseVisualStyleBackColor = true;
            // 
            // tag_label2
            // 
            this.tag_label2.AutoSize = true;
            this.tag_label2.Location = new System.Drawing.Point(5, 75);
            this.tag_label2.Name = "tag_label2";
            this.tag_label2.Size = new System.Drawing.Size(53, 12);
            this.tag_label2.TabIndex = 21;
            this.tag_label2.Text = "音樂類型";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(50, 375);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.info.Size = new System.Drawing.Size(275, 150);
            this.info.TabIndex = 22;
            this.info.WordWrap = false;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(50, 350);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(53, 12);
            this.info_label.TabIndex = 23;
            this.info_label.Text = "歌曲簡介";
            // 
            // music
            // 
            this.music.Location = new System.Drawing.Point(50, 575);
            this.music.Name = "music";
            this.music.ReadOnly = true;
            this.music.Size = new System.Drawing.Size(200, 22);
            this.music.TabIndex = 24;
            // 
            // lyrics
            // 
            this.lyrics.Location = new System.Drawing.Point(50, 650);
            this.lyrics.Multiline = true;
            this.lyrics.Name = "lyrics";
            this.lyrics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lyrics.Size = new System.Drawing.Size(275, 300);
            this.lyrics.TabIndex = 25;
            this.lyrics.WordWrap = false;
            // 
            // lyrics_label
            // 
            this.lyrics_label.AutoSize = true;
            this.lyrics_label.Location = new System.Drawing.Point(50, 625);
            this.lyrics_label.Name = "lyrics_label";
            this.lyrics_label.Size = new System.Drawing.Size(29, 12);
            this.lyrics_label.TabIndex = 26;
            this.lyrics_label.Text = "歌詞";
            // 
            // tag
            // 
            this.tag.Controls.Add(this.tag_label1);
            this.tag.Controls.Add(this.tag1);
            this.tag.Controls.Add(this.tag2);
            this.tag.Controls.Add(this.tag_label2);
            this.tag.Controls.Add(this.tag3);
            this.tag.Controls.Add(this.tag8);
            this.tag.Controls.Add(this.tag7);
            this.tag.Controls.Add(this.tag4);
            this.tag.Controls.Add(this.tag6);
            this.tag.Controls.Add(this.tag5);
            this.tag.Location = new System.Drawing.Point(50, 150);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(275, 150);
            this.tag.TabIndex = 27;
            this.tag.TabStop = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(50, 1050);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 12);
            this.message.TabIndex = 28;
            // 
            // FormMusicUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.ClientSize = new System.Drawing.Size(518, 461);
            this.Controls.Add(this.message);
            this.Controls.Add(this.tag);
            this.Controls.Add(this.lyrics_label);
            this.Controls.Add(this.lyrics);
            this.Controls.Add(this.music);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.info);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.music_button);
            this.Controls.Add(this.lyrics_button);
            this.Controls.Add(this.singer);
            this.Controls.Add(this.singer_label);
            this.Controls.Add(this.name);
            this.Controls.Add(this.name_label);
            this.Name = "FormMusicUpload";
            this.Text = "FormMusicUpload";
            this.tag.ResumeLayout(false);
            this.tag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label singer_label;
        private System.Windows.Forms.TextBox singer;
        private System.Windows.Forms.Button lyrics_button;
        private System.Windows.Forms.Button music_button;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label tag_label1;
        private System.Windows.Forms.CheckBox tag3;
        private System.Windows.Forms.CheckBox tag4;
        private System.Windows.Forms.CheckBox tag1;
        private System.Windows.Forms.CheckBox tag2;
        private System.Windows.Forms.CheckBox tag5;
        private System.Windows.Forms.CheckBox tag6;
        private System.Windows.Forms.CheckBox tag7;
        private System.Windows.Forms.CheckBox tag8;
        private System.Windows.Forms.Label tag_label2;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.TextBox music;
        private System.Windows.Forms.TextBox lyrics;
        private System.Windows.Forms.Label lyrics_label;
        private System.Windows.Forms.GroupBox tag;
        private System.Windows.Forms.Label message;
    }
}