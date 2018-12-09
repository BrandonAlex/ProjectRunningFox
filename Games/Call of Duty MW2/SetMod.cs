using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_MW2
{
    class SetMod
    {
        public void RainBowName(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("^1" + f1.textEdit54.Text + "^2" + f1.textEdit53.Text + "^3" + f1.textEdit52.Text + "^5" + f1.textEdit51.Text + "^6" + f1.textEdit50.Text + "^7" + f1.textEdit49.Text);
            Array.Resize(ref NAME, NAME.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME);
            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("^5" + f1.textEdit54.Text + "^7" + f1.textEdit53.Text + "^3" + f1.textEdit52.Text + "^1" + f1.textEdit51.Text + "^3" + f1.textEdit50.Text + "^2" + f1.textEdit49.Text);
            Array.Resize(ref NAME1, NAME1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME1);
            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("^3" + f1.textEdit54.Text + "^6" + f1.textEdit53.Text + "^8" + f1.textEdit52.Text + "^2" + f1.textEdit51.Text + "^4" + f1.textEdit50.Text + "^1" + f1.textEdit49.Text);
            Array.Resize(ref NAME2, NAME2.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME2);
            System.Threading.Thread.Sleep(10);
        }
        public void SkipperName(Form1 f1)
        {
            if (f1.groupControl51.Text.Contains("00:00:00."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit55.Text);
                Array.Resize(ref CT, CT.Length + 1);
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl51.Text.Contains("00:00:01."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit57.Text);
                Array.Resize(ref CT, CT.Length + 1);
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl51.Text.Contains("00:00:02."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit58.Text);
                Array.Resize(ref CT, CT.Length + 1);
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl51.Text.Contains("00:00:03."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit59.Text);
                Array.Resize(ref CT, CT.Length + 1);
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl51.Text.Contains("00:00:04."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit61.Text);
                Array.Resize(ref CT, CT.Length + 1);
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl51.Text.Contains("00:00:05."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit60.Text);
                Array.Resize(ref CT, CT.Length + 1);
                PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, CT);
            }
        }
        public void NameSlider(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("    " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME);

            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("      " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME1, NAME1.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME1);

            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("       " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME2, NAME2.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME2);

            System.Threading.Thread.Sleep(10);
            byte[] NAME3 = Encoding.ASCII.GetBytes("        " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME3, NAME3.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME3);

            System.Threading.Thread.Sleep(10);

            byte[] NAME4 = Encoding.ASCII.GetBytes("         " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME4, NAME4.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME4);

            System.Threading.Thread.Sleep(10);


            byte[] NAME5 = Encoding.ASCII.GetBytes("           " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME5, NAME5.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME5);

            System.Threading.Thread.Sleep(10);

            byte[] NAME6 = Encoding.ASCII.GetBytes("             " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME6, NAME6.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME6);

            System.Threading.Thread.Sleep(10);


            byte[] NAME7 = Encoding.ASCII.GetBytes("           " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME7, NAME7.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME7);

            System.Threading.Thread.Sleep(10);

            byte[] NAME8 = Encoding.ASCII.GetBytes("         " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME8, NAME8.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME8);

            System.Threading.Thread.Sleep(10);

            byte[] NAME9 = Encoding.ASCII.GetBytes("       " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME9);

            System.Threading.Thread.Sleep(10);
            byte[] NAME11 = Encoding.ASCII.GetBytes("     " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME11, NAME11.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME11);

            System.Threading.Thread.Sleep(10);

            byte[] NAME111 = Encoding.ASCII.GetBytes("   " + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME111, NAME111.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME111);

            System.Threading.Thread.Sleep(10);

            byte[] NAME12 = Encoding.ASCII.GetBytes(" " + f1.textEdit62.Text + "                ");

            Array.Resize(ref NAME12, NAME12.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME12);

            System.Threading.Thread.Sleep(10);
            byte[] NAME13 = Encoding.ASCII.GetBytes("" + f1.textEdit62.Text + "               ");

            Array.Resize(ref NAME13, NAME13.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Nonhost.Name, NAME13);

            System.Threading.Thread.Sleep(10);
        }
        public class Buttonz
        {
            public static string
                DpadUp = "+actionslot 1",
                DpadDown = "+actionslot 2",
                DpadRight = "+actionslot 4",
                DpadLeft = "+actionslot 3",
                Cross = "+gostand",
                Circle = "+stance",
                Triangle = "weapnext",
                Square = "+usereload",
                R3 = "+melee",
                R2 = "+frag",
                R1 = "+attack",
                L3 = "+breath_sprint",
                L2 = "+smoke",
                L1 = "+speed_throw",
                Select = "togglescores",
                Start = "togglemenu";
        }
        public void SetAllNames(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit48.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame1, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame2, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame3, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame4, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame5, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame6, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame7, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame8, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame9, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame10, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NameInGame11, bytes);
        }
        public void RPCText2(Form1 f1)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(0, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(1, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(2, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(3, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(4, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(5, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(6, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(7, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(8, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(9, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(10, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.iPrintlnBold(11, f1.textEdit65.Text);
        }
        public void RPCText1(Form1 f1)
        {
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(1, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(2, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(3, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(4, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(5, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(6, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(7, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(8, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(9, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(10, f1.textEdit65.Text);
            ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(11, f1.textEdit65.Text);
        }
        public void ColoredClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Custom 10");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^4Custom 9");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^3Custom 8,");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^2Custom 7");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^1Custom 6");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^5Custom 5");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^4Custom 4");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^3Custom 3");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^2Custom 2");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1Custom 1");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class1, bytes9);
        }
        public void CreatorClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Content :)");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^2Updates and More");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^1Subscribe For,");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^6Running Fox");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^5Thanks For Using");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^0BrandonCardenWV");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^3Instagram @");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^2Follow Me on");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^4AKA, Brandon");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1XxBlud-23xX");
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class1, bytes9);
        }
        public void SetAllClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class10, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class9, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class8, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class7, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class6, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class5, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class4, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class3, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class2, bytes);
            PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClassNames.Class1, bytes);
        }
        public void EnableSprint(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Disable Sprint ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Disable Sprint ^1Off");
            }
        }
        public void DisableSprint(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Disable Sprint ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Disable Sprint ^2On");
            }
        }
        public void EnableJump(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Disable Jump ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Disable Jump ^1Off");
            }
        }
        public void DisableJump(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x04 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Disable Jump ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x04 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Disable Jump ^2On");
            }
        }
        public void AutoProneOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Auto Prone ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Auto Prone ^1Off");
            }
        }
        public void AutoProneON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x55 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Auto Prone ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Movement + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x55 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Auto Prone ^2On");
            }
        }
        public void TeleportUnderMap(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Teleport + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xC7, 0x5F });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "You have been teleported under the map.");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Teleport + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xC7, 0x5F });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "You have been teleported under the map.");
            }
        }
        public void TeleportToSpace(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Teleport + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x60, 0x5C });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "You have been teleported to space.");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Teleport + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x60, 0x5C });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "You have been teleported to space.");
            }
        }
        public void TeleportToSky(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Teleport + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x46, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "You have been teleported to the sky.");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Teleport + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x46, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "You have been teleported to the sky.");
            }
        }
        public void NightVisionOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NightVisionPressDown + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Night Vision ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NightVisionPressDown + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Night Vision ^1Off");
            }
        }
        public void NightVisionON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NightVisionPressDown + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Night Vision (Press Down) ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NightVisionPressDown + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Night Vision (Press Down} ^2On");
            }
        }
        public void AllPerksON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.AllPerks + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "All Perks ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.AllPerks + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "All Perks ^2On");
            }
        }
        public void ExplosiveBulletsOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.ExplosiveBullets + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x08 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Explosive Bullets ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.ExplosiveBullets + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x08 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Explosive Bullets ^1Off");
            }
        }
        public void ExplosiveBulletsON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.ExplosiveBullets + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xFF, 0xEF });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Explosive Bullets ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.ExplosiveBullets + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xFF, 0xEF });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Explosive Bullets ^2On");
            }
        }
        public void SkateModOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Skate + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Skate Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Skate + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Skate Mode ^1Off");
            }
        }
        public void SkateModON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Skate + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Skate Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Skate + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Skate Mode ^2On");
            }
        }
        public void SmallCrosshairOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SmallCrossHair + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Small Crosshair ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SmallCrossHair + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Small Crosshair ^1Off");
            }
        }
        public void SmallCrosshairON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SmallCrossHair + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Small Crosshair ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SmallCrossHair + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Small Crosshair ^2On");
            }
        }
        public void UFOModeOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "UFO Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "UFO Mode ^1Off");
            }
        }
        public void UFOModeON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "UFO Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "UFO Mode ^2On");
            }
        }
        public void KillClient(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Kill + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xC5 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "You have been killed!");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Kill + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xC5 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "You have been killed!");
            }
        }
        public void RedBoxesOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.RedBoxes + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Red Boxes ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.RedBoxes + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Red Boxes ^1Off");
            }
        }
        public void RedBoxesON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.RedBoxes + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x55 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Red Boxes ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.RedBoxes + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x55 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Red Boxes ^2On");
            }
        }
        public void LAGOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.WeaponAkimboSecondary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Lag ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.WeaponAkimboSecondary + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Lag ^1Off");
            }
        }
        public void LAGON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Lag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Lag ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Lag + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Lag ^2On");
            }
        }
        public void SecondaryAkimboOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.WeaponAkimboSecondary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Secondary Akimbo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.WeaponAkimboSecondary + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Secondary Akimbo ^1Off");
            }
        }
        public void SecondaryAkimboON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.WeaponAkimboSecondary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Secondary Akimbo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.WeaponAkimboSecondary + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Secondary Akimbo ^2On");
            }
        }
        public void PrimaryAkimboOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.WeaponAkimbo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Primary Akimbo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.WeaponAkimbo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Primary Akimbo ^1Off");
            }
        }
        public void PrimaryAkimboON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.WeaponAkimbo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Primary Akimbo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.WeaponAkimbo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Primary Akimbo ^2On");
            }
        }
        public void UAVOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.UAV + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "UAV ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.UAV + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "UAV ^1Off");
            }
        }
        public void UAVON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.UAV + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "UAV ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.UAV + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "UAV ^2On");
            }
        }
        public void MiniMapON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MiniMap + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "No MiniMap ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MiniMap + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "No MiniMap ^1Off");
            }
        }
        public void MiniMapOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MiniMap + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "No MiniMap ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MiniMap + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "No MiniMap ^2On");
            }
        }
        public void FreezeOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Freeze ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Freeze ^1Off");
            }
        }
        public void FreezeON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x04 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Freeze ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x04 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Freeze ^2On");
            }
        }
        public void NoClipOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "No Clip ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "No Clip ^1Off");
            }
        }
        public void NoClipON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "No Clip ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.MovementMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "No Clip ^2On");
            }
        }
        public void DoubleSpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SpeedX2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x3F });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Double Speed ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SpeedX2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x3F });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Double Speed ^1Off");
            }
        }
        public void DoubleSpeedON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SpeedX2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x40 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Double Speed ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SpeedX2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x40 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Double Speed ^2On");
            }
        }
        public void AmmoOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Primary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.PrimaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Secondary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SecondaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GrenadeAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GranadeLuncherAmmoBullets + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GranadeLuncherAmmoClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Equipment + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.AkimboPrimaryBullets + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.AkimboSecondaryWeapon + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Unlimited Ammo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Primary + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.PrimaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Secondary + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SecondaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GrenadeAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GranadeLuncherAmmoBullets + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GranadeLuncherAmmoClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Equipment + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.AkimboPrimaryBullets + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.AkimboSecondaryWeapon + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x00, 0x00, 0x64 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Unlimited Ammo ^1Off");
            }
        }
        public void AmmoON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Primary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.PrimaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Secondary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SecondaryClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GrenadeAmmo + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GranadeLuncherAmmoBullets + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GranadeLuncherAmmoClip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Equipment + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.AkimboPrimaryBullets + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.AkimboSecondaryWeapon + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Primary + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.PrimaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Secondary + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.SecondaryClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GrenadeAmmo + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GranadeLuncherAmmoBullets + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GranadeLuncherAmmoClip + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.Equipment + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.AkimboPrimaryBullets + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.AkimboSecondaryWeapon + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "Unlimited Ammo ^2On");
            }
        }
        public void GodModeOFF(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GodMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x64 });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "God Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GodMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0x00, 0x64 });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }
        public void GodModeON(Form1 f1)
        {
            if (f1.listBoxControl3.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GodMode + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(i, "God Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.GodMode + ((uint)ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.Client.NextClient), new byte[] { 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.RPCText.Set(0, ProjectRunningFox.Games.Call_of_Duty_MW2.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_MW2.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }
    }
}
