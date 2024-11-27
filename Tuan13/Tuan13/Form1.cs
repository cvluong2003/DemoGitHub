using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace Tuan13
{
    public partial class Form1 : Form
    {
        ID3_D3 tt = new ID3_D3();
        public Form1()
        {
           
            tt.ID3_D2_Function();
            this.Load += Form1_Load;
       
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            List<string> items = new List<string> { "A", "B", "C", "D", "E", "F" };
            comboBox1.Items.AddRange(items.ToArray());
            comboBox2.Items.AddRange(items.ToArray());
            comboBox3.Items.AddRange(items.ToArray());
            comboBox4.Items.AddRange(items.ToArray());
            comboBox5.Items.AddRange(items.ToArray());
            comboBox6.Items.AddRange(items.ToArray());
            comboBox7.Items.AddRange(items.ToArray());
            comboBox8.Items.AddRange(items.ToArray());


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] arr = new string[]{
                comboBox1.SelectedItem.ToString(),
                comboBox2.SelectedItem.ToString(),
                comboBox3.SelectedItem.ToString(),
                comboBox4.SelectedItem.ToString(),
                comboBox5.SelectedItem.ToString(),
                comboBox6.SelectedItem.ToString(),
                comboBox7.SelectedItem.ToString(),
                comboBox8.SelectedItem.ToString(),
                comboBox9.SelectedItem.ToString()
           };
            string kq = tt.QD(arr);
            label1.Text = kq;
        }
        
    }
}
