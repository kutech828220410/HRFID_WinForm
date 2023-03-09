
namespace HRFID_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.plC_RJ_ScreenButton_系統 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_工程模式 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_設定 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_主畫面 = new MyUI.PLC_RJ_ScreenButton();
            this.panel232 = new System.Windows.Forms.Panel();
            this.rJ_TextBox_登入者顏色 = new MyUI.RJ_TextBox();
            this.rJ_TextBox_登入者姓名 = new MyUI.RJ_TextBox();
            this.rJ_TextBox_登入者ID = new MyUI.RJ_TextBox();
            this.rJ_Lable51 = new MyUI.RJ_Lable();
            this.rJ_Lable52 = new MyUI.RJ_Lable();
            this.plC_RJ_Button_後台登入_登出 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_ScreenButton143 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_ScreenPage_Main = new MyUI.PLC_ScreenPage();
            this.主畫面 = new System.Windows.Forms.TabPage();
            this.設定 = new System.Windows.Forms.TabPage();
            this.panel_設定 = new System.Windows.Forms.Panel();
            this.plC_RJ_ScreenButton_儲位效期表 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_儲位總庫存表 = new MyUI.PLC_RJ_ScreenButton();
            this.工程模式 = new System.Windows.Forms.TabPage();
            this.系統 = new System.Windows.Forms.TabPage();
            this.plC_ScreenPage_系統 = new MyUI.PLC_ScreenPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plC_UI_Init = new MyUI.PLC_UI_Init();
            this.lowerMachine_Panel1 = new LadderUI.LowerMachine_Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.plC_RJ_Button_亮燈位置設定_滅燈 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_亮燈位置設定_亮燈 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_亮燈位置設定_刪除 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_亮燈位置設定_登錄 = new MyUI.PLC_RJ_Button();
            this.rJ_Pannel4 = new MyUI.RJ_Pannel();
            this.label1 = new System.Windows.Forms.Label();
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間 = new MyUI.PLC_NumBox();
            this.rJ_Lable3 = new MyUI.RJ_Lable();
            this.rJ_Pannel3 = new MyUI.RJ_Pannel();
            this.textBox_亮燈位置設定_名稱 = new MyUI.RJ_TextBox();
            this.rJ_Lable2 = new MyUI.RJ_Lable();
            this.rJ_Pannel1 = new MyUI.RJ_Pannel();
            this.textBox_亮燈位置設定_IO_Index = new MyUI.RJ_TextBox();
            this.rJ_Lable1 = new MyUI.RJ_Lable();
            this.rJ_Pannel2 = new MyUI.RJ_Pannel();
            this.textBox_亮燈位置設定_IP = new MyUI.RJ_TextBox();
            this.rJ_Lable17 = new MyUI.RJ_Lable();
            this.plC_RJ_Button_亮燈位置設定_刷新 = new MyUI.PLC_RJ_Button();
            this.sqL_DataGridView_亮燈位置設定 = new SQLUI.SQL_DataGridView();
            this.panel_系統 = new System.Windows.Forms.Panel();
            this.plC_RJ_ScreenButton3 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton1 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton2 = new MyUI.PLC_RJ_ScreenButton();
            this.h_RFID_UI = new H_Pannel_lib.H_RFID_UI();
            this.panel_Main.SuspendLayout();
            this.panel232.SuspendLayout();
            this.plC_ScreenPage_Main.SuspendLayout();
            this.設定.SuspendLayout();
            this.panel_設定.SuspendLayout();
            this.系統.SuspendLayout();
            this.plC_ScreenPage_系統.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.rJ_Pannel4.SuspendLayout();
            this.rJ_Pannel3.SuspendLayout();
            this.rJ_Pannel1.SuspendLayout();
            this.rJ_Pannel2.SuspendLayout();
            this.panel_系統.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_系統);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_工程模式);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_設定);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_主畫面);
            this.panel_Main.Controls.Add(this.panel232);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton143);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(240, 1041);
            this.panel_Main.TabIndex = 3;
            // 
            // plC_RJ_ScreenButton_系統
            // 
            this.plC_RJ_ScreenButton_系統.but_press = false;
            this.plC_RJ_ScreenButton_系統.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plC_RJ_ScreenButton_系統.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton_系統.IconSize = 40;
            this.plC_RJ_ScreenButton_系統.Location = new System.Drawing.Point(0, 822);
            this.plC_RJ_ScreenButton_系統.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_系統.Name = "plC_RJ_ScreenButton_系統";
            this.plC_RJ_ScreenButton_系統.OffBackColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_系統.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_系統.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_系統.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_系統.OffText = "系統";
            this.plC_RJ_ScreenButton_系統.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_系統.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_系統.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_系統.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_系統.OnText = "系統";
            this.plC_RJ_ScreenButton_系統.ShowIcon = false;
            this.plC_RJ_ScreenButton_系統.Size = new System.Drawing.Size(240, 65);
            this.plC_RJ_ScreenButton_系統.TabIndex = 122;
            this.plC_RJ_ScreenButton_系統.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_系統.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_系統.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_系統.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_系統.控制位址 = "D0";
            this.plC_RJ_ScreenButton_系統.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_系統.致能讀取位置 = "";
            this.plC_RJ_ScreenButton_系統.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_系統.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_系統.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_系統.音效 = true;
            this.plC_RJ_ScreenButton_系統.頁面名稱 = "系統";
            this.plC_RJ_ScreenButton_系統.頁面編號 = 0;
            this.plC_RJ_ScreenButton_系統.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_系統.顯示狀態 = false;
            this.plC_RJ_ScreenButton_系統.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton_工程模式
            // 
            this.plC_RJ_ScreenButton_工程模式.but_press = false;
            this.plC_RJ_ScreenButton_工程模式.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_工程模式.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.plC_RJ_ScreenButton_工程模式.IconSize = 40;
            this.plC_RJ_ScreenButton_工程模式.Location = new System.Drawing.Point(0, 130);
            this.plC_RJ_ScreenButton_工程模式.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_工程模式.Name = "plC_RJ_ScreenButton_工程模式";
            this.plC_RJ_ScreenButton_工程模式.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_工程模式.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_工程模式.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_工程模式.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_工程模式.OffText = "工程模式";
            this.plC_RJ_ScreenButton_工程模式.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_工程模式.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_工程模式.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_工程模式.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_工程模式.OnText = "工程模式";
            this.plC_RJ_ScreenButton_工程模式.ShowIcon = true;
            this.plC_RJ_ScreenButton_工程模式.Size = new System.Drawing.Size(240, 65);
            this.plC_RJ_ScreenButton_工程模式.TabIndex = 121;
            this.plC_RJ_ScreenButton_工程模式.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_工程模式.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_工程模式.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_工程模式.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_工程模式.控制位址 = "D0";
            this.plC_RJ_ScreenButton_工程模式.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_工程模式.致能讀取位置 = "";
            this.plC_RJ_ScreenButton_工程模式.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_工程模式.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_工程模式.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_工程模式.音效 = true;
            this.plC_RJ_ScreenButton_工程模式.頁面名稱 = "工程模式";
            this.plC_RJ_ScreenButton_工程模式.頁面編號 = 0;
            this.plC_RJ_ScreenButton_工程模式.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_工程模式.顯示狀態 = false;
            this.plC_RJ_ScreenButton_工程模式.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton_設定
            // 
            this.plC_RJ_ScreenButton_設定.but_press = false;
            this.plC_RJ_ScreenButton_設定.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_設定.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.plC_RJ_ScreenButton_設定.IconSize = 40;
            this.plC_RJ_ScreenButton_設定.Location = new System.Drawing.Point(0, 65);
            this.plC_RJ_ScreenButton_設定.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_設定.Name = "plC_RJ_ScreenButton_設定";
            this.plC_RJ_ScreenButton_設定.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_設定.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_設定.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_設定.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_設定.OffText = "設定";
            this.plC_RJ_ScreenButton_設定.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_設定.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_設定.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_設定.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_設定.OnText = "設定";
            this.plC_RJ_ScreenButton_設定.ShowIcon = true;
            this.plC_RJ_ScreenButton_設定.Size = new System.Drawing.Size(240, 65);
            this.plC_RJ_ScreenButton_設定.TabIndex = 111;
            this.plC_RJ_ScreenButton_設定.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_設定.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_設定.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_設定.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_設定.控制位址 = "D0";
            this.plC_RJ_ScreenButton_設定.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_設定.致能讀取位置 = "";
            this.plC_RJ_ScreenButton_設定.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_設定.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_設定.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_設定.音效 = true;
            this.plC_RJ_ScreenButton_設定.頁面名稱 = "設定";
            this.plC_RJ_ScreenButton_設定.頁面編號 = 0;
            this.plC_RJ_ScreenButton_設定.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_設定.顯示狀態 = false;
            this.plC_RJ_ScreenButton_設定.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton_主畫面
            // 
            this.plC_RJ_ScreenButton_主畫面.but_press = false;
            this.plC_RJ_ScreenButton_主畫面.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_主畫面.IconChar = FontAwesome.Sharp.IconChar.SolarPanel;
            this.plC_RJ_ScreenButton_主畫面.IconSize = 40;
            this.plC_RJ_ScreenButton_主畫面.Location = new System.Drawing.Point(0, 0);
            this.plC_RJ_ScreenButton_主畫面.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_主畫面.Name = "plC_RJ_ScreenButton_主畫面";
            this.plC_RJ_ScreenButton_主畫面.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_主畫面.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_主畫面.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_主畫面.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_主畫面.OffText = "主畫面";
            this.plC_RJ_ScreenButton_主畫面.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_主畫面.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_主畫面.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_主畫面.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_主畫面.OnText = "主畫面";
            this.plC_RJ_ScreenButton_主畫面.ShowIcon = true;
            this.plC_RJ_ScreenButton_主畫面.Size = new System.Drawing.Size(240, 65);
            this.plC_RJ_ScreenButton_主畫面.TabIndex = 94;
            this.plC_RJ_ScreenButton_主畫面.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_主畫面.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_主畫面.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_主畫面.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_主畫面.控制位址 = "D0";
            this.plC_RJ_ScreenButton_主畫面.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_主畫面.致能讀取位置 = "";
            this.plC_RJ_ScreenButton_主畫面.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_主畫面.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_主畫面.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_主畫面.音效 = true;
            this.plC_RJ_ScreenButton_主畫面.頁面名稱 = "主畫面";
            this.plC_RJ_ScreenButton_主畫面.頁面編號 = 0;
            this.plC_RJ_ScreenButton_主畫面.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_主畫面.顯示狀態 = false;
            this.plC_RJ_ScreenButton_主畫面.顯示讀取位置 = "";
            // 
            // panel232
            // 
            this.panel232.Controls.Add(this.rJ_TextBox_登入者顏色);
            this.panel232.Controls.Add(this.rJ_TextBox_登入者姓名);
            this.panel232.Controls.Add(this.rJ_TextBox_登入者ID);
            this.panel232.Controls.Add(this.rJ_Lable51);
            this.panel232.Controls.Add(this.rJ_Lable52);
            this.panel232.Controls.Add(this.plC_RJ_Button_後台登入_登出);
            this.panel232.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel232.Location = new System.Drawing.Point(0, 887);
            this.panel232.Name = "panel232";
            this.panel232.Size = new System.Drawing.Size(240, 73);
            this.panel232.TabIndex = 93;
            this.panel232.Visible = false;
            // 
            // rJ_TextBox_登入者顏色
            // 
            this.rJ_TextBox_登入者顏色.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_登入者顏色.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rJ_TextBox_登入者顏色.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_登入者顏色.BorderRadius = 2;
            this.rJ_TextBox_登入者顏色.BorderSize = 1;
            this.rJ_TextBox_登入者顏色.Enabled = false;
            this.rJ_TextBox_登入者顏色.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_登入者顏色.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_登入者顏色.Location = new System.Drawing.Point(138, 2);
            this.rJ_TextBox_登入者顏色.Multiline = false;
            this.rJ_TextBox_登入者顏色.Name = "rJ_TextBox_登入者顏色";
            this.rJ_TextBox_登入者顏色.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_登入者顏色.PassWordChar = false;
            this.rJ_TextBox_登入者顏色.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_登入者顏色.PlaceholderText = "";
            this.rJ_TextBox_登入者顏色.ShowTouchPannel = false;
            this.rJ_TextBox_登入者顏色.Size = new System.Drawing.Size(34, 30);
            this.rJ_TextBox_登入者顏色.TabIndex = 114;
            this.rJ_TextBox_登入者顏色.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_登入者顏色.Texts = "";
            this.rJ_TextBox_登入者顏色.UnderlineStyle = false;
            // 
            // rJ_TextBox_登入者姓名
            // 
            this.rJ_TextBox_登入者姓名.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_登入者姓名.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rJ_TextBox_登入者姓名.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_登入者姓名.BorderRadius = 2;
            this.rJ_TextBox_登入者姓名.BorderSize = 1;
            this.rJ_TextBox_登入者姓名.Enabled = false;
            this.rJ_TextBox_登入者姓名.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_登入者姓名.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_登入者姓名.Location = new System.Drawing.Point(64, 38);
            this.rJ_TextBox_登入者姓名.Multiline = false;
            this.rJ_TextBox_登入者姓名.Name = "rJ_TextBox_登入者姓名";
            this.rJ_TextBox_登入者姓名.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_登入者姓名.PassWordChar = false;
            this.rJ_TextBox_登入者姓名.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_登入者姓名.PlaceholderText = "";
            this.rJ_TextBox_登入者姓名.ShowTouchPannel = false;
            this.rJ_TextBox_登入者姓名.Size = new System.Drawing.Size(108, 30);
            this.rJ_TextBox_登入者姓名.TabIndex = 114;
            this.rJ_TextBox_登入者姓名.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_登入者姓名.Texts = "";
            this.rJ_TextBox_登入者姓名.UnderlineStyle = false;
            // 
            // rJ_TextBox_登入者ID
            // 
            this.rJ_TextBox_登入者ID.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_登入者ID.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rJ_TextBox_登入者ID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_登入者ID.BorderRadius = 2;
            this.rJ_TextBox_登入者ID.BorderSize = 1;
            this.rJ_TextBox_登入者ID.Enabled = false;
            this.rJ_TextBox_登入者ID.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_登入者ID.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_登入者ID.Location = new System.Drawing.Point(64, 2);
            this.rJ_TextBox_登入者ID.Multiline = false;
            this.rJ_TextBox_登入者ID.Name = "rJ_TextBox_登入者ID";
            this.rJ_TextBox_登入者ID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_登入者ID.PassWordChar = false;
            this.rJ_TextBox_登入者ID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_登入者ID.PlaceholderText = "";
            this.rJ_TextBox_登入者ID.ShowTouchPannel = false;
            this.rJ_TextBox_登入者ID.Size = new System.Drawing.Size(68, 30);
            this.rJ_TextBox_登入者ID.TabIndex = 113;
            this.rJ_TextBox_登入者ID.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_登入者ID.Texts = "";
            this.rJ_TextBox_登入者ID.UnderlineStyle = false;
            // 
            // rJ_Lable51
            // 
            this.rJ_Lable51.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_Lable51.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_Lable51.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable51.BorderRadius = 12;
            this.rJ_Lable51.BorderSize = 0;
            this.rJ_Lable51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable51.ForeColor = System.Drawing.Color.White;
            this.rJ_Lable51.Location = new System.Drawing.Point(4, 2);
            this.rJ_Lable51.Name = "rJ_Lable51";
            this.rJ_Lable51.Size = new System.Drawing.Size(58, 30);
            this.rJ_Lable51.TabIndex = 20;
            this.rJ_Lable51.Text = "ID";
            this.rJ_Lable51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable51.TextColor = System.Drawing.Color.White;
            // 
            // rJ_Lable52
            // 
            this.rJ_Lable52.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_Lable52.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_Lable52.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable52.BorderRadius = 12;
            this.rJ_Lable52.BorderSize = 0;
            this.rJ_Lable52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable52.ForeColor = System.Drawing.Color.White;
            this.rJ_Lable52.Location = new System.Drawing.Point(4, 38);
            this.rJ_Lable52.Name = "rJ_Lable52";
            this.rJ_Lable52.Size = new System.Drawing.Size(58, 30);
            this.rJ_Lable52.TabIndex = 22;
            this.rJ_Lable52.Text = "Name";
            this.rJ_Lable52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable52.TextColor = System.Drawing.Color.White;
            // 
            // plC_RJ_Button_後台登入_登出
            // 
            this.plC_RJ_Button_後台登入_登出.AutoResetState = false;
            this.plC_RJ_Button_後台登入_登出.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_後台登入_登出.Bool = false;
            this.plC_RJ_Button_後台登入_登出.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_後台登入_登出.BorderRadius = 5;
            this.plC_RJ_Button_後台登入_登出.BorderSize = 0;
            this.plC_RJ_Button_後台登入_登出.but_press = false;
            this.plC_RJ_Button_後台登入_登出.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_後台登入_登出.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_後台登入_登出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_後台登入_登出.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_後台登入_登出.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_後台登入_登出.Location = new System.Drawing.Point(178, 2);
            this.plC_RJ_Button_後台登入_登出.Name = "plC_RJ_Button_後台登入_登出";
            this.plC_RJ_Button_後台登入_登出.OFF_文字內容 = "登出";
            this.plC_RJ_Button_後台登入_登出.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_後台登入_登出.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_後台登入_登出.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_後台登入_登出.ON_文字內容 = "登出";
            this.plC_RJ_Button_後台登入_登出.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_後台登入_登出.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_後台登入_登出.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_後台登入_登出.Size = new System.Drawing.Size(49, 66);
            this.plC_RJ_Button_後台登入_登出.State = false;
            this.plC_RJ_Button_後台登入_登出.TabIndex = 23;
            this.plC_RJ_Button_後台登入_登出.Text = "登出";
            this.plC_RJ_Button_後台登入_登出.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_後台登入_登出.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_後台登入_登出.字型鎖住 = false;
            this.plC_RJ_Button_後台登入_登出.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_後台登入_登出.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_後台登入_登出.文字鎖住 = false;
            this.plC_RJ_Button_後台登入_登出.致能讀取位置 = "S4000";
            this.plC_RJ_Button_後台登入_登出.讀取位元反向 = false;
            this.plC_RJ_Button_後台登入_登出.讀寫鎖住 = false;
            this.plC_RJ_Button_後台登入_登出.音效 = true;
            this.plC_RJ_Button_後台登入_登出.顯示 = false;
            this.plC_RJ_Button_後台登入_登出.顯示狀態 = false;
            // 
            // plC_RJ_ScreenButton143
            // 
            this.plC_RJ_ScreenButton143.but_press = false;
            this.plC_RJ_ScreenButton143.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plC_RJ_ScreenButton143.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.plC_RJ_ScreenButton143.IconSize = 40;
            this.plC_RJ_ScreenButton143.Location = new System.Drawing.Point(0, 960);
            this.plC_RJ_ScreenButton143.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton143.Name = "plC_RJ_ScreenButton143";
            this.plC_RJ_ScreenButton143.OffBackColor = System.Drawing.Color.CornflowerBlue;
            this.plC_RJ_ScreenButton143.OffFont = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton143.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton143.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton143.OffText = "退出程式";
            this.plC_RJ_ScreenButton143.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton143.OnFont = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton143.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton143.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton143.OnText = "退出程式";
            this.plC_RJ_ScreenButton143.ShowIcon = true;
            this.plC_RJ_ScreenButton143.Size = new System.Drawing.Size(240, 81);
            this.plC_RJ_ScreenButton143.TabIndex = 92;
            this.plC_RJ_ScreenButton143.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton143.寫入位置註解 = "";
            this.plC_RJ_ScreenButton143.寫入元件位置 = "";
            this.plC_RJ_ScreenButton143.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton143.控制位址 = "D0";
            this.plC_RJ_ScreenButton143.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.退出程式;
            this.plC_RJ_ScreenButton143.致能讀取位置 = "";
            this.plC_RJ_ScreenButton143.讀取位元反向 = false;
            this.plC_RJ_ScreenButton143.讀取位置註解 = "";
            this.plC_RJ_ScreenButton143.讀取元件位置 = "";
            this.plC_RJ_ScreenButton143.音效 = true;
            this.plC_RJ_ScreenButton143.頁面名稱 = "";
            this.plC_RJ_ScreenButton143.頁面編號 = 0;
            this.plC_RJ_ScreenButton143.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton143.顯示狀態 = false;
            this.plC_RJ_ScreenButton143.顯示讀取位置 = "";
            // 
            // plC_ScreenPage_Main
            // 
            this.plC_ScreenPage_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.plC_ScreenPage_Main.BackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_Main.Controls.Add(this.主畫面);
            this.plC_ScreenPage_Main.Controls.Add(this.設定);
            this.plC_ScreenPage_Main.Controls.Add(this.工程模式);
            this.plC_ScreenPage_Main.Controls.Add(this.系統);
            this.plC_ScreenPage_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_ScreenPage_Main.ForekColor = System.Drawing.Color.Black;
            this.plC_ScreenPage_Main.ItemSize = new System.Drawing.Size(54, 21);
            this.plC_ScreenPage_Main.Location = new System.Drawing.Point(240, 0);
            this.plC_ScreenPage_Main.Name = "plC_ScreenPage_Main";
            this.plC_ScreenPage_Main.SelectedIndex = 0;
            this.plC_ScreenPage_Main.Size = new System.Drawing.Size(1664, 1041);
            this.plC_ScreenPage_Main.TabBackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_Main.TabIndex = 4;
            this.plC_ScreenPage_Main.顯示標籤列 = MyUI.PLC_ScreenPage.TabVisibleEnum.顯示;
            this.plC_ScreenPage_Main.顯示頁面 = 0;
            // 
            // 主畫面
            // 
            this.主畫面.BackColor = System.Drawing.Color.White;
            this.主畫面.Location = new System.Drawing.Point(4, 25);
            this.主畫面.Name = "主畫面";
            this.主畫面.Size = new System.Drawing.Size(1656, 1012);
            this.主畫面.TabIndex = 0;
            this.主畫面.Text = "主畫面";
            // 
            // 設定
            // 
            this.設定.BackColor = System.Drawing.Color.White;
            this.設定.Controls.Add(this.panel_設定);
            this.設定.Location = new System.Drawing.Point(4, 25);
            this.設定.Name = "設定";
            this.設定.Size = new System.Drawing.Size(1656, 1012);
            this.設定.TabIndex = 1;
            this.設定.Text = "設定";
            // 
            // panel_設定
            // 
            this.panel_設定.Controls.Add(this.plC_RJ_ScreenButton_儲位效期表);
            this.panel_設定.Controls.Add(this.plC_RJ_ScreenButton_儲位總庫存表);
            this.panel_設定.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_設定.Location = new System.Drawing.Point(0, 0);
            this.panel_設定.Name = "panel_設定";
            this.panel_設定.Size = new System.Drawing.Size(1656, 51);
            this.panel_設定.TabIndex = 115;
            // 
            // plC_RJ_ScreenButton_儲位效期表
            // 
            this.plC_RJ_ScreenButton_儲位效期表.but_press = false;
            this.plC_RJ_ScreenButton_儲位效期表.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton_儲位效期表.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton_儲位效期表.IconSize = 32;
            this.plC_RJ_ScreenButton_儲位效期表.Location = new System.Drawing.Point(172, 0);
            this.plC_RJ_ScreenButton_儲位效期表.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_儲位效期表.Name = "plC_RJ_ScreenButton_儲位效期表";
            this.plC_RJ_ScreenButton_儲位效期表.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton_儲位效期表.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton_儲位效期表.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_儲位效期表.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_儲位效期表.OffText = "儲位效期表";
            this.plC_RJ_ScreenButton_儲位效期表.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton_儲位效期表.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton_儲位效期表.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_儲位效期表.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_儲位效期表.OnText = "儲位效期表";
            this.plC_RJ_ScreenButton_儲位效期表.ShowIcon = false;
            this.plC_RJ_ScreenButton_儲位效期表.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton_儲位效期表.TabIndex = 9;
            this.plC_RJ_ScreenButton_儲位效期表.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_儲位效期表.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_儲位效期表.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_儲位效期表.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_儲位效期表.控制位址 = "D0";
            this.plC_RJ_ScreenButton_儲位效期表.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_儲位效期表.致能讀取位置 = "";
            this.plC_RJ_ScreenButton_儲位效期表.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_儲位效期表.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_儲位效期表.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_儲位效期表.音效 = true;
            this.plC_RJ_ScreenButton_儲位效期表.頁面名稱 = "儲位效期表";
            this.plC_RJ_ScreenButton_儲位效期表.頁面編號 = 0;
            this.plC_RJ_ScreenButton_儲位效期表.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_儲位效期表.顯示狀態 = false;
            this.plC_RJ_ScreenButton_儲位效期表.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton_儲位總庫存表
            // 
            this.plC_RJ_ScreenButton_儲位總庫存表.but_press = false;
            this.plC_RJ_ScreenButton_儲位總庫存表.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton_儲位總庫存表.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton_儲位總庫存表.IconSize = 32;
            this.plC_RJ_ScreenButton_儲位總庫存表.Location = new System.Drawing.Point(0, 0);
            this.plC_RJ_ScreenButton_儲位總庫存表.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_儲位總庫存表.Name = "plC_RJ_ScreenButton_儲位總庫存表";
            this.plC_RJ_ScreenButton_儲位總庫存表.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton_儲位總庫存表.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton_儲位總庫存表.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_儲位總庫存表.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_儲位總庫存表.OffText = "亮燈位置設定";
            this.plC_RJ_ScreenButton_儲位總庫存表.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton_儲位總庫存表.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton_儲位總庫存表.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_儲位總庫存表.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_儲位總庫存表.OnText = "亮燈位置設定";
            this.plC_RJ_ScreenButton_儲位總庫存表.ShowIcon = false;
            this.plC_RJ_ScreenButton_儲位總庫存表.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton_儲位總庫存表.TabIndex = 8;
            this.plC_RJ_ScreenButton_儲位總庫存表.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_儲位總庫存表.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_儲位總庫存表.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_儲位總庫存表.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_儲位總庫存表.控制位址 = "D0";
            this.plC_RJ_ScreenButton_儲位總庫存表.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_儲位總庫存表.致能讀取位置 = "";
            this.plC_RJ_ScreenButton_儲位總庫存表.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_儲位總庫存表.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_儲位總庫存表.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_儲位總庫存表.音效 = true;
            this.plC_RJ_ScreenButton_儲位總庫存表.頁面名稱 = "亮燈位置設定";
            this.plC_RJ_ScreenButton_儲位總庫存表.頁面編號 = 0;
            this.plC_RJ_ScreenButton_儲位總庫存表.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_儲位總庫存表.顯示狀態 = false;
            this.plC_RJ_ScreenButton_儲位總庫存表.顯示讀取位置 = "";
            // 
            // 工程模式
            // 
            this.工程模式.BackColor = System.Drawing.Color.White;
            this.工程模式.Location = new System.Drawing.Point(4, 25);
            this.工程模式.Name = "工程模式";
            this.工程模式.Size = new System.Drawing.Size(1656, 1012);
            this.工程模式.TabIndex = 3;
            this.工程模式.Text = "工程模式";
            // 
            // 系統
            // 
            this.系統.BackColor = System.Drawing.Color.White;
            this.系統.Controls.Add(this.plC_ScreenPage_系統);
            this.系統.Controls.Add(this.panel_系統);
            this.系統.Location = new System.Drawing.Point(4, 25);
            this.系統.Name = "系統";
            this.系統.Size = new System.Drawing.Size(1656, 1012);
            this.系統.TabIndex = 2;
            this.系統.Text = "系統";
            // 
            // plC_ScreenPage_系統
            // 
            this.plC_ScreenPage_系統.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.plC_ScreenPage_系統.BackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_系統.Controls.Add(this.tabPage1);
            this.plC_ScreenPage_系統.Controls.Add(this.tabPage2);
            this.plC_ScreenPage_系統.Controls.Add(this.tabPage3);
            this.plC_ScreenPage_系統.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_ScreenPage_系統.ForekColor = System.Drawing.Color.Black;
            this.plC_ScreenPage_系統.ItemSize = new System.Drawing.Size(54, 21);
            this.plC_ScreenPage_系統.Location = new System.Drawing.Point(0, 51);
            this.plC_ScreenPage_系統.Name = "plC_ScreenPage_系統";
            this.plC_ScreenPage_系統.SelectedIndex = 0;
            this.plC_ScreenPage_系統.Size = new System.Drawing.Size(1656, 961);
            this.plC_ScreenPage_系統.TabBackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_系統.TabIndex = 117;
            this.plC_ScreenPage_系統.顯示標籤列 = MyUI.PLC_ScreenPage.TabVisibleEnum.顯示;
            this.plC_ScreenPage_系統.顯示頁面 = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.plC_UI_Init);
            this.tabPage1.Controls.Add(this.lowerMachine_Panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1648, 932);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "系統";
            // 
            // plC_UI_Init
            // 
            this.plC_UI_Init.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plC_UI_Init.Location = new System.Drawing.Point(881, 6);
            this.plC_UI_Init.Name = "plC_UI_Init";
            this.plC_UI_Init.Size = new System.Drawing.Size(72, 25);
            this.plC_UI_Init.TabIndex = 3;
            this.plC_UI_Init.光道視覺元件初始化 = false;
            this.plC_UI_Init.全螢幕顯示 = false;
            this.plC_UI_Init.掃描速度 = 10;
            this.plC_UI_Init.起始畫面標題內容 = "鴻森整合機電有限公司";
            this.plC_UI_Init.起始畫面標題字體 = new System.Drawing.Font("標楷體", 20F, System.Drawing.FontStyle.Bold);
            this.plC_UI_Init.起始畫面背景 = ((System.Drawing.Image)(resources.GetObject("plC_UI_Init.起始畫面背景")));
            this.plC_UI_Init.起始畫面顯示 = false;
            this.plC_UI_Init.邁得威視元件初始化 = false;
            this.plC_UI_Init.開機延遲 = 0;
            this.plC_UI_Init.音效 = false;
            // 
            // lowerMachine_Panel1
            // 
            this.lowerMachine_Panel1.Location = new System.Drawing.Point(6, 6);
            this.lowerMachine_Panel1.Name = "lowerMachine_Panel1";
            this.lowerMachine_Panel1.Size = new System.Drawing.Size(869, 565);
            this.lowerMachine_Panel1.TabIndex = 2;
            this.lowerMachine_Panel1.掃描速度 = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.h_RFID_UI);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1648, 932);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "H_RFID";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.plC_RJ_Button_亮燈位置設定_滅燈);
            this.tabPage3.Controls.Add(this.plC_RJ_Button_亮燈位置設定_亮燈);
            this.tabPage3.Controls.Add(this.plC_RJ_Button_亮燈位置設定_刪除);
            this.tabPage3.Controls.Add(this.plC_RJ_Button_亮燈位置設定_登錄);
            this.tabPage3.Controls.Add(this.rJ_Pannel4);
            this.tabPage3.Controls.Add(this.rJ_Pannel3);
            this.tabPage3.Controls.Add(this.rJ_Pannel1);
            this.tabPage3.Controls.Add(this.rJ_Pannel2);
            this.tabPage3.Controls.Add(this.plC_RJ_Button_亮燈位置設定_刷新);
            this.tabPage3.Controls.Add(this.sqL_DataGridView_亮燈位置設定);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1648, 932);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "亮燈位置設定";
            // 
            // plC_RJ_Button_亮燈位置設定_滅燈
            // 
            this.plC_RJ_Button_亮燈位置設定_滅燈.AutoResetState = false;
            this.plC_RJ_Button_亮燈位置設定_滅燈.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_亮燈位置設定_滅燈.Bool = false;
            this.plC_RJ_Button_亮燈位置設定_滅燈.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_亮燈位置設定_滅燈.BorderRadius = 5;
            this.plC_RJ_Button_亮燈位置設定_滅燈.BorderSize = 0;
            this.plC_RJ_Button_亮燈位置設定_滅燈.but_press = false;
            this.plC_RJ_Button_亮燈位置設定_滅燈.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_亮燈位置設定_滅燈.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_亮燈位置設定_滅燈.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_亮燈位置設定_滅燈.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_滅燈.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_亮燈位置設定_滅燈.Location = new System.Drawing.Point(1365, 89);
            this.plC_RJ_Button_亮燈位置設定_滅燈.Name = "plC_RJ_Button_亮燈位置設定_滅燈";
            this.plC_RJ_Button_亮燈位置設定_滅燈.OFF_文字內容 = "滅燈";
            this.plC_RJ_Button_亮燈位置設定_滅燈.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_滅燈.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_亮燈位置設定_滅燈.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_亮燈位置設定_滅燈.ON_文字內容 = "滅燈";
            this.plC_RJ_Button_亮燈位置設定_滅燈.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_滅燈.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_亮燈位置設定_滅燈.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_亮燈位置設定_滅燈.Size = new System.Drawing.Size(166, 67);
            this.plC_RJ_Button_亮燈位置設定_滅燈.State = false;
            this.plC_RJ_Button_亮燈位置設定_滅燈.TabIndex = 137;
            this.plC_RJ_Button_亮燈位置設定_滅燈.Text = "滅燈";
            this.plC_RJ_Button_亮燈位置設定_滅燈.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_亮燈位置設定_滅燈.Texts = "滅燈";
            this.plC_RJ_Button_亮燈位置設定_滅燈.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_亮燈位置設定_滅燈.字型鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_滅燈.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_亮燈位置設定_滅燈.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_亮燈位置設定_滅燈.文字鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_滅燈.讀取位元反向 = false;
            this.plC_RJ_Button_亮燈位置設定_滅燈.讀寫鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_滅燈.音效 = true;
            this.plC_RJ_Button_亮燈位置設定_滅燈.顯示 = false;
            this.plC_RJ_Button_亮燈位置設定_滅燈.顯示狀態 = false;
            // 
            // plC_RJ_Button_亮燈位置設定_亮燈
            // 
            this.plC_RJ_Button_亮燈位置設定_亮燈.AutoResetState = false;
            this.plC_RJ_Button_亮燈位置設定_亮燈.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_亮燈位置設定_亮燈.Bool = false;
            this.plC_RJ_Button_亮燈位置設定_亮燈.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_亮燈位置設定_亮燈.BorderRadius = 5;
            this.plC_RJ_Button_亮燈位置設定_亮燈.BorderSize = 0;
            this.plC_RJ_Button_亮燈位置設定_亮燈.but_press = false;
            this.plC_RJ_Button_亮燈位置設定_亮燈.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_亮燈位置設定_亮燈.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_亮燈位置設定_亮燈.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_亮燈位置設定_亮燈.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_亮燈.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_亮燈位置設定_亮燈.Location = new System.Drawing.Point(1365, 16);
            this.plC_RJ_Button_亮燈位置設定_亮燈.Name = "plC_RJ_Button_亮燈位置設定_亮燈";
            this.plC_RJ_Button_亮燈位置設定_亮燈.OFF_文字內容 = "亮燈";
            this.plC_RJ_Button_亮燈位置設定_亮燈.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_亮燈.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_亮燈位置設定_亮燈.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_亮燈位置設定_亮燈.ON_文字內容 = "亮燈";
            this.plC_RJ_Button_亮燈位置設定_亮燈.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_亮燈.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_亮燈位置設定_亮燈.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_亮燈位置設定_亮燈.Size = new System.Drawing.Size(166, 67);
            this.plC_RJ_Button_亮燈位置設定_亮燈.State = false;
            this.plC_RJ_Button_亮燈位置設定_亮燈.TabIndex = 136;
            this.plC_RJ_Button_亮燈位置設定_亮燈.Text = "亮燈";
            this.plC_RJ_Button_亮燈位置設定_亮燈.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_亮燈位置設定_亮燈.Texts = "亮燈";
            this.plC_RJ_Button_亮燈位置設定_亮燈.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_亮燈位置設定_亮燈.字型鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_亮燈.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_亮燈位置設定_亮燈.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_亮燈位置設定_亮燈.文字鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_亮燈.讀取位元反向 = false;
            this.plC_RJ_Button_亮燈位置設定_亮燈.讀寫鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_亮燈.音效 = true;
            this.plC_RJ_Button_亮燈位置設定_亮燈.顯示 = false;
            this.plC_RJ_Button_亮燈位置設定_亮燈.顯示狀態 = false;
            // 
            // plC_RJ_Button_亮燈位置設定_刪除
            // 
            this.plC_RJ_Button_亮燈位置設定_刪除.AutoResetState = false;
            this.plC_RJ_Button_亮燈位置設定_刪除.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_亮燈位置設定_刪除.Bool = false;
            this.plC_RJ_Button_亮燈位置設定_刪除.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_亮燈位置設定_刪除.BorderRadius = 5;
            this.plC_RJ_Button_亮燈位置設定_刪除.BorderSize = 0;
            this.plC_RJ_Button_亮燈位置設定_刪除.but_press = false;
            this.plC_RJ_Button_亮燈位置設定_刪除.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_亮燈位置設定_刪除.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_亮燈位置設定_刪除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_亮燈位置設定_刪除.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_刪除.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_亮燈位置設定_刪除.Location = new System.Drawing.Point(1178, 162);
            this.plC_RJ_Button_亮燈位置設定_刪除.Name = "plC_RJ_Button_亮燈位置設定_刪除";
            this.plC_RJ_Button_亮燈位置設定_刪除.OFF_文字內容 = "刪除";
            this.plC_RJ_Button_亮燈位置設定_刪除.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_刪除.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_亮燈位置設定_刪除.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_亮燈位置設定_刪除.ON_文字內容 = "刪除";
            this.plC_RJ_Button_亮燈位置設定_刪除.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_刪除.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_亮燈位置設定_刪除.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_亮燈位置設定_刪除.Size = new System.Drawing.Size(166, 67);
            this.plC_RJ_Button_亮燈位置設定_刪除.State = false;
            this.plC_RJ_Button_亮燈位置設定_刪除.TabIndex = 135;
            this.plC_RJ_Button_亮燈位置設定_刪除.Text = "刪除";
            this.plC_RJ_Button_亮燈位置設定_刪除.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_亮燈位置設定_刪除.Texts = "刪除";
            this.plC_RJ_Button_亮燈位置設定_刪除.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_亮燈位置設定_刪除.字型鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_刪除.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_亮燈位置設定_刪除.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_亮燈位置設定_刪除.文字鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_刪除.讀取位元反向 = false;
            this.plC_RJ_Button_亮燈位置設定_刪除.讀寫鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_刪除.音效 = true;
            this.plC_RJ_Button_亮燈位置設定_刪除.顯示 = false;
            this.plC_RJ_Button_亮燈位置設定_刪除.顯示狀態 = false;
            // 
            // plC_RJ_Button_亮燈位置設定_登錄
            // 
            this.plC_RJ_Button_亮燈位置設定_登錄.AutoResetState = false;
            this.plC_RJ_Button_亮燈位置設定_登錄.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_亮燈位置設定_登錄.Bool = false;
            this.plC_RJ_Button_亮燈位置設定_登錄.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_亮燈位置設定_登錄.BorderRadius = 5;
            this.plC_RJ_Button_亮燈位置設定_登錄.BorderSize = 0;
            this.plC_RJ_Button_亮燈位置設定_登錄.but_press = false;
            this.plC_RJ_Button_亮燈位置設定_登錄.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_亮燈位置設定_登錄.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_亮燈位置設定_登錄.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_亮燈位置設定_登錄.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_登錄.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_亮燈位置設定_登錄.Location = new System.Drawing.Point(1178, 89);
            this.plC_RJ_Button_亮燈位置設定_登錄.Name = "plC_RJ_Button_亮燈位置設定_登錄";
            this.plC_RJ_Button_亮燈位置設定_登錄.OFF_文字內容 = "登錄";
            this.plC_RJ_Button_亮燈位置設定_登錄.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_登錄.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_亮燈位置設定_登錄.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_亮燈位置設定_登錄.ON_文字內容 = "登錄";
            this.plC_RJ_Button_亮燈位置設定_登錄.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_登錄.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_亮燈位置設定_登錄.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_亮燈位置設定_登錄.Size = new System.Drawing.Size(166, 67);
            this.plC_RJ_Button_亮燈位置設定_登錄.State = false;
            this.plC_RJ_Button_亮燈位置設定_登錄.TabIndex = 134;
            this.plC_RJ_Button_亮燈位置設定_登錄.Text = "登錄";
            this.plC_RJ_Button_亮燈位置設定_登錄.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_亮燈位置設定_登錄.Texts = "登錄";
            this.plC_RJ_Button_亮燈位置設定_登錄.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_亮燈位置設定_登錄.字型鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_登錄.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_亮燈位置設定_登錄.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_亮燈位置設定_登錄.文字鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_登錄.讀取位元反向 = false;
            this.plC_RJ_Button_亮燈位置設定_登錄.讀寫鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_登錄.音效 = true;
            this.plC_RJ_Button_亮燈位置設定_登錄.顯示 = false;
            this.plC_RJ_Button_亮燈位置設定_登錄.顯示狀態 = false;
            // 
            // rJ_Pannel4
            // 
            this.rJ_Pannel4.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel4.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel4.BorderRadius = 10;
            this.rJ_Pannel4.BorderSize = 2;
            this.rJ_Pannel4.Controls.Add(this.label1);
            this.rJ_Pannel4.Controls.Add(this.plC_NumBox_亮燈位置設定_滅燈延遲時間);
            this.rJ_Pannel4.Controls.Add(this.rJ_Lable3);
            this.rJ_Pannel4.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel4.IsSelected = false;
            this.rJ_Pannel4.Location = new System.Drawing.Point(773, 211);
            this.rJ_Pannel4.Name = "rJ_Pannel4";
            this.rJ_Pannel4.Size = new System.Drawing.Size(384, 59);
            this.rJ_Pannel4.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "秒";
            // 
            // plC_NumBox_亮燈位置設定_滅燈延遲時間
            // 
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.Location = new System.Drawing.Point(149, 14);
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.mBackColor = System.Drawing.SystemColors.Window;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.mForeColor = System.Drawing.SystemColors.WindowText;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.Name = "plC_NumBox_亮燈位置設定_滅燈延遲時間";
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.ReadOnly = false;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.Size = new System.Drawing.Size(70, 31);
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.TabIndex = 3;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.Value = 0;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.字元長度 = MyUI.PLC_NumBox.WordLengthEnum.單字元;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.密碼欄位 = false;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.小數點位置 = 0;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.微調數值 = 1;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.音效 = true;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.顯示微調按鈕 = false;
            this.plC_NumBox_亮燈位置設定_滅燈延遲時間.顯示螢幕小鍵盤 = true;
            // 
            // rJ_Lable3
            // 
            this.rJ_Lable3.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable3.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable3.BorderRadius = 8;
            this.rJ_Lable3.BorderSize = 0;
            this.rJ_Lable3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable3.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable3.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable3.Name = "rJ_Lable3";
            this.rJ_Lable3.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable3.TabIndex = 2;
            this.rJ_Lable3.Text = "滅燈延遲時間";
            this.rJ_Lable3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable3.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Pannel3
            // 
            this.rJ_Pannel3.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel3.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel3.BorderRadius = 10;
            this.rJ_Pannel3.BorderSize = 2;
            this.rJ_Pannel3.Controls.Add(this.textBox_亮燈位置設定_名稱);
            this.rJ_Pannel3.Controls.Add(this.rJ_Lable2);
            this.rJ_Pannel3.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel3.IsSelected = false;
            this.rJ_Pannel3.Location = new System.Drawing.Point(773, 146);
            this.rJ_Pannel3.Name = "rJ_Pannel3";
            this.rJ_Pannel3.Size = new System.Drawing.Size(384, 59);
            this.rJ_Pannel3.TabIndex = 132;
            // 
            // textBox_亮燈位置設定_名稱
            // 
            this.textBox_亮燈位置設定_名稱.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_亮燈位置設定_名稱.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_亮燈位置設定_名稱.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_亮燈位置設定_名稱.BorderRadius = 5;
            this.textBox_亮燈位置設定_名稱.BorderSize = 2;
            this.textBox_亮燈位置設定_名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_亮燈位置設定_名稱.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_亮燈位置設定_名稱.Location = new System.Drawing.Point(149, 12);
            this.textBox_亮燈位置設定_名稱.Multiline = false;
            this.textBox_亮燈位置設定_名稱.Name = "textBox_亮燈位置設定_名稱";
            this.textBox_亮燈位置設定_名稱.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_亮燈位置設定_名稱.PassWordChar = false;
            this.textBox_亮燈位置設定_名稱.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_亮燈位置設定_名稱.PlaceholderText = "";
            this.textBox_亮燈位置設定_名稱.ShowTouchPannel = false;
            this.textBox_亮燈位置設定_名稱.Size = new System.Drawing.Size(217, 36);
            this.textBox_亮燈位置設定_名稱.TabIndex = 3;
            this.textBox_亮燈位置設定_名稱.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_亮燈位置設定_名稱.Texts = "";
            this.textBox_亮燈位置設定_名稱.UnderlineStyle = false;
            // 
            // rJ_Lable2
            // 
            this.rJ_Lable2.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable2.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable2.BorderRadius = 8;
            this.rJ_Lable2.BorderSize = 0;
            this.rJ_Lable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable2.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable2.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable2.Name = "rJ_Lable2";
            this.rJ_Lable2.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable2.TabIndex = 2;
            this.rJ_Lable2.Text = "名稱";
            this.rJ_Lable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable2.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Pannel1
            // 
            this.rJ_Pannel1.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel1.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel1.BorderRadius = 10;
            this.rJ_Pannel1.BorderSize = 2;
            this.rJ_Pannel1.Controls.Add(this.textBox_亮燈位置設定_IO_Index);
            this.rJ_Pannel1.Controls.Add(this.rJ_Lable1);
            this.rJ_Pannel1.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel1.IsSelected = false;
            this.rJ_Pannel1.Location = new System.Drawing.Point(773, 81);
            this.rJ_Pannel1.Name = "rJ_Pannel1";
            this.rJ_Pannel1.Size = new System.Drawing.Size(384, 59);
            this.rJ_Pannel1.TabIndex = 131;
            // 
            // textBox_亮燈位置設定_IO_Index
            // 
            this.textBox_亮燈位置設定_IO_Index.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_亮燈位置設定_IO_Index.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_亮燈位置設定_IO_Index.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_亮燈位置設定_IO_Index.BorderRadius = 5;
            this.textBox_亮燈位置設定_IO_Index.BorderSize = 2;
            this.textBox_亮燈位置設定_IO_Index.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_亮燈位置設定_IO_Index.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_亮燈位置設定_IO_Index.Location = new System.Drawing.Point(149, 12);
            this.textBox_亮燈位置設定_IO_Index.Multiline = false;
            this.textBox_亮燈位置設定_IO_Index.Name = "textBox_亮燈位置設定_IO_Index";
            this.textBox_亮燈位置設定_IO_Index.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_亮燈位置設定_IO_Index.PassWordChar = false;
            this.textBox_亮燈位置設定_IO_Index.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_亮燈位置設定_IO_Index.PlaceholderText = "";
            this.textBox_亮燈位置設定_IO_Index.ShowTouchPannel = false;
            this.textBox_亮燈位置設定_IO_Index.Size = new System.Drawing.Size(217, 36);
            this.textBox_亮燈位置設定_IO_Index.TabIndex = 3;
            this.textBox_亮燈位置設定_IO_Index.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_亮燈位置設定_IO_Index.Texts = "";
            this.textBox_亮燈位置設定_IO_Index.UnderlineStyle = false;
            // 
            // rJ_Lable1
            // 
            this.rJ_Lable1.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable1.BorderRadius = 8;
            this.rJ_Lable1.BorderSize = 0;
            this.rJ_Lable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable1.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable1.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable1.Name = "rJ_Lable1";
            this.rJ_Lable1.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable1.TabIndex = 2;
            this.rJ_Lable1.Text = "IO_Index";
            this.rJ_Lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable1.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Pannel2
            // 
            this.rJ_Pannel2.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel2.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel2.BorderRadius = 10;
            this.rJ_Pannel2.BorderSize = 2;
            this.rJ_Pannel2.Controls.Add(this.textBox_亮燈位置設定_IP);
            this.rJ_Pannel2.Controls.Add(this.rJ_Lable17);
            this.rJ_Pannel2.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel2.IsSelected = false;
            this.rJ_Pannel2.Location = new System.Drawing.Point(773, 16);
            this.rJ_Pannel2.Name = "rJ_Pannel2";
            this.rJ_Pannel2.Size = new System.Drawing.Size(384, 59);
            this.rJ_Pannel2.TabIndex = 130;
            // 
            // textBox_亮燈位置設定_IP
            // 
            this.textBox_亮燈位置設定_IP.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_亮燈位置設定_IP.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_亮燈位置設定_IP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_亮燈位置設定_IP.BorderRadius = 5;
            this.textBox_亮燈位置設定_IP.BorderSize = 2;
            this.textBox_亮燈位置設定_IP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_亮燈位置設定_IP.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_亮燈位置設定_IP.Location = new System.Drawing.Point(149, 12);
            this.textBox_亮燈位置設定_IP.Multiline = false;
            this.textBox_亮燈位置設定_IP.Name = "textBox_亮燈位置設定_IP";
            this.textBox_亮燈位置設定_IP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_亮燈位置設定_IP.PassWordChar = false;
            this.textBox_亮燈位置設定_IP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_亮燈位置設定_IP.PlaceholderText = "";
            this.textBox_亮燈位置設定_IP.ShowTouchPannel = false;
            this.textBox_亮燈位置設定_IP.Size = new System.Drawing.Size(217, 36);
            this.textBox_亮燈位置設定_IP.TabIndex = 3;
            this.textBox_亮燈位置設定_IP.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_亮燈位置設定_IP.Texts = "";
            this.textBox_亮燈位置設定_IP.UnderlineStyle = false;
            // 
            // rJ_Lable17
            // 
            this.rJ_Lable17.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable17.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable17.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable17.BorderRadius = 8;
            this.rJ_Lable17.BorderSize = 0;
            this.rJ_Lable17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable17.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable17.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable17.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable17.Name = "rJ_Lable17";
            this.rJ_Lable17.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable17.TabIndex = 2;
            this.rJ_Lable17.Text = "IP";
            this.rJ_Lable17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable17.TextColor = System.Drawing.Color.Black;
            // 
            // plC_RJ_Button_亮燈位置設定_刷新
            // 
            this.plC_RJ_Button_亮燈位置設定_刷新.AutoResetState = false;
            this.plC_RJ_Button_亮燈位置設定_刷新.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_亮燈位置設定_刷新.Bool = false;
            this.plC_RJ_Button_亮燈位置設定_刷新.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_亮燈位置設定_刷新.BorderRadius = 5;
            this.plC_RJ_Button_亮燈位置設定_刷新.BorderSize = 0;
            this.plC_RJ_Button_亮燈位置設定_刷新.but_press = false;
            this.plC_RJ_Button_亮燈位置設定_刷新.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_亮燈位置設定_刷新.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_亮燈位置設定_刷新.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_亮燈位置設定_刷新.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_刷新.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_亮燈位置設定_刷新.Location = new System.Drawing.Point(1178, 16);
            this.plC_RJ_Button_亮燈位置設定_刷新.Name = "plC_RJ_Button_亮燈位置設定_刷新";
            this.plC_RJ_Button_亮燈位置設定_刷新.OFF_文字內容 = "刷新";
            this.plC_RJ_Button_亮燈位置設定_刷新.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_刷新.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_亮燈位置設定_刷新.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_亮燈位置設定_刷新.ON_文字內容 = "刷新";
            this.plC_RJ_Button_亮燈位置設定_刷新.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_亮燈位置設定_刷新.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_亮燈位置設定_刷新.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_亮燈位置設定_刷新.Size = new System.Drawing.Size(166, 67);
            this.plC_RJ_Button_亮燈位置設定_刷新.State = false;
            this.plC_RJ_Button_亮燈位置設定_刷新.TabIndex = 129;
            this.plC_RJ_Button_亮燈位置設定_刷新.Text = "刷新";
            this.plC_RJ_Button_亮燈位置設定_刷新.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_亮燈位置設定_刷新.Texts = "刷新";
            this.plC_RJ_Button_亮燈位置設定_刷新.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_亮燈位置設定_刷新.字型鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_刷新.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_亮燈位置設定_刷新.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_亮燈位置設定_刷新.文字鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_刷新.讀取位元反向 = false;
            this.plC_RJ_Button_亮燈位置設定_刷新.讀寫鎖住 = false;
            this.plC_RJ_Button_亮燈位置設定_刷新.音效 = true;
            this.plC_RJ_Button_亮燈位置設定_刷新.顯示 = false;
            this.plC_RJ_Button_亮燈位置設定_刷新.顯示狀態 = false;
            // 
            // sqL_DataGridView_亮燈位置設定
            // 
            this.sqL_DataGridView_亮燈位置設定.AutoSelectToDeep = false;
            this.sqL_DataGridView_亮燈位置設定.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_亮燈位置設定.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_亮燈位置設定.BorderRadius = 0;
            this.sqL_DataGridView_亮燈位置設定.BorderSize = 2;
            this.sqL_DataGridView_亮燈位置設定.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_亮燈位置設定.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_亮燈位置設定.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_亮燈位置設定.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_亮燈位置設定.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_亮燈位置設定.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_亮燈位置設定.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_亮燈位置設定.columnHeadersHeight = 44;
            this.sqL_DataGridView_亮燈位置設定.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_亮燈位置設定.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_亮燈位置設定.Columns"))));
            this.sqL_DataGridView_亮燈位置設定.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_亮燈位置設定.Columns1"))));
            this.sqL_DataGridView_亮燈位置設定.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_亮燈位置設定.Columns2"))));
            this.sqL_DataGridView_亮燈位置設定.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_亮燈位置設定.Columns3"))));
            this.sqL_DataGridView_亮燈位置設定.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_亮燈位置設定.Columns4"))));
            this.sqL_DataGridView_亮燈位置設定.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_亮燈位置設定.Columns5"))));
            this.sqL_DataGridView_亮燈位置設定.DataBaseName = "Dispensing_000";
            this.sqL_DataGridView_亮燈位置設定.Dock = System.Windows.Forms.DockStyle.Left;
            this.sqL_DataGridView_亮燈位置設定.Font = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_亮燈位置設定.ImageBox = false;
            this.sqL_DataGridView_亮燈位置設定.Location = new System.Drawing.Point(0, 0);
            this.sqL_DataGridView_亮燈位置設定.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sqL_DataGridView_亮燈位置設定.Name = "sqL_DataGridView_亮燈位置設定";
            this.sqL_DataGridView_亮燈位置設定.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_亮燈位置設定.Password = "user82822040";
            this.sqL_DataGridView_亮燈位置設定.Port = ((uint)(3306u));
            this.sqL_DataGridView_亮燈位置設定.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_亮燈位置設定.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_亮燈位置設定.RowsColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqL_DataGridView_亮燈位置設定.RowsHeight = 50;
            this.sqL_DataGridView_亮燈位置設定.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_亮燈位置設定.Server = "localhost";
            this.sqL_DataGridView_亮燈位置設定.Size = new System.Drawing.Size(766, 932);
            this.sqL_DataGridView_亮燈位置設定.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_亮燈位置設定.TabIndex = 115;
            this.sqL_DataGridView_亮燈位置設定.TableName = "medicine_page";
            this.sqL_DataGridView_亮燈位置設定.UserName = "root";
            this.sqL_DataGridView_亮燈位置設定.可拖曳欄位寬度 = true;
            this.sqL_DataGridView_亮燈位置設定.可選擇多列 = true;
            this.sqL_DataGridView_亮燈位置設定.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_亮燈位置設定.自動換行 = true;
            this.sqL_DataGridView_亮燈位置設定.表單字體 = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_亮燈位置設定.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_亮燈位置設定.顯示CheckBox = false;
            this.sqL_DataGridView_亮燈位置設定.顯示首列 = true;
            this.sqL_DataGridView_亮燈位置設定.顯示首行 = true;
            this.sqL_DataGridView_亮燈位置設定.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_亮燈位置設定.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // panel_系統
            // 
            this.panel_系統.Controls.Add(this.plC_RJ_ScreenButton3);
            this.panel_系統.Controls.Add(this.plC_RJ_ScreenButton1);
            this.panel_系統.Controls.Add(this.plC_RJ_ScreenButton2);
            this.panel_系統.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_系統.Location = new System.Drawing.Point(0, 0);
            this.panel_系統.Name = "panel_系統";
            this.panel_系統.Size = new System.Drawing.Size(1656, 51);
            this.panel_系統.TabIndex = 116;
            // 
            // plC_RJ_ScreenButton3
            // 
            this.plC_RJ_ScreenButton3.but_press = false;
            this.plC_RJ_ScreenButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton3.IconSize = 32;
            this.plC_RJ_ScreenButton3.Location = new System.Drawing.Point(344, 0);
            this.plC_RJ_ScreenButton3.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton3.Name = "plC_RJ_ScreenButton3";
            this.plC_RJ_ScreenButton3.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton3.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton3.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton3.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton3.OffText = "亮燈位置設定";
            this.plC_RJ_ScreenButton3.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton3.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton3.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton3.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton3.OnText = "亮燈位置設定";
            this.plC_RJ_ScreenButton3.ShowIcon = false;
            this.plC_RJ_ScreenButton3.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton3.TabIndex = 10;
            this.plC_RJ_ScreenButton3.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton3.寫入位置註解 = "";
            this.plC_RJ_ScreenButton3.寫入元件位置 = "";
            this.plC_RJ_ScreenButton3.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton3.控制位址 = "D0";
            this.plC_RJ_ScreenButton3.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton3.致能讀取位置 = "";
            this.plC_RJ_ScreenButton3.讀取位元反向 = false;
            this.plC_RJ_ScreenButton3.讀取位置註解 = "";
            this.plC_RJ_ScreenButton3.讀取元件位置 = "";
            this.plC_RJ_ScreenButton3.音效 = true;
            this.plC_RJ_ScreenButton3.頁面名稱 = "亮燈位置設定";
            this.plC_RJ_ScreenButton3.頁面編號 = 0;
            this.plC_RJ_ScreenButton3.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton3.顯示狀態 = false;
            this.plC_RJ_ScreenButton3.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton1
            // 
            this.plC_RJ_ScreenButton1.but_press = false;
            this.plC_RJ_ScreenButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton1.IconSize = 32;
            this.plC_RJ_ScreenButton1.Location = new System.Drawing.Point(172, 0);
            this.plC_RJ_ScreenButton1.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton1.Name = "plC_RJ_ScreenButton1";
            this.plC_RJ_ScreenButton1.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton1.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton1.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton1.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton1.OffText = "H_RFID";
            this.plC_RJ_ScreenButton1.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton1.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton1.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton1.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton1.OnText = "H_RFID";
            this.plC_RJ_ScreenButton1.ShowIcon = false;
            this.plC_RJ_ScreenButton1.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton1.TabIndex = 9;
            this.plC_RJ_ScreenButton1.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton1.寫入位置註解 = "";
            this.plC_RJ_ScreenButton1.寫入元件位置 = "";
            this.plC_RJ_ScreenButton1.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton1.控制位址 = "D0";
            this.plC_RJ_ScreenButton1.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton1.致能讀取位置 = "";
            this.plC_RJ_ScreenButton1.讀取位元反向 = false;
            this.plC_RJ_ScreenButton1.讀取位置註解 = "";
            this.plC_RJ_ScreenButton1.讀取元件位置 = "";
            this.plC_RJ_ScreenButton1.音效 = true;
            this.plC_RJ_ScreenButton1.頁面名稱 = "H_RFID";
            this.plC_RJ_ScreenButton1.頁面編號 = 0;
            this.plC_RJ_ScreenButton1.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton1.顯示狀態 = false;
            this.plC_RJ_ScreenButton1.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton2
            // 
            this.plC_RJ_ScreenButton2.but_press = false;
            this.plC_RJ_ScreenButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton2.IconSize = 32;
            this.plC_RJ_ScreenButton2.Location = new System.Drawing.Point(0, 0);
            this.plC_RJ_ScreenButton2.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton2.Name = "plC_RJ_ScreenButton2";
            this.plC_RJ_ScreenButton2.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton2.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton2.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton2.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton2.OffText = "系統";
            this.plC_RJ_ScreenButton2.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton2.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton2.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton2.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton2.OnText = "系統";
            this.plC_RJ_ScreenButton2.ShowIcon = false;
            this.plC_RJ_ScreenButton2.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton2.TabIndex = 8;
            this.plC_RJ_ScreenButton2.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton2.寫入位置註解 = "";
            this.plC_RJ_ScreenButton2.寫入元件位置 = "";
            this.plC_RJ_ScreenButton2.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton2.控制位址 = "D0";
            this.plC_RJ_ScreenButton2.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton2.致能讀取位置 = "";
            this.plC_RJ_ScreenButton2.讀取位元反向 = false;
            this.plC_RJ_ScreenButton2.讀取位置註解 = "";
            this.plC_RJ_ScreenButton2.讀取元件位置 = "";
            this.plC_RJ_ScreenButton2.音效 = true;
            this.plC_RJ_ScreenButton2.頁面名稱 = "系統";
            this.plC_RJ_ScreenButton2.頁面編號 = 0;
            this.plC_RJ_ScreenButton2.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton2.顯示狀態 = false;
            this.plC_RJ_ScreenButton2.顯示讀取位置 = "";
            // 
            // h_RFID_UI
            // 
            this.h_RFID_UI.DataBaseName = "TEST";
            this.h_RFID_UI.Dock = System.Windows.Forms.DockStyle.Left;
            this.h_RFID_UI.IP = "localhost";
            this.h_RFID_UI.Location = new System.Drawing.Point(0, 0);
            this.h_RFID_UI.Name = "h_RFID_UI";
            this.h_RFID_UI.Password = "user82822040";
            this.h_RFID_UI.Port = ((uint)(3306u));
            this.h_RFID_UI.Size = new System.Drawing.Size(1393, 932);
            this.h_RFID_UI.TabIndex = 0;
            this.h_RFID_UI.TableName = "Device_Jsonstring";
            this.h_RFID_UI.UDP_LocalPorts = ((System.Collections.Generic.List<string>)(resources.GetObject("h_RFID_UI.UDP_LocalPorts")));
            this.h_RFID_UI.UDP_ServerPorts = ((System.Collections.Generic.List<string>)(resources.GetObject("h_RFID_UI.UDP_ServerPorts")));
            this.h_RFID_UI.UserName = "root";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.plC_ScreenPage_Main);
            this.Controls.Add(this.panel_Main);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "調劑台傳送帶智慧通報系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Main.ResumeLayout(false);
            this.panel232.ResumeLayout(false);
            this.plC_ScreenPage_Main.ResumeLayout(false);
            this.設定.ResumeLayout(false);
            this.panel_設定.ResumeLayout(false);
            this.系統.ResumeLayout(false);
            this.plC_ScreenPage_系統.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.rJ_Pannel4.ResumeLayout(false);
            this.rJ_Pannel4.PerformLayout();
            this.rJ_Pannel3.ResumeLayout(false);
            this.rJ_Pannel1.ResumeLayout(false);
            this.rJ_Pannel2.ResumeLayout(false);
            this.panel_系統.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_系統;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_工程模式;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_設定;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_主畫面;
        private System.Windows.Forms.Panel panel232;
        private MyUI.RJ_TextBox rJ_TextBox_登入者顏色;
        private MyUI.RJ_TextBox rJ_TextBox_登入者姓名;
        private MyUI.RJ_TextBox rJ_TextBox_登入者ID;
        private MyUI.RJ_Lable rJ_Lable51;
        private MyUI.RJ_Lable rJ_Lable52;
        private MyUI.PLC_RJ_Button plC_RJ_Button_後台登入_登出;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton143;
        private MyUI.PLC_ScreenPage plC_ScreenPage_Main;
        private System.Windows.Forms.TabPage 主畫面;
        private System.Windows.Forms.TabPage 設定;
        private System.Windows.Forms.TabPage 系統;
        private System.Windows.Forms.TabPage 工程模式;
        private System.Windows.Forms.Panel panel_設定;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_儲位效期表;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_儲位總庫存表;
        private MyUI.PLC_ScreenPage plC_ScreenPage_系統;
        private System.Windows.Forms.TabPage tabPage1;
        private MyUI.PLC_UI_Init plC_UI_Init;
        private LadderUI.LowerMachine_Panel lowerMachine_Panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_系統;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton1;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton2;
        private System.Windows.Forms.TabPage tabPage3;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton3;
        private MyUI.PLC_RJ_Button plC_RJ_Button_亮燈位置設定_刷新;
        private SQLUI.SQL_DataGridView sqL_DataGridView_亮燈位置設定;
        private MyUI.RJ_Pannel rJ_Pannel4;
        private System.Windows.Forms.Label label1;
        private MyUI.PLC_NumBox plC_NumBox_亮燈位置設定_滅燈延遲時間;
        private MyUI.RJ_Lable rJ_Lable3;
        private MyUI.RJ_Pannel rJ_Pannel3;
        private MyUI.RJ_TextBox textBox_亮燈位置設定_名稱;
        private MyUI.RJ_Lable rJ_Lable2;
        private MyUI.RJ_Pannel rJ_Pannel1;
        private MyUI.RJ_TextBox textBox_亮燈位置設定_IO_Index;
        private MyUI.RJ_Lable rJ_Lable1;
        private MyUI.RJ_Pannel rJ_Pannel2;
        private MyUI.RJ_TextBox textBox_亮燈位置設定_IP;
        private MyUI.RJ_Lable rJ_Lable17;
        private MyUI.PLC_RJ_Button plC_RJ_Button_亮燈位置設定_登錄;
        private MyUI.PLC_RJ_Button plC_RJ_Button_亮燈位置設定_刪除;
        private MyUI.PLC_RJ_Button plC_RJ_Button_亮燈位置設定_亮燈;
        private MyUI.PLC_RJ_Button plC_RJ_Button_亮燈位置設定_滅燈;
        private H_Pannel_lib.H_RFID_UI h_RFID_UI;
    }
}

