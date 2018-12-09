using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare
{
    class RPC
    {
        static uint function_address = 0;
        public static void Enable_RPC()
        {
            for (uint i = 0x32F1FC; i < 0x1000000; i += 4)
            {
                byte[] bytes = GetMemoryL(i, 8);
                if (((bytes[0] == 0xF8) && (bytes[1] == 0x01) && (bytes[2] == 0x1F) && (bytes[3] == 0x38) && (bytes[4] == 0x4B) && (bytes[5] == 0xFF) && (bytes[6] == 0xF1) && (bytes[7] == 0xB8)))
                    function_address = i + 0xC;
            }
            if (function_address == 0)
                throw new Exception("Couldn't find RPC Address");

            Form1.PS3.SetMemory(function_address, new byte[] { 0x4E, 0x80, 0x00, 0x20 });
            Thread.Sleep(20);
            byte[] func = new byte[] { 0x7C, 0x08, 0x02, 0xA6, 0xF8, 0x01, 0x00, 0x80, 0x3C, 0x60, 0x50, 0x05, 0x81, 0x83, 0x00, 0x4C, 0x2C, 0x0C, 0x00, 0x00, 0x41, 0x82, 0x00, 0x64, 0x80, 0x83, 0x00, 0x04, 0x80, 0xA3, 0x00, 0x08, 0x80, 0xC3, 0x00, 0x0C, 0x80, 0xE3, 0x00, 0x10, 0x81, 0x03, 0x00, 0x14, 0x81, 0x23, 0x00, 0x18, 0x81, 0x43, 0x00, 0x1C, 0x81, 0x63, 0x00, 0x20, 0xC0, 0x23, 0x00, 0x24, 0xC0, 0x43, 0x00, 0x28, 0xC0, 0x63, 0x00, 0x2C, 0xC0, 0x83, 0x00, 0x30, 0xC0, 0xA3, 0x00, 0x34, 0xC0, 0xC3, 0x00, 0x38, 0xC0, 0xE3, 0x00, 0x3C, 0xC1, 0x03, 0x00, 0x40, 0xC1, 0x23, 0x00, 0x48, 0x80, 0x63, 0x00, 0x00, 0x7D, 0x89, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3C, 0x80, 0x50, 0x05, 0x38, 0xA0, 0x00, 0x00, 0x90, 0xA4, 0x00, 0x4C, 0x80, 0x64, 0x00, 0x50, 0xE8, 0x01, 0x00, 0x80, 0x7C, 0x08, 0x03, 0xA6, 0x38, 0x21, 0x00, 0x70, 0x4E, 0x80, 0x00, 0x20 };
            Form1.PS3.SetMemory(function_address + 0x4, func);
            Form1.PS3.SetMemory(0x50050000, new byte[0x2854]);
            Form1.PS3.SetMemory(function_address, new byte[] { 0xF8, 0x21, 0xFF, 0x91 });
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
                    Form1.PS3.SetMemory(0x50050000 + (i + num_floats) * 4, val);
                }
                else if (parameters[i] is uint)
                {
                    byte[] val = BitConverter.GetBytes((uint)parameters[i]);
                    Array.Reverse(val);
                    Form1.PS3.SetMemory(0x50050000 + (i + num_floats) * 4, val);
                }
                else if (parameters[i] is string)
                {
                    byte[] str = Encoding.UTF8.GetBytes(Convert.ToString(parameters[i]) + "\0");
                    Form1.PS3.SetMemory(0x50050054 + i * 0x400, str);
                    uint addr = 0x50050054 + i * 0x400;
                    byte[] address = BitConverter.GetBytes(addr);
                    Array.Reverse(address);
                    Form1.PS3.SetMemory(0x50050000 + (i + num_floats) * 4, address);
                }
                else if (parameters[i] is float)
                {
                    num_floats++;
                    byte[] val = BitConverter.GetBytes((float)parameters[i]);
                    Array.Reverse(val);
                    Form1.PS3.SetMemory(0x50050024 + ((num_floats - 1) * 0x4), val);
                }
            }
            byte[] fadd = BitConverter.GetBytes(func_address);
            Array.Reverse(fadd);
            Form1.PS3.SetMemory(0x5005004C, fadd);
            Thread.Sleep(20);
            byte[] ret = GetMemoryL(0x50050050, 4);
            Array.Reverse(ret);
            return BitConverter.ToInt32(ret, 0);
        }
        private static Byte[] GetMemoryL(UInt32 address, Int32 length)
        {
            Byte[] buffer = new Byte[length];
            Form1.PS3.GetMemory(address, buffer);
            return buffer;
        }
    }
}
