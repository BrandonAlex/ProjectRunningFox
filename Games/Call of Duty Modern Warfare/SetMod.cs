using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare
{
    class SetMod
    {
        public void RainBowName(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("^1" + f1.textEdit216.Text + "^2" + f1.textEdit215.Text + "^3" + f1.textEdit214.Text + "^5" + f1.textEdit213.Text + "^6" + f1.textEdit212.Text + "^7" + f1.textEdit211.Text);
            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME);
            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("^5" + f1.textEdit216.Text + "^7" + f1.textEdit215.Text + "^3" + f1.textEdit214.Text + "^1" + f1.textEdit213.Text + "^3" + f1.textEdit212.Text + "^2" + f1.textEdit211.Text);
            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME1);
            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("^3" + f1.textEdit216.Text + "^6" + f1.textEdit215.Text + "^8" + f1.textEdit214.Text + "^2" + f1.textEdit213.Text + "^4" + f1.textEdit212.Text + "^1" + f1.textEdit211.Text);
            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME2);
            System.Threading.Thread.Sleep(10);
        }
        public void NameSkipper(Form1 f1)
        {
            if (f1.groupControl144.Text.Contains("00:00:00."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit217.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl144.Text.Contains("00:00:01."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit218.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl144.Text.Contains("00:00:02."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit219.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl144.Text.Contains("00:00:03."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit220.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl144.Text.Contains("00:00:04."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit221.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl144.Text.Contains("00:00:05."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit222.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, CT);
            }
        }
        public void NameSlider(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("    " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME);

            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("      " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME1);

            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("       " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME2);

            System.Threading.Thread.Sleep(10);
            byte[] NAME3 = Encoding.ASCII.GetBytes("        " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME3, NAME3.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME3);

            System.Threading.Thread.Sleep(10);

            byte[] NAME4 = Encoding.ASCII.GetBytes("         " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME4, NAME4.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME4);

            System.Threading.Thread.Sleep(10);


            byte[] NAME5 = Encoding.ASCII.GetBytes("           " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME5, NAME5.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME5);

            System.Threading.Thread.Sleep(10);

            byte[] NAME6 = Encoding.ASCII.GetBytes("             " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME6, NAME6.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME6);

            System.Threading.Thread.Sleep(10);


            byte[] NAME7 = Encoding.ASCII.GetBytes("           " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME7, NAME7.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME7);

            System.Threading.Thread.Sleep(10);

            byte[] NAME8 = Encoding.ASCII.GetBytes("         " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME8, NAME8.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME8);

            System.Threading.Thread.Sleep(10);

            byte[] NAME9 = Encoding.ASCII.GetBytes("       " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME9);

            System.Threading.Thread.Sleep(10);
            byte[] NAME11 = Encoding.ASCII.GetBytes("     " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME11, NAME11.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME11);

            System.Threading.Thread.Sleep(10);

            byte[] NAME111 = Encoding.ASCII.GetBytes("   " + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME111, NAME111.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME111);

            System.Threading.Thread.Sleep(10);

            byte[] NAME12 = Encoding.ASCII.GetBytes(" " + f1.textEdit223.Text + "                ");

            Array.Resize(ref NAME12, NAME12.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME12);

            System.Threading.Thread.Sleep(10);
            byte[] NAME13 = Encoding.ASCII.GetBytes("" + f1.textEdit223.Text + "               ");

            Array.Resize(ref NAME13, NAME13.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Nonhost.Name, NAME13);

            System.Threading.Thread.Sleep(10);
        }
        public void TeleportToMap(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Location + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x43 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "You were teleported back to the map.");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Location + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x43 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "You were teleported back to the map.");
            }
        }
        public void TeleportUnderMap(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Location + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xC3, 0x7F });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "You were teleported under the map.");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Location + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xC3, 0x7F });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "You were teleported under the map.");
            }
        }
        public void TeleportToSpace(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Location + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x88 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "You were teleported to space.");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Location + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x88 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "You were teleported to space");
            }
        }
        public void TeleportToSky(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Location + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x47 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "You were teleported to the sky.");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Location + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x47 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "You were teleported to the sky.");
            }
        }
        public void KickClient(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.KickClient + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x01 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.KickClient + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x01 });
            }
        }
        public void JumperOFF(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Jumper + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x3F });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "Jumper ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Jumper + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x3F });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "Jumper ^1Off");
            }
        }
        public void JumperON(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Jumper + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "Jumper ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Jumper + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "Jumper ^2On");
            }
        }
        public void LagOFF(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GiveLag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "Lag ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GiveLag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "Lag ^1Off");
            }
        }
        public void LagON(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GiveLag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "Lag ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GiveLag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "Lag ^2On");
            }
        }
        public void AllPerksON(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.AllPerks + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xF5, 0x02, 0xFF, 0xFF, 0xFF, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "All Perks ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.AllPerks + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xF5, 0x02, 0xFF, 0xFF, 0xFF, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "All Perks ^2On");
            }

        }
        public void FreezeOFF(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "Freeze ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "Freeze ^1Off");
            }
        }
        public void FreezeON(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "Freeze ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "Freeze ^2On");
            }
        }
        public void UFOModeOFF(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "UFO Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "UFO Mode ^1Off");
            }
        }
        public void UFOModeON(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "UFO Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "UFO Mode ^2On");
            }
        }
        public void NoClipOFF(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "No Clip ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "No Clip ^1Off");
            }
        }
        public void NoClipON(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "No Clip ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.mFlag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "No Clip ^2On");
            }
        }
        public void DoubleSpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.SpeedX2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x73 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "Double Speed ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.SpeedX2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x73 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "Double Speed ^1Off");
            }
        }
        public void DoubleSpeedON(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.SpeedX2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "Double Speed ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.SpeedX2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "Double Speed ^2On");
            }
        }
        public void AmmoON(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.PrimaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.PrimaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.SecondaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.SecondaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GrenadeLauncherAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GrenadeLauncherClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xA9, 0xFC });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.LethalAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x11, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.TacticalAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x11, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.PrimaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.PrimaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.SecondaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.SecondaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GrenadeLauncherAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GrenadeLauncherClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xA9, 0xFC });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.LethalAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x11, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.TacticalAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x11, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "Unlimited Ammo^2On");
            }
        }
        public void GodModOFF(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GodMod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "God Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GodMod + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }
        public void GodModeON(Form1 f1)
        {
            if (f1.listBoxControl8.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GodMod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(i, "God Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.GodMod + ((uint)ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }
    }
}
