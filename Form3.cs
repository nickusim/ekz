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
    public partial class Form3 : Form
    {
        public static string str = @"Data Source=DESKTOP-9EF573H\SQLEXPRESS;Initial Catalog=worldSkills;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(str);
        public Form3()
        {
            InitializeComponent();
            connection.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string brend = textBox1.Text;
            string name = textBox2.Text;
            string dvigatel = textBox3.Text;
            string probeg = textBox4.Text;
            string toplivo = textBox5.Text;
            string kyzov = textBox6.Text;
            string sql = "INSERT INTO autos (brand,name,engine,mileage,oil,body) VALUES ('" + brend + "','" + name + "','" + dvigatel + "','" + probeg + "','" + toplivo + "','" + kyzov + "' )";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Добавлено");
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();

           
        }
    }
}
