using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_World_at_War
{
    class SetMod
    {
        public void RainBowName(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("^1" + f1.textEdit82.Text + "^4" + f1.textEdit81.Text + "^3" + f1.textEdit80.Text + "^5" + f1.textEdit79.Text + "^6" + f1.textEdit78.Text + "^7" + f1.textEdit77.Text);
            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME);
            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("^5" + f1.textEdit82.Text + "^7" + f1.textEdit81.Text + "^3" + f1.textEdit80.Text + "^1" + f1.textEdit79.Text + "^3" + f1.textEdit78.Text + "^2" + f1.textEdit77.Text);
            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME1);
            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("^3" + f1.textEdit82.Text + "^6" + f1.textEdit81.Text + "^8" + f1.textEdit80.Text + "^2" + f1.textEdit79.Text + "^4" + f1.textEdit78.Text + "^1" + f1.textEdit77.Text);
            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME2);
            System.Threading.Thread.Sleep(10);
        }
        public void SkipperName(Form1 f1)
        {
            if (f1.groupControl29.Text.Contains("00:00:00."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit43.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl29.Text.Contains("00:00:01."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit42.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl29.Text.Contains("00:00:02."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit41.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl29.Text.Contains("00:00:03."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit40.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl29.Text.Contains("00:00:04."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit39.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl29.Text.Contains("00:00:05."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit38.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, CT);
            }
        }
        public void NameSlider(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("    " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME);

            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("      " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME1);

            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("       " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME2);

            System.Threading.Thread.Sleep(10);
            byte[] NAME3 = Encoding.ASCII.GetBytes("        " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME3, NAME3.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME3);

            System.Threading.Thread.Sleep(10);

            byte[] NAME4 = Encoding.ASCII.GetBytes("         " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME4, NAME4.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME4);

            System.Threading.Thread.Sleep(10);


            byte[] NAME5 = Encoding.ASCII.GetBytes("           " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME5, NAME5.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME5);

            System.Threading.Thread.Sleep(10);

            byte[] NAME6 = Encoding.ASCII.GetBytes("             " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME6, NAME6.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME6);

            System.Threading.Thread.Sleep(10);


            byte[] NAME7 = Encoding.ASCII.GetBytes("           " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME7, NAME7.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME7);

            System.Threading.Thread.Sleep(10);

            byte[] NAME8 = Encoding.ASCII.GetBytes("         " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME8, NAME8.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME8);

            System.Threading.Thread.Sleep(10);

            byte[] NAME9 = Encoding.ASCII.GetBytes("       " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME9);

            System.Threading.Thread.Sleep(10);
            byte[] NAME11 = Encoding.ASCII.GetBytes("     " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME11, NAME11.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME11);

            System.Threading.Thread.Sleep(10);

            byte[] NAME111 = Encoding.ASCII.GetBytes("   " + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME111, NAME111.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME111);

            System.Threading.Thread.Sleep(10);

            byte[] NAME12 = Encoding.ASCII.GetBytes(" " + f1.textEdit37.Text + "                ");

            Array.Resize(ref NAME12, NAME12.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME12);

            System.Threading.Thread.Sleep(10);
            byte[] NAME13 = Encoding.ASCII.GetBytes("" + f1.textEdit37.Text + "               ");

            Array.Resize(ref NAME13, NAME13.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Nonhost.Name, NAME13);

            System.Threading.Thread.Sleep(10);
        }
        public void ColoredClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Custom 10");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^4Custom 9");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^3Custom 8,");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^2Custom 7");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^1Custom 6");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^5Custom 5");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^4Custom 4");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^3Custom 3");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^2Custom 2");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1Custom 1");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class1, bytes9);
        }
        public void CreatorClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Content :)");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^2Updates and More");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^1Subscribe For,");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^6Running Fox");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^5Thanks For Using");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^0BrandonCardenWV");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^3Instagram @");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^2Follow Me on");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^4AKA, Brandon");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1XxBlud-23xX");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class1, bytes9);
        }
        public void SetAllClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class10, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class9, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class8, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class7, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class6, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class5, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class4, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class3, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class2, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClassNames.Class1, bytes);
        }
        public void InvisibleWeaponOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.InvisibleWeapon + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x01 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.InvisibleWeapon + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x01 });
            }
        }
        public void InvisibleWeaponON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.InvisibleWeapon + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.InvisibleWeapon + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
            }
        }
        public void BloodyVisionOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.BloodyVision + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.BloodyVision + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
            }
        }
        public void BloodyVisionON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.BloodyVision + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x02 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.BloodyVision + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x02 });
            }
        }
        public void CrouchOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.Crouch + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x60 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.Crouch + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x60 });
            }
        }
        public void CrouchON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.Crouch + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.Crouch + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
            }
        }
        public void CrossHairSizeOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.CrosshairSize + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x40, 0x40, 0x40 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.CrosshairSize + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x40, 0x40, 0x40 });
            }
        }
        public void CrossHairSize(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.CrosshairSize + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x80, 0x66, 0x66 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.CrosshairSize + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x80, 0x66, 0x66 });
            }
        }
        public void LagOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PlayerLag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x02 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PlayerLag + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x02 });
            }
        }
        public void LagON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PlayerLag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0xFF });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PlayerLag + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0xFF });
            }
        }
        public void FreezeOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
            }
        }
        public void FreezeON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x01 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x01 });
            }
        }
        public void UFOModeOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.UFOMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.UFOMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
            }
        }
        public void UFOModeON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.UFOMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x02 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.UFOMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x02 });
            }
        }
        public void WeirdGunOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.WeirdGun + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x02 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.WeirdGun + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x02 });
            }
        }
        public void WeirdGunON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.WeirdGun + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x01 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.WeirdGun + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x01 });
            }
        }
        public void DrunkVisionOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.DrunkVision + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x02 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.DrunkVision + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x02 });
            }
        }
        public void DrunkVisionON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.DrunkVision + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0xFF });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.DrunkVision + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0xFF });
            }
        }
        public void StandUpOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.StandUp + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.StandUp + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
            }
        }
        public void StandUpON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.StandUp + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x60 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.StandUp + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x60 });
            }
        }
        public void NoClipOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NoClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NoClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x00 });
            }
        }
        public void NoClipON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NoClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x01 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NoClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x01 });
            }
        }
        public void DoubleSpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SpeedX2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x3F });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SpeedX2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x3F });
            }
        }
        public void DoubleSpeedON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SpeedX2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x40 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SpeedX2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x40 });
            }
        }
        public void AmmoOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PrimaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PrimaryLeftAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SideArmClipAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SideArmLeftAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.TacticalAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.GrenadeAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PrimaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PrimaryLeftAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SideArmClipAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SideArmLeftAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.TacticalAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.GrenadeAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x64 });
            }
        }
        public void AmmoON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PrimaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PrimaryLeftAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SideArmClipAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SideArmLeftAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.GrenadeAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.TacticalAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PrimaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.PrimaryLeftAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SideArmClipAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.SideArmLeftAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.GrenadeAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.TacticalAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x0F });
            }
        }
        public void GodModeOFF(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.GodMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x03 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.GodMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x03 });
            }
        }
        public void GodModeON(Form1 f1)
        {
            if (f1.listBoxControl2.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.GodMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x08 });
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.GodMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient), new byte[] { 0x08 });
            }
        }
    }
}
