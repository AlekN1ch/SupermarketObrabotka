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
    public partial class Form4 : Form
    {
        public static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SuperMarket.accdb";
        public OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connection);
            myConnection.Open();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "superMarketDataSet.BookDelivery". При необходимости она может быть перемещена или удалена.
            this.bookDeliveryTableAdapter.Fill(this.superMarketDataSet.BookDelivery);
            foreach (var item in Form2.list.Items)
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in listBox1.Items)
            {
                string query = "INSERT INTO  BookDelivery ([ProductName])VALUES " + "('" + item.ToString() + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader reader = command.ExecuteReader();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choise = comboBox1.Text;
            if (choise == "Страница заказа")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Close();
            }
           else if (choise == "База данных товаров")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bookDeliveryTableAdapter.Fill(this.superMarketDataSet.BookDelivery);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
