using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2
{
    class SetStats
    {
        public int Countername { get; set; }
        public int Countername1 { get; set; }
        public static void Rank(Form1 f1)
        {
            if (f1.comboBoxEdit13.SelectedIndex == 0)
            {
                byte[] Emblem1 = new byte[] { 0x0F };
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem1, Emblem1);
                byte[] Emblem2 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem2, Emblem2);
            }
            if (f1.comboBoxEdit13.SelectedIndex == 1)
            {
                byte[] Emblem1 = new byte[] { 0x0F };
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem1, Emblem1);
                byte[] Emblem2 = new byte[] { 0x02, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem2, Emblem2);
            }
            if (f1.comboBoxEdit13.SelectedIndex == 2)
            {
                byte[] Emblem1 = new byte[] { 0x0F };
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem1, Emblem1);
                byte[] Emblem2 = new byte[] { 0x0A, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem2, Emblem2);
            }
            if (f1.comboBoxEdit13.SelectedIndex == 3)
            {
                byte[] Emblem1 = new byte[] { 0x0F };
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem1, Emblem1);
                byte[] Emblem2 = new byte[] { 0x15, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem2, Emblem2);
            }
            if (f1.comboBoxEdit13.SelectedIndex == 4)
            {
                byte[] Emblem1 = new byte[] { 0x0F };
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem1, Emblem1);
                byte[] Emblem2 = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem2, Emblem2);
            }
        }
        public static void Talies(Form1 f1)
        {
              if (f1.comboBoxEdit9.SelectedIndex == 0)
            {
                byte[] Rank = new byte[] { 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.TallyMask, Rank);
            }
              if (f1.comboBoxEdit9.SelectedIndex == 1)
            {
                byte[] Rank = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.TallyMask, Rank);
            }
              if (f1.comboBoxEdit9.SelectedIndex == 2)
            {
                byte[] Rank = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.TallyMask, Rank);
            }
              if (f1.comboBoxEdit9.SelectedIndex == 3)
            {
                byte[] Rank = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00 };
                Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.TallyMask, Rank);
            }
              if (f1.comboBoxEdit9.SelectedIndex == 4)
            {
                byte[] Rank = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.TallyMask, Rank);
            }
        }
        public void LevelLoop(Form1 f1)
        {
            f1.BO2Loop1.Start();
            {
                Countername1++;
                switch (Countername1)
                {
                    case 1:
                        byte[] GRADE1 = new byte[] { 0x00, 0x04, 0x00 };
                        Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.LevelL, GRADE1);
                        break;
                    case 2:
                        byte[] GRADE2 = new byte[] { 0x00, 0x00, 0x0C };
                        Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.LevelL, GRADE2);
                        break;
                    case 3:
                        byte[] GRADE3 = new byte[] { 0x00, 0xF9, 0x02 };
                        Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.LevelL, GRADE3);
                        break;
                    case 4:
                        byte[] GRADE4 = new byte[] { 0x00, 0x90, 0x05 };
                        Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.LevelL, GRADE4);
                        break;
                    case 5:
                        byte[] GRADE5 = new byte[] { 0x00, 0xA0, 0x10 };
                        Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.LevelL, GRADE5);
                        break;
                    case 6:
                        byte[] GRADE6 = new byte[] { 0x00, 0x76, 0x00 };
                        Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.LevelL, GRADE6);
                        break;
                    case 7:
                        byte[] GRADE7 = new byte[] { 0x00, 0x4C, 0x00 };
                        Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.LevelL, GRADE7);
                        break;
                    case 8:
                        byte[] GRADE8 = new byte[] { 0x00, 0x9A, 0x01 };
                        Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.LevelL, GRADE8);
                        break;
                    case 9:
                        byte[] GRADE9 = new byte[] { 0x00, 0xD0, 0x0A };
                        Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.LevelL, GRADE9);
                        break;
                    case 10:
                        byte[] GRADE10 = new byte[] { 0x00, 0x76, 0x00 };
                        Form1.PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Stats.LevelL, GRADE10);
                        break;
                }
                if (Countername == 10) Countername = 0;
                {
                    f1.BO2Loop1.Start();
                }
            }
        }
        public void ClearAll(Form1 f1)
        {
            f1.checkEdit155.Checked = false;
            f1.checkEdit187.Checked = false;
            f1.checkEdit188.Checked = false;
            f1.checkEdit190.Checked = false;
            f1.checkEdit192.Checked = false;
            f1.checkEdit193.Checked = false;
            f1.checkEdit191.Checked = false;
            f1.checkEdit189.Checked = false;
            f1.checkEdit182.Checked = false;
            f1.checkEdit194.Checked = false;
            f1.spinEdit162.Value = 0;
            f1.spinEdit164.Value = 0;
            f1.spinEdit167.Value = 0;
            f1.spinEdit161.Value = 0;
            f1.spinEdit170.Value = 0;
            f1.spinEdit172.Value = 0;
            f1.spinEdit171.Value = 0;
            f1.spinEdit169.Value = 0;
            f1.spinEdit168.Value = 0;
            f1.spinEdit166.Value = 0;
            f1.spinEdit165.Value = 0;
            f1.spinEdit163.Value = 0;
            f1.spinEdit173.Value = 0;
            f1.simpleButton639.PerformClick();
        }
        public void SendAll(Form1 f1)
        {
            f1.checkEdit155.Checked = true;
            f1.checkEdit187.Checked = true;
            f1.checkEdit188.Checked = true;
            f1.checkEdit190.Checked = true;
            f1.checkEdit192.Checked = true;
            f1.checkEdit193.Checked = true;
            f1.checkEdit191.Checked = true;
            f1.checkEdit189.Checked = true;
            f1.checkEdit182.Checked = true;
            f1.checkEdit194.Checked = true;
        }
        public void InsaneStats(Form1 f1)
        {
            f1.spinEdit162.Value = 214567899;
            f1.spinEdit164.Value = 214567899;
            f1.spinEdit167.Value = 214567899;
            f1.spinEdit161.Value = 214567899;
            f1.spinEdit170.Value = 214567899;
            f1.spinEdit172.Value = 214567899;
            f1.spinEdit171.Value = 214567899;
            f1.spinEdit169.Value = 99;
            f1.spinEdit168.Value = 59;
            f1.spinEdit166.Value = 59;
            f1.spinEdit165.Value = 59;
            f1.spinEdit163.Value = 15;
            f1.spinEdit173.Value = 55;
            f1.simpleButton639.PerformClick();
        }
        public void HighStats(Form1 f1)
        {
            f1.spinEdit162.Value = 565000;
            f1.spinEdit164.Value = 563589;
            f1.spinEdit167.Value = 48645;
            f1.spinEdit161.Value = 1111546;
            f1.spinEdit170.Value = 25489;
            f1.spinEdit172.Value = 22347;
            f1.spinEdit171.Value = 999;
            f1.spinEdit169.Value = 53;
            f1.spinEdit168.Value = 19;
            f1.spinEdit166.Value = 7;
            f1.spinEdit165.Value = 3;
            f1.spinEdit163.Value = 11;
            f1.spinEdit173.Value = 55;
            f1.simpleButton639.PerformClick();
        }
        public void LegitStats(Form1 f1)
        {
            f1.spinEdit162.Value = 24567;
            f1.spinEdit164.Value = 17546;
            f1.spinEdit167.Value = 8456;
            f1.spinEdit161.Value = 11546;
            f1.spinEdit170.Value = 521;
            f1.spinEdit172.Value = 496;
            f1.spinEdit171.Value = 500;
            f1.spinEdit169.Value = 21;
            f1.spinEdit168.Value = 16;
            f1.spinEdit166.Value = 5;
            f1.spinEdit165.Value = 21;
            f1.spinEdit163.Value = 10;
            f1.spinEdit173.Value = 21;
            f1.simpleButton639.PerformClick();
        }
        public static void SendAllZM(Form1 f1)
        {
            f1.checkEdit196.Checked = true;
            f1.checkEdit198.Checked = true;
            f1.checkEdit199.Checked = true;
            f1.checkEdit201.Checked = true;
            f1.checkEdit203.Checked = true;
            f1.checkEdit204.Checked = true;
            f1.checkEdit202.Checked = true;
            f1.checkEdit200.Checked = true;
            f1.checkEdit197.Checked = true;
            f1.checkEdit195.Checked = true;
            f1.checkEdit206.Checked = true;
            f1.checkEdit205.Checked = true;
            f1.checkEdit207.Checked = true;
            f1.checkEdit208.Checked = true;
        }
        public static void ClearAllZM(Form1 f1)
        {
            f1.checkEdit196.Checked = false;
            f1.checkEdit198.Checked = false;
            f1.checkEdit199.Checked = false;
            f1.checkEdit201.Checked = false;
            f1.checkEdit203.Checked = false;
            f1.checkEdit204.Checked = false;
            f1.checkEdit202.Checked = false;
            f1.checkEdit200.Checked = false;
            f1.checkEdit197.Checked = false;
            f1.checkEdit195.Checked = false;
            f1.checkEdit206.Checked = false;
            f1.checkEdit205.Checked = false;
            f1.checkEdit207.Checked = false;
            f1.checkEdit208.Checked = false;
            f1.spinEdit177.Value = 0;
            f1.spinEdit179.Value = 0;
            f1.spinEdit182.Value = 0;
            f1.spinEdit176.Value = 0;
            f1.spinEdit185.Value = 0;
            f1.spinEdit187.Value = 0;
            f1.spinEdit186.Value = 0;
            f1.spinEdit180.Value = 0;
            f1.spinEdit178.Value = 0;
            f1.spinEdit185.Value = 0;
            f1.spinEdit183.Value = 0;
            f1.spinEdit181.Value = 0;
            f1.comboBoxEdit9.SelectedIndex = 0;
            f1.comboBoxEdit13.SelectedIndex = 0;
        }
        public void ZombiesDisco(Form1 f1)
        {
            f1.BO2RankDisco.Start();
            f1.BO2RankDisco.Interval = 120;
            {
                Countername++;
                switch (Countername)
                {
                    case 1:
                        byte[] Emblem1 = new byte[] { 0x0F };
                        PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem1, Emblem1);
                        byte[] Emblem2 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                        PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem2, Emblem2);

                        break;

                    case 2:
                        byte[] Emblem3 = new byte[] { 0x0F };
                        PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem1, Emblem3);
                        byte[] Emblem4 = new byte[] { 0x02, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                        PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem2, Emblem4);

                        break;

                    case 3:
                        byte[] Emblem5 = new byte[] { 0x0F };
                        PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem1, Emblem5);
                        byte[] Emblem6 = new byte[] { 0x0A, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                        PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem2, Emblem6);

                        break;

                    case 4:
                        byte[] Emblem7 = new byte[] { 0x0F };
                        PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem1, Emblem7);
                        byte[] Emblem8 = new byte[] { 0x15, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                        PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem2, Emblem8);

                        break;

                    case 5:
                        byte[] Emblem9 = new byte[] { 0x0F };
                        PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem1, Emblem9);
                        byte[] Emblem10 = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                        PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Zombiemods.Emblem2, Emblem10);

                        break;

                }
                if (Countername == 5) Countername = 0;
                {
                    f1.BO2RankDisco.Start();
                }
            }
        }
        public static void LegitStatsZM(Form1 f1)
        {
            f1.spinEdit177.Value = 32423;
            f1.spinEdit179.Value = 2954;
            f1.spinEdit182.Value = 16540;
            f1.spinEdit176.Value = 721;
            f1.spinEdit185.Value = 16;
            f1.spinEdit187.Value = 112546;
            f1.spinEdit186.Value = 116954;
            f1.spinEdit180.Value = 829;
            f1.spinEdit178.Value = 643;
            f1.spinEdit185.Value = 911;
            f1.spinEdit183.Value = 221;
            f1.spinEdit181.Value = 592;
            f1.comboBoxEdit9.SelectedIndex = 3;
            f1.comboBoxEdit13.SelectedIndex = 3;
            f1.simpleButton710.PerformClick();
        }
        public static void HighStatsZM(Form1 f1)
        {
            f1.spinEdit177.Value = 600946;
            f1.spinEdit179.Value = 110549;
            f1.spinEdit182.Value = 166540;
            f1.spinEdit176.Value = 7271;
            f1.spinEdit185.Value = 1146;
            f1.spinEdit187.Value = 112111546;
            f1.spinEdit186.Value = 116111954;
            f1.spinEdit180.Value = 8279;
            f1.spinEdit178.Value = 62243;
            f1.spinEdit185.Value = 91551;
            f1.spinEdit183.Value = 22871;
            f1.spinEdit181.Value = 5942;
            f1.comboBoxEdit9.SelectedIndex = 5;
            f1.comboBoxEdit13.SelectedIndex = 4;
            f1.simpleButton710.PerformClick();
        }
        public static void InsaneStatsZM(Form1 f1)
        {
            f1.spinEdit177.Value = 214567899;
            f1.spinEdit179.Value = 214567899;
            f1.spinEdit182.Value = 214567899;
            f1.spinEdit176.Value = 214567899;
            f1.spinEdit185.Value = 214567899;
            f1.spinEdit187.Value = 214567899;
            f1.spinEdit186.Value = 214567899;
            f1.spinEdit180.Value = 214567899;
            f1.spinEdit178.Value = 214567899;
            f1.spinEdit185.Value = 214567899;
            f1.spinEdit183.Value = 214567899;
            f1.spinEdit181.Value = 214567899;
            f1.comboBoxEdit9.SelectedIndex = 5;
            f1.comboBoxEdit13.SelectedIndex = 5;
            f1.simpleButton710.PerformClick();
        }
    }
}
