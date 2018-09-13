namespace PhoneApplication {
    partial class PhoneApp {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.IPhoneHeadset = new System.Windows.Forms.RadioButton();
            this.SamsungHeadset = new System.Windows.Forms.RadioButton();
            this.PhoneSpeaker = new System.Windows.Forms.RadioButton();
            this.Apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MonochromeScreen = new System.Windows.Forms.RadioButton();
            this.ColorfulScreen = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPhoneHeadset
            // 
            this.IPhoneHeadset.AutoSize = true;
            this.IPhoneHeadset.Location = new System.Drawing.Point(6, 19);
            this.IPhoneHeadset.Name = "IPhoneHeadset";
            this.IPhoneHeadset.Size = new System.Drawing.Size(99, 17);
            this.IPhoneHeadset.TabIndex = 1;
            this.IPhoneHeadset.TabStop = true;
            this.IPhoneHeadset.Text = "IPhoneHeadset";
            this.IPhoneHeadset.UseVisualStyleBackColor = true;
            this.IPhoneHeadset.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // SamsungHeadset
            // 
            this.SamsungHeadset.AutoSize = true;
            this.SamsungHeadset.Location = new System.Drawing.Point(6, 42);
            this.SamsungHeadset.Name = "SamsungHeadset";
            this.SamsungHeadset.Size = new System.Drawing.Size(109, 17);
            this.SamsungHeadset.TabIndex = 2;
            this.SamsungHeadset.TabStop = true;
            this.SamsungHeadset.Text = "SamsungHeadset";
            this.SamsungHeadset.UseVisualStyleBackColor = true;
            // 
            // PhoneSpeaker
            // 
            this.PhoneSpeaker.AutoSize = true;
            this.PhoneSpeaker.Location = new System.Drawing.Point(6, 69);
            this.PhoneSpeaker.Name = "PhoneSpeaker";
            this.PhoneSpeaker.Size = new System.Drawing.Size(96, 17);
            this.PhoneSpeaker.TabIndex = 3;
            this.PhoneSpeaker.TabStop = true;
            this.PhoneSpeaker.Text = "PhoneSpeaker";
            this.PhoneSpeaker.UseVisualStyleBackColor = true;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(277, 127);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(101, 42);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select playback and screen components:";
            // 
            // MonochromeScreen
            // 
            this.MonochromeScreen.AutoSize = true;
            this.MonochromeScreen.Location = new System.Drawing.Point(24, 24);
            this.MonochromeScreen.Name = "MonochromeScreen";
            this.MonochromeScreen.Size = new System.Drawing.Size(121, 17);
            this.MonochromeScreen.TabIndex = 7;
            this.MonochromeScreen.TabStop = true;
            this.MonochromeScreen.Text = "MonochromeScreen";
            this.MonochromeScreen.UseVisualStyleBackColor = true;
            // 
            // ColorfulScreen
            // 
            this.ColorfulScreen.AutoSize = true;
            this.ColorfulScreen.Location = new System.Drawing.Point(24, 47);
            this.ColorfulScreen.Name = "ColorfulScreen";
            this.ColorfulScreen.Size = new System.Drawing.Size(94, 17);
            this.ColorfulScreen.TabIndex = 8;
            this.ColorfulScreen.TabStop = true;
            this.ColorfulScreen.Text = "ColorfulScreen";
            this.ColorfulScreen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IPhoneHeadset);
            this.groupBox1.Controls.Add(this.SamsungHeadset);
            this.groupBox1.Controls.Add(this.PhoneSpeaker);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ColorfulScreen);
            this.groupBox2.Controls.Add(this.MonochromeScreen);
            this.groupBox2.Location = new System.Drawing.Point(178, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 87);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 143);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // PhoneApp
            // 
            this.AcceptButton = this.Apply;
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(412, 393);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Apply);
            this.Name = "PhoneApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simcorp Mobile Phone";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.PhoneApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton IPhoneHeadset;
        private System.Windows.Forms.RadioButton SamsungHeadset;
        private System.Windows.Forms.RadioButton PhoneSpeaker;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MonochromeScreen;
        private System.Windows.Forms.RadioButton ColorfulScreen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

