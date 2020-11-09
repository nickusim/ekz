using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public static string str = @"Data Source=DESKTOP-9EF573H\SQLEXPRESS;Initial Catalog=worldSkills;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(str);
        public Form2()
        {
            InitializeComponent();
            connection.Open();
            string sql = "SELECT id,brand,name,body,engine,mileage FROM autos";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }
    }
}
