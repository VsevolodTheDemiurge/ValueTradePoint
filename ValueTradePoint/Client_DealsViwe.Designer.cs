
namespace ValueTradePoint
{
    partial class Client_DealsViwe
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
            this.сделкиTableAdapter = new ValueTradePoint._polyakov_429195_24DataSetTableAdapters.СделкиTableAdapter();
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
            // сделкиTableAdapter
            // 
            this.сделкиTableAdapter.ClearBeforeFill = true;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.Location = new System.Drawing.Point(12, 269);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(116, 34);
            this.returnButton.TabIndex = 21;
            this.returnButton.Text = "На главную";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Client_DealsViwe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 316);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client_DealsViwe";
            this.Text = "Управление сделками";
            this.Load += new System.EventHandler(this.DealsViwe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._polyakov_429195_24DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button returnButton;
    }
}