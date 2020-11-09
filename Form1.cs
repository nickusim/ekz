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
    public partial class Form1 : Form
    {
        public static string str = @"Data Source=DESKTOP-9EF573H\SQLEXPRESS;Initial Catalog=worldSkills;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(str);
        public Form1()
        {
            InitializeComponent();
            connection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string log = textBox1.Text;
            string pas = textBox2.Text;
            string sql = "SELECT password FROM Auth WHERE login='"+log+"'";
            SqlCommand command = new SqlCommand(sql,connection);
            string real_pass = (string)command.ExecuteScalar();
            real_pass = real_pass.Trim(' ');
            if (pas == real_pass) 
            {
                MessageBox.Show("Верно");
                Form2 form2 = new Form2();
                form2.Show();

            }
            else
            {
                MessageBox.Show("неверно");
                textBox1.Text=" ";
            }

        }
    }
}
