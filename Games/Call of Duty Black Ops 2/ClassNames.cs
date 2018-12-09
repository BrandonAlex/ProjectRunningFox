using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2
{
    public static class ClassNames
    {
        public static void ColoredClasses(Form1 f1)
        {
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class1, "^1Custom 1");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class2, "^2Custom 2");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class3, "^3Custom 3");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class4, "^4Custom 4");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class5, "^5Custom 5");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class6, "^1Custom 6");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class7, "^2Custom 7");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class8, "^3Custom 8");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class9, "^4Custom 9");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class10, "^5Custom 10");
        }
        public static void CreatorClasses(Form1 f1)
        {
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class1, "^1XxBlud-23xX");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class2, "^1XxBlud-23xX");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class3, "^1XxBlud-23xX");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class4, "^1XxBlud-23xX");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class5, "^1XxBlud-23xX");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class6, "^1XxBlud-23xX");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class7, "^1XxBlud-23xX");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class8, "^1XxBlud-23xX");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class9, "^1XxBlud-23xX");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class10, "^1XxBlud-23xX");
        }
        public static void PrfClasses(Form1 f1)
        {
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class1, "^1Running Fox RTM");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class2, "^1Running Fox RTM");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class3, "^1Running Fox RTM");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class4, "^1Running Fox RTM");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class5, "^1Running Fox RTM");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class6, "^1Running Fox RTM");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class7, "^1Running Fox RTM");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class8, "^1Running Fox RTM");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class9, "^1Running Fox RTM");
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class10, "^1Running Fox RTM");
        }
        public static void AllClasses(Form1 f1)
        {
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class1, f1.textEdit323.Text);
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class2, f1.textEdit323.Text);
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class3, f1.textEdit323.Text);
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class4, f1.textEdit323.Text);
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class5, f1.textEdit323.Text);
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class6, f1.textEdit323.Text);
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class7, f1.textEdit323.Text);
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class8, f1.textEdit323.Text);
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class9, f1.textEdit323.Text);
            SetClass(Games.Call_of_Duty_Black_Ops_2.offsets.Classes.Class10, f1.textEdit323.Text);
        }
        public static byte[] Multiply1(this byte[] A, byte[] B)
        {
            List<byte> list = new List<byte>();
            int num = 0;
            for (int i = 0; i < A.Length; i++)
            {
                byte b = 0;
                for (int j = 0; j < B.Length; j++)
                {
                    short num2 = (short)(A[i] * B[j] + b);
                    b = (byte)(num2 >> 8);
                    byte b2 = (byte)num2;
                    num = i + j;
                    if (num < list.Count)
                    {
                        list = ClassNames._add_(list, b2, num, 0);
                    }
                    else
                    {
                        list.Add(b2);
                    }
                }
                if (b > 0)
                {
                    if (num + 1 < list.Count)
                    {
                        list = ClassNames._add_(list, b, num + 1, 0);
                    }
                    else
                    {
                        list.Add(b);
                    }
                }
            }
            return list.ToArray();
        }
        private static List<byte> _add_(List<byte> A, byte b, int idx = 0, byte rem = 0)
        {
            List<byte> result;
            if (idx < A.Count)
            {
                short num = (short)(A[idx] + b);
                A[idx] = (byte)(num % 256);
                rem = (byte)((num - (short)A[idx]) % 255);
                if (rem > 0)
                {
                    result = ClassNames._add_(A, rem, idx + 1, 0);
                    return result;
                }
            }
            else
            {
                A.Add(b);
            }
            result = A;
            return result;
        }
        public static void SetMem(uint Offset, byte[] value)
        {
            Form1.PS3.SetMemory(Offset, value);
        }
        public static void SetClass(uint offset, string input)
        {
            SetMem(offset, new byte[16]);
            byte[] b = new byte[] { 4 };
            byte[] bytes = Encoding.ASCII.GetBytes(input);
            SetMem(offset, bytes.Multiply1(b));
        }
    }
}