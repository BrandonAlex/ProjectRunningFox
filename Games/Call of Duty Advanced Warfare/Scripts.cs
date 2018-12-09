using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare
{
    class Scripts
    {

        public static bool Notify = false;

        public static string GetNames(int clientIndex)
        {
            if (Form1.PS3.Extension.ReadByte(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.GetNames + ((uint)clientIndex * 0x3980)) == 0x00)
            {
                return "Not Connected";
            }
            else
            {
                return Form1.PS3.Extension.ReadString(ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.Offsets.Client.GetNames + ((uint)clientIndex * 0x3980));
            }
        }

        public class RPCText
        {
            public static void Set(int Client, string Text)
            {
                if (Notify == true)
                {
                    ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare.RPC.iPrintln(Client, Text);
                }
            }
        }
    }
}
