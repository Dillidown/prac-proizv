using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApp1
{
    public partial class Employees : Form
    {
        SqlCommand com;
        SqlConnection con;
        public Employees()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=sedmax;Integrated Security=True");
            con.Open();
            com = new SqlCommand($"INSERT INTO Employees (Company, Position, Expirience) VALUES (N'{comboBoxCompany.Text}', '{comboBoxPosition.Text}', '{comboBoxExpirience.Text}')", con);
            com.ExecuteNonQuery();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxUpdate.Text);
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=sedmax;Integrated Security=True");
            con.Open();
            com = new SqlCommand($"UPDATE Employees SET Company = '{comboBoxCompany.Text}', Position = '{comboBoxPosition.Text}', Expirience = '{comboBoxExpirience.Text}' WHERE id_Employee = {id}", con);
            com.ExecuteNonQuery();
        }
    }
}
