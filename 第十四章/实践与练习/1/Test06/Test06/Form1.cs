using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn comboboxColumn = new DataGridViewComboBoxColumn();
            comboboxColumn.Name = "学生编号";
            this.dataGridView1.Columns.Add(comboboxColumn);
            SqlConnection con = new SqlConnection("server=XIAOKE\\XIAOKE;uid=sa;pwd=;database=db_CSharp");
            con.Open();
            SqlCommand com = new SqlCommand("select * from tb_teacher", con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboboxColumn.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}