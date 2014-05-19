using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
     public class ClassLoad
    {
         /*
        //添加年份
        public void beginyear()
        {
            //1950-当前年份
            int year = DateTime.Now.Year;
            for (int i = 1950; i <= year; i++)
            {
                
                cbyear.Items.Add(i);
            }
        }

        //添加月份
        public void beginmonth()
        {
            //1-当前月
            //两种情况,当前年以前,1-12个月,
            //选1-12
            //int month = DateTime.Now.Month;
            for (int i = 1; i <= 12; i++)
            {
                cbmonth.Items.Add(i);
            }
        }

        //添加当月天数
        public void beginday()
        {
            //分为闰年 的2月判断
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
        public void beginsex()
        {
            cbsex.Items.Add("男");
            cbsex.Items.Add("女");
        }
          * */
    }
}
