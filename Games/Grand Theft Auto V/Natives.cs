using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Grand_Theft_Auto_V
{
    class Natives
    {
        public static Form1 f1 = new Form1();
        public static void STAT_SET_INT(string stat, int val, int savec)
        {
            if (stat.Substring(0, 6) == "MPPLY_")
            {
                Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_INT, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash(stat), val, savec);
            }
            else
            {
                if (f1.comboBoxEdit7.SelectedIndex == 0)
                {
                    Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_INT, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash("MP0_" + stat), val, savec);
                }
                if (f1.comboBoxEdit7.SelectedIndex == 1)
                {
                    Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_INT, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash("MP1_" + stat), val, savec);
                }
                if (f1.comboBoxEdit7.SelectedIndex == 2)
                {
                    Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_INT, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash("MP2_" + stat), val, savec);
                }
            }
        }

        public static void STAT_SET_BOOL(string stat, int val, int savec)
        {
            if (stat.Substring(0, 6) == "MPPLY_")
            {
                Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_BOOL, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash(stat), val, savec);
            }
            else
            {
                if (f1.comboBoxEdit7.SelectedIndex == 0)
                {
                    Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_BOOL, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash("MP0_" + stat), val, savec);
                }
                if (f1.comboBoxEdit7.SelectedIndex == 1)
                {
                    Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_BOOL, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash("MP1_" + stat), val, savec);
                }
                if (f1.comboBoxEdit7.SelectedIndex == 2)
                {
                    Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_BOOL, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash("MP2_" + stat), val, savec);
                }
            }
        }
        public static void STAT_SET_FLOAT(string stat, float val, int savec)
        {
            if (stat.Substring(0, 6) == "MPPLY_")
            {
                Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_FLOAT, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash(stat), val, savec);
            }
            else
            {
                if (f1.comboBoxEdit7.SelectedIndex == 0)
                {
                    Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_FLOAT, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash("MP0_" + stat), val, savec);
                }
                if (f1.comboBoxEdit7.SelectedIndex == 1)
                {
                    Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_FLOAT, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash("MP1_" + stat), val, savec);
                }
                if (f1.comboBoxEdit7.SelectedIndex == 2)
                {
                    Games.Grand_Theft_Auto_V.RPC.Call((uint)ProjectRunningFox.Games.Grand_Theft_Auto_V.Offsets.Addresses.STAT_SET_FLOAT, ProjectRunningFox.Games.Grand_Theft_Auto_V.Natives.Hash("MP2_" + stat), val, savec);
                }
            }
        }
        public static uint Hash(string input)

        {
            byte[] stingbytes = Encoding.UTF8.GetBytes(input.ToLower());
            uint num1 = 0U;
            for (int i = 0; i < stingbytes.Length; i++)
            {
                uint num2 = num1 + (uint)stingbytes[i];
                uint num3 = num2 + (num2 << 10);
                num1 = num3 ^ num3 >> 6;
            }
            uint num4 = num1 + (num1 << 3);
            uint num5 = num4 ^ num4 >> 11;
            return num5 + (num5 << 15);
        }
    }
}
