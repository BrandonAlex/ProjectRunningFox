using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare
{
    class SetStats
    {
        public void ClearAll(Form1 f1)
        {
            f1.spinEdit46.Value = 0;
            f1.spinEdit47.Value = 0;
            f1.spinEdit48.Value = 0;
            f1.spinEdit49.Value = 0;
            f1.spinEdit50.Value = 0;
            f1.spinEdit51.Value = 0;
            f1.spinEdit52.Value = 0;
            f1.spinEdit53.Value = 0;
            f1.spinEdit54.Value = 0;
            f1.spinEdit55.Value = 0;
            f1.spinEdit56.Value = 0;
            f1.spinEdit57.Value = 0;
            f1.checkEdit89.Checked = false;
            f1.checkEdit90.Checked = false;
            f1.checkEdit91.Checked = false;
            f1.checkEdit92.Checked = false;
            f1.checkEdit93.Checked = false;
            f1.checkEdit94.Checked = false;
            f1.checkEdit95.Checked = false;
            f1.checkEdit97.Checked = false;
        }
        public void SendAll(Form1 f1)
        {
            f1.checkEdit89.Checked = true;
            f1.checkEdit90.Checked = true;
            f1.checkEdit91.Checked = true;
            f1.checkEdit92.Checked = true;
            f1.checkEdit93.Checked = true;
            f1.checkEdit94.Checked = true;
            f1.checkEdit95.Checked = true;
            f1.checkEdit97.Checked = true;
        }   
         public void InsaneStats(Form1 f1)
        {
            f1.spinEdit46.Value = 214567899;
            f1.spinEdit47.Value = 0;
            f1.spinEdit48.Value = 214567899;
            f1.spinEdit49.Value = 214567899;
            f1.spinEdit50.Value = 214567899;
            f1.spinEdit51.Value = 214567899;
            f1.spinEdit52.Value = 214567899;
            f1.spinEdit53.Value = 214567899;
            f1.spinEdit54.Value = 214567899;
            f1.spinEdit55.Value = 214567899;
            f1.spinEdit56.Value = 214567899;
            f1.spinEdit57.Value = 10;
            f1.simpleButton274.PerformClick();
        }
        public void HighStats(Form1 f1)
        {
            f1.spinEdit46.Value = 565000;
            f1.spinEdit47.Value = 563589;
            f1.spinEdit48.Value = 2547;
            f1.spinEdit49.Value = 2365;
            f1.spinEdit50.Value = 117569785;
            f1.spinEdit51.Value = 2;
            f1.spinEdit52.Value = 4912;
            f1.spinEdit53.Value = 38;
            f1.spinEdit54.Value = 78;
            f1.spinEdit55.Value = 11;
            f1.spinEdit56.Value = 43;
            f1.spinEdit57.Value = 9;
            f1.simpleButton274.PerformClick();
        }
        public void LegitStats(Form1 f1)
        {
            f1.spinEdit46.Value = 24567;
            f1.spinEdit47.Value = 17546;
            f1.spinEdit48.Value = 529;
            f1.spinEdit49.Value = 478;
            f1.spinEdit50.Value = 569785;
            f1.spinEdit51.Value = 2;
            f1.spinEdit52.Value = 1007;
            f1.spinEdit53.Value = 22;
            f1.spinEdit54.Value = 16;
            f1.spinEdit55.Value = 5;
            f1.spinEdit56.Value = 29;
            f1.spinEdit57.Value = 8;
            f1.simpleButton274.PerformClick();
        }
    }
}
