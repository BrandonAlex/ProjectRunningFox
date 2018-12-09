using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops
{
    class Scripts
    {

        public static bool Notify = false;

        public class RPCText1
        {
            public static void Set(int Client, string Text)
            {
                if (Notify == true)
                {
                    iPrintln(Client, Text);

                }
            }
        }
        public class RPCText12
        {
            public static void SetZombies(int Client, string Text)
            {
                if (Notify == true)
                {
                    iPrintlnZombies(Client, Text);
                }
            }
        }
        public static void SV_GameSendServerCommand(int client, string command)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.RPC2.Call(0x003E95F0, client, 1, command);
        }

        public static void ZombiesSV_GameSendServerCommand(int client, string command)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.RPC1.Call(0x003C33A8, client, 1, command);
        }

        public static void ZombiesCbuf_AddText(int localClient, string command)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.RPC1.Call(0x00395BA8, localClient, command);
        }

        public static string GetNames(int clientIndex)
        {
            if (Form1.PS3.Extension.ReadByte(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.GetNames + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval)) == 0x00)
            {
                return "Not Connected";
            }
            else
            {
                return Form1.PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.GetNames + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval));
            }
        }
        public static string GetNamesZombies(int clientIndex)
        {
            if (Form1.PS3.Extension.ReadByte(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.InGameName + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval)) == 0x00)
            {
                return "Not Connected";
            }
            else
            {
                return Form1.PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.InGameName + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Zombies.ClientInterval));
            }
        }

        public static void iPrintlnZombies(int client, string input)
        {
            ZombiesSV_GameSendServerCommand(client, "c \"" + input + "\"");
        }
        public static void iPrintlnBoldZombies(int clientNumber, string input)
        {
            ZombiesSV_GameSendServerCommand(clientNumber, "e \"" + input + "\"");
        }

        public static void iPrintln(int client, string input)
        {
            SV_GameSendServerCommand(client, "c \"" + input + "\"");
        }
        public static void iPrintlnBold(int clientNumber, string input)
        {
            SV_GameSendServerCommand(clientNumber, "e \"" + input + "\"");
        }

        public static void ZombiesSetModel(int client, string model)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.RPC1.Call(0x00305940, (uint)(0xFA805C + client * 0x34C), model);
        }

        public static void SetModel(int client, string model)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.RPC2.Call(0x003701D8, (uint)(0x012ab290 + client * 0x2F8), model);
        }
        public static void cBuf_AddText(int localClient, string command)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops.RPC2.Call(0x00399CC8, localClient, command);
        }
    }
}
