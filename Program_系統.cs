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
        private enum enum_亮燈位置設定
        {
            GUID,
            IP,
            IO_Index,
            名稱,
            滅燈延遲時間,
            最後亮燈時間,
        }
        private void Program_系統_Init()
        {
            this.h_RFID_UI.Init(dBConfigClass.DB_Basic);

            this.sqL_DataGridView_亮燈位置設定.Init();
            if (this.sqL_DataGridView_亮燈位置設定.SQL_IsTableCreat() == false) this.sqL_DataGridView_亮燈位置設定.SQL_CreateTable();
            this.sqL_DataGridView_亮燈位置設定.RowDoubleClickEvent += SqL_DataGridView_亮燈位置設定_RowDoubleClickEvent;

            this.plC_RJ_Button_亮燈位置設定_刷新.MouseDownEvent += PlC_RJ_Button_亮燈位置設定_刷新_MouseDownEvent;
            this.plC_RJ_Button_亮燈位置設定_登錄.MouseDownEvent += PlC_RJ_Button_亮燈位置設定_登錄_MouseDownEvent;
            this.plC_RJ_Button_亮燈位置設定_刪除.MouseDownEvent += PlC_RJ_Button_亮燈位置設定_刪除_MouseDownEvent;
            this.plC_RJ_Button_亮燈位置設定_亮燈.MouseDownEvent += PlC_RJ_Button_亮燈位置設定_亮燈_MouseDownEvent;
            this.plC_RJ_Button_亮燈位置設定_滅燈.MouseDownEvent += PlC_RJ_Button_亮燈位置設定_滅燈_MouseDownEvent;
            this.plC_ScreenPage_系統.TabChangeEvent += PlC_ScreenPage_系統_TabChangeEvent;
        }

    

        private void sub_Program_系統()
        {
  
        }

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
    }
}
