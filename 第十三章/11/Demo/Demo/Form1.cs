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

        string strID = "";//记录选中的商品编号
        private void Form1_Load(object sender, EventArgs e)
        {
            using (db_EMSEntities db = new db_EMSEntities())
            {
                dgvInfo.DataSource = db.tb_stock.ToList();//显示数据表中所有信息
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (db_EMSEntities db = new db_EMSEntities())
            {
                tb_stock stock = new tb_stock
                {
                    //为tb_stock类中的商品实体赋值
                    tradecode = txtID.Text,
                    fullname = txtName.Text,
                    unit = cbox.Text,
                    type = txtType.Text,
                    standard = txtISBN.Text,
                    produce = txtAddress.Text,
                    qty = Convert.ToInt32(txtNum.Text),
                    price = Convert.ToDouble(txtPrice.Text)
                };
                db.tb_stock.Add(stock);//构造添加SQL语句
                db.SaveChanges();//进行数据库添加操作
                dgvInfo.DataSource = db.tb_stock.ToList();//重新绑定数据源
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (db_EMSEntities db = new db_EMSEntities())
            {
                tb_stock stock = new tb_stock { tradecode = txtID.Text, fullname = txtName.Text };
                db.tb_stock.Attach(stock);//构造修改SQL语句
                //重新为各个字段复制
                stock.unit = cbox.Text;
                stock.type = txtType.Text;
                stock.standard = txtISBN.Text;
                stock.produce = txtAddress.Text;
                stock.qty = Convert.ToInt32(txtNum.Text);
                stock.price = Convert.ToDouble(txtPrice.Text);
                db.SaveChanges();//进行数据库修改操作
                dgvInfo.DataSource = db.tb_stock.ToList();//重新绑定数据源
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (db_EMSEntities db = new db_EMSEntities())
            {
                //查找要删除的记录
                tb_stock stock = db.tb_stock.Where(W => W.tradecode == strID).FirstOrDefault();
                if (stock != null)//判断要删除的记录是否存在
                {
                    db.tb_stock.Remove(stock);//构造删除SQL语句
                    db.SaveChanges();//执行删除操作
                    dgvInfo.DataSource = db.tb_stock.ToList();//重新绑定数据源
                    MessageBox.Show("商品信息删除成功");
                }
                else
                    MessageBox.Show("请选择要删除的商品！");
            }
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)//判断是否选择了行
            {
                //获取选中的商品编号
                strID = Convert.ToString(dgvInfo[0, e.RowIndex].Value).Trim();
                using (db_EMSEntities db = new db_EMSEntities())
                {
                    //获取指定编号的商品信息
                    tb_stock stock = db.tb_stock.Where(W => W.tradecode == strID).FirstOrDefault();
                    if (stock != null)//判断查询结果是否为空
                    {
                        txtID.Text = stock.tradecode;//显示商品编号
                        txtName.Text = stock.fullname;//显示商品全称
                        cbox.Text = stock.unit;//显示商品单位
                        txtType.Text = stock.type;//显示商品类型
                        txtISBN.Text = stock.standard;//显示商品规格
                        txtAddress.Text = stock.produce;//显示商品产地
                        txtNum.Text = stock.qty.ToString();//显示商品数量
                        txtPrice.Text = stock.price.ToString();//显示商品价格
                    }
                }
            }
        }

        private void dgvInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
