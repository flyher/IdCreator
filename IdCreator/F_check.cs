using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class F_check : Form
    {
        public F_check()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string strid = txtid.Text.Trim();
            string strplace = "";
            string stryear="";
            string strmonth="";
            string strday="";
            string strturn="";
            string strsex="";

            ClassCheck clck = new ClassCheck();
            if(strid.Length==18)
            {
                //校验码
                if( clck.checkcode(strid.Substring(0,17))!=strid[17].ToString())
                {
                    lbplace.Text = "place : wrong number!";
                    lbdate.Text = "";
                    lbsex.Text = "";
                    lbturn.Text = "";
                    F_Sign frm = new F_Sign(2);
                    frm.ShowDialog();
                    return;
                }
                

                strplace=clck.checkplace(strid.Substring(0,6));
                stryear=strid.Substring(6,4);
                //strplace=clck.checkplace(strid[0].ToString() + strid[1].ToString() + strid[2].ToString() + 
                //                        strid[3].ToString() + strid[4].ToString() + strid[5].ToString());
                //stryear = strid[6].ToString() + strid[7].ToString() + strid[8].ToString() + strid[9].ToString();

                if (strid[10].ToString() == "0")
                {
                    strmonth = strid[11].ToString();
                }
                else
                {
                    strmonth = strid[10].ToString() + strid[11].ToString();
                }

                if (strid[12].ToString() == "0")
                {
                    strday = strid[13].ToString();
                }
                else
                {
                    strday = strid[12].ToString() + strid[13].ToString();
                }

                strturn = strid[14].ToString() + strid[15].ToString() + strid[16].ToString();

                if (strid[16].ToString() == "1" || strid[16].ToString() == "3" || strid[16].ToString() == "5" || strid[16].ToString() == "7" || strid[16].ToString() == "9")
                {
                    strsex = "男";
                }
                else
                {
                    strsex = "女";
                }

                lbplace.Text ="place : "+strplace;
                lbdate.Text = "date : " + stryear + "-" + strmonth + "-" + strday;
                lbturn.Text = "turn : "+strturn;
                lbsex.Text = "sex : " + strsex;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            F_main frm = (F_main)this.Owner;
            ((ListBox)frm.Controls["lbresult"]).Items.Add(this.txtid.Text.Trim());
            this.Close();
        }
        //导出列表
    }
}
