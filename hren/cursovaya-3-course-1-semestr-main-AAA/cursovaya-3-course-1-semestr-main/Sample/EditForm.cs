using Sample.Controller;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Sample
{
    public partial class EditForm : Form
    {
        Query controller;
        private TextBox textBoxOwnerCode;
        private TextBox textBoxModel;
        private TextBox textBoxLicensePlate;
        private TextBox textBoxProductionDate;
        private Button btnSave;

        // Конструктор формы
        public EditForm(string ownerCode, string model, string licensePlate, string productionDate)
        {
            // Вызываем автоматически созданный метод инициализации компонентов
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            init();
            textBoxOwnerCode = new TextBox();
            textBoxOwnerCode.Location = new Point(10, 10);
            textBoxOwnerCode.Width = 200;
            textBoxModel = new TextBox();
            textBoxModel.Location = new Point(10, 40);
            textBoxModel.Width = 200;

            textBoxLicensePlate = new TextBox();
            textBoxLicensePlate.Location = new Point(10, 70);
            textBoxLicensePlate.Width = 200;

            textBoxProductionDate = new TextBox();
            textBoxProductionDate.Location = new Point(10, 100);
            textBoxProductionDate.Width = 200;

            btnSave = new Button();
            btnSave.Text = "Сохранить";
            btnSave.Location = new Point(10, 150);
            btnSave.Click += btnSave_Click;

            // Добавление компонентов на форму
            Controls.Add(textBoxOwnerCode);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxLicensePlate);
            Controls.Add(textBoxProductionDate);
            Controls.Add(btnSave);

            // Дополнительные настройки формы
            Text = "Редактирование данных";
            Size = new Size(450, 400);

            // Теперь устанавливаем значения
            textBoxOwnerCode.Text = ownerCode;
            textBoxModel.Text = model;
            textBoxLicensePlate.Text = licensePlate;
            textBoxProductionDate.Text = productionDate;
        }

        // Автоматически созданный метод инициализации компонентов
        private void init()
        {
            // Инициализация компонентов формы
    

            
        }
        public void EditAvto(int code, string model, string gos_number, string data)
        {
          
            // Replace условие_по_которому_вы_меняете_строку with the actual condition based on which you want to update the row.
            controller.EditAvtorr(code, model, gos_number, data);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ownerCode = textBoxOwnerCode.Text;
            string model = textBoxModel.Text;
            string licensePlate = textBoxLicensePlate.Text;
            string productionDate = textBoxProductionDate.Text;

            // Выведите значения в MessageBox
            string message = $"Код владельца: {ownerCode}\nМодель: {model}\nГосударственный номер: {licensePlate}\nДата производства: {productionDate}";
            
            MessageBox.Show(message, "Подтверждение данных");
            EditAvto(Convert.ToInt32(ownerCode), model, licensePlate, productionDate);
            Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
