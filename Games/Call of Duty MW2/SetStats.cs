using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_MW2
{
    class SetStats
    {
        public void ClearAll(Form1 f1)
        {
            f1.checkEdit17.Checked = false;
            f1.checkEdit18.Checked = false;
            f1.checkEdit19.Checked = false;
            f1.checkEdit20.Checked = false;
            f1.checkEdit21.Checked = false;
            f1.checkEdit22.Checked = false;
            f1.checkEdit23.Checked = false;
            f1.checkEdit24.Checked = false;
            f1.checkEdit25.Checked = false;
            f1.checkEdit26.Checked = false;
            f1.checkEdit27.Checked = false;
            f1.checkEdit28.Checked = false;
            f1.spinEdit16.Value = 0; //kills
            f1.spinEdit17.Value = 0;  //deaths
            f1.spinEdit18.Value = 0; //headshots
            f1.spinEdit19.Value = 0; //score
            f1.spinEdit20.Value = 0; //wins
            f1.spinEdit21.Value = 0; //losses
            f1.spinEdit22.Value = 0; //ties
            f1.spinEdit23.Value = 0; //assists
            f1.spinEdit24.Value = 0; //win streak
            f1.spinEdit25.Value = 0; //kill streak
            f1.spinEdit26.Value = 0; //xp
            f1.spinEdit27.Value = 0; //prestige
        }
        public void SendAll(Form1 f1)
        {
            f1.checkEdit17.Checked = true;
            f1.checkEdit18.Checked = true;
            f1.checkEdit19.Checked = true;
            f1.checkEdit20.Checked = true;
            f1.checkEdit21.Checked = true;
            f1.checkEdit22.Checked = true;
            f1.checkEdit23.Checked = true;
            f1.checkEdit24.Checked = true;
            f1.checkEdit25.Checked = true;
            f1.checkEdit26.Checked = true;
            f1.checkEdit27.Checked = true;
            f1.checkEdit28.Checked = true;
        }   
        public void InsaneStats(Form1 f1)
        {
            f1.spinEdit16.Value = 214567899; //kills
            f1.spinEdit17.Value = 0;  //deaths
            f1.spinEdit18.Value = 214567899; //headshots
            f1.spinEdit19.Value = 214567899; //score
            f1.spinEdit20.Value = 214567899; //wins
            f1.spinEdit21.Value = 214567899; //losses
            f1.spinEdit22.Value = 214567899; //ties
            f1.spinEdit23.Value = 214567899; //assists
            f1.spinEdit24.Value = 214567899; //win streak
            f1.spinEdit25.Value = 214567899; //kill streak
            f1.spinEdit26.Value = 214567899; //xp
            f1.spinEdit27.Value = 10; //prestige
            f1.simpleButton84.PerformClick();
        }
        public void HighStats(Form1 f1)
        {
            f1.spinEdit16.Value = 128984; //kills
            f1.spinEdit17.Value = 110657;  //deaths
            f1.spinEdit18.Value = 76451; //headshots
            f1.spinEdit19.Value = 76654756; //score
            f1.spinEdit20.Value = 2436; //wins
            f1.spinEdit21.Value = 1948; //losses
            f1.spinEdit22.Value = 498; //ties
            f1.spinEdit23.Value = 42654; //assists
            f1.spinEdit24.Value = 109; //win streak
            f1.spinEdit25.Value = 234; //kill streak
            f1.spinEdit26.Value = 113465777; //xp
            f1.spinEdit27.Value = 9; //prestige
            f1.simpleButton84.PerformClick();
        }
        public void LegitStats(Form1 f1)
        {
            f1.spinEdit16.Value = 35561; //kills
            f1.spinEdit17.Value = 29678;  //deaths
            f1.spinEdit18.Value = 21456; //headshots
            f1.spinEdit19.Value = 766547; //score
            f1.spinEdit20.Value = 589; //wins
            f1.spinEdit21.Value = 346; //losses
            f1.spinEdit22.Value = 18; //ties
            f1.spinEdit23.Value = 17541; //assists
            f1.spinEdit24.Value = 42; //win streak
            f1.spinEdit25.Value = 101; //kill streak
            f1.spinEdit26.Value = 1134657; //xp
            f1.spinEdit27.Value = 8; //prestige
            f1.simpleButton84.PerformClick();
        }
    }
}
