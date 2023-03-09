using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using SQLUI;
using MyUI;
using Basic;
using System.Diagnostics;//記得取用 FileVersionInfo繼承
using System.Reflection;//記得取用 Assembly繼承
using H_Pannel_lib;
namespace HRFID_WinForm
{
    public partial class Form1 : Form
    {
        private void Fcunction_Init()
        {
            this.plC_UI_Init.Add_Method(sub_Function);
        }
        private void sub_Function()
        {

        }

        #region PLC_檢查滅燈時間
        PLC_Device PLC_Device_檢查滅燈時間 = new PLC_Device("");
        PLC_Device PLC_Device_檢查滅燈時間_OK = new PLC_Device("");
        Task Task_檢查滅燈時間;
        MyTimer MyTimer_檢查滅燈時間_結束延遲 = new MyTimer();
        int cnt_Program_檢查滅燈時間 = 65534;
        void sub_Program_檢查滅燈時間()
        {
            if (cnt_Program_檢查滅燈時間 == 65534)
            {
                this.MyTimer_檢查滅燈時間_結束延遲.StartTickTime(200);
                PLC_Device_檢查滅燈時間.SetComment("PLC_檢查滅燈時間");
                PLC_Device_檢查滅燈時間_OK.SetComment("PLC_檢查滅燈時間_OK");
                PLC_Device_檢查滅燈時間.Bool = false;
                cnt_Program_檢查滅燈時間 = 65535;
            }
            if (cnt_Program_檢查滅燈時間 == 65535) cnt_Program_檢查滅燈時間 = 1;
            if (cnt_Program_檢查滅燈時間 == 1) cnt_Program_檢查滅燈時間_檢查按下(ref cnt_Program_檢查滅燈時間);
            if (cnt_Program_檢查滅燈時間 == 2) cnt_Program_檢查滅燈時間_初始化(ref cnt_Program_檢查滅燈時間);
            if (cnt_Program_檢查滅燈時間 == 3) cnt_Program_檢查滅燈時間 = 65500;
            if (cnt_Program_檢查滅燈時間 > 1) cnt_Program_檢查滅燈時間_檢查放開(ref cnt_Program_檢查滅燈時間);

            if (cnt_Program_檢查滅燈時間 == 65500)
            {
                this.MyTimer_檢查滅燈時間_結束延遲.TickStop();
                this.MyTimer_檢查滅燈時間_結束延遲.StartTickTime(200);
                PLC_Device_檢查滅燈時間.Bool = false;
                PLC_Device_檢查滅燈時間_OK.Bool = false;
                cnt_Program_檢查滅燈時間 = 65535;
            }
        }
        void cnt_Program_檢查滅燈時間_檢查按下(ref int cnt)
        {
            if (PLC_Device_檢查滅燈時間.Bool) cnt++;
        }
        void cnt_Program_檢查滅燈時間_檢查放開(ref int cnt)
        {
            if (!PLC_Device_檢查滅燈時間.Bool) cnt = 65500;
        }
        void cnt_Program_檢查滅燈時間_初始化(ref int cnt)
        {
            if (this.MyTimer_檢查滅燈時間_結束延遲.IsTimeOut())
            {
                if (Task_檢查滅燈時間 == null)
                {
                    Task_檢查滅燈時間 = new Task(new Action(delegate { }));
                }
                if (Task_檢查滅燈時間.Status == TaskStatus.RanToCompletion)
                {
                    Task_檢查滅燈時間 = new Task(new Action(delegate { }));
                }
                if (Task_檢查滅燈時間.Status == TaskStatus.Created)
                {
                    Task_檢查滅燈時間.Start();
                }
                cnt++;
            }
        }







        #endregion
    }
}
