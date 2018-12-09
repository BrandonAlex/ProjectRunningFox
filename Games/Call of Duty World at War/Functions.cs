using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_World_at_War
{
    class Functions
    {
        public static void SetMem(uint Offset, byte[] value)
        {
            Form1.PS3.SetMemory(Offset, value);
        }
        public static void WriteUInt16(uint offset, ushort Value)
        {
            Form1.PS3.SetMemory(offset, BitConverter.GetBytes(Value).Reverse<byte>().ToArray<byte>());
        }
        public static void WriteFlo(uint Offset, float Input)
        {
            Form1.PS3.Extension.WriteFloat(Offset, Input);
        }
        public static void WriteStr(uint Offset, string Input)
        {
            Form1.PS3.Extension.WriteString(Offset, Input);
        }
        public static string ReadStr(uint Offset)
        {
            return Form1.PS3.Extension.ReadString(Offset);
        }
        public static void WriteByte(uint Offset, byte Input)
        {
            Form1.PS3.Extension.WriteByte(Offset, Input);
        }
        public static byte[] ReverseBytes(byte[] inArray)
        {
            Array.Reverse(inArray);
            return inArray;
        }
        public static void WriteSingle(uint address, float[] input)
        {
            int length = input.Length;
            byte[] array = new byte[length * 4];
            for (int i = 0; i < length; i++)
            {
                ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, (int)(i * 4));
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
        public static float ReadSingle(uint address)
        {
            byte[] memory = Form1.PS3.GetBytes(address, 4);
            Array.Reverse(memory, 0, 4);
            return BitConverter.ToSingle(memory, 0);
        }
        public static float[] ReadSingle(uint address, int length)
        {
            byte[] memory = Form1.PS3.GetBytes(address, length * 4);
            ReverseBytes(memory);
            float[] numArray = new float[length - 1 + 1];
            for (int i = 0; i <= length - 1; i++)
            {
                numArray[i] = System.Convert.ToSingle(BitConverter.ToSingle(memory, ((length - 1) - i) * 4));
            }
            return numArray;
        }
        public static byte[] HexStringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
