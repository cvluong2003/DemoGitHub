using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMain : Form
    {
        Data dt = new Data();
        List<int> phong = new List<int>()
        {
            3,4,5,6,7,
        };
        List<int> phong2 = new List<int>()
        {
            3,4,5,6,7,
        };
        List<int> phong3 = new List<int>()
        {
            3,4,5,6,7,
        };
       List<SinhVien> lst = new List<SinhVien>()
            {
                new SinhVien("2001130172","Đặng Quang Đông","04DHTH1", 3, 4, 5),
                new SinhVien("2001230434", "Đặng Quang Anh" ,"04DHTH2", 5, 6 ,7),
                new SinhVien("3002110001", "Trần Quốc Toản", "04DHTH3", 6, 4, 7),
                new SinhVien("2001130234 ","Nguyễn Thế Sơn" ,"04DHTH1", 3, 5, 4),
                new SinhVien("2001130174", "Phạm Thu Hiền", "04DHTH2" ,4, 5, 6)
            };
        public FormMain()
        {
            InitializeComponent();
            this.Load += FormMain_Load;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        void button2_Click(object sender, EventArgs e)
        {
           

          
           
            int[] lstlabel=dt.Learn(lst);
            int  i=0;
            DataTable table = ConvertListToDataTable(lst);
            table.Columns.Add("phong", typeof(string));
            
            foreach (DataRow dr in table.Rows)
            {
                dr["phong"] = lstlabel[i].ToString();
                i++;
            }
            dataGridView1.DataSource = table;
        }
        private static DataTable ConvertListToDataTable(List<SinhVien> list)
        {
            DataTable table = new DataTable();

            // Thêm các cột vào DataTable
            table.Columns.Add("Masv", typeof(string));
            table.Columns.Add("Tensv", typeof(string));
            table.Columns.Add("lop", typeof(string));
            table.Columns.Add("nv1", typeof(int));
            table.Columns.Add("nv2", typeof(int));
            table.Columns.Add("nv3", typeof(int));
            // Thêm các hàng vào DataTable
            foreach (var item in list)
            {
                table.Rows.Add(item.masv, item.tensv,item.lop,item.nv1,item.nv2,item.nv3);
            }

            return table;
        }
        void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv=new SinhVien();
            sv.masv=textBox1.Text;
            sv.tensv=textBox2.Text;
            sv.lop=textBox3.Text;
            sv.nv1=int.Parse(comboBox1.SelectedValue.ToString());
            sv.nv2=int.Parse(comboBox2.SelectedValue.ToString());
            sv.nv3=int.Parse(comboBox1.SelectedValue.ToString());
            lst.Add(sv);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lst;
           
        }
        public void loaddata()
        {
            dataGridView1.DataSource = lst;
            comboBox1.DataSource = phong;
            comboBox2.DataSource = phong2;
            comboBox3.DataSource = phong3;
            comboBox1.DisplayMember = comboBox1.Items[0].ToString();
        }

        void FormMain_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

    }
}
