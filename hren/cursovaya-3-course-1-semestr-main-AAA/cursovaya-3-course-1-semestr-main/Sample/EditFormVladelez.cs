using Sample.Controller;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Sample
{
    public partial class EditFormVladelez : Form
    {
        Query controller;
        private TextBox TextBoxZeroCode;
        private TextBox textBoxOwnerCode;
        private TextBox textBoxModel;
        private TextBox textBoxLicensePlate;
        private TextBox textBoxProductionDate;
        private Button btnSave;

        // Конструктор формы
        public EditFormVladelez(int codezero, string ownerCode, string model, string licensePlate, string productionDate)
        {
            // Вызываем автоматически созданный метод инициализации компонентов
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            init();
            TextBoxZeroCode = new TextBox();
            TextBoxZeroCode.Location = new Point(10, 10);
            TextBoxZeroCode.Width = 200;

            textBoxOwnerCode = new TextBox();
            textBoxOwnerCode.Location = new Point(10, 40);
            textBoxOwnerCode.Width = 200;

            textBoxModel = new TextBox();
            textBoxModel.Location = new Point(10, 70);
            textBoxModel.Width = 200;

            textBoxLicensePlate = new TextBox();
            textBoxLicensePlate.Location = new Point(10, 100);
            textBoxLicensePlate.Width = 200;

            textBoxProductionDate = new TextBox();
            textBoxProductionDate.Location = new Point(10, 130);
            textBoxProductionDate.Width = 200;

            btnSave = new Button();
            btnSave.Text = "Сохранить";
            btnSave.Location = new Point(10, 170);
            btnSave.Click += btnSave_Click;

            // Добавление компонентов на форму
            Controls.Add(TextBoxZeroCode);
            Controls.Add(textBoxOwnerCode);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxLicensePlate);
            Controls.Add(textBoxProductionDate);
            Controls.Add(btnSave);

            // Дополнительные настройки формы
            Text = "Редактирование данных";
            Size = new Size(450, 400);

            // Теперь устанавливаем значения
            TextBoxZeroCode.Text = Convert.ToString(codezero);
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
        public void EditAvto(string zero, string code, string model, string gos_number, string data)
        {

            // Replace условие_по_которому_вы_меняете_строку with the actual condition based on which you want to update the row.
            controller.EditOwner(Convert.ToInt32(zero), code, model, gos_number, data);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ZeroCode = TextBoxZeroCode.Text;
            string ownerCode = textBoxOwnerCode.Text;
            string model = textBoxModel.Text;
            string licensePlate = textBoxLicensePlate.Text;
            string productionDate = textBoxProductionDate.Text;

            // Выведите значения в MessageBox
            string message = $"Код владельца: {ZeroCode}\nownerCode: {ownerCode}\nmodel: {model}\nlicensePlate: {licensePlate} \nproductionDate:{productionDate}";

            MessageBox.Show(message, "Подтверждение данных");
            EditAvto(ZeroCode, ownerCode, model, licensePlate, productionDate);
            Close();
        }
    }
}
