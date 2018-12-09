using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using PS3Lib;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3
{
    class RPC
    {
        public static PS3API PS3 = new PS3API();
        public static uint function_address = 0x3D0B28;

        public static int Init()
        {
            if (function_address == 0) return -1;
            EnableRPC();
            return 0;
        }

        public static void EnableRPC()
        {
            PS3.SetMemory(0x3D0B28, new byte[] { 0x4E, 0x80, 0x00, 0x20 });
            Thread.Sleep(20);
            byte[] func = new byte[]
            {
                0x7C, 0x08, 0x02, 0xA6, 0xF8, 0x01, 0x00, 0x80, 0x3C, 0x60, 0x10, 0x05, 0x81, 0x83, 0x00, 0x4C, 0x2C, 0x0C,
                0x00, 0x00, 0x41, 0x82, 0x00, 0x64, 0x80, 0x83, 0x00, 0x04, 0x80, 0xA3, 0x00, 0x08, 0x80, 0xC3, 0x00,
                0x0C, 0x80, 0xE3, 0x00, 0x10, 0x81, 0x03, 0x00, 0x14, 0x81, 0x23, 0x00, 0x18, 0x81, 0x43, 0x00, 0x1C,
                0x81, 0x63, 0x00, 0x20, 0xC0, 0x23, 0x00, 0x24, 0xC0, 0x43, 0x00, 0x28, 0xC0, 0x63, 0x00, 0x2C, 0xC0,
                0x83, 0x00, 0x30, 0xC0, 0xA3, 0x00, 0x34, 0xC0, 0xC3, 0x00, 0x38, 0xC0, 0xE3, 0x00, 0x3C, 0xC1, 0x03,
                0x00, 0x40, 0xC1, 0x23, 0x00, 0x48, 0x80, 0x63, 0x00, 0x00, 0x7D, 0x89, 0x03, 0xA6, 0x4E, 0x80, 0x04,
                0x21, 0x3C, 0x80, 0x10, 0x05, 0x38, 0xA0, 0x00, 0x00, 0x90, 0xA4, 0x00, 0x4C, 0x90, 0x64, 0x00, 0x50,
                0xE8, 0x01, 0x00, 0x80, 0x7C, 0x08, 0x03, 0xA6, 0x38, 0x21, 0x00, 0x70, 0x4E, 0x80, 0x00, 0x20
            };
            PS3.SetMemory(0x3D0B28 + 0x4, func);
            PS3.SetMemory(0x10050000, new byte[0x2854]);
            PS3.SetMemory(0x3D0B28, new byte[] { 0xF8, 0x21, 0xFF, 0x91 });
        }

        public static Int32 Call(UInt32 Address, params Object[] MemoryParams)
        {
            int num_params = MemoryParams.Length;
            uint num_floats = 0;
            for (uint i = 0; i < num_params; i++)
            {
                if (MemoryParams[i] is int)
                {
                    byte[] val = BitConverter.GetBytes((int)MemoryParams[i]);
                    Array.Reverse(val);
                    PS3.SetMemory(0x10050000 + (i + num_floats) * 4, val);
                }
                else if (MemoryParams[i] is uint)
                {
                    byte[] val = BitConverter.GetBytes((uint)MemoryParams[i]);
                    Array.Reverse(val);
                    PS3.SetMemory(0x10050000 + (i + num_floats) * 4, val);
                }
                else if (MemoryParams[i] is string)
                {
                    byte[] str = Encoding.UTF8.GetBytes(Convert.ToString(MemoryParams[i]) + "\0");
                    PS3.SetMemory(0x10050054 + i * 0x400, str);
                    uint addr = 0x10050054 + i * 0x400;
                    byte[] address = BitConverter.GetBytes(addr);
                    Array.Reverse(address);
                    PS3.SetMemory(0x10050000 + (i + num_floats) * 4, address);
                }
                else if (MemoryParams[i] is float)
                {
                    num_floats++;
                    byte[] val = BitConverter.GetBytes((float)MemoryParams[i]);
                    Array.Reverse(val);
                    PS3.SetMemory(0x10050024 + ((num_floats - 1) * 0x4), val);
                }
            }
            byte[] fadd = BitConverter.GetBytes(Address);
            Array.Reverse(fadd);
            PS3.SetMemory(0x1005004C, fadd);
            Thread.Sleep(20);
            byte[] ret = PS3.Extension.ReadBytes(0x10050050, 4);
            Array.Reverse(ret);
            return BitConverter.ToInt32(ret, 0);
        }

        public static void iPrintln(int client, string text)
        {
            SV_GameSendServerCommand(client, "< \"" + text + "\"");
        }

        public static void iPrintlnBold(int client, string text)
        {
            SV_GameSendServerCommand(client, "O \"" + text + "\"");
        }

        public static void ZMiPrintln(int client, string text)
        {
            ZMSV_GameSendServerCommand(client, "< \"" + text + "\"");
        }

        public static void ZMiPrintlnBold(int client, string text)
        {
            ZMSV_GameSendServerCommand(client, "O \"" + text + "\"");
        }

        public static void SV_GameSendServerCommand(int client, string command)
        {
            object[] parameters = new object[] { client, 0, command + "\"" };
            Call(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.MainAddresses.ZMSV_GameSendServerCommand, parameters);
        }

        public static void Cbuf_AddText(String Command)
        {
            Call(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.MainAddresses.Cbuf_AddText, 0, Command);
        }
        public static void ZMSV_GameSendServerCommand(int client, string command)
        {
            object[] parameters = new object[] { client, 0, command + "\"" };
            Call(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.MainAddresses.ZMSV_GameSendServerCommand, parameters);
        }

        public static void ZMCbuf_AddText(String Command)
        {
            Call(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.MainAddresses.ZMCbuf_AddText, 0, Command);
        }

    }
}