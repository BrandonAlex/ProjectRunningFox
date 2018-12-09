using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2
{
    internal class PS3
    {
        public class Extension
        {
            private static SelectAPI CurrentAPI;
            public static byte[] GetBytes(uint offset, int length, SelectAPI API)
            {
                byte[] array = new byte[length];
                byte[] result;
                if (API == SelectAPI.ControlConsole)
                {
                    PS3.Extension.CurrentAPI = PS3.GetCurrentAPI();
                    result = PS3.DEX.GetBytes(offset, length);
                }
                else
                {
                    if (API == SelectAPI.TargetManager)
                    {
                        PS3.Extension.CurrentAPI = PS3.GetCurrentAPI();
                        array = PS3.DEX.GetBytes(offset, length);
                    }
                    result = array;
                }
                return result;
            }
            public static void GetMem(uint offset, byte[] buffer, SelectAPI API)
            {
                if (API == SelectAPI.ControlConsole)
                {
                    PS3.GetMemoryR(offset, buffer);
                }
                else
                {
                    if (API == SelectAPI.TargetManager)
                    {
                        PS3.GetMemoryR(offset, buffer);
                    }
                }
            }
            public static bool ReadBool(uint offset)
            {
                byte[] array = new byte[1];
                PS3.Extension.GetMem(offset, array, PS3.Extension.CurrentAPI);
                return array[0] != 0;
            }
            public static byte ReadByte(uint offset)
            {
                return PS3.Extension.GetBytes(offset, 1, PS3.Extension.CurrentAPI)[0];
            }
            public static byte[] ReadBytes(uint offset, int length)
            {
                return PS3.Extension.GetBytes(offset, length, PS3.Extension.CurrentAPI);
            }
            public static float ReadFloat(uint offset)
            {
                byte[] bytes = PS3.Extension.GetBytes(offset, 4, PS3.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 4);
                return BitConverter.ToSingle(bytes, 0);
            }
            public static short ReadInt16(uint offset)
            {
                byte[] bytes = PS3.Extension.GetBytes(offset, 2, PS3.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 2);
                return BitConverter.ToInt16(bytes, 0);
            }
            public static int ReadInt32(uint offset)
            {
                byte[] bytes = PS3.Extension.GetBytes(offset, 4, PS3.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 4);
                return BitConverter.ToInt32(bytes, 0);
            }
            public static long ReadInt64(uint offset)
            {
                byte[] bytes = PS3.Extension.GetBytes(offset, 8, PS3.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 8);
                return BitConverter.ToInt64(bytes, 0);
            }
            public static sbyte ReadSByte(uint offset)
            {
                byte[] array = new byte[1];
                PS3.Extension.GetMem(offset, array, PS3.Extension.CurrentAPI);
                return (sbyte)array[0];
            }
            public static string ReadString(uint offset)
            {
                int num = 40;
                int num2 = 0;
                string text = "";
                do
                {
                    byte[] bytes = PS3.Extension.ReadBytes(offset + (uint)num2, num);
                    text += Encoding.UTF8.GetString(bytes);
                    num2 += num;
                }
                while (!text.Contains('\0'));
                int length = text.IndexOf('\0');
                string result = text.Substring(0, length);
                text = string.Empty;
                return result;
            }
            public static byte[] ReverseArray(float float_0)
            {
                byte[] bytes = BitConverter.GetBytes(float_0);
                Array.Reverse(bytes);
                return bytes;
            }
            public static byte[] uintBytes(uint input)
            {
                byte[] bytes = BitConverter.GetBytes(input);
                Array.Reverse(bytes);
                return bytes;
            }
            public static byte[] ReverseBytes(byte[] inArray)
            {
                Array.Reverse(inArray);
                return inArray;
            }
            public static byte[] ToHexFloat(float Axis)
            {
                byte[] bytes = BitConverter.GetBytes(Axis);
                Array.Reverse(bytes);
                return bytes;
            }
            public static ushort ReadUInt16(uint offset)
            {
                byte[] bytes = PS3.Extension.GetBytes(offset, 2, PS3.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 2);
                return BitConverter.ToUInt16(bytes, 0);
            }
            public static uint ReadUInt32(uint offset)
            {
                byte[] bytes = PS3.Extension.GetBytes(offset, 4, PS3.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 4);
                return BitConverter.ToUInt32(bytes, 0);
            }
            public static ulong ReadUInt64(uint offset)
            {
                byte[] bytes = PS3.Extension.GetBytes(offset, 8, PS3.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 8);
                return BitConverter.ToUInt64(bytes, 0);
            }
            private static void SetMem(uint Address, byte[] buffer, SelectAPI API)
            {
                PS3.DEX.SetMemory(Address, buffer);
            }
            public static void WriteBool(uint offset, bool input)
            {
                byte[] buffer = new byte[]
				{
					
				};
                PS3.Extension.SetMem(offset, buffer, PS3.Extension.CurrentAPI);
            }
            public static void WriteByte(uint offset, byte input)
            {
                byte[] buffer = new byte[]
				{
					input
				};
                PS3.Extension.SetMem(offset, buffer, PS3.Extension.CurrentAPI);
            }
            public static void WriteBytes(uint offset, byte[] input)
            {
                PS3.Extension.SetMem(offset, input, PS3.Extension.CurrentAPI);
            }
            public static void WriteFloat(uint offset, float input)
            {
                byte[] array = new byte[4];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 4);
                PS3.Extension.SetMem(offset, array, PS3.Extension.CurrentAPI);
            }
            public static void WriteInt16(uint offset, short input)
            {
                byte[] array = new byte[2];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 2);
                PS3.Extension.SetMem(offset, array, PS3.Extension.CurrentAPI);
            }
            public static void WriteInt32(uint offset, int input)
            {
                byte[] array = new byte[4];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 4);
                PS3.Extension.SetMem(offset, array, PS3.Extension.CurrentAPI);
            }
            public static void WriteInt64(uint offset, long input)
            {
                byte[] array = new byte[8];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 8);
                PS3.Extension.SetMem(offset, array, PS3.Extension.CurrentAPI);
            }
            public static void WriteSByte(uint offset, sbyte input)
            {
                byte[] buffer = new byte[]
				{
					(byte)input
				};
                PS3.Extension.SetMem(offset, buffer, PS3.Extension.CurrentAPI);
            }
            public static void WriteString(uint offset, string input)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.Extension.SetMem(offset, bytes, PS3.Extension.CurrentAPI);
            }
            public static void WriteUInt16(uint offset, ushort input)
            {
                byte[] array = new byte[2];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 2);
                PS3.Extension.SetMem(offset, array, PS3.Extension.CurrentAPI);
            }
            public static void WriteUInt32(uint offset, uint input)
            {
                byte[] array = new byte[4];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 4);
                PS3.Extension.SetMem(offset, array, PS3.Extension.CurrentAPI);
            }
            public static void WriteUInt64(uint offset, ulong input)
            {
                byte[] array = new byte[8];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 8);
                PS3.Extension.SetMem(offset, array, PS3.Extension.CurrentAPI);
            }
        }
        private static PS3API DEX = new PS3API(SelectAPI.TargetManager);
        public static void Connect()
        {
            PS3.DEX.ConnectTarget(0);
            PS3.DEX.AttachProcess();
        }
        public static void Disconnect()
        {
            PS3.DEX.DisconnectTarget();
        }
        public static byte[] GetMemory(uint offset, int length)
        {
            byte[] array = new byte[length];
            PS3.DEX.GetMemory(offset, array);
            return array;
        }
        public static void ChangeAPI(SelectAPI API)
        {
            PS3.DEX.ChangeAPI(API);
        }
        public static SelectAPI GetCurrentAPI()
        {
            return PS3.DEX.GetCurrentAPI();
        }
        public static byte[] GetMemoryL(uint address, int length)
        {
            byte[] array = new byte[length];
            PS3.DEX.GetMemory(address, array);
            return array;
        }
        public static void SetMemory(uint Address, byte[] Bytes)
        {
            PS3.DEX.SetMemory(Address, Bytes);
        }
        public static void GetMemoryR(uint Address, byte[] Bytes)
        {
            PS3.DEX.GetMemory(Address, Bytes);
        }
        public static void WriteSingle(uint address, float[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 4];
            for (int i = 0; i < num; i++)
            {
                PS3.Extension.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 4);
            }
            PS3.SetMemory(address, array);
        }
        public static float[] ReadSingle(uint address, int length)
        {
            byte[] memory = PS3.GetMemory(address, length * 4);
            PS3.Extension.ReverseBytes(memory);
            float[] array = new float[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = BitConverter.ToSingle(memory, (length - 1 - i) * 4);
            }
            return array;
        }

        public static void Reconnect()
        {
            PS3.DEX.ConnectTarget(0);
        }
    }
}



