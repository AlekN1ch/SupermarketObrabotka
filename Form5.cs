using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketObrabotka
{
    public partial class Form5 : Form
    {
        public static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SuperMarket.accdb";
        public OleDbConnection myConnection;
        public Form5()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connection);
            myConnection.Open();
        }
        
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "superMarketDataSet.SupermarketTable". При необходимости она может быть перемещена или удалена.
            this.supermarketTableTableAdapter.Fill(this.superMarketDataSet.SupermarketTable);
            foreach (var item in Form2.list.Items)
            { 
                listBox1.Items.Add(item);
            }
            Filler();
        }
        public void Filler()
        {
            foreach (var item in listBox1.Items)
            {
                string query = "SELECT ProductPrice FROM SupermarketTable WHERE [ProductName]='" + item.ToString() + "'";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox2.Items.Add(reader[0].ToString());

                }
                reader.Close();
                string query1 = "SELECT HaveInMarket FROM SupermarketTable WHERE [ProductName]='" + item.ToString() + "'";
                OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                OleDbDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    listBox3.Items.Add(reader1[0].ToString());
                    
                }
                reader1.Close();
                string query2 = "SELECT HaveInInventory FROM SupermarketTable WHERE [ProductName]='" + item.ToString() + "'";
                OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                OleDbDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    listBox4.Items.Add(reader2[0].ToString());

                }
                reader2.Close();
            }
        }
        
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
