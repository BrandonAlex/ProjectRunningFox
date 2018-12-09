using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_World_at_War
{
    class SetStats
    {
        public void ClearAll(Form1 f1)
        {
            f1.spinEdit2.Value = 0;
            f1.spinEdit3.Value = 0;
            f1.spinEdit4.Value = 0;
            f1.spinEdit5.Value = 0;
            f1.spinEdit6.Value = 0;
            f1.spinEdit7.Value = 0;
            f1.spinEdit8.Value = 0;
            f1.spinEdit9.Value = 0;
            f1.spinEdit10.Value = 0;
            f1.checkEdit4.Checked = false;
            f1.checkEdit5.Checked = false;
            f1.checkEdit6.Checked = false;
            f1.checkEdit7.Checked = false;
            f1.checkEdit8.Checked = false;
            f1.checkEdit9.Checked = false;
            f1.checkEdit10.Checked = false;
            f1.checkEdit11.Checked = false;
            f1.checkEdit12.Checked = false;
        }
        public void SendAll(Form1 f1)
        {
            f1.checkEdit4.Checked = true;
            f1.checkEdit5.Checked = true;
            f1.checkEdit6.Checked = true;
            f1.checkEdit7.Checked = true;
            f1.checkEdit8.Checked = true;
            f1.checkEdit9.Checked = true;
            f1.checkEdit10.Checked = true;
            f1.checkEdit11.Checked = true;
            f1.checkEdit12.Checked = true;
        }
        public void InsaneStats(Form1 f1)
        {
            f1.spinEdit2.Value = 214567899;
            f1.spinEdit3.Value = 0;
            f1.spinEdit4.Value = 214567899;
            f1.spinEdit5.Value = 214567899;
            f1.spinEdit6.Value = 214567899;
            f1.spinEdit7.Value = 214567899;
            f1.spinEdit8.Value = 214567899;
            f1.spinEdit9.Value = 214567899;
            f1.spinEdit10.Value = 10;
            f1.simpleButton30.PerformClick();
        }
        public void HighStats(Form1 f1)
        {
            f1.spinEdit2.Value = 500675; 
            f1.spinEdit3.Value = 498234;  
            f1.spinEdit4.Value = 321657; 
            f1.spinEdit5.Value = 114687331; 
            f1.spinEdit6.Value = 47; 
            f1.spinEdit7.Value = 19; 
            f1.spinEdit8.Value = 22; 
            f1.spinEdit9.Value = 493; 
            f1.spinEdit10.Value = 9; 
            f1.simpleButton30.PerformClick();
        }
        public void LegitStats(Form1 f1)
        {
            f1.spinEdit2.Value = 35561; 
            f1.spinEdit3.Value = 29678; 
            f1.spinEdit4.Value = 21456; 
            f1.spinEdit5.Value = 766547; 
            f1.spinEdit6.Value = 22;
            f1.spinEdit7.Value = 13; 
            f1.spinEdit8.Value = 7; 
            f1.spinEdit9.Value = 58; 
            f1.spinEdit10.Value = 8; 
            f1.simpleButton30.PerformClick();
        }
    }
}
