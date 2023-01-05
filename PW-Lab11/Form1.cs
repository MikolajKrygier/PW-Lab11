using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PW_Lab11
{
    public partial class Form1 : Form
    {
        string CsvFilePath;
        char csvDelimiter = ',';
        public DataTable dt = new DataTable();
        public static Form1 form1Instance;

        public Form1()
        {
            InitializeComponent();
            form1Instance = this;
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                CsvFilePath = ofd.FileName;
                dt = CSVtoDataTable(CsvFilePath, csvDelimiter);
                int i = 0;
                foreach(DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][4]);
                    i++;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

    

        public DataTable CSVtoDataTable(string strFilePath, char csvDelimiter)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(csvDelimiter);
                
                foreach (string header in headers)
                {
                    try
                    {
                        dt.Columns.Add(header);
                        

                    }
                    catch { }
                }
                DataRow de = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    de[i] = headers[i];
                }
                dt.Rows.Add(de);
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(csvDelimiter);
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }
            return dt;
        }


    }
}