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
            String connectionString = "Data Source=LAPTOP-H7SB8JUI\\SQLEXPRESS;Initial Catalog=DB;Integrated Security=True";
            var connect = new SqlConnection(connectionString);
            connect.Open();
            string idUnits = comboBox1.SelectedValue.ToString();
            //string sqlQuery = "UPDATE ";


        }
    }
}
