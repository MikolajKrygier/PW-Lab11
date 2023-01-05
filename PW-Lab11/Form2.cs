using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW_Lab11
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
            if(Form1.form1Instance.checkBox1.Checked) 
            {
                label1.Text = label1.Text + "Miasto: " + Form1.form1Instance.dt.Rows[Form1.form1Instance.dataGridView1.CurrentCell.RowIndex][0] + "\n";
            }
            if (Form1.form1Instance.checkBox2.Checked)
            {
                label1.Text = label1.Text + "Województwo:  " + Form1.form1Instance.dt.Rows[Form1.form1Instance.dataGridView1.CurrentCell.RowIndex][1] + "\n";
            }
            if (Form1.form1Instance.checkBox3.Checked)
            {
                label1.Text = label1.Text + "Kod lotniska ICAO: " + Form1.form1Instance.dt.Rows[Form1.form1Instance.dataGridView1.CurrentCell.RowIndex][2] + "\n";
            }
            if (Form1.form1Instance.checkBox4.Checked)
            {
                label1.Text = label1.Text + "Kod lotniska IATA: " + Form1.form1Instance.dt.Rows[Form1.form1Instance.dataGridView1.CurrentCell.RowIndex][3] + "\n";
            }
            if (Form1.form1Instance.checkBox5.Checked)
            {
                label1.Text = label1.Text + "Liczba pasażerów: " + Form1.form1Instance.dt.Rows[Form1.form1Instance.dataGridView1.CurrentCell.RowIndex][5] + "\n";
            }
            if (Form1.form1Instance.checkBox6.Checked)
            {
                label1.Text = label1.Text + "Liczba pasażerów 2018 vs 2019:  " + Form1.form1Instance.dt.Rows[Form1.form1Instance.dataGridView1.CurrentCell.RowIndex][6] + "\n";
            }
        }
    }
}
