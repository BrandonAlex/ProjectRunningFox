using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2
{
    class RPC
    {
        #region
        private static uint function_address;
        public static uint g_entity = 0x16b9f20;
        public static uint G_SetModel = 0x2774a4;
        public static uint entitySize = 0x31c;
        #endregion

        public static void G_Model(int Client, string Model)
        {
            RPC.Call(G_SetModel, new object[] { g_entity + ((uint)(entitySize * Client)), Model });
        }

        public static void Clone(int Client)
        {
            PS3.Extension.WriteBytes(0x1F63C4, new byte[] { 0x38, 0x60, 0x0, 0x0 });
            PS3.Extension.WriteInt16(0x1F63C4 + 2, (short)Client);
            RPC.Call(0x1F6388, Client);
        }


        public static int Call(uint func_address, params object[] parameters)
        {
            int length = parameters.Length;
            int index = 0;
            uint num3 = 0;
            uint num4 = 0;
            uint num5 = 0;
            uint num6 = 0;
            while (index < length)
            {
                if (parameters[index] is int)
                {
                    PS3.Extension.WriteInt32(0x10020000 + (num3 * 4), (int)parameters[index]);
                    num3++;
                }
                else if (parameters[index] is uint)
                {
                    PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), (uint)parameters[index]);
                    num3++;
                }
                else
                {
                    uint num7;
                    if (parameters[index] is string)
                    {
                        num7 = 0x10022000 + (num4 * 0x400);
                        PS3.Extension.WriteString(num7, Convert.ToString(parameters[index]));
                        PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);
                        num3++;
                        num4++;
                    }
                    else if (parameters[index] is float)
                    {
                        PS3.Extension.WriteFloat(0x10020024 + (num5 * 4), (float)parameters[index]);
                        num5++;
                    }
                    else if (parameters[index] is float[])
                    {
                        float[] input = (float[])parameters[index];
                        num7 = 0x10021000 + (num6 * 4);
                        Lib.WriteSingle(num7, input);
                        PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);
                        num3++;
                        num6 += (uint)input.Length;
                    }
                }
                index++;
            }
            PS3.Extension.WriteUInt32(0x1002004C, func_address);
            Thread.Sleep(20);
            return PS3.Extension.ReadInt32(0x10020050);
        }

        public static void Enable()
        {
            PS3.SetMemory(function_address, new byte[] { 0x4E, 0x80, 0x00, 0x20 });
            Thread.Sleep(20);
            byte[] memory = new byte[] 
                    { 0x7C, 0x08, 0x02, 0xA6, 0xF8, 0x01, 0x00, 0x80, 0x3C, 0x60, 0x10, 0x02, 0x81, 0x83, 0x00, 0x4C, 
            0x2C, 0x0C, 0x00, 0x00, 0x41, 0x82, 0x00, 0x64, 0x80, 0x83, 0x00, 0x04, 0x80, 0xA3, 0x00, 0x08, 
            0x80, 0xC3, 0x00, 0x0C, 0x80, 0xE3, 0x00, 0x10, 0x81, 0x03, 0x00, 0x14, 0x81, 0x23, 0x00, 0x18, 
            0x81, 0x43, 0x00, 0x1C, 0x81, 0x63, 0x00, 0x20, 0xC0, 0x23, 0x00, 0x24, 0xc0, 0x43, 0x00, 0x28, 
            0xC0, 0x63, 0x00, 0x2C, 0xC0, 0x83, 0x00, 0x30, 0xC0, 0xA3, 0x00, 0x34, 0xc0, 0xC3, 0x00, 0x38, 
            0xC0, 0xE3, 0x00, 0x3C, 0xC1, 0x03, 0x00, 0x40, 0xC1, 0x23, 0x00, 0x48, 0x80, 0x63, 0x00, 0x00, 
            0x7D, 0x89, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3C, 0x80, 0x10, 0x02, 0x38, 0xA0, 0x00, 0x00, 
            0x90, 0xA4, 0x00, 0x4C, 0x90, 0x64, 0x00, 0x50, 0xE8, 0x01, 0x00, 0x80, 0x7C, 0x08, 0x03, 0xA6, 
            0x38, 0x21, 0x00, 0x70, 0x4E, 0x80, 0x00, 0x20 };
            PS3.SetMemory(function_address + 4, memory);
            PS3.SetMemory(0x10020000, new byte[0x2854]);
            PS3.SetMemory(function_address, new byte[] { 0xF8, 0x21, 0xFF, 0x91 });
        }

        public static int Init()
        {
            function_address = 0x007AA050;
            Enable();
            return 0;
        }

        public static void iPrintln(int Client, string Text)
        {
            SV_GameSendServerCommand(Client, "O \"" + Text + "\"");
        }

        public static void iPrintlnBold(int Client, string Text)
        {
            SV_GameSendServerCommand(Client, "< \"" + Text + "\"");
        }
        public static void cbuf_addtext(string Command)
        {
            RPC.Call(0x313c18, 0, Command);
        }

        public static void SvKick(int Client, string Reason)
        {
            RPC.SV_GameSendServerCommand(Client, "5 \"\n" + Reason + "\"");
        }
        public static void KickClient(int Client)
        {
            RPC.cbuf_addtext("clientKick " + Client);
        }

        public static void PlayerModel(int Client, string ModelName)
        {
            RPC.Call(0x2774A4, 0, Client);
        }

        public static UInt32 G_Entity(int entityIndex, UInt32 Mod = 0x00)
        {
            return (0x0016B9F20 + (UInt32)Mod) + ((UInt32)entityIndex * 0x31C);
        }

        public static void G_EntAttach(int entityIndex, string modelName, string tagName)
        {
            Int32 tag = RPC.Call(0x48E718, tagName);
            RPC.Call(0x27769c, G_Entity(entityIndex), modelName, tag, 0);
        }

        public static void PS3Freeze(int Client)
        {
            SV_GameSendServerCommand(Client, "^ 6 90 ");
        }

        public static void SV_GameSendServerCommand(int client, string command)
        {
            Call(0x349F6C, new object[] { client, 0, command });
        }
    }
}