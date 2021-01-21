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
    public class BigQuery
    {
        public GoogleCredential Credential { get; set; }
        public BigQueryClient Client { get; set; }
        public string ProjectId { get; set; }
        public string DataSet { get; set; }
        public string Table { get; set; }

        public BigQuery(string credential, string projectId)
        {
            Credential = GoogleCredential.FromFile(credential);
            Client = BigQueryClient.Create(projectId, Credential);
            ProjectId = projectId;
        }

        public BigQueryResults ExecuteSql(string sql, BigQueryParameter[] parameters = null)
        {
            BigQueryResults results = Client.ExecuteQuery(sql, parameters);
            return results;
        }
    }
}
