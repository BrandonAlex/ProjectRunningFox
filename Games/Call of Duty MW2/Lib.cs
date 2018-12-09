using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_MW2
{
    public class Lib
    {
        public static void And_Int32(uint address, int input)
        {
            int input2 = Lib.ReadInt32(address) & input;
            Lib.WriteInt32(address, input2);
        }
        public static bool CompareByteArray(byte[] a, byte[] b)
        {
            int num = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    num++;
                }
            }
            return num == a.Length;
        }
        public static void Or_Int32(uint address, int input)
        {
            int input2 = Lib.ReadInt32(address) | input;
            Lib.WriteInt32(address, input2);
        }
        public static bool ReadBool(uint address)
        {
            return ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 1)[0] != 0;
        }
        public static byte ReadByte(uint address)
        {
            return ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 1)[0];
        }
        public static byte[] ReadBytes(uint address, int length)
        {
            return ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, length);
        }
        public static double ReadDouble(uint address)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 8);
            Array.Reverse(memory, 0, 8);
            return BitConverter.ToDouble(memory, 0);
        }
        public static double[] ReadDouble(uint address, int length)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, length * 8);
            Lib.ReverseBytes(memory);
            double[] array = new double[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = (double)BitConverter.ToSingle(memory, (length - 1 - i) * 8);
            }
            return array;
        }
        public static short ReadInt16(uint address)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 2);
            Array.Reverse(memory, 0, 2);
            return BitConverter.ToInt16(memory, 0);
        }
        public static short[] ReadInt16(uint address, int length)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, length * 2);
            Lib.ReverseBytes(memory);
            short[] array = new short[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = BitConverter.ToInt16(memory, (length - 1 - i) * 2);
            }
            return array;
        }
        public static int ReadInt32(uint address)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 4);
            Array.Reverse(memory, 0, 4);
            return BitConverter.ToInt32(memory, 0);
        }
        public static int[] ReadInt32(uint address, int length)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, length * 4);
            Lib.ReverseBytes(memory);
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = BitConverter.ToInt32(memory, (length - 1 - i) * 4);
            }
            return array;
        }
        public static long ReadInt64(uint address)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 8);
            Array.Reverse(memory, 0, 8);
            return BitConverter.ToInt64(memory, 0);
        }
        public static long[] ReadInt64(uint address, int length)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, length * 8);
            Lib.ReverseBytes(memory);
            long[] array = new long[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = BitConverter.ToInt64(memory, (length - 1 - i) * 8);
            }
            return array;
        }
        public static sbyte ReadSByte(uint address)
        {
            return (sbyte)ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 1)[0];
        }
        public static sbyte[] ReadSBytes(uint address, int length)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, length);
            sbyte[] array = new sbyte[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = (sbyte)memory[i];
            }
            return array;
        }
        public static float ReadSingle(uint address)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 4);
            Array.Reverse(memory, 0, 4);
            return BitConverter.ToSingle(memory, 0);
        }
        public static float[] ReadSingle(uint address, int length)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, length * 4);
            Lib.ReverseBytes(memory);
            float[] array = new float[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = BitConverter.ToSingle(memory, (length - 1 - i) * 4);
            }
            return array;
        }
        public static string ReadString(uint address)
        {
            int num = 40;
            int num2 = 0;
            string text = "";
            do
            {
                byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address + (uint)num2, num);
                text += Encoding.UTF8.GetString(memory);
                num2 += num;
            }
            while (!text.Contains('\0'));
            int length = text.IndexOf('\0');
            string result = text.Substring(0, length);
            text = string.Empty;
            return result;
        }
        public static ushort ReadUInt16(uint address)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 2);
            Array.Reverse(memory, 0, 2);
            return BitConverter.ToUInt16(memory, 0);
        }
        public static ushort[] ReadUInt16(uint address, int length)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, length * 2);
            Lib.ReverseBytes(memory);
            ushort[] array = new ushort[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = BitConverter.ToUInt16(memory, (length - 1 - i) * 2);
            }
            return array;
        }
        public static uint ReadUInt32(uint address)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 4);
            Array.Reverse(memory, 0, 4);
            return BitConverter.ToUInt32(memory, 0);
        }
        public static uint[] ReadUInt32(uint address, int length)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, length * 4);
            Lib.ReverseBytes(memory);
            uint[] array = new uint[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = BitConverter.ToUInt32(memory, (length - 1 - i) * 4);
            }
            return array;
        }
        public static ulong ReadUInt64(uint address)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, 8);
            Array.Reverse(memory, 0, 8);
            return BitConverter.ToUInt64(memory, 0);
        }
        public static ulong[] ReadUInt64(uint address, int length)
        {
            byte[] memory = ProjectRunningFox.Games.Call_of_Duty_MW2.PS3.GetMemory(address, length * 8);
            Lib.ReverseBytes(memory);
            ulong[] array = new ulong[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = BitConverter.ToUInt64(memory, (length - 1 - i) * 8);
            }
            return array;
        }
        public static byte[] ReverseBytes(byte[] toReverse)
        {
            Array.Reverse(toReverse);
            return toReverse;
        }
        public static void WriteBool(uint address, bool input)
        {
            byte[] bytes = new byte[]
			{
				
			};
            Form1.PS3.SetMemory(address, bytes);
        }
        public static void WriteByte(uint address, byte input)
        {
            Form1.PS3.SetMemory(address, new byte[]
			{
				input
			});
        }
        public static void WriteBytes(uint address, byte[] input)
        {
            Form1.PS3.SetMemory(address, input);
        }
        public static bool WriteBytesToggle(uint Offset, byte[] On, byte[] Off)
        {
            bool flag = Lib.ReadByte(Offset) == On[0];
            Lib.WriteBytes(Offset, (!flag) ? On : Off);
            return flag;
        }
        public static void WriteDouble(uint address, double input)
        {
            byte[] array = new byte[8];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 8);
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteDouble(uint address, double[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 8];
            for (int i = 0; i < num; i++)
            {
                Lib.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 8);
            }
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteInt16(uint address, short input)
        {
            byte[] array = new byte[2];
            Lib.ReverseBytes(BitConverter.GetBytes(input)).CopyTo(array, 0);
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteInt16(uint address, short[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 2];
            for (int i = 0; i < num; i++)
            {
                Lib.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 2);
            }
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteInt32(uint address, int input)
        {
            byte[] array = new byte[4];
            Lib.ReverseBytes(BitConverter.GetBytes(input)).CopyTo(array, 0);
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteInt32(uint address, int[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 4];
            for (int i = 0; i < num; i++)
            {
                Lib.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 4);
            }
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteInt64(uint address, long input)
        {
            byte[] array = new byte[8];
            Lib.ReverseBytes(BitConverter.GetBytes(input)).CopyTo(array, 0);
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteInt64(uint address, long[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 8];
            for (int i = 0; i < num; i++)
            {
                Lib.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 8);
            }
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteSByte(uint address, sbyte input)
        {
            byte[] bytes = new byte[]
			{
				(byte)input
			};
            Form1.PS3.SetMemory(address, bytes);
        }
        public static void WriteSBytes(uint address, sbyte[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num];
            for (int i = 0; i < num; i++)
            {
                array[i] = (byte)input[i];
            }
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteSingle(uint address, float input)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteSingle(uint address, float[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 4];
            for (int i = 0; i < num; i++)
            {
                Lib.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 4);
            }
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteString(uint address, string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3.SetMemory(address, bytes);
        }
        public static void WriteUInt16(uint address, ushort input)
        {
            byte[] array = new byte[2];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 2);
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteUInt16(uint address, ushort[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 2];
            for (int i = 0; i < num; i++)
            {
                Lib.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 2);
            }
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteUInt32(uint address, uint input)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteUInt32(uint address, uint[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 4];
            for (int i = 0; i < num; i++)
            {
                Lib.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 4);
            }
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteUInt64(uint address, ulong input)
        {
            byte[] array = new byte[8];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 8);
            Form1.PS3.SetMemory(address, array);
        }
        public static void WriteUInt64(uint address, ulong[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 8];
            for (int i = 0; i < num; i++)
            {
                Lib.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 8);
            }
            Form1.PS3.SetMemory(address, array);
        }
        public static string char_to_wchar(string text)
        {
            string text2 = text;
            for (int i = 0; i < text.Length; i++)
            {
                text2 = text2.Insert(i * 2, "\0");
            }
            return text2;
        }
    }
}

