using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;//hashtable
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class F_main : Form
    {
        public F_main()
        {
            InitializeComponent();
        }
        ClassCheck clcheck = new ClassCheck();
        int choseplace = 0;//当没选择城市时初始化为0，后面要用
        private void frmidentity_Load(object sender, EventArgs e)
        {
            //初始化省份数据源
            ArrayList alpro = clcheck.matchpro();
            cbpro.DataSource = alpro;
            cbpro.DisplayMember = "value";
            cbpro.ValueMember = "key";
            //设置默认省份
            cbpro.SelectedIndex = 0;
            //设置默认城市
            begindata(cbpro.SelectedValue.ToString());
            //设置默认年份
            beginyear();
            cbyear.SelectedIndex = 0;
            //设置默认月份
            beginmonth();
            cbmonth.SelectedIndex = 0;
            //设置默认天数
            beginday();
            cbday.SelectedIndex = 0;
            //设置默认性别
            beginsex();
            cbsex.SelectedIndex = 0;
            //ComboBox控件的DrawMode属性为：OwnerDrawVariable ,然后设置ItemHeight属性你要求的高度。不然下拉下来太长岂不是很像那个...你懂得的...
            //cbpro.Height = 20;
            cbpro.DropDownHeight = 100;
            cbplace.DropDownHeight = 100;
            cbyear.DropDownHeight = 100;
            cbmonth.DropDownHeight = 100;
            cbday.DropDownHeight = 100;

            this.Opacity = 0.95;
        }

        /// <summary>
        /// 改动省份时城市变动
        /// </summary>
        private void cbpro_SelectedValueChanged(object sender, EventArgs e)
        {
            //窗体第一次加载时会自动调用该事件,因为窗体加载时初始化了数据,而此时文本框里是空的,所以调用不了数据
            cbplace.DataSource = null;

            //begindata(cbpro.SelectedValue.ToString());
            if (choseplace > 1)
            {
                cbplace.DataSource = null;
                string strpro = cbpro.SelectedValue.ToString();
                begindata(strpro);
            }
            else
            {
                choseplace++;
            }
        }

        /// <summary>
        /// 改变月份时日期变动
        /// </summary>
        private void cbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbday.DataSource = null;
            cbday.Items.Clear();
            beginday();
            //begindata(cbpro.SelectedValue.ToString());
            //if (choseplace > 1)
            //{
            //    cbmonth.DataSource = null;
            //    string strpro = cbpro.SelectedValue.ToString();
            //    begindata(strpro);
            //}
            //else
            //{
            //    choseplace++;
            //}
        }

        /// <summary>
        /// 改动年份时日期变动
        /// </summary>
        private void cbyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbday.DataSource = null;
            cbday.Items.Clear();
            beginday();
        }
        /// <summary>
        /// 获取
        /// </summary>
        private void btnGet_Click(object sender, EventArgs e)
        {
            #region 注释
            //string strin = txtFir.Text.Trim();

            ////检查年月日是否正确
            //string errdate = clcheck.checkdate(strin);
            //if (errdate != "")
            //{
            //    MessageBox.Show(errdate, "错误", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    if (strin.Trim().Length == 17)
            //    {
            //        //赋值
            //        txtLast.Text = clcheck.checkcode(strin);
            //    }
            //    if (strin.Trim().Length == 18)
            //    {
            //        //校验
            //        if (clcheck.checkcode(strin) == strin[17].ToString())
            //        {
            //            txtLast.Text = "正确!";
            //        }
            //        else
            //        {
            //            txtLast.Text = "失败!";
            //        }
            //    }
            //}
            #endregion
            lbresult.Items.Add(getresule());
            //for (int i = 0; i < 5; i++)
            //{
            //    lbresult.Items.Add(getresule());
            //}
            //txtresult.Text = getresule();
        }
        /// <summary>
        /// 复制
        /// </summary>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(lbresult.SelectedItem);
                F_Sign frm = new F_Sign(1);//这不是就是上面的1么
                frm.ShowDialog();
            }
            catch (Exception err)
            { 
                //出现错误就复制失败
                F_Sign frm = new F_Sign(0);//0在这里
                frm.ShowDialog();                
            }
        }

        /// <summary>
        /// 移除选中
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //try{}catch{}捕获异常
            try
            {
                int indexbegin = lbresult.SelectedIndex;
                lbresult.Items.Remove(lbresult.SelectedItem);
                if (lbresult.Items.Count == 0)
                {
                    return;
                }
                //MessageBox.Show(lbresult.SelectedIndex.ToString());
                if (indexbegin == 0)
                {
                    lbresult.SelectedIndex = 0;
                }
                else
                {
                    //选中的为最后一个
                    if (indexbegin == lbresult.Items.Count - 1)
                    {
                        lbresult.SelectedIndex = indexbegin - 1;
                    }
                    else
                    {
                        //MessageBox.Show(lbresult.SelectedIndex.ToString());
                        lbresult.SelectedIndex = indexbegin - 1;
                    }
                }
            }
            catch (Exception err)
            {
                F_Sign frm = new F_Sign(3);
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        private void cmsdel_Click(object sender, EventArgs e)
        {
            this.lbresult.Items.Clear();
        }
        /// <summary>
        /// Check
        /// </summary>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //cbplace.DataSource = null;
            //string strpro = cbpro.SelectedValue.ToString();
            //begindata(strpro);
            F_check f2 = new F_check();
            
            f2.Owner = this;//传值关键,新窗体往主窗体回传值不能用属性
            f2.ShowDialog();
        }
        /// <summary>
        /// 导出结果
        /// </summary>
        private void btnout_Click(object sender, EventArgs e)
        {
            if (lbresult.Items.Count > 0)
            {
                string str = "";
                StreamWriter sw = new StreamWriter("outid.txt");
                for (int i = 0; i < lbresult.Items.Count; i++)
                {
                    //str += lbresult.Items[i] + "\n";
                    sw.WriteLine(lbresult.Items[i]);
                }
                
                sw.Close();
            }
        }

        /// <summary>
        /// 两级联动,根据省份编号匹配城市(前两个数字)
        /// </summary>
        /// <param name="strpro"></param>
        private void begindata(string strpro)
        {
            ArrayList alplace = clcheck.matchplace(strpro);
            cbplace.DataSource = alplace;
            cbplace.DisplayMember = "value";
            cbplace.ValueMember = "key";
        }

        //添加年份
        private void beginyear()
        {
            //1950-当前年份
            int year = DateTime.Now.Year;
            for (int i = 1950; i <= year; i++)
            {
                cbyear.Items.Add(i);
            }
        }

        //添加月份
        private void beginmonth()
        {
            //1-当前月
            //两种情况,当前年以前,1-12个月;算了，麻烦，又得判断，就用12个月吧，这样是不是还没出生的都有了
            //选1-12
            //int month = DateTime.Now.Month;
            for (int i = 1; i <= 12; i++)
            {
                cbmonth.Items.Add(i);
            }
        }

        //添加当月天数
        private void beginday()
        {
            //分为闰年 的2月判断
            //这里是不是就用到了类中的方法了
            bool byear = clcheck.cheakYear(Convert.ToInt32(cbyear.Text.Trim()));
            switch (cbmonth.Text)
            {
                case "4":
                case "6":
                case "8":
                case "10":
                    for (int i = 1; i <= 30; i++)
                    {
                        cbday.Items.Add(i);
                    }
                    break;
                case "2":
                    if (byear)
                    {
                        for (int i = 1; i <= 29; i++)
                        {
                            cbday.Items.Add(i);
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= 28; i++)
                        {
                            cbday.Items.Add(i);
                        }

                    }
                    break;
                default:
                    for (int i = 1; i <= 31; i++)
                    {
                        cbday.Items.Add(i);
                    }
                    break;
            }
        }

        //添加性别
        private void beginsex() 
        {
            cbsex.Items.Add("男");
            cbsex.Items.Add("女");
        }

        //顺序码=2位+性别1位
        //随机生成5个不重复的顺序码怎么玩?
        private string beginturn()
        {
            Random rm=new Random();
            int turnfirint = rm.Next(0, 100);
            string turnfirstr,turnsexstr;
            string[] str = new string[5];
            if (turnfirint < 10)
            {
                turnfirstr = "0" + turnfirint.ToString();
            }
            else
            {
                turnfirstr = turnfirint.ToString();
            }

            if (cbsex.SelectedIndex == 0)//男
            {
                turnsexstr = (2 * rm.Next(0, 5) + 1).ToString(); ;

            }
            else
            {
                turnsexstr = (2 * rm.Next(0, 5)).ToString();
            }

            return turnfirstr + turnsexstr;
        }
        //生成结果
        private string getresule()
        {
            string strplace= cbplace.SelectedValue.ToString();
            string strbir,strmonth,strday;
            if(cbmonth.Text.Length<2)
            {
                strmonth="0"+cbmonth.Text.ToString();//选择的月是一位数要在前面加0
            }
            else
            {
                strmonth=cbmonth.Text.ToString();
            }
            if(cbday.Text.Length<2)
            {
                strday="0"+cbday.Text.ToString();
            }
            else
            {
                strday=cbday.Text.ToString();
            }

            strbir=cbyear.Text.ToString()+strmonth+strday;
            string strfir=strplace+strbir+beginturn();
            string strall=strfir+clcheck.checkcode(strfir);
            return strall;
        }




    }
}
