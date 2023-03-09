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
            this.plC_RJ_Button_檢查滅燈.MouseDownEvent += PlC_RJ_Button_檢查滅燈_MouseDownEvent;
            this.plC_UI_Init.Add_Method(sub_Function);
        }

      

        private void sub_Function()
        {
            this.sub_Program_檢查滅燈時間();
        }

        #region PLC_檢查滅燈時間
        PLC_Device PLC_Device_檢查滅燈時間 = new PLC_Device("");
        PLC_Device PLC_Device_檢查滅燈時間_OK = new PLC_Device("");
        Task Task_檢查滅燈時間;
        MyTimer MyTimer_檢查滅燈時間_結束延遲 = new MyTimer();
        int cnt_Program_檢查滅燈時間 = 65534;
        void sub_Program_檢查滅燈時間()
        {
            PLC_Device_檢查滅燈時間.Bool = true;
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
                    Task_檢查滅燈時間 = new Task(new Action(delegate { PlC_RJ_Button_檢查滅燈_MouseDownEvent(null); }));
                }
                if (Task_檢查滅燈時間.Status == TaskStatus.RanToCompletion)
                {
                    Task_檢查滅燈時間 = new Task(new Action(delegate { PlC_RJ_Button_檢查滅燈_MouseDownEvent(null); }));
                }
                if (Task_檢查滅燈時間.Status == TaskStatus.Created)
                {
                    Task_檢查滅燈時間.Start();
                }
                cnt++;
            }
        }


        #endregion

        #region Event
        private void PlC_RJ_Button_檢查滅燈_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_亮燈位置設定.SQL_GetAllRows(false);
            List<object[]> list_value_replace = new List<object[]>();
            List<Task> taskList = new List<Task>();
            for (int i = 0; i < list_value.Count; i++)
            {
                DateTime dateTime_st = list_value[i][(int)enum_亮燈位置設定.最後亮燈時間].ToDateTimeString().StringToDateTime();
                if (dateTime_st.ToDateString("/") == "1991/01/01") continue;
                DateTime dateTime_end = DateTime.Now;
                TimeSpan timeSpan = dateTime_end - dateTime_st;
                int sec = (int)timeSpan.TotalSeconds;
                int 滅燈延遲時間 = list_value[i][(int)enum_亮燈位置設定.滅燈延遲時間].StringToInt32();
                string IP = list_value[i][(int)enum_亮燈位置設定.IP].ObjectToString();
                int IO_Index = list_value[i][(int)enum_亮燈位置設定.IO_Index].StringToInt32();
                
                if (sec >= 滅燈延遲時間)
                {
                    list_value[i][(int)enum_亮燈位置設定.最後亮燈時間] = "1991/01/01";
                    list_value_replace.Add(list_value[i]);
                    Console.WriteLine($"檢查滅燈,同步滅燈 IP:{IP} IO_Index:{IO_Index}");
                    taskList.Add(Task.Run(() =>
                    {
                        this.h_RFID_UI.Set_BlinkEnable(IP, 29030, IO_Index, false, 0);
                    }));
                }

            }
            Task.WhenAll(taskList);
            if (list_value_replace.Count > 0) this.sqL_DataGridView_亮燈位置設定.SQL_ReplaceExtra(list_value_replace, false);

        }
        #endregion
    }
}
