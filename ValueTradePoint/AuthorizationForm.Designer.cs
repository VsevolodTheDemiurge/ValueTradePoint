namespace ValueTradePoint
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.Enter_Button = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordShowCheckBox = new System.Windows.Forms.CheckBox();
            this.CaptchaPictureBox = new System.Windows.Forms.PictureBox();
            this.CaptchaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Enter_Button
            // 
            this.Enter_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Enter_Button, "Enter_Button");
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // LoginTextBox
            // 
            resources.ApplyResources(this.LoginTextBox, "LoginTextBox");
            this.LoginTextBox.Name = "LoginTextBox";
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            resources.ApplyResources(this.LoginLabel, "LoginLabel");
            this.LoginLabel.Name = "LoginLabel";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // PasswordShowCheckBox
            // 
            resources.ApplyResources(this.PasswordShowCheckBox, "PasswordShowCheckBox");
            this.PasswordShowCheckBox.Name = "PasswordShowCheckBox";
            this.PasswordShowCheckBox.UseVisualStyleBackColor = true;
            this.PasswordShowCheckBox.CheckedChanged += new System.EventHandler(this.PasswordShowCheckBox_CheckedChanged);
            // 
            // CaptchaPictureBox
            // 
            resources.ApplyResources(this.CaptchaPictureBox, "CaptchaPictureBox");
            this.CaptchaPictureBox.Name = "CaptchaPictureBox";
            this.CaptchaPictureBox.TabStop = false;
            this.CaptchaPictureBox.Click += new System.EventHandler(this.CaptchaPictureBox_Click);
            // 
            // CaptchaTextBox
            // 
            resources.ApplyResources(this.CaptchaTextBox, "CaptchaTextBox");
            this.CaptchaTextBox.Name = "CaptchaTextBox";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AuthorizationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CaptchaTextBox);
            this.Controls.Add(this.CaptchaPictureBox);
            this.Controls.Add(this.PasswordShowCheckBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.Enter_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox PasswordShowCheckBox;
        private System.Windows.Forms.PictureBox CaptchaPictureBox;
        private System.Windows.Forms.TextBox CaptchaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

