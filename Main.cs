using Google.Apis.Auth.OAuth2;
using Google.Cloud.BigQuery.V2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertBigQuery
{
    public partial class Main : Form
    {
        private List<string> _lines = new List<string>();
        private BigQuery _connect;

        public Main()
        {
            InitializeComponent();
        }

        private void JsonPath_Click(object sender, EventArgs e)
        {
            if (openJsonDialog.ShowDialog() == DialogResult.OK)
                JsonPath.Text = openJsonDialog.FileName;
        }

        private void CsvPath_Click(object sender, EventArgs e)
        {
            if (openCsvDialog.ShowDialog() == DialogResult.OK)
            {
                CsvPath.Text = openCsvDialog.FileName;
                _lines.AddRange(File.ReadAllLines(openCsvDialog.FileName, Encoding.Default));
            }
        }

        private void Input_Click(object sender, EventArgs e)
        {
            string errors = "";

            if (string.IsNullOrEmpty(JsonPath.Text))
                errors += "Не выбран json файл.\n";

            if (_lines.Count <= 0)
                errors += "Не выбран csv файл.\n";

            if (string.IsNullOrEmpty(ProjectId.Text))
                errors += "Не введен ID проекта.\n";

            if (string.IsNullOrEmpty(DataSet.Text))
                errors += "Не введено имя набора данных.\n";

            if (string.IsNullOrEmpty(Table.Text))
                errors += "Не введено имя таблицы.\n";

            if (string.IsNullOrEmpty(errors))
            {
                _connect = new BigQuery(JsonPath.Text, ProjectId.Text);
                _connect.DataSet = DataSet.Text;
                _connect.Table = Table.Text;

                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
                Bar.Enabled = false;    
                Input.Enabled = false;
            }
            else
                MessageBox.Show(errors);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int klimit = 0;
            int k = 1;
            int rowLimit = 700;
            string header = $"INSERT {DataSet.Text}.{Table.Text} ({string.Join(", ", _lines[0].Split(';'))}) VALUES ";

            string body = "";
            string sqlFile = header;

            List<string> tempValues = new List<string>();
            _lines.Remove(_lines[0]);

            foreach (string line in _lines)
            {
                if (++klimit >= rowLimit || k >= _lines.Count)
                {
                    klimit = 0;
                    body = string.Join(", ", tempValues);
                    sqlFile += body + Environment.NewLine;
                    tempValues.Clear();

                    body = body.Replace(@"\", "");

                    var resultSql = _connect.ExecuteSql(header + body, null);
                    Invoke((MethodInvoker)delegate
                    {
                        Result.Text += $"Execute all row: {k}\n";
                        Result.SelectionStart = Result.Text.Length;
                        Result.ScrollToCaret();
                    });
                }

                string[] rows = line.Split(';');

                for (int i = 0; i < rows.Length; i++)
                    rows[i] = $"'{rows[i]}'";

                tempValues.Add($"({string.Join(", ", rows)})");

                backgroundWorker1.ReportProgress(++k);
            }

            File.WriteAllText(Path.GetDirectoryName(openCsvDialog.FileName) + $"Script_{Path.GetFileNameWithoutExtension(openCsvDialog.FileName)}.txt", sqlFile, Encoding.Default);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Text = $"Обработано: {e.ProgressPercentage}";
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Bar.Enabled = true;
            Input.Enabled = true;
            MessageBox.Show("Complete!");
        }
    }
}
