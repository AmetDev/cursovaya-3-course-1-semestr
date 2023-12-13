using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sample.Controller;

namespace Sample
{
    public partial class Form1 : Form
    {
        private const bool V = false;
        Query controller;
        bool isAdmin = true;
        CheckAdmin Checks;
        public bool Value { get; set; }

        public Form1(bool isCheck)
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            Checks = new CheckAdmin(); // создаем экземпляр класса CheckAdmin
            if (isCheck)
            {
                button5.Visible = true;
            }
            else
            {
                button5.Visible = false;
            }
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            controller.Add(textBox1.Text, textBox2.Text, textBox4.Text,  int.Parse(textBox3.Text), isAdmin);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       


        private void button5_Click(object sender, EventArgs e)
        {
          
            Form3 ss = new Form3();
            this.Hide();
            ss.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.виды_нарушения". При необходимости она может быть перемещена или удалена.
            this.виды_нарушенияTableAdapter.Fill(this.testDataSet.виды_нарушения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Инспектор". При необходимости она может быть перемещена или удалена.
            this.инспекторTableAdapter.Fill(this.testDataSet.Инспектор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.факты_нарушения". При необходимости она может быть перемещена или удалена.
            this.факты_нарушенияTableAdapter.Fill(this.testDataSet.факты_нарушения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.владельцы". При необходимости она может быть перемещена или удалена.
            this.владельцыTableAdapter.Fill(this.testDataSet.владельцы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.testDataSet.автомобили);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet3.виды_нарушения". При необходимости она может быть перемещена или удалена.
    
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

          /*  OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");
            // запрос на проверку данн
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From владельцы", con);
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
*/
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;

        }

        private void владельцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            textBox3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox4.Visible = true;
        }

        private void фактыНарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = true;
        }

        private void видыНарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void инспекторToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            controller.AddOwner(textBox1.Text, textBox2.Text, textBox4.Text);
        
          

        }
    }
}
