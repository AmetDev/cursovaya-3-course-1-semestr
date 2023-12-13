using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sample.Controller;
using Label = System.Windows.Forms.Label;

namespace Sample
{
    public partial class Form1 : Form
    {
        private const bool V = false;
        Query controller;
        public string TableNameGlobal { get; set; }
        bool isAdmin = true;
        CheckAdmin Checks;
        bool[] arrBoolStateManager  = new bool[5] {false, false, false, false, false};
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
           
           // controller.Add(textBox1.Text, textBox2.Text, textBox4.Text,  int.Parse(textBox3.Text), isAdmin);
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
        List<Label> labels = new List<Label>();
        List<TextBox> textBoxLabel = new List<TextBox>();
        List<Button> buttonsList = new List<Button>();
        List<string> labelsString = new List<string>();


        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From автомобили", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            int k = 0;
            TableNameGlobal = "автомобили";

            foreach (DataColumn column in dataTable.Columns)
            {

                k += 45;
                Label myLabel = new Label();
                TextBox newTextBox = new TextBox();

                newTextBox.Name = "textBox " + column;
                newTextBox.Location = new Point(650, 170 + k);
                myLabel.Parent = this.Parent;
                myLabel.Text = column.ToString();
                myLabel.Location = new Point(650, 160 + k);
                myLabel.Name = "lbl" + column;
                myLabel.AutoSize = true; // Автоматическое изменение размера метки в соответствии с содержимым
                this.Controls.Add(myLabel);
                this.Controls.Add(newTextBox);

                textBoxLabel.Add(newTextBox);


            }
            foreach (var item in buttonsList) //обходим все элементы формы
            {
                if (item is Button) // проверяем, что это кнопка
                {
                    ((Button)item).Click += CommonBtn_Click; //приводим к типу и устанавливаем обработчик события  
                }
            }




            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            arrBoolStateManager[0] = true;
        }
     
        private void CommonBtn_Click(object sender, EventArgs e)
        {

          
            foreach (var item in textBoxLabel)
            {
                labelsString.Add(item.Text);
              
            }
            
        }

        private void AddInDB(List<string> argsLablesString)
        {
           
            switch (TableNameGlobal)
            {
                case "владельцы":
         
                    string FirstName=argsLablesString[1];
                    string LastName = argsLablesString[2];
                    string FatherName = argsLablesString[3];
                    string Category = argsLablesString[4];
                    controller.AddOwner(FirstName, LastName, FatherName, Category);
                     dataGridView2.DataSource = controller.UpdatePerson();
                    break;
                case "автомобили":
                    int code_vladelech = Convert.ToInt32(argsLablesString[1]);
                    string model = argsLablesString[2];
                    string gover_number = argsLablesString[3];
                    string data_proizvod = argsLablesString[4];
                    controller.AddCars(code_vladelech, model, gover_number, data_proizvod);
                    dataGridView1.DataSource = controller.UpdateCars();
                    break;
            }
        }
        private void владельцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");
           
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From владельцы", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            int k=0;
            TableNameGlobal = "владельцы";
         
            foreach (DataColumn column in dataTable.Columns)
            {
                
                k += 45;
                Label myLabel = new Label();
                TextBox newTextBox = new TextBox();
              
                newTextBox.Name = "textBox "+column;
                newTextBox.Location = new Point(650, 170+k);
                myLabel.Parent = this.Parent;
                myLabel.Text = column.ToString();
                myLabel.Location = new Point(650, 160+k);
                myLabel.Name = "lbl" + column;
                myLabel.AutoSize = true; // Автоматическое изменение размера метки в соответствии с содержимым
                this.Controls.Add(myLabel);
                this.Controls.Add(newTextBox);
             
                textBoxLabel.Add(newTextBox);
               

            }
                foreach (var item in buttonsList) //обходим все элементы формы
                {
                    if (item is Button) // проверяем, что это кнопка
                    {
                        ((Button)item).Click += CommonBtn_Click; //приводим к типу и устанавливаем обработчик события  
                    }
                }
            




            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
          
            arrBoolStateManager[1] = true;
        }
  
        private void фактыНарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = true;
            arrBoolStateManager[2] = true;
        }

        private void видыНарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            arrBoolStateManager[3] = true;
        }

        private void инспекторToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;
            arrBoolStateManager[4] = true;
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
            foreach (var item in textBoxLabel)
            {
                labelsString.Add(item.Text);
     
            }
            AddInDB(labelsString);
         

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }
    }
}
