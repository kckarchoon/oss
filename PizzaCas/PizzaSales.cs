using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Data.Objects;
using System.Data.SqlClient;


namespace PizzaCas
{
    public partial class PizzaSales : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\PizzaCas\PizzaCas\Database1.mdf;Integrated Security=True");

        public PizzaSales()
        {
            InitializeComponent();
            DateTimePicker date = new DateTimePicker();
            string Date = date.Value.ToString("dd/M/yyyy hh:mm:ss");
            label2.Text = Date;

        }

        private void AddProductToTabbedPanel()
        {
            Con.Open();
            int i = 1;

            SqlCommand cmd = new SqlCommand("SELECT Name FROM [TblProduct]", Con);
            SqlDataReader dataReader = cmd.ExecuteReader();

            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Dock = DockStyle.Fill;

            while(dataReader.Read())
            {
               Button b = new Button();
               b.Size = new Size(100, 100);
               b.Text = dataReader["Name"].ToString();
               tabControl1.Controls.Add(b);
            }

               // tp.Controls.Add(flp);
               // i++;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PizzaSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.TblPorduct' table. You can move, or remove it, as needed.
            this.tblPorductTableAdapter.Fill(this.database1DataSet.TblPorduct);

        }

        
    }

  /*  internal class Database1
    {
    }

    internal class TblProduct
    {
        internal string Size;
    }*/
}
