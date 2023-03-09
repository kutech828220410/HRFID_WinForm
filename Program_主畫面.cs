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
        private string 窗口A_01_名稱 = "A_01";
        private string 窗口A_02_名稱 = "A_02";
        private string 窗口B_01_名稱 = "B_01";
        private string 窗口B_02_名稱 = "B_02";
        private string 窗口C_01_名稱 = "C_01";
        private string 窗口C_02_名稱 = "C_02";
        private List<string> List_窗口名稱
        {
            get
            {
                List<string> list_value = new List<string>();
                list_value.Add(窗口A_01_名稱);
                list_value.Add(窗口A_02_名稱);
                list_value.Add(窗口B_01_名稱);
                list_value.Add(窗口B_02_名稱);
                list_value.Add(窗口C_01_名稱);
                list_value.Add(窗口C_02_名稱);

                return list_value;
            }
        }
        private List<RJ_Lable> List_rJ_Lables_窗口名稱
        {
            get
            {
                List<RJ_Lable> list_value = new List<RJ_Lable>();
                list_value.Add(A_01);
                list_value.Add(A_02);
                list_value.Add(B_01);
                list_value.Add(B_02);
                list_value.Add(C_01);
                list_value.Add(C_02);
                return list_value;
            }
        }
        private void Program_主畫面_Init()
        {
            this.plC_RJ_Button_主畫面_檢查感應.MouseDownEvent += PlC_RJ_Button_主畫面_檢查感應_MouseDownEvent;
            this.plC_RJ_Button_主畫面_檢查亮燈.MouseDownEvent += PlC_RJ_Button_主畫面_檢查亮燈_MouseDownEvent;
            this.plC_RJ_Button_主畫面_檢查UI.MouseDownEvent += PlC_RJ_Button_主畫面_檢查UI_MouseDownEvent;
            this.plC_UI_Init.Add_Method(sub_Program_主畫面);
        }

   
        private void sub_Program_主畫面()
        {
            sub_Program_主畫面_檢查感應();
            sub_Program_主畫面_檢查UI();
            sub_Program_主畫面_檢查亮燈();
        }

        #region PLC_主畫面_檢查感應
        string str_主畫面_檢查感應_上次卡號 = "";
        PLC_Device PLC_Device_主畫面_檢查感應 = new PLC_Device("");
        PLC_Device PLC_Device_主畫面_檢查感應_OK = new PLC_Device("");
        Task Task_主畫面_檢查感應;
        MyTimer MyTimer_主畫面_檢查感應_結束延遲 = new MyTimer();
        int cnt_Program_主畫面_檢查感應 = 65534;
        void sub_Program_主畫面_檢查感應()
        {
            if (plC_ScreenPage_Main.PageText == "主畫面") PLC_Device_主畫面_檢查感應.Bool = true;
            if (cnt_Program_主畫面_檢查感應 == 65534)
            {
                this.MyTimer_主畫面_檢查感應_結束延遲.StartTickTime(100);
                PLC_Device_主畫面_檢查感應.SetComment("PLC_主畫面_檢查感應");
                PLC_Device_主畫面_檢查感應_OK.SetComment("PLC_主畫面_檢查感應_OK");
                PLC_Device_主畫面_檢查感應.Bool = false;
                cnt_Program_主畫面_檢查感應 = 65535;
            }
            if (cnt_Program_主畫面_檢查感應 == 65535) cnt_Program_主畫面_檢查感應 = 1;
            if (cnt_Program_主畫面_檢查感應 == 1) cnt_Program_主畫面_檢查感應_檢查按下(ref cnt_Program_主畫面_檢查感應);
            if (cnt_Program_主畫面_檢查感應 == 2) cnt_Program_主畫面_檢查感應_初始化(ref cnt_Program_主畫面_檢查感應);
            if (cnt_Program_主畫面_檢查感應 == 3) cnt_Program_主畫面_檢查感應 = 65500;
            if (cnt_Program_主畫面_檢查感應 > 1) cnt_Program_主畫面_檢查感應_檢查放開(ref cnt_Program_主畫面_檢查感應);

            if (cnt_Program_主畫面_檢查感應 == 65500)
            {
                this.MyTimer_主畫面_檢查感應_結束延遲.TickStop();
                this.MyTimer_主畫面_檢查感應_結束延遲.StartTickTime(100);
                PLC_Device_主畫面_檢查感應.Bool = false;
                PLC_Device_主畫面_檢查感應_OK.Bool = false;
                cnt_Program_主畫面_檢查感應 = 65535;
            }
        }
        void cnt_Program_主畫面_檢查感應_檢查按下(ref int cnt)
        {
            if (PLC_Device_主畫面_檢查感應.Bool) cnt++;
        }
        void cnt_Program_主畫面_檢查感應_檢查放開(ref int cnt)
        {
            if (!PLC_Device_主畫面_檢查感應.Bool) cnt = 65500;
        }
        void cnt_Program_主畫面_檢查感應_初始化(ref int cnt)
        {
            if (this.MyTimer_主畫面_檢查感應_結束延遲.IsTimeOut())
            {
                if (Task_主畫面_檢查感應 == null)
                {
                    Task_主畫面_檢查感應 = new Task(new Action(delegate { this.PlC_RJ_Button_主畫面_檢查感應_MouseDownEvent(null); }));
                }
                if (Task_主畫面_檢查感應.Status == TaskStatus.RanToCompletion)
                {
                    Task_主畫面_檢查感應 = new Task(new Action(delegate { this.PlC_RJ_Button_主畫面_檢查感應_MouseDownEvent(null); }));
                
                }
                if (Task_主畫面_檢查感應.Status == TaskStatus.Created)
                {
                    Task_主畫面_檢查感應.Start();
                }
                cnt++;
            }
        }







        #endregion
        #region PLC_主畫面_檢查UI
        PLC_Device PLC_Device_主畫面_檢查UI = new PLC_Device("");
        PLC_Device PLC_Device_主畫面_檢查UI_OK = new PLC_Device("");
        Task Task_主畫面_檢查UI;
        MyTimer MyTimer_主畫面_檢查UI_結束延遲 = new MyTimer();
        int cnt_Program_主畫面_檢查UI = 65534;
        void sub_Program_主畫面_檢查UI()
        {
            if (plC_ScreenPage_Main.PageText == "主畫面") PLC_Device_主畫面_檢查UI.Bool = true;
            if (cnt_Program_主畫面_檢查UI == 65534)
            {
                this.MyTimer_主畫面_檢查UI_結束延遲.StartTickTime(300);
                PLC_Device_主畫面_檢查UI.SetComment("PLC_主畫面_檢查UI");
                PLC_Device_主畫面_檢查UI_OK.SetComment("PLC_主畫面_檢查UI_OK");
                PLC_Device_主畫面_檢查UI.Bool = false;
                cnt_Program_主畫面_檢查UI = 65535;
            }
            if (cnt_Program_主畫面_檢查UI == 65535) cnt_Program_主畫面_檢查UI = 1;
            if (cnt_Program_主畫面_檢查UI == 1) cnt_Program_主畫面_檢查UI_檢查按下(ref cnt_Program_主畫面_檢查UI);
            if (cnt_Program_主畫面_檢查UI == 2) cnt_Program_主畫面_檢查UI_初始化(ref cnt_Program_主畫面_檢查UI);
            if (cnt_Program_主畫面_檢查UI == 3) cnt_Program_主畫面_檢查UI = 65500;
            if (cnt_Program_主畫面_檢查UI > 1) cnt_Program_主畫面_檢查UI_檢查放開(ref cnt_Program_主畫面_檢查UI);

            if (cnt_Program_主畫面_檢查UI == 65500)
            {
                this.MyTimer_主畫面_檢查UI_結束延遲.TickStop();
                this.MyTimer_主畫面_檢查UI_結束延遲.StartTickTime(300);
                PLC_Device_主畫面_檢查UI.Bool = false;
                PLC_Device_主畫面_檢查UI_OK.Bool = false;
                cnt_Program_主畫面_檢查UI = 65535;
            }
        }
        void cnt_Program_主畫面_檢查UI_檢查按下(ref int cnt)
        {
            if (PLC_Device_主畫面_檢查UI.Bool) cnt++;
        }
        void cnt_Program_主畫面_檢查UI_檢查放開(ref int cnt)
        {
            if (!PLC_Device_主畫面_檢查UI.Bool) cnt = 65500;
        }
        void cnt_Program_主畫面_檢查UI_初始化(ref int cnt)
        {
            if (this.MyTimer_主畫面_檢查UI_結束延遲.IsTimeOut())
            {
                if (Task_主畫面_檢查UI == null)
                {
                    Task_主畫面_檢查UI = new Task(new Action(delegate { PlC_RJ_Button_主畫面_檢查UI_MouseDownEvent(null); }));
                }
                if (Task_主畫面_檢查UI.Status == TaskStatus.RanToCompletion)
                {
                    Task_主畫面_檢查UI = new Task(new Action(delegate { PlC_RJ_Button_主畫面_檢查UI_MouseDownEvent(null); }));
                }
                if (Task_主畫面_檢查UI.Status == TaskStatus.Created)
                {
                    Task_主畫面_檢查UI.Start();
                }
                cnt++;
            }
        }







        #endregion
        #region PLC_主畫面_檢查亮燈
        PLC_Device PLC_Device_主畫面_檢查亮燈 = new PLC_Device("");
        PLC_Device PLC_Device_主畫面_檢查亮燈_OK = new PLC_Device("");
        Task Task_主畫面_檢查亮燈;
        MyTimer MyTimer_主畫面_檢查亮燈_結束延遲 = new MyTimer();
        int cnt_Program_主畫面_檢查亮燈 = 65534;
        void sub_Program_主畫面_檢查亮燈()
        {
            if (plC_ScreenPage_Main.PageText == "主畫面") PLC_Device_主畫面_檢查亮燈.Bool = true;
            if (cnt_Program_主畫面_檢查亮燈 == 65534)
            {
                this.MyTimer_主畫面_檢查亮燈_結束延遲.StartTickTime(100);
                PLC_Device_主畫面_檢查亮燈.SetComment("PLC_主畫面_檢查亮燈");
                PLC_Device_主畫面_檢查亮燈_OK.SetComment("PLC_主畫面_檢查亮燈_OK");
                PLC_Device_主畫面_檢查亮燈.Bool = false;
                cnt_Program_主畫面_檢查亮燈 = 65535;
            }
            if (cnt_Program_主畫面_檢查亮燈 == 65535) cnt_Program_主畫面_檢查亮燈 = 1;
            if (cnt_Program_主畫面_檢查亮燈 == 1) cnt_Program_主畫面_檢查亮燈_檢查按下(ref cnt_Program_主畫面_檢查亮燈);
            if (cnt_Program_主畫面_檢查亮燈 == 2) cnt_Program_主畫面_檢查亮燈_初始化(ref cnt_Program_主畫面_檢查亮燈);
            if (cnt_Program_主畫面_檢查亮燈 == 3) cnt_Program_主畫面_檢查亮燈 = 65500;
            if (cnt_Program_主畫面_檢查亮燈 > 1) cnt_Program_主畫面_檢查亮燈_檢查放開(ref cnt_Program_主畫面_檢查亮燈);

            if (cnt_Program_主畫面_檢查亮燈 == 65500)
            {
                this.MyTimer_主畫面_檢查亮燈_結束延遲.TickStop();
                this.MyTimer_主畫面_檢查亮燈_結束延遲.StartTickTime(100);
                PLC_Device_主畫面_檢查亮燈.Bool = false;
                PLC_Device_主畫面_檢查亮燈_OK.Bool = false;
                cnt_Program_主畫面_檢查亮燈 = 65535;
            }
        }
        void cnt_Program_主畫面_檢查亮燈_檢查按下(ref int cnt)
        {
            if (PLC_Device_主畫面_檢查亮燈.Bool) cnt++;
        }
        void cnt_Program_主畫面_檢查亮燈_檢查放開(ref int cnt)
        {
            if (!PLC_Device_主畫面_檢查亮燈.Bool) cnt = 65500;
        }
        void cnt_Program_主畫面_檢查亮燈_初始化(ref int cnt)
        {
            if (this.MyTimer_主畫面_檢查亮燈_結束延遲.IsTimeOut())
            {
                if (Task_主畫面_檢查亮燈 == null)
                {
                    Task_主畫面_檢查亮燈 = new Task(new Action(delegate { PlC_RJ_Button_主畫面_檢查亮燈_MouseDownEvent(null); }));
                }
                if (Task_主畫面_檢查亮燈.Status == TaskStatus.RanToCompletion)
                {
                    Task_主畫面_檢查亮燈 = new Task(new Action(delegate { PlC_RJ_Button_主畫面_檢查亮燈_MouseDownEvent(null); }));
                }
                if (Task_主畫面_檢查亮燈.Status == TaskStatus.Created)
                {
                    Task_主畫面_檢查亮燈.Start();
                }
                cnt++;
            }
        }







        #endregion
        private void PlC_RJ_Button_主畫面_檢查感應_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_亮燈位置設定 = this.sqL_DataGridView_亮燈位置設定.SQL_GetAllRows(false);
            list_亮燈位置設定 = list_亮燈位置設定.GetRows((int)enum_亮燈位置設定.名稱, "None");
            if (list_亮燈位置設定.Count == 0) return;
            string IP = list_亮燈位置設定[0][(int)enum_亮燈位置設定.IP].ObjectToString();
            string 名稱 = "";
            this.Invoke(new Action(delegate
            {
                名稱 = comboBox_藥蘭設定_選擇窗口.Text;
            }));

            List<H_RFID_UI.UDP_READ.RFID_Data> rFID_Datas = this.h_RFID_UI.GetRFID();
            string CardID = "";
            for (int i = 0; i < rFID_Datas.Count; i++)
            {
                if (rFID_Datas[i].IP != IP) continue;
                CardID = rFID_Datas[i].Card_ID;
                break;
            }
            if (CardID.StringIsEmpty())
            {
                this.Invoke(new Action(delegate
                {
                    label_主畫面_消磁感應區.Text = $"[等待感應]";
                    label_主畫面_消磁感應區.ForeColor = Color.Black;
                    label_主畫面_消磁感應區.BackColor = Color.GreenYellow;
                }));
                return;
            }
            if (str_主畫面_檢查感應_上次卡號 == CardID)
            {
                this.Invoke(new Action(delegate
                {
                    label_主畫面_消磁感應區.Text = $"[等待感應]";
                    label_主畫面_消磁感應區.ForeColor = Color.Black;
                    label_主畫面_消磁感應區.BackColor = Color.GreenYellow;
                }));
                return;
            }
            str_主畫面_檢查感應_上次卡號 = CardID;
            this.Invoke(new Action(delegate
            {
                label_主畫面_消磁感應區.Text = $"卡號:[{CardID}]";
                label_主畫面_消磁感應區.ForeColor = Color.Black;
                label_主畫面_消磁感應區.BackColor = Color.Yellow;
            }));
            System.Threading.Thread.Sleep(1000);
            List<object[]> list_藥藍資料 = this.sqL_DataGridView_藥藍資料.SQL_GetAllRows(false);
            list_藥藍資料 = list_藥藍資料.GetRows((int)enum_藥藍資料.CardID, CardID);
            if (list_藥藍資料.Count == 0)
            {
                this.Invoke(new Action(delegate
                {
                    label_主畫面_消磁感應區.Text = $"[此藥藍無設定]";
                    label_主畫面_消磁感應區.ForeColor = Color.White;
                    label_主畫面_消磁感應區.BackColor = Color.Red;
                }));
                System.Threading.Thread.Sleep(1000);
                this.Invoke(new Action(delegate
                {
                    label_主畫面_消磁感應區.Text = $"[等待感應]";
                    label_主畫面_消磁感應區.ForeColor = Color.Black;
                    label_主畫面_消磁感應區.BackColor = Color.GreenYellow;
                }));
                return;
            }
            else
            {
                object[] value = list_藥藍資料[0];
                value[(int)enum_藥藍資料.CardID] = CardID;
                value[(int)enum_藥藍資料.已消磁] = "Y";
                value[(int)enum_藥藍資料.最後掃描時間] = DateTime.Now;
                this.sqL_DataGridView_藥藍資料.SQL_ReplaceExtra(value, false);
            }
            this.Invoke(new Action(delegate
            {
                label_主畫面_消磁感應區.Text = $"[消磁完成]";
                label_主畫面_消磁感應區.ForeColor = Color.White;
                label_主畫面_消磁感應區.BackColor = Color.Red;
            }));
            System.Threading.Thread.Sleep(1000);
            this.Invoke(new Action(delegate
            {
                label_主畫面_消磁感應區.Text = $"[等待感應]";
                label_主畫面_消磁感應區.ForeColor = Color.Black;
                label_主畫面_消磁感應區.BackColor = Color.GreenYellow;
            }));
        }
        private void PlC_RJ_Button_主畫面_檢查UI_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_亮燈位置設定 = this.sqL_DataGridView_亮燈位置設定.SQL_GetAllRows(false);
            List<object[]> list_亮燈位置設定_buf = new List<object[]>();
            for (int i = 0; i < List_窗口名稱.Count; i++)
            {
                list_亮燈位置設定_buf = list_亮燈位置設定.GetRows((int)enum_亮燈位置設定.名稱, List_窗口名稱[i]);
                if (list_亮燈位置設定_buf.Count > 0)
                {
                    string IP = list_亮燈位置設定_buf[0][(int)enum_亮燈位置設定.IP].ObjectToString();
                    int pinNum = list_亮燈位置設定_buf[0][(int)enum_亮燈位置設定.IO_Index].StringToInt32();
                    bool flag = this.h_RFID_UI.GetBlinkEnable(IP, pinNum);
                    for(int k = 0; k < List_rJ_Lables_窗口名稱.Count; k++)
                    {
                        if(List_rJ_Lables_窗口名稱[k].Name == List_窗口名稱[i])
                        {
                            this.Invoke(new Action(delegate
                            {
                                if (flag)
                                {
                                    List_rJ_Lables_窗口名稱[k].Text = "警示中";
                                    List_rJ_Lables_窗口名稱[k].BackColor = Color.YellowGreen;
                                    List_rJ_Lables_窗口名稱[k].ForeColor = Color.White;
                                }
                                else
                                {
                                    List_rJ_Lables_窗口名稱[k].Text = "等待中";
                                    List_rJ_Lables_窗口名稱[k].BackColor = Color.Silver;
                                    List_rJ_Lables_窗口名稱[k].ForeColor = Color.White;

                                }

                            }));
                        }
                    }
               
                }
            }
          
           
           
        }
        private void PlC_RJ_Button_主畫面_檢查亮燈_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_亮燈位置設定 = this.sqL_DataGridView_亮燈位置設定.SQL_GetAllRows(false);
            List<object[]> list_亮燈位置設定_buf = new List<object[]>();
            List<object[]> list_藥藍資料 = this.sqL_DataGridView_藥藍資料.SQL_GetAllRows(false);
            List<object[]> list_藥藍資料_buf = new List<object[]>();
            List<H_RFID_UI.UDP_READ.RFID_Data> rFID_Datas = this.h_RFID_UI.GetRFID();
            List<H_RFID_UI.UDP_READ.BlinkEnable_Data> IP_Datas = new List<H_RFID_UI.UDP_READ.BlinkEnable_Data>();
            List<H_RFID_UI.UDP_READ.BlinkEnable_Data> IP_Datas_buf = new List<H_RFID_UI.UDP_READ.BlinkEnable_Data>();

            for (int i = 0; i < rFID_Datas.Count; i++)
            {
                string CardID = rFID_Datas[i].Card_ID;
                string IP = rFID_Datas[i].IP;
                list_藥藍資料_buf = this.sqL_DataGridView_藥藍資料.SQL_GetRows((int)enum_藥藍資料.CardID, CardID, false);
                if (list_藥藍資料_buf.Count == 0) continue;
                if (list_藥藍資料_buf[0][(int)enum_藥藍資料.已消磁].ObjectToString() == "N") continue;
                string 藥藍指定名稱 = list_藥藍資料_buf[0][(int)enum_藥藍資料.名稱].ObjectToString();
                list_亮燈位置設定_buf = list_亮燈位置設定.GetRows((int)enum_亮燈位置設定.名稱, 藥藍指定名稱);
                if (list_亮燈位置設定_buf.Count == 0) continue;
                int pinNum = list_亮燈位置設定_buf[0][(int)enum_亮燈位置設定.IO_Index].StringToInt32();
                list_藥藍資料_buf[0][(int)enum_藥藍資料.已消磁] = "N";
                list_藥藍資料_buf[0][(int)enum_藥藍資料.最後掃描時間] = DateTime.Now.ToDateTimeString_6();
                this.sqL_DataGridView_藥藍資料.SQL_ReplaceExtra(list_藥藍資料_buf[0], false);
                IP_Datas_buf = (from value in IP_Datas
                                where value.IP == IP
                                where value.PinNum == pinNum
                                select value).ToList();
                if(IP_Datas_buf.Count == 0)
                {
                    IP_Datas.Add(new H_RFID_UI.UDP_READ.BlinkEnable_Data(IP, pinNum));
                }
            }
            List<Task> taskList = new List<Task>();
            for(int i = 0; i < IP_Datas.Count; i++)
            {
                string IP = IP_Datas[i].IP;
                int pinNum = IP_Datas[i].PinNum;
                list_亮燈位置設定_buf = list_亮燈位置設定.GetRows((int)enum_亮燈位置設定.IP, IP);
                list_亮燈位置設定_buf = list_亮燈位置設定_buf.GetRows((int)enum_亮燈位置設定.IO_Index, pinNum.ToString());
                if (list_亮燈位置設定_buf.Count > 0)
                {
                    list_亮燈位置設定_buf[0][(int)enum_亮燈位置設定.最後亮燈時間] = DateTime.Now.ToDateTimeString_6();
                    this.sqL_DataGridView_亮燈位置設定.SQL_ReplaceExtra(list_亮燈位置設定_buf[0], false);
                }
                taskList.Add(Task.Run(() =>
                {
                    
                    this.h_RFID_UI.Set_BlinkEnable(IP, 29030, pinNum, true, 300);
                }));

            }

        }
    }

}
