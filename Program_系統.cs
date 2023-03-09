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
        private enum enum_H_RFID_Datas
        {
            GUID,
            IP,
            CardID,
            RSSI,
        }
        private enum enum_亮燈位置設定
        {
            GUID,
            IP,
            IO_Index,
            名稱,
            滅燈延遲時間,
            最後亮燈時間,
        }
        private enum enum_藥藍資料
        {
            GUID,
            名稱,
            CardID,
            已消磁,
            最後掃描時間,

        }
        private void Program_系統_Init()
        {
            this.h_RFID_UI.Init(dBConfigClass.DB_Basic);

            this.sqL_DataGridView_亮燈位置設定.Init();
            if (this.sqL_DataGridView_亮燈位置設定.SQL_IsTableCreat() == false) this.sqL_DataGridView_亮燈位置設定.SQL_CreateTable();
            this.sqL_DataGridView_亮燈位置設定.RowDoubleClickEvent += SqL_DataGridView_亮燈位置設定_RowDoubleClickEvent;

            this.sqL_DataGridView_藥藍資料.Init();
            if (this.sqL_DataGridView_藥藍資料.SQL_IsTableCreat() == false) this.sqL_DataGridView_藥藍資料.SQL_CreateTable();

            this.plC_RJ_Button_h_RFID_Datas_刷新.MouseDownEvent += PlC_RJ_Button_h_RFID_Datas_刷新_MouseDownEvent;

            this.plC_RJ_Button_亮燈位置設定_刷新.MouseDownEvent += PlC_RJ_Button_亮燈位置設定_刷新_MouseDownEvent;
            this.plC_RJ_Button_亮燈位置設定_登錄.MouseDownEvent += PlC_RJ_Button_亮燈位置設定_登錄_MouseDownEvent;
            this.plC_RJ_Button_亮燈位置設定_刪除.MouseDownEvent += PlC_RJ_Button_亮燈位置設定_刪除_MouseDownEvent;
            this.plC_RJ_Button_亮燈位置設定_亮燈.MouseDownEvent += PlC_RJ_Button_亮燈位置設定_亮燈_MouseDownEvent;
            this.plC_RJ_Button_亮燈位置設定_滅燈.MouseDownEvent += PlC_RJ_Button_亮燈位置設定_滅燈_MouseDownEvent;


            this.plC_RJ_Button_藥藍資料庫_刷新.MouseDownEvent += PlC_RJ_Button_藥藍資料庫_刷新_MouseDownEvent;
            this.plC_RJ_Button_藥藍資料庫_刪除.MouseDownEvent += PlC_RJ_Button_藥藍資料庫_刪除_MouseDownEvent;
            this.plC_ScreenPage_系統.TabChangeEvent += PlC_ScreenPage_系統_TabChangeEvent;

            this.plC_UI_Init.Add_Method(sub_Program_系統);
        }
      
        private void sub_Program_系統()
        {
            sub_Program_系統_h_RFID_Datas_刷新();
        }

        #region PLC_系統_h_RFID_Datas_刷新
        PLC_Device PLC_Device_系統_h_RFID_Datas_刷新 = new PLC_Device("");
        PLC_Device PLC_Device_系統_h_RFID_Datas_刷新_OK = new PLC_Device("");
        Task Task_系統_h_RFID_Datas_刷新;
        MyTimer MyTimer_系統_h_RFID_Datas_刷新_結束延遲 = new MyTimer();
        int cnt_Program_系統_h_RFID_Datas_刷新 = 65534;
        void sub_Program_系統_h_RFID_Datas_刷新()
        {
            if (this.plC_ScreenPage_Main.PageText == "系統" && this.plC_ScreenPage_系統.PageText == "H_RFID") PLC_Device_系統_h_RFID_Datas_刷新.Bool = true;
            if (cnt_Program_系統_h_RFID_Datas_刷新 == 65534)
            {
                this.MyTimer_系統_h_RFID_Datas_刷新_結束延遲.StartTickTime(100);
                PLC_Device_系統_h_RFID_Datas_刷新.SetComment("PLC_系統_h_RFID_Datas_刷新");
                PLC_Device_系統_h_RFID_Datas_刷新_OK.SetComment("PLC_系統_h_RFID_Datas_刷新_OK");
                PLC_Device_系統_h_RFID_Datas_刷新.Bool = false;
                cnt_Program_系統_h_RFID_Datas_刷新 = 65535;
            }
            if (cnt_Program_系統_h_RFID_Datas_刷新 == 65535) cnt_Program_系統_h_RFID_Datas_刷新 = 1;
            if (cnt_Program_系統_h_RFID_Datas_刷新 == 1) cnt_Program_系統_h_RFID_Datas_刷新_檢查按下(ref cnt_Program_系統_h_RFID_Datas_刷新);
            if (cnt_Program_系統_h_RFID_Datas_刷新 == 2) cnt_Program_系統_h_RFID_Datas_刷新_初始化(ref cnt_Program_系統_h_RFID_Datas_刷新);
            if (cnt_Program_系統_h_RFID_Datas_刷新 == 3) cnt_Program_系統_h_RFID_Datas_刷新 = 65500;
            if (cnt_Program_系統_h_RFID_Datas_刷新 > 1) cnt_Program_系統_h_RFID_Datas_刷新_檢查放開(ref cnt_Program_系統_h_RFID_Datas_刷新);

            if (cnt_Program_系統_h_RFID_Datas_刷新 == 65500)
            {
                this.MyTimer_系統_h_RFID_Datas_刷新_結束延遲.TickStop();
                this.MyTimer_系統_h_RFID_Datas_刷新_結束延遲.StartTickTime(100);
                PLC_Device_系統_h_RFID_Datas_刷新.Bool = false;
                PLC_Device_系統_h_RFID_Datas_刷新_OK.Bool = false;
                cnt_Program_系統_h_RFID_Datas_刷新 = 65535;
            }
        }
        void cnt_Program_系統_h_RFID_Datas_刷新_檢查按下(ref int cnt)
        {
            if (PLC_Device_系統_h_RFID_Datas_刷新.Bool) cnt++;
        }
        void cnt_Program_系統_h_RFID_Datas_刷新_檢查放開(ref int cnt)
        {
            if (!PLC_Device_系統_h_RFID_Datas_刷新.Bool) cnt = 65500;
        }
        void cnt_Program_系統_h_RFID_Datas_刷新_初始化(ref int cnt)
        {
            if (this.MyTimer_系統_h_RFID_Datas_刷新_結束延遲.IsTimeOut())
            {
                if (Task_系統_h_RFID_Datas_刷新 == null)
                {
                    Task_系統_h_RFID_Datas_刷新 = new Task(new Action(delegate { this.PlC_RJ_Button_h_RFID_Datas_刷新_MouseDownEvent(null); }));
                }
                if (Task_系統_h_RFID_Datas_刷新.Status == TaskStatus.RanToCompletion)
                {
                    Task_系統_h_RFID_Datas_刷新 = new Task(new Action(delegate { this.PlC_RJ_Button_h_RFID_Datas_刷新_MouseDownEvent(null); }));
                }
                if (Task_系統_h_RFID_Datas_刷新.Status == TaskStatus.Created)
                {
                    Task_系統_h_RFID_Datas_刷新.Start();
                }
                cnt++;
            }
        }







        #endregion
        private void PlC_ScreenPage_系統_TabChangeEvent(string PageText)
        {
            if (PageText == "亮燈位置設定")
            {
                this.sqL_DataGridView_亮燈位置設定.SQL_GetAllRows(true);
            }
        }
        private void SqL_DataGridView_亮燈位置設定_RowDoubleClickEvent(object[] RowValue)
        {
            this.textBox_亮燈位置設定_IP.Text = RowValue[(int)enum_亮燈位置設定.IP].ObjectToString();
            this.textBox_亮燈位置設定_IO_Index.Text = RowValue[(int)enum_亮燈位置設定.IO_Index].ObjectToString();
            this.textBox_亮燈位置設定_名稱.Text = RowValue[(int)enum_亮燈位置設定.名稱].ObjectToString();
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.Value = RowValue[(int)enum_亮燈位置設定.滅燈延遲時間].StringToInt32();
        }
        private void PlC_RJ_Button_h_RFID_Datas_刷新_MouseDownEvent(MouseEventArgs mevent)
        {
            this.sqL_DataGridView_h_RFID_Datas.Init();
            List<H_RFID_UI.UDP_READ.RFID_Data> rFID_UID_Classes = this.h_RFID_UI.GetRFID();
            List<object[]> list_value = new List<object[]>();
            for (int i = 0; i < rFID_UID_Classes.Count; i++)
            {
                object[] value = new object[new enum_H_RFID_Datas().GetLength()];
                value[(int)enum_H_RFID_Datas.GUID] = Guid.NewGuid().ToString();
                value[(int)enum_H_RFID_Datas.IP] = rFID_UID_Classes[i].IP;
                value[(int)enum_H_RFID_Datas.CardID] = rFID_UID_Classes[i].Card_ID;
                value[(int)enum_H_RFID_Datas.RSSI] = rFID_UID_Classes[i].RSSI;
                list_value.Add(value);
            }
            List<H_RFID_UI.UDP_READ.BlinkEnable_Data> blinkEnable_Datas = this.h_RFID_UI.GetBlinkEnable();
  
            this.sqL_DataGridView_h_RFID_Datas.RefreshGrid(list_value);
        }
        private void PlC_RJ_Button_亮燈位置設定_刷新_MouseDownEvent(MouseEventArgs mevent)
        {
            this.sqL_DataGridView_亮燈位置設定.SQL_GetAllRows(true);
        }
        private void PlC_RJ_Button_亮燈位置設定_登錄_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_亮燈位置設定.SQL_GetAllRows(false);
            string IP = this.textBox_亮燈位置設定_IP.Text;
            string IO_Index = this.textBox_亮燈位置設定_IO_Index.Text;
            string 名稱 = this.textBox_亮燈位置設定_名稱.Text;

            if (IP.StringIsEmpty() || !IP.Check_IP_Adress())
            {
                MyMessageBox.ShowDialog("資料錯誤!");
                return;
            }
            if (IO_Index.StringIsEmpty() || !IO_Index.StringIsInt32())
            {
                MyMessageBox.ShowDialog("資料錯誤!");
                return;
            }
            if (名稱.StringIsEmpty())
            {
                MyMessageBox.ShowDialog("資料錯誤!");
                return;
            }
            if (this.plC_NumBox_亮燈位置設定_滅燈延遲時間.Value < 2) this.plC_NumBox_亮燈位置設定_滅燈延遲時間.Value = 2;
            list_value = list_value.GetRows((int)enum_亮燈位置設定.IP, IP);
            list_value = list_value.GetRows((int)enum_亮燈位置設定.IO_Index, IO_Index);
            if(list_value.Count == 0)
            {
                object[] value = new object[new enum_亮燈位置設定().GetLength()];
                value[(int)enum_亮燈位置設定.GUID] = Guid.NewGuid().ToString();
                value[(int)enum_亮燈位置設定.IP] = IP;
                value[(int)enum_亮燈位置設定.IO_Index] = IO_Index;
                value[(int)enum_亮燈位置設定.名稱] = 名稱;
                value[(int)enum_亮燈位置設定.滅燈延遲時間] = this.plC_NumBox_亮燈位置設定_滅燈延遲時間.Value;
                value[(int)enum_亮燈位置設定.最後亮燈時間] = DateTime.Now.ToDateTimeString();
                this.sqL_DataGridView_亮燈位置設定.SQL_AddRow(value, false);
                this.sqL_DataGridView_亮燈位置設定.AddRow(value ,true);
            }
            else
            {
                object[] value = list_value[0];
                value[(int)enum_亮燈位置設定.IP] = IP;
                value[(int)enum_亮燈位置設定.IO_Index] = IO_Index;
                value[(int)enum_亮燈位置設定.名稱] = 名稱;
                value[(int)enum_亮燈位置設定.滅燈延遲時間] = this.plC_NumBox_亮燈位置設定_滅燈延遲時間.Value;
                value[(int)enum_亮燈位置設定.最後亮燈時間] = DateTime.Now.ToDateTimeString();
                this.sqL_DataGridView_亮燈位置設定.SQL_ReplaceExtra(value, false);
                this.sqL_DataGridView_亮燈位置設定.ReplaceExtra(value, true);
            }
            MyMessageBox.ShowDialog("完成!");
        }
        private void PlC_RJ_Button_亮燈位置設定_刪除_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_亮燈位置設定.Get_All_Select_RowsValues();
            if (list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("未選取資料!");
                return;
            }
            this.sqL_DataGridView_亮燈位置設定.SQL_DeleteExtra(list_value, false);
            this.sqL_DataGridView_亮燈位置設定.DeleteExtra(list_value, true);
            MyMessageBox.ShowDialog("刪除完成!");
        }
        private void PlC_RJ_Button_亮燈位置設定_亮燈_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_亮燈位置設定.Get_All_Select_RowsValues();
            if (list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("未選取資料!");
                return;
            }
            string IP = list_value[0][(int)enum_亮燈位置設定.IP].ObjectToString();
            int IO_Index = list_value[0][(int)enum_亮燈位置設定.IO_Index].StringToInt32();
            bool flag = this.h_RFID_UI.Set_BlinkEnable(IP, 29030, IO_Index, true , 100);
            if(flag)
            {
                object[] value = list_value[0];
                value[(int)enum_亮燈位置設定.最後亮燈時間] = DateTime.Now.ToDateTimeString();
                this.sqL_DataGridView_亮燈位置設定.SQL_ReplaceExtra(value, false);
                this.sqL_DataGridView_亮燈位置設定.ReplaceExtra(value, true);
            }
        
        }
        private void PlC_RJ_Button_亮燈位置設定_滅燈_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_亮燈位置設定.Get_All_Select_RowsValues();
            if (list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("未選取資料!");
                return;
            }
            string IP = list_value[0][(int)enum_亮燈位置設定.IP].ObjectToString();
            int IO_Index = list_value[0][(int)enum_亮燈位置設定.IO_Index].StringToInt32();
            bool flag = this.h_RFID_UI.Set_BlinkEnable(IP, 29030, IO_Index, false, 100);
            if (flag)
            {
                object[] value = list_value[0];
                value[(int)enum_亮燈位置設定.最後亮燈時間] = "1999/01/01";
                this.sqL_DataGridView_亮燈位置設定.SQL_ReplaceExtra(value, false);
                this.sqL_DataGridView_亮燈位置設定.ReplaceExtra(value, true);
            }
        }

        private void PlC_RJ_Button_藥藍資料庫_刪除_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_藥藍資料.Get_All_Select_RowsValues();
            if (list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("未選取資料!");
                return;
            }
            this.sqL_DataGridView_藥藍資料.SQL_DeleteExtra(list_value, false);
            this.sqL_DataGridView_藥藍資料.DeleteExtra(list_value, true);
            MyMessageBox.ShowDialog("刪除完成!");
        }
        private void PlC_RJ_Button_藥藍資料庫_刷新_MouseDownEvent(MouseEventArgs mevent)
        {
            this.sqL_DataGridView_藥藍資料.SQL_GetAllRows(true);
        }
    }
}
