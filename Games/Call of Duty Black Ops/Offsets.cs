using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops
{
    class Offsets
    {
        public static int ClientIndex = 0;
        public static int MaxClients = 12;
        public static int ZombiesMaxClients = 4;


        public class Stats
        {
            public static uint
                CODPoints = 0x020942d1,
                TimePlayed = 0x02094731,
                TotalWins = 0x0209475d,
                TotalLosses = 0x020944dd,
                Prestige = 0x020946dd,
                Score = 0x020946e5,
                Kills = 0x02094429,
                Deaths = 0x020942f5,
                Assists = 0x02094291,
                Headshots = 0x0209440d,
                ContractsAmountSpent = 0x020942dd,
                ContractsPurchased = 0x020942e1,
                XPAwardsContracts = 0x020942e5,
                AmountEarnedContracts = 0x020942d9,
                GamesPlayed = 0x020938b1,
                WagerMatchEarnings = 0x020944d9,
                UnlockAll = 0x02094990;
        }

        public class Client
        {
            public static uint
                 Interval = 0x2A38,
                 GetNames = 0x139784C, 
                 NameInGame = 0x139784C,
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
                 LobbySuperJump = 0x008CF430,
                 NoFallDamage = 0x81B64,
                 mFlags = 0x13979BF, //0x01 for noclip,0x02 for ufo 00
                 NoTarget = 0x110079B,
                 MoonName = 0x13A5D77,
                 PlayerCMD_EnableInvulnerability = 0x25AE80,
                 PlayerCMD_DisableInvulnerability = 0x25AD90,
                 BlackBird = 0x1397AEB, //0x01 On, 0x00 Off
                 YellowMap = 0x01395674, //ON = 0x60, OFF = 0x00
                 BigMap = 0x01395583, //On = 0x01, OFF = 0x00
                 AllPerks = 0x013955f3, //ON = 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, OFF = 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                 Invisibility = 0x013951a9, //ON = 0x01, OFF = 0x00
                 ReconPlane = 0x1397967, //0x03 for On, 0x00 for Off
                 SecondChance = 0x1397AEC, //ON = 0x01, OFF = 0x00
                 CheckerBoard = 0x013950db, //ON = 0xFA, OFF = 0x00
                 Speed = 0x1397880, //0x40,0x40 for super, 0x3F 0x80 for default, 0x00,0x00 for freeze
                 IngameCamo = 0x013952E0, //60 for gold, 10 for ice,13 for red,10 for olive,20 for nevada,0x18 for sahara
                 Teleport = 0x13950f0,
                 GodMod = 0x013950df, //ON = 0x05, OFF: 0x04
                 UnlimitedAmmo = 0x13950c8 + 0x388,
                 UnlimitedAmmo1 = 0x13950c8 + 0x400,
                 UnlimitedAmmo2 = 0x13950c8 + 0x380,
                 UnlimitedAmmo3 = 0x13950c8 + 0x3f8,
                 UnlimitedAmmo4 = 0x13950c8 + 0x410,
                 UnlimitedAmmo5 = 0x13950c8 + 0x408;
        }

        public class Addresses
        {
            public static uint
                FPS = 0x00466298, //40 00 - ON 40 9A - OFF
                ZombiesFPS = 0x00407554,
                ZombiesTextFPS = 0x008283a8,
                ZombiesTextSize = 0x0082794c,
                FPSText = 0x0091C860,
                FPSTextSize = 0x0091BF34;
        }

        public class ClassNames
        {
            public static uint
                GMIClass1 = 0x0208b8f2, //0xE7
                GMIClass2 = 0x0208b915, //0xE7
                GMIClass3 = 0x0208b938, //0xE7
                GMIClass4 = 0x0208b95b, //0xE7
                GMIClass5 = 0x0208b97e, //0xE7
                GMIClass6 = 0x0208b9a5, //0xCE
                GMIClass7 = 0x0208b9c8, //0xCE
                GMIClass8 = 0x0208b9eb, //0xCE
                GMIClass9 = 0x0208ba0e, //0xCE
                GMIClass10 = 0x0208ba31, ////0xCE
                Class15 = 0x01c3896f,
                Class610 = 0x01c43cf4;
        }

        public class Zombies
        {
            public static uint
                LobbyName = 0x01C33DB0,
                MOTD = 0x01c8004c,
                ClientInterval = 0x1d30,
                InGameName = 0x011008B8,
                InGameName1 = 0x011025E8,
                InGameName2 = 0x01104318,
                InGameName3 = 0x01106048,
                InGameName4 = 0x01107D78,
                InGameName5 = 0x01109AA8,
                InGameName6 = 0x0110B7D8,
                InGameName7 = 0x0110D508,
                InGameName8 = 0x0110F238,
                InGameName9 = 0x01100F68,
                InGameName10 = 0x01102C98,
                InGameName11 = 0x011049C8,
                GodMod = 0x01100840, //0x08,0x88,0x08,0x88 for On, 0x00,0x00,0x00,0x64 for Off 
                Ammo1 = 0x010FF138, //15,0xff,0xff,0xff for On
                Ammo2 = 0x010FF148,
                Ammo3 = 0x010FF160,
                Ammo4 = 0x010FF140,
                Ammo5 = 0x010FF168,
                Ammo6 = 0x010FF150,
                mFlags = 0x0110098F, 
                PrimaryWeapon = 0x010fef6f,
                SecondaryWeapon = 0x010fef9f,
                DeadOpsArcadeWeapon = 0x010FEF57, //FlameThrower- 0A ShotGun- 0E RayGun- 0B RegularGun- 0C MiniGun- 0D GranadeLuancher- 0F
                Modes = 0x0110079B, //0x01 for notarget, 0x02 for spectator,0x00 for default
                Money = 0x0110090C,
                Ingamekills = 0x01100910,
                InGameHeadshots = 0x01100930,
                InGameRevives = 0x0110092C,
                InGameDowns = 0x01100928,
                SuperJump = 0x007E3498, //0x49, 0x00, 0x00 ON / 0x42, 0x9C, 0x00 OFF
                NoFallDamage = 0x79038, //0x40 ON / 0x41 OFF
                Speed = 0x01100854;//0x40, 0x74 for super,0x00, 0x00 for freeze,0x3f, 0x80 for default
        }

        public class Nonhost
        {
            public static uint
                Name = 0x02000934,
                ClassName1 = 0x01C43B64,
                ClassName2 = 0x01C43B74,
                ClassName3 = 0x01C43C04,
                ClassName4 = 0x01C43C14,
                ClassName5 = 0x01C43C24,
                ClassName6 = 0x01C43C34,
                ClassName7 = 0x01C43C44,
                ClassName8 = 0x01C43C54,
                ClassName9 = 0x01C43C64,
                ClassName10 = 0x01C43C74,
                NoRecoil = 0x19B244, //0x60,0x00,0x00,0x00 for On, 0x4B, 0xF1, 0x84, 0xCD for Off
                WallHack = 0x131144, //0x38, 0xC0, 0xF0, 0x03 for On,0xFC, 0xC0, 0xF8, 0x90 for Off
                RedBoxes = 0x001205C0, //0x60,0x00,0x00,0x00 | 0x41, 0x86, 0x02, 0x78
                PerkCheckOffset = 0x001206C8, //0x60,0x00,0x00,0x00
                SleightofHand = 0xBBC2E8, //0x02 for on, 0x01 for off
                ChromePlayer = 0x131144, //0x38, 0xC0, 0xFF, 0xFF for On, 0xFC, 0xC0, 0xF8, 0x90 for Off
                RapidFire = 0xBBC2EC, //0x02 for On, 0x01 for Off
                ZombiesNoRecoil = 0x15A320, //ON 0x60, 0x00, 0x00, 0x00 ,OFF 0x4B, 0xF3, 0xFF, 0x89
                ZombiesSteadyAim = 0x91014, //ON 2F 80 00 00, OFF 2F 80 00 02
                BlackBird = 0xEBDF4, //0x40, 0x9A, 0x00, 0xC4 for On, 0x41, 0x9A, 0x00, 0xC4 for Off
                SteadyAim = 0xAB8EC; //0x60,0x00,0x00,0x00 for On, 0x2F, 0x80, 0x00, 0x02 for Off
        }
    }
}