using Sample.Controller;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Sample
{
    public partial class EditVid : Form
    {
        Query controller;
        private TextBox textBoxCodVida;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private Button btnSave;

        // Конструктор формы
        public EditVid(int cod_vida, string name, int price)
        {
            // Вызываем автоматически созданный метод инициализации компонентов
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            init();
            textBoxCodVida = new TextBox();
            textBoxCodVida.Location = new Point(10, 10);
            textBoxCodVida.Width = 200;

            textBoxName = new TextBox();
            textBoxName.Location = new Point(10, 40);
            textBoxName.Width = 200;

            textBoxPrice = new TextBox();
            textBoxPrice.Location = new Point(10, 70);
            textBoxPrice.Width = 200;

            btnSave = new Button();
            btnSave.Text = "Сохранить";
            btnSave.Location = new Point(10, 120);
            btnSave.Click += btnSave_Click;

            // Добавление компонентов на форму
            Controls.Add(textBoxCodVida);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPrice);
            Controls.Add(btnSave);

            // Дополнительные настройки формы
            Text = "Редактирование данных";
            Size = new Size(450, 400);

            // Теперь устанавливаем значения
            textBoxCodVida.Text = cod_vida.ToString();
            textBoxName.Text = name;
            textBoxPrice.Text = price.ToString();
        }

        // Автоматически созданный метод инициализации компонентов
        private void init()
        {
            // Инициализация компонентов формы
        }

        public void EditVid1(int cod_vida, string name, int price)
        {
            controller.EditVidCon(cod_vida, name, price);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cod_vida = int.Parse(textBoxCodVida.Text);
            string name = textBoxName.Text;
            int price = int.Parse(textBoxPrice.Text);

            // Выведите значения в MessageBox
            string message = $"Код вида: {cod_vida}\nНазвание: {name}\nЦена: {price}";

            MessageBox.Show(message, "Подтверждение данных");
            EditVid1(cod_vida, name, price);
            Close();
        }
    }
}
