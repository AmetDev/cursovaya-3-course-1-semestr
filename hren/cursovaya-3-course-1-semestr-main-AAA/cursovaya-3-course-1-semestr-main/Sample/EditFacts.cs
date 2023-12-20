using Sample.Controller;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Sample
{
    public partial class EditFacts : Form
    {
        Query controller;
        private TextBox textBoxCodeZero;
        private TextBox textBoxAvtoCode;
        private TextBox textBoxInspCode;
        private TextBox textBoxVladCode;
        private TextBox textBoxVidCode;
        private TextBox textBoxDataNarush;
        private TextBox textBoxFioVoditel;
        private Button btnSave;

        // Конструктор формы
        public EditFacts(int codezero, int avto, int insp, int vlad, int vid, string data_narush, string fio_voditel)
        {
            // Вызываем автоматически созданный метод инициализации компонентов
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            init();
            textBoxCodeZero = new TextBox();
            textBoxCodeZero.Location = new Point(10, 10);
            textBoxCodeZero.Width = 200;

            textBoxAvtoCode = new TextBox();
            textBoxAvtoCode.Location = new Point(10, 40);
            textBoxAvtoCode.Width = 200;

            textBoxInspCode = new TextBox();
            textBoxInspCode.Location = new Point(10, 70);
            textBoxInspCode.Width = 200;

            textBoxVladCode = new TextBox();
            textBoxVladCode.Location = new Point(10, 100);
            textBoxVladCode.Width = 200;

            textBoxVidCode = new TextBox();
            textBoxVidCode.Location = new Point(10, 130);
            textBoxVidCode.Width = 200;

            textBoxDataNarush = new TextBox();
            textBoxDataNarush.Location = new Point(10, 160);
            textBoxDataNarush.Width = 200;

            textBoxFioVoditel = new TextBox();
            textBoxFioVoditel.Location = new Point(10, 190);
            textBoxFioVoditel.Width = 200;

            btnSave = new Button();
            btnSave.Text = "Сохранить";
            btnSave.Location = new Point(10, 240);
            btnSave.Click += btnSave_Click;

            // Добавление компонентов на форму
            Controls.Add(textBoxCodeZero);
            Controls.Add(textBoxAvtoCode);
            Controls.Add(textBoxInspCode);
            Controls.Add(textBoxVladCode);
            Controls.Add(textBoxVidCode);
            Controls.Add(textBoxDataNarush);
            Controls.Add(textBoxFioVoditel);
            Controls.Add(btnSave);

            // Дополнительные настройки формы
            Text = "Редактирование данных";
            Size = new Size(450, 400);

            // Теперь устанавливаем значения
            textBoxCodeZero.Text = codezero.ToString();
            textBoxAvtoCode.Text = avto.ToString();
            textBoxInspCode.Text = insp.ToString();
            textBoxVladCode.Text = vlad.ToString();
            textBoxVidCode.Text = vid.ToString();
            textBoxDataNarush.Text = data_narush;
            textBoxFioVoditel.Text = fio_voditel;
        }

        // Автоматически созданный метод инициализации компонентов
        private void init()
        {
            // Инициализация компонентов формы
        }

        public void EditFactsZ(int codezero, int avto, int insp, int vlad, int vid, string data, string fio)
        {
            controller.UpdateFactsInDB(codezero, avto, insp, vlad, vid, data, fio);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int codezero = int.Parse(textBoxCodeZero.Text);
            int avtoCode = int.Parse(textBoxAvtoCode.Text);
            int inspCode = int.Parse(textBoxInspCode.Text);
            int vladCode = int.Parse(textBoxVladCode.Text);
            int vidCode = int.Parse(textBoxVidCode.Text);
            string dataNarush = textBoxDataNarush.Text;
            string fioVoditel = textBoxFioVoditel.Text;

            // Выведите значения в MessageBox
            string message = $"Код нулевой записи: {codezero}\nКод автомобиля: {avtoCode}\nКод инспектора: {inspCode}\nКод владельца: {vladCode}\nКод вида нарушения: {vidCode}\nДата нарушения: {dataNarush}\nФИО водителя: {fioVoditel}";

            MessageBox.Show(message, "Подтверждение данных");
            EditFactsZ(codezero, avtoCode, inspCode, vladCode, vidCode, dataNarush, fioVoditel);
            Close();
        }
    }
}
