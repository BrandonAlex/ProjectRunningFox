using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.The_Last_of_US
{
    class Offsets
    {
        public class HostMods
        {
            public static uint
                GodMode = 0x7CAF50,
                GodMode1 = 0xE8BC74,
                GodMode2 = 0xE8BC78,
                GodMode3 = 0xE8BC7C,
                GodMode4 = 0xE8BC80,
                GodMode5 = 0xE8BC84, 
                Oxygen = 0x53AE78,
                Ammo = 0x6B1D94, 
                Items = 0x336C0,
                Smoke = 0xA7D768, 
                FlameThrower = 0x6B9148,
                FlameThrower1 = 0x6B6AD0,
                Money = 0x2F78C8,
                Money2 = 0x2F78CC,
                Money3 = 0x2F78D0;
        }
    }
}

/*
In-Game Score

Entry = 0x13B8E60

Client 0 [Entry + 0x4]
Client 1 [Entry + 0xA4C]
Client 2 [Entry + 0x6DC]
Client 3 [Entry + 0x1B4]
Client 4 [Entry + 0x524]
Client 5 [Entry + 0xC04]
Client 6 [Entry + 0x36C]
Client 7 [Entry + 0x894]
 * 
 * 
 * 1.07 FPS NEEDS UPDATED
 * 0xA878DC - Draw FPS
40 On/41 Off
0x134CB40 - Fps String
 * 
*/