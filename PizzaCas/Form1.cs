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

namespace PizzaCas
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\PizzaCas\PizzaCas\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PizzaSales pizzaSales = new PizzaSales();
            pizzaSales.Show();
            Form1 form1 = new Form1();
            form1.Close();
            this.Hide();
        }
    }
}
/*}
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

namespace salesRecord
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\salesRecord.mdf;Integrated Security=True;MultipleActiveResultSets=true");
        public Form1()
        {
            InitializeComponent();

            DateTimePicker date = new DateTimePicker();
            string Date = date.Value.ToString("dd/M/yyyy");
            fromDate.Value = DateTime.Now;
            toDate.Value = DateTime.Now;
            label7.Text = Date;
            tabControl1.Enabled = false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesRecordDataSet.salesRecord' table. You can move, or remove it, as needed.
            this.salesRecordTableAdapter.Fill(this.salesRecordDataSet.salesRecord);

            int sum = dataGridView1.RowCount - 1;
            label11.Text = sum.ToString();
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
            totalSales.Text = total.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void specificDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void food_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusId_TextChanged(object sender, EventArgs e)
        {

        }

        private void salesRecordBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



        private void fromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        //Search record by day.
        private void button1_Click_2(object sender, EventArgs e)
        {
            connection.Open();

            string Date = specificDate.Text;
            Convert.ToDateTime(Date);
            SqlDataAdapter dataFetch = new SqlDataAdapter("SELECT * FROM salesRecord WHERE orderDate = '" + Date + "' ", connection);
            DataTable record = new DataTable();
            dataFetch.Fill(record);
            dataGridView1.DataSource = record;
            int sum = dataGridView1.RowCount - 1;
            label11.Text = sum.ToString();
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
            totalSales.Text = total.ToString();
            connection.Close();
        }


        private void button5_Click_1(object sender, EventArgs e)
        {

        }
        //Show today sales.
        private void dailySale_Click(object sender, EventArgs e)
        {
            connection.Open();
            DateTimePicker date = new DateTimePicker();
            // string Date = date.Value.ToString("dd/M/yyyy");
            DateTime myDateTime = DateTime.Now;
            string Date = myDateTime.ToString("yyyy/MM/dd");
            SqlDataAdapter dataFetch = new SqlDataAdapter("SELECT * FROM salesRecord WHERE orderDate = '" + Date + "' ", connection);
            DataTable record = new DataTable();
            dataFetch.Fill(record);
            dataGridView1.DataSource = record;
            int sum = dataGridView1.RowCount - 1;
            label11.Text = sum.ToString();
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
            totalSales.Text = total.ToString();
            connection.Close();

        }


        private void food_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //Show all record.
        private void button6_Click_2(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter dataFetch = new SqlDataAdapter("SELECT * FROM salesRecord ", connection);
            DataTable record = new DataTable();
            dataFetch.Fill(record);
            dataGridView1.DataSource = record;
            int sum = dataGridView1.RowCount - 1;
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
            label11.Text = sum.ToString();
            totalSales.Text = total.ToString();
            connection.Close();
        }

        private void specificDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void cusId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void amount_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTimePicker date = new DateTimePicker();
            string Date = date.Value.ToString("dd/M/yyyy");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //Checkbox for advanced filtering.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tabControl1.Enabled = true;
            }
            else
            {
                tabControl1.Enabled = false;
            }

        }

        private void totalSales_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void totalSales_TextChanged(object sender, EventArgs e)
        {

        }
        //Search record by month.
        private void button2_Click_2(object sender, EventArgs e)
        {
            connection.Open();

            string Months = month.Text.ToString();
            string Years = year.Text.ToString();
            SqlDataAdapter dataFetch = new SqlDataAdapter("SELECT * FROM salesRecord WHERE Month(orderDate) = '" + Months + "' and Year(orderDate) = '" + Years + "'", connection);
            DataTable record = new DataTable();
            dataFetch.Fill(record);
            dataGridView1.DataSource = record;
            int sum = dataGridView1.RowCount - 1;
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
            label11.Text = sum.ToString();
            totalSales.Text = total.ToString();
            connection.Close();
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Add new record.
        private void button5_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (cusId.Text.Trim() == string.Empty || food.Text.Trim() == string.Empty || amount.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("The field is blank.");
                    return; // return because we don't want to run normal code of buton click
                }
                else
                {
                    DateTimePicker date = new DateTimePicker();
                    if (cusId.Text.All(char.IsDigit))
                    {
                        DateTime myDateTime = DateTime.Now;
                        string Date = myDateTime.ToString("yyyy/MM/dd");
                        string insert = "INSERT INTO salesRecord(cusId,orderDate,orderTime,orderFood,amountPrice) VALUES('" + cusId.Text + "','" + Date + "','" + date.Value.TimeOfDay + "','" + food.Text + "','" + amount.Text + "');";
                        using (SqlCommand command = new SqlCommand(insert, connection))
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Record added!");
                            SqlDataAdapter dataFetch = new SqlDataAdapter("SELECT * FROM salesRecord", connection);
                            DataTable record = new DataTable();
                            dataFetch.Fill(record);
                            dataGridView1.DataSource = record;
                            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
                            int sum = dataGridView1.RowCount - 1;
                            label11.Text = sum.ToString();
                            totalSales.Text = total.ToString();
                            connection.Close();
                            cusId.Text = string.Empty;
                            food.Text = string.Empty;
                            amount.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid customer ID");
                        cusId.Text = string.Empty;
                        food.Text = string.Empty;
                        amount.Text = string.Empty;

                    }



                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Update sales record.
        private void button7_Click_1(object sender, EventArgs e)
        {
            if (findCusId.Text.Trim() == string.Empty || updateOrderFood.Text.Trim() == string.Empty || updateOrderFood.Text.Trim() == string.Empty)
            {
                MessageBox.Show("The field is blank.");
                return; // return because we don't want to run normal code of buton click
            }
            else
            {
                if (findCusId.Text.All(char.IsDigit))
                {
                    connection.Open();
                    SqlDataAdapter dataFetch = new SqlDataAdapter();
                    dataFetch.UpdateCommand = new SqlCommand("UPDATE salesRecord SET orderFood = @Food,amountPrice = @amount WHERE cusId = @customerID", connection);
                    dataFetch.UpdateCommand.Parameters.Add("@Food", SqlDbType.VarChar).Value = updateOrderFood.Text.ToString();
                    dataFetch.UpdateCommand.Parameters.Add("@amount", SqlDbType.Float).Value = updateAmountPrice.Text.ToString();
                    dataFetch.UpdateCommand.Parameters.Add("@customerID", SqlDbType.Int).Value = findCusId.Text.ToString();
                    dataFetch.UpdateCommand.ExecuteNonQuery();
                    dataFetch = new SqlDataAdapter("SELECT * FROM salesRecord ", connection);
                    DataTable record = new DataTable();
                    MessageBox.Show("Record updated!");
                    dataFetch.Fill(record);
                    dataGridView1.DataSource = record;
                    int sum = dataGridView1.RowCount - 1;
                    int total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
                    label11.Text = sum.ToString();
                    totalSales.Text = total.ToString();
                    connection.Close();
                    updateAmountPrice.Text = string.Empty;
                    updateOrderFood.Text = string.Empty;
                    findCusId.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please enter a valid customer ID");
                    cusId.Text = string.Empty;
                    food.Text = string.Empty;
                    amount.Text = string.Empty;
                }

            }
        }
        //Search record by specific duration.
        private void button8_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            string FromDate = fromDate.Text.ToString();
            string ToDate = toDate.Text.ToString();
            Convert.ToDateTime(ToDate);
            Convert.ToDateTime(FromDate);
            SqlDataAdapter dataFetch = new SqlDataAdapter("SELECT * FROM salesRecord WHERE orderDate BETWEEN'" + FromDate + "' AND '" + ToDate + "'; ", connection);
            DataTable record = new DataTable();
            dataFetch.Fill(record);
            dataGridView1.DataSource = record;
            int sum = dataGridView1.RowCount - 1;
            label11.Text = sum.ToString();
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
            totalSales.Text = total.ToString();
            connection.Close();
        }
        //Search record by year.
        private void button3_Click_1(object sender, EventArgs e)
        {
            connection.Open();


            string Years = searchYear.Text.ToString();
            SqlDataAdapter dataFetch = new SqlDataAdapter("SELECT * FROM salesRecord WHERE Year(orderDate) = '" + Years + "'", connection);
            DataTable record = new DataTable();
            dataFetch.Fill(record);
            dataGridView1.DataSource = record;
            int sum = dataGridView1.RowCount - 1;
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
            label11.Text = sum.ToString();
            totalSales.Text = total.ToString();
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            connection.Open();
            string searchCustomerID = frm.searchCusId.Text;
            SqlDataAdapter dataFetch = new SqlDataAdapter("SELECT * FROM salesRecord WHERE cusId = '" + searchCustomerID + "' ", connection);
            DataTable record = new DataTable();
            dataFetch.Fill(record);
            dataGridView1.DataSource = record;
            int sum = dataGridView1.RowCount - 1;
            label11.Text = sum.ToString();
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
            totalSales.Text = total.ToString();
            connection.Close();
        }
    }
}
*/