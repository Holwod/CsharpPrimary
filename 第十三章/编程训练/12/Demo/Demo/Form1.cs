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

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (db_EMSEntities db = new db_EMSEntities())
            {
                //查找要删除的记录
                tb_employee tb = db.tb_employee.Where(W => W.employeecode == strID).FirstOrDefault();
                if (tb != null)//判断要删除的记录是否存在
                {
                    db.tb_employee.Remove(tb);//构造删除SQL语句
                    db.SaveChanges();//执行删除操作
                    dgvInfo.DataSource = db.tb_employee.ToList();//重新绑定数据源
                    MessageBox.Show("员工信息删除成功");
                }
                else
                    MessageBox.Show("请选择要删除的员工！");
            }
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                //获取选中的员工编号
                strID = Convert.ToString(dgvInfo[0, e.RowIndex].Value).Trim();
        }

        private void dgvInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
