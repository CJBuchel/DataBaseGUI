using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI_Csharp
{
    public partial class main : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=skynet;port=3308;persistsecurityinfo=True");
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
   

        public main()
        {
            InitializeComponent();
            showdata();
            showCourseData();
            showStudentData();
            showTeacherData();
        }

        private void main_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBox2.Text);
        }

        public void SearchData(string search)
        {
            string query = "select * from schoolimport where SubjectName like '%" + search + "%'";
            adpt = new MySqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void schoolimportBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 dd = new Form2();
            dd.Show();
        }

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        public void showdata()
        {
            adpt = new MySqlDataAdapter("Select * from schoolimport", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void showCourseData()
        {
            adpt = new MySqlDataAdapter("Select * from schoolimport where SubjectName", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void showStudentData()
        {
            adpt = new MySqlDataAdapter("Select * from schoolimport", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void showTeacherData()
        {
            adpt = new MySqlDataAdapter("Select * from schoolimport", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showCourseData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showStudentData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showTeacherData();
        }
    }
}
