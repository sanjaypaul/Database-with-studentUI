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

namespace student_entry_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string email = emailtextBox.Text;
            string address = addresstextBox.Text;

            string connetionString = @"Server= BITM-401-PC03\SQLEXPRESS; Database=universityDBc; Integrated Security = True";
            SqlConnection cannaction =new SqlConnection(connetionString);

            string query = String.Format("INSERT INTO tStudent VALUES('{0}', '{1}', '{2}')", name, email, address);
            
            SqlCommand coomend =new SqlCommand(query,cannaction);

            cannaction.Open();
            string sanjay = coomend.ExecuteNonQuery().ToString();
            //cannaction.Close();


            string sql = "Select * FROM tStudent";//LIS VIEW SHOW RUN THIS LINE
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();

            resultlistView.Items.Clear();

            while (Reader.Read())
            {

                ListViewItem lv = new ListViewItem(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                resultlistView.Items.Add(lv);


            }

            Reader.Close();
            cnn.Close();
          
        }
    }
}
