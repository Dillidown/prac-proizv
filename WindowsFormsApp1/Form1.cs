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
    public partial class Main : Form
    {
        SqlCommand com;
        SqlConnection con;
        public Main()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 0)
            {
                if ((comboBoxCompany.Text == "") | (comboBoxPosition.Text == "") | (comboBoxExpirience.Text == ""))
                {
                    MessageBox.Show("Нужно заполнить все поля!");
                }
                else
                {
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=sedmax;Integrated Security=True");
                    con.Open();
                    com = new SqlCommand($"INSERT INTO Employees (Company, Position, Expirience) VALUES (N'{comboBoxCompany.Text}', '{comboBoxPosition.Text}', '{comboBoxExpirience.Text}')", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Данные внесены!");
                    con.Close();
                }
            }
            if (tabMain.SelectedIndex == 1)
            {
                if (((textBoxName.Text == "") | (textBoxName.Text == " ")) | (comboBoxCompanyClients.Text == ""))
                {
                    MessageBox.Show("Нужно заполнить все поля!");
                }
                else
                {
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=sedmax;Integrated Security=True");
                    con.Open();
                    com = new SqlCommand($"INSERT INTO Clients (Clients_Name, Selected_Company) VALUES (N'{textBoxName.Text}', '{comboBoxCompanyClients.Text}')", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Данные внесены!");
                    con.Close();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sedmaxDataSet1.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.sedmaxDataSet1.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sedmaxDataSet1.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter1.Fill(this.sedmaxDataSet1.Employees);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (tabMain.SelectedIndex == 0)
            {
                if (textBoxId.Text == "")
                {
                    MessageBox.Show("Заполните поле для ввода id!");
                }
                else
                {
                    int id = Convert.ToInt32(textBoxId.Text);
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=sedmax;Integrated Security=True");
                    con.Open();
                    com = new SqlCommand($"DELETE FROM Employees WHERE id_Employee = {id}", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    con.Close();
                }
            }
            if (tabMain.SelectedIndex == 1)
            {
                if (textBoxId.Text == "")
                {
                    MessageBox.Show("Заполните поле для ввода id!");
                }
                else
                {
                    int id = Convert.ToInt32(textBoxId.Text);
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=sedmax;Integrated Security=True");
                    con.Open();
                    com = new SqlCommand($"DELETE FROM Clients WHERE id_Clients = {id}", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    con.Close();
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 0)
            {
                if (textBoxId.Text == "")
                {
                    MessageBox.Show("Заполните поле для ввода id!");
                }
                else
                {
                    if ((comboBoxCompany.Text == "") | (comboBoxPosition.Text == "") | (comboBoxExpirience.Text == ""))
                    {
                        MessageBox.Show("Нужно заполнить все поля!");
                    }
                    else
                    {
                        int id = Convert.ToInt32(textBoxId.Text);
                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=sedmax;Integrated Security=True");
                        con.Open();
                        com = new SqlCommand($"UPDATE Employees SET Company = '{comboBoxCompany.Text}', Position = '{comboBoxPosition.Text}', Expirience = '{comboBoxExpirience.Text}' WHERE id_Employee = {id}", con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Данные изменены");
                        con.Close();
                    }
                }
            }
            if (tabMain.SelectedIndex == 1)
            {
                if (textBoxId.Text == "")
                {
                    MessageBox.Show("Заполните поле для ввода id!");
                }
                else
                {
                    if (((textBoxName.Text == "") | (textBoxName.Text == " ")) | (comboBoxCompanyClients.Text == ""))
                    {
                        MessageBox.Show("Нужно заполнить все поля!");
                    }
                    else
                    {
                        int id = Convert.ToInt32(textBoxId.Text);
                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=sedmax;Integrated Security=True");
                        con.Open();
                        com = new SqlCommand($"UPDATE Clients SET Clients_Name = '{textBoxName.Text}', Selected_Company = '{comboBoxCompanyClients.Text}' WHERE id_Clients = {id}", con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Данные изменены");
                        con.Close();
                    }
                }
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 0)
            {
                for (int i = 0; i < dataGridViewEmployees.RowCount; i++)
                {
                    dataGridViewEmployees.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewEmployees.ColumnCount; j++)
                        if (dataGridViewEmployees.Rows[i].Cells[j].Value != null)
                            if (dataGridViewEmployees.Rows[i].Cells[j].Value.ToString().Contains(textBoxSelect.Text))
                            {
                                dataGridViewEmployees.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            if (tabMain.SelectedIndex == 1)
            {
                for (int i = 0; i < dataGridClients.RowCount; i++)
                {
                    dataGridClients.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridClients.ColumnCount; j++)
                        if (dataGridClients.Rows[i].Cells[j].Value != null)
                            if (dataGridClients.Rows[i].Cells[j].Value.ToString().Contains(textBoxSelect.Text))
                            {
                                dataGridClients.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
