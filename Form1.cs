using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using TechLifeForum;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;
using DevExpress.Utils;
using DevExpress.Utils.Serializing;
using System.Data.SqlClient;
using ProjectRunningFox;
using System.Net.Cache;
using System.IO.Compression;
using PS3Lib;

namespace ProjectRunningFox
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SkinName = Properties.Settings.Default["ApplicationSkinName"].ToString();
        }
        #region definitions
        private static WebClient WC = new WebClient();
        public TimeSpan Elapsed;
        Stopwatch stopWatch = new Stopwatch();
        Stopwatch stopWatch1 = new Stopwatch();
        Stopwatch stopWatch2 = new Stopwatch();
        Stopwatch stopWatch3 = new Stopwatch();
        #endregion
        #region definitions
        public static uint ProcessID;
        public static uint[] processIDs;
        public static string snresult;
        private static string usage;
        public static string Info;
        public static PS3TMAPI.ConnectStatus connectStatus;
        public static string Status;
        public static string MemStatus;
        public static PS3API PS3 = new PS3API();
        System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer();
        PS3API API = new PS3API();
        public int Gameindex = 0;
        int thisVersion = 5;
        public int avatarIndex = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        TileItem newItem = new TileItem();
        private bool doubtback;
        IrcClient irc;
        public static string roomname;
        public static string currentroom;
        public static string currentname;
        public static string currentserver;
        public static int port;
        public static bool isconnected = false;
        public static string connectmsg = currentname + " has just joined!";
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Form1_Load
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SkinName = Properties.Settings.Default["ApplicationSkinName"].ToString();
            player.Stream = Properties.Resources.Dragon_Quest_Monsters_Joker_2_OST___Doubtback;
            player.Load();
            notifyIcon1.BalloonTipTitle = "Project Running Fox";
            notifyIcon1.BalloonTipText = "Welcome " + Properties.Settings.Default.UserName + "!";
            notifyIcon1.ShowBalloonTip(250);
            notifyIcon1.Text = "Project Running Fox";
            WC.DownloadProgressChanged += OnDownloadProgressChanged;
            WC.DownloadFileCompleted += OnDownloadComplete;
            WC.Headers.Add("user-agent", "Only a test!");
            textEdit312.Visible = true;
            SettingsOnLoad settingsLoad = new SettingsOnLoad();
            settingsLoad.Form1Load(this);
            settingsLoad.TileLayOut(this);
            //Conditions
            try
            {
                memoEdit2.Text = WC.DownloadString("https://pastebin.com/raw/dYP7iLg6");
                memoEdit1.Text = WC.DownloadString("https://pastebin.com/raw/GtL7gQBT");
                textEdit321.Text = WC.DownloadString("https://pastebin.com/raw/s069eKU6");
                textEdit358.Text = WC.DownloadString("https://pastebin.com/raw/kkmk0Ts8");
                textEdit359.Text = WC.DownloadString("https://pastebin.com/raw/euqxGRc2");
                textEdit360.Text = WC.DownloadString("https://pastebin.com/raw/e4QsKTcF");
            }
            catch
            {
                XtraMessageBox.Show("The following features may not work :\n1.User Settings\n2.Updated log and Credits\n3.Chatroom\n4.Auto Updater\n\nIf you are connected, try the following :\n-Restart your router\n-Make sure your anti-virus isnt blocking connection to PRF\nContact me on skype : brandon.alex65 if you cant fix the issue.", "It appears that you are offline", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (checkEdit2.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
            }
            if (checkEdit1.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
            }
            if (textEdit5.Text == "" || labelControl1.Text == "")
            {
                Conditionals conditions = new Conditionals();
                conditions.ResetHeaders(this);
            }
            if (Properties.Settings.Default.FirstRun == true)
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Project Running Fox"));
                tileControl1.Enabled = false;
                tileControl2.Enabled = false;
                tileControl3.Enabled = false;
                tileControl4.Enabled = false;
                tileControl5.Enabled = false;
                tileControl6.Enabled = false;
                tileControl7.Enabled = false;
                tileControl8.Enabled = false;
                xtraTabPage1.AutoScroll = false;
                labelControl900.Visible = true;
                panel1.Visible = true;
                pictureBox52.Visible = true;
                memoEdit6.Visible = true;
                simpleButton696.Visible = true;
            }
            if (Properties.Settings.Default.CheckUpdate == true)
            {
                checkForUpdates();
            }
            if (labelControl610.Text == "1")
            {
                Conditionals conditions = new Conditionals();
                conditions.CreateOneTile(this);
            }
            if (labelControl610.Text == "2")
            {
                Conditionals conditions = new Conditionals();
                conditions.CreateTwoTiles(this);
            }
            if (labelControl610.Text == "3")
            {
                Conditionals conditions = new Conditionals();
                conditions.CreateThreeTiles(this);
            }
            if (textEdit15.Text == "1")
            {
                pictureBox1.Image = Properties.Resources.Avatar1;
                pictureBox2.Image = Properties.Resources.Avatar1;
            }
            if (textEdit15.Text == "2")
            {
                pictureBox1.Image = Properties.Resources.Avatar2;
                pictureBox2.Image = Properties.Resources.Avatar2;
            }
            if (textEdit15.Text == "3")
            {
                pictureBox1.Image = Properties.Resources.Avatar3;
                pictureBox2.Image = Properties.Resources.Avatar3;
            }
            if (textEdit15.Text == "4")
            {
                pictureBox1.Image = Properties.Resources.Avatar4;
                pictureBox2.Image = Properties.Resources.Avatar4;
            }
            if (textEdit15.Text == "5")
            {
                pictureBox1.Image = Properties.Resources.Avatar5;
                pictureBox2.Image = Properties.Resources.Avatar5;
            }
            if (textEdit321.Text == "Terminate")
            {
                XtraMessageBox.Show("The creator has decided to close this project", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(2500);
                System.Windows.Forms.Application.Exit();
            }
            if (toggleSwitch267.IsOn)
            {
                if (textEdit358.Text == "Halloween")
                {
                    this.defaultLookAndFeel1.LookAndFeel.SkinName = "Pumpkin";
                }
                if (textEdit358.Text == "Christmas")
                {
                    this.defaultLookAndFeel1.LookAndFeel.SkinName = "Xmas 2008 Blue";
                    SettingsOnLoad sol = new SettingsOnLoad();
                    sol.XMASSkin(this);
                }
            }
            if (File.Exists("ProjectRunningFoxUpdate.exe"))
            {
            }
            else
            {
                XtraMessageBox.Show("The ProjectRunningFoxUpdate.exe was not found! \nReinstall the program or restore the ProjectRunningFoxUpdate.exe.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(2500);
                System.Windows.Forms.Application.Exit();
            }
            if (textEdit359.Text == "Yes")
            {
                Properties.Settings.Default.CheckUpdate = true;
            }
            if (checkEdit210.Checked)
            {
                string url1 = textEdit318.Text;
                pictureBox1.ImageLocation = url1;
                pictureBox2.ImageLocation = url1;
            }
            labelControl899.Text = textEdit360.Text;
            MovingLabel.Start();
            SettingsOnLoad loadSettings = new SettingsOnLoad();
            loadSettings.PresetNames(this);
            loadSettings.TileHeaders(this);
            loadSettings.TileForeColorNormal(this);
            loadSettings.TileFontNormal(this);
            loadSettings.TileBorderColorHovered(this);
            loadSettings.TileBackColorHovered(this);
            loadSettings.TileGradientHovered(this);
            loadSettings.TileBorderColorSelected(this);
            loadSettings.TileBackColorSelected(this);
            loadSettings.TileGradientSelected(this);
            loadSettings.TileGradientNormal(this);
            loadSettings.TileBorderColorNormal(this);
            loadSettings.TileBackColorNormal(this);
            loadSettings.HeaderFont(this);
            loadSettings.HeaderForeColor(this);
            loadSettings.HeaderBackColor(this);
            loadSettings.AllLabelFont(this);
            loadSettings.AllLabelForeColor(this);
            loadSettings.ClientListFont(this);
            loadSettings.ClientListForeColor(this);
            loadSettings.TextBoxFont(this);
            loadSettings.TextBoxForeColor(this);
            loadSettings.ButtonFont(this);
            loadSettings.ButtonForeColor(this);
            loadSettings.CheckEditFont(this);
            loadSettings.CheckEditForeColor(this);
            loadSettings.ToggleSwitchFont(this);
            loadSettings.ToggleSwitchForeColor(this);
            loadSettings.CheckButtonFont(this);
            loadSettings.CheckButtonForeColor(this);
            loadSettings.SpinEditFont(this);
            loadSettings.SpinEditForeColor(this);
            loadSettings.KeyShortCuts(this);
            loadSettings.UserTiles(this);
            #endregion
        }

        #region NewTileEventHandlers
        public void newItem_ItemClick(object sender, TileItemEventArgs e)
        {
            System.Diagnostics.Process.Start(textEdit306.Text);
        }

        public void newItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            System.Diagnostics.Process.Start(textEdit315.Text);
        }

        public void newItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            System.Diagnostics.Process.Start(textEdit317.Text);
        }
        #endregion
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Form1_Closing
            Properties.Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.Save();
            SettingsOnClosing closingSettings = new SettingsOnClosing();
            closingSettings.CloseForm(this);
            closingSettings.TilelayOut(this);
            closingSettings.PresetNames(this);
            closingSettings.TileHeaders(this);
            closingSettings.TileForeColorNormal(this);
            closingSettings.TileFontNormal(this);
            closingSettings.TileBorderColorHovered(this);
            closingSettings.TileBackColorHovered(this);
            closingSettings.TileGradientHovered(this);
            closingSettings.TileBorderColorSelected(this);
            closingSettings.TileBackColorSelected(this);
            closingSettings.TileGradientSelected(this);
            closingSettings.TileBorderColorNormal(this);
            closingSettings.TileGradientNormal(this);
            closingSettings.TileBackColorNormal(this);
            closingSettings.TileHeaderFont(this);
            closingSettings.TileHeaderBackColor(this);
            closingSettings.TileHeaderForeColor(this);
            closingSettings.AllLabelFont(this);
            closingSettings.AllLabelForeColor(this);
            closingSettings.ClientListFont(this);
            closingSettings.ClientListForeColor(this);
            closingSettings.TextBoxFont(this);
            closingSettings.TextBoxForeColor(this);
            closingSettings.ButtonFont(this);
            closingSettings.ButtonForeColor(this);
            closingSettings.CheckEditFont(this);
            closingSettings.CheckEditForeColor(this);
            closingSettings.ToggleSwitchFont(this);
            closingSettings.ToggleSwitchForeColor(this);
            closingSettings.CheckButtonFont(this);
            closingSettings.CheckButtonForeColor(this);
            closingSettings.SpinEditFont(this);
            closingSettings.SpinEditForeColor(this);
            closingSettings.KeyShortCuts(this);
            closingSettings.UserTiles(this);
            Properties.Settings.Default.Save();
            #endregion
        }

        #region Check For Updates
        void checkForUpdates()
        {
            string[] lns = new System.Net.WebClient().DownloadString("https://pastebin.com/raw/cyB22uCT").Split('\n');
            if (int.Parse(lns[0]) > thisVersion)
            {
                System.Diagnostics.Process.Start(@"ProjectRunningFoxUpdate");
                System.Windows.Forms.Application.Exit();
            }
        }
        #endregion
        #region Tile Settings
        private void simpleButton621_Click(object sender, EventArgs e)
        {
            if (labelControl610.Text == "1")
            {
                TileItem newItem1 = new TileItem();
                newItem1.ItemSize = TileItemSize.Medium;
                newItem1.Elements.Add(new TileItemElement() { Text = textEdit314.Text });
                tileGroup8.Items.Add(newItem1);
                newItem1.AppearanceItem.Normal.BackColor = Color.Maroon;
                newItem1.AppearanceItem.Normal.BackColor2 = Color.Maroon;
                newItem1.AppearanceItem.Normal.BorderColor = Color.Maroon;
                XtraMessageBox.Show("Check the Other Tools Section.", "Tile Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (labelControl610.Text == "2")
            {
                simpleButton621.Visible = false;
                simpleButton622.Visible = true;
                textEdit314.Visible = false;
                textEdit315.Visible = false;
                textEdit316.Visible = true;
                textEdit317.Visible = true;
            }
        }

        private void simpleButton622_Click(object sender, EventArgs e)
        {
            if (labelControl610.Text == "2")
            {
                TileItem newItem2 = new TileItem();
                newItem2.ItemSize = TileItemSize.Medium;
                newItem2.Elements.Add(new TileItemElement() { Text = textEdit316.Text });
                tileGroup8.Items.Add(newItem2);
                newItem2.AppearanceItem.Normal.BackColor = Color.Maroon;
                newItem2.AppearanceItem.Normal.BackColor2 = Color.Maroon;
                newItem2.AppearanceItem.Normal.BorderColor = Color.Maroon;
                labelControl610.Text = "3";
                XtraMessageBox.Show("Check the Other Tools Section.", "Tile Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (labelControl610.Text == "3")
            {
                XtraMessageBox.Show("Upgrade to Premium to get more tiles.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void simpleButton620_Click(object sender, EventArgs e)
        {
            labelControl610.Text = "0";
            textEdit305.Visible = true;
            textEdit306.Visible = true;
            textEdit314.Visible = false;
            textEdit315.Visible = false;
            simpleButton621.Location = new Point(38, 434);
            simpleButton612.Visible = true;
            simpleButton621.Visible = false;
            XtraMessageBox.Show("Restart application to add them again.", "Tiles Reset!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void checkEdit155_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkEdit145_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Please restart the application.", "All changes have been set!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton452_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = new MainInterface();
            mainInterface.RevertChanges(this);
            UserLookAndFeel.Default.SkinName = comboBoxEdit1.Text;
        }
        private void colorEdit4_EditValueChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.GradientNormal(this);
            Properties.Settings.Default["TileBG2Color"] = colorEdit4.Color;
        }

        private void colorEdit1_EditValueChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.BackColorNormal(this);
            Properties.Settings.Default["TileBGColor"] = colorEdit1.Color;
        }

        private void colorEdit5_EditValueChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.BorderColorNormal(this);
            Properties.Settings.Default["TileBGBorderC"] = colorEdit5.Color;
        }

        private void colorEdit6_EditValueChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.GradientHovered(this);
            Properties.Settings.Default["TileBG2ColorH"] = colorEdit6.Color;
        }

        private void colorEdit8_EditValueChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.BackColorHovered(this);
            Properties.Settings.Default["TileBGColorH"] = colorEdit8.Color;
        }

        private void colorEdit7_EditValueChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.BorderColorHovered(this);
            Properties.Settings.Default["TileBGBorderH"] = colorEdit7.Color;
        }

        private void colorEdit9_EditValueChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.GradientSelected(this);
            Properties.Settings.Default["TileBG2ColorS"] = colorEdit9.Color;
        }

        private void colorEdit11_EditValueChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.BackColorSelected(this);
            Properties.Settings.Default["TileBGColorS"] = colorEdit11.Color;
        }

        private void colorEdit10_EditValueChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.BorderColorSelected(this);
            Properties.Settings.Default["TileBGBorderCS"] = colorEdit5.Color;
        }

        private void fontEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.TileFont(this);
            Properties.Settings.Default["TileFontNormal"] = tileItem1.AppearanceItem.Normal.Font;
        }

        private void colorEdit14_EditValueChanged(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings();
            tileSettings.TileForeColor(this);
            Properties.Settings.Default["TileFontColor"] = tileItem1.AppearanceItem.Normal.ForeColor;
        }
        #endregion
        #region IRCChat
        private void AddListeners()
        {
            irc.ChannelMessage += (c, u, m) =>
            {
                richTextBox1.AppendText(u + ": " + m + "\n\n");
                richTextBox1.ScrollToCaret();
            };
            irc.ServerMessage += (m) =>
            {
                richTextBox1.AppendText(m + "\n");
                richTextBox1.ScrollToCaret();
            };
            irc.UpdateUsers += (c, u) =>
            {
                listBoxControl13.Items.Clear();
                listBoxControl13.Items.AddRange(u);
            };
            irc.OnConnect += () =>
            {
                richTextBox1.AppendText("You just connected to " + roomname + " !");
                irc.JoinChannel(currentroom);
                irc.SendMessage(currentroom, connectmsg);
                richTextBox1.AppendText(connectmsg);
            };
        }
        private void simpleButton630_Click(object sender, EventArgs e)
        {
            if (isconnected == false)
            {
                currentserver = "chat.freenode.net";
                roomname = "Room";
                currentroom = "#" + "projectrunningfox";
                if (toggleSwitch229.IsOn)
                {
                    currentname = "AnonymousUser1";
                }
                else
                {
                    currentname = textEdit312.Text;
                }
                port = 6667;
                richTextBox1.AppendText("Connecting...");
                irc = new IrcClient(currentserver, port);
                irc.Nick = currentname;
                AddListeners();
                irc.Connect();
                isconnected = true;
                simpleButton630.Text = "Connected";
            }
            }
        private void memoEdit6_EditValueChanged(object sender, EventArgs e)
        {
            richTextBox1.ScrollToCaret();
        }
        private void simpleButton628_Click(object sender, EventArgs e)
        {
            irc.SendMessage(currentroom, textEdit322.Text);
            richTextBox1.AppendText("You: " + textEdit322.Text + "\n\n");
            textEdit322.Text = "";
            textEdit322.Focus();
        }
        private void simpleButton631_Click(object sender, EventArgs e)
        {
            IRCChat.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Chatroom";
        }
        private void simpleButton629_Click(object sender, EventArgs e)
        {
            if (toggleSwitch230.IsOn)
            {
                richTextBox1.Clear();
            }
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }
        private void textEdit322_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
           {
               simpleButton628.PerformClick();
           }
        }
        #endregion
        #region Set Theme
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                comboBoxEdit1.Text = "Metropolis";
                UserLookAndFeel.Default.SkinName = comboBoxEdit1.Text;
                Properties.Settings.Default["ApplicationSkinName"] = comboBoxEdit1.Text;
                MainInterface mainInterface = new MainInterface();
                mainInterface.WhiteTheme(this);

            }
            if (comboBoxEdit1.SelectedIndex == 1)
            {
                comboBoxEdit1.Text = "Metropolis Dark";
                UserLookAndFeel.Default.SkinName = comboBoxEdit1.Text;
                Properties.Settings.Default["ApplicationSkinName"] = comboBoxEdit1.Text;
                MainInterface mainInterface = new MainInterface();
                mainInterface.BlackTheme(this);
            }
        }
        #endregion
        #region Tutorial
        private int CaseSwitch = 0;
        private void BETA_Part1_Tick(object sender, EventArgs e)
        {
            CaseSwitch++;
            switch (CaseSwitch)
            {
                case 1:
                    tileItem1.AppearanceItem.Normal.BorderColor = Color.Red;
                    break;
                case 2:
                    tileItem1.AppearanceItem.Normal.BorderColor = Color.Blue;
                    break;
            }
            if (CaseSwitch == 2) CaseSwitch = 0;
        }
        #endregion
        #region Header Font Options
        private void fontEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainInterface mainInterface = new MainInterface();
            mainInterface.MainFont(this);
            Properties.Settings.Default["label1Font"] = labelControl1.Font;
        }

        private void colorEdit2_EditValueChanged(object sender, EventArgs e)
        {
            MainInterface mainInterface = new MainInterface();
            mainInterface.MainForeColor(this);
            Properties.Settings.Default["label1Color"] = colorEdit2.Color;
        }

        private void colorEdit3_EditValueChanged(object sender, EventArgs e)
        {
            MainInterface mainInterface = new MainInterface();
            mainInterface.MainBackColor(this);
            Properties.Settings.Default["label1BColor"] = colorEdit3.Color;
        }
        #endregion
        #region Tool Control Settings
        private void fontEdit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.LabelFont(this);
            Properties.Settings.Default["AllLabelsFont"] = labelControl1.Font;
        }
        private void fontEdit10_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.CheckBoxesFont(this);
            Properties.Settings.Default["CheckBoxesFont"] = checkEdit13.Font;
        }

        private void colorEdit15_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.CheckBoxesForeColor(this);
            Properties.Settings.Default["CheckBoxesForeColor"] = colorEdit15.Color;
        }

        private void fontEdit6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.CheckButtonFont(this);
            Properties.Settings.Default["CheckButtonFont"] = checkButton1.Font;
        }

        private void fontEdit7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.ToggleSwitchesFont(this);
            Properties.Settings.Default["TGFont"] = toggleSwitch4.Font;
        }

        private void colorEdit22_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.ToggleSwitchesForeColor(this);
            Properties.Settings.Default["TGForeColor"] = colorEdit22.Color;
        }

        private void colorEdit20_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.CheckButtonForeColor(this);
            Properties.Settings.Default["CheckButtonForeCOlor"] = colorEdit20.Color;
        }

        private void fontEdit9_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.SpinEditFont(this);
            Properties.Settings.Default["SpinEditFont"] = spinEdit2.Font;
        }

        private void colorEdit12_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.SpinEditForeColor(this);
            Properties.Settings.Default["SpinEditForeColor"] = colorEdit12.Color;
        }
        private void colorEdit13_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.LabelForeColor(this);
            Properties.Settings.Default["AllLabelsForeColor"] = colorEdit13.Color;
        }

        private void fontEdit4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.ListBoxFont(this);
            Properties.Settings.Default["ClientListFont"] = listBoxControl1.Font;
        }

        private void colorEdit16_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.ListBoxForeColor(this);
            Properties.Settings.Default["ClientListColor"] = colorEdit16.Color;
        }

        private void fontEdit8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.TextBoxFont(this);
            Properties.Settings.Default["TextBoxesFont"] = textEdit16.Font;
        }

        private void colorEdit24_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.TextBoxForeColor(this);
            Properties.Settings.Default["TextBoxesForeColor"] = colorEdit24.Color;
        }

        private void simpleButton211_Click(object sender, EventArgs e)
        {
        }

        private void fontEdit5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.ButtonFont(this);
            Properties.Settings.Default["ButtonsFont"] = simpleButton35.Font;
        }

        private void colorEdit18_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.ButtonForeColor(this);
            Properties.Settings.Default["ButtonsForeColor"] = colorEdit18.Color;
        }

        #endregion
        #region Game Open Events
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }
        private void simpleButton213_Click_2(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }
        private void simpleButton82_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }
        private void simpleButton635_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }
        private void tileItem40_ItemClick(object sender, TileItemEventArgs e)
        {
            BlackOps2.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Call of Duty : Black Ops 2";
        }
        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            Mw2.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Call of Duty : Modern Warfare 2";
        }
        private void tileItem39_ItemClick(object sender, TileItemEventArgs e)
        {
            ASGTA.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Grand Theft Auto : San Andreas";
        }

        private void simpleButton616_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void tileItem38_ItemClick(object sender, TileItemEventArgs e)
        {
            ACRogue.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Assassin's Creed : Rogue";
        }

        private void simpleButton613_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }
        private void tileItem37_ItemClick(object sender, TileItemEventArgs e)
        {
            EbootLibrary.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] EBOOT Library";
        }
        private void simpleButton152_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton153_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton154_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton155_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton156_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton157_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton158_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            MW3.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Call of Duty : Modern Warfare 3";
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            AW.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Call of Duty : Advanced Warfare";
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            BO.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Call of Duty : Black Ops";
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            MW.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Call of Duty : Modern Warfare";
        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            BO3.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Call of Duty : Black Ops 3";
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            Ghosts.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Call of Duty : Ghosts";
        }

        private void tileItem13_ItemClick(object sender, TileItemEventArgs e)
        {
            //GTAV.Show();
            XtraMessageBox.Show("Grand Theft Auto V is not done yet...", "Section Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Form1.ActiveForm.Text = "Project Running Fox [BETA] Grand Theft Auto V";
        }

        private void simpleButton189_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton190_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton191_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton192_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton193_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton194_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton195_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton196_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton197_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton198_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton199_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton200_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton201_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton202_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void simpleButton203_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }

        private void tileItem14_ItemClick(object sender, TileItemEventArgs e)
        {
            SP.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] South Park : The Stick of Truth";
        }

        private void tileItem16_ItemClick(object sender, TileItemEventArgs e)
        {
            DS2.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Dark Souls 2";
        }

        private void tileItem25_ItemClick(object sender, TileItemEventArgs e)
        {
            TLOU.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] The Last of Us";
        }

        private void tileItem17_ItemClick(object sender, TileItemEventArgs e)
        {
            //GTAIV.Show();
        }

        private void tileItem18_ItemClick(object sender, TileItemEventArgs e)
        {
            MC.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Minecraft";
        }

        private void tileItem19_ItemClick(object sender, TileItemEventArgs e)
        {
            Skate3.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Skate 3";
        }

        private void tileItem20_ItemClick(object sender, TileItemEventArgs e)
        {
            JC2.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Just Cause 2";
        }

        private void tileItem21_ItemClick(object sender, TileItemEventArgs e)
        {
            Skyrim.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Skyrim";
        }
        private void tileItem22_ItemClick(object sender, TileItemEventArgs e)
        {
           SR3.Show();
           Form1.ActiveForm.Text = "Project Running Fox [BETA] FarCry 4";
        }

        private void tileItem23_ItemClick(object sender, TileItemEventArgs e)
        {
            //BL2.Show();
            // Form1.ActiveForm.Text = "Project Running Fox [BETA] Borderlands 2";
            XtraMessageBox.Show("Borderlands 2 is not done yet...", "Section Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tileItem24_ItemClick(object sender, TileItemEventArgs e)
        {
            RDR.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Read Dead Redemption";
        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
           // BFBC2.Show();
        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {
            BF3.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Battlefield 3";
        }

        private void tileItem11_ItemClick(object sender, TileItemEventArgs e)
        {
            BF4.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Battlefield 4";
        }

        private void tileItem12_ItemClick(object sender, TileItemEventArgs e)
        {
            BFH.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Battlefield Hardline";
        }
        private void tileItem26_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ToolSettings.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Settings";
        }
        private void simpleButton26_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA]";
        }
        private void tileItem15_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ToolSettings.Show();
            xtraTabPage14.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] PS3 Options";
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            WAW.Show();
            Form1.ActiveForm.Text = "Project Running Fox [BETA] Call of Duty : World at War";
        }
        #endregion
        #region Key Preview
        private void textEdit259_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton516.PerformClick();
            }
        }
        #endregion
        #region EBOOT Library
        private void simpleButton607_Click_1(object sender, EventArgs e)
        {
            EbootLibrary ebootlibrary = new EbootLibrary();
            ebootlibrary.NavigateBack(this);
        }
        private void simpleButton627_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(memoEdit5.Text);
        }
        private void simpleButton606_Click_1(object sender, EventArgs e)
        {
            EbootLibrary ebootlibrary = new EbootLibrary();
            ebootlibrary.NavigateForward(this);
        }

        private void simpleButton146_Click_3(object sender, EventArgs e)
        {
            try
            {
                Uri URL = new Uri(textEdit311.Text);
                string assemblyPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Running Fox\\EBOOT.rar";
                WC.DownloadFileAsync(URL, assemblyPath);
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    XtraMessageBox.Show(ex.Message);
                    ex = ex.InnerException;
                }
            }
        }

        private void OnDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            XtraMessageBox.Show("Your EBOOT.BIN is in the Project Running Fox folder in your documents.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelControl707.Text = "Downloaded {} of {} bytes";
            label2.Text = "0%";
            progressBarControl1.EditValue = 0;
        }

        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            progressBarControl1.EditValue = e.ProgressPercentage;
            labelControl707.Text = String.Format("Downloaded {0} of {1} bytes", e.BytesReceived, e.TotalBytesToReceive);
            long dProgress = 100 * e.BytesReceived / e.TotalBytesToReceive;
            label2.Text = dProgress.ToString() + " %";
        }

        private void simpleButton608_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Running Fox\\EBOOT.rar");
        }
        #endregion
        #region Logo Easter Egg
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            player.Play();
        }
        #endregion
        #region Connect and Attach MW2
        private void simpleButton80_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl112.Text = "Connected";
                labelControl112.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl112.Text = "Failed!";
                labelControl112.ForeColor = Color.Red;
            }
        }

        private void checkEdit16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit16.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit15.Enabled = false;
            }
            else
            {
                checkEdit15.Enabled = true;
            }
        }

        private void checkEdit15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit15.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit16.Enabled = false;
            }
            else
            {
                checkEdit16.Enabled = true;
            }
        }

        private void simpleButton81_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl107.Text = "Game Attached";
                labelControl107.ForeColor = Color.Green;
                labelControl105.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name);
                labelControl105.ForeColor = Color.Green;
                labelControl104.Text = labelControl105.Text;
                if (toggleSwitch224.IsOn)
                {
                    ProjectRunningFox.Games.Call_of_Duty_MW2.RPC.EnableRPC();
                }
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl107.Text = "Failed!";
                labelControl107.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach World at War
        private void simpleButton34_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl64.Text = "Connected";
                labelControl64.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl64.Text = "Failed!";
                labelControl64.ForeColor = Color.Red;
            }
        }

        private void checkEdit13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit13.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit14.Enabled = false;
            }
            else
            {
                checkEdit14.Enabled = true;
            }
        }

        private void checkEdit14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit14.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit13.Enabled = false;
            }
            else
            {
                checkEdit13.Enabled = true;
            }
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl65.Text = "Game Attached";
                labelControl65.ForeColor = Color.Green;
                if (toggleSwitch224.IsOn)
                {
                    ProjectRunningFox.Games.Call_of_Duty_World_at_War.RPC.Init();
                }
                labelControl67.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name);
                labelControl67.ForeColor = Color.Green;
                labelControl96.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name);
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl65.Text = "Failed!";
                labelControl65.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach MW3
        private void checkEdit34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit34.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit35.Enabled = false;
            }
            else
            {
                checkEdit35.Enabled = true;
            }
        }

        private void checkEdit35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit35.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit34.Enabled = false;
            }
            else
            {
                checkEdit34.Enabled = true;
            }
        }

        private void simpleButton131_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl161.Text = "Connected";
                labelControl161.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl161.Text = "Failed!";
                labelControl161.ForeColor = Color.Maroon;
            }
        }

        private void simpleButton132_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl103.Text = "Game Attached";
                labelControl103.ForeColor = Color.Green;
                labelControl97.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name);
                labelControl97.ForeColor = Color.Green;
                labelControl176.Text = labelControl97.Text;
                if (toggleSwitch224.IsOn)
                {
                    Games.Call_of_Duty_MW3.RPC.RPC_Enable_124();
                }
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl103.Text = "Failed!";
                labelControl103.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Advanced Warfare
        private void simpleButton134_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl174.Text = "Connected";
                labelControl174.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl174.Text = "Failed!";
                labelControl174.ForeColor = Color.Red;
            }
        }

        private void checkEdit37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit37.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit36.Enabled = false;
            }
            else
            {
                checkEdit36.Enabled = true;
            }
        }

        private void checkEdit36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit36.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit37.Enabled = false;
            }
            else
            {
                checkEdit37.Enabled = true;
            }
        }

        private void simpleButton133_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl171.Text = "Game Attached";
                labelControl171.ForeColor = Color.Green;
                labelControl163.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name);
                labelControl163.ForeColor = Color.Green;
                labelControl177.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name);
                if (toggleSwitch224.IsOn)
                {
                    Games.Call_of_Duty_Advanced_Warfare.RPC.Init();
                }
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl171.Text = "Failed!";
                labelControl171.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Black Ops
        private void simpleButton136_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl202.Text = "Connected";
                labelControl202.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl202.Text = "Failed!";
                labelControl202.ForeColor = Color.Red;
            }
        }

        private void checkEdit39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit39.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit38.Enabled = false;
            }
            else
            {
                checkEdit38.Enabled = true;
            }
        }

        private void checkEdit38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit38.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit39.Enabled = false;
            }
            else
            {
                checkEdit39.Enabled = true;
            }
        }

        private void simpleButton135_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl200.Text = "Game Attached";
                if (toggleSwitch224.IsOn)
                {
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.RPC2.Enable_RPC();
                }
                labelControl200.ForeColor = Color.Green;
                labelControl195.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name);
                labelControl195.ForeColor = Color.Green;
                labelControl190.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name);
                if (labelControl195.Text == "")
                {
                    labelControl195.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName);
                    labelControl195.ForeColor = Color.Green;
                    if (toggleSwitch224.IsOn)
                    {
                        ProjectRunningFox.Games.Call_of_Duty_Black_Ops.RPC1.Init();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl200.Text = "Failed!";
                labelControl200.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach MW
        private void simpleButton138_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl208.Text = "Connected";
                labelControl208.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl208.Text = "Failed!";
                labelControl208.ForeColor = Color.Red;
            }
        }

        private void checkEdit41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit41.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit40.Enabled = false;
            }
            else
            {
                checkEdit40.Enabled = true;
            }
        }

        private void checkEdit40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit40.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit41.Enabled = false;
            }
            else
            {
                checkEdit41.Enabled = true;
            }
        }

        private void simpleButton137_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl206.Text = "Game Attached";
                labelControl206.ForeColor = Color.Green;
                // ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.RPC.Enable_RPC();
                labelControl204.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name);
                labelControl204.ForeColor = Color.Green;
                labelControl191.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name);
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl206.Text = "Failed!";
                labelControl206.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Ghosts
        private void simpleButton142_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl220.Text = "Connected";
                labelControl220.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl220.Text = "Failed!";
                labelControl220.ForeColor = Color.Red;
            }
        }

        private void checkEdit45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit45.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit44.Enabled = false;
            }
            else
            {
                checkEdit44.Enabled = true;
            }
        }

        private void checkEdit44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit44.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit45.Enabled = false;
            }
            else
            {
                checkEdit45.Enabled = true;
            }
        }

        private void simpleButton141_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl218.Text = "Game Attached";
                labelControl218.ForeColor = Color.Green;
                labelControl216.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name);
                labelControl216.ForeColor = Color.Green;
                labelControl193.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name);
                if (toggleSwitch224.IsOn)
                {
                    Games.Call_of_Duty_Ghosts.RPC.EnableRPC();
                }
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl218.Text = "Failed!";
                labelControl218.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach BO3
        private void simpleButton140_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl214.Text = "Connected";
                labelControl214.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl214.Text = "Failed!";
                labelControl214.ForeColor = Color.Red;
            }
        }

        private void checkEdit43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit43.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit42.Enabled = false;
            }
            else
            {
                checkEdit42.Enabled = true;
            }
        }

        private void checkEdit42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit42.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit43.Enabled = false;
            }
            else
            {
                checkEdit43.Enabled = true;
            }
        }

        private void simpleButton139_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl212.Text = "Game Attached";
                labelControl212.ForeColor = Color.Green;
                labelControl210.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name);
                labelControl210.ForeColor = Color.Green;
                labelControl192.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name);
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl212.Text = "Failed!";
                labelControl212.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach GTA V
        private void simpleButton144_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl226.Text = "Connected";
                labelControl226.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl226.Text = "Failed!";
                labelControl226.ForeColor = Color.Red;
            }
        }

        private void checkEdit47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit47.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit46.Enabled = false;
            }
            else
            {
                checkEdit46.Enabled = true;
            }
        }

        private void checkEdit46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit46.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit47.Enabled = false;
            }
            else
            {
                checkEdit47.Enabled = true;
            }
        }

        private void simpleButton143_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl224.Text = "Game Attached";
                labelControl224.ForeColor = Color.Green;
                ProjectRunningFox.Games.Grand_Theft_Auto_V.RPC.Enable();
                labelControl222.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.Name2);
                labelControl222.ForeColor = Color.Green;
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl224.Text = "Failed!";
                labelControl224.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach TLOU
        private void simpleButton164_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl607.Text = "Connected";
                labelControl607.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl607.Text = "Failed!";
                labelControl607.ForeColor = Color.Red;
            }
        }

        private void checkEdit48_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit48.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit33.Enabled = false;
            }
            else
            {
                checkEdit33.Enabled = true;
            }
        }

        private void checkEdit33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit33.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit48.Enabled = false;
            }
            else
            {
                checkEdit48.Enabled = true;
            }
        }

        private void simpleButton163_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl605.Text = "Game Attached";
                labelControl167.ForeColor = Color.Green;
                labelControl167.Text = System.Environment.UserName;
                labelControl605.ForeColor = Color.Green;
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl605.Text = "Failed!";
                labelControl605.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Skate 3
        private void simpleButton170_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl620.Text = "Connected";
                labelControl620.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl620.Text = "Failed!";
                labelControl620.ForeColor = Color.Red;
            }
        }

        private void checkEdit54_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit54.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit53.Enabled = false;
            }
            else
            {
                checkEdit53.Enabled = true;
            }
        }

        private void checkEdit53_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit53.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit54.Enabled = false;
            }
            else
            {
                checkEdit54.Enabled = true;
            }
        }

        private void simpleButton169_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl618.Text = "Game Attached";
                labelControl618.ForeColor = Color.Green;
                labelControl616.Text = System.Environment.UserName;
                labelControl616.ForeColor = Color.Green;
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl618.Text = "Failed!";
                labelControl618.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Battlefield 3
        private void simpleButton184_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl641.Text = "Connected";
                labelControl641.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl641.Text = "Failed!";
                labelControl641.ForeColor = Color.Red;
            }
        }

        private void checkEdit68_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit68.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit67.Enabled = false;
            }
            else
            {
                checkEdit67.Enabled = true;
            }
        }

        private void checkEdit67_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit67.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit68.Enabled = false;
            }
            else
            {
                checkEdit68.Enabled = true;
            }
        }

        private void simpleButton183_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl639.Text = "Game Attached";
                labelControl639.ForeColor = Color.Green;
                labelControl637.Text = System.Environment.UserName;
                labelControl637.ForeColor = Color.Green;
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl639.Text = "Failed!";
                labelControl639.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach ???
        private void simpleButton188_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl645.Text = "Connected";
                labelControl645.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl645.Text = "Failed!";
                labelControl645.ForeColor = Color.Red;
            }
        }

        private void checkEdit72_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit72.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit71.Enabled = false;
            }
            else
            {
                checkEdit71.Enabled = true;
            }
        }

        private void checkEdit71_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit71.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit72.Enabled = false;
            }
            else
            {
                checkEdit72.Enabled = true;
            }
        }

        private void simpleButton187_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl643.Text = "Game Attached";
                labelControl643.ForeColor = Color.Green;
                labelControl244.Text = System.Environment.UserName;
                labelControl244.ForeColor = Color.Green;

            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl643.Text = "Failed!";
                labelControl643.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Battlefield 4
        private void simpleButton186_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl658.Text = "Connected";
                labelControl657.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl658.Text = "Failed!";
                labelControl658.ForeColor = Color.Red;
            }
        }

        private void checkEdit70_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit70.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit69.Enabled = false;
            }
            else
            {
                checkEdit69.Enabled = true;
            }
        }

        private void checkEdit69_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit69.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit70.Enabled = false;
            }
            else
            {
                checkEdit70.Enabled = true;
            }
        }

        private void simpleButton185_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl656.Text = "Game Attached";
                labelControl656.ForeColor = Color.Green;
                labelControl654.Text = System.Environment.UserName;
                labelControl654.ForeColor = Color.Green;

            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl656.Text = "Failed!";
                labelControl656.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Just Cause 2
        private void simpleButton172_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl675.Text = "Connected";
                labelControl675.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl675.Text = "Failed!";
                labelControl675.ForeColor = Color.Red;
            }
        }

        private void checkEdit56_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit56.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit55.Enabled = false;
            }
            else
            {
                checkEdit55.Enabled = true;
            }
        }

        private void checkEdit55_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit55.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit56.Enabled = false;
            }
            else
            {
                checkEdit56.Enabled = true;
            }
        }

        private void simpleButton171_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl673.Text = "Game Attached";
                labelControl673.ForeColor = Color.Green;
                labelControl236.Text = System.Environment.UserName;
                labelControl236.ForeColor = Color.Green;

            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl673.Text = "Failed!";
                labelControl673.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Skyrim
        private void simpleButton174_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl681.Text = "Connected";
                labelControl681.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl681.Text = "Failed!";
                labelControl681.ForeColor = Color.Red;
            }
        }

        private void checkEdit58_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit58.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit57.Enabled = false;
            }
            else
            {
                checkEdit57.Enabled = true;
            }
        }

        private void checkEdit57_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit57.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit58.Enabled = false;
            }
            else
            {
                checkEdit58.Enabled = true;
            }
        }

        private void simpleButton173_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl679.Text = "Game Attached";
                labelControl679.ForeColor = Color.Green;
                labelControl239.Text = System.Environment.UserName;
                labelControl239.ForeColor = Color.Green;

            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl679.Text = "Failed!";
                labelControl679.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Minecraft
        private void simpleButton168_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl694.Text = "Connected";
                labelControl694.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl694.Text = "Failed!";
                labelControl694.ForeColor = Color.Red;
            }
        }

        private void checkEdit52_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit52.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit51.Enabled = false;
            }
            else
            {
                checkEdit51.Enabled = true;
            }
        }

        private void checkEdit51_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit51.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit52.Enabled = false;
            }
            else
            {
                checkEdit52.Enabled = true;
            }
        }

        private void simpleButton167_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl692.Text = "Game Attached";
                labelControl692.ForeColor = Color.Green;
                labelControl683.Text = System.Environment.UserName;
                labelControl683.ForeColor = Color.Green;

            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl692.Text = "Failed!";
                labelControl692.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Dark Souls 2
        private void simpleButton162_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl727.Text = "Connected";
                labelControl727.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl727.Text = "Failed!";
                labelControl727.ForeColor = Color.Red;
            }
        }

        private void checkEdit32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit32.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit31.Enabled = false;
            }
            else
            {
                checkEdit31.Enabled = true;
            }
        }

        private void checkEdit31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit31.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit32.Enabled = false;
            }
            else
            {
                checkEdit32.Enabled = true;
            }
        }

        private void simpleButton161_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl725.Text = "Game Attached";
                labelControl725.ForeColor = Color.Green;
                labelControl231.Text = System.Environment.UserName;
                labelControl231.ForeColor = Color.Green;

            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl725.Text = "Failed!";
                labelControl725.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach ???
        private void simpleButton176_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl64.Text = "Connected";
                labelControl64.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl64.Text = "Failed!";
                labelControl64.ForeColor = Color.Red;
            }
        }

        private void checkEdit60_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit60.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit59.Enabled = false;
            }
            else
            {
                checkEdit59.Enabled = true;
            }
        }

        private void checkEdit59_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit59.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit60.Enabled = false;
            }
            else
            {
                checkEdit60.Enabled = true;
            }
        }

        private void simpleButton175_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl729.Text = "Game Attached";
                labelControl729.ForeColor = Color.Green;
                labelControl232.Text = System.Environment.UserName;
                labelControl232.ForeColor = Color.Green;

            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl729.Text = "Failed!";
                labelControl729.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach ???
        private void simpleButton160_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl717.Text = "Connected";
                labelControl717.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl717.Text = "Failed!";
                labelControl717.ForeColor = Color.Red;
            }
        }

        private void checkEdit30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit30.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit29.Enabled = false;
            }
            else
            {
                checkEdit29.Enabled = true;
            }
        }

        private void checkEdit29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit29.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit30.Enabled = false;
            }
            else
            {
                checkEdit30.Enabled = true;
            }
        }

        private void simpleButton159_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl715.Text = "Game Attached";
                labelControl715.ForeColor = Color.Green;
                labelControl713.Text = System.Environment.UserName;
                labelControl713.ForeColor = Color.Green;
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl715.Text = "Failed!";
                labelControl715.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Assassins Creed Rogue
        private void simpleButton611_Click_1(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl750.Text = "Connected";
                labelControl750.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl750.Text = "Failed!";
                labelControl750.ForeColor = Color.Red;
            }
        }

        private void checkEdit184_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit184.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit183.Enabled = false;
            }
            else
            {
                checkEdit183.Enabled = true;
            }
        }

        private void checkEdit183_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit183.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit184.Enabled = false;
            }
            else
            {
                checkEdit184.Enabled = true;
            }
        }

        private void simpleButton610_Click_1(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl601.Text = "Game Attached";
                labelControl601.ForeColor = Color.Green;
                labelControl152.Text = System.Environment.UserName;
                labelControl152.ForeColor = Color.Green;

            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl601.Text = "Failed!";
                labelControl601.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Red Dead Redemption
        private void checkEdit64_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit64.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit63.Enabled = false;
            }
            else
            {
                checkEdit63.Enabled = true;
            }
        }

        private void checkEdit63_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit63.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit64.Enabled = false;
            }
            else
            {
                checkEdit64.Enabled = true;
            }
        }

        private void simpleButton179_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl740.Text = "Game Attached";
                labelControl740.ForeColor = Color.Green;
                labelControl738.Text = System.Environment.UserName;
                labelControl738.ForeColor = Color.Green;

            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl740.Text = "Failed!";
                labelControl740.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Connect and Attach Black Ops 2
        private void simpleButton634_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl806.Text = "Connected";
                labelControl806.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl806.Text = "Failed!";
                labelControl806.ForeColor = Color.Red;
            }
        }

        private void checkEdit145_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkEdit145.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit3.Enabled = false;
            }
            else
            {
                checkEdit3.Enabled = true;
            }
        }

        private void checkEdit3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkEdit3.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit145.Enabled = false;
            }
            else
            {
                checkEdit145.Enabled = true;
            }
        }

        private void simpleButton633_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl804.Text = "Game Attached";
                labelControl804.ForeColor = Color.Green;
                labelControl802.Text = PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name);
                labelControl802.ForeColor = Color.Green;
                labelControl808.Text = labelControl802.Text;
                if (toggleSwitch224.IsOn)
                {
                    Games.Call_of_Duty_Black_Ops_2.RPC.Init();
                }
            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl804.Text = "Failed!";
                labelControl804.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Other Connect and Attach
        private void simpleButton180_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl742.Text = "Connected";
                labelControl742.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl742.Text = "Failed!";
                labelControl742.ForeColor = Color.Red;
            }
        }
        private void simpleButton615_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                XtraMessageBox.Show("PS3 Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl760.Text = "Connected";
                labelControl760.ForeColor = Color.Green;
            }
            else
            {

                XtraMessageBox.Show("PS3 Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl760.Text = "Failed!";
                labelControl760.ForeColor = Color.Red;
            }
        }

        private void checkEdit186_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit186.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit185.Enabled = false;
            }
            else
            {
                checkEdit185.Enabled = true;
            }
        }

        private void checkEdit185_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit185.Checked)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit186.Enabled = false;
            }
            else
            {
                checkEdit186.Enabled = true;
            }
        }

        private void simpleButton614_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                XtraMessageBox.Show("Game Attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl758.Text = "Game Attached";
                labelControl758.ForeColor = Color.Green;
                labelControl756.Text = System.Environment.UserName;
                labelControl756.ForeColor = Color.Green;

            }
            else
            {
                XtraMessageBox.Show("Game Not Found", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                labelControl758.Text = "Failed!";
                labelControl758.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Other Settings
        private void mich9_Click(object sender, EventArgs e)
        {
            if (mich8.Text == "XxBlud-23xX" | mich8.Text == "XxBlud23xX" | mich8.Text == "xxblud-23xx" | mich8.Text == "xXBlud-23Xx" | mich8.Text == "admin"
                 | mich8.Text == "Admin" | mich8.Text == "Administrator" | mich8.Text == "administrator" | mich8.Text == "BrandonCardenWV" | mich8.Text == "BrandonCarden"
                 | mich8.Text == "brandon Carden" | mich8.Text == "Brandon carden" | mich8.Text == "Creator" | mich8.Text == "creator" | mich8.Text == "xxblud23xx")
            {
                mich8.Text = "";
                labelControl901.ForeColor = Color.Red;
                labelControl901.Text = "Invalid username!";
            }
            else
            {
                labelControl901.ForeColor = Color.Green;
                labelControl901.Text = "That username is valid :)";
                Properties.Settings.Default.UserName = mich8.Text;
                textEdit312.Text = mich8.Text;
                textEdit1.Text = mich8.Text;
            }
			
			
        }
        private void mich10_Click(object sender, EventArgs e)
        {
            xtraUserControl1.Visible = false;
            panel1.Visible = false;
            mich1.Visible = false;
            mich2.Visible = false;
            mich3.Visible = false;
            mich4.Visible = false;
            mich5.Visible = false;
            mich6.Visible = false;
            mich7.Visible = false;
            mich8.Visible = false;
            mich9.Visible = false;
            mich10.Visible = false;
            labelControl901.Visible = false;
            tileControl1.Enabled = true;
            tileControl2.Enabled = true;
            tileControl3.Enabled = true;
            tileControl4.Enabled = true;
            tileControl5.Enabled = true;
            tileControl6.Enabled = true;
            tileControl7.Enabled = true;
            tileControl8.Enabled = true;
            xtraTabPage1.AutoScroll = true;
            Properties.Settings.Default.FirstRun = false;
        }
        private void mich2_CheckedChanged(object sender, EventArgs e)
        {
            if (mich2.Checked)
            {
                this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis";
                MainInterface mainInterface = new MainInterface();
                mainInterface.WhiteTheme(this);
                mich3.Enabled = false;
            }
            else
            {
                mich3.Enabled = true;
            }
        }
        private void mich3_CheckedChanged(object sender, EventArgs e)
        {
            if (mich3.Checked)
            {
                this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis Dark";
                MainInterface mainInterface = new MainInterface();
                mainInterface.BlackTheme(this);
                mich2.Enabled = false;
            }
            else
            {
                mich2.Enabled = true;
            }
        }
        private void simpleButton696_Click(object sender, EventArgs e)
        {
            labelControl900.Visible = false;
            pictureBox52.Visible = false;
            memoEdit6.Visible = false;
            simpleButton696.Visible = false;
            xtraUserControl1.Visible = true;
            mich1.Visible = true;
            mich2.Visible = true;
            mich3.Visible = true;
            mich4.Visible = true;
            mich5.Visible = true;
            mich6.Visible = true;
            mich7.Visible = true;
            mich8.Visible = true;
            mich9.Visible = true;
            mich10.Visible = true;
            labelControl901.Visible = true;
            labelControl901.BringToFront();
            mich1.BringToFront();
            mich2.BringToFront();
            mich3.BringToFront();
            mich4.BringToFront();
            mich5.BringToFront();
            mich6.BringToFront();
            mich7.BringToFront();
            mich8.BringToFront();
            mich9.BringToFront();
            mich10.BringToFront();

        }
        private void MovingLabel_Tick(object sender, EventArgs e)
        {
            labelControl899.Location = new Point(labelControl899.Location.X + 5, labelControl899.Location.Y);

            if (labelControl899.Location.X > this.Width)
            {
                labelControl899.Location = new Point(0 - labelControl899.Width, labelControl899.Location.Y);
            }
        }
        private void simpleButton612_Click(object sender, EventArgs e)
        {
            if (labelControl610.Text == "0")
            {
                TileItem newItem = new TileItem();
                newItem.ItemSize = TileItemSize.Medium;
                newItem.Elements.Add(new TileItemElement() { Text = "User Tile 1" });
                tileGroup8.Items.Add(newItem);
                newItem.AppearanceItem.Normal.BackColor = Color.Maroon;
                newItem.AppearanceItem.Normal.BackColor2 = Color.Maroon;
                newItem.AppearanceItem.Normal.BorderColor = Color.Maroon;
                labelControl610.Text = "1";
                XtraMessageBox.Show("Check the Other Tools Section.", "Tile Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (labelControl610.Text == "1")
            {
                textEdit305.Visible = false;
                textEdit306.Visible = false;
                textEdit314.Visible = true;
                textEdit315.Visible = true;
                simpleButton621.Location = new Point(38, 451);
                simpleButton612.Visible = false;
                simpleButton621.Visible = true;
            }
        }
        private void fontEdit12_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(fontEdit12.Text, 8, FontStyle.Bold);
            Properties.Settings.Default["chatFont"] = richTextBox1.Font;
        }

        private void colorEdit25_EditValueChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = colorEdit25.Color;
            Properties.Settings.Default["chatForeColor"] = richTextBox1.ForeColor;
        }

        private void colorEdit23_EditValueChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = colorEdit23.Color;
            Properties.Settings.Default["chatBackColor"] = richTextBox1.BackColor;
        }

        private void fontEdit13_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControl13.Font = new Font(fontEdit13.Text, 8, FontStyle.Bold);
            Properties.Settings.Default["usersOnlineFont"] = listBoxControl13.Font;
        }

        private void colorEdit27_EditValueChanged(object sender, EventArgs e)
        {
            listBoxControl13.ForeColor = colorEdit27.Color;
            Properties.Settings.Default["usersOnlineForeColor"] = listBoxControl13.ForeColor;
        }

        private void colorEdit26_EditValueChanged(object sender, EventArgs e)
        {
            listBoxControl13.BackColor = colorEdit26.Color;
            Properties.Settings.Default["usersOnlineBackColor"] = listBoxControl13.BackColor;
        }

        private void fontEdit14_SelectedIndexChanged(object sender, EventArgs e)
        {
            textEdit322.Font = new Font(fontEdit14.Text, 8, FontStyle.Bold);
            Properties.Settings.Default["messageFont"] = textEdit322.Font;
        }

        private void colorEdit29_EditValueChanged(object sender, EventArgs e)
        {
            textEdit322.ForeColor = colorEdit29.Color;
            Properties.Settings.Default["messageForeColor"] = textEdit322.ForeColor;
        }

        private void colorEdit28_EditValueChanged(object sender, EventArgs e)
        {
            textEdit322.BackColor = colorEdit28.Color;
            Properties.Settings.Default["messageBackColor"] = textEdit322.BackColor;
        }
        private void simpleButton609_Click_2(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("This will delete all changes you have made and restore the application to its original state when you first opened it!", "Are you sure you want to do this?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string AppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string FolderToDelete = Path.Combine(AppDataFolder, "ProjectRunningFox");

                Directory.Delete(FolderToDelete, true);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void toggleSwitch226_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch226.IsOn)
            {
                TileSettings tileSettings = new TileSettings();
                tileSettings.TextOnlyTrue(this);
            }
            else
            {
                TileSettings tileSettings = new TileSettings();
                tileSettings.TextOnlyFalse(this);
            }
        }

        private void toggleSwitch227_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch227.IsOn)
            {
                TileSettings tileSettings = new TileSettings();
                tileSettings.GameCasesTrue(this);
            }
            else
            {
                TileSettings tileSettings = new TileSettings();
                tileSettings.GamesCasesFalse(this);
            }
        }

        private void toggleSwitch228_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch228.IsOn)
            {
                TileSettings tileSettings = new TileSettings();
                tileSettings.TileCheckedTrue(this);
            }
            else
            {
                TileSettings tileSettings = new TileSettings();
                tileSettings.TileCheckedFalse(this);
            }
        }
        private void simpleButton618_Click_1(object sender, EventArgs e)
        {
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.Text == "XxBlud-23xX" | textEdit1.Text == "XxBlud23xX" | textEdit1.Text == "xxblud-23xx" | textEdit1.Text == "xXBlud-23Xx" | textEdit1.Text == "admin"
                | textEdit1.Text == "Admin" | textEdit1.Text == "Administrator" | textEdit1.Text == "administrator" | textEdit1.Text == "BrandonCardenWV" | textEdit1.Text == "BrandonCarden"
                | textEdit1.Text == "brandon Carden" | textEdit1.Text == "Brandon carden" | textEdit1.Text == "Creator" | textEdit1.Text == "creator" | textEdit1.Text == "xxblud23xx")
            {
                textEdit1.Text = "";
                textEdit312.Text = "";
                XtraMessageBox.Show("You cant use that username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                textEdit312.Text = textEdit1.Text;
            }
        }
        private void spinEdit34_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.NameFlashInterval(this);
        }

        private void spinEdit35_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.NameSliderInterval(this);
        }

        private void spinEdit36_EditValueChanged(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.NameSkipperInterval(this);
        }
        private void spinEdit37_EditValueChanged_1(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.RainBowName(this);
        }
        private void label1_TextChanged(object sender, EventArgs e)
        {
            Tutorial tut = new Tutorial();
            tut.TutorialPart1(this);
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            labelControl28.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == textEdit277.Text)
                ToolSettings.Show();
            if (e.Control && e.KeyCode.ToString() == textEdit313.Text)
                EbootLibrary.Show();
        }
        private void simpleButton632_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Project Running Fox Chatroom [BETA]\n\nRules :\n1.No Harassing!\n2.No Spamming!\n3.No Trolling!\n4.Don't impersonate me or other big name modders!\nFailure to comply will result in me forcing an update and removing this feature entirely!\n\nErrors : \n1.No nickname given User not enough parameters\nFix : Change your username in the Settings to something else!\n2.Wont connect?\nFix : Check your internet\n\nOther :\n1.This chat uses the username that you set if you have set one.\n2.Be sure to comply to these simple rules, dont ruin this for others!", "Chatroom - Rules and Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region Tool Settings
        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.Opacity = decimal.ToDouble(spinEdit1.Value) * 0.01;
        }
        private void toggleSwitch3_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch3.IsOn)
            {
                textEdit312.Visible = true;
            }
            else
            {
                textEdit312.Visible = false;
            }
        }
        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
        }

        private void toggleSwitch2_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch2.IsOn)
            {
                labelControl518.Visible = true;
            }
            else
            {
                labelControl518.Visible = false;
            }
        }

        private void toggleSwitch7_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch7.IsOn)
            {
                labelControl28.Visible = true;
                Clock.Start();
            }
            else
            {
                labelControl28.Visible = false;
                Clock.Stop();
            }
        }

        private void toggleSwitch5_Toggled(object sender, EventArgs e)
        {
        }

        private async void toggleSwitch8_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch8.IsOn)
            {
                await Task.Delay(60000);
                Random r = new Random();
                int index = r.Next(ProjectRunningFox.EbootLibrary.Tips.Length - 1);
                notifyIcon1.BalloonTipTitle = "Project Running Fox - Tip";
                notifyIcon1.BalloonTipText = ProjectRunningFox.EbootLibrary.Tips[index].ToString();
                notifyIcon1.ShowBalloonTip(250);
                notifyIcon1.Text = "Project Running Fox";
            }
            else
            {
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Use this if the headers dont save normally!", "Super Save Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion
        #region User Avatar
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            Image[] AllImageArr = new Image[]
                {
                  ProjectRunningFox.Properties.Resources.Avatar1, ProjectRunningFox.Properties.Resources.Avatar2, 
                    ProjectRunningFox.Properties.Resources.Avatar3, ProjectRunningFox.Properties.Resources.Avatar4, 
                    ProjectRunningFox.Properties.Resources.Avatar5,
                  };
            if (avatarIndex > 0)
            {
                avatarIndex -= 1;
                textEdit15.Text = ProjectRunningFox.EbootLibrary.AvatarCount[avatarIndex];
                pictureBox1.Image = AllImageArr[avatarIndex];
                pictureBox2.Image = AllImageArr[avatarIndex];
            }
        }
        private void simpleButton24_Click(object sender, EventArgs e)
        {
            Image[] AllImageArr = new Image[]
                {
                   ProjectRunningFox.Properties.Resources.Avatar1, ProjectRunningFox.Properties.Resources.Avatar2, 
                    ProjectRunningFox.Properties.Resources.Avatar3, ProjectRunningFox.Properties.Resources.Avatar4, 
                    ProjectRunningFox.Properties.Resources.Avatar5, 
                  };
            if (avatarIndex < ProjectRunningFox.EbootLibrary.AvatarCount.Count() - 1)
            {
                avatarIndex += 1;
                textEdit15.Text = ProjectRunningFox.EbootLibrary.AvatarCount[avatarIndex];
                pictureBox1.Image = AllImageArr[avatarIndex];
                pictureBox2.Image = AllImageArr[avatarIndex];
            }
        }
        #endregion
        #region Control Console Options
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ToolSettings toolSettings = new ToolSettings();
            toolSettings.CCAPISetText(this);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetConsoleID(textEdit14.Text);
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetBootConsoleID(textEdit14.Text);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.ShutDown);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.SoftReboot);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.HardReboot);
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Single);
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Double);
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Continuous);
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Green, PS3Lib.CCAPI.LedMode.Off);
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Red, PS3Lib.CCAPI.LedMode.Off);
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Green, PS3Lib.CCAPI.LedMode.On);
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Red, PS3Lib.CCAPI.LedMode.On);
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Green, PS3Lib.CCAPI.LedMode.Blink);
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Red, PS3Lib.CCAPI.LedMode.Blink);
        }
        #endregion
        #region Send Email
        private void simpleButton12_Click(object sender, EventArgs e)
        {
            try
            {
                var mail = new MailMessage();
                var client = new SmtpClient("mail.smtp2go.com", 2525)
                {
                    Credentials = new NetworkCredential("brandonalex234@hotmail.com", "3xETChFpG79n"),
                    EnableSsl = true
                };
                MailMessage objMsg = new MailMessage();
                objMsg.Body = textEdit2.Text;
                objMsg.Subject = textEdit3.Text;
                objMsg.From = new MailAddress(textEdit4.Text.ToString());
                objMsg.To.Add(new MailAddress("brandoncardenwv@gmail.com"));
                client.Send(objMsg);
                XtraMessageBox.Show("Your email was sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Your message didnt send, check your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Quick Acesss Links & Tools
        private void tileItem28_ItemClick(object sender, TileItemEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ps3ita.it/");
        }

        private void tileItem29_ItemClick(object sender, TileItemEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rebug.me/");
        }

        private void tileItem30_ItemClick(object sender, TileItemEventArgs e)
        {
            System.Diagnostics.Process.Start("http://store.brewology.com/homebrew.php?lang=");
        }

        private void tileItem31_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Program Files \Filezilla FTP Client\filezilla.exe");
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Application not found. Make sure you have the \n application installed in the default path. ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tileItem27_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\SN Systems\\PS3\bin\ps3tm.exe");
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Application not found. Make sure you have the \n application installed in the default path. ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tileItem33_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\ControlConsoleAPI\CCAPIConsoleManager.exe");
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Application not found. Make sure you have the \n application installed in the default path. ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tileItem32_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Notepad++\notepad++.exe");
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Application not found. Make sure you have the \n application installed in the default path. ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region World at War Modifications
        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit2.Value);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.Kills, PRF);
        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit3.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.Deaths, PRF);
        }

        private void checkEdit6_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit4.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.HeadShots, PRF);
        }

        private void checkEdit7_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit5.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.XP, PRF);
        }

        private void checkEdit8_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit6.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.TimePlayedDays, PRF);
        }

        private void checkEdit9_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit7.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.TimePlayedHours, PRF);
        }

        private void checkEdit10_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit8.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.TimePlayedMinutes, PRF);
        }

        private void checkEdit11_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit9.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.Beststreak, PRF);
        }

        private void checkEdit12_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit10.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.Prestige, PRF);
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetStats setStats = new Games.Call_of_Duty_World_at_War.SetStats();
            setStats.LegitStats(this);
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetStats setStats = new Games.Call_of_Duty_World_at_War.SetStats();
            setStats.HighStats(this);
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetStats setStats = new Games.Call_of_Duty_World_at_War.SetStats();
            setStats.InsaneStats(this);
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetStats setStats = new Games.Call_of_Duty_World_at_War.SetStats();
            setStats.SendAll(this);
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetStats setStats = new Games.Call_of_Duty_World_at_War.SetStats();
            setStats.ClearAll(this);
        }

        private void COD5PLoop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 10);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.Prestige, Code1);
            COD5PLoop.Start();
        }

        private void toggleSwitch4_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch4.IsOn)
            {
                COD5PLoop.Start();
            }
            else
            {
                COD5PLoop.Stop();
            }
        }

        private void simpleButton32_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x0B };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.Prestige, PRF);
        }

        private void simpleButton33_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xF0, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Stats.UnlockAll, buffer);
        }

        private void toggleSwitch6_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch6.IsOn)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.UI_ShowList, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.UI_ShowList, buffer);
            }
        }

        private void toggleSwitch9_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch9.IsOn)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Crosshair, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Crosshair, buffer);
            }
        }

        private void toggleSwitch10_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch10.IsOn)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.HudsOff, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.HudsOff, buffer);
            }
        }

        private void toggleSwitch13_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch13.IsOn)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.LagOMeter, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.LagOMeter, buffer);
            }
        }

        private void toggleSwitch12_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch12.IsOn)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Laser, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Laser, buffer);
            }
        }

        private void toggleSwitch11_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch11.IsOn)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.ThirdPerson, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.ThirdPerson, buffer);
            }
        }

        private void toggleSwitch16_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch16.IsOn)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.DrawGun, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.DrawGun, buffer);
            }
        }

        private void toggleSwitch15_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch15.IsOn)
            {
                byte[] buffer = new byte[] { 0x42, 0xA0 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.WallHack, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x40, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.WallHack, buffer);
            }
        }

        private void toggleSwitch14_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch14.IsOn)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Fog, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Fog, buffer);
            }
        }

        private void toggleSwitch19_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch19.IsOn)
            {
                byte[] buffer = new byte[] { 0x4F, 0xFF };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.FarKnife, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x43, 0x80 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.FarKnife, buffer);
            }
        }

        private void toggleSwitch18_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch18.IsOn)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.SustainAmmo, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.SustainAmmo, buffer);
            }
        }

        private void toggleSwitch17_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch17.IsOn)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Blur, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Blur, buffer);
            }
        }

        private void comboBoxEdit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit3.SelectedIndex == 0)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.FlameVision, buffer);
            }
            if (comboBoxEdit3.SelectedIndex == 1)
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.FlameVision, buffer);
            }
            if (comboBoxEdit3.SelectedIndex == 2)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.WaterVision, buffer);
            }
            if (comboBoxEdit3.SelectedIndex == 3)
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.WaterVision, buffer);
            }
            if (comboBoxEdit3.SelectedIndex == 4)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.DofTweak, buffer);
            }
            if (comboBoxEdit3.SelectedIndex == 5)
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.DofTweak, buffer);
            }
            if (comboBoxEdit3.SelectedIndex == 6)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.BlackandWhite, buffer);
            }
            if (comboBoxEdit3.SelectedIndex == 7)
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.BlackandWhite, buffer);
            }
        }

        private void comboBoxEdit4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit4.SelectedIndex == 0)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.MapColor, buffer);
            }
            if (comboBoxEdit4.SelectedIndex == 1)
            {
                byte[] buffer = new byte[] { 0x06 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.MapColor, buffer);
            }
            if (comboBoxEdit4.SelectedIndex == 2)
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.MapColor, buffer);
            }
            if (comboBoxEdit4.SelectedIndex == 3)
            {
                byte[] buffer = new byte[] { 0x02 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.MapColor, buffer);
            }
        }

        private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void trackBarControl2_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton68_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit23.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class1, bytes);
        }

        private void simpleButton67_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit26.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class1, bytes);
        }

        private void simpleButton66_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit25.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class2, bytes);
        }

        private void simpleButton65_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit24.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class3, bytes);
        }

        private void simpleButton64_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit16.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class4, bytes);
        }

        private void simpleButton63_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit17.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class5, bytes);
        }

        private void simpleButton62_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit18.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class6, bytes);
        }

        private void simpleButton61_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit19.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class7, bytes);
        }

        private void simpleButton38_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit20.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class8, bytes);
        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit21.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class9, bytes);
        }

        private void simpleButton36_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit22.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class10, bytes);
        }

        private void simpleButton73_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetMod setMod = new Games.Call_of_Duty_World_at_War.SetMod();
            setMod.SetAllClasses(this);
        }

        private void simpleButton72_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetMod setMod = new Games.Call_of_Duty_World_at_War.SetMod();
            setMod.CreatorClasses(this);
        }

        private void simpleButton71_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetMod setMod = new Games.Call_of_Duty_World_at_War.SetMod();
            setMod.ColoredClasses(this);
        }

        private void simpleButton74_Click(object sender, EventArgs e)
        {
            listBoxControl2.Items.Clear();
            listBoxControl2.Items.Add("All Players");
            for (int i = 0; i <= ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.MaxClients - 1; i++)
            {
                listBoxControl2.Items.Add(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Scripts.GetNames(i));
            }
        }

        private void simpleButton78_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton1.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.GodModeON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.GodModeOFF(this);
            }
        }

        private void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Field_of_view, (float)zoomTrackBarControl1.Value);
        }

        private void zoomTrackBarControl2_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.CompassSize, (float)zoomTrackBarControl2.Value);
        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton2.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.AmmoON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.AmmoOFF(this);
            }
        }

        private void checkButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton3.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.DoubleSpeedON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.DoubleSpeedOFF(this);
            }
        }
        private void checkButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton4.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.NoClipON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.NoClipOFF(this);
            }
        }

        private void checkButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton9.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.StandUpON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.StandUpOFF(this);
            }
        }

        private void checkButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton11.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.DrunkVisionON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.DrunkVisionOFF(this);
            }
        }

        private void checkButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton12.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.WeirdGunON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.WeirdGunOFF(this);
            }
        }

        private void checkButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton5.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.UFOModeON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.UFOModeOFF(this);
            }
        }

        private void checkButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton6.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.FreezeON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.FreezeOFF(this);
            }
        }

        private void checkButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton7.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.LagON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.LagOFF(this);
            }
        }

        private void checkButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton8.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.CrossHairSize(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.CrossHairSizeOFF(this);
            }
        }

        private void checkButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton10.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.CrouchON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.CrouchOFF(this);
            }
        }

        private void checkButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton14.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.BloodyVisionON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.BloodyVisionOFF(this);
            }
        }

        private void checkButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton15.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.InvisibleWeaponON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_World_at_War.SetMod();
                setMod.InvisibleWeaponOFF(this);
            }
        }

        private void simpleButton69_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit28.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame, bytes);
        }

        private void NameChanger(uint uint_8, string string_4)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(string_4);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(uint_8, bytes);
        }

        private void simpleButton70_Click(object sender, EventArgs e)
        {
            NameChanger(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame + ((uint)this.spinEdit11.Value - 1u) * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient, this.textEdit28.Text);
        }

        private void COD5Advertise_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit28.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame11, bytes);
        }

        private void toggleSwitch25_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch25.IsOn)
            {
                COD5Advertise.Start();
            }
            else
            {
                COD5Advertise.Stop();
            }
        }

        private void simpleButton39_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit36.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton40_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl96.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
            textEdit36.Text = labelControl96.Text;
        }

        private void COD5NameFlash_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit36.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void toggleSwitch20_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch20.IsOn)
            {
                COD5NameFlash.Start();
            }
            else
            {
                COD5NameFlash.Stop();
            }
        }

        private void simpleButton42_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit37.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton41_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl96.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
            textEdit37.Text = labelControl96.Text;
        }

        private void COD5NameSlider_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetMod setMod = new Games.Call_of_Duty_World_at_War.SetMod();
            setMod.NameSlider(this);
        }

        private void toggleSwitch21_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch21.IsOn)
            {
                COD5NameSlider.Start();
            }
            else
            {
                COD5NameSlider.Stop();
            }
        }

        private void COD5Clock_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, DateTime.Now.ToString("hh:mm:ss"));
        }

        private void toggleSwitch22_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch22.IsOn)
            {
                COD5Clock.Start();
            }
            else
            {
                COD5Clock.Stop();
            }
        }

        private void textEdit36_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton39.PerformClick();
            }
        }

        private void COD5Skipper_Tick(object sender, EventArgs e)
        {
            groupControl29.Text = Convert.ToString(stopWatch.Elapsed);
            if (groupControl29.Text.Contains("00:00:06."))
            {
                stopWatch.Restart();
            }
        }

        private void COD5Skipper2_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetMod setMod = new Games.Call_of_Duty_World_at_War.SetMod();
            setMod.SkipperName(this);
        }

        private void toggleSwitch24_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch24.IsOn)
            {
                stopWatch.Start();
                COD5Skipper2.Start();
                COD5Skipper.Start();
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                COD5Skipper.Stop();
                COD5Skipper2.Stop();
            }
        }

        private void COD5RB_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_World_at_War.SetMod setMod = new Games.Call_of_Duty_World_at_War.SetMod();
            setMod.RainBowName(this);
        }

        private void toggleSwitch23_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch23.IsOn)
            {
                COD5RB.Start();
            }
            else
            {
                COD5RB.Stop();
            }
        }

        private void simpleButton43_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton44_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BrandonCardenWV");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton45_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1CFG is Gay!");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton48_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Hacking...");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton47_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2$5 ^4PayPal");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton46_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Modded Lobby");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton51_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1REBUG");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton50_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PS3ITA");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton49_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2HABIB");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton54_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit72.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton53_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit73.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton52_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit75.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This option was introduced in my Black Ops 2 RTM tool\nand i have received a lot of great feedback becuase of it.\nTo edit these presets go to the Tool Settings!", "Custom Preset Names", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton60_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+gostand}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton59_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+usereload}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton58_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+melee}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton57_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{weapnext}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton56_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+smoke}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton55_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+breathe_sprint}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton76_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit27.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Addresses.MOTD, bytes);
        }

        private void simpleButton75_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_World_at_War.Scripts.Cbuf_AddText(0, textEdit56.Text);
        }

        private void simpleButton77_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit83.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Addresses.PlayersOnline, bytes);
        }
        #endregion
        #region Modern Warfare 2 Modification
        private void checkEdit17_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit16.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.Kills, PRF);
        }

        private void checkEdit18_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit17.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.Deaths, PRF);
        }

        private void checkEdit19_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit18.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.HeadShots, PRF);
        }

        private void checkEdit20_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit19.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.Score, PRF);
        }

        private void checkEdit21_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit20.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.Wins, PRF);
        }

        private void checkEdit22_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit21.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.Losses, PRF);
        }

        private void checkEdit23_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit22.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.Ties, PRF);
        }

        private void checkEdit24_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit23.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.Assists, PRF);
        }

        private void checkEdit25_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit24.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.WinStreak, PRF);
        }

        private void checkEdit26_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit25.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.KillStreak, PRF);
        }

        private void checkEdit27_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit26.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.XP, PRF);
        }

        private void checkEdit28_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit27.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.Prestige, PRF);
        }

        private void simpleButton86_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetStats setStats = new Games.Call_of_Duty_MW2.SetStats();
            setStats.LegitStats(this);
        }

        private void simpleButton87_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetStats setStats = new Games.Call_of_Duty_MW2.SetStats();
            setStats.HighStats(this);
        }

        private void simpleButton85_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetStats setStats = new Games.Call_of_Duty_MW2.SetStats();
            setStats.InsaneStats(this);
        }

        private void simpleButton84_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetStats setStats = new Games.Call_of_Duty_MW2.SetStats();
            setStats.SendAll(this);
        }

        private void simpleButton83_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetStats setStats = new Games.Call_of_Duty_MW2.SetStats();
            setStats.ClearAll(this);
        }

        private void MW2Loop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 10);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.Prestige, Code1);
            MW2Loop.Start();
        }

        private void toggleSwitch26_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch26.IsOn)
            {
                MW2Loop.Start();
            }
            else
            {
                MW2Loop.Stop();
            }
        }

        private void simpleButton89_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x20, 0x64, 0x26, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.XP, PRF);
        }

        private void simpleButton88_Click(object sender, EventArgs e)
        {
            simpleButton89.PerformClick();
            byte[] UnlockAll = new byte[] { 0x0A, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x02, 0x02, 0x02, 0x09, 0x09, 0x02, 0x02, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x04, 0x02, 0x04, 0x04, 0x04, 0x02, 0x04, 0x04, 0x02, 0x02, 0x03, 0x03, 0x03, 0x02, 0x03, 0x05, 0x05, 0x05, 0x05, 0x05, 0x02, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0xF4, 0x30, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xC4, 0x09, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xC4, 0x09, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xC4, 0x09, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xC4, 0x09, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xB0, 0x04, 0x00, 0x00, 0xB0, 0x04, 0x00, 0x00, 0xB0, 0x04, 0x00, 0x00, 0xB0, 0x04, 0x00, 0x00, 0xFA, 0x00, 0x00, 0x00, 0x00, 0x61, 0x08, 0x00, 0x0F, 0x40, 0x00, 0x00, 0xFA, 0x00, 0x00, 0x00, 0xFA, 0x00, 0x00, 0x00, 0xEE, 0x02, 0x00, 0x00, 0x84, 0x03, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0xFA, 0x00, 0x00, 0x00, 0xEE, 0x02, 0x00, 0x00, 0xFA, 0x00, 0x00, 0x00, 0x64, 0x00, 0x00, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x64, 0x00, 0x00, 0x00, 0xEE, 0x02, 0x00, 0x00, 0x40, 0x24, 0x14, 0x00, 0x0F, 0x40, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xC8, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x50, 0xC3, 0x00, 0x00, 0x50, 0xC3, 0x00, 0x00, 0x64, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0xC8, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xFA, 0x00, 0x00, 0x00, 0x64, 0x00, 0x00, 0x00, 0xE8, 0x03, 0x00, 0x00, 0x2C, 0x00, 0x00, 0x00, 0x2C, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x13, 0x00, 0x18, 0x00, 0x00, 0x00, 0x67, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x0F, 0xFA, 0xFF, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFE, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xBF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x78, 0xDD, 0x99, 0x03 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Stats.UnlockAll, UnlockAll);
        }

        private void toggleSwitch27_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch27.IsOn)
            {
                byte[] PRF = new byte[] { 0x2f, 0x80, 0x00, 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.RedBoxes, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x2f, 0x80, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.RedBoxes, PRF);
            }
        }
        private void toggleSwitch28_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch28.IsOn)
            {
                byte[] PRF = new byte[] { 0x39, 0x40, 0x00, 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Laser, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x39, 0x40, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Laser, PRF);
            }
        }

        private void toggleSwitch29_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch29.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0, 0, 0 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.NoRecoil, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x4B, 0xFA, 0x10, 0xF5 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.NoRecoil, PRF);
            }
        }
        private void toggleSwitch30_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch30.IsOn)
            {
                byte[] PRF = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.UAV, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.UAV, PRF);
            }
        }
        private void simpleButton100_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit29.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class1, bytes);
        }

        private void simpleButton99_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit47.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class1, bytes);
        }

        private void simpleButton98_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit46.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class2, bytes);
        }

        private void simpleButton97_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit45.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class3, bytes);
        }

        private void simpleButton96_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit44.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class4, bytes);
        }

        private void simpleButton95_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit35.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class5, bytes);
        }

        private void simpleButton94_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit34.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class6, bytes);
        }

        private void simpleButton93_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit33.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class7, bytes);
        }

        private void simpleButton92_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit32.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class8, bytes);
        }

        private void simpleButton91_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit31.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class9, bytes);
        }

        private void simpleButton90_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit30.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class10, bytes);
        }

        private void simpleButton103_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetMod setMod = new Games.Call_of_Duty_MW2.SetMod();
            setMod.SetAllClasses(this);
        }

        private void simpleButton102_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetMod setMod = new Games.Call_of_Duty_MW2.SetMod();
            setMod.CreatorClasses(this);
        }

        private void simpleButton101_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetMod setMod = new Games.Call_of_Duty_MW2.SetMod();
            setMod.ColoredClasses(this);
        }

        private void simpleButton105_Click(object sender, EventArgs e)
        {
            listBoxControl3.Items.Clear();
            listBoxControl3.Items.Add("All Players");
            for (int i = 0; i < 12; i++)
            {
                listBoxControl3.Items.Add(ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(i));
            }
        }

        private void simpleButton104_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton28.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.GodModeON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.GodModeOFF(this);
            }
        }

        private void checkButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton27.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.AmmoON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.AmmoOFF(this);
            }
        }

        private void checkButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton26.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.DoubleSpeedON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.DoubleSpeedOFF(this);
            }
        }

        private void checkButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton25.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.NoClipON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.NoClipOFF(this);
            }
        }

        private void checkButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton20.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.FreezeON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.FreezeOFF(this);
            }
        }

        private void checkButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton18.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.MiniMapOFF(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.MiniMapON(this);
            }
        }

        private void checkButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton17.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.UAVON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.UAVOFF(this);
            }
        }

        private void checkButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton29.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.PrimaryAkimboON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.PrimaryAkimboOFF(this);
            }
        }

        private void checkButton30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton30.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.SecondaryAkimboON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.SecondaryAkimboOFF(this);
            }
        }

        private void checkButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton33.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.LAGON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.LAGOFF(this);
            }
        }

        private void toggleSwitch37_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch37.IsOn)
            {
                Conditionals conditions = new Conditionals();
                conditions.PrintTextModsON(this);
            }
            else
            {
                Conditionals conditions = new Conditionals();
                conditions.PrintTextModsOFF(this);
            }
        }

        private void simpleButton147_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This is the text that appears on your screen when you enable a modification.\nEx. Unlimited Ammo ON", "iPrintLn Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkButton34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton34.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.RedBoxesON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.RedBoxesOFF(this);
            }
        }

        private void checkButton32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton32.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.KillClient(this);
                checkButton32.Checked = false;
            }
            else
            {
            }
        }

        private void checkButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton24.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.UFOModeON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.UFOModeOFF(this);
            }
        }

        private void checkButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton23.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.SmallCrosshairON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.SmallCrosshairOFF(this);
            }
        }

        private void checkButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton22.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.SkateModON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.SkateModOFF(this);
            }
        }

        private void checkButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton21.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.ExplosiveBulletsON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.ExplosiveBulletsOFF(this);
            }
        }

        private void checkButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton19.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.AllPerksON(this);
                checkButton19.Checked = false;
            }
            else
            {
            }
        }

        private void checkButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton16.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.NightVisionON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.NightVisionOFF(this);
            }
        }

        private void checkButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton13.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.TeleportToSky(this);
                checkButton13.Checked = false;
            }
            else
            {
            }
        }

        private void checkButton38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton38.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.TeleportToSpace(this);
                checkButton38.Checked = false;
            }
            else
            {
            }
        }

        private void checkButton37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton37.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.TeleportUnderMap(this);
                checkButton37.Checked = false;
            }
            else
            {
            }
        }

        private void checkButton35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton35.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.AutoProneON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.AutoProneOFF(this);
            }
        }

        private void checkButton36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton36.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.DisableJump(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.EnableJump(this);
            }
        }

        private void checkButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton31.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.DisableSprint(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_MW2.SetMod();
                setMod.EnableSprint(this);
            }
        }

        private void comboBoxEdit5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.PrimaryCamos(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.CamoByte.Camos[comboBoxEdit5.SelectedIndex], "Camo changed to : " + comboBoxEdit5.Text);
        }

        private void comboBoxEdit6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SecondaryCamos(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.CamoByte.Camos[comboBoxEdit6.SelectedIndex], "Camo changed to : " + comboBoxEdit6.Text);
        }

        private void comboBoxEdit8_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxEdit7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxEdit10_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.ChangeTeam(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.WeaponBytes166.Team[comboBoxEdit10.SelectedIndex], "Team changed to : " + comboBoxEdit10.Text);
        }

        private void simpleButton151_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetMod setMod = new Games.Call_of_Duty_MW2.SetMod();
            setMod.RPCText1(this);
        }

        private void simpleButton150_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetMod setMod = new Games.Call_of_Duty_MW2.SetMod();
            setMod.RPCText2(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void visitWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Website is not available at the moment.");
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                checkForUpdates();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("You have the current version.", "No updates are available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton107_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetMod setMod = new Games.Call_of_Duty_MW2.SetMod();
            setMod.SetAllNames(this);
        }

        private void simpleButton106_Click(object sender, EventArgs e)
        {
            NameChanger(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame + ((uint)this.spinEdit28.Value - 1u) * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient, this.textEdit48.Text);
        }

        private void MW2Advertise_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit48.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame11, bytes);
        }

        private void toggleSwitch31_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch31.IsOn)
            {
                MW2Advertise.Start();
            }
            else
            {
                MW2Advertise.Stop();
            }
        }

        private void simpleButton79_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(0, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(1, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(2, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(3, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(4, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(5, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(6, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(7, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(8, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(9, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(10, "N 2064 0A000"); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.SV_GameSendServerCommand(11, "N 2064 0A000");
        }

        private void simpleButton130_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(0); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(1); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(2); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(3); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(4); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(5); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(6); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(7); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(8); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(9); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(10); ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GiveUnlockAll(11);
        }

        public static String KeyBoard(String Title, String PresetText = "", Int32 MaxLength = 20)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW2.RPC.Call(0x238070, 0, Title, PresetText, MaxLength, 0x70B4D8);
            while (PS3.Extension.ReadInt32(0x203B4C8) != 0) continue;
            return PS3.Extension.ReadString(0x2510E22);
        }

        private void simpleButton145_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(KeyBoard("Project Running Fox Keyboard [MW2]", "", 50));
        }

        private void simpleButton146_Click(object sender, EventArgs e)
        {
        }

        public bool ButtonPressed(int client, string Button)
        {
            if (PS3.Extension.ReadString(0x34750E9F + ((uint)client * 0x97F80)) == Button)
                return true;
            else return false;
        }

        private void MW2HostJetPack_Tick(object sender, EventArgs e)
        {
            if (ButtonPressed(0, Games.Call_of_Duty_MW2.SetMod.Buttonz.Cross))
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.JetPack(0);
        }

        private void checkButton39_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton129_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit63.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton128_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl104.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
            textEdit63.Text = labelControl104.Text;
        }

        private void MW2NameFlash_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit63.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void toggleSwitch36_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch36.IsOn)
            {
                MW2NameFlash.Start();
            }
            else
            {
                MW2NameFlash.Stop();
            }
        }

        private void simpleButton126_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit62.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton127_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl104.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
            textEdit62.Text = labelControl104.Text;
        }

        private void MW2NameSlider_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetMod setMod = new Games.Call_of_Duty_MW2.SetMod();
            setMod.NameSlider(this);
        }

        private void toggleSwitch35_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch35.IsOn)
            {
                MW2NameSlider.Start();
            }
            else
            {
                MW2NameSlider.Stop();
            }
        }

        private void MW2Clock_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, DateTime.Now.ToString("hh:mm:ss"));
        }

        private void toggleSwitch34_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch34.IsOn)
            {
                MW2Clock.Start();
            }
            else
            {
                MW2Clock.Stop();
            }
        }

        private void MW2Skipper_Tick(object sender, EventArgs e)
        {
            groupControl51.Text = Convert.ToString(stopWatch.Elapsed);
            if (groupControl51.Text.Contains("00:00:06."))
            {
                stopWatch.Restart();
            }
        }

        private void MW2Skipper2_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetMod setMod = new Games.Call_of_Duty_MW2.SetMod();
            setMod.SkipperName(this);
        }

        private void toggleSwitch33_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch33.IsOn)
            {
                MW2Skipper.Start();
                MW2Skipper2.Start();
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                MW2Skipper.Stop();
                MW2Skipper2.Stop();
            }
        }

        private void toggleSwitch32_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch32.IsOn)
            {
                MW2RB.Start();
            }
            else
            {
                MW2RB.Stop();
            }
        }

        private void MW2RB_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW2.SetMod setMod = new Games.Call_of_Duty_MW2.SetMod();
            setMod.RainBowName(this);
        }

        private void textEdit63_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton129.PerformClick();
            }
        }

        private void textEdit63_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton125_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton124_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BrandonCardenWV");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton123_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1CFW FTW");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton122_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Hacking...");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton121_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2$5 ^4PayPal");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton120_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Modded Lobby");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton119_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1REBUG");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton118_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PS3ITA");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton117_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2HABIB");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton116_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit84.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton115_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit69.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton114_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit67.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton113_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+gostand}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton112_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+usereload}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton111_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+melee}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton110_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{weapnext}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton109_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+smoke}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton108_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+breathe_sprint}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, bytes);
        }
        #endregion
        #region Modern Warfare 3 Modifications
        private void checkEdit73_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit12.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Kills, PRF);
        }
        private void simpleButton596_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit304.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.ClanTag, bytes);
        }

        private void simpleButton235_Click_1(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PRF");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.ClanTag, bytes);
        }

        private void simpleButton236_Click_1(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("iMOD");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.ClanTag, bytes);
        }

        private void simpleButton271_Click_1(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x01 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.GoldClanTag, PRF);
        }

        private void simpleButton272_Click_1(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.GoldClanTag, PRF);
        }

        private void simpleButton597_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x01, 0x8C, 0x4E, 0x6C, 0x00, 0x56, 0x76, 0x64, 0x00, 0x04, 0x00, 0x00, 0x01 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.GameBrightNess, PRF);
        }

        private void simpleButton598_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x01, 0x8C, 0x4E, 0x6C, 0x00, 0x56, 0x76, 0x64, 0x00, 0x04, 0x00, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.GameBrightNess, PRF);
        }


        private void checkEdit74_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit13.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Deaths, PRF);
        }

        private void checkEdit75_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit14.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Headshots, PRF);
        }

        private void checkEdit76_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit15.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Score, PRF);
        }

        private void checkEdit77_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit29.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Wins, PRF);
        }

        private void checkEdit78_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit30.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Losses, PRF);
        }

        private void checkEdit79_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit31.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Ties, PRF);
        }

        private void checkEdit80_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit32.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.KillStreak, PRF);
        }

        private void checkEdit81_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit33.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.WinStreak, PRF);
        }

        private void checkEdit82_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit38.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Hits, PRF);
        }

        private void checkEdit83_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit39.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Misses, PRF);
        }

        private void checkEdit84_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit40.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Tokens, PRF);
        }

        private void checkEdit85_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit41.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.XP, PRF);
        }

        private void checkEdit87_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit43.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.DoubleXP, PRF);
        }

        private void checkEdit88_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit44.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.DoubleWeaponXP, PRF);
        }

        private void checkEdit86_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit42.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Prestige, PRF);
        }

        private void simpleButton219_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetStats setStats = new Games.Call_of_Duty_MW3.SetStats();
            setStats.LegitStats(this);
        }

        private void simpleButton220_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetStats setStats = new Games.Call_of_Duty_MW3.SetStats();
            setStats.HighStats(this);
        }

        private void simpleButton218_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetStats setStats = new Games.Call_of_Duty_MW3.SetStats();
            setStats.InsaneStats(this);
        }

        private void simpleButton217_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetStats setStats = new Games.Call_of_Duty_MW3.SetStats();
            setStats.SendAll(this);
        }

        private void simpleButton216_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetStats setStats = new Games.Call_of_Duty_MW3.SetStats();
            setStats.ClearAll(this);
        }

        private void MW3Loop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 20);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.Prestige, Code1);
            MW3Loop.Start();
        }

        private void toggleSwitch5_Toggled_1(object sender, EventArgs e)
        {
            if (toggleSwitch5.IsOn)
            {
                MW3Loop.Start();
            }
            else
            {
                MW3Loop.Stop();
            }
        }

        private void simpleButton214_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW3.UnlockAll.Unlock_All();
        }

        private void simpleButton221_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 01, 27, 00, 09, 00, 00, 00, 00, 00, 86, 00, 00, 00, 07, 00, 09, 00, 00, 00, 00, 00, 86, 00, 00, 00, 0x6A, 00, 0x0F, 00, 11, 00, 08, 00, 00, 00, 61, 00, 83, 00, 00, 00, 73, 77, 61, 67, 0x2E, 63, 0x6C, 61, 73, 73, 00, 73, 73, 20, 32, 00, 54, 20, 31, 00, 00, 76, 00, 20, 00, 20, 00, 20, 00, 13, 00, 14, 00, 19, 00, 0x2D, 00, 26, 00, 27, 00, 02, 00, 00, 00, 04, 00, 00, 00, 06, 00, 0x6B, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 37 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Stats.GodModeClass, buffer);
        }

        private void toggleSwitch38_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch38.IsOn)
            {
                byte[] buffer = new byte[] { 58, 40, 00, 56, 76, 14, 00, 04, 01, 00, 05, 90, 40, 45, 00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.WallHack, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 8, 40, 00, 56, 76, 14, 00, 04, 01, 00, 00, 00, 00, 00, 00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.WallHack, buffer);
            }
        }

        private void toggleSwitch39_Toggled(object sender, EventArgs e)
        {
        }

        private void toggleSwitch40_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch40.IsOn)
            {
                byte[] buffer = new byte[] { 00, 00, 00, 00, 00, 53, 0xC5, 48, 00, 44, 05, 00, 01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.NoFog, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 00, 00, 00, 00, 00, 53, 0xC5, 48, 00, 44, 05, 00, 00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.NoFog, buffer);
            }
        }

        private void toggleSwitch42_Toggled(object sender, EventArgs e)
        {
        }

        private void toggleSwitch41_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch41.IsOn)
            {
                byte[] buffer = new byte[] { 01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.AdvancedUAV, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.AdvancedUAV, buffer);
            }
        }

        private void comboBoxEdit9_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxEdit7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void simpleButton235_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton236_Click(object sender, EventArgs e)
        {
        }

        private void zoomTrackBarControl5_EditValueChanged_1(object sender, EventArgs e)
        {
        }

        private void simpleButton231_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit85.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class1, bytes);
        }

        private void simpleButton230_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit95.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class1, bytes);
        }

        private void simpleButton229_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit94.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class2, bytes);
        }

        private void simpleButton228_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit93.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class3, bytes);
        }

        private void simpleButton227_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit92.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class4, bytes);
        }

        private void simpleButton226_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit91.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class5, bytes);
        }

        private void simpleButton225_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit90.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class6, bytes);
        }

        private void simpleButton224_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit89.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class7, bytes);
        }

        private void simpleButton223_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit88.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class8, bytes);
        }

        private void simpleButton222_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit87.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class9, bytes);
        }

        private void simpleButton215_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit86.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class10, bytes);
        }

        private void simpleButton234_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
            setMod.SetAllClasses(this);
        }

        private void simpleButton233_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
            setMod.CreatorClasses(this);
        }

        private void simpleButton232_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
            setMod.ColoredClasses(this);
        }

        private void simpleButton237_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton238_Click(object sender, EventArgs e)
        {
            listBoxControl4.Items.Clear();
            listBoxControl4.Items.Add("All Players");
            for (int i = 0; i < 12; i++)
            {
                listBoxControl4.Items.Add(ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.GetNames(i));
            }
        }

        private void checkButton52_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton52.Checked)
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.GodModeON(this);

            }
            else
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.GodModeOFF(this);
            }
        }

        private void checkButton56_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton56.Checked)
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.AmmoON(this);
            }
            else
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.AmmoOFF(this);
            }
        }

        private void checkButton60_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton60.Checked)
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.LaserOn(this);
            }
            else
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.LaserOFF(this);
            }
        }

        private void checkButton41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton41.Checked)
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.WallhackON(this);
            }
            else
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.WallhackOFF(this);
            }
        }

        private void checkButton44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton44.Checked)
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.FreezeON(this);
            }
            else
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.FreezeOFF(this);
            }
        }

        private void checkButton39_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkButton39.Checked)
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.NightVision(this);
            }
            else
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.NightVisionOFF(this);
            }
        }

        private void checkButton49_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton49.Checked)
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.UFOModeON(this);
            }
            else
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.UFOModeOFF(this);
            }
        }

        private void checkButton59_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton59.Checked)
            {
                Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
                setMod.Suicide(this);
                checkButton59.Checked = false;
            }
            else
            {
            }
        }
        private void checkButton55_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkButton42_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxEdit11_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.ChangeTeam(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex, ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.TeamBytes.Team[comboBoxEdit11.SelectedIndex], "Team changed to : " + comboBoxEdit11.Text);
        }

        private void simpleButton246_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x38, 0xa0, 0x00, 0xbe };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.LobbySpeed, buffer);
        }

        private void simpleButton247_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x38, 0xA0, 0x07, 0xD0 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.LobbySpeed, buffer);
        }

        private void zoomTrackBarControl6_EditValueChanged_1(object sender, EventArgs e)
        {
        }

        private void simpleButton249_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x42, 0x9c, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.LobbyJumpHeight, buffer);
        }

        private void simpleButton248_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x43, 0xf5, 0xb0 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.LobbyJumpHeight, buffer);
        }

        private void zoomTrackBarControl7_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton240_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
            setMod.RPCText2(this);
        }

        private void simpleButton239_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
            setMod.RPCText1(this);
        }

        private void simpleButton245_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
            setMod.NameInGame(this);
        }

        private void simpleButton244_Click(object sender, EventArgs e)
        {
            NameChanger(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame + ((uint)this.spinEdit45.Value - 1u) * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient, this.textEdit97.Text);
        }

        private void MW3Advertise_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit97.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame11, bytes);
        }

        private void simpleButton268_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit111.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton267_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl176.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
            textEdit111.Text = labelControl176.Text;
        }

        private void MW3NameFlash_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit111.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void toggleSwitch46_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch46.IsOn)
            {
                MW3NameFlash.Start();
            }
            else
            {
                MW3NameFlash.Stop();
            }
        }

        private void simpleButton265_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit110.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void textEdit111_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton268.PerformClick();
            }
        }

        private void textEdit111_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton266_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl176.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
            textEdit110.Text = labelControl176.Text;
        }

        private void MW3NameSlider_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
            setMod.NameSlider(this);
        }

        private void toggleSwitch45_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch45.IsOn)
            {
                MW3NameSlider.Start();
            }
            else
            {
                MW3NameSlider.Stop();
            }
        }

        private void MW3Clock_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, DateTime.Now.ToString("hh:mm:ss"));
        }

        private void toggleSwitch44_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch44.IsOn)
            {
                MW3Clock.Start();
            }
            else
            {
                MW3Clock.Stop();
            }
        }

        private void MW3Skipper_Tick(object sender, EventArgs e)
        {
            groupControl82.Text = Convert.ToString(stopWatch.Elapsed);
            if (groupControl82.Text.Contains("00:00:06."))
            {
                stopWatch.Restart();
            }
        }

        private void MW3Skipper2_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
            setMod.NameSkipper(this);
        }

        private void toggleSwitch43_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch43.IsOn)
            {
                MW3Skipper.Start();
                MW3Skipper2.Start();
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                MW3Skipper.Stop();
                MW3Skipper2.Stop();
            }
        }

        private void MW3RB_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_MW3.SetMod setMod = new Games.Call_of_Duty_MW3.SetMod();
            setMod.RainBowName(this);
        }

        private void toggleSwitch42_Toggled_1(object sender, EventArgs e)
        {
            if (toggleSwitch42.IsOn)
            {
                MW3RB.Start();
            }
            else
            {
                MW3RB.Stop();
            }
        }

        private void simpleButton264_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton263_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BrandonCardenWV");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton262_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1CFW FTW");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton261_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Hacking...");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton260_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2$5 ^4PayPal");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This option was introduced in my Black Ops 2 RTM tool\nand i have received a lot of great feedback becuase of it.\nTo edit these presets go to the Tool Settings!", "Custom Preset Names", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton259_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Modded Lobby");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton258_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Rebug");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton257_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PS3ITA");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton256_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2HABIB");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton255_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit117.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton254_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit115.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton253_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit113.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void hyperlinkLabelControl4_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This option was introduced in my Black Ops 2 RTM tool\nand i have received a lot of great feedback becuase of it.\nTo edit these presets go to the Tool Settings!", "Custom Preset Names", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton252_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+gostand}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton251_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+usereload}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton250_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+melee}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton243_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{weapnext}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton242_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+smoke}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton241_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+breathe_sprint}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, bytes);
        }
        #endregion
        #region Advanced Warfare Modifications
        private void checkEdit89_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit46.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.Kills, PRF);
        }

        private void checkEdit90_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit47.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.Deaths, PRF);
        }

        private void checkEdit91_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit48.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.Wins, PRF);
        }

        private void checkEdit92_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit49.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.Losses, PRF);
        }

        private void checkEdit93_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit50.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.Score, PRF);
        }

        private void checkEdit94_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit51.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.Accuracy, PRF);
        }

        private void checkEdit95_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit52.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.GamePlayed, PRF);
        }

        private void checkEdit96_CheckedChanged(object sender, EventArgs e)
        {
            decimal num = (((this.spinEdit53.Value * 86400M) + (this.spinEdit54.Value * 3600M)) + (this.spinEdit55.Value * 60M)) + this.spinEdit56.Value;
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(num.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.TimePlayed, bytes);
        }

        private void checkEdit97_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit57.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.Prestige, PRF);
        }

        private void simpleButton276_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetStats setStats = new Games.Call_of_Duty_Advanced_Warfare.SetStats();
            setStats.LegitStats(this);
        }

        private void simpleButton277_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetStats setStats = new Games.Call_of_Duty_Advanced_Warfare.SetStats();
            setStats.HighStats(this);
        }

        private void simpleButton275_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetStats setStats = new Games.Call_of_Duty_Advanced_Warfare.SetStats();
            setStats.InsaneStats(this);
        }

        private void simpleButton274_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetStats setStats = new Games.Call_of_Duty_Advanced_Warfare.SetStats();
            setStats.SendAll(this);
        }

        private void simpleButton273_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetStats setStats = new Games.Call_of_Duty_Advanced_Warfare.SetStats();
            setStats.ClearAll(this);
        }

        private void AWLoop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 30);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.Prestige, Code1);
            AWLoop.Start();
        }

        private void toggleSwitch47_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch47.IsOn)
            {
                AWLoop.Start();
            }
            else
            {
                AWLoop.Stop();
            }
        }

        private void simpleButton279_Click(object sender, EventArgs e)
        {
            Byte[] UnlockBytes = new Byte[0x7FF];
            for (Int32 I = 0; I < 0x7FF; I++)
            {
                UnlockBytes[I] = 0x0F;
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Stats.UnlockAll, UnlockBytes);
            }
        }

        private void simpleButton278_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[6]
      {
        (byte) 32,
        (byte) 32,
        (byte) 48,
        (byte) 69,
        (byte) 86,
        (byte) 118
      };
            PS3.SetMemory(44987921U, buffer);
        }

        private void toggleSwitch49_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch49.IsOn)
            {
                byte[] buffer = new byte[] { 0x6B, 0x18, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.AdvancedUAV, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x6B, 0x18, 0x00, 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.AdvancedUAV, buffer);
            }
        }

        private void toggleSwitch50_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch50.IsOn)
            {
                byte[] buffer = new byte[] { 0x2C, 0x12, 0x00, 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Laser, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x2C, 0x12, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Laser, buffer);
            }
        }

        private void toggleSwitch51_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch51.IsOn)
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.NoRecoil, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.NoRecoil, buffer);
            }
        }

        private void toggleSwitch54_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch54.IsOn)
            {
                byte[] buffer = new byte[] { 0x38, 0xC0, 0x00, 0x09 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.WallHack, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x63, 0xE6, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.WallHack, buffer);
            }
        }

        private void toggleSwitch53_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch53.IsOn)
            {
                byte[] buffer = new byte[] { 0x2C, 0x03, 0x00, 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.RedBoxes, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x2C, 0x03, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.RedBoxes, buffer);
            }
        }

        private void toggleSwitch52_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch53.IsOn)
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.SteadyAim, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.SteadyAim, buffer);
            }
        }

        private void simpleButton300_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit121.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class1, bytes);
        }

        private void simpleButton299_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit131.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class1, bytes);
        }

        private void simpleButton298_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit130.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class2, bytes);
        }

        private void simpleButton297_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit129.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class3, bytes);
        }

        private void simpleButton296_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit128.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class4, bytes);
        }

        private void simpleButton295_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit127.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class5, bytes);
        }

        private void simpleButton294_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit126.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class6, bytes);
        }

        private void simpleButton293_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit125.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class7, bytes);
        }

        private void simpleButton292_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit124.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class8, bytes);
        }

        private void simpleButton291_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit123.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class9, bytes);
        }

        private void simpleButton290_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit122.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class10, bytes);
        }

        private void simpleButton303_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new Games.Call_of_Duty_Advanced_Warfare.SetMod();
            setMod.SetAllClasses(this);
        }

        private void simpleButton302_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new Games.Call_of_Duty_Advanced_Warfare.SetMod();
            setMod.CreatorClasses(this);
        }

        private void simpleButton301_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new Games.Call_of_Duty_Advanced_Warfare.SetMod();
            setMod.ColoredClasses(this);
        }

        private void simpleButton280_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton281_Click(object sender, EventArgs e)
        {
            listBoxControl5.Items.Clear();
            listBoxControl5.Items.Add("All Players");
            for (int i = 0; i < 12; i++)
            {
                listBoxControl5.Items.Add(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(i));
            }
        }

        private void checkButton46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton46.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.GodModeON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.GodModeOFF(this);
            }
        }

        private void checkButton48_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton48.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.AmmoON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.AmmoOFF(this);
            }
        }

        private void checkButton51_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton51.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.mFlagON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.mFlagOFF(this);
            }
        }

        private void checkButton43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton43.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.LaserOn(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.LaserOFF(this);
            }
        }

        private void checkButton40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton40.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.DoubleSpeedON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.DoubleSpeedOFF(this);
            }
        }

        private void checkButton45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton45.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.LagON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.LagOFF(this);
            }
        }

        private void checkButton50_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton50.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.RedBoxesON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.RedBoxesOFF(this);
            }
        }

        private void checkButton47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton47.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.ThirdPersonON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.ThirdPersonOFF(this);
            }
        }

        private void checkButton42_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkButton42.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.ExoCloakON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.ExoCloakOFF(this);
            }
        }

        private void checkButton53_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton53.Checked)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.NoFrictionON(this);
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.SetMod();
                setMod.NoFrictionOFF(this);
            }
        }

        private void simpleButton285_Click(object sender, EventArgs e)
        {
            zoomTrackBarControl11.Value = 180;
        }

        private void zoomTrackBarControl11_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.LobbyJump, (float)zoomTrackBarControl11.Value);
        }

        private void simpleButton282_Click(object sender, EventArgs e)
        {
            zoomTrackBarControl10.Value = 1000;
        }

        private void zoomTrackBarControl10_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.KnockBack, (float)zoomTrackBarControl10.Value);
        }

        private void simpleButton283_Click(object sender, EventArgs e)
        {
            zoomTrackBarControl12.Value = 65;
        }

        private void zoomTrackBarControl12_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.FOV, (float)zoomTrackBarControl12.Value);
        }

        private void simpleButton284_Click(object sender, EventArgs e)
        {
            zoomTrackBarControl13.Value = 0;
        }

        private void zoomTrackBarControl13_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.GunPosX, (float)zoomTrackBarControl13.Value);
        }

        private void simpleButton304_Click(object sender, EventArgs e)
        {
            zoomTrackBarControl14.Value = 0;
        }

        private void zoomTrackBarControl14_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.GunPosY, (float)zoomTrackBarControl14.Value);
        }

        private void simpleButton305_Click(object sender, EventArgs e)
        {
            zoomTrackBarControl15.Value = 0;
        }

        private void zoomTrackBarControl15_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.GunPosZ, (float)zoomTrackBarControl15.Value);
        }

        private void toggleSwitch55_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch55.IsOn)
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "ds_serverConnectTimeout 1000");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "ds_serverConnectTimeout 1");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "party_minplayers 1");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "party_maxplayers 12");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "pt_searchConnectAttempts 1");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "pt_connectAttempts 1");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "pt_connectTimeout 1");
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "reset ds_serverConnectTimeout");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "reset ds_serverConnectTimeout");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "reset party_minplayers");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "reset party_maxplayers");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "reset pt_searchConnectAttempts");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "reset pt_connectAttempts");
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.Cbuf_AddText(0, "reset pt_connectTimeout");
            }
        }

        private void toggleSwitch56_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch56.IsOn)
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.AntiBan1, buffer);
                byte[] buffer1 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.AntiBan1, buffer1);
                byte[] buffer2 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.AntiBan1, buffer2);
                byte[] buffer3 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.AntiBan1, buffer3);
                byte[] buffer4 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.AntiBan1, buffer4);
                byte[] buffer5 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.AntiBan1, buffer5);
                byte[] buffer6 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.AntiBan1, buffer6);
                XtraMessageBox.Show("Anti-Ban is enabled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            }
        }

        private void simpleButton287_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(1, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(2, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(3, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(4, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(5, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(6, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(7, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(8, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(9, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(10, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(11, textEdit119.Text);
        }

        private void simpleButton306_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Lobby.LobbyGodMod, buffer);
        }

        private void simpleButton286_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(0, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(1, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(2, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(3, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(4, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(5, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(6, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(7, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(8, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(9, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(10, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintlnBold(11, textEdit119.Text);
        }

        private void simpleButton289_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit120.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame11, bytes);
        }

        private void simpleButton288_Click(object sender, EventArgs e)
        {
            NameChanger(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame + ((uint)this.spinEdit58.Value - 1u) * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient, this.textEdit120.Text);
        }

        private void AWAdvertise_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit120.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NameInGame11, bytes);
        }

        private void toggleSwitch48_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch48.IsOn)
            {
                AWAdvertise.Start();
            }
            else
            {
                AWAdvertise.Stop();
            }
        }

        private void simpleButton328_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit145.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton327_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl177.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
            textEdit145.Text = labelControl177.Text;
        }

        private void AWNameFlash_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit145.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton325_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit144.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void toggleSwitch61_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch61.IsOn)
            {
                AWNameFlash.Start();
            }
            else
            {
                AWNameFlash.Stop();
            }
        }

        private void simpleButton326_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl177.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
            textEdit144.Text = labelControl177.Text;
        }

        private void AWNameSlider_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new Games.Call_of_Duty_Advanced_Warfare.SetMod();
            setMod.NameSlider(this);
        }

        private void toggleSwitch60_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch60.IsOn)
            {
                AWNameSlider.Start();
            }
            else
            {
                AWNameSlider.Stop();
            }
        }

        private void AWClock_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, DateTime.Now.ToString("hh:mm:ss"));
        }

        private void toggleSwitch59_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch59.IsOn)
            {
                AWClock.Start();
            }
            else
            {
                AWClock.Stop();
            }
        }

        private void AWSkipper_Tick(object sender, EventArgs e)
        {
            groupControl99.Text = Convert.ToString(stopWatch.Elapsed);
            if (groupControl99.Text.Contains("00:00:06."))
            {
                stopWatch.Restart();
            }
        }

        private void AWSkipper2_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new Games.Call_of_Duty_Advanced_Warfare.SetMod();
            setMod.NameSkipper(this);
        }

        private void toggleSwitch58_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch58.IsOn)
            {
                stopWatch.Start();
                AWSkipper2.Start();
                AWSkipper.Start();
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                AWSkipper.Stop();
                AWSkipper2.Stop();
            }
        }

        private void AWRB_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Advanced_Warfare.SetMod setMod = new Games.Call_of_Duty_Advanced_Warfare.SetMod();
            setMod.RainBowName(this);
        }

        private void toggleSwitch57_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch57.IsOn)
            {
                AWRB.Start();
            }
            else
            {
                AWRB.Stop();
            }
        }

        private void simpleButton324_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton323_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BrandonCardenWV");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton322_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1CFW FTW");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton321_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Hacking...");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton320_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2$5 ^4PayPal");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton319_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Modded Lobby");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton318_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1REBUG");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton317_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PS3ITA");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton316_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2HABIB");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void textEdit145_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton328.PerformClick();
            }
        }

        private void textEdit145_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton315_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("preset1");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton314_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("preset2");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton313_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("preset3");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void hyperlinkLabelControl5_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This option was introduced in my Black Ops 2 RTM tool\nand i have received a lot of great feedback becuase of it.\nTo edit these presets go to the Tool Settings!", "Custom Preset Names", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton312_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+gostand}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton311_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+usereload}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton310_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+melee}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton309_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{weapnext}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton308_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+smoke}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton307_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+breathe_sprint}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton330_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x01 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Addresses.FPS, buffer);
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit146.Text);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Addresses.TextFPS, bytes);
        }

        private void simpleButton329_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Addresses.FPS, buffer);
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit146.Text);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Addresses.TextFPS, bytes);
        }

        private void zoomTrackBarControl17_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Addresses.FPSTextSize, (float)zoomTrackBarControl17.Value);
        }
        #endregion
        #region Black Ops Modifications
        private void checkEdit98_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit59.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.Kills, PRF);
        }
        private void simpleButton623_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x49, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.LobbySuperJump, PRF);
        }
        private void checkButton55_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkButton55.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.NoTargetON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.NoTargetOFF(this);
            }
        }
        private void simpleButton624_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x49, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.SuperJump, PRF);
        }

        private void checkEdit99_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit60.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.Deaths, PRF);
        }

        private void checkEdit100_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit61.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.Headshots, PRF);
        }

        private void checkEdit101_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit62.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.Score, PRF);
        }

        private void checkEdit102_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit63.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.Assists, PRF);
        }

        private void checkEdit103_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit64.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.TotalWins, PRF);
        }

        private void checkEdit104_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit65.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.TotalLosses, PRF);
        }

        private void checkEdit105_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit66.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.GamesPlayed, PRF);
        }

        private void checkEdit106_CheckedChanged(object sender, EventArgs e)
        {
            decimal num = (((this.spinEdit67.Value * 86400M) + (this.spinEdit75.Value * 3600M)) + (this.spinEdit76.Value * 60M)) + this.spinEdit77.Value;
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(num.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.TimePlayed, bytes);
        }

        private void checkEdit107_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit68.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.ContractsPurchased, PRF);
        }

        private void checkEdit108_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit69.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.ContractsAmountSpent, PRF);
        }

        private void checkEdit109_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit70.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.XPAwardsContracts, PRF);
        }

        private void checkEdit110_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit71.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.AmountEarnedContracts, PRF);
        }

        private void checkEdit111_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit72.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.WagerMatchEarnings, PRF);
        }

        private void checkEdit112_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit73.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.CODPoints, PRF);
        }

        private void checkEdit113_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit74.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.Prestige, PRF);
        }

        private void simpleButton336_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetStats setStats = new Games.Call_of_Duty_Black_Ops.SetStats();
            setStats.LegitStats(this);
        }

        private void simpleButton337_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetStats setStats = new Games.Call_of_Duty_Black_Ops.SetStats();
            setStats.HighStats(this);
        }

        private void simpleButton335_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetStats setStats = new Games.Call_of_Duty_Black_Ops.SetStats();
            setStats.InsaneStats(this);
        }

        private void simpleButton334_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetStats setStats = new Games.Call_of_Duty_Black_Ops.SetStats();
            setStats.SendAll(this);
        }

        private void simpleButton333_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetStats setStats = new Games.Call_of_Duty_Black_Ops.SetStats();
            setStats.Clear(this);
        }

        private void BO1Loop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 30);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.Prestige, Code1);
            BO1Loop.Start();
        }

        private void toggleSwitch62_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch62.IsOn)
            {
                BO1Loop.Start();
            }
            else
            {
                BO1Loop.Stop();
            }
        }

        private void simpleButton332_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.UnlockAll.UnlockAll1();
        }

        private void simpleButton331_Click(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(999.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Stats.CODPoints, PRF);
        }

        private void toggleSwitch68_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch68.IsOn)
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.NoRecoil, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x4B, 0xF1, 0x84, 0xCD };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.NoRecoil, buffer);
            }
        }

        private void toggleSwitch67_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch67.IsOn)
            {
                byte[] buffer = new byte[] { 0x38, 0xC0, 0xF0, 0x03 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.WallHack, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0xFC, 0xC0, 0xF8, 0x90 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.WallHack, buffer);
            }
        }

        private void toggleSwitch66_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch66.IsOn)
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.RedBoxes, buffer);
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.PerkCheckOffset, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x41, 0x86, 0x02, 0x78 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.RedBoxes, buffer);
            }
        }

        private void toggleSwitch65_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch65.IsOn)
            {
                byte[] buffer = new byte[] { 0x02 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.SleightofHand, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.SleightofHand, buffer);
            }
        }

        private void toggleSwitch64_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch64.IsOn)
            {
                byte[] buffer = new byte[] { 0x38, 0xC0, 0xFF, 0xFF };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.ChromePlayer, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0xFC, 0xC0, 0xF8, 0x90 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.ChromePlayer, buffer);
            }
        }

        private void toggleSwitch63_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch63.IsOn)
            {
                byte[] buffer = new byte[] { 0x02 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.RapidFire, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.RapidFire, buffer);
            }
        }

        private void toggleSwitch71_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch71.IsOn)
            {
                byte[] buffer = new byte[] { 0x40, 0x9A, 0x00, 0xC4 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.BlackBird, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x41, 0x9A, 0x00, 0xC4 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.BlackBird, buffer);
            }
        }

        private void toggleSwitch70_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch70.IsOn)
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.SteadyAim, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x2F, 0x80, 0x00, 0x02 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.SteadyAim, buffer);
            }
        }

        private void simpleButton352_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.UnlockTrophies.TrophyUnlocks_MP();
        }

        private void simpleButton353_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.GodModeClasses(this);
        }

        private void toggleSwitch72_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch72.IsOn)
            {
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "ds_serverConnectTimeout 1000");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "ds_serverConnectTimeout 1");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "party_minplayers 1");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "party_maxplayers 12");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "pt_searchConnectAttempts 1");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "pt_connectAttempts 1");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "pt_connectTimeout 1");
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "reset ds_serverConnectTimeout");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "reset ds_serverConnectTimeout");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "reset party_minplayers");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "reset party_maxplayers");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "reset pt_searchConnectAttempts");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "reset pt_connectAttempts");
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.cBuf_AddText(0, "reset pt_connectTimeout");
            }
        }

        private void simpleButton354_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton355_Click(object sender, EventArgs e)
        {
            listBoxControl6.Items.Clear();
            listBoxControl6.Items.Add("All Players");
            for (int i = 0; i < 12; i++)
            {
                listBoxControl6.Items.Add(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(i));
            }
        }

        private void checkButton63_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton63.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.GodModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.GodModeOFF(this);
            }
        }

        private void checkButton65_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton65.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.AmmoON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.AmmoOFF(this);
            }
        }

        private void checkButton67_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton67.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.DoubleSpeedON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.DoubleSpeedOFF(this);
            }
        }

        private void checkButton61_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton61.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.NoClipON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.NoClipOFF(this);
            }
        }

        private void checkButton57_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton57.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.UFOModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.UFOModeOFF(this);
            }
        }

        private void checkButton73_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton73.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ReconPlaneON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ReconPlaneOFF(this);
            }
        }

        private void checkButton71_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton71.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.SecondChanceON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.SecondChanceOFF(this);
            }
        }

        private void checkButton69_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton69.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.CheckerBoardON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.CheckerBoardOFF(this);
            }
        }

        private void checkButton74_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton74.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.FreezeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.FreezeOFF(this);
            }
        }

        private void checkButton62_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton62.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.BlackBirdON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.BlackBirdOFF(this);
            }
        }

        private void checkButton66_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton66.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.YellowMapON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.YellowMapOFF(this);
            }
        }

        private void checkButton64_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton64.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.BigMapON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.BigMapOFF(this);
            }
        }

        private void checkButton58_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton58.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.AllPerksON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.AllPerksOFF(this);
            }
        }

        private void checkButton54_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton54.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.InvisibilityON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.InvisibilityOFF(this);
            }
        }

        private void simpleButton362_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x42, 0x9C, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.LobbySuperJump, buffer);
        }

        private void zoomTrackBarControl22_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton361_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x41 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NoFallDamage, buffer);
        }

        private void simpleButton356_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x40 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NoFallDamage, buffer);
        }

        private void simpleButton364_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.RPCText1(this);
        }

        private void simpleButton363_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.RPCText2(this);
        }

        private void simpleButton366_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.SetAllNames(this);
        }

        private void simpleButton365_Click(object sender, EventArgs e)
        {
            NameChanger(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame + ((uint)this.spinEdit78.Value - 1u) * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval, this.textEdit165.Text);
        }

        private void BO1Advertise_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.FlashAll(this);
        }

        private void toggleSwitch69_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch69.IsOn)
            {
                BO1Advertise.Start();
            }
            else
            {
                BO1Advertise.Stop();
            }
        }

        private void simpleButton384_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit179.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton383_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl190.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
            textEdit179.Text = labelControl190.Text;
        }

        private void BO1NameFlash_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit179.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void toggleSwitch77_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch77.IsOn)
            {
                BO1NameFlash.Start();
            }
            else
            {
                BO1NameFlash.Stop();
            }
        }

        private void simpleButton381_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit178.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton382_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl190.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
            textEdit178.Text = labelControl190.Text;
        }

        private void BO1NameSlider_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.NameSlider(this);
        }

        private void toggleSwitch76_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch76.IsOn)
            {
                BO1NameSlider.Start();
            }
            else
            {
                BO1NameSlider.Stop();
            }
        }

        private void BO1Clock_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, DateTime.Now.ToString("hh:mm:ss"));
        }

        private void toggleSwitch75_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch75.IsOn)
            {
                BO1Clock.Start();
            }
            else
            {
                BO1Clock.Stop();
            }
        }

        private void BO1Skipper_Tick(object sender, EventArgs e)
        {
            groupControl116.Text = Convert.ToString(stopWatch.Elapsed);
            if (groupControl116.Text.Contains("00:00:06."))
            {
                stopWatch.Restart();
            }
        }

        private void textEdit179_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton384.PerformClick();
            }
        }

        private void BO1Skipper2_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.NameSkipper(this);
        }

        private void toggleSwitch74_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch74.IsOn)
            {
                stopWatch.Start();
                BO1Skipper2.Start();
                BO1Skipper.Start();
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                BO1Skipper.Stop();
                BO1Skipper2.Stop();
            }
        }

        private void BO1RB_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.RainbowName(this);
        }

        private void toggleSwitch73_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch73.IsOn)
            {
                BO1RB.Start();
            }
            else
            {
                BO1RB.Stop();
            }
        }

        private void simpleButton380_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton379_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BrandonCardenWV");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton378_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1CFW FTW");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton377_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Hacking...");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton376_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2$5 ^4PayPal");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton375_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Modded Lobby");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton374_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1REBUG");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton373_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PS3ITA");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton372_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2Habib");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton371_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit186.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton370_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit184.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton369_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit182.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void hyperlinkLabelControl6_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This option was introduced in my Black Ops 2 RTM tool\nand i have received a lot of great feedback becuase of it.\nTo edit these presets go to the Tool Settings!", "Custom Preset Names", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton368_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+gostand}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton367_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+usereload}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton360_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+melee}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton359_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{weapnext}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton358_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+smoke}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton357_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+breathe_sprint}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton386_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x40, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Addresses.FPS, buffer);
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit180.Text);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Addresses.FPSText, bytes);
        }

        private void simpleButton385_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x40, 0x9A };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Addresses.FPS, buffer);
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit180.Text);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Addresses.FPSText, bytes);
        }

        private void simpleButton387_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton388_Click(object sender, EventArgs e)
        {
            listBoxControl7.Items.Clear();
            listBoxControl7.Items.Add("All Players");
            for (int i = 0; i <= ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ZombiesMaxClients - 1; i++)
            {
                listBoxControl7.Items.Add(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(i));
            }
        }

        private void checkButton77_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton77.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieGodModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieGodModeOFF(this);
            }
        }

        private void checkButton79_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton79.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieAmmoON(this);
            }
            else
            {
            }
        }

        private void checkButton81_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton81.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieNoClipON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieNoClipOFF(this);
            }
        }

        private void checkButton75_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton75.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieUFOModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieUFOModeOFF(this);
            }
        }

        private void checkButton70_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton70.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieFreezeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieFreezeOFF(this);
            }
        }

        private void checkButton76_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton76.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieDoubleSpeedON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.ZombieDoubleSpeedOFF(this);
            }
        }

        private void checkButton68_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton68.Checked)
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.MaxPointsON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
                setMod.MaxPointsOFF(this);
            }
        }

        private void toggleSwitch81_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch81.IsOn)
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.ZombiesNoRecoil, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x4B, 0xF3, 0xFF, 0x89 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.ZombiesNoRecoil, buffer);
            }
        }

        private void toggleSwitch82_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch82.IsOn)
            {
                byte[] buffer = new byte[] { 0x2F, 80, 00, 00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.ZombiesSteadyAim, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x2F, 80, 00, 02 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.ZombiesSteadyAim, buffer);
            }
        }

        private void toggleSwitch83_Toggled(object sender, EventArgs e)
        {
        }

        private void toggleSwitch84_Toggled(object sender, EventArgs e)
        {
        }

        private void simpleButton412_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit201.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void BO1ZNameFlash_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit201.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void toggleSwitch89_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch89.IsOn)
            {
                BO1ZNameFlash.Start();
            }
            else
            {
                BO1ZNameFlash.Stop();
            }
        }

        private void simpleButton409_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit200.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void BO1ZNameSlider_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.ZombieNameSlider(this);

        }

        private void toggleSwitch88_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch88.IsOn)
            {
                BO1ZNameSlider.Start();
            }
            else
            {
                BO1ZNameSlider.Stop();
            }
        }

        private void BO1ZClock_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, DateTime.Now.ToString("hh:mm:ss"));
        }

        private void toggleSwitch87_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch87.IsOn)
            {
                BO1ZClock.Start();
            }
            else
            {
                BO1ZClock.Stop();
            }
        }

        private void BO1ZNameSkipper_Tick(object sender, EventArgs e)
        {
            groupControl129.Text = Convert.ToString(stopWatch.Elapsed);
            if (groupControl129.Text.Contains("00:00:06."))
            {
                stopWatch.Restart();
            }
        }

        private void BO1ZNameSkipper2_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.ZombieNameSkipper(this);
        }

        private void toggleSwitch86_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch86.IsOn)
            {
                stopWatch.Start();
                BO1ZNameSkipper2.Start();
                BO1ZNameSkipper.Start();
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                BO1ZNameSkipper.Stop();
                BO1ZNameSkipper2.Stop();
            }
        }

        private void BO1ZRB_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.ZombieRainBowName(this);
        }

        private void toggleSwitch85_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch85.IsOn)
            {
                BO1ZRB.Start();
            }
            else
            {
                BO1ZRB.Stop();
            }
        }

        private void simpleButton408_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void textEdit201_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton412.PerformClick();
            }
        }

        private void simpleButton407_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BrandonCardenWV");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton406_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1CFW FTW");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton405_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Hacking...");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton404_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2$5 ^4PayPal");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton403_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Modded Lobby");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton402_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1REBUG");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton401_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PS3ITA");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton400_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2HABIB");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton399_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit209.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton398_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit207.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton395_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit205.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton394_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+gostand}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void hyperlinkLabelControl7_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This option was introduced in my Black Ops 2 RTM tool\nand i have received a lot of great feedback becuase of it.\nTo edit these presets go to the Tool Settings!", "Custom Preset Names", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton393_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+usereload}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton392_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+melee}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton391_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{weapnext}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton390_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+smoke}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton389_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+breathe_sprint}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, bytes);
        }

        private void simpleButton411_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x40, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Addresses.ZombiesFPS, buffer);
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit202.Text);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Addresses.ZombiesTextFPS, bytes);
        }

        private void zoomTrackBarControl18_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton410_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x40, 0x9A };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Addresses.ZombiesFPS, buffer);
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit202.Text);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Addresses.ZombiesTextFPS, bytes);
        }

        private void zoomTrackBarControl16_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton415_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x42, 0x9C, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.SuperJump, buffer);
        }

        private void zoomTrackBarControl19_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton414_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x41 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.NoFallDamage, buffer);
        }

        private void simpleButton413_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x40 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.NoFallDamage, buffer);
        }

        private void simpleButton417_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit203.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.MOTD, bytes);
        }

        private void simpleButton397_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(1, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(2, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(3, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(4, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(5, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(6, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(7, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(8, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(9, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(10, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(11, textEdit187.Text);
        }

        private void simpleButton396_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(0, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(1, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(2, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(3, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(4, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(5, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(6, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(7, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(8, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(9, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(10, textEdit187.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBoldZombies(11, textEdit187.Text);

        }
        #endregion
        #region Modern Warfare Modifications
        private void checkEdit114_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit79.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Kills, PRF);
        }

        private void checkEdit115_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit80.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Deaths, PRF);
        }

        private void checkEdit116_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit81.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Headshots, PRF);
        }

        private void checkEdit117_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit82.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Score, PRF);
        }

        private void checkEdit118_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit83.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Wins, PRF);
        }

        private void checkEdit119_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit84.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Losses, PRF);
        }

        private void checkEdit120_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit85.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Streaks, PRF);
        }

        private void checkEdit121_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit86.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Assists, PRF);
        }

        private void checkEdit122_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit87.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Hits, PRF);
        }

        private void checkEdit123_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit88.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Misses, PRF);
        }

        private void checkEdit126_CheckedChanged(object sender, EventArgs e)
        {
            decimal num = (((this.spinEdit91.Value * 86400M) + (this.spinEdit92.Value * 3600M)) + (this.spinEdit93.Value * 60M)) + this.spinEdit94.Value;
            byte[] bytes = BitConverter.GetBytes((int)num);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.TimePlayed, bytes);
        }

        private void checkEdit125_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit90.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.XP, PRF);
        }

        private void checkEdit124_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes((int)this.spinEdit89.Value);
            Array.Reverse(PRF);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Prestige, PRF);
        }

        private void simpleButton422_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Modern_Warfare.SetStats setStats = new Games.Call_of_Duty_Modern_Warfare.SetStats();
            setStats.LegitStats(this);
        }

        private void simpleButton423_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Modern_Warfare.SetStats setStats = new Games.Call_of_Duty_Modern_Warfare.SetStats();
            setStats.HighStats(this);
        }

        private void simpleButton421_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Modern_Warfare.SetStats setStats = new Games.Call_of_Duty_Modern_Warfare.SetStats();
            setStats.InsaneStats(this);
        }

        private void simpleButton420_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Modern_Warfare.SetStats setStats = new Games.Call_of_Duty_Modern_Warfare.SetStats();
            setStats.SendAll(this);
        }

        private void simpleButton419_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Modern_Warfare.SetStats setStats = new Games.Call_of_Duty_Modern_Warfare.SetStats();
            setStats.ClearAll(this);
        }

        private void COD4Loop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 30);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.Prestige, Code1);
            COD4Loop.Start();
        }

        private void toggleSwitch90_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch90.IsOn)
            {
                COD4Loop.Start();
            }
            else
            {
                COD4Loop.Stop();
            }
        }

        private void simpleButton418_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x12C010D0, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x13, 0x1A, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xF6, 0xFF, 0xFF, 0xFF, 0xFE, 0xFF, 0xFF, 0xFF, 0xF6, 0xFF, 0xFF, 0xFF, 0xFE, 0xFF, 0xFF, 0xFF, 0xFE, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xC0, 0xDC, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0, 0xD2, 0xFF, 0xFF, 0xFF, 0xFE, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0, 0xEA, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
        }

        private void simpleButton416_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x00, 0x01, 0xD5, 0xD8 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Stats.XP, buffer);
        }

        private void toggleSwitch91_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch91.IsOn)
            {
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("ds_serverConnectTimeout 1000");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("ds_serverConnectTimeout 1");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("party_minplayers 1");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("party_maxplayers 12");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("pt_searchConnectAttempts 1");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("pt_connectAttempts 1");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("pt_connectTimeout 1");
            }
            else
            {
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("reset ds_serverConnectTimeout");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("reset ds_serverConnectTimeout");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("reset party_minplayers");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("reset party_maxplayers");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("reset pt_searchConnectAttempts");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("reset pt_connectAttempts");
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Cbuf_AddText("reset pt_connectTimeout");
            }
        }

        private void toggleSwitch92_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch91.IsOn)
            {
                byte[] buffer = new byte[] { 0x41 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.GunMovement, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x42 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.GunMovement, buffer);
            }
        }

        private void simpleButton424_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton425_Click(object sender, EventArgs e)
        {
            listBoxControl8.Items.Clear();
            listBoxControl8.Items.Add("All Players");
            for (int i = 0; i <= ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.MaxClients - 1; i++)
            {
                listBoxControl8.Items.Add(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(i));
            }
        }

        private void checkButton88_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton88.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.GodModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.GodModOFF(this);
            }
        }

        private void checkButton90_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton90.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.AmmoON(this);
            }
            else
            {
            }
        }

        private void checkButton92_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton92.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.DoubleSpeedON(this);
            }
            else
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.DoubleSpeedOFF(this);
            }
        }

        private void checkButton86_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton86.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.NoClipON(this);
            }
            else
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.NoClipOFF(this);
            }
        }

        private void checkButton84_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton84.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.UFOModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.UFOModeOFF(this);
            }
        }

        private void checkButton82_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton82.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.FreezeON(this);
            }
            else
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.FreezeOFF(this);
            }
        }

        private void checkButton80_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton80.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.AllPerksON(this);
            }
            else
            {
            }
        }

        private void checkButton87_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton87.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.LagON(this);
            }
            else
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.LagOFF(this);
            }
        }

        private void checkButton91_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton91.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.JumperON(this);
            }
            else
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.JumperOFF(this);
            }
        }

        private void checkButton89_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton89.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.KickClient(this);
                checkButton89.Checked = false;
            }
            else
            {
            }
        }

        private void checkButton85_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton85.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.TeleportToSky(this);
                checkButton85.Checked = false;
            }
            else
            {
            }
        }

        private void checkButton83_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton83.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.TeleportToSpace(this);
                checkButton83.Checked = false;
            }
            else
            {
            }
        }

        private void checkButton78_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton78.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.TeleportUnderMap(this);
                checkButton78.Checked = false;
            }
            else
            {
            }
        }

        private void checkButton72_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton72.Checked)
            {
                Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
                setMod.TeleportToMap(this);
            }
            else
            {
            }
        }

        private void toggleSwitch98_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch98.IsOn)
            {
                byte[] buffer = new byte[] { 0x40, 0xFF };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.TimeScale, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x3F, 0x80 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.TimeScale, buffer);
            }
        }

        private void toggleSwitch99_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch99.IsOn)
            {
                byte[] buffer = new byte[] { 0x3D, 0xFF };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.TimeScale, buffer);
            }
            else
            {
                byte[] buffer = new byte[] { 0x3F, 0x80 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.TimeScale, buffer);
            }
        }

        private void toggleSwitch101_Toggled(object sender, EventArgs e)
        {
        }

        private void toggleSwitch102_Toggled(object sender, EventArgs e)
        {
        }

        private void simpleButton430_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(1, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(2, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(3, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(4, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(5, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(6, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(7, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(8, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(9, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(10, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(11, textEdit210.Text);
        }

        private void simpleButton429_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(0, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(1, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(2, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(3, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(4, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(5, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(6, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(7, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(8, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(9, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(10, textEdit210.Text); ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.iPrintlnBold(11, textEdit210.Text);
        }

        private void simpleButton451_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit225.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame11, bytes);

        }

        private void simpleButton450_Click(object sender, EventArgs e)
        {
            NameChanger(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame + ((uint)this.spinEdit95.Value - 1u) * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval, this.textEdit225.Text);
        }

        private void COD4Advertise_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit225.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.NameInGame11, bytes);
        }

        private void toggleSwitch100_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch100.IsOn)
            {
                COD4Advertise.Start();
            }
            else
            {
                COD4Advertise.Stop();
            }
        }

        private void simpleButton449_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit224.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton448_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl204.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
            textEdit224.Text = labelControl204.Text;
        }

        private void COD4NameFlash_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit224.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void toggleSwitch97_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch97.IsOn)
            {
                COD4NameFlash.Start();
            }
            else
            {
                COD4NameFlash.Stop();
            }
        }

        private void textEdit224_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton449.PerformClick();
            }
        }

        private void simpleButton446_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit223.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton447_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl204.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
            textEdit223.Text = labelControl204.Text;
        }

        private void COD4NameSlider_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
            setMod.NameSlider(this);
        }

        private void toggleSwitch96_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch96.IsOn)
            {
                COD4NameSlider.Start();
            }
            else
            {
                COD4NameSlider.Stop();
            }
        }

        private void COD4Clock_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, DateTime.Now.ToString("hh:mm:ss"));
        }

        private void toggleSwitch95_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch95.IsOn)
            {
                COD4Clock.Start();
            }
            else
            {
                COD4Clock.Stop();
            }
        }

        private void COD4Skipper_Tick(object sender, EventArgs e)
        {
            groupControl144.Text = Convert.ToString(stopWatch.Elapsed);
            if (groupControl144.Text.Contains("00:00:06."))
            {
                stopWatch.Restart();
            }
        }

        private void COD4Skipper2_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
            setMod.NameSkipper(this);
        }

        private void toggleSwitch94_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch94.IsOn)
            {
                COD4Skipper.Start();
                COD4Skipper2.Start();
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                COD4Skipper.Stop();
                COD4Skipper2.Stop();
            }
        }

        private void COD4RB_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Modern_Warfare.SetMod setMod = new Games.Call_of_Duty_Modern_Warfare.SetMod();
            setMod.RainBowName(this);
        }

        private void toggleSwitch93_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch93.IsOn)
            {
                COD4RB.Start();
            }
            else
            {
                COD4RB.Stop();
            }
        }

        private void simpleButton445_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton444_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BrandonCardenWV");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton443_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1CFW FTW");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton442_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Hacking...");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton441_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2$5 ^4PayPal");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton440_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Modded Lobby");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton439_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1REBUG");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton438_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PS3ITA");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton437_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2HABIB");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton436_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit231.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton435_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit229.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton434_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit227.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void hyperlinkLabelControl8_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This option was introduced in my Black Ops 2 RTM tool\nand i have received a lot of great feedback becuase of it.\nTo edit these presets go to the Tool Settings!", "Custom Preset Names", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton433_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+gostand}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton432_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+usereload}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton431_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+melee}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton428_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{weapnext}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton427_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+smoke}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton426_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+breathe_sprint}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, bytes);
        }
        #endregion
        #region Ghosts Modifications
        private void checkEdit127_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit96.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Kills, PRF);
        }
        private void toggleSwitch117_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch117.IsOn)
            {
                GHOSTSClock.Start();
            }
            else
            {
                GHOSTSClock.Stop();
            }
        }
        private void simpleButton625_Click_1(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x45, 0xFF };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.JumpHeight, PRF);
        }

        private void simpleButton626_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x45, 0xFF };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.JumpHeight, PRF);
        }
        private void GHOSTSClock_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, DateTime.Now.ToString("hh:mm:ss"));
        }
        private void checkEdit138_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit110.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Deaths, PRF);
        }

        private void checkEdit137_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit109.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Hits, PRF);
        }

        private void checkEdit140_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit112.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.XPSoldier, PRF);
        }

        private void checkEdit136_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit108.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Score, PRF);
        }

        private void checkEdit135_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit107.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Wins, PRF);
        }

        private void checkEdit134_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit106.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Losses, PRF);
        }

        private void checkEdit133_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit105.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.SquadPoints, PRF);
        }

        private void checkEdit131_CheckedChanged(object sender, EventArgs e)
        {
            decimal num = (((this.spinEdit103.Value * 86400M) + (this.spinEdit99.Value * 3600M)) + (this.spinEdit98.Value * 60M)) + this.spinEdit97.Value;
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(num.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.TimePlayed, bytes);
        }

        private void checkEdit132_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit104.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.GamesPlayed, PRF);
        }

        private void checkEdit130_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit102.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Currentstreak, PRF);
        }

        private void checkEdit129_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit101.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Winstreak, PRF);
        }

        private void checkEdit128_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit100.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Prestige, PRF);
        }

        private void simpleButton458_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.SetStats setStats = new Games.Call_of_Duty_Ghosts.SetStats();
            setStats.LegitStats(this);
        }

        private void simpleButton459_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.SetStats setStats = new Games.Call_of_Duty_Ghosts.SetStats();
            setStats.HighStats(this);
        }

        private void simpleButton457_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.SetStats setStats = new Games.Call_of_Duty_Ghosts.SetStats();
            setStats.LegitStats(this);
        }

        private void simpleButton456_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.SetStats setStats = new Games.Call_of_Duty_Ghosts.SetStats();
            setStats.SendAll(this);
        }

        private void simpleButton455_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.SetStats setStats = new Games.Call_of_Duty_Ghosts.SetStats();
            setStats.ClearAll(this);
        }

        private void GHOSTSLoop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 10);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Prestige, Code1);
            GHOSTSLoop.Start();
        }

        private void toggleSwitch103_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch103.IsOn)
            {
                GHOSTSLoop.Start();
            }
            else
            {
                GHOSTSLoop.Stop();
            }
        }

        private void simpleButton454_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.UnlockAll, new byte[] { 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x01, 0x01, 0x01, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x02, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x00, 0x00 });
        }

        private void simpleButton453_Click_1(object sender, EventArgs e)
        {
            byte[] FPS = new byte[] { 0x0B };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.Prestige, FPS);
        }

        private void comboBoxEdit12_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] Weapons = { 0x58, 0x57, 0x70, 0x0A, 0x07, 0xA3, 0x05, 0x03, 0x01, 0x10, 0x11, 0x12, 0x15, 0x16, 0x17, 0x18, 0x19, 0x20, 0x21, 0x22, 0x24, 0x25, 0x26, 0x27, 0x29, 0x30, 0x31, 0x33, 0x34, 0x35, 0x36, 0x37, 0x41, 0x44, 0x45, 0x47, 0x48, 0x2a, 0x0F, 0x0C, 0x7A, 0x3A, 0x1B, 0x2B, 0x2D, 0x3B };
            PS3.Extension.WriteByte(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Stats.PreferredWeapon, Weapons[comboBoxEdit12.SelectedIndex]);
        }

        private void toggleSwitch112_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch112.IsOn)
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.AdvancedUAV, new byte[] { 0x01 });
            }
            else
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.AdvancedUAV, new byte[] { 0x00 });
            }
        }

        private void toggleSwitch111_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch111.IsOn)
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.NoRecoil, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.NoRecoil, new byte[] { 0x4B, 0xB9, 0x7D, 0xCD });
            }
        }

        private void toggleSwitch110_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch110.IsOn)
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.SteadyAim, new byte[] { 0x2C, 0x03, 0x00, 0x00 });
            }
            else
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.SteadyAim, new byte[] { 0x2C, 0x03, 0x00, 0x02 });
            }
        }

        private void toggleSwitch108_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch108.IsOn)
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.RedBoxes, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.RedBoxes, new byte[] { 0x41, 0x82, 0x00, 0x0c });
            }
        }

        private void toggleSwitch107_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch107.IsOn)
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.UAV, new byte[] { 0x01 });
            }
            else
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.UAV, new byte[] { 0x00 });
            }
        }

        private void toggleSwitch104_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch104.IsOn)
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.ChromePlayer, new byte[] { 0x01 });
            }
            else
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.ChromePlayer, new byte[] { 0x00 });
            }
        }

        private void toggleSwitch106_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch106.IsOn)
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Wallhack, new byte[] { 0x42, 0x80 });
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.WallhackGlow, new byte[] { 0xF9 });
            }
            else
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Wallhack, new byte[] { 0x40, 0x80 });
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.WallhackGlow, new byte[] { 0x00 });
            }
        }

        private void toggleSwitch105_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch105.IsOn)
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.FOV, new byte[] { 0x42, 0xCC });
            }
            else
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.FOV, new byte[] { 0x42, 0x82 });
            }
        }

        private void toggleSwitch109_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch109.IsOn)
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Laser, new byte[] { 0x01 });
            }
            else
            {
                PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Laser, new byte[] { 0x00 });
            }
        }

        private void simpleButton462_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit232.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.ClanTag, bytes);
        }

        private void simpleButton461_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PRF");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.ClanTag, bytes);
        }

        private void simpleButton460_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("iMOD");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.ClanTag, bytes);
        }

        private void simpleButton487_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.WallhackGlow, new byte[] { 0xFF });
        }

        private void simpleButton485_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.WallhackGlow, new byte[] { 0xF5 });
        }

        private void simpleButton486_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.WallhackGlow, new byte[] { 0xF3 });
        }

        private void simpleButton484_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.WallhackGlow, new byte[] { 0xF7 });
        }

        private void simpleButton483_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.WallhackGlow, new byte[] { 0xFB });
        }

        private void simpleButton482_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.WallhackGlow, new byte[] { 0xFD });
        }

        private void simpleButton481_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.WallhackGlow, new byte[] { 0x00 });
        }

        private void simpleButton474_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetAllClasses(this);
        }

        private void simpleButton473_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetClass1(this);
        }

        private void textEdit242_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton472_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetClass2(this);
        }

        private void simpleButton471_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetClass3(this);
        }

        private void simpleButton470_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetClass4(this);
        }

        private void simpleButton469_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetClass5(this);
        }

        private void simpleButton468_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetClass6(this);
        }

        private void simpleButton467_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetClass7(this);
        }

        private void simpleButton466_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetClass8(this);
        }

        private void simpleButton465_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetClass9(this);
        }

        private void simpleButton464_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.SetClass10(this);
        }

        private void simpleButton489_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.PRFClasses(this);
        }

        private void simpleButton488_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.CreatorClasses(this);
        }

        private void simpleButton463_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.ColoredClasses(this);
        }

        private void simpleButton492_Click(object sender, EventArgs e)
        {
            listBoxControl9.Items.Clear();
            listBoxControl9.Items.Add("All Players");
            for (int i = 0; i < 12; i++)
            {
                listBoxControl9.Items.Add(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(i));
            }
        }

        private void simpleButton491_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toggleSwitch113_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch113.IsOn)
            {
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.ForceHostON();
            }
            else
            {
            }
        }

        private void checkButton102_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton102.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.GodModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.GodModeOFF(this);
            }
        }

        private void checkButton104_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton104.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.AmmoON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.AmmoOFF(this);
            }
        }

        private void checkButton106_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton106.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ThirdPersonON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ThirdPersonOFF(this);
            }
        }

        private void checkButton100_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton100.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.RedBoxesON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.RedBoxesOFF(this);
            }
        }

        private void checkButton98_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton98.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.AllPerks(this);
                checkButton98.Checked = false;
            }
            else
            {
            }
        }

        private void checkButton96_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton96.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.DoubleSpeedON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.DoubleSpeedOFF(this);
            }
        }

        private void checkButton95_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton95.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.LagON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.LagOFF(this);
            }
        }

        private void checkButton101_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton101.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.NoClipON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.NoClipOFF(this);
            }
        }

        private void checkButton105_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton105.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.FreezePlayerON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.FreezePlayerOFF(this);
            }
        }

        private void checkButton103_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton103.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.UAVON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.UAVOFF(this);
            }
        }

        private void checkButton99_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton99.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.LaserON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.LaserOFF(this);
            }
        }

        private void checkButton97_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton97.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.UFOModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.UFOModeOFF(this);
            }
        }

        private void checkButton94_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton94.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.PrimaryAkimboON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.PrimaryAkimboOFF(this);
            }
        }

        private void checkButton93_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton93.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.SecondaryAkimboON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.SecondaryAkimboOFF(this);
            }
        }

        private void simpleButton477_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x42, 0x9C };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.JumpHeight, PRF);
        }

        private void zoomTrackBarControl20_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.JumpHeight, (float)zoomTrackBarControl20.Value);
        }

        private void simpleButton475_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0xFF, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.MinFallDamage, PRF);
        }

        private void simpleButton476_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x43, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.MinFallDamage, PRF);
        }

        private void simpleButton493_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x3B, 0x60, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.FullAuto, PRF);
        }

        private void simpleButton494_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x3B, 0x60, 0x00, 0x01 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.FullAuto, PRF);
        }

        private void simpleButton479_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(1, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(2, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(3, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(4, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(5, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(6, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(7, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(8, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(9, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(10, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(11, textEdit244.Text);
        }

        private void simpleButton478_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(0, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(1, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(2, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(3, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(4, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(5, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(6, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(7, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(8, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(9, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(10, textEdit244.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(11, textEdit244.Text);
        }

        private void simpleButton516_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit259.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton515_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl193.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
            textEdit259.Text = labelControl193.Text;
        }

        private void GhostNameFlash_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit259.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void toggleSwitch119_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch119.IsOn)
            {
                GhostNameFlash.Start();
            }
            else
            {
                GhostNameFlash.Stop();
            }
        }

        private void simpleButton513_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit258.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton514_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl193.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
            textEdit258.Text = labelControl193.Text;
        }

        private void GhostsNameSlider_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.NameSlider(this);
        }

        private void toggleSwitch118_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch118.IsOn)
            {
                GhostsNameSlider.Start();
            }
            else
            {
                GhostsNameSlider.Stop();
            }
        }

        private void GhostsSkipper_Tick(object sender, EventArgs e)
        {
            groupControl165.Text = Convert.ToString(stopWatch.Elapsed);
            if (groupControl165.Text.Contains("00:00:06."))
            {
                stopWatch.Restart();
            }
        }

        private void GhostsSkipper2_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.NameSkipper(this);
        }

        private void toggleSwitch116_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch116.IsOn)
            {
                stopWatch.Start();
                GhostsSkipper.Start();
                GhostsSkipper2.Start();
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                GhostsSkipper.Stop();
                GhostsSkipper2.Stop();
            }
        }

        private void GhostsRB_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Ghosts.OtherMods otherMods = new Games.Call_of_Duty_Ghosts.OtherMods();
            otherMods.RainBowName(this);
        }

        private void toggleSwitch115_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch115.IsOn)
            {
                GhostsRB.Start();
            }
            else
            {
                GhostsRB.Stop();
            }
        }

        private void simpleButton512_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton511_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BrandonCardenWV");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton510_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1CFW FTW");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton509_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Hacking...");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton508_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2$5 ^4PayPal");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton507_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Modded Lobby");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton506_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Rebug");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton505_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PS3ITA");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton504_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Habib");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton503_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit261.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton502_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit262.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton501_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit264.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void hyperlinkLabelControl9_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This option was introduced in my Black Ops 2 RTM tool\nand i have received a lot of great feedback becuase of it.\nTo edit these presets go to the Tool Settings!", "Custom Preset Names", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton500_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+gostand}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton499_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+usereload}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton498_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+melee}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton497_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{weapnext}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton496_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+smoke}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void simpleButton495_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+breathe_sprint}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, bytes);
        }

        private void xtraUserControl1_Load(object sender, EventArgs e)
        {
        }

        public static void ToggleFPS(Boolean Status)
        {
            PS3.Extension.WriteBool(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.ToggleFPS, Status);
        }
        public static void InitalizeFPS(String Text)
        {
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.InitalizeFPS, Encoding.ASCII.GetBytes(Text + "\0"));
        }

        private void simpleButton518_Click(object sender, EventArgs e)
        {
            ToggleFPS(true);
            InitalizeFPS(textEdit272.Text);
        }

        private void simpleButton517_Click(object sender, EventArgs e)
        {
            ToggleFPS(false);
            InitalizeFPS(textEdit272.Text);
        }

        private void checkEdit139_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit113.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.AliensKilled, PRF);
        }

        private void checkEdit141_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit114.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.MissionCompleted, PRF);
        }

        private void checkEdit142_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit115.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.MaxRelics, PRF);
        }

        private void checkEdit143_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit116.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.Revive, PRF);
        }

        private void checkEdit146_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit119.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.Teeth, PRF);
        }

        private void checkEdit144_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit117.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.Prestige, PRF);
        }

        private void checkEdit153_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit127.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.LBKills, PRF);
        }

        private void checkEdit152_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit126.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.LBDowns, PRF);
        }

        private void checkEdit151_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit125.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.LBRevives, PRF);
        }

        private void checkEdit150_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit124.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.LBScore, PRF);
        }

        private void checkEdit149_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit123.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.LBCashFlow, PRF);
        }

        private void checkEdit148_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit122.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.LBHivesDestroyed, PRF);
        }

        private void checkEdit147_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit121.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.LBAttemteptedChallenges, PRF);
        }

        private void checkEdit154_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit128.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.LBCompletedChallenges, PRF);
        }

        private void simpleButton520_Click(object sender, EventArgs e)
        {
            spinEdit113.Value = 4647;
            spinEdit114.Value = 37;
            spinEdit115.Value = 5;
            spinEdit116.Value = 1016;
            spinEdit117.Value = 99;
            spinEdit119.Value = 6;
            simpleButton534.PerformClick();
        }

        private void simpleButton521_Click(object sender, EventArgs e)
        {
            spinEdit113.Value = 15647;
            spinEdit114.Value = 598;
            spinEdit115.Value = 8;
            spinEdit116.Value = 12899;
            spinEdit117.Value = 999;
            spinEdit119.Value = 9;
            simpleButton534.PerformClick();
        }

        private void simpleButton519_Click(object sender, EventArgs e)
        {
            spinEdit113.Value = 214567899;
            spinEdit114.Value = 214567899;
            spinEdit115.Value = 214567899;
            spinEdit116.Value = 214567899;
            spinEdit117.Value = 999;
            spinEdit119.Value = 10;
            simpleButton534.PerformClick();
        }

        private void simpleButton534_Click(object sender, EventArgs e)
        {
            checkEdit139.Checked = true;
            checkEdit141.Checked = true;
            checkEdit142.Checked = true;
            checkEdit143.Checked = true;
            checkEdit146.Checked = true;
            checkEdit144.Checked = true;
        }

        private void simpleButton533_Click(object sender, EventArgs e)
        {
            spinEdit113.Value = 0;
            spinEdit114.Value = 0;
            spinEdit115.Value = 0;
            spinEdit116.Value = 0;
            spinEdit117.Value = 0;
            spinEdit119.Value = 0;
            checkEdit139.Checked = false;
            checkEdit141.Checked = false;
            checkEdit142.Checked = false;
            checkEdit143.Checked = false;
            checkEdit146.Checked = false;
            checkEdit144.Checked = false;
        }

        private void toggleSwitch122_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch122.IsOn)
            {
                GhostsEXLoop.Start();
            }
            else
            {
                GhostsEXLoop.Stop();
            }
        }

        private void simpleButton536_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton535_Click(object sender, EventArgs e)
        {
        }

        private void GhostsEXLoop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 10);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ExtintionStats.Prestige, Code1);
            GhostsEXLoop.Start();
        }

        private void simpleButton523_Click(object sender, EventArgs e)
        {
            listBoxControl10.Items.Clear();
            listBoxControl10.Items.Add("All Players");
            for (int i = 0; i < 4; i++)
            {
                listBoxControl10.Items.Add(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(i));
            }
        }

        private void simpleButton522_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toggleSwitch121_Toggled(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.ForceHostON();
        }

        private void checkButton116_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton116.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionGodModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionGodModeOFF(this);
            }
        }

        private void checkButton118_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton118.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionAmmoON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionAmmoOFF(this);
            }
        }

        private void checkButton120_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton120.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionThirdPersonON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionThirdPersonOFF(this);
            }
        }

        private void checkButton110_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton110.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionDoubleSpeedON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionDoubleSpeedOFF(this);
            }
        }

        private void checkButton109_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton109.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionLagON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionLagOFF(this);
            }
        }

        private void checkButton111_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton111.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionUFOModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionUFOModeOFF(this);
            }
        }

        private void checkButton115_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton115.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionNoClipON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionNoClipOFF(this);
            }
        }

        private void checkButton119_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton119.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionFreezePlayerON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionFreezePlayerOFF(this);
            }
        }

        private void checkButton108_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton108.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionPrimaryAkimboON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionPrimaryAkimboOFF(this);
            }
        }

        private void checkButton107_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton107.Checked)
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionSecondaryAkimboON(this);
            }
            else
            {
                Games.Call_of_Duty_Ghosts.SetMod setMod = new Games.Call_of_Duty_Ghosts.SetMod();
                setMod.ExtinctionSecondaryAkimboOFF(this);
            }
        }

        private void simpleButton528_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x42, 0x9C };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.JumpHeight, PRF);
        }

        private void zoomTrackBarControl21_EditValueChanged(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.JumpHeight, (float)zoomTrackBarControl21.Value);
        }

        private void simpleButton527_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x43, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.MinFallDamage, PRF);
        }

        private void simpleButton526_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0xFF, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.MinFallDamage, PRF);
        }

        private void simpleButton525_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x3B, 0x60, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.FullAuto, PRF);
        }

        private void simpleButton524_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x3B, 0x60, 0x00, 0x01 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.LobbySettings.FullAuto, PRF);
        }

        private void simpleButton530_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(1, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(2, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(3, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(4, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(5, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(6, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(7, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(8, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(9, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(10, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(11, textEdit273.Text);
        }

        private void simpleButton529_Click(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(0, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(1, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(2, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(3, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(4, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(5, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(6, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(7, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(8, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(9, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(10, textEdit273.Text); ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.iPrintlnBold(11, textEdit273.Text);
        }

        private void simpleButton490_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit245.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame11, bytes);
        }

        private void simpleButton480_Click(object sender, EventArgs e)
        {
            NameChanger(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame + ((uint)this.spinEdit111.Value - 1u) * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval, this.textEdit245.Text);
        }

        private void GhostsAdvertise_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit245.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame11, bytes);
        }

        private void toggleSwitch114_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch114.IsOn)
            {
                GhostsAdvertise.Start();
            }
            else
            {
                GhostsAdvertise.Stop();
            }
        }

        private void simpleButton532_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit274.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame11, bytes);
        }

        private void simpleButton531_Click(object sender, EventArgs e)
        {
            NameChanger(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame + ((uint)this.spinEdit120.Value - 1u) * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval, this.textEdit274.Text);
        }

        private void GhostsAdvertise2_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit274.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NameInGame11, bytes);
        }

        private void toggleSwitch120_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch120.IsOn)
            {
                GhostsAdvertise2.Start();
            }
            else
            {
                GhostsAdvertise2.Stop();
            }
        }
        #endregion
        #region Black Ops 3 Modifications
        private void checkEdit156_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit129.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.Kills, PRF);
        }

        private void checkEdit157_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit130.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.Deaths, PRF);
        }
        private void toggleSwitch223_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch223.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.FPS, new byte[] { 0x2c, 0x14, 0x00, 0x01 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.FPS, new byte[] { 0x2c, 0x14, 0x00, 0x00 });
            }
        }
        private void checkEdit159_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit132.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.Wins, PRF);
        }

        private void checkEdit158_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit131.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.Losses, PRF);
        }

        private void checkEdit161_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit134.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.Score, PRF);
        }

        private void checkEdit160_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit133.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.Tokens, PRF);
        }

        private void checkEdit163_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit136.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.XP, PRF);
        }

        private void checkEdit164_CheckedChanged(object sender, EventArgs e)
        {
            decimal num = (((this.spinEdit137.Value * 86400M) + (this.spinEdit138.Value * 3600M)) + (this.spinEdit139.Value * 60M)) + this.spinEdit140.Value;
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(num.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.TimePlayed, bytes);
        }

        private void checkEdit162_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit135.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.Prestige, PRF);
        }

        private void simpleButton546_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetStats setStats = new Games.Call_of_Duty_Black_Ops_3.SetStats();
            setStats.LegitStats(this);
        }

        private void simpleButton547_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetStats setStats = new Games.Call_of_Duty_Black_Ops_3.SetStats();
            setStats.HighStats(this);
        }

        private void simpleButton545_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetStats setStats = new Games.Call_of_Duty_Black_Ops_3.SetStats();
            setStats.InsaneStats(this);
        }

        private void simpleButton544_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetStats setStats = new Games.Call_of_Duty_Black_Ops_3.SetStats();
            setStats.SendAll(this);
        }

        private void simpleButton543_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetStats setStats = new Games.Call_of_Duty_Black_Ops_3.SetStats();
            setStats.ClearAll(this);
        }

        private void BO3Loop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 10);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.Prestige, Code1);
            BO3Loop.Start();
        }

        private void toggleSwitch129_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch129.IsOn)
            {
                BO3Loop.Start();
            }
            else
            {
                BO3Loop.Stop();
            }
        }

        private void simpleButton541_Click_1(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0xff };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Stats.Prestige, PRF);
        }

        private void toggleSwitch130_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch130.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.UAV, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x41, 0x82, 0x00, 0xAC };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.UAV, PRF);
            }
        }

        private void toggleSwitch131_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch131.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.NoRecoil, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x48, 0x5F, 0x6B, 0x79 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.NoRecoil, PRF);
            }
        }

        private void toggleSwitch132_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch132.IsOn)
            {
                byte[] PRF2 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.RedBoxes1, PRF2);
                byte[] PRF3 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.RedBoxes2, PRF3);
            }
            else
            {
                byte[] PRF = new byte[] { 0x41, 0x82, 0x01, 0xD4 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.RedBoxes1, PRF);
                byte[] PRF1 = new byte[] { 0x41, 0x82, 0x02, 0x0C };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.RedBoxes2, PRF1);
            }
        }

        private void toggleSwitch133_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch133.IsOn)
            {
                byte[] PRF = new byte[] { 0x38, 0xC0, 0xFF, 0xFF };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.WallHack, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x63, 0xE6, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.WallHack, PRF);
            }
        }

        private void toggleSwitch134_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch134.IsOn)
            {
                byte[] PRF = new byte[] { 0x2C, 0x04, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.SteadyAim, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x2C, 0x04, 0x00, 0x02 };
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.SteadyAim, PRF);
            }
        }

        private void simpleButton564_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit289.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.ClanTag, bytes);
        }

        private void simpleButton563_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PRF");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.ClanTag, bytes);
        }

        private void simpleButton562_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("iMOD");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.ClanTag, bytes);
        }

        private void simpleButton558_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
            setMod.SetAllClasses(this);
        }

        private void simpleButton557_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit287.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class1, bytes);
        }

        private void simpleButton556_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit286.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class2, bytes);
        }

        private void simpleButton555_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit285.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class3, bytes);
        }

        private void simpleButton554_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit284.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class4, bytes);
        }

        private void simpleButton553_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit283.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class5, bytes);
        }

        private void simpleButton552_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit282.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class6, bytes);
        }

        private void simpleButton551_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit281.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class7, bytes);
        }

        private void simpleButton550_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit280.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class8, bytes);
        }

        private void simpleButton549_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit279.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class9, bytes);
        }

        private void simpleButton548_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit278.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class10, bytes);
        }

        private void simpleButton561_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
            setMod.PRFClasses(this);
        }

        private void simpleButton560_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
            setMod.CreatorClasses(this);
        }

        private void simpleButton559_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
            setMod.ColoredClasses(this);
        }

        private void simpleButton535_Click_1(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton536_Click_1(object sender, EventArgs e)
        {
            listBoxControl11.Items.Clear();
            listBoxControl11.Items.Add("All Players");
            for (int i = 0; i < 12; i++)
            {
                listBoxControl11.Items.Add(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(i));
            }
        }

        private void checkButton126_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton126.Checked)
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.GodModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.GodModeOFF(this);
            }
        }

        private void checkButton130_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton130.Checked)
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.ThirdPersonON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.ThirdPersonOFF(this);
            }
        }

        private void checkButton124_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton124.Checked)
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.SkateModON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.SkateModOFF(this);
            }
        }

        private void checkButton122_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton122.Checked)
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.HUDOFF(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.HUDON(this);
            }
        }

        private void checkButton117_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton117.Checked)
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.VisibilityOFF(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.VisibilityON(this);
            }
        }

        private void checkButton114_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton114.Checked)
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.SpecialistON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.SpecialistOFF(this);
            }
        }

        private void checkButton125_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton125.Checked)
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.DoubleSpeedON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.DoubleSpeedOFF(this);
            }
        }

        private void checkButton129_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton129.Checked)
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.UAVON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.UAVOFF(this);
            }
        }

        private void checkButton127_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton127.Checked)
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.LastStandON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.LastStandOFF(this);
            }
        }

        private void checkButton128_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton128.Checked)
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.AmmoOn(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
                setMod.AmmoOFF(this);
            }
        }

        private void toggleSwitch128_Toggled(object sender, EventArgs e)
        {
        }

        private void simpleButton538_Click(object sender, EventArgs e)
        {
            //ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(1, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(2, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(3, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(4, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(5, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(6, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(7, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(8, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(9, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(10, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(11, textEdit275.Text);
        }

        private void simpleButton537_Click(object sender, EventArgs e)
        {
            //ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(0, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(1, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(2, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(3, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(4, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(5, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(6, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(7, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(8, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(9, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(10, textEdit119.Text); ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.iPrintlnBold(11, textEdit275.Text);
        }

        private void simpleButton540_Click(object sender, EventArgs e)
        {
            //byte[] bytes = Encoding.ASCII.GetBytes(textEdit276.Text);
            //Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame11, bytes);

        }

        private void simpleButton539_Click(object sender, EventArgs e)
        {
            // NameChanger(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame + ((uint)this.spinEdit118.Value - 1u) * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient, this.textEdit276.Text);
        }

        private void BO3Advertise_Tick(object sender, EventArgs e)
        {
            //int num = new Random().Next(0, 7);
            //byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit276.Text);
            //Array.Resize<byte>(ref bytes, bytes.Length + 1); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame1, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame2, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame3, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame4, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame5, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame6, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame7, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame8, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame9, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame10, bytes); PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NameInGame11, bytes);
        }

        private void toggleSwitch127_Toggled(object sender, EventArgs e)
        {
            //if (toggleSwitch127.IsOn)
            //{
            //    BO3Advertise.Start();
            //}
            //else
            //{
            //    BO3Advertise.Stop();
            //}
        }

        private void simpleButton586_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit303.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton585_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl192.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
            textEdit303.Text = labelControl192.Text;
        }

        private void BO3NameFlash_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit303.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void toggleSwitch135_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch135.IsOn)
            {
                BO3NameFlash.Start();
            }
            else
            {
                BO3NameFlash.Stop();
            }
        }

        private void textEdit303_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton586.PerformClick();
            }
        }

        private void simpleButton583_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit302.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton584_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl192.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
            textEdit302.Text = labelControl192.Text;
        }

        private void BO3NameSlider_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
            setMod.NameSlider(this);
        }

        private void toggleSwitch126_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch126.IsOn)
            {
                BO3NameSlider.Start();
            }
            else
            {
                BO3NameSlider.Stop();
            }
        }

        private void BO3Clock_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, DateTime.Now.ToString("hh:mm:ss"));
        }

        private void toggleSwitch125_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch125.IsOn)
            {
                BO3Clock.Start();
            }
            else
            {
                BO3Clock.Stop();
            }
        }

        private void BO3Skipper_Tick(object sender, EventArgs e)
        {
            groupControl198.Text = Convert.ToString(stopWatch.Elapsed);
            if (groupControl198.Text.Contains("00:00:06."))
            {
                stopWatch.Restart();
            }
        }

        private void BO3Skipper1_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetMod setMod = new Games.Call_of_Duty_Black_Ops_3.SetMod();
            setMod.NameSkipper(this);
        }

        private void toggleSwitch124_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch124.IsOn)
            {
                stopWatch.Start();
                BO3Skipper.Start();
                BO3Skipper1.Start();
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                BO3Skipper.Stop();
                BO3Skipper1.Stop();
            }
        }

        private void BO3RB_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops.SetMod setMod = new Games.Call_of_Duty_Black_Ops.SetMod();
            setMod.RainbowName(this);
        }

        private void toggleSwitch123_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch123.IsOn)
            {
                BO3RB.Start();
            }
            else
            {
                BO3RB.Stop();
            }
        }
        private void simpleButton582_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton581_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BrandonCardenWV");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton580_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1CFW FTW");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton579_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Hacking...");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton578_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2$5 ^4PayPal");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton577_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Modded Lobby");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton576_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1REBUG");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton575_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("PS3ITA");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton574_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2HABIB");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton573_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit267.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton572_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit268.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton571_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit270.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton570_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+gostand}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This option was introduced in my Black Ops 2 RTM tool\nand i have received a lot of great feedback becuase of it.\nTo edit these presets go to the Tool Settings!", "Custom Preset Names", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton569_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+usereload}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton568_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+melee}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton567_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{weapnext}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton566_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+smoke}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton565_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+breathe_sprint}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, bytes);
        }

        private void simpleButton588_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x2c, 0x14, 0x00, 0x01 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.FPS, PRF);
        }

        private void simpleButton587_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x2c, 0x14, 0x00, 0x00 };
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.FPS, PRF);
        }

        private void checkEdit165_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit141.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ZMStats.kills, PRF);
        }

        private void checkEdit173_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit152.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ZMStats.Headshot, PRF);
        }

        private void checkEdit172_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit151.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ZMStats.round_survived, PRF);
        }

        private void checkEdit171_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit150.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ZMStats.score_per_minutes, PRF);
        }

        private void checkEdit169_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit148.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ZMStats.game_score, PRF);
        }

        private void checkEdit168_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit147.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ZMStats.experiences, PRF);
        }

        private void checkEdit167_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit142.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ZMStats.liquidDivinium, PRF);
        }

        private void checkEdit166_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit145.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ZMStats.Prestige, PRF);
        }

        private void checkEdit170_CheckedChanged(object sender, EventArgs e)
        {
            decimal num = (((this.spinEdit153.Value * 86400M) + (this.spinEdit149.Value * 3600M)) + (this.spinEdit146.Value * 60M)) + this.spinEdit144.Value;
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(num.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ZMStats.time_of_game, bytes);
        }

        private void simpleButton594_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetStats setStats = new Games.Call_of_Duty_Black_Ops_3.SetStats();
            setStats.ZMLegitStats(this);
        }

        private void simpleButton595_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetStats setStats = new Games.Call_of_Duty_Black_Ops_3.SetStats();
            setStats.ZMHighStats(this);
        }

        private void simpleButton593_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetStats setStats = new Games.Call_of_Duty_Black_Ops_3.SetStats();
            setStats.ZMInsaneStats(this);
        }

        private void simpleButton592_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetStats setStats = new Games.Call_of_Duty_Black_Ops_3.SetStats();
            setStats.ZMSendAll(this);
        }

        private void simpleButton591_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_3.SetStats setStats = new Games.Call_of_Duty_Black_Ops_3.SetStats();
            setStats.ZMClearAll(this);
        }

        private void BO3ZMLoop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 10);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ZMStats.Prestige, Code1);
            BO3ZMLoop.Start();
        }

        private void toggleSwitch136_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch136.IsOn)
            {
                BO3ZMLoop.Start();
            }
            else
            {
                BO3ZMLoop.Stop();
            }
        }
        #endregion
        #region Grand Theft Auto V Modifications
        private void checkEdit174_CheckedChanged(object sender, EventArgs e)
        {
            Games.Grand_Theft_Auto_V.Natives.STAT_SET_INT("MPPLY_KILLS_PLAYERS", Convert.ToInt32(spinEdit143.Value), 1);
        }

        private void checkEdit175_CheckedChanged(object sender, EventArgs e)
        {
            Games.Grand_Theft_Auto_V.Natives.STAT_SET_INT("MPPLY_DEATHS_PLAYER", Convert.ToInt32(spinEdit154.Value), 1);
        }

        void RankSet(string val)
        {
            Games.Grand_Theft_Auto_V.Natives.STAT_SET_INT("CHAR_XP_FM", Convert.ToInt32(val), 0);
        }

        private void checkEdit176_CheckedChanged(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Grand_Theft_Auto_V.RanksSet ranks = new ProjectRunningFox.Games.Grand_Theft_Auto_V.RanksSet();
            RankSet(Convert.ToString(ranks.Ranks[Convert.ToInt32(textEdit112.Text) - 1]));
        }

        private void simpleButton604_Click(object sender, EventArgs e)
        {
            Games.Grand_Theft_Auto_V.Natives.STAT_SET_BOOL("MPPLY_NO_MORE_TUTORIALS", 1, 1);
        }

        private void checkEdit177_CheckedChanged(object sender, EventArgs e)
        {
            ProjectRunningFox.Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.Money, Convert.ToInt32(spinEdit156.Value), 0);
        }

        private void checkEdit178_CheckedChanged(object sender, EventArgs e)
        {
            Games.Grand_Theft_Auto_V.Natives.STAT_SET_INT("PLAYER_HEADSHOTS", Convert.ToInt32(spinEdit157.Value), 1);
        }

        private void checkEdit181_CheckedChanged(object sender, EventArgs e)
        {
            Games.Grand_Theft_Auto_V.Natives.STAT_SET_INT("SHOTS", Convert.ToInt32(spinEdit160.Value), 1);
        }

        private void checkEdit180_CheckedChanged(object sender, EventArgs e)
        {
            Games.Grand_Theft_Auto_V.Natives.STAT_SET_INT("KILLS_COP", Convert.ToInt32(spinEdit159.Value), 1);
        }

        private void checkEdit179_CheckedChanged(object sender, EventArgs e)
        {
            Games.Grand_Theft_Auto_V.Natives.STAT_SET_INT("KILLS_SWAT", Convert.ToInt32(spinEdit158.Value), 1);
        }

        private void simpleButton605_Click(object sender, EventArgs e)
        {
            //unlock all
        }

        private void simpleButton602_Click(object sender, EventArgs e)
        {
            //stats 1
        }

        private void simpleButton603_Click(object sender, EventArgs e)
        {
            //high stats
        }

        private void simpleButton601_Click(object sender, EventArgs e)
        {
            //insane stats
        }

        private void simpleButton600_Click(object sender, EventArgs e)
        {
            //send all stats
        }

        private void simpleButton599_Click(object sender, EventArgs e)
        {
            //clear 
        }

        private void toggleSwitch137_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch137.IsOn)
            {
                byte[] PRF = new byte[] { 0x38, 0x60, 0x7F, 0xFF, 0xB0, 0x7F, 0x00, 0xB4 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.Godmode, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0xFC, 0x01, 0x10, 0x00, 0x41, 0x80, 0x01, 0x14 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.Godmode, PRF);
            }
        }

        private void toggleSwitch138_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch138.IsOn)
            {
                byte[] PRF = new byte[] { 0x3B, 0xA0, 0x27, 0x72 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.Ammo, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x63, 0xFD, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.Ammo, PRF);
            }
        }

        private void toggleSwitch139_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch139.IsOn)
            {
                byte[] PRF = new byte[] { 0x39, 0x60, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.NoPolice, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x81, 0x7D, 0x00, 0x04 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.NoPolice, PRF);
            }
        }

        private void toggleSwitch142_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch142.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.SuperJump, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x41, 0x82, 0x00, 0x10 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.SuperJump, PRF);
            }
        }

        private void toggleSwitch141_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch141.IsOn)
            {
                byte[] PRF = new byte[] { 0x40, 0xA0, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.Superman, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0xC0, 0xA0, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.Superman, PRF);
            }
        }

        private void toggleSwitch140_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch140.IsOn)
            {
                byte[] PRF = new byte[] { 0x00, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.NoGravity, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3F, 0x80, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.NoGravity, PRF);
            }
        }

        private void toggleSwitch145_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch145.IsOn)
            {
                byte[] PRF = new byte[] { 0x3F, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.SlowMotion, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3F, 0x80, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.SlowMotion, PRF);
            }
        }

        private void toggleSwitch144_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch144.IsOn)
            {
                byte[] PRF = new byte[] { 0x40, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.BigGuns, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3F, 0x80, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.HostMods.BigGuns, PRF);
            }
        }

        private void comboBoxEdit7_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            comboBoxEdit7.Text = comboBoxEdit7.SelectedText;
        }
        #endregion
        #region The Last of Us Modifications

        private void toggleSwitch143_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch143.IsOn)
            {
                byte[] PRF = new byte[] { 0x48, 0x6C, 0x0D, 0x24 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode, PRF);
                byte[] PRF1 = new byte[] { 0x3A, 0x20, 0x00, 0x8C };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode1, PRF1);
                byte[] PRF2 = new byte[] { 0x92, 0x3F, 0x00, 0x30 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode2, PRF2);
                byte[] PRF3 = new byte[] { 0x92, 0x3F, 0x00, 0x38 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode3, PRF3);
                byte[] PRF4 = new byte[] { 0x92, 0x3F, 0x00, 0x44 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode4, PRF4);
                byte[] PRF5 = new byte[] { 0x4B, 0x93, 0xF2, 0xD0 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode5, PRF5);
            }
            else
            {
                byte[] PRF = new byte[] { 0x80, 0x1F, 0x00, 0x30 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode, PRF);
                byte[] PRF1 = new byte[] { 0x38, 160, 0, 1 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode1, PRF1);
                byte[] PRF2 = new byte[] { 0x38, 160, 0, 1 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode2, PRF2);
                byte[] PRF3 = new byte[] { 0x38, 160, 0, 1 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode3, PRF3);
                byte[] PRF4 = new byte[] { 0x38, 160, 0, 1 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode4, PRF4);
                byte[] PRF5 = new byte[] { 0x38, 160, 0, 1 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.GodMode5, PRF5);
            }
        }

        private void toggleSwitch146_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch146.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Ammo, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0xB1, 0x3C, 0x05, 0x7C };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Ammo, PRF);
            }
        }

        private void toggleSwitch147_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch147.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Items, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x7C, 0x0B, 0x4A, 0x2E };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Items, PRF);
            }
        }

        private void toggleSwitch150_Toggled(object sender, EventArgs e)
        {
        }

        private void toggleSwitch149_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch149.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Oxygen, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0xD1, 0xBF, 0x08, 0x34 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Oxygen, PRF);
            }
        }

        private void toggleSwitch148_Toggled(object sender, EventArgs e)
        {
        }

        private void toggleSwitch151_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch151.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.FlameThrower, PRF);
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.FlameThrower1, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0xB1, 0x3F, 0x05, 0x7C };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.FlameThrower, PRF);
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.FlameThrower1, PRF);
            }
        }

        private void toggleSwitch152_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch152.IsOn)
            {
                byte[] PRF = new byte[] { 0x3C, 0xA0, 0x3B, 0x9A };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Money, PRF);
                byte[] PRF1 = new byte[] { 0xA6, 0x0A, 0x5C, 0x9F };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Money2, PRF1);
                byte[] PRF2 = new byte[] { 0xF7, 0xFA, 0x3E, 0xB7 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Money2, PRF2);
            }
            else
            {
                byte[] PRF = new byte[] { 0x7B, 0xBD, 0x00, 0x20 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Money, PRF);
                byte[] PRF1 = new byte[] { 0x80, 0xA9, 0x01, 0x60 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Money2, PRF1);
                byte[] PRF2 = new byte[] { 0x7F, 0xA3, 0xEB, 0x78 };
                PS3.SetMemory(ProjectRunningFox.Games.The_Last_of_US.Offsets.HostMods.Money2, PRF2);
            }
        }
        #endregion
        #region Skate 3 Modifications
        private void toggleSwitch160_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch160.IsOn)
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.BigArms, 2.0f);
            }
            else
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.BigArms, 1.0f);
            }
        }

        private void toggleSwitch159_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch159.IsOn)
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.SuperJump, 250.0f);
            }
            else
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.SuperJump, 19.6f);
            }
        }

        private void toggleSwitch158_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch158.IsOn)
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.ScreenParticles, 5.0f);
            }
            else
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.ScreenParticles, 1.0f);
            }
        }

        private void toggleSwitch157_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch157.IsOn)
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.InsaneOllie, -150);
            }
            else
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.InsaneOllie, -9.8f);
            }
        }

        private void toggleSwitch156_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch156.IsOn)
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.InsanePEDS, 2.0f);
            }
            else
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.InsanePEDS, 1.0f);
            }
        }
        private void toggleSwitch155_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch156.IsOn)
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.ShakyCamera, 1.5f);
            }
            else
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.ShakyCamera, 1.0f);
            }
        }

        private void toggleSwitch154_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch154.IsOn)
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.RainbowScreen, 5.0f);
            }
            else
            {
                PS3.Extension.WriteFloat(ProjectRunningFox.Games.Skate_3.Offsets.HostMods.RainbowScreen, 1.0f);
            }
        }
        #endregion
        #region Battlefield 3 Modifications
        private void toggleSwitch167_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch167.IsOn)
            {
                byte[] PRF = new byte[] { 42, 0x7a };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.IncreasedDamage, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3f, 80 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.IncreasedDamage, PRF);
            }
        }

        private void toggleSwitch166_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch166.IsOn)
            {
                byte[] PRF = new byte[] { 0x38, 0x60, 0x00, 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.UAV, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x38, 0x60, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.UAV, PRF);
            }
        }

        private void toggleSwitch165_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch165.IsOn)
            {
                byte[] PRF = new byte[] { 0x4e, 0x80, 0x00, 0x20 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.WallHack, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x7c, 0x08, 0x02, 0xa6 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.WallHack, PRF);
            }
        }

        private void toggleSwitch164_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch164.IsOn)
            {
                byte[] PRF = new byte[] { 0x40, 0x82, 0x00, 0x1C };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.SniperBreath, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x41, 0x82, 0x00, 0x1C };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.SniperBreath, PRF);
            }
        }

        private void toggleSwitch163_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch163.IsOn)
            {
                byte[] PRF = new byte[] { 0x3c, 0xa0, 0x44, 0x7a };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.OneHitKill, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3c, 0xa0, 0x3f, 0x80 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.OneHitKill, PRF);
            }
        }

        private void toggleSwitch162_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch162.IsOn)
            {
                byte[] PRF = new byte[] { 0x38, 0xA0, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.NameTags, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x38, 0xA0, 0x00, 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.NameTags, PRF);
            }
        }

        private void toggleSwitch161_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch161.IsOn)
            {
                byte[] PRF = new byte[] { 0x3c, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.NoRecoil1, PRF);
                byte[] PRF1 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0xbf, 0x80, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.NoRecoil2, PRF1);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3f, 0x80, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.NoRecoil1, PRF);
                byte[] PRF1 = new byte[] { 0x3f, 0x80, 0x00, 0x00, 0x3f, 0x66, 0x66, 0x66 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_3.Offsets.HostMods.NoRecoil2, PRF1);
            }
        }
        #endregion
        #region Battlefield Hardline Modifications
        private void toggleSwitch174_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch174.IsOn)
            {
                byte[] PRF = new byte[] { 0x3C, 0xE0, 0x44, 0x7A };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.OneHitKill, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3C, 0xE0, 0x3F, 0x80 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.OneHitKill, PRF);
            }
        }

        private void toggleSwitch173_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch173.IsOn)
            {
                byte[] PRF = new byte[] { 0x3c, 0x80, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.NoRecoil, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3c, 0x80, 0x3F, 0x80 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.NoRecoil, PRF);
            }
        }

        private void toggleSwitch172_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch172.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.WallHack, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x41, 0x82, 0x00, 0x08 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.WallHack, PRF);
            }
        }

        private void toggleSwitch171_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch171.IsOn)
            {
                byte[] PRF = new byte[] { 0x2c, 0x03, 0x00, 0x01 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.UAV, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x2c, 0x03, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.UAV, PRF);
            }
        }

        private void toggleSwitch170_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch170.IsOn)
            {
                byte[] PRF = new byte[] { 0x89, 0x23, 0x00, 0x06 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.InstantHit, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x89, 0x23, 0x00, 0x05 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.InstantHit, PRF);
            }
        }

        private void toggleSwitch169_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch169.IsOn)
            {
                byte[] PRF = new byte[] { 0x38, 0x60, 0x00, 0xE4 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.Gravity, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x38, 0x60, 0x00, 0xE8 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.Gravity, PRF);
            }
        }

        private void toggleSwitch168_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch168.IsOn)
            {
                byte[] PRF = new byte[] { 0x00, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.SniperBreath, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3f, 0x80, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.SniperBreath, PRF);
            }
        }

        private void toggleSwitch153_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch153.IsOn)
            {
                byte[] PRF = new byte[] { 0x40, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.FOV, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3F, 0x80, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_Hardline.Offsets.HostMods.FOV, PRF);
            }
        }
        #endregion
        #region Battlefield 4 Modifications
        private void toggleSwitch182_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch182.IsOn)
            {
                byte[] PRF = new byte[] { 0x63, 0xE3, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.UAV, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3B, 0xE0, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.UAV, PRF);
            }
        }

        private void toggleSwitch181_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch181.IsOn)
            {
                byte[] PRF = new byte[] { 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.NoRecoil, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3F, 0x80 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.NoRecoil, PRF);
            }
        }

        private void toggleSwitch180_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch180.IsOn)
            {
                byte[] PRF = new byte[] { 0xD0, 0x3B, 0x00, 0xB8 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.NoReload, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0xD0, 0x3B, 0x00, 0xB0 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.NoReload, PRF);
            }
        }

        private void toggleSwitch179_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch179.IsOn)
            {
                byte[] PRF = new byte[] { 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.NoSpread, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3F, 0x80 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.NoSpread, PRF);
            }
        }

        private void toggleSwitch178_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch178.IsOn)
            {
                byte[] PRF = new byte[] { 0x38, 0x60, 0x00, 0xD4 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.MaxDistance, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x38, 0x60, 0x00, 0xD8 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.MaxDistance, PRF);
            }
        }

        private void toggleSwitch177_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch177.IsOn)
            {
                byte[] PRF = new byte[] { 0x40 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.NameTags, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x41 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.NameTags, PRF);
            }
        }

        private void toggleSwitch176_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch176.IsOn)
            {
                byte[] PRF = new byte[] { 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.Sniperbreath, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3F, 0x80 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.Sniperbreath, PRF);
            }
        }

        private void toggleSwitch175_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch175.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.VehicleWallhack, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x41, 0x82, 0x00, 0x08 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.VehicleWallhack, PRF);
            }
        }

        private void toggleSwitch183_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch183.IsOn)
            {
                byte[] PRF = new byte[] { 0x40 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.PlayerWallhack, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x41 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.PlayerWallhack, PRF);
            }
        }

        private void toggleSwitch186_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch186.IsOn)
            {
                byte[] PRF = new byte[] { 0x44, 0x7A };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.OneShotKill, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x3F, 0x80 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.OneShotKill, PRF);
            }
        }

        private void toggleSwitch185_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch185.IsOn)
            {
                byte[] PRF = new byte[] { 0x89, 0x26, 0x01, 0x16 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.InstantHit, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x89, 0x26, 0x01, 0x15 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.InstantHit, PRF);
            }
        }

        private void toggleSwitch184_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch184.IsOn)
            {
                byte[] PRF = new byte[] { 0x89, 0x26, 0x01, 0x16 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.UnlockAll, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x89, 0x26, 0x01, 0x15 };
                PS3.SetMemory(ProjectRunningFox.Games.Battlefield_4.Offsets.HostMods.UnlockAll, PRF);
            }
        }
        #endregion
        #region Just Cause 2 Modifications
        private void toggleSwitch188_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch188.IsOn)
            {
                byte[] PRF = new byte[] { 0xED, 0x80, 0x00, 0x28 };
                PS3.SetMemory(ProjectRunningFox.Games.Just_Cause_2.Offsets.HostMods.GodMode, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0xED, 0x80, 0x03, 0x72 };
                PS3.SetMemory(ProjectRunningFox.Games.Just_Cause_2.Offsets.HostMods.GodMode, PRF);
            }
        }

        private void toggleSwitch189_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch189.IsOn)
            {
                byte[] PRF = new byte[] { 0x39, 0x29, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Just_Cause_2.Offsets.HostMods.Ammo, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x39, 0x29, 0xFF, 0xFF };
                PS3.SetMemory(ProjectRunningFox.Games.Just_Cause_2.Offsets.HostMods.Ammo, PRF);
            }
        }
        #endregion
        #region Skyrim Modifications
        private void toggleSwitch197_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch197.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.InfiniteDragonSouls, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x7C, 0x26, 0x3D, 0x2E };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.InfiniteDragonSouls, PRF);
            }
        }

        private void toggleSwitch196_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch196.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.InfiniteShout, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0xD0, 0x23, 0x00, 0x10 };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.InfiniteShout, PRF);
            }
        }

        private void toggleSwitch195_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch195.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.InfiniteArrows, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x93, 0xFD, 0x00, 0x24 };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.InfiniteArrows, PRF);
            }
        }

        private void toggleSwitch194_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch194.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.Carryweightnoincrease, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x90, 0xC5, 0x00, 0x08 };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.Carryweightnoincrease, PRF);
            }
        }

        private void toggleSwitch193_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch193.IsOn)
            {
                byte[] PRF = new byte[] { 0x38, 0x60, 0x7F, 0xFF };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.Maxshopgold, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x7C, 0x63, 0x07, 0xB4 };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.Maxshopgold, PRF);
            }
        }

        private void toggleSwitch192_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch192.IsOn)
            {
                byte[] PRF = new byte[] { 0x38, 0x60, 0x00, 0x0F };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.Craftnomaterial, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x63, 0xC3, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Skyrim.Offsets.HostMods.Craftnomaterial, PRF);
            }
        }

        private void toggleSwitch191_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch191.IsOn)
            {
                ProjectRunningFox.Games.Skyrim.Offsets.InfiniteHPMPStaminaON();
            }
            else
            {
                ProjectRunningFox.Games.Skyrim.Offsets.InfiniteHPMPStaminaOFF();
            }
        }
        #endregion
        #region Dark Souls 2 Modifications
        private void toggleSwitch190_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch190.IsOn)
            {
                ProjectRunningFox.Games.Dark_Souls_2.Offsets.GodmodeON();
            }
            else
            {
                ProjectRunningFox.Games.Dark_Souls_2.Offsets.GodmodeOFF();
            }
        }

        private void toggleSwitch198_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch198.IsOn)
            {
                ProjectRunningFox.Games.Dark_Souls_2.Offsets.MaxSouls();
            }
        }
        #endregion
        #region Assassins Creed Rogue Modifications
        private void toggleSwitch204_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch204.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Assassins_Creed_Rogue.Offsets_cs.HostMods.GodMode, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(ProjectRunningFox.Games.Assassins_Creed_Rogue.Offsets_cs.HostMods.GodMode, new byte[] { 0x91, 0x7F, 0x00, 0x88 });
            }
        }

        private void toggleSwitch203_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch203.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Assassins_Creed_Rogue.Offsets_cs.HostMods.Ammo, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(ProjectRunningFox.Games.Assassins_Creed_Rogue.Offsets_cs.HostMods.Ammo, new byte[] { 0x91, 0x23, 0x00, 0x0C });
            }
        }

        private void toggleSwitch202_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch202.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Assassins_Creed_Rogue.Offsets_cs.HostMods.ShipGodMode, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(ProjectRunningFox.Games.Assassins_Creed_Rogue.Offsets_cs.HostMods.ShipGodMode, new byte[] { 0x90, 0x9F, 0x00, 0x78 });
            }
        }

        private void toggleSwitch201_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch201.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Assassins_Creed_Rogue.Offsets_cs.HostMods.Money, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(ProjectRunningFox.Games.Assassins_Creed_Rogue.Offsets_cs.HostMods.Money, new byte[] { 0x90, 0x9F, 0x00, 0x0C });
            }
        }
        #endregion
        #region Grand Theft Auto SA Modifications
        private void toggleSwitch205_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch205.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.GodMode, new byte[] { 0x00, 0x00, 0x01, 0x00 });
            }
            else
            {
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.GodMode, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            }
        }

        private void comboBoxEdit9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void toggleSwitch200_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch200.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.Ammo, new byte[] { 0x00, 0x01, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.Ammo, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            }
        }

        private void toggleSwitch150_Toggled_1(object sender, EventArgs e)
        {
            if (toggleSwitch150.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.Jump, new byte[] { 0x00, 0x01, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.Jump, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            }
        }

        private void toggleSwitch148_Toggled_1(object sender, EventArgs e)
        {
            if (toggleSwitch148.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.Oxygen, new byte[] { 0x00, 0x00, 0x00, 0x01 });
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.Oxygen1, new byte[] { 0x41, 0x07, 0x0A, 0x3D });
            }
            else
            {
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.Oxygen, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.Oxygen1, new byte[] { 0x3F, 0x54, 0x7A, 0xE1 });
            }
        }

        private void toggleSwitch206_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch206.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.FloatingCars, new byte[] { 0x00, 0x01, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(ProjectRunningFox.Games.Grand_Theft_Auto_SA.Offsets.HostMods.FloatingCars, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            }
        }
        #endregion
        #region Farcry4 Modifications
        private void toggleSwitch214_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch214.IsOn)
            {
                byte[] PRF = new byte[] { 0xD0, 0x43, 0x00, 0x10 };
                PS3.SetMemory(ProjectRunningFox.Games.Far_Cry_4.Offsets.HostMods.GodMode, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x48, 0x00, 0x00, 0x04 };
                PS3.SetMemory(ProjectRunningFox.Games.Far_Cry_4.Offsets.HostMods.GodMode, PRF);
            }
        }

        private void toggleSwitch213_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch213.IsOn)
            {
                byte[] PRF = new byte[] { 0x7C, 0xA4, 0x2B, 0x78 };
                PS3.SetMemory(ProjectRunningFox.Games.Far_Cry_4.Offsets.HostMods.NoReload, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x7C, 0x9F, 0x28, 0x10 };
                PS3.SetMemory(ProjectRunningFox.Games.Far_Cry_4.Offsets.HostMods.NoReload, PRF);
            }
        }

        private void toggleSwitch212_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch212.IsOn)
            {
                byte[] PRF = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(ProjectRunningFox.Games.Far_Cry_4.Offsets.HostMods.InfEquipment, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0x7C, 0x9F, 0x20, 0x10 };
                PS3.SetMemory(ProjectRunningFox.Games.Far_Cry_4.Offsets.HostMods.InfEquipment, PRF);
            }
        }

        private void toggleSwitch199_Toggled_1(object sender, EventArgs e)
        {
            if (toggleSwitch199.IsOn)
            {
                byte[] PRF = new byte[] { 0x1F, 0xC4, 0x01, 0xF4 };
                PS3.SetMemory(ProjectRunningFox.Games.Far_Cry_4.Offsets.HostMods.XP, PRF);
            }
            else
            {
            }
        }
        #endregion
        #region Minecraft Modifications
        private void toggleSwitch217_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch217.IsOn)
            {
                byte[] PRF = new byte[] { 0xfc, 0, 0xf8, 0x90 };
                PS3.SetMemory(ProjectRunningFox.Games.Minecraft.Offsets.HostMods.Godmode, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0xfc, 0x20, 0xf8, 0x90 };
                PS3.SetMemory(ProjectRunningFox.Games.Minecraft.Offsets.HostMods.Godmode, PRF);
            }
        }

        private void toggleSwitch216_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch216.IsOn)
            {
                byte[] PRF = new byte[4];
                PRF[0] = 0xbf;
                PRF[1] = 0x80;
                PS3.SetMemory(ProjectRunningFox.Games.Minecraft.Offsets.HostMods.InfiniteFood, PRF);
            }
            else
            {
                byte[] PRF2 = new byte[4];
                PRF2[0] = 0x3f;
                PRF2[1] = 0x80;
                PS3.SetMemory(ProjectRunningFox.Games.Minecraft.Offsets.HostMods.InfiniteFood, PRF2);
            }
        }

        private void toggleSwitch215_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch215.IsOn)
            {
                byte[] PRF = new byte[4];
                PRF[0] = 0x38;
                PRF[1] = 0x80;
                PS3.SetMemory(ProjectRunningFox.Games.Minecraft.Offsets.HostMods.InstantMine, PRF);
            }
            else
            {
                byte[] PRF2 = new byte[] { 0x38, 0x80, 0, 1 };
                PS3.SetMemory(ProjectRunningFox.Games.Minecraft.Offsets.HostMods.InstantMine, PRF2);
            }
        }

        private void toggleSwitch187_Toggled_1(object sender, EventArgs e)
        {
            if (toggleSwitch187.IsOn)
            {
                byte[] PRF = new byte[] { 0xfc, 0, 0xf8, 0x90 };
                PS3.SetMemory(ProjectRunningFox.Games.Minecraft.Offsets.HostMods.NoFallDamage, PRF);
            }
            else
            {
                byte[] PRF = new byte[] { 0xfc, 0x20, 0xf8, 0x90 };
                PS3.SetMemory(ProjectRunningFox.Games.Minecraft.Offsets.HostMods.NoFallDamage, PRF);
            }
        }
        #endregion
        #region South Park Modifications
        private void toggleSwitch210_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch210.IsOn)
            {
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.GodMode1, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.GodMode2, new byte[] { 0x39, 0x00, 0x00, 0x01, 0xFF, 0xE0, 0x08, 0x90, 0x63, 0x63, 0x00, 0x00, 0x4B, 0xF4, 0x3B, 0x7D, 0x91, 0x03, 0x00, 0x2C });
            }
            else
            {
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.GodMode1, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.GodMode2, new byte[] { 0x39, 0x00, 0x00, 0x00, 0xFF, 0xE0, 0x08, 0x90, 0x63, 0x63, 0x00, 0x00, 0x4B, 0xF4, 0x3B, 0x7D, 0x91, 0x03, 0x00, 0x2C });
            }
        }

        private void toggleSwitch209_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch209.IsOn)
            {
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.InfinitePPMania1, new byte[] { 0xC0, 0x25, 0x00, 0x04 });
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.InfinitePPMania2, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.InfinitePPMania1, new byte[] { 0xEF, 0xE1, 0x10, 0x28 });
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.InfinitePPMania2, new byte[] { 0x4B, 0xE6, 0xB0, 0x7D });
            }
        }

        private void toggleSwitch208_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch208.IsOn)
            {
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.Networth, new byte[] { 0x83, 0xBC, 0x00, 0x04 });
            }
            else
            {
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.Networth, new byte[] { 0x7F, 0x7B, 0xE8, 0x10 });
            }
        }

        private void toggleSwitch207_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch207.IsOn)
            {
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.MaxXpAfterBattle, new byte[] { 0x38, 0x84, 0x27, 0x10 });
            }
            else
            {
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.MaxXpAfterBattle, new byte[] { 0x7C, 0x84, 0xF0, 0x14 });
            }
        }

        private void toggleSwitch211_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch211.IsOn)
            {
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.MaxItemsonuse, new byte[] { 0x38, 0x80, 0x00, 0x0A });
            }
            else
            {
                PS3.SetMemory(Games.South_Park_The_Stick_of_Truth.Offsets.HostOffsets.MaxItemsonuse, new byte[] { 0x60, 0x7A, 0x00, 0x00 });
            }
        }
        #endregion
        #region Red Dead Redemption
        private void toggleSwitch221_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch221.IsOn)
            {
                PS3.SetMemory(Games.Red_Dead_Redemption.Offsets.HostMods.Godmode, new byte[] { 0x3C, 0x60, 0x47, 0xC3, 0x90, 0x7C, 0x00, 0x10, 0x90, 0x7C, 0x00, 0x14, 0x41, 0x82, 0x00, 0x48 });
            }
            else
            {
                PS3.SetMemory(Games.Red_Dead_Redemption.Offsets.HostMods.Godmode, new byte[] { 0x4C, 0x42, 0x29, 0xC2, 0x41, 0x82, 0x00, 0x54, 0xEC, 0x21, 0x18, 0x28, 0xEC, 0x42, 0x18, 0x28 });
            }
        }

        private void toggleSwitch220_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch220.IsOn)
            {
                PS3.SetMemory(Games.Red_Dead_Redemption.Offsets.HostMods.ammo, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Red_Dead_Redemption.Offsets.HostMods.ammo, new byte[] { 0xEC, 0x21, 0xF0, 0x28 });
            }
        }

        private void toggleSwitch219_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch219.IsOn)
            {
                PS3.SetMemory(Games.Red_Dead_Redemption.Offsets.HostMods.horse, new byte[] { 0xC3, 0xDF, 0x00, 0x14, 0xD3, 0xDF, 0x00, 0x10 });
            }
            else
            {
                PS3.SetMemory(Games.Red_Dead_Redemption.Offsets.HostMods.horse, new byte[] { 0xFF, 0xC5, 0xF1, 0x2E, 0xD3, 0xDF, 0x00, 0x14 });
            }
        }

        private void toggleSwitch218_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch218.IsOn)
            {
                PS3.SetMemory(Games.Red_Dead_Redemption.Offsets.HostMods.items, new byte[] { 0x30, 0x63, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Red_Dead_Redemption.Offsets.HostMods.items, new byte[] { 0x30, 0x63, 0xFF, 0xFF });
            }
        }

        private void toggleSwitch222_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch222.IsOn)
            {
                PS3.SetMemory(Games.Red_Dead_Redemption.Offsets.HostMods.deadeye, new byte[] { 0xC0, 0x26, 0x03, 0x94, 0xD0, 0x26, 0x03, 0x90 });
            }
            else
            {
                PS3.SetMemory(Games.Red_Dead_Redemption.Offsets.HostMods.deadeye, new byte[] { 0xC0, 0x46, 0x03, 0x90, 0xEC, 0x22, 0x08, 0x2A });
            }
        }
        #endregion
        #region Black Osp 2
        private void checkEdit155_CheckedChanged_1(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit162.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Kills, PRF);
        }
        private void checkEdit187_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit164.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Deaths, PRF);
        }
        private void checkEdit188_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit167.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.HeadShots, PRF);
        }
        private void checkEdit190_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit161.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Score, PRF);
        }
        private void checkEdit192_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit170.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Wins, PRF);
        }
        private void checkEdit193_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit172.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Losses, PRF);
        }
        private void checkEdit191_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit171.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Tokens, PRF);
        }
        private void checkEdit189_CheckedChanged(object sender, EventArgs e)
        {
            decimal num = (((this.spinEdit169.Value * 86400M) + (this.spinEdit168.Value * 3600M)) + (this.spinEdit166.Value * 60M)) + this.spinEdit165.Value;
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(num.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.TimePlayed, bytes);
        }
        private void checkEdit182_CheckedChanged_1(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit163.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Prestige, PRF);
        }
        private void checkEdit194_CheckedChanged(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.Levels levels = new Games.Call_of_Duty_Black_Ops_2.Levels();
            levels.SetLevel(this);
        }
        private void simpleButton641_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats setStats = new Games.Call_of_Duty_Black_Ops_2.SetStats();
            setStats.LegitStats(this);
        }
        private void simpleButton642_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats setStats = new Games.Call_of_Duty_Black_Ops_2.SetStats();
            setStats.HighStats(this);
        }
        private void simpleButton640_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats setStats = new Games.Call_of_Duty_Black_Ops_2.SetStats();
            setStats.InsaneStats(this);
        }
        private void simpleButton639_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats setStats = new Games.Call_of_Duty_Black_Ops_2.SetStats();
            setStats.SendAll(this);
        }
        private void simpleButton638_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats setStats = new Games.Call_of_Duty_Black_Ops_2.SetStats();
            setStats.ClearAll(this);
        }
        private void BO2Loop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int prestige = random.Next(1, 15);
            byte[] Code1 = BitConverter.GetBytes(prestige);
            Array.Resize(ref Code1, Code1.Length + 1);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Prestige, Code1);
            BO2Loop.Start();
        }
        private void BO2Loop1_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats setStats = new Games.Call_of_Duty_Black_Ops_2.SetStats();
            setStats.LevelLoop(this);
        }
        private void toggleSwitch231_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch231.IsOn)
            {
                BO2Loop.Start();
            }
            else
            {
                BO2Loop.Stop();
            }
        }
        private void toggleSwitch232_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch232.IsOn)
            {
                BO2Loop1.Start();
            }
            else
            {
                BO2Loop1.Stop();
            }
        }
        private void simpleButton637_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.UnlockAll.SetUnlockAll();
        }
        private void simpleButton636_Click(object sender, EventArgs e)
        {
            byte[] PRF = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level55, PRF);
        }
        private void toggleSwitch238_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch238.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.SteadyAim, new byte[] { 0x2C, 0x04, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.SteadyAim, new byte[] { 0x2C, 0x04, 0x00, 0x02 });
            }
        }
        private void toggleSwitch237_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch237.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.NoRecoil, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.NoRecoil, new byte[] { 0x48, 0x50, 0x6E, 0xF5 });
            }
        }
        private void toggleSwitch236_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch236.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Laser, new byte[] { 0x2C, 0x03, 0x00, 0x01 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Laser, new byte[] { 0x2C, 0x03, 0x00, 0x00 });
            }
        }

        private void toggleSwitch235_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch235.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.FOV, new byte[] { 0x42, 0xDC });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.FOV, new byte[] { 0x41, 0x20 });
            }
        }
        private void toggleSwitch234_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch234.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.TargetFinder, new byte[] { 0x01 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.TargetFinder, new byte[] { 0x00 });
            }
        }
        private void toggleSwitch233_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch233.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BigNames, new byte[] { 0x3F, 0xFF, 0xFF, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BigNames, new byte[] { 0x3F, 0x26, 0x66, 0x66 });
            }
        }
        private void toggleSwitch244_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch244.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.RedBox0, new byte[] { 0x38, 0x60, 0x00, 0x01 });
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.RedBox1, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.RedBox0, new byte[] { 0x38, 0x60, 0x00, 0x00 });
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.RedBox1, new byte[] { 0x41, 0x81, 0x01, 0x0C });
            }
        }
        private void toggleSwitch243_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch243.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.FloatingBodies, new byte[] { 0x43, 0x48 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.FloatingBodies, new byte[] { 0xC4, 0x48 });
            }
        }
        private void toggleSwitch242_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch242.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BlinkingBoddies, new byte[] { 0x2C, 0x03, 0x00, 0x01 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BlinkingBoddies, new byte[] { 0xDB, 0xC1, 0x00, 0xF0 });
            }
        }
        private void toggleSwitch241_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch241.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.WallHack1, new byte[] { 0x38, 0xC0, 0xFF, 0xFF });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.WallHack1, new byte[] { 0x63, 0x26, 0x00, 0x00 });
            }
        }
        private void toggleSwitch240_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch240.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.VSAT, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.VSAT, new byte[] { 0x40, 0x81, 0x00, 0x44 });
            }
        }
        private void toggleSwitch239_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch239.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.UAV, new byte[] { 0x2C, 0x03, 0x00, 0x01 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.UAV, new byte[] { 0x2C, 0x03, 0x00, 0x00 });
            }
        }
        private void toggleSwitch253_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch253.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BodyColor, new byte[] { 0x3F, 0x80, 0x00, 0x00, 0x6F, 0x80, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BodyColor, new byte[] { 0x3F, 0x80, 0x00, 0x00, 0x3F, 0x80, 0x00, 0x00 });
            }
        }
        private void toggleSwitch254_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch254.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BodyColor, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BodyColor, new byte[] { 0x3F, 0x80, 0x00, 0x00, 0x3F, 0x80, 0x00, 0x00 });
            }
        }
        private void toggleSwitch255_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch255.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BodyColor, new byte[] { 0x3F, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BodyColor, new byte[] { 0x3F, 0x80, 0x00, 0x00, 0x3F, 0x80, 0x00, 0x00 });
            }
        }
        private void toggleSwitch256_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch256.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BodyColor, new byte[] { 0x3F, 0xFF, 0x00, 0x00, 0x3F, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.BodyColor, new byte[] { 0x3F, 0x80, 0x00, 0x00, 0x3F, 0x80, 0x00, 0x00 });
            }
        }
        private void toggleSwitch257_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch257.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.SkyColor, new byte[] { 0xFF, 0x80 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.SkyColor, new byte[] { 0x3F, 0x80 });
            }
        }
        private void toggleSwitch258_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch258.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.SkyColor, new byte[] { 0x5F, 0x80 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.SkyColor, new byte[] { 0x3F, 0x80 });
            }
        }
        public void SpoofIP(uint client)
        {
            PS3.Extension.WriteBytes(0x00f9e726 + ((uint)client * 328), new byte[] { 0x23, 0x07, 0x49, 0x22, 0x33, 0x01 });
        }
        private void BO2IPSpoof_Tick(object sender, EventArgs e)
        {
            SpoofIP(0);
        }
        private void toggleSwitch259_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch259.IsOn)
            {
                BO2IPSpoof.Start();
            }
            else
            {
                BO2IPSpoof.Stop();
            }
        }
        private void endgame()
        {
            string str = "cmd mr " + PS3.Extension.ReadInt32(0xf11d9c) + " 3 endround";
            object[] parameters = new object[] { 0, str };
            Games.Call_of_Duty_Black_Ops_2.RPC.Call(0x313c18, parameters);
        }
        private void toggleSwitch260_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch260.IsOn)
            {
                endgame();
                toggleSwitch260.IsOn = false;
            }
        }
        private void toggleSwitch261_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch261.IsOn)
            {
                PS3.SetMemory(0xd82158, new byte[] { 1 });
            }
            else
            {
                PS3.SetMemory(0xd82158, new byte[1]);
            }
        }
        private void simpleButton653_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.AllClasses(this);
        }
        private void simpleButton652_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class1, textEdit333.Text);
        }
        private void simpleButton651_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class2, textEdit332.Text);
        }
        private void simpleButton650_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class3, textEdit331.Text);
        }
        private void simpleButton649_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class4, textEdit330.Text);
        }
        private void simpleButton648_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class5, textEdit329.Text);
        }
        private void simpleButton647_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class6, textEdit328.Text);
        }

        private void simpleButton646_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class7, textEdit327.Text);
        }
        private void simpleButton645_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class8, textEdit326.Text);
        }
        private void simpleButton644_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class9, textEdit325.Text);
        }
        private void simpleButton643_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class10, textEdit324.Text);
        }
        private void simpleButton656_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.PrfClasses(this);
        }
        private void simpleButton655_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.CreatorClasses(this);
        }
        private void simpleButton654_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.ClassNames.ColoredClasses(this);
        }
        private void simpleButton658_Click(object sender, EventArgs e)
        {
            listBoxControl14.Items.Clear();
            listBoxControl14.Items.Add("All Players");
            for (int i = 0; i < 12; i++)
            {
                listBoxControl14.Items.Add(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(i));
            }
        }
        private void simpleButton657_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void checkButton132_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton132.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.GodModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.GodModeOFF(this);
            }
        }
        private void checkButton134_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton134.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.AmmoON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.AmmoOFF(this);
            }
        }
        private void checkButton136_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton136.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.ThirdPersonON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.ThirdPersonOFF(this);
            }
        }
        private void checkButton123_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton123.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.VSATON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.VSATOff(this);
            }
        }
        private void checkButton113_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton113.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.SpeedON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.SpeedOFF(this);
            }
        }
        private void checkButton131_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton131.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.ScorestreaksON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.ScorestreaksOFF(this);
            }
        }
        private void checkButton135_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton135.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.JumperON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.JumperOFF(this);
            }
        }
        private void checkButton133_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton133.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.InvisibleON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.InvisibleOFF(this);
            }
        }
        private void checkButton121_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton121.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.FreezeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.FreezeOFF(this);
            }
        }
        private void checkButton112_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton112.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.LagON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetMod.LagOFF(this);
            }
        }
        private void toggleSwitch246_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch246.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.ForceHost, new byte[] { 0x00 });
            }
            else
            {
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.ForceHost, new byte[] { 0x01 });
            }
        }
        private void toggleSwitch247_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch247.IsOn)
            {
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Protection.AntiBan1, new byte[] { 0x99 });
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Protection.AntiBan2, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Protection.AntiBan3, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Protection.AntiBan4, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Protection.AntiBan5, new byte[] { 0x48, 0x00 });
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Protection.AntiBan6, new byte[] { 0x48, 0x00 });
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Protection.AntiBan7, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Protection.AntiBan8, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
        }
        private void simpleButton685_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Speed, new byte[3]);
        }

        private void simpleButton687_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[3];
            buffer[2] = 2;
            byte[] buffer2 = buffer;
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Speed, buffer2);
        }
        private void simpleButton688_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[3];
            buffer[2] = 6;
            byte[] buffer2 = buffer;
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Speed, buffer2);
        }
        private void simpleButton686_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Jump, new byte[] { 0x42, 0x9C });
        }
        private void simpleButton689_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Jump, new byte[] { 0x44, 0x61 });
        }
        private void simpleButton690_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Jump, new byte[] { 0x45, 0x48 });
        }
        private void simpleButton693_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Gravity, new byte[] { 0x44, 0x48 });
        }
        private void simpleButton692_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Gravity, new byte[] { 0x43, 9 });
        }
        private void simpleButton691_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Gravity, new byte[] { 0x41, 0x48 });
        }
        private void simpleButton667_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetMod.iPrintln1(this);
        }
        private void simpleButton666_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetMod.iPrintBold1(this);
        }
        private void simpleButton669_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetMod.SetAllNames(this);
        }
        private void simpleButton668_Click(object sender, EventArgs e)
        {
            NameChanger(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName + ((uint)this.spinEdit174.Value - 1u) * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient, this.textEdit335.Text);
        }
        private void BO2Advertise_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetMod.FlashAll(this);
        }
        private void toggleSwitch245_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch245.IsOn)
            {
                BO2Advertise.Start();
            }
            else
            {
                BO2Advertise.Stop();
            }
        }
        private void simpleButton684_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit349.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton683_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl808.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
            textEdit349.Text = labelControl808.Text;
        }
        private void BO2NameFlash_Tick(object sender, EventArgs e)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + this.textEdit349.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void toggleSwitch252_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch252.IsOn)
            {
                BO2NameFlash.Start();
            }
            else
            {
                BO2NameFlash.Stop();
            }
        }
        private void simpleButton681_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit348.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton682_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(labelControl808.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
            textEdit348.Text = labelControl808.Text;
        }
        private void BO2NameSlider_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetMod.NameSlider(this);
        }
        private void toggleSwitch251_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch251.IsOn)
            {
                BO2NameSlider.Start();
            }
            else
            {
                BO2NameSlider.Stop();
            }
        }
        private void BO2Clock_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, DateTime.Now.ToString("hh:mm:ss"));
        }
        private void toggleSwitch250_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch250.IsOn)
            {
                BO2Clock.Start();
            }
            else
            {
                BO2Clock.Stop();
            }
        }
        private void BO2NameSkipper_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetMod.NameSkipper(this);
        }
        private void BO2NameSkipper1_Tick(object sender, EventArgs e)
        {
            groupControl230.Text = Convert.ToString(stopWatch.Elapsed);
            if (groupControl230.Text.Contains("00:00:06."))
            {
                stopWatch.Restart();
            }
        }
        private void toggleSwitch249_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch249.IsOn)
            {
                stopWatch.Start();
                BO2NameSkipper.Start();
                BO2NameSkipper1.Start();
            }
            else
            {
                stopWatch.Stop();
                stopWatch.Reset();
                BO2NameSkipper.Stop();
                BO2NameSkipper1.Stop();
            }
        }
        private void BO2RB_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetMod.RBName(this);
        }
        private void toggleSwitch248_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch248.IsOn)
            {
                BO2RB.Start();
            }
            else
            {
                BO2RB.Stop();
            }
        }
        private void simpleButton680_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton679_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BrandonCardenWV");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton678_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2CFW FTW!");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton677_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Hacking...");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton676_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2$5 ^4PayPal");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton675_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Modded Lobby");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton674_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Rebug");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton673_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^4PS3ITA");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton672_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^2Habib");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton671_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit350.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton670_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit353.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton665_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textEdit355.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton664_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+gostand}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void hyperlinkLabelControl11_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This option was introduced in my original Black Ops 2 RTM tool\nand i have received a lot of great feedback becuase of it.\nTo edit these presets go to the Tool Settings!", "Custom Preset Names", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void simpleButton663_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+usereload}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton662_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+melee}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton661_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{weapnext}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton660_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+smoke}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }
        private void simpleButton659_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("[{+breathe_sprint}]");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, bytes);
        }

        private void textEdit349_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton684.PerformClick();
            }
        }
        private void checkEdit196_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit177.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Kills, PRF);
        }
        private void checkEdit198_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit179.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Downs, PRF);
        }
        private void checkEdit199_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit182.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Headshots, PRF);
        }
        private void checkEdit201_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit176.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Revives, PRF);
        }
        private void checkEdit203_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit185.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.GrenadeKills, PRF);
        }
        private void checkEdit204_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit187.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.BulletsFired, PRF);
        }
        private void checkEdit202_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit186.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Hits, PRF);
        }
        private void checkEdit200_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit180.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.PerksDrank, PRF);
        }
        private void checkEdit197_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit178.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Gibs, PRF);
        }
        private void checkEdit195_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit175.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.DoorsOpened, PRF);
        }
        private void checkEdit206_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit183.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.TraveledMiles, PRF);
        }
        private void checkEdit205_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit181.Value.ToString()));
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Deaths, PRF);
        }
        private void checkEdit207_CheckedChanged(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats.Talies(this);
        }
        private void checkEdit208_CheckedChanged(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats.Rank(this);
        }
        private void simpleButton712_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats.LegitStatsZM(this);
        }
        private void simpleButton713_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats.HighStatsZM(this);
        }
        private void simpleButton711_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats.InsaneStatsZM(this);
        }
        private void simpleButton710_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats.SendAllZM(this);
        }
        private void simpleButton709_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats.ClearAllZM(this);
        }
        private void BO2RankDisco_Tick(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetStats setStats = new Games.Call_of_Duty_Black_Ops_2.SetStats();
            setStats.ZombiesDisco(this);
        }
        private void toggleSwitch264_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch264.IsOn)
            {
                BO2RankDisco.Start();
            }
            else
            {
                BO2RankDisco.Stop();
            }
        }
        private void checkEdit209_CheckedChanged(object sender, EventArgs e)
        {
            byte[] PRF = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit184.Value.ToString()));
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.SoloLeaderboards, PRF);
        }
        private void toggleSwitch263_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch263.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.ZMSTeadyaim, new byte[] { 0x2C, 0x04, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.ZMSTeadyaim, new byte[] { 0x2C, 0x04, 0x00, 0x02 });
            }
        }
        private void toggleSwitch265_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch265.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.ZBNORecoil, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.ZBNORecoil, new byte[] { 0x48, 0x50, 0x6D, 0x65 });
            }
        }
        private void simpleButton695_Click(object sender, EventArgs e)
        {
            listBoxControl15.Items.Clear();
            listBoxControl15.Items.Add("All Players");
            for (int i = 0; i < 4; i++)
            {
                listBoxControl15.Items.Add(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(i));
            }
        }
        private void simpleButton694_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Select a client or all clients, then click a mod. \nClick the mod again to disable it.", "Client List Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void toggleSwitch266_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch266.IsOn)
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.ForceHost, new byte[] { 0x00 });
            }
            else
            {
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.ForceHost, new byte[] { 0x01 });
            }
        }
        private void checkButton142_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton142.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.GodModeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.GodModeOFF(this);
            }
        }
        private void checkButton146_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton146.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.PointsON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.PointsOFF(this);
            }
        }
        private void checkButton140_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton140.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.ThirdPersonON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.ThirdPersonOFF(this);
            }
        }
        private void checkButton138_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton138.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.BOXScreenON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.BOXScreenOFF(this);
            }
        }
        private void checkButton141_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton141.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.LastStandON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.LastStandOFF(this);
            }
        }
        private void checkButton145_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton145.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.SpeedON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.SpeedOFF(this);
            }
        }
        private void checkButton143_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton143.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.FreezeON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.FreezeOFF(this);
            }
        }
        private void checkButton139_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton139.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.LagON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.LagOFF(this);
                //th
            }
        }
        private void checkButton137_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton137.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.RemoveWeapon(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.RemoveWeaponOFF(this);
            }
        }
        private void checkButton144_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton144.Checked)
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.AmmoON(this);
            }
            else
            {
                Games.Call_of_Duty_Black_Ops_2.SetModZM.AmmoOFF(this);
            }
        }
        private void simpleButton704_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Speed, new byte[] { 0x00, 0xBE, 0x00 });
        }
        private void simpleButton702_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Speed, new byte[] { 0x01, 0xBE, 0x00 });
        }
        private void simpleButton701_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Speed, new byte[] { 0x02, 0xBE, 0x00 });
        }
        private void simpleButton703_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Jump, new byte[] { 0x42, 0x9C });
        }
        private void simpleButton700_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Jump, new byte[] { 0x44, 0x61 });
        }
        private void simpleButton699_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Jump, new byte[] { 0x45, 0x48 });
        }
        private void simpleButton698_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Gravity, new byte[] { 0x44, 0x48 });
        }
        private void simpleButton697_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.Gravity, new byte[] { 0x42, 0xAA });
        }
        private void simpleButton714_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.ZombiesStopSpawning, new byte[] { 0x00 });
        }
        private void simpleButton715_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.ZombiesStopSpawning, new byte[] { 0x01 });
        }
        private void simpleButton706_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetModZM.iPrintLn(this);
        }
        private void simpleButton705_Click(object sender, EventArgs e)
        {
            Games.Call_of_Duty_Black_Ops_2.SetModZM.iPrintLn1(this);
        }
        #endregion
        #region Empty Event Handlers
        private void xtraTabPage19_Paint(object sender, PaintEventArgs e)
        {
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
        private void toggleSwitch229_Toggled(object sender, EventArgs e)
        {
        }
        private void labelControl763_Click(object sender, EventArgs e)
        {
        }
        private void memoEdit5_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void xtraTabPage31_Paint(object sender, PaintEventArgs e)
        {
        }
        private void zoomTrackBarControl4_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void xtraTabPage82_Paint(object sender, PaintEventArgs e)
        {
        }
        private void zoomTrackBarControl3_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void xtraTabPage94_Paint(object sender, PaintEventArgs e)
        {
        }
        private void simpleButton146_Click_1(object sender, EventArgs e)
        {
        }
        private void simpleButton213_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton453_Click(object sender, EventArgs e)
        {
        }
        private void xtraTabControl3_Click(object sender, EventArgs e)
        {
        }
        private void checkEdit182_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void simpleButton146_Click_2(object sender, EventArgs e)
        {
        }
        private void simpleButton213_Click_1(object sender, EventArgs e)
        {
        }
        private void labelControl582_Click(object sender, EventArgs e)
        {
        }
        private void BETATimer_Tick(object sender, EventArgs e)
        {
        }
        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void simpleButton182_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton617_Click(object sender, EventArgs e)
        {
        }
        private void hyperlinkLabelControl10_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton618_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton619_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton606_Click(object sender, EventArgs e)
        {
        }
        private void toggleSwitch187_Toggled(object sender, EventArgs e)
        {
        }
        private void textEdit314_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void toggleSwitch199_Toggled(object sender, EventArgs e)
        {
        }
        private void simpleButton607_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton608_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton609_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton610_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton611_Click(object sender, EventArgs e)
        {
        }
        private void xtraTabControl68_Click(object sender, EventArgs e)
        {
        }
        private void Form1_MouseHover(object sender, EventArgs e)
        {
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
        }
        private void MCGM_Tick(object sender, EventArgs e)
        {
        }
        private void labelControl703_Click(object sender, EventArgs e)
        {
        }
        private void zoomTrackBarControl5_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void zoomTrackBarControl6_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void simpleButton270_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton269_Click(object sender, EventArgs e)
        {
        }
        private void zoomTrackBarControl9_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void labelControl159_Click(object sender, EventArgs e)
        {
        }
        private void toggleSwitch78_Toggled(object sender, EventArgs e)
        {
        }
        private void zoomTrackBarControl8_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void simpleButton272_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton271_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton609_Click_1(object sender, EventArgs e)
        {
        }
        private void xtraTabPage105_Paint(object sender, PaintEventArgs e)
        {
        }
        private void simpleButton149_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton204_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton541_Click(object sender, EventArgs e)
        {
        }
        private void xtraTabControl2_Click(object sender, EventArgs e)
        {
        }
        private void labelControl23_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton625_Click(object sender, EventArgs e)
        {
        }
        private void xtraTabPage13_Paint(object sender, PaintEventArgs e)
        {
        }
        private void xtraTabPage13_Click(object sender, EventArgs e)
        {
        }
        private void xtraTabPage10_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton348_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton347_Click(object sender, EventArgs e)
        {
        }
        private void Tabs_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void spinEdit37_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void tileControl1_LocationChanged(object sender, EventArgs e)
        {
        }
        private void xtraTabControl16_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
   






