using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

namespace ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare
{
    class RPC
    {
        public static CCAPI PS3 = new CCAPI();

        private static uint function_address = 0x628870;

        public static byte[] ReverseBytes(Byte[] toReverse)
        {
            Array.Reverse(toReverse);
            return toReverse;
        }
        public static void WriteSingle(UInt32 address, float[] input)
        {
            Int32 length = input.Length;
            Byte[] array = new Byte[length * 4];
            for (Int32 i = 0; i < length; i++)
            {
                ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, (Int32)(i * 4));
            }
            PS3.SetMemory(address, array);
        }

        public static float[] ReadSingle(uint address, int length)
        {
            byte[] memory = PS3.Extension.ReadBytes(address, length * 4);
            ReverseBytes(memory);
            float[] numArray = new float[length];
            for (int index = 0; index < length; ++index)
                numArray[index] = BitConverter.ToSingle(memory, (length - 1 - index) * 4);
            return numArray;
        }
        public static void SV_GameSendServerCommand(int client, string command)
        {
            Call(0x45799C, client, 0, command + "\"");
        }
        public static void iPrintln(int client, string text)
        {
            SV_GameSendServerCommand(client, "e \"" + text + "\"");
        }
        public static void Cbuf_AddText(int client, string command)
        {
            UInt32 Cbuf = 0x3AF41C;
            RPC.Call(Cbuf, client, command);
        }
        public static void iPrintlnBold(int client, string text)
        {
            SV_GameSendServerCommand(client, "c \"" + text + "\"");
        }

        public static int Init()
        {
            if (function_address == 0) return -1;
            Enable_RPC();
            return 0;
        }

        public static void Enable_RPC()
        {
            PS3.SetMemory(function_address, new byte[] { 0x4E, 0x80, 0x00, 0x20 });
            System.Threading.Thread.Sleep(20);
            byte[] func = new byte[] { 0x7C, 0x08, 0x02, 0xA6, 0xF8, 0x01, 0x00, 0x80, 0x3C, 0x60, 0x10, 0x05, 0x81, 0x83, 0x00, 0x4C, 0x2C, 0x0C, 0x00, 0x00, 0x41, 0x82, 0x00, 0x64, 0x80, 0x83, 0x00, 0x04, 0x80, 0xA3, 0x00, 0x08, 0x80, 0xC3, 0x00, 0x0C, 0x80, 0xE3, 0x00, 0x10, 0x81, 0x03, 0x00, 0x14, 0x81, 0x23, 0x00, 0x18, 0x81, 0x43, 0x00, 0x1C, 0x81, 0x63, 0x00, 0x20, 0xC0, 0x23, 0x00, 0x24, 0xC0, 0x43, 0x00, 0x28, 0xC0, 0x63, 0x00, 0x2C, 0xC0, 0x83, 0x00, 0x30, 0xC0, 0xA3, 0x00, 0x34, 0xC0, 0xC3, 0x00, 0x38, 0xC0, 0xE3, 0x00, 0x3C, 0xC1, 0x03, 0x00, 0x40, 0xC1, 0x23, 0x00, 0x48, 0x80, 0x63, 0x00, 0x00, 0x7D, 0x89, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3C, 0x80, 0x10, 0x05, 0x38, 0xA0, 0x00, 0x00, 0x90, 0xA4, 0x00, 0x4C, 0x90, 0x64, 0x00, 0x50, 0xE8, 0x01, 0x00, 0x80, 0x7C, 0x08, 0x03, 0xA6, 0x38, 0x21, 0x00, 0x70, 0x4E, 0x80, 0x00, 0x20 };
            PS3.SetMemory(function_address + 0x4, func);
            PS3.SetMemory(0x10050000, new byte[0x2854]);
            PS3.SetMemory(function_address, new byte[] { 0xF8, 0x21, 0xFF, 0x91 });
        }

        public static int Call(uint func_address, params object[] parameters)
        {
            int num_params = parameters.Length;
            uint num_floats = 0;
            for (uint i = 0; i < num_params; i++)
            {
                if (parameters[i] is int)
                {
                    byte[] val = BitConverter.GetBytes((int)parameters[i]);
                    Array.Reverse(val);
                    PS3.SetMemory(0x10050000 + (i + num_floats) * 4, val);
                }
                else if (parameters[i] is uint)
                {
                    byte[] val = BitConverter.GetBytes((uint)parameters[i]);
                    Array.Reverse(val);
                    PS3.SetMemory(0x10050000 + (i + num_floats) * 4, val);
                }
                else if (parameters[i] is string)
                {
                    byte[] str = Encoding.UTF8.GetBytes(Convert.ToString(parameters[i]) + "\0");
                    PS3.SetMemory(0x10050054 + i * 0x400, str);
                    uint addr = 0x10050054 + i * 0x400;
                    byte[] address = BitConverter.GetBytes(addr);
                    Array.Reverse(address);
                    PS3.SetMemory(0x10050000 + (i + num_floats) * 4, address);
                }
                else if (parameters[i] is float)
                {
                    num_floats++;
                    byte[] val = BitConverter.GetBytes((float)parameters[i]);
                    Array.Reverse(val);
                    PS3.SetMemory(0x10050024 + ((num_floats - 1) * 0x4), val);
                }
            }
            byte[] fadd = BitConverter.GetBytes(func_address);
            Array.Reverse(fadd);
            PS3.SetMemory(0x1005004C, fadd);
            System.Threading.Thread.Sleep(20);
            byte[] ret = PS3.Extension.ReadBytes(0x10050050, 4);
            Array.Reverse(ret);
            return BitConverter.ToInt32(ret, 0);
        }
    }
}
