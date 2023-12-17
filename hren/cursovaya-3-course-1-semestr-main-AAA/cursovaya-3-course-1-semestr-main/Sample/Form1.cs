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
        bool[] arrBoolStateManager = new bool[5] { false, false, false, false, false };
        public bool Value { get; set; }
        public int IndexDate { get; set; }
        public int IndexCodeOwner { get; set; }
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
        List<int> DateIndex = new List<int>();
        //this is needed for later use
        List<ComboBox> comboBoxes = new List<ComboBox>();
        bool isClickBtnDate = false;
        MonthCalendar dynamicMonthCalendar = new MonthCalendar();
        Button btnDate = new Button();
        // НАДО БУДЕТ ВЫНЕСТИ ГЛОБАЛЬНО
        private void DynamicMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            int IndexDate1 = IndexDate - 1;
            for (int i = 0; i < textBoxLabel.Count; i++)
            {
               
                if (i == IndexDate1)
                {
                  
                    textBoxLabel[IndexDate1].Text = e.Start.ToShortDateString().ToString();
                    MessageBox.Show($"Selected Date: {e.Start.ToShortDateString()}");
                    this.Controls.Remove(dynamicMonthCalendar);
                    
                }
            }

        }
        void textBox_Enter(object sender, EventArgs e)
        {
            // Get the TextBox that received focus
            Button btn = sender as Button;
            MessageBox.Show(btn.Name + " Clicked"); // Display TextBox details

            this.Controls.Add(dynamicMonthCalendar);
            
            dynamicMonthCalendar.DateSelected += new DateRangeEventHandler(this.DynamicMonthCalendar_DateSelected);
           


        }


        private void Clciked(object sender, EventArgs e)
        {
            TextBox pressedTextBox = (TextBox)sender;
            foreach (var item in textBoxLabel)
            {
                if (item is TextBox textBox) // Check if the item is a TextBox
                {
                    textBox.Click += new EventHandler(this.textBox_Enter);
                }
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                string selectedValue = comboBox.SelectedItem.ToString();

                string[] parts = selectedValue.Split(' ');
                if (parts.Length == 3)
                {
                    string lastName = parts[0];    // Фамилия
                    string firstName = parts[1];   // Имя
                    string middleName = parts[2];  // Отчество
                   
                    var dataID = controller.GetIDOwnder(firstName, lastName, middleName);
                  
                    if (dataID.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataID.Rows)
                        {
                            MessageBox.Show(row["код_владельца"].ToString());
                            textBoxLabel[0].Tag = "DynamicallyGenerated";
                            textBoxLabel[0].Text = row["код_владельца"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }

                }
            }
        }



        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < labels.Count; i++)
            {

                this.Controls.Remove(labels[i]);

            }
            for (int i = 0; i < textBoxLabel.Count; i++)
            {

                this.Controls.Remove(textBoxLabel[i]);

            }
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                this.Controls.Remove(comboBoxes[i]);
            }
            this.Controls.Remove(btnDate);
            textBoxLabel.Clear();
            labelsString.Clear();
            this.Controls.Remove(dynamicMonthCalendar);


            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From автомобили", con);
            OleDbDataAdapter DateOwner = new OleDbDataAdapter("Select Фамилия, Имя, Отчество From владельцы", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            int k = 0;
            TableNameGlobal = "автомобили";
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                k += 45;
                Label myLabel = new Label();
                TextBox newTextBox = new TextBox();
                myLabel.Tag  = "DynamicallyGenerated";
                newTextBox.Tag = "DynamicallyGenerated";

                if (i==0) continue;  
               
                DataColumn column = dataTable.Columns[i];
                Type columnType = column.DataType;
                if (i == 1)
                {
                    IndexCodeOwner = i;
                    //this is needed for later use
                    ComboBox comboBox = new ComboBox();
                    comboBox.Name = "comboBox_" + column.ColumnName; // Assign a unique name
                    comboBox.Location = new Point(600, -50 + k);
                    comboBox.Tag = "DynamicallyGenerated";
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList; // Set the style
                    comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged; // Handle selection change event

                    // Populate ComboBox with values from владельцы table
                    DataTable ownersTable = new DataTable();
                    DateOwner.Fill(ownersTable);
                    foreach (DataRow row in ownersTable.Rows)
                    {
                        string fullName = $"{row["Фамилия"]} {row["Имя"]} {row["Отчество"]}";
                        comboBox.Items.Add(fullName);
                    }

                    this.Controls.Add(comboBox);
                    comboBoxes.Add(comboBox);
                   


                }
               
               
                if (columnType == typeof(DateTime))
                {
                    IndexDate = i;
                   
                    dynamicMonthCalendar.Location = new System.Drawing.Point(750, 60 + k);
                    dynamicMonthCalendar.Size = new System.Drawing.Size(200, 180);
                    btnDate.Name = "date";
                    btnDate.Text = "выберите дату";
                    btnDate.Tag = "DynamicallyGenerated";
                    btnDate.Size = new System.Drawing.Size(100, 25);
                    btnDate.Location = new System.Drawing.Point(700, -51 + k);
                    btnDate.Click += new EventHandler(this.textBox_Enter);
                    this.Controls.Add(btnDate);
                   

                }
                newTextBox.Name = "textBox " + column;
                newTextBox.Location = new Point(600, -50 + k);
                newTextBox.Tag = "DynamicallyGenerated"; 
                myLabel.Parent = this.Parent;
                myLabel.Tag = "DynamicallyGenerated";
                myLabel.Text = column.ToString();
                myLabel.Location = new Point(600, -63 + k);
                myLabel.Name = "lbl" + column;
                myLabel.AutoSize = true; // Автоматическое изменение размера метки в соответствии с содержимым
                this.Controls.Add(myLabel);
                this.Controls.Add(newTextBox);
                labels.Add(myLabel);
                textBoxLabel.Add(newTextBox);
                if(i==1)
                {
                    
                    this.Controls.Remove(newTextBox);
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
                item.Tag = "DynamicallyGenerated";
                labelsString.Add(item.Text);

              
            }
            
        }

        private void AddInDB(List<string> argsLablesString)
        {
           
            switch (TableNameGlobal)
            {
                case "владельцы":
         
                    string FirstName=argsLablesString[0];
                    string LastName = argsLablesString[1];
                    string FatherName = argsLablesString[2];
                    string Category = argsLablesString[3];
                    controller.AddOwner(FirstName, LastName, FatherName, Category);
                     dataGridView2.DataSource = controller.UpdatePerson();
                    break;
                case "автомобили":
                    int code_vladelech = Convert.ToInt32(argsLablesString[0]);
                    string model = argsLablesString[1];
                    string gover_number = argsLablesString[2];
                    string data_proizvod = argsLablesString[3];
                    controller.AddCars(code_vladelech, model, gover_number, data_proizvod);
                    dataGridView1.DataSource = controller.UpdateCars();
                    break;
                case "Инспектор":
                    string FML = Convert.ToString(argsLablesString[0]);
                    controller.AddFML(FML);
                    dataGridView4.DataSource = controller.UpdateInspector();
                    break;
                case "виды_нарушения":
                    string Name = Convert.ToString(argsLablesString[0]);
                    int Price = Convert.ToInt32(argsLablesString[1]);
                    controller.AddVid_Narush(Name, Price);
                    dataGridView5.DataSource = controller.UpdateVidNarush();
                    break;

            }
        }
        private void владельцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < labels.Count; i++)
            {

                this.Controls.Remove(labels[i]);

            }
            for (int i = 0; i < textBoxLabel.Count; i++)
            {

                this.Controls.Remove(textBoxLabel[i]);

            }
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                this.Controls.Remove(comboBoxes[i]);
            }
            this.Controls.Remove(btnDate);
            textBoxLabel.Clear();
            labelsString.Clear();
            this.Controls.Remove(dynamicMonthCalendar);
          


            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");
           
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From владельцы", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            int k=0;
            TableNameGlobal = "владельцы";

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (i == 0) continue;
                DataColumn column = dataTable.Columns[i];
                Type columnType = column.DataType;
                k += 45;
                Label myLabel = new Label();
                TextBox newTextBox = new TextBox();
                if (columnType == typeof(DateTime))
                {
                    // Do something specific for DateTime data type
                    //MessageBox.Show(columnType.ToString());// Set default value or any specific property
                }
                newTextBox.Name = "textBox " + column;
                newTextBox.Location = new Point(600, -5 + k);
                myLabel.Parent = this.Parent;
                myLabel.Text = column.ToString();
                myLabel.Location = new Point(600, -19 + k);
                myLabel.Name = "lbl" + column;
                myLabel.AutoSize = true; // Автоматическое изменение размера метки в соответствии с содержимым
                this.Controls.Add(myLabel);
                this.Controls.Add(newTextBox);
                labels.Add(myLabel);
                textBoxLabel.Add(newTextBox);
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
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            arrBoolStateManager[2] = true;
            for (int i = 0; i < labels.Count; i++)
            {

                this.Controls.Remove(labels[i]);

            }
            for (int i = 0; i < textBoxLabel.Count; i++)
            {

                this.Controls.Remove(textBoxLabel[i]);

            }
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                this.Controls.Remove(comboBoxes[i]);
            }
            this.Controls.Remove(btnDate);
            textBoxLabel.Clear();
            labelsString.Clear();
            this.Controls.Remove(dynamicMonthCalendar);



            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From факты_нарушения", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            int k = 0;
            TableNameGlobal = "факты_нарушения";

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (i == 0) continue;
                DataColumn column = dataTable.Columns[i];
                Type columnType = column.DataType;
                k += 45;
                Label myLabel = new Label();
                TextBox newTextBox = new TextBox();
                if (columnType == typeof(DateTime))
                {
                    // Do something specific for DateTime data type
                  //  MessageBox.Show(columnType.ToString());// Set default value or any specific property
                }

                newTextBox.Name = "textBox " + column;
                newTextBox.Location = new Point(600, 10 + k);
                myLabel.Parent = this.Parent;
                myLabel.Text = column.ToString();
                myLabel.Location = new Point(600, -3 + k);
                myLabel.Name = "lbl" + column;
                myLabel.AutoSize = true; // Автоматическое изменение размера метки в соответствии с содержимым
                this.Controls.Add(myLabel);
                this.Controls.Add(newTextBox);
                labels.Add(myLabel);
                textBoxLabel.Add(newTextBox);
            }
        }

        private void видыНарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = true;
            arrBoolStateManager[3] = true;
            for (int i = 0; i < labels.Count; i++)
            {

                this.Controls.Remove(labels[i]);

            }
            for (int i = 0; i < textBoxLabel.Count; i++)
            {

                this.Controls.Remove(textBoxLabel[i]);

            }
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                this.Controls.Remove(comboBoxes[i]);
            }
            this.Controls.Remove(btnDate);
            textBoxLabel.Clear();
            labelsString.Clear();
            this.Controls.Remove(dynamicMonthCalendar);



            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From виды_нарушения", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            int k = 0;
            TableNameGlobal = "виды_нарушения";

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (i == 0) continue;
                DataColumn column = dataTable.Columns[i];
                Type columnType = column.DataType;
                k += 45;
                Label myLabel = new Label();
                TextBox newTextBox = new TextBox();
                if (columnType == typeof(DateTime))
                {
                    // Do something specific for DateTime data type
                   // MessageBox.Show(columnType.ToString());// Set default value or any specific property
                }
                newTextBox.Name = "textBox " + column;
                newTextBox.Location = new Point(600, -5 + k);
                myLabel.Parent = this.Parent;
                myLabel.Text = column.ToString();
                myLabel.Location = new Point(600, -19 + k);
                myLabel.Name = "lbl" + column;
                myLabel.AutoSize = true; // Автоматическое изменение размера метки в соответствии с содержимым
                this.Controls.Add(myLabel);
                this.Controls.Add(newTextBox);
                labels.Add(myLabel);
                textBoxLabel.Add(newTextBox);
            }

         
            //AddVid_Narush
        }

        private void инспекторToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;
            arrBoolStateManager[3] = true;
            for (int i = 0; i < labels.Count; i++)
            {

                this.Controls.Remove(labels[i]);

            }
            for (int i = 0; i < textBoxLabel.Count; i++)
            {

                this.Controls.Remove(textBoxLabel[i]);

            }
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                this.Controls.Remove(comboBoxes[i]);
            }
            this.Controls.Remove(btnDate);
            textBoxLabel.Clear();
            labelsString.Clear();
            this.Controls.Remove(dynamicMonthCalendar);



            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From Инспектор", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            int k = 0;
            TableNameGlobal = "Инспектор";

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (i == 0) continue;
                DataColumn column = dataTable.Columns[i];
                Type columnType = column.DataType;
                k += 45;
                Label myLabel = new Label();
                TextBox newTextBox = new TextBox();
                if (columnType == typeof(DateTime))
                {
                    // Do something specific for DateTime data type
                    //MessageBox.Show(columnType.ToString());// Set default value or any specific property
                }
                newTextBox.Name = "textBox " + column;
                newTextBox.Location = new Point(600, -5 + k);
                myLabel.Parent = this.Parent;
                myLabel.Text = column.ToString();
                myLabel.Location = new Point(600, -19 + k);
                myLabel.Name = "lbl" + column;
                myLabel.AutoSize = true; // Автоматическое изменение размера метки в соответствии с содержимым
                this.Controls.Add(myLabel);
                this.Controls.Add(newTextBox);
                labels.Add(myLabel);
                textBoxLabel.Add(newTextBox);
            }
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
            labelsString.Clear();



        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }
    }
}
