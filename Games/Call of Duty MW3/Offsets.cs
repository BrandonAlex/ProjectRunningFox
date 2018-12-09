using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_MW3
{
    class Offsets
    {
        public static class Client
        {
            public static uint
                NextClient = 0x280,
                NextClientName = 136,
                GetNames =  0x0110d60c, 
                NameInGame = 0x0110D694,
                NameInGame1 = 0x01111014,
                NameInGame2 = 0x01114994,
                NameInGame3 = 0x01118314,
                NameInGame4 = 0x0111BC94,
                NameInGame5 = 0x0111F614,
                NameInGame6 = 0x01122F94,
                NameInGame7 = 0x01126914,
                NameInGame8 = 0x0112A294,
                NameInGame9 = 0x0112DC14,
                NameInGame10 = 0x01131594,
                NameInGame11 = 0x01134F14,
                PrimaryAmmo = 0x0110a6ab, //ff 64
                WallHack = 0x00173b62, //Use 01 2c for wall breach, 02 81 to turn off
                SecondaryOffset = 0x011a693, 
                Tatical = 0x0110a6b7, 
                Lethal = 0x0110a69f, 
                GodMode = 0x0FCA41E, //(0x280 *i for other clients) FF = on, 00 = off
                UFOMode = 0x0110d87f, //Use 02 for ufo, 00 to take it off
                Laser = 0x000b6703, //Use 01 for on, 00 for off
                Teleport = 0x0110A29C, 
                Suicide = 0x0110a2a5, //FF
                GoldClanTag = 0x00892C13, //on = 01, 00
                ExplosiveBUllets = 0x0110A773,//OFF = 00 00  ON = FF 00
                RedBoxes = 0x0110a293, //Use 10 for red boxes, 00 to turn off
                Freeze = 0x0110d87f, //use 07 for freeze, 00 to unfreeze
                ChangeTeam = 0x0110d657, //Use 01 for your team, 02 for enemy team, 07 for spectator team
                LobbyJumpHeight = 0x000019780, //Normal 42 9c 00, High 44 f9 c0, super 40 00 00
                LobbySpeed = 0x000173B60, //Noraml 38 a0 00 be, super 38 a0 07 d0
                NightVision = 0x0110a5f7; //Use FF for night vision, 00 to turn off

                
        }

        public static int ClientIndex = 0;
        public static int MaxClients = 12;
        public class ClassNames
        {
            public static uint
               Class1 = 0x01c1982c,
               Class2 = 0x01c1988e,
               Class3 = 0x01c198f0,
               Class4 = 0x01c19952,
               Class5 = 0x01c199b4,
               Class6 = 0x01c19a16,
               Class7 = 0x01c19a78,
               Class8 = 0x01c19ada,
               Class9 = 0x01c19b3c,
               Class10 = 0x01c19b9e;
        }

            public class Addresses
            {
                public static uint
                    Sv_GameSendServerCommand = 0x228FA8, 
                    G_SetModel = 0x1BEF5C,
                    FPS = 0x277208, //40, 00
                    MapName = 0x01810722, 
                    GameModeName = 0x01893fa9,
                    FPSTextPosition = 0x277150,
                    FPSTextSize = 0x27714c,
                    TextFPS = 0x554d84; //fps: %f
            }


            public class Stats
            {
                public static uint
                   GodModeClass = 0x01c19865, //01 27 00 09 00 00 00 00 00 86 00 00 00 07 00 09 00 00 00 00 00 86 00 00 00 6A 00 0F 00 11 00 08 00 00 00 61 00 83 00 00 00 73 77 61 67 2E 63 6C 61 73 73 00 73 73 20 32 00 54 20 31 00 00 76 00 20 00 20 00 20 00 13 00 14 00 19 00 2D 00 26 00 27 00 02 00 00 00 04 00 00 00 06 00 6B 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 37
                   Prestige = 0x01c1947c,
                   XP = 0x01c1926c,
                   Score = 0x01c19484,
                   Kills = 0x01c194ac,
                   Deaths = 0x01c194b4,
                   KillStreak = 0x01c194b0,
                   Wins = 0x01c194e0,
                   ClanTag = 0x00892C0E, //(Add { To Make It Unbound)
                   GMClass1 = 0x01c1985f,
                   GMClass2 = 0x01c198c1, 
                   GMClass3 = 0x01c19923, 
                   GMClass4 = 0x01c19985,
                   GMClass5 = 0x01c199e7,
                   GMClass6 = 0x01c19a49,
                   GMClass7 = 0x01c19aab,
                   GMClass8 = 0x01c19b0d, 
                   GMClass9 = 0x01c19b6f,
                   GMClass10 = 0x01c19bd1,
                   Losses = 0x01c194e4,
                   Ties = 0x01c194e8,
                   WinStreak = 0x01c194ec,
                   Assists = 0x01c194bc,
                   Headshots = 0x01c194c0,
                   Hits = 0x01c194f8,
                   Misses = 0x01c194fc,
                   Tokens = 0x01c1b2db,
                   MOTD =  0x005357F0, 
                   TimePlayed = 0x01c194d0,
                   DoubleXP = 0x01C1B331,
                   DoubleWeaponXP = 0x01C1B339;
            }


            public class Nonhost
            {
                public static uint
                    Name = 0x001bbbc2c,
                    MapColor = 0x018C654B, //00 00 00 00 00 - Black, 00 00 00 00 01 - Defualt, 00 00 00 00 02 - White 00 00 00 00 03 - Cartoon
                    Visions = 0x018C66DA, //00 00 00 56 78 AC 00 4C 01 01 3F 80 - Defualt 00 00 00 56 78 AC 00 4C 01 01 39 80 - Evening 00 00 00 56 78 AC 00 4C 01 01 50 80 - Black & White 00 00 00 56 78 AC 00 4C 01 01 3F FF - Flashy
                    ChromePlayers = 0x3984DF, //01, 00
                    ChromePlayers2 = 0x3984F2, //05 70, 05 6A
                    FOV = 0x018C643A,
                    ClanTag = 0x00892C0E,
                    NoFog = 0x018C9158, //00 00 00 00 00 53 C5 48 00 44 05 00 01 - On, 00 00 00 00 00 53 C5 48 00 44 05 00 00 - Off
                    ScreenOptions = 0x018C6437, //D4 00 04 04 00 00 00 00 00 3F 80 00 00 00 00 00 00 3F 80 00 - Defualt D4 00 04 04 00 00 00 00 00 4F 80 00 00 00 00 00 00 3F 80 00 - Blind (Black Screen)  D4 00 04 04 00 40 00 00 00 8F 80 00 00 00 00 00 00 3F 80 00 - Wind Screen 
                    GameBrightNess = 0x018C64B8, //01 8C 4E 6C 00 56 76 64 00 04 00 00 01 - Sunny 01 8C 4E 6C 00 56 76 64 00 04 00 00 00 - Darkness
                    WallHack = 0x018C6476, //ON:01 2C OFF:02 81
                    AdvancedUAV = 0x018db8c4; //On is 02, for off use 0x01

            }
        }
    }

