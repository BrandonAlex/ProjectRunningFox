using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_World_at_War
{
    class Scripts
    {
        public static void GodModeOn(int Client)
        {
            Functions.SetMem(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.GodMode + (ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient * (uint)Client), new byte[] { 0x08 });
        }

        public static void Cbuf_AddText(UInt32 client, string text)
        {
            RPC.Call(0x00329CC8, client, text);
        }

        public static string GetNames(int clientIndex)
        {
            if (Form1.PS3.Extension.ReadByte(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient)) == 0x00)
            {
                return "Not Connected";
            }
            else
            {
                return Form1.PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame + ((uint)clientIndex * ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient));
            }
        }

        public static string GetClients(int Client)
        {
            return Form1.PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NameInGame + ProjectRunningFox.Games.Call_of_Duty_World_at_War.Offsets.Client.NextClient * (uint)Client);
        }
    }
}
