using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace UseSelect
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        #region 定义公共对象及变量
        SqlConnection sqlcon;
        SqlDataAdapter sqlda;
        DataSet myds;
        string strCon = @"Data Source =XIAOKE\XIAOKE;Database=db_EMS;Uid=sa;Pwd=;";
        string strSql = "select employeecode as 职工编号,fullname as 职工姓名,sex as 性别,dept as 部门,tel as 联系电话,memo as 备注 from tb_employee";
        public static string FindValue = "";  //存储查询条件
        #endregion

        //窗体初始化时显示所有职工信息
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllInfo(strSql);
            cbox_Sex.SelectedIndex = 0;
        }

        //综合查询职工信息
        private void btnQuery_Click(object sender, EventArgs e)
        {
            FindValue = "";//得到空字符串对象
            string Find_SQL = strSql;//得到SQL字符串对象
            if (FindValue.Length > 0)
                FindValue = FindValue + "and";//组合SQL字符串
            if (txt_id.Text != "")
                FindValue += "(employeecode='" + txt_id.Text + "') and";//组合SQL字符串
            if (txt_Name.Text != "")
                FindValue += "(fullname='" + txt_Name.Text + "') and";//组合SQL字符串
            if (cbox_Sex.Text != "")
                FindValue += "(sex='" + cbox_Sex.Text + "') and";//组合SQL字符串
            if (txt_Dept.Text != "")
                FindValue += "(dept ='" + Convert.ToInt32(txt_Dept.Text) + "') and";//组合SQL字符串
            if (txt_Phone.Text != "")
            {
                if (validatePhone(txt_Phone.Text))
                    FindValue += "(tel='" + txt_Phone.Text + "') and";//组合SQL字符串
                else
                {
                    MessageBox.Show("请输入正确的电话号码！");//弹出消息对话框
                    txt_Phone.Text = "";//引用空字符串
                    txt_Phone.Focus();//得到焦点
                }
            }
            if (FindValue.Length > 0)
            {
                if (FindValue.IndexOf("and") > -1)
                    FindValue = FindValue.Substring(0, FindValue.Length - 4);//删除AND运算符
            }
            else
                FindValue = "";
            if (FindValue != "")   //如果FindValue字段不为空
                Find_SQL = Find_SQL + " where " + FindValue;//组合SQL字符串
            GetAllInfo(Find_SQL);//按照SQL字符串进行查询
        }

        //清空文本框
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in groupBox1.Controls)
            {
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    ctl.Text = "";
                }
            }
            txt_id.Focus();
            cbox_Sex.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labCount.Text = "共有" + (txt_Message.Rows.Count - 1) + "条记录";
        }

        #region 根据条件查询职工信息
        /// <summary>
        /// 根据条件查询职工信息
        /// </summary>
        /// <param name="strsql">设置查询条件的SQL语句</param>
        private void GetAllInfo(string strsql)
        {
            sqlcon = new SqlConnection(strCon);
            sqlda = new SqlDataAdapter(strsql, sqlcon);
            myds = new DataSet();
            sqlda.Fill(myds);
            txt_Message.DataSource = myds.Tables[0];
        }
        #endregion

        #region  验证输入为电话号码
        /// <summary>
        /// 验证输入为电话号码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool validatePhone(string str)
        {
            return Regex.IsMatch(str, @"^(\d{3,4})-(\d{7,8})$");
        }
        #endregion
    }
}
