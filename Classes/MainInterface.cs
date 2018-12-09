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

namespace ProjectRunningFox
{
    class MainInterface
    {
        public void FirstLoadLabelFont(Form1 f1)
        {
            f1.labelControl1.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl2.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl3.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl4.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl5.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl6.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl7.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl8.Font = new Font("Arial", 14, FontStyle.Bold);
        }
        public void RevertChanges(Form1 f1)
        {
            f1.comboBoxEdit1.Text = "Metropolis Dark";
            Properties.Settings.Default["ApplicationSkinName"] = f1.comboBoxEdit1.Text;
            f1.labelControl1.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl2.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl3.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl4.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl5.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl6.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl7.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.labelControl8.Font = new Font("Arial", 14, FontStyle.Bold);
            Properties.Settings.Default["label1Font"] = f1.labelControl1.Font;
            f1.labelControl1.ForeColor = Color.White;
            f1.labelControl2.ForeColor = Color.White;
            f1.labelControl3.ForeColor = Color.White;
            f1.labelControl4.ForeColor = Color.White;
            f1.labelControl5.ForeColor = Color.White;
            f1.labelControl6.ForeColor = Color.White;
            f1.labelControl7.ForeColor = Color.White;
            f1.labelControl8.ForeColor = Color.White;
            Properties.Settings.Default["label1Color"] = f1.labelControl1.ForeColor;
            f1.labelControl1.BackColor = Color.Transparent;
            f1.labelControl2.BackColor = Color.Transparent;
            f1.labelControl3.BackColor = Color.Transparent;
            f1.labelControl4.BackColor = Color.Transparent;
            f1.labelControl5.BackColor = Color.Transparent;
            f1.labelControl6.BackColor = Color.Transparent;
            f1.labelControl7.BackColor = Color.Transparent;
            f1.labelControl8.BackColor = Color.Transparent;
            Properties.Settings.Default["label1BColor"] = f1.labelControl1.BackColor;
            f1.simpleButton620.PerformClick();
            f1.spinEdit1.Value = 100;
            f1.toggleSwitch1.IsOn = true;
            f1.toggleSwitch2.IsOn = true;
            f1.toggleSwitch7.IsOn = true;
            f1.toggleSwitch8.IsOn = false;
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
            f1.checkEdit30.Checked = false;
            f1.fontEdit2.Font = new Font("Tahoma", 14, FontStyle.Bold);
            f1.colorEdit14.Color = Color.White;
            f1.colorEdit4.Color = Color.Maroon;
            f1.colorEdit1.Color = Color.Maroon;
            f1.colorEdit5.Color = Color.Maroon;
            f1.colorEdit6.Color = Color.Maroon;
            f1.colorEdit8.Color = Color.Maroon;
            f1.colorEdit7.Color = Color.Maroon;
            f1.colorEdit9.Color = Color.Maroon;
            f1.colorEdit11.Color = Color.Maroon;
            f1.colorEdit10.Color = Color.Maroon;
            f1.colorEdit13.Color = Color.White;
            f1.colorEdit16.Color = Color.White;
            f1.colorEdit15.Color = Color.White;
            f1.colorEdit24.Color = Color.White;
            f1.colorEdit18.Color = Color.White;
            f1.colorEdit20.Color = Color.White;
            f1.colorEdit22.Color = Color.White;
            f1.colorEdit12.Color = Color.White;
            f1.fontEdit3.Font = new Font("Tahoma", 8, FontStyle.Bold);
            f1.fontEdit4.Font = new Font("Tahoma", 8, FontStyle.Bold);
            f1.fontEdit8.Font = new Font("Tahoma", 8, FontStyle.Bold);
            f1.fontEdit10.Font = new Font("Tahoma", 8, FontStyle.Bold);
            f1.fontEdit9.Font = new Font("Tahoma", 8, FontStyle.Bold);
            f1.fontEdit7.Font = new Font("Tahoma", 8, FontStyle.Bold);
            f1.fontEdit6.Font = new Font("Tahoma", 8, FontStyle.Bold);
            f1.fontEdit5.Font = new Font("Tahoma", 8, FontStyle.Bold);
            f1.toggleSwitch37.IsOn = false;
            f1.spinEdit34.Value = 100;
            f1.spinEdit35.Value = 100;
            f1.spinEdit36.Value = 100;
            f1.spinEdit37.Value = 100;
            f1.textEdit277.Text = "S";
            f1.textEdit313.Text = "L";
            f1.toggleSwitch3.IsOn = true;
        }
        public void MainBackColor(Form1 f1)
        {
            f1.labelControl1.BackColor = f1.colorEdit3.Color;
            f1.labelControl2.BackColor = f1.colorEdit3.Color;
            f1.labelControl3.BackColor = f1.colorEdit3.Color;
            f1.labelControl4.BackColor = f1.colorEdit3.Color;
            f1.labelControl5.BackColor = f1.colorEdit3.Color;
            f1.labelControl6.BackColor = f1.colorEdit3.Color;
            f1.labelControl7.BackColor = f1.colorEdit3.Color;
            f1.labelControl8.BackColor = f1.colorEdit3.Color;
        }
        public void MainForeColor(Form1 f1)
        {
            f1.labelControl1.ForeColor = f1.colorEdit2.Color;
            f1.labelControl2.ForeColor = f1.colorEdit2.Color;
            f1.labelControl3.ForeColor = f1.colorEdit2.Color;
            f1.labelControl4.ForeColor = f1.colorEdit2.Color;
            f1.labelControl5.ForeColor = f1.colorEdit2.Color;
            f1.labelControl6.ForeColor = f1.colorEdit2.Color;
            f1.labelControl7.ForeColor = f1.colorEdit2.Color;
            f1.labelControl8.ForeColor = f1.colorEdit2.Color;
        }
        public void MainFont(Form1 f1)
        {
            f1.labelControl1.Font = new Font(f1.fontEdit1.Text, 14, FontStyle.Bold);
            f1.labelControl2.Font = new Font(f1.fontEdit1.Text, 14, FontStyle.Bold);
            f1.labelControl3.Font = new Font(f1.fontEdit1.Text, 14, FontStyle.Bold);
            f1.labelControl4.Font = new Font(f1.fontEdit1.Text, 14, FontStyle.Bold);
            f1.labelControl5.Font = new Font(f1.fontEdit1.Text, 14, FontStyle.Bold);
            f1.labelControl6.Font = new Font(f1.fontEdit1.Text, 14, FontStyle.Bold);
            f1.labelControl7.Font = new Font(f1.fontEdit1.Text, 14, FontStyle.Bold);
            f1.labelControl8.Font = new Font(f1.fontEdit1.Text, 14, FontStyle.Bold);
        }
        public void BlackTheme(Form1 f1)
        {
            f1.labelControl1.ForeColor = Color.White;
            f1.labelControl2.ForeColor = Color.White;
            f1.labelControl3.ForeColor = Color.White;
            f1.labelControl4.ForeColor = Color.White;
            f1.labelControl5.ForeColor = Color.White;
            f1.labelControl6.ForeColor = Color.White;
            f1.labelControl7.ForeColor = Color.White;
            f1.labelControl8.ForeColor = Color.White;
            f1.colorEdit13.Color = Color.White;
            f1.colorEdit16.Color = Color.White;
            f1.colorEdit15.Color = Color.White;
            f1.colorEdit24.Color = Color.White;
            f1.colorEdit18.Color = Color.White;
            f1.colorEdit20.Color = Color.White;
            f1.colorEdit22.Color = Color.White;
            f1.colorEdit12.Color = Color.White;
        }
        public void WhiteTheme(Form1 f1)
        {
            f1.labelControl1.ForeColor = Color.Black;
            f1.labelControl2.ForeColor = Color.Black;
            f1.labelControl3.ForeColor = Color.Black;
            f1.labelControl4.ForeColor = Color.Black;
            f1.labelControl5.ForeColor = Color.Black;
            f1.labelControl6.ForeColor = Color.Black;
            f1.labelControl7.ForeColor = Color.Black;
            f1.labelControl8.ForeColor = Color.Black;
            f1.colorEdit13.Color = Color.Black;
            f1.colorEdit16.Color = Color.Black;
            f1.colorEdit15.Color = Color.Black;
            f1.colorEdit24.Color = Color.Black;
            f1.colorEdit18.Color = Color.Black;
            f1.colorEdit20.Color = Color.Black;
            f1.colorEdit22.Color = Color.Black;
            f1.colorEdit12.Color = Color.Black;
        }
    }
}
