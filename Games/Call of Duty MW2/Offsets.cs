using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_MW2
{
    class Offsets
    {
        public static class Client
        {
            public static uint
                NextClient = 0x3700,
                ClanTagInGame = 0x014E54CC,
                NameInGame = 0x014E5490,
                NameInGame1 = 0x014E8B90,
                NameInGame2 = 0x014EC290,
                NameInGame3 = 0x014EF990,
                NameInGame4 = 0x014E3090,
                NameInGame5 = 0x014E6790,
                NameInGame6 = 0x014E9E90,
                NameInGame7 = 0x014ED590,
                NameInGame8 = 0x014E0C90,
                NameInGame9 = 0x014E4390,
                NameInGame10 = 0x014E7A90,
                NameInGame11 = 0x014EB190,
                GodMode = 0x14E235A, //0xFF 0xFF, 0x00 0x64
                WeaponAkimbo = 0x014E2467, // 0x01 //0x00
                WeaponAkimboSecondary = 0x014E245D, // 0x01 //0x00
                MovementMode = 0x014E5623, //Nomal: 0x00 Noclip: 0x01 UFO: 0x02 Freeze: 0x04
                SpeedX2 = 0x014E543C, //0x3F - Off , 0x40 - On
                PrimaryCamo = 0x014e2468, //Desert - 0x01 Arctic - 0x02 Woodland - 0x03 Digital - 0x04 Urban - 0x05 Blue Tiger - 0x07 Red Tiger - 0x06 Fall - 0x08
                SecondaryCamo = 0x014e245e,
                Lag = 0x014e53af, //0x02 - Off , 0x00 - On
                RedBoxes = 0x014e2213, //(0x00 - Off , 0x55 - On)
                Kill = 0x014e2220, //0xC5 - Kill
                Teleport = 0x014e221b, //0x46, 0xFF - Sky 0x60, 0x5C - Space 0xC7, 0x5F - Under Map
                Movement = 0x014e220d, //Auto Prone - 0x55, Disable Jump - 0x04, Disable Sprint - 0x02, Default - 0x00
                SmallCrossHair = 0x014e24d3,  //0x02 - On, 0x00 - Off
                WeaponFlags = 0x014e24be, //Disable Weapons Switch - 0x08 No Recoil - 0x04 Disable Weapons - 0x00, 0x80 Disable ADS- 0x00, 0x20 Default - 0x00, 0x00
                ChnageTeam = 0x014e5453, //0x00 - FFA 0x01 - OpFor/Spetznas 0x02 - TF141/Rangers 0x03 - Spectator
                Kills = 0x014e53a0,
                Assists = 0x014e53a4,
                Deaths = 0x014e539c,
                Score = 0x014e5398,
                Prestige = 0x014e54bb,
                Level = 0x014e54b7, // (0x45 , 0xFF - Level 70)
                Visions = 0x014e2213, //0x09 - Thermal Vision 0x60 - Small Volume 0x00 - Off
                Skate = 0x014e220e, // (0x01 - On , 0x00 - Off)
                KillandScare = 0x14E2224, //(0xFF, 0xFF)
                AllPerks = 0x014e262a, //0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF
                ExplosiveBullets = 0x014e2628, //(0xFF, 0xEF - On , 0x00 , 0x08 - Off)
                AutoKill = 0x01319901, //(0x01 - On | 0x00 - Off) - 0x280 Index
                NightVisionPressDown = 0x14e2657, //(0xFF ON / 0x00 OFF)
                UAV = 0x14E54E6, //(0x01 - On , 0x00 - Off)
                CounterUAV = 0x14E54EB, ////(0x01 - On , 0x00 - Off)
                MiniMap = 0x14E23B7, //0x01, 0x00

                PrimaryClip = 0x014E24EC, // 0x0F, 0xFF, 0xFF, 0xFF | 0x00, 0x00, 0x00, 0x64
                Primary = 0x014E256C,
                SecondaryClip = 0x014E24DC,
                Secondary = 0x014E2554,
                GrenadeAmmo = 0x014E2578,
                AkimboPrimaryBullets = 0x014e2570,
                AkimboSecondaryWeapon = 0x014e2558,
                GranadeLuncherAmmoBullets = 0x014e2578,
                GranadeLuncherAmmoClip = 0x014e24f4,
                Equipment = 0x014E2560;
        }

        public static int ClientIndex = 0;
        public static int MaxClients = 12;
        public class ClassNames
        {
            public static uint
               Class1 = 0x01FF9E6C,
               Class2 = 0x01FF9EAC,
               Class3 = 0x01FF9EEC,
               Class4 = 0x01FF9F2C,
               Class5 = 0x01FF9F6C,
               Class6 = 0x01FF9FAC,
               Class7 = 0x01FF9FEC,
               Class8 = 0x01FFA02C,
               Class9 = 0x01FFA06C,
               Class10 = 0x01FFA0AC;
        }

        public class Addresses
        {
            public static uint
                Sv_GameSendServerCommand = 0x0021A0A0,
                FPSTextSize = 0x007291A4, 
                FPSLocation1 = 0x00729418,
                FPSLocation2 = 0x00729318,
                FPS = 0x00253AC8; //40 = ON 41 = off
        }


        public class Stats
        {
            public static uint
               UnlockAll = 0x01ffa0c7, 
               Prestige = 0x01ff9a9c,
               XP = 0x01ff9a94,
               Score = 0x01ff9aa4,
               Kills = 0x01ff9aa8,
               Deaths = 0x01ff9ab0,
               Assists = 0x01ff9ab8,
               TimePlayed = 0x01ff9ac8,
               TimePlayed1 = 0x01ff9acc,
               Wins = 0x01ff9adc,
               Losses = 0x01ff9ae0,
               Ties = 0x01ff9ae4,
               WinStreak = 0x01ff9ae8,
               KillStreak = 0x01ff9aac,
               HeadShots = 0x01ff9abc;
        }


        public class Nonhost
        {
            public static uint
                Name = 0x01f9f11c,
                RedBoxes = 0x496F4, 
                NoRecoil = 0x9342C, 
                Laser = 0x8C7B8, 
                FOV = 0x01d17f90, 
                UAV = 0x01d1ff04; 

        }
    }
}
