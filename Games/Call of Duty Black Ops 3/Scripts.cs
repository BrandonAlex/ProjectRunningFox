using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3
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

        public static string GetNames(int clientIndex)
        {
            if (Form1.PS3.Extension.ReadByte(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.GetName + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient)) == 0x00)
            {
                return "Not Connected";
            }
            else
            {
                return Form1.PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.GetName + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.NextClient));
            }
        }

        public static void SV_GameSendServerCommand(int client, string text, int type = 0)
        {
            UInt32 SV_GameSendServerCommand_Offset = ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.MainAddresses.ZMSV_GameSendServerCommand;
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.Call(SV_GameSendServerCommand_Offset, client, 0, (text));
        }

        public static void iPrintln(int client, string input)
        {
            SV_GameSendServerCommand(client, "c \"" + input + "\"");
        }
        public static void Cbuf_AddText(UInt32 Client, String Command)
        {
            ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.RPC.Call(ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3.Offsets.Client.MainAddresses.Cbuf_AddText, Client, Command);
        }
        public static void ForceHostON()
        {
            Cbuf_AddText(0, "ds_serverConnectTimeout 1000");
            Cbuf_AddText(0, "ds_serverConnectTimeout 1");
            Cbuf_AddText(0, "party_minplayers 1");
            Cbuf_AddText(0, "party_maxplayers 16");
        }
        public static void iPrintlnBold(int clientNumber, string input)
        {
            SV_GameSendServerCommand(clientNumber, "e \"" + input + "\"");
        }
    }
}
