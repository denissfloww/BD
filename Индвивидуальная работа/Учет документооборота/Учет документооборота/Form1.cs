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

namespace Учет_документооборота
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Исполнители". При необходимости она может быть перемещена или удалена.
            this.исполнителиTableAdapter.Fill(this.dBDataSet.Исполнители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Подразделение". При необходимости она может быть перемещена или удалена.
            this.подразделениеTableAdapter.Fill(this.dBDataSet.Подразделение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Тип_документа". При необходимости она может быть перемещена или удалена.
            this.тип_документаTableAdapter.Fill(this.dBDataSet.Тип_документа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Авторы". При необходимости она может быть перемещена или удалена.
            this.авторыTableAdapter.Fill(this.dBDataSet.Авторы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            авторыTableAdapter.Update(dBDataSet);
            authorsGridView.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            тип_документаTableAdapter.Update(dBDataSet);
            typeOfDocumentGridView.ClearSelection();
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            typeTextBox.Focus();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            authorsTextBox.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            подразделениеTableAdapter.Update(dBDataSet);
            unitsDataGridView.ClearSelection();
        }

        private void bindingNavigatorAddNewItem2_Click(object sender, EventArgs e)
        {
            unitsTextBox.Focus();
        }
        //Data Source=LAPTOP-H7SB8JUI\SQLEXPRESS;Initial Catalog=DB;Integrated Security=True
        private void button1_Click_2(object sender, EventArgs e)
        {                   
            String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
            var connect = new SqlConnection(connectionString);
            connect.Open();
            string idUnits = comboBox1.SelectedValue.ToString();         
            string sqlQuery = $"UPDATE dbo.Исполнители SET I='{textBox1.Text}',Kod_P='{idUnits}' WHERE KI='{textBox2.Text}'";
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sqlQuery;
            command.ExecuteNonQuery();
            connect.Close();
            this.исполнителиTableAdapter.Fill(this.dBDataSet.Исполнители);
        }

        private void bindingNavigatorAddNewItem3_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorDeleteItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            button1.Enabled = false;
            button2.Enabled = true;
            label7.Visible = true;
            if (dataGridView1.Rows.Count == 0)
            {
                textBox2.Text = "1";
            }
            else
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string sqlQuery = $"SELECT MAX(KI) FROM DB.dbo.Исполнители;";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                int ki = (int)command.ExecuteScalar();
                command.ExecuteNonQuery();
                connect.Close();
                textBox2.Text = (ki + 1).ToString();
            }           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {          
            if (textBox1.Text == "") 
            {
                MessageBox.Show("Заполните все поля!");               
                textBox1.BackColor = Color.FromArgb(214, 81, 104);
            }
            else
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string idUnits = comboBox1.SelectedValue.ToString();              
                string sqlQuery = $"INSERT INTO DB.dbo.Исполнители(I,Kod_P) VALUES ('{textBox1.Text}','{idUnits}');";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.исполнителиTableAdapter.Fill(this.dBDataSet.Исполнители);
                button1.Enabled = true;
                button2.Enabled = false;
                label7.Visible = false;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            authorsTextBox.Clear();           
            authorsSave.Enabled = false;
            authorsAdd.Enabled = true;
            label4.Visible = true;
        }

        private void authorsAdd_Click(object sender, EventArgs e)
        {
            if (authorsTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                authorsTextBox.BackColor = Color.FromArgb(214, 81, 104);
            }
            else
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();               
                string sqlQuery = $"INSERT INTO DB.dbo.Авторы(A) VALUES ('{authorsTextBox.Text}');";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.авторыTableAdapter.Fill(this.dBDataSet.Авторы);
                authorsSave.Enabled = true;
                authorsAdd.Enabled = false;
                label4.Visible = false;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            typeTextBox.Clear();
            saveTypeOfDoc.Enabled = false;
            AddTypeOfDoc.Enabled = true;
            label5.Visible = true;
        }

        private void AddTypeOfDoc_Click(object sender, EventArgs e)
        {
            if (typeTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                typeTextBox.BackColor = Color.FromArgb(214, 81, 104);
            }
            else
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string sqlQuery = $"INSERT INTO DB.dbo.[Тип документа](T) VALUES ('{typeTextBox.Text}');";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.тип_документаTableAdapter.Fill(this.dBDataSet.Тип_документа);
                saveTypeOfDoc.Enabled = true;
                AddTypeOfDoc.Enabled = false;
                label5.Visible = false;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            unitsTextBox.Clear();
            unitsSaveButton.Enabled = false;
            unitsAddButton.Enabled = true;
            label6.Visible = true;
        }

        private void unitsAddButton_Click(object sender, EventArgs e)
        {
            if (unitsTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                unitsTextBox.BackColor = Color.FromArgb(214, 81, 104);
            }
            else
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string sqlQuery = $"INSERT INTO DB.dbo.[Подразделение](P) VALUES ('{unitsTextBox.Text}');";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.подразделениеTableAdapter.Fill(this.dBDataSet.Подразделение);
                unitsSaveButton.Enabled = true;
                unitsAddButton.Enabled = false;
                label6.Visible = false;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string idUnits = comboBox1.SelectedValue.ToString();
                string sqlQuery = $"DELETE FROM DB.dbo.Исполнители WHERE KI='{textBox2.Text}'";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.исполнителиTableAdapter.Fill(this.dBDataSet.Исполнители);
            }
            else
            {
                toolStripButton5.Enabled = false;
            }
        }
    }
}
