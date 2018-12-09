using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectRunningFox.Games.Call_of_Duty_MW3
{
    class Scripts
    {

        public static bool Notify = false;

        public class RPCText
        {
            public static void Set(int Client, string Text)
            {
                if (Notify == true)
                {
                    Games.Call_of_Duty_MW3.RPC.iPrintln(Client, Text);
                }
            }
        }

        public static string GetNames(int clientIndex)
        {
            if (Form1.PS3.Extension.ReadByte(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.GetNames + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClientName)) == 0x00)
            {
                return "Not Connected";
            }
            else
            {
                return Form1.PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.GetNames + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClientName));
            }
        }

        public class TeamBytes
        {
            public static byte[] Team = { 0x01, 0x02, 0x07 };
        }

        public static void ChangeTeam(int Client, byte TeamByte, string team)
        {
            ProjectRunningFox.Games.Call_of_Duty_World_at_War.Functions.WriteByte(ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.ChangeTeam + ProjectRunningFox.Games.Call_of_Duty_MW3.Offsets.Client.NextClient * (uint)Client, TeamByte);
            RPCText.Set(Client, team);
        }
    }
}
