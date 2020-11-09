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
    public partial class Form4 : Form
    {
        public static string str = @"Data Source=DESKTOP-9EF573H\SQLEXPRESS;Initial Catalog=worldSkills;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(str);
        public Form4()
        {
            InitializeComponent();
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id= textBox1.Text;
            string del = "DELETE FROM autos WHERE id='"+id+"'";
            SqlCommand command = new SqlCommand(del,connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Удалено");
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
