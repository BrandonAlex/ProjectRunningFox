using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_World_at_War
{
    class Offsets
    {
        public class Client
        {
            public static uint
                NextClient = 0x3BEC,
                ClanTagInGame = 0x011c0c50,
                NameInGame = 0x011c0c14,
                NameInGame1 = 0x011c4800,
                NameInGame2 = 0x011c83ec,
                NameInGame3 = 0x011cbfd8,
                NameInGame4 = 0x011cfbc4,
                NameInGame5 = 0x011c37b0,
                NameInGame6 = 0x011c739c,
                NameInGame7 = 0x011caf88,
                NameInGame8 = 0x011ceb74,
                NameInGame9 = 0x011c2760,
                NameInGame10 = 0x011c634c,
                NameInGame11 = 0x011c9f38,
                GodMode = 0x011c0bdf, //0x08, 0x03
                SpeedX2 = 0x011c0bc8, //0x40, 0x3f
                Teleport = 0x011bd17c,
                DrunkVision = 0x011be13b, //0xff, 0x02
                PlayerLag = 0x011c0b33, //0x00, 0x02
                UFOMode = 0x011c0c79, //0x02, 0x00
                NoClip = 0x011c0c7b, //0x01, 0x00
                InvisibleWeapon = 0x011c0bce, //0x00, 0x01
                BloodyVision = 0x011c0cac, //0x02, 0x00
                WeirdGun = 0x011c0bcf, //0x01, 0x02
                Freeze = 0x011c0c80, //0x01, 0x00
                CrosshairSize = 0x11C0B05, //0x80, 0x66, 0x66 \ 0x40, 0x40, 0x40
                StandUp = 0x11BD294, //0x60, 0x00
                Crouch = 0x11BD295, //0x00, 0x60 
                //Model = 0x10C58D0 + (client * 0x330) + 0x19C;
                PrimaryClip = 0x011bdcfb, // ( On: 0x0F | Off: 0x64 )
                PrimaryLeftAmmo = 0x011bd32f,  //( On: 0x0F | Off: 0x64 )
                SideArmClipAmmo = 0x011bdbdf, //( On: 0x0F | Off: 0x64 )
                SideArmLeftAmmo = 0x011bd2df, //( On: 0x0F | Off: 0x64 )
                GrenadeAmmo = 0x011bd2df, //( On: 0x0F | Off: 0x64 )
                TacticalAmmo = 0x011bdc67; //( On: 0x0F | Off: 0x64 )
        }

        public static int MaxClients = 12;
        public static int ClientIndex = 0;

        public class ClassNames
        {
            public static uint
               Class1 = 0x02BCE1CC,
               Class2 = 0x02BCE1C0,
               Class3 = 0x02BCE1E0,
               Class4 = 0x02BCE1f8,
               Class5 = 0x02BCE210,
               Class6 = 0x02BCE228,
               Class7 = 0x02BCE300,
               Class8 = 0x02BCE318,
               Class9 = 0x02BCE330,
               Class10 = 0x02BCE350;
        }

        public class Addresses
        {
            public static uint
                Sv_GameSendServerCommand = 0x361410,
                PlayersOnline = 0x02BCE588,
                Cbuf_AddText = 0x329CC8,
                MOTD = 0x0291BA60;
        }


        public class Stats
        {
            public static uint
               UnlockAll = 0x02991f45,
               Prestige = 0x02991dc7,
               XP = 0x02991d60,
               Kills = 0x02991d6b,
               Deaths = 0x02991d73,
               HeadShots = 0x02991d7f,
               Beststreak = 0x02991d6f,
               TimePlayedDays = 0x2627348,
               TimePlayedHours = 0x0262734B,
               TimePlayedMinutes = 0x0262734E;
        }


        public class Nonhost
        {
            public static uint
                Name = 0x02952934,
                UI_ShowList = 0x27636AC, //0n = 0x01, 0x00
                Crosshair = 0x27639E8, //on = 0x01, 0x00 
                Field_of_view = 0x274DB29, //float val, 0x00
                HudsOff = 0x274DCF4, //0x00, 0x01
                LagOMeter = 0x274EE90, //0x01, 0x00
                Laser = 0x274FDA8, //0x01, 0x00
                ThirdPerson = 0x2750648, //0x01, 0x00
                DrawGun = 0x274D9B8, //0x01, 0x00
                WallHack = 0x275BB0C, //0x42, 0xA0, \ 0x40, 0x80
                Fog = 0x275BC20, //0x01, 0x00
                PartyNameColorRed = 0x27637C0,
                PartyNameColorGreen = 0x27637C1,
                PartyNameColorBlue = 0x27637C2,
                PartyNameColorAlpha = 0x27637C3,
                CompassSize = 0x2752C61, //FLoat Val, 0x00
                FarKnife = 0x27575B0, //0x4F, 0xFF \ 0x43, 0x80
                SustainAmmo = 0x2755FC4, //0x01, 0x00
                FlameVision = 0x275F31C, //0x01, 0x00
                WaterVision = 0x275F710, //0x01, 0x00 
                Blur = 0x275E404, //0x40, 0x00
                DofTweak = 0x275ED00, //0x01, 0x00
                BlackandWhite = 0x275FAA8, //0x01, 0x00
                MapColor = 0x275BF03, //Chrome = 0x06, Black = 0x00, Snow = 0x02, default = 0x01
                ClanTag = 0x00B1C078;

        }
    }
}
