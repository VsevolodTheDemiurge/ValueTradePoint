
namespace ValueTradePoint
{
    partial class Admin_Main
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
            this.buttonLoginLog = new System.Windows.Forms.Button();
            this.buttonDealsView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginLog
            // 
            this.buttonLoginLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoginLog.Location = new System.Drawing.Point(205, 100);
            this.buttonLoginLog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoginLog.Name = "buttonLoginLog";
            this.buttonLoginLog.Size = new System.Drawing.Size(128, 71);
            this.buttonLoginLog.TabIndex = 0;
            this.buttonLoginLog.Text = "Журнал авторизаций";
            this.buttonLoginLog.UseVisualStyleBackColor = true;
            this.buttonLoginLog.Click += new System.EventHandler(this.buttonLoginLog_Click);
            // 
            // buttonDealsView
            // 
            this.buttonDealsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDealsView.Location = new System.Drawing.Point(205, 33);
            this.buttonDealsView.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDealsView.Name = "buttonDealsView";
            this.buttonDealsView.Size = new System.Drawing.Size(128, 62);
            this.buttonDealsView.TabIndex = 3;
            this.buttonDealsView.Text = "Просмотр сделок";
            this.buttonDealsView.UseVisualStyleBackColor = true;
            this.buttonDealsView.Click += new System.EventHandler(this.buttonDealsView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добро пожаловать!";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(22, 223);
            this.labelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(159, 24);
            this.labelRole.TabIndex = 6;
            this.labelRole.Text = "Администратор.";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ValueTradePoint.Properties.Resources._18601_photo_resizer_ru__1_;
            this.pictureBox1.Location = new System.Drawing.Point(13, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 187);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDealsView);
            this.Controls.Add(this.buttonLoginLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin_Main";
            this.Text = "Меню администрации";
            this.Load += new System.EventHandler(this.Admin_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginLog;
        private System.Windows.Forms.Button buttonDealsView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}