
namespace Lab10c
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new Lab10c.masterDataSet();
            this.possBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.possTableAdapter = new Lab10c.masterDataSetTableAdapters.possTableAdapter();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarogdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sempologkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katobuchkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuzkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomerDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.datarogdenDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.sempologkDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.katobuchkDataGridViewTextBoxColumn,
            this.vuzkDataGridViewTextBoxColumn,
            this.mpDataGridViewTextBoxColumn,
            this.gpDataGridViewTextBoxColumn,
            this.moDataGridViewTextBoxColumn,
            this.gokDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.possBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1212, 483);
            this.dataGridView2.TabIndex = 1;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // possBindingSource
            // 
            this.possBindingSource.DataMember = "poss";
            this.possBindingSource.DataSource = this.masterDataSet;
            // 
            // possTableAdapter
            // 
            this.possTableAdapter.ClearBeforeFill = true;
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "nomer";
            this.nomerDataGridViewTextBoxColumn.HeaderText = "nomer";
            this.nomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
            this.nomerDataGridViewTextBoxColumn.Visible = false;
            this.nomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Ф.И.О";
            this.fioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.Width = 125;
            // 
            // datarogdenDataGridViewTextBoxColumn
            // 
            this.datarogdenDataGridViewTextBoxColumn.DataPropertyName = "data_rogden";
            this.datarogdenDataGridViewTextBoxColumn.HeaderText = "data_rogden";
            this.datarogdenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datarogdenDataGridViewTextBoxColumn.Name = "datarogdenDataGridViewTextBoxColumn";
            this.datarogdenDataGridViewTextBoxColumn.Width = 125;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "pol";
            this.polDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.Width = 125;
            // 
            // sempologkDataGridViewTextBoxColumn
            // 
            this.sempologkDataGridViewTextBoxColumn.DataPropertyName = "sem_polog_k";
            this.sempologkDataGridViewTextBoxColumn.HeaderText = "sem_polog_k";
            this.sempologkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sempologkDataGridViewTextBoxColumn.Name = "sempologkDataGridViewTextBoxColumn";
            this.sempologkDataGridViewTextBoxColumn.Width = 125;
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "spec";
            this.specDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            this.specDataGridViewTextBoxColumn.Width = 125;
            // 
            // katobuchkDataGridViewTextBoxColumn
            // 
            this.katobuchkDataGridViewTextBoxColumn.DataPropertyName = "Категория обучения";
            this.katobuchkDataGridViewTextBoxColumn.HeaderText = "Категория обучения";
            this.katobuchkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.katobuchkDataGridViewTextBoxColumn.Name = "katobuchkDataGridViewTextBoxColumn";
            this.katobuchkDataGridViewTextBoxColumn.Width = 125;
            // 
            // vuzkDataGridViewTextBoxColumn
            // 
            this.vuzkDataGridViewTextBoxColumn.DataPropertyName = "vuz_k";
            this.vuzkDataGridViewTextBoxColumn.HeaderText = "ВУЗ";
            this.vuzkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vuzkDataGridViewTextBoxColumn.Name = "vuzkDataGridViewTextBoxColumn";
            this.vuzkDataGridViewTextBoxColumn.Width = 125;
            // 
            // mpDataGridViewTextBoxColumn
            // 
            this.mpDataGridViewTextBoxColumn.DataPropertyName = "mp";
            this.mpDataGridViewTextBoxColumn.HeaderText = "mp";
            this.mpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mpDataGridViewTextBoxColumn.Name = "mpDataGridViewTextBoxColumn";
            this.mpDataGridViewTextBoxColumn.Width = 125;
            // 
            // gpDataGridViewTextBoxColumn
            // 
            this.gpDataGridViewTextBoxColumn.DataPropertyName = "gp";
            this.gpDataGridViewTextBoxColumn.HeaderText = "gp";
            this.gpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gpDataGridViewTextBoxColumn.Name = "gpDataGridViewTextBoxColumn";
            this.gpDataGridViewTextBoxColumn.Width = 125;
            // 
            // moDataGridViewTextBoxColumn
            // 
            this.moDataGridViewTextBoxColumn.DataPropertyName = "mo";
            this.moDataGridViewTextBoxColumn.HeaderText = "mo";
            this.moDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moDataGridViewTextBoxColumn.Name = "moDataGridViewTextBoxColumn";
            this.moDataGridViewTextBoxColumn.Width = 125;
            // 
            // gokDataGridViewTextBoxColumn
            // 
            this.gokDataGridViewTextBoxColumn.DataPropertyName = "gok";
            this.gokDataGridViewTextBoxColumn.HeaderText = "gok";
            this.gokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gokDataGridViewTextBoxColumn.Name = "gokDataGridViewTextBoxColumn";
            this.gokDataGridViewTextBoxColumn.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 540);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 22);
            this.textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(262, 539);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 20);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(504, 539);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(225, 20);
            this.listBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Форма 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 592);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Форма 3";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource possBindingSource;
        private masterDataSetTableAdapters.possTableAdapter possTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarogdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sempologkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katobuchkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuzkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gokDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

