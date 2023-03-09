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

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
namespace HRFID_WinForm
{
    public partial class Form1 : Form
    {
        private string FormText = "";

        #region DBConfigClass
        private const string DBConfigFileName = "DBConfig.txt";
        public DBConfigClass dBConfigClass = new DBConfigClass();
        public class DBConfigClass
        {
            private SQL_DataGridView.ConnentionClass dB_Basic = new SQL_DataGridView.ConnentionClass();

            public SQL_DataGridView.ConnentionClass DB_Basic { get => dB_Basic; set => dB_Basic = value; }
        }
        private void LoadDBConfig()
        {
            string jsonstr = MyFileStream.LoadFileAllText($".//{DBConfigFileName}");
            if (jsonstr.StringIsEmpty())
            {
                dBConfigClass = new DBConfigClass();
                dBConfigClass.DB_Basic.DataBaseName = "PLS01";
                dBConfigClass.DB_Basic.IP = "127.0.0.1";
                dBConfigClass.DB_Basic.UserName = "user";
                dBConfigClass.DB_Basic.Password = "66437068";
                dBConfigClass.DB_Basic.Port = 3306;
                dBConfigClass.DB_Basic.MySqlSslMode = MySql.Data.MySqlClient.MySqlSslMode.None;
                jsonstr = Basic.Net.JsonSerializationt<DBConfigClass>(dBConfigClass, true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{DBConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{DBConfigFileName}檔案失敗!");
                }
                MyMessageBox.ShowDialog($"未建立參數文件!請至子目錄設定{DBConfigFileName}");
                Application.Exit();
            }
            else
            {
                dBConfigClass = Basic.Net.JsonDeserializet<DBConfigClass>(jsonstr);

                jsonstr = Basic.Net.JsonSerializationt<DBConfigClass>(dBConfigClass, true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{DBConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{DBConfigFileName}檔案失敗!");
                }

            }


        }
        #endregion
        #region MyConfigClass
        private const string MyConfigFileName = "MyConfig.txt";
        public MyConfigClass myConfigClass = new MyConfigClass();
        public class MyConfigClass
        {

            private bool _線上更新 = true;



            public bool 線上更新 { get => _線上更新; set => _線上更新 = value; }
        }
        private void LoadMyConfig()
        {
            string jsonstr = MyFileStream.LoadFileAllText($".//{MyConfigFileName}");
            if (jsonstr.StringIsEmpty())
            {
                jsonstr = Basic.Net.JsonSerializationt<MyConfigClass>(new MyConfigClass(), true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{MyConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{MyConfigFileName}檔案失敗!");
                }
                MyMessageBox.ShowDialog($"未建立參數文件!請至子目錄設定{MyConfigFileName}");
                Application.Exit();
            }
            else
            {
                myConfigClass = Basic.Net.JsonDeserializet<MyConfigClass>(jsonstr);

                jsonstr = Basic.Net.JsonSerializationt<MyConfigClass>(myConfigClass, true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{MyConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{MyConfigFileName}檔案失敗!");
                }

            }

        }
        #endregion
        #region FtpConfigClass
        private const string FtpConfigFileName = "FtpConfig.txt";
        public FtpConfigClass ftpConfigClass = new FtpConfigClass();
        public class FtpConfigClass
        {
            private string fTP_Server = "";
            private string fTP_username = "";
            private string fTP_password = "";

            public string FTP_Server { get => fTP_Server; set => fTP_Server = value; }
            public string FTP_username { get => fTP_username; set => fTP_username = value; }
            public string FTP_password { get => fTP_password; set => fTP_password = value; }
        }
        private void LoadFtpConfig()
        {
            string jsonstr = MyFileStream.LoadFileAllText($".//{FtpConfigFileName}");
            if (jsonstr.StringIsEmpty())
            {
                jsonstr = Basic.Net.JsonSerializationt<FtpConfigClass>(new FtpConfigClass(), true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{FtpConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{FtpConfigFileName}檔案失敗!");
                }
                MyMessageBox.ShowDialog($"未建立參數文件!請至子目錄設定{FtpConfigFileName}");
                Application.Exit();
            }
            else
            {
                ftpConfigClass = Basic.Net.JsonDeserializet<FtpConfigClass>(jsonstr);

                jsonstr = Basic.Net.JsonSerializationt<FtpConfigClass>(ftpConfigClass, true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{FtpConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{FtpConfigFileName}檔案失敗!");
                }

            }
            if (myConfigClass.線上更新)
            {
                this.ftp_DounloadUI.FTP_Server = ftpConfigClass.FTP_Server;
                this.ftp_DounloadUI.Username = ftpConfigClass.FTP_username;
                this.ftp_DounloadUI.Password = ftpConfigClass.FTP_password;
                string updateVersion = this.ftp_DounloadUI.GetFileVersion();
                if (this.ftp_DounloadUI.CheckUpdate(this.ProductVersion, updateVersion))
                {
                    if (Basic.MyMessageBox.ShowDialog(string.Format("有新版本是否更新? (Ver : {0})", updateVersion), "Update", Basic.MyMessageBox.enum_BoxType.Asterisk, Basic.MyMessageBox.enum_Button.Confirm_Cancel) == DialogResult.Yes)
                    {
                        this.Invoke(new Action(delegate { this.Update(); }));
                    }
                }
            }

        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadDBConfig();
            this.LoadMyConfig();
            this.LoadFtpConfig();
            MyMessageBox.form = this.FindForm();
            Dialog_NumPannel.form = this.FindForm();
            MyMessageBox.音效 = false;
            this.Text += "  Ver" + this.ProductVersion;
            this.FormText = this.Text;
            this.WindowState = FormWindowState.Maximized;

            this.plC_UI_Init.Run(this.FindForm(), this.lowerMachine_Panel1);
            this.plC_UI_Init.UI_Finished_Event += PlC_UI_Init_UI_Finished_Event;
        }

        private void PlC_UI_Init_UI_Finished_Event()
        {
            this.plC_Button_最高權限.Bool = false;
            SQLUI.SQL_DataGridView.SQL_Set_Properties(dBConfigClass.DB_Basic.DataBaseName, dBConfigClass.DB_Basic.UserName, dBConfigClass.DB_Basic.Password, dBConfigClass.DB_Basic.IP, dBConfigClass.DB_Basic.Port, dBConfigClass.DB_Basic.MySqlSslMode, this.FindForm());

            PLC_UI_Init.Set_PLC_ScreenPage(this.panel_Main, this.plC_ScreenPage_Main);
            PLC_UI_Init.Set_PLC_ScreenPage(this.panel_設定, this.plC_ScreenPage_設定);
            PLC_UI_Init.Set_PLC_ScreenPage(this.panel_系統, this.plC_ScreenPage_系統);
            this.plC_ScreenPage_Main.TabChangeEvent += PlC_ScreenPage_Main_TabChangeEvent;

            this.Program_主畫面_Init();
            this.Program_系統_Init();
            this.Program_設定_Init();
            this.Fcunction_Init();

            this.WindowState = FormWindowState.Maximized;
        }

        private void PlC_ScreenPage_Main_TabChangeEvent(string PageText)
        {
            if (PageText == "主畫面")
            {
                str_主畫面_檢查感應_上次卡號 = "";

            }
            if(plC_ScreenPage_設定.PageText == "藥藍設定")
            {
                plC_Button_設定_藥藍設定_開始感應.Bool = false;
                str_設定_藥藍設定_檢查感應_上次卡號 = "";
                List<object[]> list_value = this.sqL_DataGridView_亮燈位置設定.SQL_GetAllRows(false);
                List<string> list_str = new List<string>();
                for (int i = 0; i < list_value.Count; i++)
                {
                    if (list_value[i][(int)enum_亮燈位置設定.IO_Index].StringToInt32() == -1) continue;
                   
                    string name = list_value[i][(int)enum_亮燈位置設定.名稱].ObjectToString();
                    list_str.Add(name);
                }
                this.comboBox_藥蘭設定_選擇窗口.DataSource = list_str;

                this.Invoke(new Action(delegate
                {
                    label_設定_藥藍設定_消磁感應區.Text = $"[等待感應]";
                    label_設定_藥藍設定_消磁感應區.ForeColor = Color.Black;
                    label_設定_藥藍設定_消磁感應區.BackColor = Color.GreenYellow;
                }));
            }
        }


        #region PLC_Method
        PLC_Device PLC_Device_Method = new PLC_Device("");
        PLC_Device PLC_Device_Method_OK = new PLC_Device("");
        Task Task_Method;
        MyTimer MyTimer_Method_結束延遲 = new MyTimer();
        int cnt_Program_Method = 65534;
        void sub_Program_Method()
        {
            if (cnt_Program_Method == 65534)
            {
                this.MyTimer_Method_結束延遲.StartTickTime(10000);
                PLC_Device_Method.SetComment("PLC_Method");
                PLC_Device_Method_OK.SetComment("PLC_Method_OK");
                PLC_Device_Method.Bool = false;
                cnt_Program_Method = 65535;
            }
            if (cnt_Program_Method == 65535) cnt_Program_Method = 1;
            if (cnt_Program_Method == 1) cnt_Program_Method_檢查按下(ref cnt_Program_Method);
            if (cnt_Program_Method == 2) cnt_Program_Method_初始化(ref cnt_Program_Method);
            if (cnt_Program_Method == 3) cnt_Program_Method = 65500;
            if (cnt_Program_Method > 1) cnt_Program_Method_檢查放開(ref cnt_Program_Method);

            if (cnt_Program_Method == 65500)
            {
                this.MyTimer_Method_結束延遲.TickStop();
                this.MyTimer_Method_結束延遲.StartTickTime(10000);
                PLC_Device_Method.Bool = false;
                PLC_Device_Method_OK.Bool = false;
                cnt_Program_Method = 65535;
            }
        }
        void cnt_Program_Method_檢查按下(ref int cnt)
        {
            if (PLC_Device_Method.Bool) cnt++;
        }
        void cnt_Program_Method_檢查放開(ref int cnt)
        {
            if (!PLC_Device_Method.Bool) cnt = 65500;
        }
        void cnt_Program_Method_初始化(ref int cnt)
        {
            if (this.MyTimer_Method_結束延遲.IsTimeOut())
            {
                if (Task_Method == null)
                {
                    Task_Method = new Task(new Action(delegate { }));
                }
                if (Task_Method.Status == TaskStatus.RanToCompletion)
                {
                    Task_Method = new Task(new Action(delegate { }));
                }
                if (Task_Method.Status == TaskStatus.Created)
                {
                    Task_Method.Start();
                }
                cnt++;
            }
        }







        #endregion
    }
}
