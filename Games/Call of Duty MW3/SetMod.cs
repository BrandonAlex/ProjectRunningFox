using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_MW3
{
    class SetMod
    {
        public void RainBowName(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("^1" + f1.textEdit103.Text + "^2" + f1.textEdit102.Text + "^3" + f1.textEdit101.Text + "^5" + f1.textEdit100.Text + "^6" + f1.textEdit99.Text + "^7" + f1.textEdit98.Text);
            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME);
            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("^5" + f1.textEdit103.Text + "^7" + f1.textEdit102.Text + "^3" + f1.textEdit101.Text + "^1" + f1.textEdit100.Text + "^3" + f1.textEdit99.Text + "^2" + f1.textEdit98.Text);
            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME1);
            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("^3" + f1.textEdit103.Text + "^6" + f1.textEdit102.Text + "^8" + f1.textEdit101.Text + "^2" + f1.textEdit100.Text + "^4" + f1.textEdit99.Text + "^1" + f1.textEdit98.Text);
            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME2);
            System.Threading.Thread.Sleep(10);
        }
        public void NameSkipper(Form1 f1)
        {
            if (f1.groupControl82.Text.Contains("00:00:00."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit104.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl82.Text.Contains("00:00:01."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit105.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl82.Text.Contains("00:00:02."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit106.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl82.Text.Contains("00:00:03."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit107.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl82.Text.Contains("00:00:04."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit109.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl82.Text.Contains("00:00:05."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit108.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, CT);
            }
        }
        public void NameSlider(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("    " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME);

            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("      " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME1);

            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("       " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME2);

            System.Threading.Thread.Sleep(10);
            byte[] NAME3 = Encoding.ASCII.GetBytes("        " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME3, NAME3.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME3);

            System.Threading.Thread.Sleep(10);

            byte[] NAME4 = Encoding.ASCII.GetBytes("         " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME4, NAME4.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME4);

            System.Threading.Thread.Sleep(10);


            byte[] NAME5 = Encoding.ASCII.GetBytes("           " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME5, NAME5.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME5);

            System.Threading.Thread.Sleep(10);

            byte[] NAME6 = Encoding.ASCII.GetBytes("             " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME6, NAME6.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME6);

            System.Threading.Thread.Sleep(10);


            byte[] NAME7 = Encoding.ASCII.GetBytes("           " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME7, NAME7.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME7);

            System.Threading.Thread.Sleep(10);

            byte[] NAME8 = Encoding.ASCII.GetBytes("         " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME8, NAME8.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME8);

            System.Threading.Thread.Sleep(10);

            byte[] NAME9 = Encoding.ASCII.GetBytes("       " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME9);

            System.Threading.Thread.Sleep(10);
            byte[] NAME11 = Encoding.ASCII.GetBytes("     " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME11, NAME11.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME11);

            System.Threading.Thread.Sleep(10);

            byte[] NAME111 = Encoding.ASCII.GetBytes("   " + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME111, NAME111.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME111);

            System.Threading.Thread.Sleep(10);

            byte[] NAME12 = Encoding.ASCII.GetBytes(" " + f1.textEdit110.Text + "                ");

            Array.Resize(ref NAME12, NAME12.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME12);

            System.Threading.Thread.Sleep(10);
            byte[] NAME13 = Encoding.ASCII.GetBytes("" + f1.textEdit110.Text + "               ");

            Array.Resize(ref NAME13, NAME13.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Nonhost.Name, NAME13);

            System.Threading.Thread.Sleep(10);
        }
        public void ColoredClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Custom 10");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^4Custom 9");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^3Custom 8,");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^2Custom 7");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^1Custom 6");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^5Custom 5");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^4Custom 4");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^3Custom 3");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^2Custom 2");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1Custom 1");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class1, bytes9);
        }
            
        public void CreatorClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Content :)");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^2Updates and More");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^1Subscribe For,");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^6Running Fox");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^5Thanks For Using");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^0BrandonCardenWV");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^3Instagram @");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^2Follow Me on");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^4AKA, Brandon");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1XxBlud-23xX");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class1, bytes9);
        }
        public void SetAllClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class10, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class9, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class8, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class7, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class6, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class5, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class4, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class3, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class2, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClassNames.Class1, bytes);
        }
        public void RPCText2(Form1 f1)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(1, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(2, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(3, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(4, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(5, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(6, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(7, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(8, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(9, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(10, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(11, f1.textEdit96.Text);
        }
        public void NameInGame(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit97.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame1, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame2, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame3, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame4, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame5, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame6, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame7, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame8, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame9, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame10, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NameInGame11, bytes);
        }
        public void RPCText1(Form1 f1)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(0, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(1, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(2, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(3, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(4, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(5, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(6, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(7, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(8, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(9, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(10, f1.textEdit96.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW3.RPC.iPrintlnBold(11, f1.textEdit96.Text);
        }
        public void Suicide(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Suicide + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Suicide ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Suicide + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Suicide ^2On");
            }
        }
        public void UFOModeOFF(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.UFOMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "UFO Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.UFOMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "UFO Mode ^1Off");
            }
        }
        public void UFOModeON(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.UFOMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "UFO Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.UFOMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "UFO Mode ^2On");
            }
        }
        public void NightVisionOFF(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NightVision + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Night Vision ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NightVision + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Night Vision ^1Off");
            }
        }
        public void NightVision(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NightVision + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Night Vision ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NightVision + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Night Vision ^2On");
            }
        }
        public void FreezeOFF(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Freeze ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Freeze ^1Off");
            }
        }
        public void FreezeON(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x07 });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Freeze ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x07 });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Freeze ^2On");
            }
        }
        public void WallhackOFF(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.WallHack + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x02, 0x81 });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Wall Hack ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.WallHack + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x02, 0x81 });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Wall Hack ^1Off");
            }
        }
        public void WallhackON(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.WallHack + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x01, 0x2c });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Wall Hack ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.WallHack + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x01, 0x2c });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Wall Hack ^2On");
            }
        }
        public void LaserOFF(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Laser + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Laser ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Laser + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Laser ^1Off");
            }
        }
        public void LaserOn(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Laser + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Laser ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Laser + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Laser ^2On");
            }
        }
        public void AmmoOFF(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.PrimaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.SecondaryOffset + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Lethal + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Tatical + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x64 });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Unlimited Ammo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.PrimaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.SecondaryOffset + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Lethal + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Tatical + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x64 });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Unlimited Ammo ^1Off");
            }
        }
        public void AmmoON(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.PrimaryAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.SecondaryOffset + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Lethal + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Tatical + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.PrimaryAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.SecondaryOffset + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Lethal + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.Tatical + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "Unlimited Ammo ^2On");
            }
        }
        public void GodModeOFF(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.GodMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "God Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.GodMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }
        public void GodModeON(Form1 f1)
        {
            if (f1.listBoxControl4.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.GodMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(i, "God Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.GodMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient), new byte[] { 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_MW3.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }
    }
}
