using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketObrabotka
{
    public partial class Form2 : Form
    {
        public static int changes=0;
        public static string place = "Страница заказов";
       public static ListBox list=new ListBox();
        public bool onBasa = false;
       
        public Form2()
        {
            InitializeComponent();
        }
        public void Change(Button button)
        {
            bool change;
            button.UseWaitCursor = !button.UseWaitCursor;
            change = button.UseWaitCursor;
            if (change)
            {
                button.BackColor = Color.Green;
                changes++;
                listBox1.Items.Add(button.Tag.ToString());
                label1.Text = button.Tag.ToString();
            }
            else
            {
                button.BackColor=SystemColors.Window;
                changes--;
                label1.Text = "";
               listBox1.Items.Remove(button.Tag.ToString());
            }
            label3.Text = changes.ToString();
           
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Change(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Change(button2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Change(button4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change(button3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Change(button6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Change(button5);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Change(button12);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Change(button11);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Change(button10);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Change(button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Change(button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Change(button7);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Change(button18);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Change(button17);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Change(button16);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Change(button15);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Change(button14);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Change(button13);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Change(button30);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Change(button29);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Change(button28);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Change(button27);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Change(button26);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Change(button25);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choise = comboBox1.Text;
            if (choise == "База данных товаров")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Close();
            }
            else if (choise == "Книга заказов")
            { 
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }    
        }

        private void button19_Click(object sender, EventArgs e)
        {
            onBasa=true;
            List<string> listG = new List<string>();
            foreach (var item in listBox1.Items)
            { 
                listG.Add(item.ToString());
            }
            foreach (var item in listG)
            {
                list.Items.Add(item.ToString());
            }
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            onBasa = true;
            List<string> listG = new List<string>();
            foreach (var item in listBox1.Items)
            {
                listG.Add(item.ToString());
            }
            foreach (var item in listG)
            {
                list.Items.Add(item.ToString());
            }
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }
    }
}
