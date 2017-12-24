using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comic
{
    partial class Form1
    {
        public bool isInSpeedTest = false;
        private DateTime startTime = DateAndTime.Now;
        private bool isSecondTest = false;
        private int errorTimes;
        private int successTimes;
        private double downloadTime;
        private int yerrorTimes;
        private int secondErrorTimes;
        
        public void beginSpeedTest()
        {
            isInSpeedTest = true;
            startTime = DateAndTime.Now;
            isSecondTest = false;
            secondErrorTimes = 0;
            errorTimes = 0;
            successTimes = 0;
            yerrorTimes = 0;
            downloadTime = 0;
            out_addLine("速度测试：开始测试");
        }

        public bool speed_test_onFinishTask()
        {
            if (!isInSpeedTest) return false;
            if (!isSecondTest) successTimes++;
            if (BGWs.Count == 0 && listView1.Items.Count == 0)
            {
                if (!isSecondTest)
                {
                    secondErrorTimes = 0;
                    out_addLine("速度测试：开始第二次测试");
                    isSecondTest = true;
                    yerrorTimes = errorTimes;
                    if (errorTimes == 0)
                    {
                        out_addLine("速度测试：测试结束");
                        echo();
                    }
                }
                else
                {
                    if (0 == secondErrorTimes || yerrorTimes ==secondErrorTimes)
                    {
                        out_addLine("速度测试：测试结束");
                        echo();
                    }
                    else
                    {
                        yerrorTimes = secondErrorTimes;
                        secondErrorTimes = 0;
                        out_addLine("速度测试：继续后续测试");
                    }
                }
                return true;
            }
            return false;
        }

        public void speed_test_onDownloadOK(DateTime beginTime, DateTime endTime)
        {
            if (!isInSpeedTest || isSecondTest) return;
            downloadTime += (endTime - beginTime).TotalSeconds;
        }

        public void speed_test_onError()
        {
            if (!isInSpeedTest) return;
            if (!isSecondTest) { errorTimes++; successTimes--; }
            if (isSecondTest) secondErrorTimes++;
        }

        public void echo()
        {
            out_addLine("-----速度测试-----");
            out_addLine("总耗时：" + (DateAndTime.Now - startTime).TotalSeconds.ToString() + "秒");
            out_addLine("下载耗时：" + downloadTime.ToString());
            out_addLine("第一次错误次数：" + errorTimes.ToString() + "/" + successTimes.ToString());
            out_addLine("----------------");
        }
    }
}
