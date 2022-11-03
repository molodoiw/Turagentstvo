
namespace Turagentstvo
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemSearch3 = new System.Windows.Forms.ToolStripMenuItem();
            this.избранноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.turagentstvo_demoDataSet = new Turagentstvo.Turagentstvo_demoDataSet();
            this.бронированиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бронированиеTableAdapter = new Turagentstvo.Turagentstvo_demoDataSetTableAdapters.БронированиеTableAdapter();
            this.idстраныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idотеляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаястоимостьбронированияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turagentstvo_demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронированиеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(45, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 603);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Шаг3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Шаг2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Шаг1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Результаты поиска";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.dataGridViewTours);
            this.panel2.Location = new System.Drawing.Point(234, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 308);
            this.panel2.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSearch3,
            this.избранноеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemSearch3
            // 
            this.ToolStripMenuItemSearch3.Name = "ToolStripMenuItemSearch3";
            this.ToolStripMenuItemSearch3.Size = new System.Drawing.Size(54, 20);
            this.ToolStripMenuItemSearch3.Text = "Поиск";
            this.ToolStripMenuItemSearch3.Click += new System.EventHandler(this.ToolStripMenuItemSearch3_Click);
            // 
            // избранноеToolStripMenuItem
            // 
            this.избранноеToolStripMenuItem.Name = "избранноеToolStripMenuItem";
            this.избранноеToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.избранноеToolStripMenuItem.Text = "Избранное";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Turagentstvo.Properties.Resources._3шаг;
            this.pictureBox6.Location = new System.Drawing.Point(612, 81);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 54);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Turagentstvo.Properties.Resources._2шаг;
            this.pictureBox7.Location = new System.Drawing.Point(453, 81);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(56, 54);
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Turagentstvo.Properties.Resources._1шаг;
            this.pictureBox8.Location = new System.Drawing.Point(292, 81);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(56, 54);
            this.pictureBox8.TabIndex = 20;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::Turagentstvo.Properties.Resources.star;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.AutoGenerateColumns = false;
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idстраныDataGridViewTextBoxColumn,
            this.idотеляDataGridViewTextBoxColumn,
            this.датазаездаDataGridViewTextBoxColumn,
            this.общаястоимостьбронированияDataGridViewTextBoxColumn});
            this.dataGridViewTours.DataSource = this.бронированиеBindingSource;
            this.dataGridViewTours.Location = new System.Drawing.Point(18, 79);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.Size = new System.Drawing.Size(318, 178);
            this.dataGridViewTours.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(334, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 178);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Забронировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // turagentstvo_demoDataSet
            // 
            this.turagentstvo_demoDataSet.DataSetName = "Turagentstvo_demoDataSet";
            this.turagentstvo_demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бронированиеBindingSource
            // 
            this.бронированиеBindingSource.DataMember = "Бронирование";
            this.бронированиеBindingSource.DataSource = this.turagentstvo_demoDataSet;
            // 
            // бронированиеTableAdapter
            // 
            this.бронированиеTableAdapter.ClearBeforeFill = true;
            // 
            // idстраныDataGridViewTextBoxColumn
            // 
            this.idстраныDataGridViewTextBoxColumn.DataPropertyName = "Id_страны";
            this.idстраныDataGridViewTextBoxColumn.HeaderText = "Id_страны";
            this.idстраныDataGridViewTextBoxColumn.Name = "idстраныDataGridViewTextBoxColumn";
            // 
            // idотеляDataGridViewTextBoxColumn
            // 
            this.idотеляDataGridViewTextBoxColumn.DataPropertyName = "Id_отеля";
            this.idотеляDataGridViewTextBoxColumn.HeaderText = "Id_отеля";
            this.idотеляDataGridViewTextBoxColumn.Name = "idотеляDataGridViewTextBoxColumn";
            // 
            // датазаездаDataGridViewTextBoxColumn
            // 
            this.датазаездаDataGridViewTextBoxColumn.DataPropertyName = "Дата_заезда";
            this.датазаездаDataGridViewTextBoxColumn.HeaderText = "Дата_заезда";
            this.датазаездаDataGridViewTextBoxColumn.Name = "датазаездаDataGridViewTextBoxColumn";
            // 
            // общаястоимостьбронированияDataGridViewTextBoxColumn
            // 
            this.общаястоимостьбронированияDataGridViewTextBoxColumn.DataPropertyName = "Общая_стоимость_бронирования";
            this.общаястоимостьбронированияDataGridViewTextBoxColumn.HeaderText = "Общая_стоимость_бронирования";
            this.общаястоимостьбронированияDataGridViewTextBoxColumn.Name = "общаястоимостьбронированияDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туристическое агентство";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.turagentstvo_demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронированиеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearch3;
        private System.Windows.Forms.ToolStripMenuItem избранноеToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewTours;
        private System.Windows.Forms.Button button1;
        private Turagentstvo_demoDataSet turagentstvo_demoDataSet;
        private System.Windows.Forms.BindingSource бронированиеBindingSource;
        private Turagentstvo_demoDataSetTableAdapters.БронированиеTableAdapter бронированиеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idстраныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idотеляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаястоимостьбронированияDataGridViewTextBoxColumn;
    }
}