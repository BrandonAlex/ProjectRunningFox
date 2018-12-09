using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops
{
    class SetMod
    {
        public void ZombieRainBowName(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("^1" + f1.textEdit193.Text + "^4" + f1.textEdit192.Text + "^3" + f1.textEdit191.Text + "^5" + f1.textEdit190.Text + "^6" + f1.textEdit189.Text + "^7" + f1.textEdit188.Text);
            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME);
            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("^5" + f1.textEdit193.Text + "^7" + f1.textEdit192.Text + "^3" + f1.textEdit191.Text + "^1" + f1.textEdit190.Text + "^3" + f1.textEdit189.Text + "^2" + f1.textEdit188.Text);
            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME1);
            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("^3" + f1.textEdit193.Text + "^6" + f1.textEdit192.Text + "^8" + f1.textEdit191.Text + "^2" + f1.textEdit190.Text + "^4" + f1.textEdit189.Text + "^1" + f1.textEdit188.Text);
            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME2);
            System.Threading.Thread.Sleep(10);
        }
        public void ZombieNameSkipper(Form1 f1)
        {
            if (f1.groupControl129.Text.Contains("00:00:00."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit194.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, CT);
            }
            if (f1.groupControl129.Text.Contains("00:00:01."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit195.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, CT);
            }
            if (f1.groupControl129.Text.Contains("00:00:02."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit196.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, CT);
            }
            if (f1.groupControl129.Text.Contains("00:00:03."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit197.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, CT);
            }
            if (f1.groupControl129.Text.Contains("00:00:04."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit198.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, CT);
            }
            if (f1.groupControl129.Text.Contains("00:00:05."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit199.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, CT);
            }
        }
        public void ZombieNameSlider(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("    " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME);

            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("      " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME1);

            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("       " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME2);

            System.Threading.Thread.Sleep(10);
            byte[] NAME3 = Encoding.ASCII.GetBytes("        " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME3, NAME3.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME3);

            System.Threading.Thread.Sleep(10);

            byte[] NAME4 = Encoding.ASCII.GetBytes("         " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME4, NAME4.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME4);

            System.Threading.Thread.Sleep(10);


            byte[] NAME5 = Encoding.ASCII.GetBytes("           " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME5, NAME5.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME5);

            System.Threading.Thread.Sleep(10);

            byte[] NAME6 = Encoding.ASCII.GetBytes("             " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME6, NAME6.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME6);

            System.Threading.Thread.Sleep(10);


            byte[] NAME7 = Encoding.ASCII.GetBytes("           " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME7, NAME7.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME7);

            System.Threading.Thread.Sleep(10);

            byte[] NAME8 = Encoding.ASCII.GetBytes("         " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME8, NAME8.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME8);

            System.Threading.Thread.Sleep(10);

            byte[] NAME9 = Encoding.ASCII.GetBytes("       " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME9);

            System.Threading.Thread.Sleep(10);
            byte[] NAME11 = Encoding.ASCII.GetBytes("     " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME11, NAME11.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME11);

            System.Threading.Thread.Sleep(10);

            byte[] NAME111 = Encoding.ASCII.GetBytes("   " + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME111, NAME111.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME111);

            System.Threading.Thread.Sleep(10);

            byte[] NAME12 = Encoding.ASCII.GetBytes(" " + f1.textEdit200.Text + "                ");

            Array.Resize(ref NAME12, NAME12.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME12);

            System.Threading.Thread.Sleep(10);
            byte[] NAME13 = Encoding.ASCII.GetBytes("" + f1.textEdit200.Text + "               ");

            Array.Resize(ref NAME13, NAME13.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.LobbyName, NAME13);

            System.Threading.Thread.Sleep(10);
        }
        public void RainbowName(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("^1" + f1.textEdit171.Text + "^4" + f1.textEdit170.Text + "^3" + f1.textEdit169.Text + "^5" + f1.textEdit168.Text + "^6" + f1.textEdit167.Text + "^7" + f1.textEdit166.Text);
            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME);
            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("^5" + f1.textEdit171.Text + "^7" + f1.textEdit170.Text + "^3" + f1.textEdit169.Text + "^1" + f1.textEdit168.Text + "^3" + f1.textEdit167.Text + "^2" + f1.textEdit166.Text);
            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME1);
            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("^3" + f1.textEdit171.Text + "^6" + f1.textEdit170.Text + "^8" + f1.textEdit169.Text + "^2" + f1.textEdit168.Text + "^4" + f1.textEdit167.Text + "^1" + f1.textEdit166.Text);
            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME2);
            System.Threading.Thread.Sleep(10);
        }
        public void NameSkipper(Form1 f1)
        {
            if (f1.groupControl116.Text.Contains("00:00:00."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit172.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl116.Text.Contains("00:00:01."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit173.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl116.Text.Contains("00:00:02."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit174.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl116.Text.Contains("00:00:03."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit175.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl116.Text.Contains("00:00:04."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit176.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl116.Text.Contains("00:00:05."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit177.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, CT);
            }
        }
        public void NameSlider(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("    " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME);

            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("      " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME1);

            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("       " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME2);

            System.Threading.Thread.Sleep(10);
            byte[] NAME3 = Encoding.ASCII.GetBytes("        " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME3, NAME3.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME3);

            System.Threading.Thread.Sleep(10);

            byte[] NAME4 = Encoding.ASCII.GetBytes("         " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME4, NAME4.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME4);

            System.Threading.Thread.Sleep(10);


            byte[] NAME5 = Encoding.ASCII.GetBytes("           " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME5, NAME5.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME5);

            System.Threading.Thread.Sleep(10);

            byte[] NAME6 = Encoding.ASCII.GetBytes("             " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME6, NAME6.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME6);

            System.Threading.Thread.Sleep(10);


            byte[] NAME7 = Encoding.ASCII.GetBytes("           " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME7, NAME7.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME7);

            System.Threading.Thread.Sleep(10);

            byte[] NAME8 = Encoding.ASCII.GetBytes("         " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME8, NAME8.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME8);

            System.Threading.Thread.Sleep(10);

            byte[] NAME9 = Encoding.ASCII.GetBytes("       " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME9);

            System.Threading.Thread.Sleep(10);
            byte[] NAME11 = Encoding.ASCII.GetBytes("     " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME11, NAME11.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME11);

            System.Threading.Thread.Sleep(10);

            byte[] NAME111 = Encoding.ASCII.GetBytes("   " + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME111, NAME111.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME111);

            System.Threading.Thread.Sleep(10);

            byte[] NAME12 = Encoding.ASCII.GetBytes(" " + f1.textEdit178.Text + "                ");

            Array.Resize(ref NAME12, NAME12.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME12);

            System.Threading.Thread.Sleep(10);
            byte[] NAME13 = Encoding.ASCII.GetBytes("" + f1.textEdit178.Text + "               ");

            Array.Resize(ref NAME13, NAME13.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Nonhost.Name, NAME13);

            System.Threading.Thread.Sleep(10);
        }
        public void GodModeClasses(Form1 f1)
        {
            byte[] buffer = new byte[] { 0xE7 };
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClassNames.GMIClass1, buffer);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClassNames.GMIClass2, buffer);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClassNames.GMIClass3, buffer);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClassNames.GMIClass4, buffer);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClassNames.GMIClass5, buffer);
            byte[] buffer1 = new byte[] { 0xCE };
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClassNames.GMIClass1, buffer1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClassNames.GMIClass1, buffer1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClassNames.GMIClass1, buffer1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClassNames.GMIClass1, buffer1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClassNames.GMIClass1, buffer1);
        }
        public void FlashAll(Form1 f1)
        {
            int num = new Random().Next(0, 7);
            byte[] bytes = Encoding.ASCII.GetBytes("^" + num + f1.textEdit165.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame1, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame2, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame3, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame4, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame5, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame6, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame7, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame8, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame9, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame10, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame11, bytes);
        }
        public void SetAllNames(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit165.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame1, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame2, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame3, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame4, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame5, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame6, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame7, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame8, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame9, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame10, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NameInGame11, bytes);
        }
        public void RPCText2(Form1 f1)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(0, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(1, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(2, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(3, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(4, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(5, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(6, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(7, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(8, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(9, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(10, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.iPrintlnBold(11, f1.textEdit164.Text);
        }
        public void RPCText1(Form1 f1)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(1, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(2, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(3, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(4, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(5, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(6, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(7, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(8, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(9, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(10, f1.textEdit164.Text);
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(11, f1.textEdit164.Text);
        }
        //ZOMBIES

        public void NoTargetON(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NoTarget + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "No Target ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NoTarget + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "No Target ^2On");
            }
        }

        public void NoTargetOFF(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NoTarget + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "No Target ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.NoTarget + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "No Target ^1Off");
            }
        }
        public void MaxPointsOFF(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Money + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x50, 0x00, 0x01, 0xF4 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "Max Points ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Money + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x50, 0x00, 0x01, 0xF4 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Max Points ^1Off");
            }
        }
        public void MaxPointsON(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Money + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0, 1, 0x86, 160 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "Max Points ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Money + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0, 1, 0x86, 160 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Max Points ^2On");
            }
        }
        public void ZombieDoubleSpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Speed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x3f, 0x80 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "Double Speed ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Speed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x3f, 0x80 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Double Speed ^1Off");
            }
        }
        public void ZombieDoubleSpeedON(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Speed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x40, 0x74 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "Double Speed ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Speed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x40, 0x74 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Double Speed ^2On");
            }
        }
        public void ZombieFreezeOFF(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "Freeze ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Freeze ^1Off");
            }
        }
        public void ZombieFreezeON(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x04 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "Freeze ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x04 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Freeze ^2On");
            }
        }
        public void ZombieUFOModeOFF(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "UFO Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "UFO Mode ^1Off");
            }
        }
        public void ZombieUFOModeON(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "UFO Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "UFO Mode ^2On");
            }
        }
        public void ZombieNoClipOFF(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "No Clip ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "No Clip ^1Off");
            }
        }
        public void ZombieNoClipON(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "No Clip ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.mFlags + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "No Clip ^2On");
            }
        }
        public void ZombieAmmoON(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo4 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo5 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo6 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo4 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo5 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.Ammo6 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval), new byte[] { 15, 0xff, 0xff, 0xff });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Unlimited Ammo ^2On");
            }
        }
        public void ZombieGodModeOFF(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Games.Call_of_Duty_Black_Ops.RPC1.Call(Games.Call_of_Duty_Black_Ops.Offsets.Client.PlayerCMD_DisableInvulnerability + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval));
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "God Mode ^1Off");
                }
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.RPC1.Call(Games.Call_of_Duty_Black_Ops.Offsets.Client.PlayerCMD_DisableInvulnerability + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval));
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }
        public void ZombieGodModeON(Form1 f1)
        {
            if (f1.listBoxControl7.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Games.Call_of_Duty_Black_Ops.RPC1.Call(Games.Call_of_Duty_Black_Ops.Offsets.Client.PlayerCMD_EnableInvulnerability + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval));
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(i, "God Mode ^2On");
                }
            }
            else
            {
                Games.Call_of_Duty_Black_Ops.RPC1.Call(Games.Call_of_Duty_Black_Ops.Offsets.Client.PlayerCMD_EnableInvulnerability + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval));
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText12.SetZombies(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNamesZombies(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }
        //ZOMBIES
        public void InvisibilityOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Invisibility + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Invisibility ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Invisibility + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Invisibility ^1Off");
            }
        }
        public void InvisibilityON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Invisibility + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Invisibility ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Invisibility + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Invisibility ^2On");
            }
        }
        public void AllPerksOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.AllPerks + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "All Perks ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.AllPerks + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "All Perks ^1Off");
            }
        }
        public void AllPerksON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.AllPerks + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "All Perks ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.AllPerks + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "All Perks ^2On");
            }
        }
        public void BigMapOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.BigMap + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Big Map ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.BigMap + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Big Map ^1Off");
            }
        }
        public void BigMapON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.BigMap + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Big Map ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.BigMap + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Big Map ^2On");
            }
        }
        public void YellowMapOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.YellowMap + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Yellow Map ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.YellowMap + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Yellow Map ^1Off");
            }
        }
        public void YellowMapON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.YellowMap + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x60 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Yellow Map ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.YellowMap + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x60 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Yellow Map ^2On");
            }
        }
        public void BlackBirdOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.BlackBird + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Black Bird ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.BlackBird + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Black Bird ^1Off");
            }
        }
        public void BlackBirdON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.BlackBird + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Black Bird ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.BlackBird + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Black Bird ^2On");
            }
        }
        public void FreezeOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Speed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x3F, 0x80 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Freeze ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Speed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x3F, 0x80 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Freeze ^1Off");
            }
        }
        public void FreezeON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Speed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Freeze ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Speed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Freeze ^2On");
            }
        }
        public void CheckerBoardOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.CheckerBoard + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Checker Board ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.CheckerBoard + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Checker Board ^1Off");
            }
        }
        public void CheckerBoardON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.CheckerBoard + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0xFA });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Checker Board ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.CheckerBoard + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0xFA });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Checker Board ^2On");
            }
        }
        public void SecondChanceOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.SecondChance + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Second Chance ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.SecondChance + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Second Chance ^1Off");
            }
        }
        public void SecondChanceON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.SecondChance + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Second Chance ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.SecondChance + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Second Chance ^2On");
            }
        }
        public void ReconPlaneOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.ReconPlane + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "HUD ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.ReconPlane + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "HUD ^1Off");
            }
        }
        public void ReconPlaneON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.ReconPlane + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x03 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "HUD ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.ReconPlane + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x03 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "HUD ^2On");
            }
        }
        public void UFOModeOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.mFlags + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "UFO Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.mFlags + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "UFO Mode ^1Off");
            }
        }
        public void UFOModeON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.mFlags + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "UFO Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.mFlags + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "UFO Mode ^2On");
            }
        }
        public void NoClipOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.mFlags + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "No Clip ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.mFlags + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "No Clip ^1Off");
            }
        }
        public void NoClipON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.mFlags + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "No Clip ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.mFlags + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "No Clip ^2On");
            }
        }
        public void DoubleSpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Speed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x3F, 0x80 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Double Speed ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Speed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x3F, 0x80 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Double Speed ^1Off");
            }
        }
        public void DoubleSpeedON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Speed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x40, 0x40 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Double Speed ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Speed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x40, 0x40 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Double Speed ^2On");
            }
        }
        public void AmmoOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo4 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo5 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Unlimited Ammo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo4 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo5 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 00, 0x00, 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Unlimited Ammo ^1Off");
            }
        }
        public void AmmoON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo4 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo5 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo4 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.UnlimitedAmmo5 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 15, 0xff, 0xff, 0xff });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "Unlimited Ammo ^2On");
            }
        }
        public void GodModeOFF(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.GodMod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x04 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "God Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.GodMod + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x04 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }
        public void GodModeON(Form1 f1)
        {
            if (f1.listBoxControl6.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.GodMod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x05 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(i, "God Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.GodMod + ((uint)ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval), new byte[] { 0x05 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }
    }
}
