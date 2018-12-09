using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Modern_Warfare
{
    class Offsets
    {
        public static int ClientIndex = 0;
        public static int MaxClients = 12;

        public class Stats
        {
            public static uint
                XP = 0x12c00ed0,
                Prestige = 0x12c00f34, 
                Kills = 0x12c00ed8,
                Deaths = 0x12c00ee0, 
                Streaks = 0x12c00edc,
                Assists = 0x12c00ee8,
                Score = 0x12c00ed4, 
                Headshots = 0x12c00eec,
                TimePlayed = 0x12c00ef8,
                Wins = 0x12c00f0c,
                Losses = 0x12c00f10,
                Misses = 0x12c00f28,
                Hits = 0x12c00f24,
                UnlockAll = 0x12C010D0; 
        }

        public class Client
        {
            public static uint
                 Interval = 0x31B4,
                 GetNames = 0x108bbd0c,
                 NameInGame = 0x108bbd0c,
                 NameInGame1 = 0x139A284,
                 NameInGame2 = 0x139CCBC,
                 NameInGame3 = 0x139F6F4,
                 NameInGame4 = 0x139212C,
                 NameInGame5 = 0x1394B64,
                 NameInGame6 = 0x139759C,
                 NameInGame7 = 0x1399FD4,
                 NameInGame8 = 0x139CA0C,
                 NameInGame9 = 0x139F444,
                 NameInGame10 = 0x1391E7C,
                 NameInGame11 = 0x13948B4,
                 ClanTagInGame = 0x108bbd40,
                 GodMod = 0x108bbcd5, 
                 PrimaryAmmo = 0x108b9076, 
                 AllPerks = 0x108b92b0,
                 PrimaryClip = 0x108b8e22, 
                 SecondaryAmmo = 0x108b9032, 
                 SecondaryClip = 0x108b8e2e, 
                 GrenadeLauncherClip = 0x108b8e46, 
                 GrenadeLauncherAmmo = 0x108b907a, 
                 LethalAmmo = 0x108b90ae, 
                 TacticalAmmo = 0x108b90b2, 
                 Location = 0x108b8ccb, 
                 GiveLag = 0x108bbc43, 
                 Jumper = 0x108bbcc0, 
                 SpeedX2 = 0x108bbcc1, 
                 mFlag = 0x108BBD58, 
                 ChnageTeam = 0x108bbcd7, //Free For All: 0x00 Spector: 0x03 Marines/S.A.S: 0x02 OpFor/Spetsnaz: 0x01
                 TimeScale = 0x10966080, 
                 KickClient = 0x108b8d3e; 
        }

        public class Addresses
        {
            public static uint
                SV_GameSendServerCommand = 0x1C5E40;
        }


        public class Nonhost
        {
            public static uint
                Name = 0x122a4c64,
                GunMovement = 0x10110F76; 
        }
    }
}