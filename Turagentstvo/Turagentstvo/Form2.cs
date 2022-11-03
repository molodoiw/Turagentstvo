using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turagentstvo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int starsCount = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turagentstvo_demoDataSet.Тип_питания' table. You can move, or remove it, as needed.
            this.тип_питанияTableAdapter.Fill(this.turagentstvo_demoDataSet.Тип_питания);
            this.BackColor = Color.FromArgb(186, 227, 232);
            panel1.BackColor = Color.FromArgb(186, 227, 232);
        }

        private void ToolStripMenuItemSearch2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            form1.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star.png");
            pictureBox4.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star.png");
            pictureBox5.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star.png");
            starsCount = 0;
            starsCount = 1;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star.png");
            pictureBox4.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star.png");
            pictureBox5.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star.png");
            starsCount = 0;
            starsCount = 2;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox4.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star.png");
            pictureBox5.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star.png");
            starsCount = 0;
            starsCount = 3;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox4.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox5.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star.png");
            starsCount = 0;
            starsCount = 4;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox4.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            pictureBox5.Image = Image.FromFile(@"C:\Users\molod\Desktop\demoApp\Turagentstvo\Turagentstvo\Resourses\star_selected.png");
            starsCount = 0;
            starsCount = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var food_type = comboBoxFood.Text;
            var countStars = starsCount;
            var carParking = checkBoxCarParking;
            var transfer = checkBoxTransfer;

            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var food_type = "";
            var countStars = 5;
            var carParking = false;
            var transfer = true;
        }
    }
}
