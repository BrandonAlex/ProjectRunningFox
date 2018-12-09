using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2
{
    class SetModZM
    {
        public static void GodModeON(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.ZMGod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x7F, 0xFF, 0xFF, 0xFF });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "God Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.ZMGod + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x7F, 0xFF, 0xFF, 0xFF });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }
        public static void PointsON(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.MaxPoints + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x0F, 0x42, 0x40 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Max Points ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.MaxPoints + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x0F, 0x42, 0x40 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Max Points ^2On");
            }
        }
        public static void BOXScreenON(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.BoxSCR1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x10 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Box Screen ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.BoxSCR1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x10 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Box Screen ^2On");
            }
        }
        public static void LastStandON(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.fakedown + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x01 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Last Stand ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.fakedown + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x01 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Last Stand ^2On");
            }
        }
        public static void SpeedON(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Speed2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x40 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Double Speed ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Speed2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x40 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Double Speed ^2On");
            }
        }
        public static void FreezeON(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 15 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Freeze ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 15 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Freeze ^2On");
            }
        }
        public static void LagON(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.lag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Lag ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.lag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Lag ^2On");
            }
        }
        public static void RemoveWeapon(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.RemoveWeapon + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xE8 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "^1Weapon Removed");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.RemoveWeapon + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xE8 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "^1Weapon Removed");
            }
        }
        public static void AmmoON(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(0x1781355 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0xFF, 0x00, 0xFF, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(0x1781319 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(0x1781339 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0x00 });
                    Form1.PS3.Extension.WriteBytes(0x178135D + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(0x1781321 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(0x1781355 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0xFF, 0x00, 0xFF, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(0x1781319 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(0x1781339 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0x00 });
                Form1.PS3.Extension.WriteBytes(0x178135D + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(0x1781321 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Unlimited Ammo ^2On");
            }
        }

        public static void AmmoOFF(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(0x1781355 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(0x1781319 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(0x1781339 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0x00 });
                    Form1.PS3.Extension.WriteBytes(0x178135D + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00, 0xFF, 0x00 });
                    Form1.PS3.Extension.WriteBytes(0x1781321 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0x00, 0xFF });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Unlimited Ammo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(0x1781355 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(0x1781319 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(0x1781339 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0x00 });
                Form1.PS3.Extension.WriteBytes(0x178135D + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00, 0xFF, 0x00 });
                Form1.PS3.Extension.WriteBytes(0x1781321 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0x00, 0xFF });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Unlimited Ammo ^1Off");
            }
        }
        public static void RemoveWeaponOFF(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.RemoveWeapon + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xE9 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "^2Weapon Returned");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.RemoveWeapon + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xE9 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "^1Weapon Returned");
            }
        }
        public static void LagOFF(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.lag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[]{ 0x22 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Lag ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.lag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[]{ 0x22 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Lag ^1Off");
            }
        }
        public static void FreezeOFF(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Freeze ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Freeze ^1Off");
            }
        }
        public static void SpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Speed2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x3f });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Double Speed ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.Speed2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x3f });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Double Speed ^1Off");
            }
        }
        public static void iPrintLn(Form1 f1)
        {
            Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, f1.textEdit356.Text);
            Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(1, f1.textEdit356.Text);
            Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(2, f1.textEdit356.Text);
            Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(3, f1.textEdit356.Text);
        }
        public static void iPrintLn1(Form1 f1)
        {
            Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(0, f1.textEdit356.Text);
            Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(1, f1.textEdit356.Text);
            Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(2, f1.textEdit356.Text);
            Games.Call_of_Duty_Black_Ops_2.RPC.iPrintlnBold(3, f1.textEdit356.Text);
        }
        public static void LastStandOFF(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.fakedown + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Last Stand ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.fakedown + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Last Stand ^1Off");
            }
        }
        public static void BOXScreenOFF(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.BoxSCR1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Box Screen ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.BoxSCR1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] {0x00});
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Box Screen ^1Off");
            }
        }
        public static void ThirdPersonON(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.POV3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 1 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Third Person ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.POV3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 1 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Third Person ^2On");
            }
        }
        public static void ThirdPersonOFF(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.POV3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Third Person ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.POV3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[1]);
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Third Person ^1Off");
            }
        }
        public static void PointsOFF(Form1 f1)
        {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.MaxPoints + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00, 0x00, 0x00 });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "Max Points ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.MaxPoints + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0x00, 0x00, 0x00 });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Max Points ^1Off");
            }
        }
             public static void GodModeOFF(Form1 f1)
              {
            if (f1.listBoxControl15.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.ZMGod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
                    Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(i, "God Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Lobby.ZMGod + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2.offsets.Multiplayermods.NextClient), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
                Games.Call_of_Duty_Black_Ops_2.SetMod.RPCText1.Set(0, Games.Call_of_Duty_Black_Ops_2.SetMod.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }
    }
}
