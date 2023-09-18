
namespace ValueTradePoint
{
    partial class Admin_DealsViwe
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиеВалютыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКассираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусСделкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСделкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяСделкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаПроданнойВалютыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаКупленнойВалютыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сделкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._polyakov_429195_24DataSet = new ValueTradePoint._polyakov_429195_24DataSet();
            this.InsertButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.сделкиTableAdapter = new ValueTradePoint._polyakov_429195_24DataSetTableAdapters.СделкиTableAdapter();
            this.CurrencyTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.SaleAmountTextBox = new System.Windows.Forms.TextBox();
            this.PurchaseAmountTextBox = new System.Windows.Forms.TextBox();
            this.CashierNumberTextBox = new System.Windows.Forms.TextBox();
            this.ClientNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._polyakov_429195_24DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеВалютыDataGridViewTextBoxColumn,
            this.номерКассираDataGridViewTextBoxColumn,
            this.номерКлиентаDataGridViewTextBoxColumn,
            this.статусСделкиDataGridViewTextBoxColumn,
            this.датаСделкиDataGridViewTextBoxColumn,
            this.времяСделкиDataGridViewTextBoxColumn,
            this.суммаПроданнойВалютыDataGridViewTextBoxColumn,
            this.суммаКупленнойВалютыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сделкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // названиеВалютыDataGridViewTextBoxColumn
            // 
            this.названиеВалютыDataGridViewTextBoxColumn.DataPropertyName = "Название_Валюты";
            this.названиеВалютыDataGridViewTextBoxColumn.HeaderText = "Название_Валюты";
            this.названиеВалютыDataGridViewTextBoxColumn.Name = "названиеВалютыDataGridViewTextBoxColumn";
            // 
            // номерКассираDataGridViewTextBoxColumn
            // 
            this.номерКассираDataGridViewTextBoxColumn.DataPropertyName = "Номер_Кассира";
            this.номерКассираDataGridViewTextBoxColumn.HeaderText = "Номер_Кассира";
            this.номерКассираDataGridViewTextBoxColumn.Name = "номерКассираDataGridViewTextBoxColumn";
            // 
            // номерКлиентаDataGridViewTextBoxColumn
            // 
            this.номерКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Номер_Клиента";
            this.номерКлиентаDataGridViewTextBoxColumn.HeaderText = "Номер_Клиента";
            this.номерКлиентаDataGridViewTextBoxColumn.Name = "номерКлиентаDataGridViewTextBoxColumn";
            // 
            // статусСделкиDataGridViewTextBoxColumn
            // 
            this.статусСделкиDataGridViewTextBoxColumn.DataPropertyName = "Статус_Сделки";
            this.статусСделкиDataGridViewTextBoxColumn.HeaderText = "Статус_Сделки";
            this.статусСделкиDataGridViewTextBoxColumn.Name = "статусСделкиDataGridViewTextBoxColumn";
            // 
            // датаСделкиDataGridViewTextBoxColumn
            // 
            this.датаСделкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_Сделки";
            this.датаСделкиDataGridViewTextBoxColumn.HeaderText = "Дата_Сделки";
            this.датаСделкиDataGridViewTextBoxColumn.Name = "датаСделкиDataGridViewTextBoxColumn";
            // 
            // времяСделкиDataGridViewTextBoxColumn
            // 
            this.времяСделкиDataGridViewTextBoxColumn.DataPropertyName = "Время_Сделки";
            this.времяСделкиDataGridViewTextBoxColumn.HeaderText = "Время_Сделки";
            this.времяСделкиDataGridViewTextBoxColumn.Name = "времяСделкиDataGridViewTextBoxColumn";
            // 
            // суммаПроданнойВалютыDataGridViewTextBoxColumn
            // 
            this.суммаПроданнойВалютыDataGridViewTextBoxColumn.DataPropertyName = "Сумма_Проданной_Валюты";
            this.суммаПроданнойВалютыDataGridViewTextBoxColumn.HeaderText = "Сумма_Проданной_Валюты";
            this.суммаПроданнойВалютыDataGridViewTextBoxColumn.Name = "суммаПроданнойВалютыDataGridViewTextBoxColumn";
            // 
            // суммаКупленнойВалютыDataGridViewTextBoxColumn
            // 
            this.суммаКупленнойВалютыDataGridViewTextBoxColumn.DataPropertyName = "Сумма_Купленной_Валюты";
            this.суммаКупленнойВалютыDataGridViewTextBoxColumn.HeaderText = "Сумма_Купленной_Валюты";
            this.суммаКупленнойВалютыDataGridViewTextBoxColumn.Name = "суммаКупленнойВалютыDataGridViewTextBoxColumn";
            // 
            // сделкиBindingSource
            // 
            this.сделкиBindingSource.DataMember = "Сделки";
            this.сделкиBindingSource.DataSource = this._polyakov_429195_24DataSet;
            // 
            // _polyakov_429195_24DataSet
            // 
            this._polyakov_429195_24DataSet.DataSetName = "_polyakov_429195_24DataSet";
            this._polyakov_429195_24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InsertButton
            // 
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertButton.Location = new System.Drawing.Point(434, 315);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(100, 34);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(540, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // сделкиTableAdapter
            // 
            this.сделкиTableAdapter.ClearBeforeFill = true;
            // 
            // CurrencyTextBox
            // 
            this.CurrencyTextBox.Location = new System.Drawing.Point(14, 289);
            this.CurrencyTextBox.Name = "CurrencyTextBox";
            this.CurrencyTextBox.Size = new System.Drawing.Size(121, 20);
            this.CurrencyTextBox.TabIndex = 4;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(15, 328);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(122, 20);
            this.TimeTextBox.TabIndex = 5;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(391, 289);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(122, 20);
            this.StatusTextBox.TabIndex = 6;
            // 
            // SaleAmountTextBox
            // 
            this.SaleAmountTextBox.Location = new System.Drawing.Point(143, 328);
            this.SaleAmountTextBox.Name = "SaleAmountTextBox";
            this.SaleAmountTextBox.Size = new System.Drawing.Size(138, 20);
            this.SaleAmountTextBox.TabIndex = 7;
            // 
            // PurchaseAmountTextBox
            // 
            this.PurchaseAmountTextBox.Location = new System.Drawing.Point(290, 328);
            this.PurchaseAmountTextBox.Name = "PurchaseAmountTextBox";
            this.PurchaseAmountTextBox.Size = new System.Drawing.Size(138, 20);
            this.PurchaseAmountTextBox.TabIndex = 8;
            // 
            // CashierNumberTextBox
            // 
            this.CashierNumberTextBox.Location = new System.Drawing.Point(141, 289);
            this.CashierNumberTextBox.Name = "CashierNumberTextBox";
            this.CashierNumberTextBox.Size = new System.Drawing.Size(117, 20);
            this.CashierNumberTextBox.TabIndex = 9;
            // 
            // ClientNumberTextBox
            // 
            this.ClientNumberTextBox.Location = new System.Drawing.Point(264, 289);
            this.ClientNumberTextBox.Name = "ClientNumberTextBox";
            this.ClientNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.ClientNumberTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название Валюты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Номер Кассира";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Номер Клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Статус Сделки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Дата Сделки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Время Сделки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Сумма Проданной Валюты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Сумма Купленной Валюты";
            // 
            // DateDateTimePicker
            // 
            this.DateDateTimePicker.Location = new System.Drawing.Point(518, 289);
            this.DateDateTimePicker.Name = "DateDateTimePicker";
            this.DateDateTimePicker.Size = new System.Drawing.Size(244, 20);
            this.DateDateTimePicker.TabIndex = 20;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.Location = new System.Drawing.Point(646, 315);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(116, 34);
            this.returnButton.TabIndex = 21;
            this.returnButton.Text = "На главную";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // DealsViwe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 359);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.DateDateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientNumberTextBox);
            this.Controls.Add(this.CashierNumberTextBox);
            this.Controls.Add(this.PurchaseAmountTextBox);
            this.Controls.Add(this.SaleAmountTextBox);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.CurrencyTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DealsViwe";
            this.Text = "Управление сделками";
            this.Load += new System.EventHandler(this.DealsViwe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._polyakov_429195_24DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button button3;
        private _polyakov_429195_24DataSet _polyakov_429195_24DataSet;
        private System.Windows.Forms.BindingSource сделкиBindingSource;
        private _polyakov_429195_24DataSetTableAdapters.СделкиTableAdapter сделкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеВалютыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКассираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусСделкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСделкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяСделкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаПроданнойВалютыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаКупленнойВалютыDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox CurrencyTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.TextBox SaleAmountTextBox;
        private System.Windows.Forms.TextBox PurchaseAmountTextBox;
        private System.Windows.Forms.TextBox CashierNumberTextBox;
        private System.Windows.Forms.TextBox ClientNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateDateTimePicker;
        private System.Windows.Forms.Button returnButton;
    }
}