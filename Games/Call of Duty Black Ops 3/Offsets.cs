using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_3
{
    class Offsets
    {
        public static class Client
        {
            public static uint
                gclient = 0x18C6220,
                NextClient = 0x6200,
                NameInGame = 0x18CBFD0,
                NameInGame1 = 0x18D21D0,
                NameInGame2 = 0x18D83D0,
                NameInGame3 = 0x18DE5D0,
                NameInGame4 = 0x18E47D0,
                NameInGame5 = 0x18EA9D0,
                NameInGame6 = 0x18F0BD0,
                NameInGame7 = 0x18F6DD0,
                NameInGame8 = 0x18FCFD0,
                NameInGame9 = 0x19031D0,
                NameInGame10 = 0x19093D0,
                NameInGame11 = 0x190F5D0,
                GetName = gclient + 0x5DB0,
                GodMod = gclient + 0x23, //on = 0x05, 0ff = 0x04
                ThirdPerson = gclient + 0x12D, //01, 00
                SkateMode = gclient + 0x186, //01, 02
                ChangeWeapon = gclient + 0x383,
                ChangeCamo = gclient + 0x389, 
                KillStreak1 = gclient + 0x57B, //01, 00
                KillStreak2 = gclient + 0x57F, //01, 00
                KillStreak3 = gclient + 0x580, //01, 00
                PrimaryAmmo = gclient + 0x586, //FF, 00
                PrimaryClip = gclient + 0x54A, //FF, 00
                SecondaryAmmo = gclient + 0x58A, //FF, 00
                SecondaryClip = gclient + 0x54E, //FF, 00
                LethalAmmo = gclient + 0x58E, //FF, 00
                TatcticalAmmo = gclient + 0x592, //FF, 00
                HUD = gclient + 0x659, //02, 01
                Visibility = gclient + 0x65A, //Normal Invisibility - 0x01 Blue Invisibility - 0x02 0ff = 0x00
                GiveSpecialist = gclient + 0x73B, //01, 00
                DisableKS1 = gclient + 0x8D7, //00, 01
                DisableKS2 = gclient + 0x8CF, //00, 01
                DisableKS3 = gclient + 0x8CB, //00, 01
                OnPlayerSpawn = gclient + 0x5D03, //Spawned - 0x00, Not Spawned + Bloody Screen - 0x01, Real Spectator - 0x02, Spectating Nothing - 0x03
                X2Speed = gclient + 0x5DF8, //40, 3F
                IGScore = gclient + 0x5EB7,
                IGPoints = gclient + 0x5EC7,
                IGKills = gclient + 0x5ECB,
                IGDeaths = gclient + 0x5ECF,
                UAV = gclient + 0x61A3, //01, 00
                LastStand = gclient + 0x61B0; //01, 00

            public static class NonHost
            {
                public static uint
                    UAV = 0xC8998, //0x60, 0x00, 0x00, 0x00  0x41, 0x82, 0x00, 0xAC
                    NoRecoil = 0x1907F0, //0x60 , 0x00 , 0x00 , 0x00  0x48 , 0x5F , 0x6B , 0x79
                    RedBoxes1 = 0x58DF48, //0x60, 0x00, 0x00, 0x00   0x41 , 0x82 , 0x01 , 0xD4
                    RedBoxes2 = 0x58DF10, //0x60, 0x00, 0x00, 0x00  0x41, 0x82, 0x02, 0x0C
                    Name = 0x20DFE78,
                    WallHack = 0x1908E8, //0x38 , 0xC0 , 0xFF , 0xFF   0x63, 0xE6, 0x00, 0x00
                    ClanTag = 0x37EF8FD9, 
                    FPS = 0xCC5A8, //0x2c, 0x14, 0x00, 0x01  0x2c, 0x14, 0x00, 0x00
                    SteadyAim = 0x76A174; //0x2C , 0x04 , 0x00 , 0x00  0x2C , 0x04 , 0x00 , 0x02
            }

            public static class Stats
            {
                public static uint
                    Level = 0x37EF8E65,
                    Tokens = 0x37ef80f7,
                    Prestige = 0x37ef8e45,
                    Kills = 0x37ef86d1,
                    Wins = 0x37f3e8dd,
                    Score = 0x37ef8e87,
                    Deaths = 0x37ef828d,
                    Losses = 0x37ef87af,
                    XP = 0x37ef8e64,
                    TimePlayed = 0x37ef8f65;
            }

            public static class ZMStats
            {
                public static uint
                     Prestige = 0x37DDE5D8,
                     Headshot = 0x37DDE58A,
                     time_of_game = 0x37DDE5D4,
                     game_score = 0x37DDE57E,
                     score_per_minutes = 0x37DDE57E,
                     round_survived = 0x37DDE5A8,
                     kills = 0x37DDE686,
                     liquidDivinium = 0x37DDE674,
                     experiences = 0x37DDE578;
            }

            public static class ClassNames
            {
                public static uint
                    Class1 = 0x37F107B1,
                    Class2 = 0x37F107C1,
                    Class3 = 0x37F107D1,
                    Class4 = 0x37F107E1,
                    Class5 = 0x37F107F1,
                    Class6 = 0x37F10801,
                    Class7 = 0x37F10811,
                    Class8 = 0x37F10821,
                    Class9 = 0x37F10831,
                    Class10 = 0x37F10841;
            }

            public static class MainAddresses
            {
                public static uint
                   SV_GameSendServerCommand = 0x5EC544,
                   ZMSV_GameSendServerCommand = 0x5E0E44,
                   ZMCbuf_AddText = 0x5A657C,
                   Cbuf_AddText = 0x5B1A7C;
            }

            public static class ZMClient
            {
                public static uint
                    GClient = 0x18C42E8,//
                    NextClient = 0x61E0,
                    Points = 0x190DDFC, //0x00, 0xFF, 0xFF, 0xFF
                    PrimaryAmmo = 0x19084EA, //FF, FF
                    PrimaryClip = 0x19084AE, 
                    SecondaryAmmo = 0x19084F2,
                    SecondaryClip = 0x19084B6, 
                    GodMod = 0x19080A0; //01, 00
               
               
            }
        }
    }
}
