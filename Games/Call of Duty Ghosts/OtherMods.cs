using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Ghosts
{
    class OtherMods
    {
        public void RainBowName(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("^1" + f1.textEdit251.Text + "^2" + f1.textEdit250.Text + "^3" + f1.textEdit249.Text + "^5" + f1.textEdit248.Text + "^6" + f1.textEdit247.Text + "^7" + f1.textEdit246.Text);
            Array.Resize(ref NAME, NAME.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME);
            System.Threading.Thread.Sleep(10);
            byte[] NAME1 = Encoding.ASCII.GetBytes("^5" + f1.textEdit251.Text + "^7" + f1.textEdit250.Text + "^;" + f1.textEdit249.Text + "^1" + f1.textEdit248.Text + "^3" + f1.textEdit247.Text + "^2" + f1.textEdit246.Text);
            Array.Resize(ref NAME1, NAME1.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME1);
            System.Threading.Thread.Sleep(10);
            byte[] NAME2 = Encoding.ASCII.GetBytes("^3" + f1.textEdit251.Text + "^6;" + f1.textEdit250.Text + "^8" + f1.textEdit249.Text + "^2" + f1.textEdit248.Text + "^;" + f1.textEdit247.Text + "^1" + f1.textEdit246.Text);
            Array.Resize(ref NAME2, NAME2.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME2);
            System.Threading.Thread.Sleep(10);
        }
        public void NameSkipper(Form1 f1)
        {
            if (f1.groupControl165.Text.Contains("00:00:00."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit252.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl165.Text.Contains("00:00:01."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit253.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl165.Text.Contains("00:00:02."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit254.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl165.Text.Contains("00:00:03."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit255.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl165.Text.Contains("00:00:04."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit256.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, CT);
            }
            if (f1.groupControl165.Text.Contains("00:00:05."))
            {
                byte[] CT = Encoding.ASCII.GetBytes(f1.textEdit257.Text);
                Array.Resize(ref CT, CT.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, CT);
            }
        }
        public void NameSlider(Form1 f1)
        {
            byte[] NAME = Encoding.ASCII.GetBytes("    " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME);

            System.Threading.Thread.Sleep(10);

            byte[] NAME1 = Encoding.ASCII.GetBytes("      " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME1, NAME1.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME1);

            System.Threading.Thread.Sleep(10);

            byte[] NAME2 = Encoding.ASCII.GetBytes("       " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME2, NAME2.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME2);

            System.Threading.Thread.Sleep(10);

            byte[] NAME3 = Encoding.ASCII.GetBytes("        " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME3, NAME3.Length + 1);


            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME3);

            System.Threading.Thread.Sleep(10);

            byte[] NAME4 = Encoding.ASCII.GetBytes("         " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME4, NAME4.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME4);

            System.Threading.Thread.Sleep(10);

            byte[] NAME5 = Encoding.ASCII.GetBytes("           " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME5, NAME5.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME5);

            System.Threading.Thread.Sleep(10);

            byte[] NAME6 = Encoding.ASCII.GetBytes("             " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME6, NAME6.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME6);

            System.Threading.Thread.Sleep(10);

            byte[] NAME7 = Encoding.ASCII.GetBytes("           " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME7, NAME7.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME7);

            System.Threading.Thread.Sleep(10);

            byte[] NAME8 = Encoding.ASCII.GetBytes("         " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME8, NAME8.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME8);

            System.Threading.Thread.Sleep(10);

            byte[] NAME9 = Encoding.ASCII.GetBytes("       " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME, NAME.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME9);

            System.Threading.Thread.Sleep(10);

            byte[] NAME11 = Encoding.ASCII.GetBytes("     " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME11, NAME11.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME11);

            System.Threading.Thread.Sleep(10);

            byte[] NAME111 = Encoding.ASCII.GetBytes("   " + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME111, NAME111.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME111);

            System.Threading.Thread.Sleep(10);

            byte[] NAME12 = Encoding.ASCII.GetBytes(" " + f1.textEdit258.Text + "                ");

            Array.Resize(ref NAME12, NAME12.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME12);

            System.Threading.Thread.Sleep(10);

            byte[] NAME13 = Encoding.ASCII.GetBytes("" + f1.textEdit258.Text + "               ");

            Array.Resize(ref NAME13, NAME13.Length + 1);

            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Nonhost.Name, NAME13);

            System.Threading.Thread.Sleep(10);
        }
        public void ColoredClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Custom 10");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^4Custom 9");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^3Custom 8,");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^2Custom 7");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^1Custom 6");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^5Custom 5");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^4Custom 4");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^3Custom 3");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^2Custom 2");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1Custom 1");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1, bytes9);
        }
        public void CreatorClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Content :)");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10, bytes);
            byte[] bytes1 = Encoding.ASCII.GetBytes("^2Updates and More");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9, bytes1);
            byte[] bytes2 = Encoding.ASCII.GetBytes("^1Subscribe For,");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8, bytes2);
            byte[] bytes3 = Encoding.ASCII.GetBytes("^6Running Fox");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7, bytes3);
            byte[] bytes4 = Encoding.ASCII.GetBytes("^5Thanks For Using");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6, bytes4);
            byte[] bytes5 = Encoding.ASCII.GetBytes("^0BrandonCardenWV");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5, bytes5);
            byte[] bytes6 = Encoding.ASCII.GetBytes("^3Instagram @");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4, bytes6);
            byte[] bytes7 = Encoding.ASCII.GetBytes("^2Follow Me on");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3, bytes7);
            byte[] bytes8 = Encoding.ASCII.GetBytes("^4AKA, Brandon");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2, bytes8);
            byte[] bytes9 = Encoding.ASCII.GetBytes("^1XxBlud-23xX");
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1, bytes9);
        }
        public void PRFClasses(Form1 f1)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1Running Fox RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2, bytes);
            Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1, bytes);
        }
        public void SetAllClasses(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit243.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit243.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + 0x564, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + 0x564, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + 0x564, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + 0x564, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + 0x564, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + 0x564, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + 0x564, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + 0x564, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + 0x564, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit243.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + 0x564 * 2, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + 0x564 * 2, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + 0x564 * 2, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + 0x564 * 2, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + 0x564 * 2, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + 0x564 * 2, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + 0x564 * 2, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + 0x564 * 2, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + 0x564 * 2, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + 0x564 * 2, bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit243.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + 0x564 * 3, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + 0x564 * 3, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + 0x564 * 3, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + 0x564 * 3, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + 0x564 * 3, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + 0x564 * 3, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + 0x564 * 3, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + 0x564 * 3, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + 0x564 * 3, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + 0x564 * 3, bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit243.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + 0x564 * 4, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + 0x564 * 4, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + 0x564 * 4, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + 0x564 * 4, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + 0x564 * 4, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + 0x564 * 4, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + 0x564 * 4, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + 0x564 * 4, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + 0x564 * 4, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + 0x564 * 4, bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit243.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + 0x564 * 5, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + 0x564 * 5, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + 0x564 * 5, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + 0x564 * 5, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + 0x564 * 5, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + 0x564 * 5, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + 0x564 * 5, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + 0x564 * 5, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + 0x564 * 5, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + 0x564 * 5, bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit243.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + 0x564 * 6, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + 0x564 * 6, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + 0x564 * 6, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + 0x564 * 6, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + 0x564 * 6, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + 0x564 * 6, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + 0x564 * 6, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + 0x564 * 6, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + 0x564 * 6, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + 0x564 * 6, bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit243.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + 0x564 * 7, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + 0x564 * 7, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + 0x564 * 7, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + 0x564 * 7, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + 0x564 * 7, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + 0x564 * 7, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + 0x564 * 7, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + 0x564 * 7, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + 0x564 * 7, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + 0x564 * 7, bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit243.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + 0x564 * 8, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + 0x564 * 8, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + 0x564 * 8, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + 0x564 * 8, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + 0x564 * 8, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + 0x564 * 8, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + 0x564 * 8, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + 0x564 * 8, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + 0x564 * 8, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + 0x564 * 8, bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit243.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + 0x564 * 9, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + 0x564 * 9, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + 0x564 * 9, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + 0x564 * 9, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + 0x564 * 9, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + 0x564 * 9, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + 0x564 * 9, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + 0x564 * 9, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + 0x564 * 9, bytes);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + 0x564 * 9, bytes);
            }
        }
        public void SetClass10(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit233.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit233.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit233.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + (0x564 * 2), bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit233.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + (0x564 * 3), bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit233.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + (0x564 * 4), bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit233.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + (0x564 * 5), bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit233.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + (0x564 * 6), bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit233.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + (0x564 * 7), bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit233.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + (0x564 * 8), bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit233.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class10 + (0x564 * 9), bytes);
            }
        }
        public void SetClass9(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit234.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit234.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit234.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + (0x564 * 2), bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit234.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + (0x564 * 3), bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit234.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + (0x564 * 4), bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit234.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + (0x564 * 5), bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit234.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + (0x564 * 6), bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit234.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + (0x564 * 7), bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit234.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + (0x564 * 8), bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit234.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class9 + (0x564 * 9), bytes);
            }
        }
        public void SetClass8(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit235.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit235.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit235.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + (0x564 * 2), bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit235.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + (0x564 * 3), bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit235.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + (0x564 * 4), bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit235.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + (0x564 * 5), bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit235.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + (0x564 * 6), bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit235.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + (0x564 * 7), bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit235.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + (0x564 * 8), bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit235.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class8 + (0x564 * 9), bytes);
            }
        }
        public void SetClass7(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit236.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit236.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit236.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + (0x564 * 2), bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit236.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + (0x564 * 3), bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit236.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + (0x564 * 4), bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit236.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + (0x564 * 5), bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit236.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + (0x564 * 6), bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit236.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + (0x564 * 7), bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit236.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + (0x564 * 8), bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit236.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class7 + (0x564 * 9), bytes);
            }
        }
        public void SetClass6(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit237.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit237.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit237.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + (0x564 * 2), bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit237.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + (0x564 * 3), bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit237.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + (0x564 * 4), bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit237.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + (0x564 * 5), bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit237.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + (0x564 * 6), bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit237.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + (0x564 * 7), bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit237.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + (0x564 * 8), bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit237.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class6 + (0x564 * 9), bytes);
            }
        }
        public void SetClass5(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit238.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit238.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit238.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + (0x564 * 2), bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit238.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + (0x564 * 3), bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit238.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + (0x564 * 4), bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit238.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + (0x564 * 5), bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit238.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + (0x564 * 6), bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit238.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + (0x564 * 7), bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit238.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + (0x564 * 8), bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit238.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class5 + (0x564 * 9), bytes);
            }
        }
        public void SetClass4(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit239.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit239.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit239.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + (0x564 * 2), bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit239.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + (0x564 * 3), bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit239.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + (0x564 * 4), bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit239.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + (0x564 * 5), bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit239.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + (0x564 * 6), bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit239.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + (0x564 * 7), bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit239.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + (0x564 * 8), bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit239.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class4 + (0x564 * 9), bytes);
            }
        }
        public void SetClass3(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit240.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit240.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit240.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + (0x564 * 2), bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit240.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + (0x564 * 3), bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit240.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + (0x564 * 4), bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit240.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + (0x564 * 5), bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit240.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + (0x564 * 6), bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit240.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + (0x564 * 7), bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit240.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + (0x564 * 8), bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit240.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class3 + (0x564 * 9), bytes);
            }
        }
        public void SetClass2(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit241.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit241.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit241.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + (0x564 * 2), bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit241.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + (0x564 * 3), bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit241.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + (0x564 * 4), bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit241.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + (0x564 * 5), bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit241.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + (0x564 * 6), bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit241.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + (0x564 * 7), bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit241.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + (0x564 * 8), bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit241.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class2 + (0x564 * 9), bytes);
            }
        }
        public void SetClass1(Form1 f1)
        {
            if (f1.spinEdit155.Value == 1)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit242.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1, bytes);
            }
            if (f1.spinEdit155.Value == 2)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit242.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + 0x564, bytes);
            }
            if (f1.spinEdit155.Value == 3)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit242.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + (0x564 * 2) , bytes);
            }
            if (f1.spinEdit155.Value == 4)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit242.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + (0x564 * 3), bytes);
            }
            if (f1.spinEdit155.Value == 5)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit242.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + (0x564 * 4), bytes);
            }
            if (f1.spinEdit155.Value == 6)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit242.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + (0x564 * 5), bytes);
            }
            if (f1.spinEdit155.Value == 7)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit242.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + (0x564 * 6), bytes);
            }
            if (f1.spinEdit155.Value == 8)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit242.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + (0x564 * 7), bytes);
            }
            if (f1.spinEdit155.Value == 9)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit242.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + (0x564 * 8), bytes);
            }
            if (f1.spinEdit155.Value == 10)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(f1.textEdit242.Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Form1.PS3.SetMemory(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClassNames.Class1 + (0x564 * 9), bytes);
            }
        }
    }
}
