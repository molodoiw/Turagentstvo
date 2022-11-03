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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemSearch3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turagentstvo_demoDataSet.Бронирование' table. You can move, or remove it, as needed.
            this.бронированиеTableAdapter.Fill(this.turagentstvo_demoDataSet.Бронирование);
            this.BackColor = Color.FromArgb(186, 227, 232);
            panel1.BackColor = Color.FromArgb(186, 227, 232);
        }
    }
}
