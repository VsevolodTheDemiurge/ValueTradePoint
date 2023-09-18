
namespace ValueTradePoint
{
    partial class Admin_LoginLog
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
            this.dataGridViewLoginLog = new System.Windows.Forms.DataGridView();
            this.textBoxUsernameFilter = new System.Windows.Forms.TextBox();
            this.lableUsernameFilter = new System.Windows.Forms.Label();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApplySort = new System.Windows.Forms.Button();
            this.buttonMainPageReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoginLog
            // 
            this.dataGridViewLoginLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoginLog.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewLoginLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewLoginLog.Name = "dataGridViewLoginLog";
            this.dataGridViewLoginLog.RowHeadersWidth = 51;
            this.dataGridViewLoginLog.RowTemplate.Height = 24;
            this.dataGridViewLoginLog.Size = new System.Drawing.Size(454, 267);
            this.dataGridViewLoginLog.TabIndex = 0;
            // 
            // textBoxUsernameFilter
            // 
            this.textBoxUsernameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsernameFilter.Location = new System.Drawing.Point(9, 298);
            this.textBoxUsernameFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsernameFilter.Name = "textBoxUsernameFilter";
            this.textBoxUsernameFilter.Size = new System.Drawing.Size(122, 23);
            this.textBoxUsernameFilter.TabIndex = 1;
            this.textBoxUsernameFilter.TextChanged += new System.EventHandler(this.textBoxUsernameFilter_TextChanged);
            // 
            // lableUsernameFilter
            // 
            this.lableUsernameFilter.AutoSize = true;
            this.lableUsernameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableUsernameFilter.Location = new System.Drawing.Point(6, 280);
            this.lableUsernameFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableUsernameFilter.Name = "lableUsernameFilter";
            this.lableUsernameFilter.Size = new System.Drawing.Size(116, 17);
            this.lableUsernameFilter.TabIndex = 2;
            this.lableUsernameFilter.Text = "Поиск по логину";
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApplyFilter.Location = new System.Drawing.Point(134, 297);
            this.buttonApplyFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(58, 24);
            this.buttonApplyFilter.TabIndex = 3;
            this.buttonApplyFilter.Text = "Поиск";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(196, 297);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(156, 25);
            this.comboBoxSortBy.TabIndex = 4;
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(196, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сортировка по дате";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonApplySort
            // 
            this.buttonApplySort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApplySort.Location = new System.Drawing.Point(356, 298);
            this.buttonApplySort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonApplySort.Name = "buttonApplySort";
            this.buttonApplySort.Size = new System.Drawing.Size(107, 24);
            this.buttonApplySort.TabIndex = 6;
            this.buttonApplySort.Text = "Сортировать";
            this.buttonApplySort.UseVisualStyleBackColor = true;
            this.buttonApplySort.Click += new System.EventHandler(this.buttonApplySort_Click);
            // 
            // buttonMainPageReturn
            // 
            this.buttonMainPageReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainPageReturn.Location = new System.Drawing.Point(167, 341);
            this.buttonMainPageReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMainPageReturn.Name = "buttonMainPageReturn";
            this.buttonMainPageReturn.Size = new System.Drawing.Size(136, 36);
            this.buttonMainPageReturn.TabIndex = 7;
            this.buttonMainPageReturn.Text = "На главную";
            this.buttonMainPageReturn.UseVisualStyleBackColor = true;
            this.buttonMainPageReturn.Click += new System.EventHandler(this.buttonMainPageReturn_Click);
            // 
            // Admin_LoginLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(474, 388);
            this.Controls.Add(this.buttonMainPageReturn);
            this.Controls.Add(this.buttonApplySort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.lableUsernameFilter);
            this.Controls.Add(this.textBoxUsernameFilter);
            this.Controls.Add(this.dataGridViewLoginLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin_LoginLog";
            this.Text = "Журнал авторизаций";
            this.Load += new System.EventHandler(this.Admin_LoginLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoginLog;
        private System.Windows.Forms.TextBox textBoxUsernameFilter;
        private System.Windows.Forms.Label lableUsernameFilter;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApplySort;
        private System.Windows.Forms.Button buttonMainPageReturn;
    }
}