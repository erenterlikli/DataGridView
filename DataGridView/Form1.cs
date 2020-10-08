using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Sıra No";
            dataGridView1.Columns[1].Name = "Ad";
            dataGridView1.Columns[2].Name = "Soyad";
            dataGridView1.Columns[3].Name = "Meslek";
            dataGridView1.Columns[4].Name = "Şehir";
           

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add(4);

            i = 0;
            dataGridView1.Rows[i].Cells[0].Value = 1;
            dataGridView1.Rows[i].Cells[1].Value = "Murat";
            dataGridView1.Rows[i].Cells[2].Value = "Yıldız";
            dataGridView1.Rows[i].Cells[3].Value = "İnşaat Mühendisi";
            dataGridView1.Rows[i].Cells[4].Value = "İzmir";

            i = 1;
            dataGridView1.Rows[i].Cells[0].Value = 2;
            dataGridView1.Rows[i].Cells[1].Value = "Ayşe";
            dataGridView1.Rows[i].Cells[2].Value = "Yılmaz";
            dataGridView1.Rows[i].Cells[3].Value = "Gıda Mühendisi";
            dataGridView1.Rows[i].Cells[4].Value = "Ankara";

            i = 2;
            dataGridView1.Rows[i].Cells[0].Value = 3;
            dataGridView1.Rows[i].Cells[1].Value = "Metin";
            dataGridView1.Rows[i].Cells[2].Value = "Kaya";
            dataGridView1.Rows[i].Cells[3].Value = "Bilgisayar Mühendisi";
            dataGridView1.Rows[i].Cells[4].Value = "Antalya";

            i = 3;
            dataGridView1.Rows[i].Cells[0].Value = 4;
            dataGridView1.Rows[i].Cells[1].Value = "Nur";
            dataGridView1.Rows[i].Cells[2].Value = "Yavuz";
            dataGridView1.Rows[i].Cells[3].Value = "Makina Mühendisi";
            dataGridView1.Rows[i].Cells[4].Value = "İstanbul";

            i = 4; //kullanıcıdan alınıyor.s
            dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[i].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[i].Cells[4].Value = textBox5.Text;

           
        }
    }
}
