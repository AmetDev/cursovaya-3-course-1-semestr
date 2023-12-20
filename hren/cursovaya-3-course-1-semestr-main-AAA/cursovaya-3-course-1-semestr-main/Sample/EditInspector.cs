using Sample.Controller;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Sample
{
    public partial class EditInspector : Form
    {
        Query controller;
        private TextBox textBoxId;
        private TextBox textBoxFullname;
        private Button btnSave;

        // Конструктор формы
        public EditInspector(int id, string fullname)
        {
            // Вызываем автоматически созданный метод инициализации компонентов
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            init();
            textBoxId = new TextBox();
            textBoxId.Location = new Point(10, 10);
            textBoxId.Width = 200;

            textBoxFullname = new TextBox();
            textBoxFullname.Location = new Point(10, 40);
            textBoxFullname.Width = 200;

            btnSave = new Button();
            btnSave.Text = "Сохранить";
            btnSave.Location = new Point(10, 90);
            btnSave.Click += btnSave_Click;

            // Добавление компонентов на форму
            Controls.Add(textBoxId);
            Controls.Add(textBoxFullname);
            Controls.Add(btnSave);

            // Дополнительные настройки формы
            Text = "Редактирование данных";
            Size = new Size(450, 300);

            // Теперь устанавливаем значения
            textBoxId.Text = id.ToString();
            textBoxFullname.Text = fullname;
        }

        // Автоматически созданный метод инициализации компонентов
        private void init()
        {
            // Инициализация компонентов формы
        }

        public void EditInspectorData(int id, string fullname)
        {
            controller.UpdateInspectorData(id, fullname);
            // Реализуйте метод для обновления данных инспектора, если это необходимо
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            string fullname = textBoxFullname.Text;

            // Выведите значения в MessageBox
            string message = $"ID инспектора: {id}\nФИО: {fullname}";

            MessageBox.Show(message, "Подтверждение данных");
            EditInspectorData(id, fullname);
            Close();
        }
    }
}
