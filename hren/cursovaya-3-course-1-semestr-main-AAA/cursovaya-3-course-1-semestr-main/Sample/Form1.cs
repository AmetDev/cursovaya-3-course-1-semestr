using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
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
            label2.Text = "";
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

       

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (dataGridView4.Visible == true)
            {
                controller.DeleteAll(codeColumn, TableNameGlobal, int.Parse(dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[0].Value.ToString()));
                dataGridView4.DataSource = controller.UpdateInspector();
            }
            if (dataGridView3.Visible == true)
            {
                controller.DeleteAll(codeColumn, TableNameGlobal, int.Parse(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[0].Value.ToString()));
                dataGridView3.DataSource = controller.UpdateFacts();
            }
            if (dataGridView2.Visible == true)
            {
                controller.DeleteAll(codeColumn, TableNameGlobal, int.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString()));
                dataGridView2.DataSource = controller.UpdatePerson();
            }
            if (dataGridView1.Visible == true)
            {
                controller.DeleteAll(codeColumn, TableNameGlobal, int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
                dataGridView1.DataSource = controller.UpdateCars();
            }
            if (dataGridView5.Visible == true)
            {
                controller.DeleteAll(codeColumn, TableNameGlobal, int.Parse(dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[0].Value.ToString()));
                dataGridView5.DataSource = controller.UpdateVidNarush();
            }




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
        int GlobalCounterForDate = 0;
        int counterTextBox = 0;
        //this is needed for later use
        private int selectedComboBoxIndex = -1;
        List<ComboBox> comboBoxes = new List<ComboBox>();
        bool isClickBtnDate = false;
        MonthCalendar dynamicMonthCalendar = new MonthCalendar();
        Button btnDate = new Button();
      
        List<Button> btns = new List<Button>();
        List<ComboBox> comboFacts = new List<ComboBox>();
        string codeColumn = "";
        int checkavto = 0;
        bool[] arr = new bool[5] { false, false, false, false, false };


        int avtocode = 0;
        int inspectorcode = 0;
        int code_owner = 0;
        int vidnarish = 0;
        string datanarish = "";
        string fio_pilot = "";
        bool right_controll = false;

        int code_car_vlad_update = 0;
        string update_model = "";
        string gos_nubmer_update = "";
        string date_update = "";

        private void DynamicMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // MessageBox.Show("INDEX"+ IndexDate);
            
            int IndexDate1 = IndexDate - checkavto;
            textBoxLabel[IndexDate1].Text = e.Start.ToShortDateString().ToString();
            datanarish = e.Start.ToShortDateString().ToString();
            //MessageBox.Show($"Selected Date: {e.Start.ToShortDateString()}");
            this.Controls.Remove(dynamicMonthCalendar);
           
        }
        void textBox_Enter(object sender, EventArgs e)
        {

            // Get the TextBox that received focus
            Button btn = sender as Button;
           // MessageBox.Show(btn.Name + " Clicked"); // Display TextBox details

            this.Controls.Add(dynamicMonthCalendar);

            dynamicMonthCalendar.DateSelected += new DateRangeEventHandler(this.DynamicMonthCalendar_DateSelected);



        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null && comboBox.SelectedItem != null)
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

                    selectedComboBoxIndex = comboBox.SelectedIndex;

                    // Сброс индекса, чтобы снова вызывать SelectedIndexChanged при следующем выборе
                    
                }
            }
        }





        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            dataGridView1.DataSource = автомобилиBindingSource;
            comboBox1.Items.Clear();
            comboBox1.Text = "";



            comboBox1.Items.Clear();
            comboBox1.Text = "";
            IndexDate = 0;
            checkavto = 0;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            arrBoolStateManager[2] = true;
            foreach (var item in comboFacts)
            {
                this.Controls.Remove(item);
            }
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
            for (int i = 0; i < btns.Count; i++)
            {
                this.Controls.Remove(btns[i]);
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
            codeColumn = "код_автомобиля";
            label2.Text = "автомобили, поиск по гос. номеру:";
            foreach(DataRow row in dataTable.Rows) {
               
                string gos_number = $"{row["гос_номер"]}";

                comboBox1.Items.Add(gos_number);
            }
       

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                int counterTextBox = 0;
                GlobalCounterForDate = i;
                k += 45;
                Label myLabel = new Label();
                TextBox newTextBox = new TextBox();

                myLabel.Tag = "DynamicallyGenerated";
                newTextBox.Tag = "textbox";

              
                if (i == 0) continue;

                Type textBoxType = typeof(TextBox);
                DataColumn column = dataTable.Columns[i];
                Type columnType = column.DataType;

               
                if (i == 1)
                {
                    IndexCodeOwner = i;
                    //this is needed for later use
                    ComboBox comboBox = new ComboBox();

                    comboBox.Items.Clear(); // Очистка предыдущих элементов
                   
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
                    IndexDate = 3;

                    dynamicMonthCalendar.Location = new System.Drawing.Point(750, -50 + k);
                    dynamicMonthCalendar.Size = new System.Drawing.Size(200, 180);
                    btnDate.Name = "date";
                    btnDate.Text = "выберите дату";
                    btnDate.Tag = "DynamicallyGenerated";
                    btnDate.Size = new System.Drawing.Size(100, 25);
                    btnDate.Location = new System.Drawing.Point(698, -52 + k);
                    btnDate.Click += new EventHandler(this.textBox_Enter);
                    this.Controls.Add(btnDate);
                }
                // Добавляем все кнопки в Controls только после того, как им добавлен обработчик
                foreach (var item in btns)
                {
                    this.Controls.Add(item);
                }

                // Если столбец не соответствует условиям, добавляем Label и TextBox

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
                if (i == 1)
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

                    string FirstName = argsLablesString[0];
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
                    selectedComboBoxIndex = -1;
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
                case "факты_нарушения":
                    MessageBox.Show("" + avtocode + ";" + code_owner + ";" + inspectorcode + ";" + vidnarish + ";" + datanarish + ";" + fio_pilot + ";" + right_controll);
                    controller.AddFactsInDB(avtocode, inspectorcode, code_owner, vidnarish, datanarish, fio_pilot, right_controll);
                    dataGridView3.DataSource = controller.UpdateFacts();
                    break;

            }
        }
        private void владельцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            dataGridView2.DataSource = владельцыBindingSource;
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            foreach (var item in comboFacts)
            {
                this.Controls.Remove(item);
            }
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
            for (int i = 0; i < btns.Count; i++) {
                this.Controls.Remove(btns[i]);
            }
            this.Controls.Remove(btnDate);
            textBoxLabel.Clear();
            labelsString.Clear();
            this.Controls.Remove(dynamicMonthCalendar);



            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From владельцы", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            int k = 0;
            TableNameGlobal = "владельцы";
            codeColumn = "код_владельца";
            label2.Text = "владельцы:Поиск по категории прав:";
            foreach (DataRow row in dataTable.Rows)
            {

                string gos_number = $"{row["Категория_прав"]}";
                comboBox1.Items.Add(gos_number);
            }
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
        private void ToClickBtn(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Извлекаем значение column.ColumnName из свойства Tag
            string columnName = clickedButton.Tag as string;
            MessageBox.Show(columnName + "");

            switch (columnName)
            {
                case "код_автомобиля":
                    MessageBox.Show("Clicked column: " + columnName);
                    break;
                case "код_владельца":
                    MessageBox.Show("Clicked column: " + columnName);
                    break;
                case "код_инспектора":
                    MessageBox.Show("Clicked column: " + columnName);
                    break;
                case "код_вида_нарушения":
                    MessageBox.Show("Clicked column: " + columnName);
                    break;

            }
        }

        private void EditAvto(int ID)
        {
            

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"Select * From автомобили WHERE код_автомобиля={ID}", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Проверка наличия данных
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                // Извлеките данные из строки и передайте их в новую форму
                string ownerCode = $"{row["код_владельца"]}";
                string model = $"{row["модель"]}";
                string licensePlate = $"{row["гос_номер"]}";
                string productionDate = $"{row["дата_производства"]}";

                // Создайте и покажите новую форму для редактирования
                EditForm editForm = new EditForm(ownerCode, model, licensePlate, productionDate);
                editForm.ShowDialog();
            }



        }
        private void EditVid(int ID)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"Select * From виды_нарушения WHERE код_вида_нарушения={ID}", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Проверка наличия данных
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                // Извлеките данные из строки и передайт их в новую форму
                int ownerCode = Convert.ToInt32(row["код_вида_нарушения"]);
                string model = $"{row["наименование_вида_нарушения"]}";
                int licensePlate = Convert.ToInt32(row["размер штрафа"]);
                EditVid EditVid = new EditVid(ownerCode, model, licensePlate);
                EditVid.ShowDialog();
            }



        }
        private void EditInspector(int ID)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"Select * From Инспектор WHERE код_инспектора={ID}", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Проверка наличия данных
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                // Извлеките данные из строки и передайт их в новую форму
                int ownerCode = Convert.ToInt32(row["код_инспектора"]);
                string name = $"{row["фио_инспектора"]}";
                EditInspector EditInspector = new EditInspector(ownerCode, name);
                EditInspector.ShowDialog();
            }



        }
        private void EditVladelez(int ID)
        {

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"Select * From владельцы WHERE код_владельца={ID}", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Проверка наличия данных
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                // Извлеките данные из строки и передайте их в новую форму
                int codezero = Convert.ToInt32(row["код_владельца"]);
                string ownerCode = $"{row["Имя"]}";
                string model = $"{row["Фамилия"]}";
                string licensePlate = $"{row["Отчество"]}";
                string productionDate = $"{row["Категория_прав"]}";

                // Создайте и покажите новую форму для редактирования
                EditFormVladelez EditFormVladelez = new EditFormVladelez(codezero, ownerCode, model, licensePlate, productionDate);
                EditFormVladelez.ShowDialog();
            }

        }
        private void EditFacts(int ID)
        {
            MessageBox.Show($"ID{ID}");
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"Select * From факты_нарушения WHERE код_нарушения={ID}", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Проверка наличия данных
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                // Извлеките данные из строки и передайте их в новую форму
                int codezero = Convert.ToInt32(row["код_нарушения"]);
                int code_avto = Convert.ToInt32(row["код_автомобиля"]);
                int insp = Convert.ToInt32(row["код_инспектора"]);
                int vlad = Convert.ToInt32(row["код_владельца"]);
                int vid = Convert.ToInt32(row["код_вида_нарушения"]);
                string data_narush = $"{row["дата_нарушения"]}";
                string fio_voditel = $"{row["фио_водителя"]}";

                // Создайте и покажите новую форму для редактирования
                EditFacts EditFacts = new EditFacts(codezero, code_avto, insp, vlad, vid, data_narush, fio_voditel);
                EditFacts.ShowDialog();
            }
        }

        private void фактыНарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView3.DataSource = фактынарушенияBindingSource;
            button7.Visible = false;
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            IndexDate = 0;
            checkavto = 0;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            arrBoolStateManager[2] = true;
            foreach (var item in comboFacts)
            {
                this.Controls.Remove(item);
            }
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
            for (int i = 0; i < btns.Count; i++)
            {
                this.Controls.Remove(btns[i]);
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
            codeColumn = "код_нарушения";
            label2.Text = "факт_нарушения:Поиск по фио_водителя:";
            foreach (DataRow row in dataTable.Rows)
            {
          
                string gos_number = $"{row["фио_водителя"]}";
                comboBox1.Items.Add(gos_number);
            }
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                GlobalCounterForDate = i;

                k += 45;
                DataColumn column = dataTable.Columns[i];
                Type columnType = column.DataType;
                int counterTextBox = 0;
                if (i == 0) continue; // Пропускаем первый столбец

                if (column.ColumnName == "код_владельца")
                {
                    OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter("Select * From владельцы", con);
                    DataTable dataTable1 = new DataTable();
                    dataAdapter1.Fill(dataTable1);
                    ComboBox comboBox = new ComboBox();

                    comboBox.Text = column.ColumnName;
                    comboBox.Location = new Point(600, 0 + k);
                    comboBox.Tag = "tag" + column.ColumnName;
                    comboBox.Name = "name" + column.ColumnName;

                    foreach (DataRow row in dataTable1.Rows)
                    {
                        string fullName = $"{row["Фамилия"]}";
                        string Name = $"{row["Имя"]}";
                        string FatherName = $"{row["Отчество"]}";
                        comboBox.Items.Add(fullName + " " + Name + " " + FatherName);
                    }
                    comboFacts.Add(comboBox);
                    foreach (var item in comboFacts)
                    {
                        if(item==comboBox)
                        {
                            this.Controls.Add(item);
                        }
                    }
                  
                    continue;

                }
                if (column.ColumnName == "код_инспектора")
                {
                    List<int> list = new List<int>();
                    OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter("Select * From Инспектор", con);
                    DataTable dataTable1 = new DataTable();
                    dataAdapter1.Fill(dataTable1);
                    ComboBox comboBox = new ComboBox();

                    comboBox.Text = column.ColumnName;
                    comboBox.Location = new Point(600, 0 + k);
                    comboBox.Tag = "tag" + column.ColumnName;
                    comboBox.Name = "name" + column.ColumnName;
                    //inspectorcode

                    foreach (DataRow row in dataTable1.Rows)
                    {
                        string fullName = $"{row["фио_инспектора"]}";
                        int ID = Convert.ToInt32(row["код_инспектора"]);
                        comboBox.Items.Add(fullName);
                        list.Add(ID);
                    }
                    this.Controls.Add(comboBox);
                    comboBox.SelectedIndexChanged += (selectedSender, selectedEvent) =>
                    {
                        if (comboBox.SelectedIndex != -1)
                        {
                            int selectedIndex = comboBox.SelectedIndex;
                            MessageBox.Show($"Выбрано с кодом {list[selectedIndex]} ");

                            inspectorcode = list[selectedIndex];



                        }
                    };
                    comboFacts.Add(comboBox);
                    foreach (var item in comboFacts)
                    {
                        if (item == comboBox)
                        {
                            this.Controls.Add(item);
                        }
                    }
                    continue;

                }
                if (column.ColumnName == "код_вида_нарушения")
                {
                    List<int> list = new List<int>();
                    OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter("Select * From виды_нарушения", con);
                    DataTable dataTable1 = new DataTable();
                    dataAdapter1.Fill(dataTable1);
                    ComboBox comboBox = new ComboBox();

                    comboBox.Text = column.ColumnName;
                    comboBox.Location = new Point(600, 0 + k);
                    comboBox.Tag = "tag" + column.ColumnName;
                    comboBox.Name = "name" + column.ColumnName;


                    foreach (DataRow row in dataTable1.Rows)
                    {
                        string fullName = $"{row["наименование_вида_нарушения"]}";
                        int ID = Convert.ToInt32(row["код_вида_нарушения"]);
                        comboBox.Items.Add(fullName);
                        list.Add(ID);
                    }
                    this.Controls.Add(comboBox);
                    comboBox.SelectedIndexChanged += (selectedSender, selectedEvent) =>
                    {
                        if (comboBox.SelectedIndex != -1)
                        {
                            int selectedIndex = comboBox.SelectedIndex;
                            MessageBox.Show($"Выбрано с кодом {list[selectedIndex]} ");

                            vidnarish = list[selectedIndex];
                        }
                    };
                    comboFacts.Add(comboBox);
                    foreach (var item in comboFacts)
                    {
                        if (item == comboBox)
                        {
                            this.Controls.Add(item);
                        }
                    }
                    continue;

                }
                if (column.ColumnName == "фио_водителя")
                {
                    List<string> list = new List<string>();
                    OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter("Select * From владельцы", con);
                    DataTable dataTable1 = new DataTable();
                    dataAdapter1.Fill(dataTable1);
                    ComboBox comboBox = new ComboBox();

                    comboBox.Text = column.ColumnName;
                    comboBox.Location = new Point(600, 0 + k);
                    comboBox.Tag = "tag" + column.ColumnName;
                    comboBox.Name = "name" + column.ColumnName;

                    foreach (DataRow row in dataTable1.Rows)
                    {
                        string fullName = $"{row["Фамилия"]}";
                        string Name = $"{row["Имя"]}";
                        string FatherName = $"{row["Отчество"]}";
                        comboBox.Items.Add(fullName + " " + Name + " " + FatherName);
                        list.Add(fullName + " " + Name + " " + FatherName);
                    }
                    this.Controls.Add(comboBox);
                    comboBox.SelectedIndexChanged += (selectedSender, selectedEvent) =>
                    {
                        if (comboBox.SelectedIndex != -1)
                        {
                            int selectedIndex = comboBox.SelectedIndex;
                            MessageBox.Show($"Выбрано {list[selectedIndex]} ");

                            fio_pilot = list[selectedIndex];



                        }
                    };
                    comboFacts.Add(comboBox);
                    foreach (var item in comboFacts)
                    {
                        if (item == comboBox)
                        {
                            this.Controls.Add(item);
                        }
                    }
                    continue;

                }
                if (column.ColumnName == "право управления")
                {
                    List<string> list = new List<string>();
                    string[] boolean = new string[2] { "Есть", "Отсутствует" };
                    bool localbool = false;
                    ComboBox comboBox = new ComboBox();
                    comboBox.Text = column.ColumnName;
                    comboBox.Location = new Point(600, 0 + k);
                    comboBox.Tag = "tag" + column.ColumnName;
                    comboBox.Name = "name" + column.ColumnName;
                    // Добавляем значения true/false
                    comboBox.Items.Add("Есть");
                    comboBox.Items.Add("Отсутствует");
                    foreach (var item in boolean)
                    {
                        list.Add(item);
                    }

                    this.Controls.Add(comboBox);
                    comboBox.SelectedIndexChanged += (selectedSender, selectedEvent) =>
                    {
                        if (comboBox.SelectedIndex != -1)
                        {
                            int selectedIndex = comboBox.SelectedIndex;
                            MessageBox.Show($"Выбрано {list[selectedIndex]} ");
                            if (list[selectedIndex] == "Есть")
                            {
                                localbool = true;
                            }
                            else
                            {
                                localbool = false;
                            }
                            right_controll = localbool;



                        }
                    };
                    comboFacts.Add(comboBox);
                    foreach (var item in comboFacts)
                    {
                        if (item == comboBox)
                        {
                            this.Controls.Add(item);
                        }
                    }
                    continue;
                }

                if (column.ColumnName == "код_автомобиля")
                {
                    OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter("SELECT * FROM автомобили", con);
                    DataTable dataTable1 = new DataTable();
                    dataAdapter1.Fill(dataTable1);

                    OleDbDataAdapter dataAdapter2 = new OleDbDataAdapter("SELECT * FROM владельцы", con);
                    DataTable dataTable2 = new DataTable();
                    dataAdapter2.Fill(dataTable2);


                    List<string> carCodes = new List<string>();
                    List<string> ownerCodes = new List<string>();
                    ComboBox comboBox = new ComboBox();
                    comboBox.Items.Clear(); // Очистка предыдущих элементов
                    carCodes.Clear(); // Очистка предыдущих кодов автомобилей
                    ownerCodes.Clear(); // Очистка предыдущих кодов владельцев
                    comboBox.Text = column.ColumnName;
                    comboBox.Location = new Point(600, 0 + k);
                    comboBox.Width = 200;
                    comboBox.Height = 50;
                    comboBox.Tag = "tag" + column.ColumnName;
                    comboBox.Name = "name" + column.ColumnName;
                    


                    foreach (DataRow row1 in dataTable1.Rows)
                    {
                        foreach (DataRow row2 in dataTable2.Rows)
                        {
                            if (row1["код_владельца"].ToString() == row2["код_владельца"].ToString())
                            {
                                string model = $"{row1["модель"]}";
                                string fullName = $"{row2["Фамилия"]} {row2["Имя"]} {row2["Отчество"]}";
                                string ownerCode = $"{row2["код_владельца"]}";
                                string carCode = $"{row1["код_автомобиля"]}";

                                comboBox.Items.Add($"модель: {model}, владелец: {fullName}");

                                // Добавляем коды в списки
                                carCodes.Add(carCode);
                                ownerCodes.Add(ownerCode);
                            }
                        }
                    }

                    // Добавляем обработчик события SelectedIndexChanged после цикла
                    comboBox.SelectedIndexChanged += (selectedSender, selectedEvent) =>
                    {
                        if (comboBox.SelectedIndex != -1)
                        {
                            int selectedIndex = comboBox.SelectedIndex;
                            MessageBox.Show($"Выбран автомобиль с кодом {carCodes[selectedIndex]} и владельцем с кодом {ownerCodes[selectedIndex]}");
                            avtocode = Convert.ToInt32(carCodes[selectedIndex]);
                            code_owner = Convert.ToInt32(ownerCodes[selectedIndex]);


                        }
                    };
                    comboFacts.Add(comboBox);
                    foreach (var item in comboFacts)
                    {
                        if(item==comboBox)
                        {
                            this.Controls.Add(item);
                        }
                    }
                    continue;

              
                }

                
                TextBox newTextBox = new TextBox();
                newTextBox.Name = "textBox " + column.ColumnName;
                newTextBox.Location = new Point(600, 10 + k);
                if ("textbox" == newTextBox.Tag)
                {
                    counterTextBox += 1;
                    // Your code here
                }
                if (columnType == typeof(DateTime))
                {
                    IndexDate = counterTextBox;

                    dynamicMonthCalendar.Location = new System.Drawing.Point(750, 60 + k);
                    dynamicMonthCalendar.Size = new System.Drawing.Size(200, 180);
                    btnDate.Name = "date";
                    btnDate.Text = "выберите дату";
                    btnDate.Tag = "DynamicallyGenerated";
                    btnDate.Size = new System.Drawing.Size(100, 25);
                    btnDate.Location = new System.Drawing.Point(695, 10 + k);
                    btnDate.Click += new EventHandler(this.textBox_Enter);
                    this.Controls.Add(btnDate);
                }
                // Добавляем все кнопки в Controls только после того, как им добавлен обработчик
                foreach (var item in btns)
                {
                    this.Controls.Add(item);
                }

                // Если столбец не соответствует условиям, добавляем Label и TextBox

                Label myLabel = new Label();
                myLabel.Parent = this.Parent;
                myLabel.Text = column.ColumnName;
                myLabel.Location = new Point(600, -3 + k);
                myLabel.Name = "lbl" + column.ColumnName;
                myLabel.AutoSize = true;

                this.Controls.Add(myLabel);
                this.Controls.Add(newTextBox);

                labels.Add(myLabel);
                textBoxLabel.Add(newTextBox);
            }
        }

        private void видыНарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            dataGridView5.DataSource = видынарушенияBindingSource;
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            foreach (var item in comboFacts)
            {
                this.Controls.Remove(item);
            }
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
            for (int i = 0; i < btns.Count; i++)
            {
                this.Controls.Remove(btns[i]);
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
            codeColumn = "код_вида_нарушения";
            label2.Text = "вид нарушения, поиск по наименованию:";
            foreach (DataRow row in dataTable.Rows)
            {

                string gos_number = $"{row["наименование_вида_нарушения"]}";

                comboBox1.Items.Add(gos_number);
            }
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
              button7.Visible = true;
            dataGridView4.DataSource = инспекторBindingSource;
            comboBox1.Items.Clear();
            comboBox1.Text = "";

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;
            arrBoolStateManager[3] = true;
            foreach (var item in comboFacts)
            {
                this.Controls.Remove(item);
            }
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
            for (int i = 0; i < btns.Count; i++)
            {
                this.Controls.Remove(btns[i]);
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
            codeColumn = "код_инспектора";
            label2.Text = "Инспектор, поиск по ФИО:";
            foreach (DataRow row in dataTable.Rows)
            {

                string gos_number = $"{row["фио_инспектора"]}";

                comboBox1.Items.Add(gos_number);
            }
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
            dataGridView4.DataSource = controller.UpdateInspector();
            dataGridView3.DataSource = controller.UpdateFacts();
            dataGridView2.DataSource = controller.UpdatePerson();
            dataGridView1.DataSource = controller.UpdateCars();
            dataGridView5.DataSource = controller.UpdateVidNarush();

            AddInDB(labelsString);
            if (dataGridView4.Visible == true)
            {
                arr[3] = true;
                // controller.DeleteAll(codeColumn, TableNameGlobal, int.Parse(dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[0].Value.ToString()));
               
                dataGridView4.DataSource = controller.UpdateInspector();

            }
            if (dataGridView3.Visible == true)
            {
               
                dataGridView3.DataSource = controller.UpdateFacts();
            }
            if (dataGridView2.Visible == true)
            {
                //controller.DeleteAll(codeColumn, TableNameGlobal, int.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString()));
               
                dataGridView2.DataSource = controller.UpdatePerson();
                //EditOwner
            }
            if (dataGridView1.Visible == true)
            {
                arr[0] = true;
               
               
                dataGridView1.DataSource = controller.UpdateCars();
            }
            if (dataGridView5.Visible == true)
            {
              
                dataGridView5.DataSource = controller.UpdateVidNarush();
            }
            labelsString.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (dataGridView4.Visible == true)
            {
                arr[3] = true;
               
                // controller.DeleteAll(codeColumn, TableNameGlobal, int.Parse(dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[0].Value.ToString()));
                EditInspector(int.Parse(dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[0].Value.ToString()));
                dataGridView4.DataSource = controller.UpdateInspector();

            }
            if (dataGridView3.Visible == true)
            {

                //EditFacts(int.Parse(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[0].Value.ToString()));
             
                dataGridView3.DataSource = controller.UpdateFacts();
              
            }
            if (dataGridView2.Visible == true)
            {
               
                //controller.DeleteAll(codeColumn, TableNameGlobal, int.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString()));
                EditVladelez(int.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString()));
                dataGridView2.DataSource = controller.UpdatePerson();
                //EditOwner
            }
            if (dataGridView1.Visible == true)
            {
                arr[0] = true;
                /* controller.DeleteAll(codeColumn, TableNameGlobal, int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
                 dataGridView1.DataSource = controller.UpdateCars();*/
              
                EditAvto(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
                dataGridView1.DataSource = controller.UpdateCars();
            }
            if (dataGridView5.Visible == true)
            {
              
                EditVid(int.Parse(dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[0].Value.ToString()));
                dataGridView5.DataSource = controller.UpdateVidNarush();
            }

        }
        private DataGridView activeDataGridView;


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private DataGridView GetActiveDataGridView()
        {
            // Определите активный DataGridView в зависимости от текущего контекста приложения
            // Например, используя видимость компонентов

            if (dataGridView1.Visible)
            {
                return dataGridView1;
            }
            else if (dataGridView2.Visible)
            {
                return dataGridView2;
            }
            else if (dataGridView3.Visible)
            {
                return dataGridView3;
            }
            else if (dataGridView4.Visible)
            {
                return dataGridView4;
            }
            else if (dataGridView5.Visible)
            {
                return dataGridView5;
            }

            return null; // Если активный DataGridView не определен
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Получаем выбранное значение из ComboBox
            string selectedValue = comboBox1.SelectedItem.ToString();
            // Определите активный DataGridView
            activeDataGridView = GetActiveDataGridView();

            // Выводим значение в MessageBox
            MessageBox.Show("Выбранное значение: " + selectedValue, "Информация");

            if (dataGridView1.Visible == true)
            {
                ApplyFilter(dataGridView1, "гос_номер", selectedValue);
            }

            if (dataGridView3.Visible == true)
            {
                ApplyFilter(dataGridView3, "фио_водителя", selectedValue);
            }

            if (dataGridView2.Visible == true)
            {
                ApplyFilter(dataGridView2, "Категория_прав", selectedValue);
            }

            if (dataGridView4.Visible == true)
            {
                ApplyFilter(dataGridView4, "фио_инспектора", selectedValue);
            }

            if (dataGridView5.Visible == true)
            {
                ApplyFilter(dataGridView5, "наименование_вида_нарушения", selectedValue);
            }
        }

        private void ApplyFilter(DataGridView dataGridView, string columnName, string filterValue)
        {
            // Проверяем, что DataSource - BindingSource
            if (dataGridView.DataSource is BindingSource bs)
            {
                // Получаем DataView из BindingSource
                DataView dv = (DataView)bs.List;

                // Применяем фильтр к DataView
                dv.RowFilter = $"{columnName} = '{filterValue}'";
            }
            else if (dataGridView.DataSource is DataTable dt)
            {
                // Если DataSource - DataTable, то фильтруем его напрямую
                dt.DefaultView.RowFilter = $"{columnName} = '{filterValue}'";
            }
            else
            {
                // Обработка других типов DataSource, если необходимо
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            activeDataGridView = GetActiveDataGridView();
            ResetFilter(activeDataGridView);
        }

        private void ResetFilter(DataGridView dataGridView)
        {
            // Очистить фильтр для указанного DataGridView
            // Проверяем, что DataSource - BindingSource
            if (dataGridView.DataSource is BindingSource bs)
            {
                // Получаем DataView из BindingSource
                DataView dv = (DataView)bs.List;

                // Очищаем фильтр у DataView
                dv.RowFilter = string.Empty;
            }
            else if (dataGridView.DataSource is DataTable dt)
            {
                // Если DataSource - DataTable, то сбрасываем фильтр напрямую
                dt.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                // Обработка других типов DataSource, если необходимо
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AboutBox1 ss = new AboutBox1();
            ss.Show();
        }
    }
}
