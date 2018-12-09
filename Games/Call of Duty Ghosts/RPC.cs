using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

namespace ProjectRunningFox.Games.Call_of_Duty_Ghosts
{
    class RPC
    {
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        static uint function_address;

        public static int Init()
        {
            function_address = Get_func_address();
            if (function_address == 0) return -1;
            EnableRPC();
            return 0;
        }

        public static uint Get_func_address()
        {
            for (uint i = 0x489BD4; i < 0x1000000; i += 4)
            {
                byte[] bytes = new byte[8];
                PS3.GetMemory(i, bytes);
                if (((bytes[0] == 0x3C) && (bytes[1] == 0x8E) && (bytes[2] == 0xFA) && (bytes[3] == 0x35) && (bytes[4] == 0x42) && (bytes[5] == 0xC8) && (bytes[6] == 0x00) && (bytes[7] == 0x00)))
                {
                    return i + 0xC;
                }
            }
            return 0;
        }

        public static void EnableRPC()
        {
            PS3.SetMemory(0x4A0700, new byte[] { 0x4e, 0x80, 0, 0x20 });
            Thread.Sleep(20);
            byte[] memory = new byte[] { 0x7c, 8, 2, 0xa6, 0xf8, 1, 0, 0x80, 60, 0x60, 0x10, 5, 0x81, 0x83, 0, 0x4c, 0x2c, 12, 0, 0, 0x41, 130, 0, 100, 0x80, 0x83, 0, 4, 0x80, 0xa3, 0, 8, 0x80, 0xc3, 0, 12, 0x80, 0xe3, 0, 0x10, 0x81, 3, 0, 20, 0x81, 0x23, 0, 0x18, 0x81, 0x43, 0, 0x1c, 0x81, 0x63, 0, 0x20, 0xc0, 0x23, 0, 0x24, 0xc0, 0x43, 0, 40, 0xc0, 0x63, 0, 0x2c, 0xc0, 0x83, 0, 0x30, 0xc0, 0xa3, 0, 0x34, 0xc0, 0xc3, 0, 0x38, 0xc0, 0xe3, 0, 60, 0xc1, 3, 0, 0x40, 0xc1, 0x23, 0, 0x48, 0x80, 0x63, 0, 0, 0x7d, 0x89, 3, 0xa6, 0x4e, 0x80, 4, 0x21, 60, 0x80, 0x10, 5, 0x38, 160, 0, 0, 0x90, 0xa4, 0, 0x4c, 0x90, 100, 0, 80, 0xe8, 1, 0, 0x80, 0x7c, 8, 3, 0xa6, 0x38, 0x21, 0, 0x70, 0x4e, 0x80, 0, 0x20 };
            PS3.SetMemory(0x4A0700 + 4, memory);
            PS3.SetMemory(0x10050000, new byte[0x2854]);
            PS3.SetMemory(0x4A0700, new byte[] { 0xf8, 0x21, 0xff, 0x91 });
        }

     public static int CallFunction(uint func_address, params object[] parameters)
            {
                int length = parameters.Length;
                uint num2 = 0;
                for (uint i = 0; i < length; i++)
                {
                    if (parameters[i] is int)
                    {
                        byte[] array = BitConverter.GetBytes((int)parameters[i]);
                        Array.Reverse(array);
                        PS3.SetMemory(0x10050000 + ((i + num2) * 4), array);
                    }
                    else if (parameters[i] is uint)
                    {
                        byte[] buffer2 = BitConverter.GetBytes((uint)parameters[i]);
                        Array.Reverse(buffer2);
                        PS3.SetMemory(0x10050000 + ((i + num2) * 4), buffer2);
                    }
                    else if (parameters[i] is string)
                    {
                        byte[] buffer3 = Encoding.UTF8.GetBytes(Convert.ToString(parameters[i]) + "*********");
                        PS3.SetMemory(0x10050054 + (i * 0x400), buffer3);
                        uint num4 = 0x10050054 + (i * 0x400);
                        byte[] buffer4 = BitConverter.GetBytes(num4);
                        Array.Reverse(buffer4);
                        PS3.SetMemory(0x10050000 + ((i + num2) * 4), buffer4);
                    }
                    else if (parameters[i] is float)
                    {
                        num2++;
                        byte[] buffer5 = BitConverter.GetBytes((float)parameters[i]);
                        Array.Reverse(buffer5);
                        PS3.SetMemory(0x10050024 + ((num2 - 1) * 4), buffer5);
                    }
                }
                byte[] bytes = BitConverter.GetBytes(func_address);
                Array.Reverse(bytes);
                PS3.SetMemory(0x1005004c, bytes);
                Thread.Sleep(20);
                byte[] memory = new byte[4];
                PS3.GetMemory(0x10050050, memory);
                Array.Reverse(memory);
                return BitConverter.ToInt32(memory, 0);
            }
        }
    }
