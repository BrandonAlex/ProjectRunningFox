using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_MW2
{
    class RPC
    {
        private static uint function_address = 0x38EDE8;

        public static int Call(UInt32 func_address, params object[] parameters)
        {
            int length = parameters.Length;
            int index = 0;
            UInt32 num3 = 0;
            UInt32 num4 = 0;
            UInt32 num5 = 0;
            UInt32 num6 = 0;
            while (index < length)
            {
                if (parameters[index] is int)
                {
                    Form1.PS3.Extension.WriteInt32(0x10050000 + (num3 * 4), (int)parameters[index]);
                    num3++;
                }
                else if (parameters[index] is UInt32)
                {
                    Form1.PS3.Extension.WriteUInt32(0x10050000 + (num3 * 4), (UInt32)parameters[index]);
                    num3++;
                }
                else
                {
                    UInt32 num7;
                    if (parameters[index] is string)
                    {
                        num7 = 0x10052000 + (num4 * 0x400);
                        Form1.PS3.Extension.WriteString(num7, Convert.ToString(parameters[index]));
                        Form1.PS3.Extension.WriteUInt32(0x10050000 + (num3 * 4), num7);
                        num3++;
                        num4++;
                    }
                    else if (parameters[index] is float)
                    {
                        Form1.PS3.Extension.WriteFloat(0x10050024 + (num5 * 4), (float)parameters[index]);
                        num5++;
                    }
                    else if (parameters[index] is float[])
                    {
                        float[] input = (float[])parameters[index];
                        num7 = 0x10051000 + (num6 * 4);
                        ProjectRunningFox.Games.Call_of_Duty_MW2.Lib.WriteSingle(num7, input);
                        Form1.PS3.Extension.WriteUInt32(0x10050000 + (num3 * 4), num7);
                        num3++;
                        num6 += (UInt32)input.Length;
                    }
                }
                index++;
            }
            Form1.PS3.Extension.WriteUInt32(0x1005004C, func_address);
            Thread.Sleep(20);
            return Form1.PS3.Extension.ReadInt32(0x10050050);
        }

        public static void EnableRPC()
        {
            byte[] RPC = { 0xF8, 0x21, 0xFF, 0x91, 0x7C, 0x08, 0x02, 0xA6, 0xF8, 0x01, 0x00, 0x80, 0x3C, 0x40, 0x00, 0x72, 0x30, 0x42, 0x4C, 0x38, 0x3C, 0x60, 0x10, 0x05, 0x81, 0x83, 0x00, 0x4C, 0x2C, 0x0C, 0x00, 0x00, 0x41, 0x82, 0x00, 0x64, 0x80, 0x83, 0x00, 0x04, 0x80, 0xA3, 0x00, 0x08, 0x80, 0xC3, 0x00, 0x0C, 0x80, 0xE3, 0x00, 0x10, 0x81, 0x03, 0x00, 0x14, 0x81, 0x23, 0x00, 0x18, 0x81, 0x43, 0x00, 0x1C, 0x81, 0x63, 0x00, 0x20, 0xC0, 0x23, 0x00, 0x24, 0xC0, 0x43, 0x00, 0x28, 0xC0, 0x63, 0x00, 0x2C, 0xC0, 0x83, 0x00, 0x30, 0xC0, 0xA3, 0x00, 0x34, 0xC0, 0xC3, 0x00, 0x38, 0xC0, 0xE3, 0x00, 0x3C, 0xC1, 0x03, 0x00, 0x40, 0xC1, 0x23, 0x00, 0x48, 0x80, 0x63, 0x00, 0x00, 0x7D, 0x89, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3C, 0x80, 0x10, 0x05, 0x38, 0xA0, 0x00, 0x00, 0x90, 0xA4, 0x00, 0x4C, 0x90, 0x64, 0x00, 0x50, 0x3C, 0x40, 0x00, 0x73, 0x30, 0x42, 0x4B, 0xE8, 0xE8, 0x01, 0x00, 0x80, 0x7C, 0x08, 0x03, 0xA6, 0x38, 0x21, 0x00, 0x70, 0x4E, 0x80, 0x00, 0x20 };
            Form1.PS3.SetMemory(function_address, RPC);
            Form1.PS3.SetMemory(0x10050000, new byte[0x2854]);
        }
    }
}
