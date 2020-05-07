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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet8.View_4". При необходимости она может быть перемещена или удалена.
            this.view_4TableAdapter.Fill(this.dBDataSet8.View_4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet7.View_4". При необходимости она может быть перемещена или удалена.
            //this.view_4TableAdapter.Fill(this.dBDataSet7.View_4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet6.View_2". При необходимости она может быть перемещена или удалена.
            this.view_2TableAdapter.Fill(this.dBDataSet6.View_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet5.View_1". При необходимости она может быть перемещена или удалена.          
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet4.View_2". При необходимости она может быть перемещена или удалена.
            //this.view_2TableAdapter.Fill(this.dBDataSet4.View_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Поручения". При необходимости она может быть перемещена или удалена.
            this.порученияTableAdapter.Fill(this.dBDataSet.Поручения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Поручения". При необходимости она может быть перемещена или удалена.
            this.порученияTableAdapter.Fill(this.dBDataSet.Поручения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Поручения". При необходимости она может быть перемещена или удалена.
            this.порученияTableAdapter.Fill(this.dBDataSet.Поручения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Поручения". При необходимости она может быть перемещена или удалена.
            this.порученияTableAdapter.Fill(this.dBDataSet.Поручения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Поручения". При необходимости она может быть перемещена или удалена.
            this.порученияTableAdapter.Fill(this.dBDataSet.Поручения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Поручения". При необходимости она может быть перемещена или удалена.
            this.порученияTableAdapter.Fill(this.dBDataSet.Поручения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Документы". При необходимости она может быть перемещена или удалена.
            this.документыTableAdapter.Fill(this.dBDataSet.Документы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Исполнители". При необходимости она может быть перемещена или удалена.
            this.исполнителиTableAdapter.Fill(this.dBDataSet.Исполнители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Подразделение". При необходимости она может быть перемещена или удалена.
            this.подразделениеTableAdapter.Fill(this.dBDataSet.Подразделение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Тип_документа". При необходимости она может быть перемещена или удалена.
            this.тип_документаTableAdapter.Fill(this.dBDataSet.Тип_документа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Авторы". При необходимости она может быть перемещена или удалена.
            this.авторыTableAdapter.Fill(this.dBDataSet.Авторы);
            //this.proc_p1TableAdapter.Fill(this.dBDataSet10.proc_p1, comboBox4.Text);
            ComboFill(comboBox4.Text);
        }

        public void ComboFill(string Param = "")
        {
            String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
            var connect = new SqlConnection(connectionString);
            SqlCommand myCommand = connect.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[proc_p1]";
            //string Parameter = comboBox4.Text;
            string Parameter = Param;            
            myCommand.Parameters.Add("@A", SqlDbType.VarChar, 255);
            myCommand.Parameters["@A"].Value = Parameter;
            connect.Open();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            while (dataReader.Read())
            {
                col.Add(dataReader.GetString(1));
            }
            comboBox4.AutoCompleteCustomSource = col;
            connect.Close();
            this.proc_p1TableAdapter.Fill(this.dBDataSet10.proc_p1, comboBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            авторыTableAdapter.Update(dBDataSet);           
            authorsGridView.ClearSelection();
            comboBox4.Text = "";
            ComboFill();
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
            string sqlQuery = $"UPDATE dbo.Исполнители SET I='{FIO_ispoln.Text}',Kod_P='{idUnits}' WHERE KI='{Kod_ispoln.Text}'";
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
            Kod_ispoln.Clear();
            FIO_ispoln.Clear();
            save_ispoln.Enabled = false;
            add_ispoln.Enabled = true;
            label7.Visible = true;
            if (dataGridView1.Rows.Count == 0)
            {
                Kod_ispoln.Text = "1";
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
                Kod_ispoln.Text = (ki + 1).ToString();
            }           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {          
            if (FIO_ispoln.Text == "") 
            {
                MessageBox.Show("Заполните все поля!");               
                FIO_ispoln.BackColor = Color.FromArgb(214, 81, 104);
            }
            else
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string idUnits = comboBox1.SelectedValue.ToString();              
                string sqlQuery = $"INSERT INTO DB.dbo.Исполнители(I,Kod_P) VALUES ('{FIO_ispoln.Text}','{idUnits}');";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.исполнителиTableAdapter.Fill(this.dBDataSet.Исполнители);
                save_ispoln.Enabled = true;
                add_ispoln.Enabled = false;
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
                this.view_2TableAdapter.Fill(this.dBDataSet6.View_2);
                this.view_4TableAdapter.Fill(this.dBDataSet8.View_4);
                authorsSave.Enabled = true;
                authorsAdd.Enabled = false;
                label4.Visible = false;
                ComboFill();
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
                string sqlQuery = $"DELETE FROM DB.dbo.Исполнители WHERE KI='{Kod_ispoln.Text}'";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.исполнителиTableAdapter.Fill(this.dBDataSet.Исполнители);
            }
            else
            {
               // toolStripButton5.Enabled = false;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            name_doc.Clear();
            kode_doc.Clear();
            add_doc.Enabled = true;
            save_doc.Enabled = false;
            label13.Visible = true;
            if (dataGridView2.Rows.Count == 0)
            {
                kode_doc.Text = "1";
            }
            else
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string sqlQuery = $"SELECT MAX(KD) FROM DB.dbo.Документы;";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                int kD = (int)command.ExecuteScalar();
                command.ExecuteNonQuery();
                connect.Close();
                kode_doc.Text = (kD + 1).ToString();
            }
        }

        private void add_doc_Click(object sender, EventArgs e)
        {
            if (name_doc.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                name_doc.BackColor = Color.FromArgb(214, 81, 104);
            }
            else
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string kodAuthor = comboBox2.SelectedValue.ToString();
                string kodType = comboBox3.SelectedValue.ToString();
                string dateVal = dateTimePicker1.Value.ToShortDateString();
                string nameDoc = name_doc.Text;
                string sqlQuery = $"INSERT INTO DB.dbo.Документы(ND,Kod_A,Kod_T,D) VALUES ('{nameDoc}',{kodAuthor},{kodType},'{dateVal}');";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.документыTableAdapter.Fill(this.dBDataSet.Документы);
                this.view_2TableAdapter.Fill(this.dBDataSet6.View_2);
                this.view_4TableAdapter.Fill(this.dBDataSet8.View_4);
                save_doc.Enabled = true;
                add_doc.Enabled = false;
                label13.Visible = false;
            }
        }

        private void save_doc_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
            var connect = new SqlConnection(connectionString);
            connect.Open();
            string kodAuthor = comboBox2.SelectedValue.ToString();
            string kodType = comboBox3.SelectedValue.ToString();
            string dateVal = dateTimePicker1.Value.ToShortDateString();
            string nameDoc = name_doc.Text;
            string KD = kode_doc.Text;
            string sqlQuery = $"UPDATE dbo.Документы SET ND='{nameDoc}',Kod_A={kodAuthor},Kod_T={kodType},D='{dateVal}' WHERE KD={KD};";
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sqlQuery;
            command.ExecuteNonQuery();
            connect.Close();
            this.документыTableAdapter.Fill(this.dBDataSet.Документы);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string KD = kode_doc.Text;
                string sqlQuery = $"DELETE FROM DB.dbo.Документы WHERE KD={KD}";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.документыTableAdapter.Fill(this.dBDataSet.Документы);
                this.view_2TableAdapter.Fill(this.dBDataSet6.View_2);
                this.view_4TableAdapter.Fill(this.dBDataSet8.View_4);
            }
            else
            {
                toolStripButton7.Enabled = false;
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            add_misson.Enabled = true;
            save_mission.Enabled = false;
            textBox4.Clear();
            label21.Visible = true;          
        }

        private void add_misson_Click(object sender, EventArgs e)
        {
            if (porychText.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                porychText.BackColor = Color.FromArgb(214, 81, 104);
            }
            else
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string kodAuthor = kod_autPO.Text;
                string kodDoc = kod_docPO.Text;
                string porysh = porychText.Text;
                string kodIspoln = kod_ispolnPO.SelectedValue.ToString();
                string datePlan = dateTimePicker2.Value.ToShortDateString();
                string dateFact = dateTimePicker3.Value.ToShortDateString();               
                string sqlQuery = $"INSERT INTO DB.dbo.Поручения(Kod_D,PO,Kod_I,DP,DI) VALUES ({kodDoc},'{porysh}',{kodIspoln},'{datePlan}','{dateFact}');";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.порученияTableAdapter.Fill(this.dBDataSet.Поручения);
                save_mission.Enabled = true;
                add_misson.Enabled = false;
                label21.Visible = false;
            }
        }

        private void save_mission_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string kodDoc = kod_docPO.Text;
                string porysh = porychText.Text;
                string kodIspoln = kod_ispolnPO.SelectedValue.ToString();
                string datePlan = dateTimePicker2.Value.ToShortDateString();
                string dateFact = dateTimePicker3.Value.ToShortDateString();
                string sqlQuery = $"UPDATE dbo.Поручения SET Kod_D={kodDoc},PO='{porysh}',Kod_I={kodIspoln},DP='{datePlan}',DI='{dateFact}' WHERE N={textBox4.Text};";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.порученияTableAdapter.Fill(this.dBDataSet.Поручения);
            }
            else
            {
                MessageBox.Show(
                "Вы не выбрали поручение!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);              
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (dataGridView5.Rows.Count != 0)
            {
                String connectionString = "Data Source=DESKTOP-A48PMQ5;Initial Catalog=DB;Integrated Security=True";
                var connect = new SqlConnection(connectionString);
                connect.Open();
                string N = textBox4.Text;               
                string sqlQuery = $"DELETE FROM DB.dbo.Поручения WHERE N={N}";
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connect.Close();
                this.порученияTableAdapter.Fill(this.dBDataSet.Поручения);
            }          
        }
    
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.proc2TableAdapter.Fill(this.dBDataSet13.proc2, Convert.ToInt32(comboBox4.SelectedValue));          
        }
    }
}
