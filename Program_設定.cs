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
        private void Program_設定_Init()
        {
            this.plC_RJ_Button_設定_藥藍設定_消磁感應區_檢查感應.MouseDownEvent += PlC_RJ_Button_設定_藥藍設定_消磁感應區_檢查感應_MouseDownEvent;
            this.plC_UI_Init.Add_Method(sub_Program_設定);
        }

   

        private void sub_Program_設定()
        {
            sub_Program_設定_藥藍設定_檢查感應();
        }
        #region PLC_設定_藥藍設定_檢查感應
        string str_設定_藥藍設定_檢查感應_上次卡號 = "";
        PLC_Device PLC_Device_設定_藥藍設定_檢查感應 = new PLC_Device("");
        PLC_Device PLC_Device_設定_藥藍設定_檢查感應_OK = new PLC_Device("");
        Task Task_設定_藥藍設定_檢查感應;
        MyTimer MyTimer_設定_藥藍設定_檢查感應_結束延遲 = new MyTimer();
        int cnt_Program_設定_藥藍設定_檢查感應 = 65534;
        void sub_Program_設定_藥藍設定_檢查感應()
        {
            if (this.plC_ScreenPage_Main.PageText == "設定" && this.plC_ScreenPage_設定.PageText == "藥藍設定") PLC_Device_設定_藥藍設定_檢查感應.Bool = true;
            if (!plC_Button_設定_藥藍設定_開始感應.Bool) PLC_Device_設定_藥藍設定_檢查感應.Bool = false;
            if (cnt_Program_設定_藥藍設定_檢查感應 == 65534)
            {
                this.MyTimer_設定_藥藍設定_檢查感應_結束延遲.StartTickTime(100);
                PLC_Device_設定_藥藍設定_檢查感應.SetComment("PLC_設定_藥藍設定_檢查感應");
                PLC_Device_設定_藥藍設定_檢查感應_OK.SetComment("PLC_設定_藥藍設定_檢查感應_OK");
                PLC_Device_設定_藥藍設定_檢查感應.Bool = false;
                cnt_Program_設定_藥藍設定_檢查感應 = 65535;
            }
            if (cnt_Program_設定_藥藍設定_檢查感應 == 65535) cnt_Program_設定_藥藍設定_檢查感應 = 1;
            if (cnt_Program_設定_藥藍設定_檢查感應 == 1) cnt_Program_設定_藥藍設定_檢查感應_檢查按下(ref cnt_Program_設定_藥藍設定_檢查感應);
            if (cnt_Program_設定_藥藍設定_檢查感應 == 2) cnt_Program_設定_藥藍設定_檢查感應_初始化(ref cnt_Program_設定_藥藍設定_檢查感應);
            if (cnt_Program_設定_藥藍設定_檢查感應 == 3) cnt_Program_設定_藥藍設定_檢查感應 = 65500;
            if (cnt_Program_設定_藥藍設定_檢查感應 > 1) cnt_Program_設定_藥藍設定_檢查感應_檢查放開(ref cnt_Program_設定_藥藍設定_檢查感應);

            if (cnt_Program_設定_藥藍設定_檢查感應 == 65500)
            {
                this.MyTimer_設定_藥藍設定_檢查感應_結束延遲.TickStop();
                this.MyTimer_設定_藥藍設定_檢查感應_結束延遲.StartTickTime(100);
                PLC_Device_設定_藥藍設定_檢查感應.Bool = false;
                PLC_Device_設定_藥藍設定_檢查感應_OK.Bool = false;
                cnt_Program_設定_藥藍設定_檢查感應 = 65535;
            }
        }
        void cnt_Program_設定_藥藍設定_檢查感應_檢查按下(ref int cnt)
        {
            if (PLC_Device_設定_藥藍設定_檢查感應.Bool) cnt++;
        }
        void cnt_Program_設定_藥藍設定_檢查感應_檢查放開(ref int cnt)
        {
            if (!PLC_Device_設定_藥藍設定_檢查感應.Bool) cnt = 65500;
        }
        void cnt_Program_設定_藥藍設定_檢查感應_初始化(ref int cnt)
        {
            if (this.MyTimer_設定_藥藍設定_檢查感應_結束延遲.IsTimeOut())
            {
                if (Task_設定_藥藍設定_檢查感應 == null)
                {
                    Task_設定_藥藍設定_檢查感應 = new Task(new Action(delegate { this.PlC_RJ_Button_設定_藥藍設定_消磁感應區_檢查感應_MouseDownEvent(null); }));
                }
                if (Task_設定_藥藍設定_檢查感應.Status == TaskStatus.RanToCompletion)
                {
                    Task_設定_藥藍設定_檢查感應 = new Task(new Action(delegate { this.PlC_RJ_Button_設定_藥藍設定_消磁感應區_檢查感應_MouseDownEvent(null); }));
                }
                if (Task_設定_藥藍設定_檢查感應.Status == TaskStatus.Created)
                {
                    Task_設定_藥藍設定_檢查感應.Start();
                }
                cnt++;
            }
        }







        #endregion
        private void PlC_RJ_Button_設定_藥藍設定_消磁感應區_檢查感應_MouseDownEvent(MouseEventArgs mevent)
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
            for(int i = 0; i < rFID_Datas.Count; i++)
            {
                if (rFID_Datas[i].IP != IP) continue;
                CardID = rFID_Datas[i].Card_ID;
                break;
            }
            if (CardID.StringIsEmpty())
            {
                this.Invoke(new Action(delegate
                {
                    label_設定_藥藍設定_消磁感應區.Text = $"[等待感應]";
                    label_設定_藥藍設定_消磁感應區.ForeColor = Color.Black;
                    label_設定_藥藍設定_消磁感應區.BackColor = Color.GreenYellow;
                }));
                return;
            }
            if(str_設定_藥藍設定_檢查感應_上次卡號 == CardID)
            {
                this.Invoke(new Action(delegate
                {
                    label_設定_藥藍設定_消磁感應區.Text = $"[等待感應]";
                    label_設定_藥藍設定_消磁感應區.ForeColor = Color.Black;
                    label_設定_藥藍設定_消磁感應區.BackColor = Color.GreenYellow;
                }));
                return;
            }
            str_設定_藥藍設定_檢查感應_上次卡號 = CardID;
            this.Invoke(new Action(delegate
            {
                label_設定_藥藍設定_消磁感應區.Text = $"卡號:[{CardID}]";
                label_設定_藥藍設定_消磁感應區.ForeColor = Color.Black;
                label_設定_藥藍設定_消磁感應區.BackColor = Color.Yellow;
            }));
            System.Threading.Thread.Sleep(1000);
            List<object[]> list_藥藍資料 = this.sqL_DataGridView_藥藍資料.SQL_GetAllRows(false);
            list_藥藍資料 = list_藥藍資料.GetRows((int)enum_藥藍資料.CardID, CardID);
            if (list_藥藍資料.Count == 0)
            {
                object[] value = new object[new enum_藥藍資料().GetLength()];
                value[(int)enum_藥藍資料.GUID] = Guid.NewGuid().ToString();
                value[(int)enum_藥藍資料.CardID] = CardID;
                value[(int)enum_藥藍資料.名稱] = 名稱;
                value[(int)enum_藥藍資料.已消磁] = "Y";
                value[(int)enum_藥藍資料.最後掃描時間] = DateTime.Now;
                this.sqL_DataGridView_藥藍資料.SQL_AddRow(value, false);
            }
            else
            {
                object[] value = list_藥藍資料[0];
                value[(int)enum_藥藍資料.CardID] = CardID;
                value[(int)enum_藥藍資料.名稱] = 名稱;
                value[(int)enum_藥藍資料.已消磁] = "Y";
                value[(int)enum_藥藍資料.最後掃描時間] = DateTime.Now;
                this.sqL_DataGridView_藥藍資料.SQL_ReplaceExtra(value, false);
            }
            this.Invoke(new Action(delegate
            {
                label_設定_藥藍設定_消磁感應區.Text = $"[設定完成]";
                label_設定_藥藍設定_消磁感應區.ForeColor = Color.White;
                label_設定_藥藍設定_消磁感應區.BackColor = Color.Red;
            }));
            System.Threading.Thread.Sleep(1000);
            this.Invoke(new Action(delegate
            {
                label_主畫面_消磁感應區.Text = $"卡號:[{CardID}]";
                label_主畫面_消磁感應區.ForeColor = Color.Black;
                label_主畫面_消磁感應區.BackColor = Color.Yellow;
            }));
        }
    }
}
