
namespace InsertBigQuery
{
    partial class Main
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
            this.Result = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.Button();
            this.openCsvDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Bar = new System.Windows.Forms.TableLayoutPanel();
            this.ProjectId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.JsonPath = new System.Windows.Forms.TextBox();
            this.JsonPathOpen = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CsvPath = new System.Windows.Forms.TextBox();
            this.CsvPathOpen = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TextBox();
            this.DataSet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openJsonDialog = new System.Windows.Forms.OpenFileDialog();
            this.Bar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result.Location = new System.Drawing.Point(0, 144);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(800, 283);
            this.Result.TabIndex = 0;
            this.Result.Text = "";
            // 
            // Input
            // 
            this.Input.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Input.Location = new System.Drawing.Point(0, 427);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(800, 23);
            this.Input.TabIndex = 1;
            this.Input.Text = "Convert";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // openCsvDialog
            // 
            this.openCsvDialog.FileName = "openFileDialog1";
            this.openCsvDialog.Filter = "\"csv files (*.csv)|*.csv|All files (*.*)|*.*\"";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Bar
            // 
            this.Bar.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Bar.ColumnCount = 2;
            this.Bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.375F));
            this.Bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.625F));
            this.Bar.Controls.Add(this.ProjectId, 1, 2);
            this.Bar.Controls.Add(this.label1, 0, 2);
            this.Bar.Controls.Add(this.label3, 0, 0);
            this.Bar.Controls.Add(this.label4, 0, 1);
            this.Bar.Controls.Add(this.panel2, 1, 0);
            this.Bar.Controls.Add(this.panel3, 1, 1);
            this.Bar.Controls.Add(this.Table, 1, 4);
            this.Bar.Controls.Add(this.DataSet, 1, 3);
            this.Bar.Controls.Add(this.label5, 0, 3);
            this.Bar.Controls.Add(this.label6, 0, 4);
            this.Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Name = "Bar";
            this.Bar.RowCount = 6;
            this.Bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.Bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.Bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.Bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.Bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.Bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.Bar.Size = new System.Drawing.Size(800, 144);
            this.Bar.TabIndex = 3;
            // 
            // ProjectId
            // 
            this.ProjectId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectId.Location = new System.Drawing.Point(135, 60);
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.Size = new System.Drawing.Size(661, 20);
            this.ProjectId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Проект (ID)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "JSON файл";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "CSV файл";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.JsonPath);
            this.panel2.Controls.Add(this.JsonPathOpen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(135, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 21);
            this.panel2.TabIndex = 7;
            // 
            // JsonPath
            // 
            this.JsonPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JsonPath.Enabled = false;
            this.JsonPath.Location = new System.Drawing.Point(0, 0);
            this.JsonPath.Name = "JsonPath";
            this.JsonPath.Size = new System.Drawing.Size(627, 20);
            this.JsonPath.TabIndex = 0;
            // 
            // JsonPathOpen
            // 
            this.JsonPathOpen.Dock = System.Windows.Forms.DockStyle.Right;
            this.JsonPathOpen.Location = new System.Drawing.Point(627, 0);
            this.JsonPathOpen.Name = "JsonPathOpen";
            this.JsonPathOpen.Size = new System.Drawing.Size(34, 21);
            this.JsonPathOpen.TabIndex = 1;
            this.JsonPathOpen.Text = "...";
            this.JsonPathOpen.UseVisualStyleBackColor = true;
            this.JsonPathOpen.Click += new System.EventHandler(this.JsonPath_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CsvPath);
            this.panel3.Controls.Add(this.CsvPathOpen);
            this.panel3.Location = new System.Drawing.Point(135, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 19);
            this.panel3.TabIndex = 8;
            // 
            // CsvPath
            // 
            this.CsvPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvPath.Enabled = false;
            this.CsvPath.Location = new System.Drawing.Point(0, 0);
            this.CsvPath.Name = "CsvPath";
            this.CsvPath.Size = new System.Drawing.Size(627, 20);
            this.CsvPath.TabIndex = 0;
            // 
            // CsvPathOpen
            // 
            this.CsvPathOpen.Dock = System.Windows.Forms.DockStyle.Right;
            this.CsvPathOpen.Location = new System.Drawing.Point(627, 0);
            this.CsvPathOpen.Name = "CsvPathOpen";
            this.CsvPathOpen.Size = new System.Drawing.Size(34, 19);
            this.CsvPathOpen.TabIndex = 1;
            this.CsvPathOpen.Text = "...";
            this.CsvPathOpen.UseVisualStyleBackColor = true;
            this.CsvPathOpen.Click += new System.EventHandler(this.CsvPath_Click);
            // 
            // Table
            // 
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(135, 116);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(661, 20);
            this.Table.TabIndex = 11;
            // 
            // DataSet
            // 
            this.DataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataSet.Location = new System.Drawing.Point(135, 88);
            this.DataSet.Name = "DataSet";
            this.DataSet.Size = new System.Drawing.Size(661, 20);
            this.DataSet.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Набор данных";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Таблица";
            // 
            // openJsonDialog
            // 
            this.openJsonDialog.FileName = "openFileDialog2";
            this.openJsonDialog.Filter = "\"json files (*.json)|*.json|All files (*.*)|*.*\"";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.Input);
            this.Name = "Main";
            this.Bar.ResumeLayout(false);
            this.Bar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.OpenFileDialog openCsvDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel Bar;
        private System.Windows.Forms.OpenFileDialog openJsonDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox JsonPath;
        private System.Windows.Forms.Button JsonPathOpen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CsvPath;
        private System.Windows.Forms.Button CsvPathOpen;
        private System.Windows.Forms.TextBox DataSet;
        private System.Windows.Forms.TextBox Table;
        private System.Windows.Forms.TextBox ProjectId;
        private System.Windows.Forms.Label label1;
    }
}

