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
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectRunningFox
{
    class Conditionals
    {
        public void PrintTextModsOFF(Form1 f1)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.Notify = false;
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.Notify = false;
            ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.Notify = false;
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.Notify = false;
            ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Notify = false;
            ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.Notify = false;
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.Notify = false;
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.SetMod.Notify = false;
            //bo3 zombies
        }
        public void PrintTextModsON(Form1 f1)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.Notify = true;
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.Notify = true;
            ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.Notify = true;
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.Notify = true;
            ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.Notify = true;
            ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.Notify = true;
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.Notify = true;
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.SetMod.Notify = true;
            //bo3 zombies
        }
        public void CreateThreeTiles(Form1 f1)
        {
                f1.simpleButton621.Visible = false;
                f1.simpleButton622.Visible = true;
                f1.textEdit314.Visible = false;
                f1.textEdit315.Visible = false;
                f1.textEdit316.Visible = true;
                f1.textEdit317.Visible = true;
                TileItem newItem = new TileItem();
                newItem.ItemSize = TileItemSize.Medium;
                newItem.Elements.Add(new TileItemElement() { Text = f1.textEdit305.Text });
                newItem.Checked = true;
                newItem.AppearanceItem.Normal.Font = Properties.Settings.Default.TileFont;
                newItem.AppearanceItem.Normal.ForeColor = f1.colorEdit17.Color;
                newItem.AppearanceItem.Normal.BackColor = f1.colorEdit19.Color;
                newItem.AppearanceItem.Normal.BorderColor = f1.colorEdit21.Color;
                newItem.Name = "UsersTile";
                f1.tileGroup8.Items.Add(newItem);
                newItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(f1.newItem_ItemClick);

                TileItem newItem1 = new TileItem();
                newItem1.ItemSize = TileItemSize.Medium;
                newItem1.Elements.Add(new TileItemElement() { Text = Properties.Settings.Default.TileText1 });
                newItem1.Checked = true;
                newItem1.AppearanceItem.Normal.Font = Properties.Settings.Default.TileFont;
                newItem1.AppearanceItem.Normal.ForeColor = f1.colorEdit17.Color;
                newItem1.AppearanceItem.Normal.BackColor = f1.colorEdit19.Color;
                newItem1.AppearanceItem.Normal.BorderColor = f1.colorEdit21.Color;
                newItem1.Name = "UsersTile1";
                f1.tileGroup8.Items.Add(newItem1);
                newItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(f1.newItem1_ItemClick);

                TileItem newItem2 = new TileItem();
                newItem2.ItemSize = TileItemSize.Medium;
                newItem2.Elements.Add(new TileItemElement() { Text = Properties.Settings.Default.TileText2 });
                newItem2.Checked = true;
                newItem2.AppearanceItem.Normal.Font = Properties.Settings.Default.TileFont;
                newItem2.AppearanceItem.Normal.ForeColor = f1.colorEdit17.Color;
                newItem2.AppearanceItem.Normal.BackColor = f1.colorEdit19.Color;
                newItem2.AppearanceItem.Normal.BorderColor = f1.colorEdit21.Color;
                newItem2.Name = "UsersTile1";
                f1.tileGroup8.Items.Add(newItem2);
                newItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(f1.newItem2_ItemClick);
            }
        public void CreateTwoTiles(Form1 f1)
        {
            f1.textEdit305.Visible = false;
            f1.textEdit306.Visible = false;
            f1.Visible = true;
            f1.Visible = true;
            f1.Location = new Point(38, 434);
            f1.Visible = false;
            f1.Visible = true;
            TileItem newItem = new TileItem();
            newItem.ItemSize = TileItemSize.Medium;
            newItem.Elements.Add(new TileItemElement() { Text = f1.textEdit305.Text });
            newItem.Checked = true;
            newItem.AppearanceItem.Normal.Font = Properties.Settings.Default.TileFont;
            newItem.AppearanceItem.Normal.ForeColor = f1.colorEdit17.Color;
            newItem.AppearanceItem.Normal.BackColor = f1.colorEdit19.Color;
            newItem.AppearanceItem.Normal.BorderColor = f1.colorEdit21.Color;
            newItem.Name = "UsersTile";
            f1.tileGroup8.Items.Add(newItem);
            newItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(f1.newItem_ItemClick);

            TileItem newItem1 = new TileItem();
            newItem1.ItemSize = TileItemSize.Medium;
            newItem1.Elements.Add(new TileItemElement() { Text = Properties.Settings.Default.TileText1 });
            newItem1.Checked = true;
            newItem1.AppearanceItem.Normal.Font = Properties.Settings.Default.TileFont;
            newItem1.AppearanceItem.Normal.ForeColor = f1.colorEdit17.Color;
            newItem1.AppearanceItem.Normal.BackColor = f1.colorEdit19.Color;
            newItem1.AppearanceItem.Normal.BorderColor = f1.colorEdit21.Color;
            newItem1.Name = "UsersTile1";
            f1.tileGroup8.Items.Add(newItem1);
            newItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(f1.newItem1_ItemClick);
        }
        public void CreateOneTile(Form1 f1)
        {
            TileItem newItem = new TileItem();
            newItem.ItemSize = TileItemSize.Medium;
            newItem.Elements.Add(new TileItemElement() { Text = f1.textEdit305.Text });
            newItem.Checked = true;
            newItem.AppearanceItem.Normal.Font = Properties.Settings.Default.TileFont;
            newItem.AppearanceItem.Normal.ForeColor = f1.colorEdit17.Color;
            newItem.AppearanceItem.Normal.BackColor = f1.colorEdit19.Color;
            newItem.AppearanceItem.Normal.BorderColor = f1.colorEdit21.Color;
            newItem.Name = "UsersTile";
            f1.tileGroup8.Items.Add(newItem);
            newItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(f1.newItem_ItemClick);
        }
        public void ResetHeaders(Form1 f1)
        {
            f1.labelControl1.Text = "Call of Duty Series";
            f1.labelControl2.Text = "Battlefield Series";
            f1.labelControl3.Text = "Popular Games";
            f1.labelControl4.Text = "Classic Games";
            f1.labelControl5.Text = "Other Games";
            f1.labelControl6.Text = "Settings and Options";
            f1.labelControl7.Text = "Useful Links";
            f1.labelControl8.Text = "Other Tools";
            f1.textEdit5.Text = "Call of Duty Series";
            f1.textEdit6.Text = "Battlefield && Assassins Creed";
            f1.textEdit8.Text = "Popular Games";
            f1.textEdit7.Text = "Classic Games";
            f1.textEdit10.Text = "Other Games";
            f1.textEdit9.Text = "Settings and Options";
            f1.textEdit12.Text = "Useful Links";
            f1.textEdit11.Text = "Other Tools";
        }
    }
}
