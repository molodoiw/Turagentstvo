using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Turagentstvo
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(186, 227, 232);
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuItemSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNext1_Click_1(object sender, EventArgs e)
        {
            var dateStart = dateTimePickerStart.Text;
            var dateFinish = dateTimePickerFinish.Text;
            var countDays = textBoxCountDays.Text;
            var countHumans = textBoxCountHumans.Text;
            var childrens = checkBoxChildrens.Checked;

            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dateStart = "";
            var dateFinish = "";
            var countDays = "";
            var countHumans = "";
            var childrens = "";

            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
    }
}
