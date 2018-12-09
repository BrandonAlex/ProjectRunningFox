using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2
{
    public static class SetMod
    {
        public static bool Notify = false;
        public static void InvisibleON(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Invisible + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x01 });
                    RPCText1.Set(i, "Invisible ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Invisible + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x01 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Invisible ^2On");
            }
        }
        public static void LagON(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.lag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                    RPCText1.Set(i, "Lag ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.lag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Lag ^2On");
            }
        }
        public static void LagOFF(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.lag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x22 });
                    RPCText1.Set(i, "Lag ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.lag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x22 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Lag ^1Off");
            }
        }
        public static void FreezeON(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 15 });
                    RPCText1.Set(i, "Freeze ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 15 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Freeze ^2On");
            }
        }
        public static void FreezeOFF(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                    RPCText1.Set(i, "Freeze ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Freeze ^1Off");
            }
        }
        public static void InvisibleOFF(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Invisible + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                    RPCText1.Set(i, "Invisible ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Invisible + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Invisible ^1Off");
            }
        }
        public static void JumperON(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Jumper + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                    RPCText1.Set(i, "Jumper ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Jumper + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Jumper ^2On");
            }
        }
        public static void JumperOFF(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Jumper + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x3f });
                    RPCText1.Set(i, "Jumper ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Jumper + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x3f });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Jumper ^1Off");
            }
        }
        public static void ScorestreaksOFF(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });

                    RPCText1.Set(i, "Scorestreaks ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Scorestreaks ^1Off");
            }
        }
        public static void ScorestreaksON(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x01 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x01 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x01 });

                    RPCText1.Set(i, "Scorestreaks ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x01 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x01 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Killstreak3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x01 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Scorestreaks ^2On");
            }
        }
        public static void SpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Speed2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x3f });
                    RPCText1.Set(i, "Double Speed ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Speed2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x3f });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Double Speed ^1Off");
            }
        }
        public static void SpeedON(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Speed2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x40 });
                    RPCText1.Set(i, "Double Speed ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Speed2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x40 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Double Speed ^2On");
            }
        }
        public static void VSATOff(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.VSATIG + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                    RPCText1.Set(i, "Orbital VSAT ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.VSATIG + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Orbital VSAT ^1Off");
            }
        }
        public static void VSATON(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.VSATIG + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 1 });
                    RPCText1.Set(i, "Orbital VSAT ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.VSATIG + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 1 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Orbital VSAT ^2On");
            }
        }
        public static void ThirdPersonOFF(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.POV3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                    RPCText1.Set(i, "Third Person ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.POV3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Third Person ^1Off");
            }
        }
        public static void ThirdPersonON(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.POV3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 1 });
                    RPCText1.Set(i, "Third Person ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.POV3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 1 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Third Person ^2On");
            }
        }
        public static void AmmoOFF(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo4 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo5 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo6 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo7 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo8 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                    RPCText1.Set(i, "Unlimited Ammo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo4 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo5 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo6 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo7 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo8 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[6]);
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Unlimited Ammo ^1Off");
            }
        }
        public static void AmmoON(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo4 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo5 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo6 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo7 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo8 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                    RPCText1.Set(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo4 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo5 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo6 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo7 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Ammo8 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xff, 0xff });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Unlimited Ammo ^2On");
            }
        }
        public static  void GodModeON(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.GodMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x05 });
                    RPCText1.Set(i, "God Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.GodMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x05 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }
        public static void GodModeOFF(Form1 f1)
        {
            if (f1.listBoxControl14.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.GodMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x04 });
                    RPCText1.Set(i, "God Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.GodMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x04 });
                RPCText1.Set(0, GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }
        public static void iPrintln1(Form1 f1)
        {
            RPCText1.Set(0, f1.textEdit334.Text);
            RPCText1.Set(1, f1.textEdit334.Text);
            RPCText1.Set(2, f1.textEdit334.Text);
            RPCText1.Set(3, f1.textEdit334.Text);
            RPCText1.Set(4, f1.textEdit334.Text);
            RPCText1.Set(5, f1.textEdit334.Text);
            RPCText1.Set(6, f1.textEdit334.Text);
            RPCText1.Set(7, f1.textEdit334.Text);
            RPCText1.Set(8, f1.textEdit334.Text);
            RPCText1.Set(9, f1.textEdit334.Text);
            RPCText1.Set(10, f1.textEdit334.Text);
            RPCText1.Set(11, f1.textEdit334.Text);
        }
        public static void SetAllNames(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit335.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName1, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName2, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName3, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName4, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName5, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName6, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName7, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName8, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName9, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName10, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName11, bytes);
        }
        public static void NameSkipper(Form1 f1)
        {
            if (f1.groupControl230.Text.Contains("00:00:00."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit342.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl230.Text.Contains("00:00:01."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit343.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl230.Text.Contains("00:00:02."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit344.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl230.Text.Contains("00:00:03."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit345.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl230.Text.Contains("00:00:04."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit346.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl230.Text.Contains("00:00:05."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit347.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, CT);
            }
        }
        public static void NameSlider(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("    " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME);

            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("      " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME1);

            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("       " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME2);

            System.Threading.Thread.Sleep(10);
            byte[] NAME3 = Encoding.ASCII.GetBytes("        " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME3, NAME3.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME3);

            System.Threading.Thread.Sleep(10);

            byte[] NAME4 = Encoding.ASCII.GetBytes("         " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME4, NAME4.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME4);

            System.Threading.Thread.Sleep(10);


            byte[] NAME5 = Encoding.ASCII.GetBytes("           " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME5, NAME5.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME5);

            System.Threading.Thread.Sleep(10);

            byte[] NAME6 = Encoding.ASCII.GetBytes("             " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME6, NAME6.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME6);

            System.Threading.Thread.Sleep(10);


            byte[] NAME7 = Encoding.ASCII.GetBytes("           " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME7, NAME7.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME7);

            System.Threading.Thread.Sleep(10);

            byte[] NAME8 = Encoding.ASCII.GetBytes("         " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME8, NAME8.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME8);

            System.Threading.Thread.Sleep(10);

            byte[] NAME9 = Encoding.ASCII.GetBytes("       " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME9);

            System.Threading.Thread.Sleep(10);
            byte[] NAME11 = Encoding.ASCII.GetBytes("     " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME11, NAME11.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME11);

            System.Threading.Thread.Sleep(10);

            byte[] NAME111 = Encoding.ASCII.GetBytes("   " + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME111, NAME111.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME111);

            System.Threading.Thread.Sleep(10);

            byte[] NAME12 = Encoding.ASCII.GetBytes(" " + f1.textEdit348.Text + "                ");

            Array.Resize(ref NAME12, NAME12.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME12);

            System.Threading.Thread.Sleep(10);
            byte[] NAME13 = Encoding.ASCII.GetBytes("" + f1.textEdit348.Text + "               ");

            Array.Resize(ref NAME13, NAME13.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME13);

            System.Threading.Thread.Sleep(10);
        }
        public static void RBName(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("^1" + f1.textEdit341.Text + "^4" + f1.textEdit340.Text + "^3" + f1.textEdit339.Text + "^5" + f1.textEdit338.Text + "^6" + f1.textEdit337.Text + "^7" + f1.textEdit336.Text);
            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME);
            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("^5" + f1.textEdit341.Text + "^7" + f1.textEdit340.Text + "^3" + f1.textEdit339.Text + "^1" + f1.textEdit338.Text + "^3" + f1.textEdit337.Text + "^2" + f1.textEdit336.Text);
            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME1);
            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("^3" + f1.textEdit341.Text + "^6" + f1.textEdit340.Text + "^8" + f1.textEdit339.Text + "^2" + f1.textEdit338.Text + "^4" + f1.textEdit337.Text + "^1" + f1.textEdit336.Text);
            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Nonhost.Name, NAME2);
            System.Threading.Thread.Sleep(10);
        }
        public static void FlashAll(Form1 f1)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + f1.textEdit335.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName1, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName2, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName3, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName4, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName5, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName6, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName7, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName8, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName9, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName10, bytes);
            PS3.SetMemory(Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName11, bytes);
          
        }
        public static void iPrintBold1(Form1 f1)
        {
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(0, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(1, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(2, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(3, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(4, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(5, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(6, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(7, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(8, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(9, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(10, f1.textEdit334.Text);
           Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(11, f1.textEdit334.Text);
        }
        public static string GetNames(int clientIndex)
        {
            if (Form1.PS3.Extension.ReadByte(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient)) == 0x00)
            {
                return "Not Connected";
            }
            else
            {
                return Form1.PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.InGameName + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient));
            }
        }
        public class RPCText1
        {
            public static void Set(int Client, string Text)
            {
                if (Notify == true)
                {
                    Games.Call_of_Duty_Black_Ops_2.RPC.iPrintln(Client, Text);

                }
            }
        }
    }
}
