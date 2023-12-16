using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sample.Controller;

namespace Sample
{
    public partial class Form1 : Form
    {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdatePerson();
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

        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  controller.UpdateCars();
        }

        private void владельцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateCars();
        }

        private void фактыНарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateFacts();
        }

        private void видыНарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateVidNarush();
        }

        private void инспекторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateInspector();
        }
    }
}
