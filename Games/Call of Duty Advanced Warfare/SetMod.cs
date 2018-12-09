using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare
{
    class SetMod
    {
        public void RainBowName(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("^1" + f1.textEdit137.Text + "^4" + f1.textEdit136.Text + "^3" + f1.textEdit135.Text + "^5" + f1.textEdit134.Text + "^6" + f1.textEdit133.Text + "^7" + f1.textEdit132.Text);
            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME);
            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("^5" + f1.textEdit137.Text + "^7" + f1.textEdit136.Text + "^3" + f1.textEdit135.Text + "^1" + f1.textEdit134.Text + "^3" + f1.textEdit133.Text + "^2" + f1.textEdit132.Text);
            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME1);
            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("^3" + f1.textEdit137.Text + "^6" + f1.textEdit136.Text + "^8" + f1.textEdit135.Text + "^2" + f1.textEdit134.Text + "^4" + f1.textEdit133.Text + "^1" + f1.textEdit132.Text);
            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME2);
            System.Threading.Thread.Sleep(10);
        }
        public void NameSkipper(Form1 f1)
        {
            if (f1.groupControl99.Text.Contains("00:00:00."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit138.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl99.Text.Contains("00:00:01."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit139.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl99.Text.Contains("00:00:02."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit140.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl99.Text.Contains("00:00:03."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit141.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl99.Text.Contains("00:00:04."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit142.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl99.Text.Contains("00:00:05."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit143.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, CT);
            }
        }
        public void NameSlider(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("    " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME);

            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("      " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME1);

            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("       " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME2);

            System.Threading.Thread.Sleep(10);
            byte[] NAME3 = Encoding.ASCII.GetBytes("        " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME3, NAME3.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME3);

            System.Threading.Thread.Sleep(10);

            byte[] NAME4 = Encoding.ASCII.GetBytes("         " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME4, NAME4.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME4);

            System.Threading.Thread.Sleep(10);


            byte[] NAME5 = Encoding.ASCII.GetBytes("           " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME5, NAME5.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME5);

            System.Threading.Thread.Sleep(10);

            byte[] NAME6 = Encoding.ASCII.GetBytes("             " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME6, NAME6.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME6);

            System.Threading.Thread.Sleep(10);


            byte[] NAME7 = Encoding.ASCII.GetBytes("           " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME7, NAME7.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME7);

            System.Threading.Thread.Sleep(10);

            byte[] NAME8 = Encoding.ASCII.GetBytes("         " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME8, NAME8.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME8);

            System.Threading.Thread.Sleep(10);

            byte[] NAME9 = Encoding.ASCII.GetBytes("       " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME9);

            System.Threading.Thread.Sleep(10);
            byte[] NAME11 = Encoding.ASCII.GetBytes("     " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME11, NAME11.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME11);

            System.Threading.Thread.Sleep(10);

            byte[] NAME111 = Encoding.ASCII.GetBytes("   " + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME111, NAME111.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME111);

            System.Threading.Thread.Sleep(10);

            byte[] NAME12 = Encoding.ASCII.GetBytes(" " + f1.textEdit144.Text + "                ");

            Array.Resize(ref NAME12, NAME12.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME12);

            System.Threading.Thread.Sleep(10);
            byte[] NAME13 = Encoding.ASCII.GetBytes("" + f1.textEdit144.Text + "               ");

            Array.Resize(ref NAME13, NAME13.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Nonhost.Name, NAME13);

            System.Threading.Thread.Sleep(10);
        }
        public void ColoredClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Custom 10");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^4Custom 9");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^3Custom 8,");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^2Custom 7");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^1Custom 6");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^5Custom 5");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^4Custom 4");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^3Custom 3");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^2Custom 2");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1Custom 1");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class1, bytes9);
        }
        public void CreatorClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Content :)");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^2Updates and More");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^1Subscribe For,");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^6Running Fox");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^5Thanks For Using");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^0BrandonCardenWV");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^3Instagram @");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^2Follow Me on");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^4AKA, Brandon");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1XxBlud-23xX");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class1, bytes9);
        }
        public void SetAllClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class10, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class9, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class8, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class7, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class6, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class5, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class4, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class3, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class2, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClassNames.Class1, bytes);
        }
        public void NoFrictionOFF(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NoFriction + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "No Friction ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NoFriction + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "No Friction ^1Off");
            }
        }
        public void NoFrictionON(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NoFriction + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "No Friction ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NoFriction + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "No Friction ^2On");
            }
        }
        public void ExoCloakOFF(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ExoCloak + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Exo Cloak ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ExoCloak + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Exo Cloak ^1Off");
            }
        }
        public void ExoCloakON(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ExoCloak + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Exo Cloak ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ExoCloak + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Exo Cloak ^2On");
            }
        }
        public void ThirdPersonOFF(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ThirdPerson + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 1 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Third Person ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ThirdPerson + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 1 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Third Person ^1Off");
            }
        }
        public void ThirdPersonON(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ThirdPerson + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 14 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Third Person ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ThirdPerson + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 14 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Third Person ^2On");
            }
        }
        public void RedBoxesOFF(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.RedBoxes + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x1 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Red Boxes ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.RedBoxes + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x1 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Red Boxes ^1Off");
            }
        }
        public void RedBoxesON(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.RedBoxes + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x15 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Red Boxes ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.RedBoxes + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x15 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Red Boxes ^2On");
            }
        }
        public void LaserOFF(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.Laser + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Laser ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.Laser + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Laser ^1Off");
            }
        }
        public void LaserOn(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.Laser + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Laser ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.Laser + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Laser ^2On");
            }
        }
        public void DoubleSpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.Speed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 63 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Double Speed ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.Speed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 63 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Double Speed ^1Off");
            }
        }
        public void DoubleSpeedON(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.Speed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 64 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Double Speed ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.Speed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 64 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Double Speed ^2On");
            }
        }
        public void LagOFF(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.FakeLag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Lag ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.FakeLag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Lag ^1Off");
            }
        }
        public void LagON(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.FakeLag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Lag ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.FakeLag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Lag ^2On");
            }
        }
        public void mFlagOFF(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.mFlag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "mFlag ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.mFlag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "mFlag ^1Off");
            }
        }
        public void mFlagON(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.mFlag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "mFlag ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.mFlag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "mFlag ^2On");
            }
        }
        public void AmmoOFF(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ExoLauncherAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00, 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.PrimaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00, 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.SecondaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Unlimited Ammo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ExoLauncherAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00, 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.PrimaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00, 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.SecondaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Unlimited Ammo ^1Off");
            }
        }
        public void AmmoON(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ExoLauncherAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.PrimaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.SecondaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.ExoLauncherAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.PrimaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.SecondaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.NextClient), new byte[] { 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "Unlimited Ammo ^2On");
            }
        }
        public void GodModeOFF(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.GodMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.GModInterval), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "God Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.GodMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.GModInterval), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }
        public void GodModeON(Form1 f1)
        {
            if (f1.listBoxControl5.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.GodMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.GModInterval), new byte[] { 0x00, 0x00, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(i, "God Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.GodMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.GModInterval), new byte[] { 0x00, 0x00, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }
    }
}
