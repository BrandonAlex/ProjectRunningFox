using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Ghosts
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
            if (Form1.PS3.Extension.ReadByte(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.ChangeName + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval)) == 0x00)
            {
                return "Not Connected";
            }
            else
            {
                return Form1.PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.ChangeName + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_Black_Ops.Offsets.Client.Interval));
            }
        }

        public static void SV_GameSendServerCommand(int client, string command)
        {
            Games.Call_of_Duty_Ghosts.RPC.CallFunction(0x672444, client, 0, command);
        }

       public static void iPrintln(int client, string input)
        {
            SV_GameSendServerCommand(client, "c \"" + input + "\"");
        }
       public static void Cbuf_AddText(UInt32 Client, string Command) 
        {
             Games.Call_of_Duty_Ghosts.RPC.CallFunction(0x2B1C14, Client, Command);
         }
        public static void ForceHostON()
        {
            Cbuf_AddText(0, "ds_serverConnectTimeout 1000");
            Cbuf_AddText(0, "ds_serverConnectTimeout 1");
            Cbuf_AddText(0, "party_minplayers 1");
            Cbuf_AddText(0, "party_maxplayers 16");
        }
      public static void iPrintlnBold(int client, string input)
        {
            SV_GameSendServerCommand(client, "e \"" + input + "\"");
        }
    }
}
