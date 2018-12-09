using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2
{
    class Levels
    {
        public void SetLevel(Form1 f1)
        {
            if (f1.spinEdit173.Value == 1)
            {
                byte[] Rank = new byte[] { 0x00, 0x00, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 2)
            {
                byte[] Rank = new byte[] { 0x00, 0x04, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 3)
            {
                byte[] Rank = new byte[] { 0x00, 0x08, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 4)
            {
                byte[] Rank = new byte[] { 0x00, 0x0D, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 5)
            {
                byte[] Rank = new byte[] { 0x00, 0x1A, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 6)
            {
                byte[] Rank = new byte[] { 0x00, 0x1F, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 7)
            {
                byte[] Rank = new byte[] { 0x00, 0x2C, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 8)
            {
                byte[] Rank = new byte[] { 0x00, 0x3B, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 9)
            {
                byte[] Rank = new byte[] { 0x00, 0x4C, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);


            }
            if (f1.spinEdit173.Value == 10)
            {
                byte[] Rank = new byte[] { 0x00, 0x5F, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);


            }
            if (f1.spinEdit173.Value == 11)
            {
                byte[] Rank = new byte[] { 0x00, 0x76, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);


            }
            if (f1.spinEdit173.Value == 12)
            {
                byte[] Rank = new byte[] { 0x00, 0x90, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);


            }
            if (f1.spinEdit173.Value == 13)
            {
                byte[] Rank = new byte[] { 0x00, 0xC0, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 14)
            {
                byte[] Rank = new byte[] { 0x00, 0xE0, 0x00 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 15)
            {
                byte[] Rank = new byte[] { 0x00, 0x10, 0x01 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 16)
            {
                byte[] Rank = new byte[] { 0x00, 0x30, 0x01 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 17)
            {
                byte[] Rank = new byte[] { 0x00, 0x50, 0x01 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 18)
            {
                byte[] Rank = new byte[] { 0x00, 0x9A, 0x01 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 19)
            {
                byte[] Rank = new byte[] { 0x00, 0x9F, 0x01 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 20)
            {
                byte[] Rank = new byte[] { 0x00, 0xF9, 0x01 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 21)
            {
                byte[] Rank = new byte[] { 0x00, 0x30, 0x02 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 22)
            {
                byte[] Rank = new byte[] { 0x00, 0x70, 0x02 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 23)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x02 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 24)
            {
                byte[] Rank = new byte[] { 0x00, 0xF9, 0x02 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 25)
            {
                byte[] Rank = new byte[] { 0x00, 0xFF, 0x02 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 26)
            {
                byte[] Rank = new byte[] { 0x00, 0x4F, 0x03 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 27)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x03 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 28)
            {
                byte[] Rank = new byte[] { 0x00, 0xFF, 0x03 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 29)
            {
                byte[] Rank = new byte[] { 0x00, 0x2F, 0x04 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 30)
            {
                byte[] Rank = new byte[] { 0x00, 0x7F, 0x04 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 31)
            {
                byte[] Rank = new byte[] { 0x00, 0xFF, 0x04 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 32)
            {
                byte[] Rank = new byte[] { 0x00, 0x50, 0x05 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 33)
            {
                byte[] Rank = new byte[] { 0x00, 0x90, 0x05 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 34)
            {
                byte[] Rank = new byte[] { 0x00, 0x00, 0x06 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 35)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x06 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 36)
            {
                byte[] Rank = new byte[] { 0x00, 0xC0, 0x06 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 37)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x07 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 38)
            {
                byte[] Rank = new byte[] { 0x00, 0xB0, 0x07 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 39)
            {
                byte[] Rank = new byte[] { 0x00, 0x1F, 0x08 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 40)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x08 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 41)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x09 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 42)
            {
                byte[] Rank = new byte[] { 0x00, 0xB0, 0x09 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 43)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x0A };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 44)
            {
                byte[] Rank = new byte[] { 0x00, 0xD0, 0x0A };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 45)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x0B };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 46)
            {
                byte[] Rank = new byte[] { 0x00, 0x00, 0x0C };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 47)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x0C };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 48)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x0D };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 49)
            {
                byte[] Rank = new byte[] { 0x00, 0xF0, 0x0D };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 50)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x0E };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 51)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x0F };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 52)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x10 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 53)
            {
                byte[] Rank = new byte[] { 0x00, 0x00, 0x11 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 54)
            {
                byte[] Rank = new byte[] { 0x00, 0xA0, 0x11 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
            if (f1.spinEdit173.Value == 55)
            {
                byte[] Rank = new byte[] { 0x00, 0xFF, 0x12 };
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Stats.Level, Rank);
            }
        }
    }
}
