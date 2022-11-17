using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strID = "";//记录选中的员工编号
        private void Form1_Load(object sender, EventArgs e)
        {
            using (db_EMSEntities db = new db_EMSEntities())
            {
                dgvInfo.DataSource = db.tb_employee.ToList();//显示数据表中所有信息
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (db_EMSEntities db = new db_EMSEntities())
            {
                tb_employee tb = new tb_employee
                {
                    //为tb_employee类中的员工实体赋值
                    employeecode = txtID.Text,
                    fullname = txtName.Text,
                    sex = cbox.Text,
                    dept = txtDept.Text,
                    tel = txtTel.Text,
                    memo = txtMemo.Text
                };
                db.tb_employee.Add(tb);//构造添加SQL语句
                db.SaveChanges();//进行数据库添加操作
                dgvInfo.DataSource = db.tb_employee.ToList();//重新绑定数据源
            }
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                //获取选中的员工编号
                strID = Convert.ToString(dgvInfo[0, e.RowIndex].Value).Trim();
                using (db_EMSEntities db = new db_EMSEntities())
                {
                    //获取指定编号的员工信息
                    tb_employee tb = db.tb_employee.Where(W => W.employeecode == strID).FirstOrDefault();
                    if (tb != null)//判断查询结果是否为空
                    {
                        txtID.Text = tb.employeecode;//显示员工编号
                        txtName.Text = tb.fullname;//显示员工名称
                        cbox.Text = tb.sex;//显示员工性别
                        txtDept.Text = tb.dept;//显示所属部门
                        txtTel.Text = tb.tel;//显示员工电话
                        txtMemo.Text = tb.memo;//显示备注
                    }
                }
        }

        private void dgvInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
