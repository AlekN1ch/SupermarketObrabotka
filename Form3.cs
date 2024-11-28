using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketObrabotka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "superMarketDataSet.SupermarketTable". При необходимости она может быть перемещена или удалена.
            this.supermarketTableTableAdapter.Fill(this.superMarketDataSet.SupermarketTable);

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
            else if (choise == "Книга заказов")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.supermarketTableTableAdapter.Fill(this.superMarketDataSet.SupermarketTable);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string choise = comboBox1.Text;
            if (choise == "Страница заказа")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Close();
            }
            else if (choise == "Книга заказов")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }
        }
    }
}
