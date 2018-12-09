using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3
{
    class SetMod
    {
        public void RainBowName(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("^1" + f1.textEdit295.Text + "^4" + f1.textEdit294.Text + "^3" + f1.textEdit293.Text + "^5" + f1.textEdit292.Text + "^6" + f1.textEdit291.Text + "^7" + f1.textEdit290.Text);
            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME);
            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("^5" + f1.textEdit295.Text + "^7" + f1.textEdit294.Text + "^3" + f1.textEdit293.Text + "^1" + f1.textEdit292.Text + "^3" + f1.textEdit291.Text + "^2" + f1.textEdit290.Text);
            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME1);
            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("^3" + f1.textEdit295.Text + "^6" + f1.textEdit294.Text + "^8" + f1.textEdit293.Text + "^2" + f1.textEdit292.Text + "^4" + f1.textEdit291.Text + "^1" + f1.textEdit290.Text);
            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME2);
            System.Threading.Thread.Sleep(10);
        }
        public void NameSkipper(Form1 f1)
        {
            if (f1.groupControl198.Text.Contains("00:00:00."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit296.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, CT);
            }
            if (f1.groupControl198.Text.Contains("00:00:01."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit297.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, CT);
            }
            if (f1.groupControl198.Text.Contains("00:00:02."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit298.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, CT);
            }
            if (f1.groupControl198.Text.Contains("00:00:03."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit299.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, CT);
            }
            if (f1.groupControl198.Text.Contains("00:00:04."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit300.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, CT);
            }
            if (f1.groupControl198.Text.Contains("00:00:05."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit301.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, CT);
            }
        }
        public void NameSlider(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("    " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME);

            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("      " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME1);

            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("       " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME2);

            System.Threading.Thread.Sleep(10);
            byte[] NAME3 = Encoding.ASCII.GetBytes("        " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME3, NAME3.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME3);

            System.Threading.Thread.Sleep(10);

            byte[] NAME4 = Encoding.ASCII.GetBytes("         " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME4, NAME4.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME4);

            System.Threading.Thread.Sleep(10);


            byte[] NAME5 = Encoding.ASCII.GetBytes("           " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME5, NAME5.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME5);

            System.Threading.Thread.Sleep(10);

            byte[] NAME6 = Encoding.ASCII.GetBytes("             " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME6, NAME6.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME6);

            System.Threading.Thread.Sleep(10);


            byte[] NAME7 = Encoding.ASCII.GetBytes("           " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME7, NAME7.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME7);

            System.Threading.Thread.Sleep(10);

            byte[] NAME8 = Encoding.ASCII.GetBytes("         " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME8, NAME8.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME8);

            System.Threading.Thread.Sleep(10);

            byte[] NAME9 = Encoding.ASCII.GetBytes("       " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME9);

            System.Threading.Thread.Sleep(10);
            byte[] NAME11 = Encoding.ASCII.GetBytes("     " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME11, NAME11.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME11);

            System.Threading.Thread.Sleep(10);

            byte[] NAME111 = Encoding.ASCII.GetBytes("   " + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME111, NAME111.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME111);

            System.Threading.Thread.Sleep(10);

            byte[] NAME12 = Encoding.ASCII.GetBytes(" " + f1.textEdit302.Text + "                ");

            Array.Resize(ref NAME12, NAME12.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME12);

            System.Threading.Thread.Sleep(10);
            byte[] NAME13 = Encoding.ASCII.GetBytes("" + f1.textEdit302.Text + "               ");

            Array.Resize(ref NAME13, NAME13.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NonHost.Name, NAME13);

            System.Threading.Thread.Sleep(10);
        }
        public void ColoredClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Custom 10");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^4Custom 9");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^3Custom 8,");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^2Custom 7");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^1Custom 6");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^5Custom 5");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^4Custom 4");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^3Custom 3");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^2Custom 2");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1Custom 1");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class1, bytes9);
        }
        public void CreatorClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Content :)");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^2Updates and More");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^1Subscribe For,");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^6Running Fox");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^5Thanks For Using");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^0BrandonCardenWV");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^3Instagram @");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^2Follow Me on");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^4AKA, Brandon");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1XxBlud-23xX");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class1, bytes9);
        }
        public void PRFClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class10, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class9, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class8, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class7, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class6, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class5, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class4, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class3, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class2, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class1, bytes);
        }
        public void SetAllClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit288.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class1, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class2, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class3, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class4, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class5, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class6, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class7, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class8, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class9, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ClassNames.Class10, bytes);
        }
        public void AmmoOFF(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.PrimaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SecondaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.LethalAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.TatcticalAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.PrimaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SecondaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Unlimited Ammo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.PrimaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SecondaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.LethalAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.TatcticalAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.PrimaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SecondaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Unlimited Ammo ^1Off");
            }
        }
        public void AmmoOn(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.PrimaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SecondaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.LethalAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.TatcticalAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.PrimaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SecondaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.PrimaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SecondaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.LethalAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.TatcticalAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.PrimaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SecondaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Unlimited Ammo ^2On");
            }
        }
        public void LastStandOFF(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.LastStand + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Last Stand ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.LastStand + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Last Stand ^1Off");
            }
        }
        public void LastStandON(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.LastStand + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Last Stand ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.LastStand + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Last Stand ^2On");
            }
        }
        public void UAVOFF(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.UAV + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "UAV ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.UAV + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "UAV ^1Off");
            }
        }
        public void UAVON(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.UAV + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "UAV ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.UAV + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "UAV ^2On");
            }
        }
        public void DoubleSpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.X2Speed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x3F });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Speed X2 ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.X2Speed + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x3F });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Speed X2 ^1Off");
            }
        }
        public void DoubleSpeedON(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.X2Speed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x40 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Speed X2 ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.X2Speed + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x40 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Speed X2 ^2On");
            }
        }
        public void SpecialistOFF(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.GiveSpecialist + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Give Specialist ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.GiveSpecialist + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Give Specialist ^1Off");
            }
        }
        public void SpecialistON(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.GiveSpecialist + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Give Specialist ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.GiveSpecialist + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Give Specialist ^2On");
            }
        }
        public void VisibilityON(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Visibility + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Visibility ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Visibility + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Visibility ^2On");
            }
        }
        public void VisibilityOFF(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Visibility + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Visibility ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.Visibility + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Visibility ^1Off");
            }
        }
        public void HUDON(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.HUD + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "HUD ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.HUD + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "HUD ^2On");
            }
        }
        public void HUDOFF(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.HUD + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "HUD ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.HUD + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "HUD ^1Off");
            }
        }
        public void SkateModOFF(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SkateMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Skate Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SkateMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Skate Mode ^1Off");
            }
        }
        public void SkateModON(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SkateMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Skate Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.SkateMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Skate Mode ^2On");
            }
        }
        public void ThirdPersonOFF(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ThirdPerson + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Third Person ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ThirdPerson + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Third Person ^1Off");
            }
        }
        public void ThirdPersonON(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ThirdPerson + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "Third Person ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.ThirdPerson + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Third Person ^2On");
            }
        }
        public void GodModeOFF(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.GodMod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x04 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "God Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.GodMod + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x04 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }
        public void GodModeON(Form1 f1)
        {
            if (f1.listBoxControl11.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.GodMod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x05 });
                    ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(i, "God Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.GodMod + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient), new byte[] { 0x05 });
                ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }
    }
}
