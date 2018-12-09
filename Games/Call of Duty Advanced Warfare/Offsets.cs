using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Advanced_Warfare
{
    class Offsets
    {
        public static class Client
        {
            public static uint
                G_Client = 0x1AEE380,
                G_Entity = 0x19FE380,
                NextClient = 0x4180, 
                GetNames = 0x1AF16B4,
                NameInGame = 0x1AF1EBC,
                NameInGame1 = 0x1AF603C,
                NameInGame2 = 0x1AFA1BC,
                NameInGame3 = 0x1AFE33C,
                NameInGame4 = 0x1AF24BC,
                NameInGame5 = 0x1AF663C,
                NameInGame6 = 0x1AF1EBC,
                NameInGame7 = 0x1AFA7BC,
                NameInGame8 = 0x1AFE93C,
                NameInGame9 = 0x1AF2ABC,
                NameInGame10 = 0x1AF6C3C,
                NameInGame11 = 0x1AFADBC,
                GModInterval = 0x280,
                GodMode = 0x19FE52C,//On: 0x00, 0x00, 0xFF, 0xFF Off:  0x00, 0x00, 0x00, 0x00
                PrimaryAmmo = 0x1AEEA3D, //FF, 00 00
                SecondaryAmmo = 0x1AEEA0D,
                ExoLauncherAmmo = 0x1AEEA25,
                Team = 0x1AF165F,
                mFlag =  0x1AF1927, //1, 0
                FakeLag = 0x1AF159B, //FF, 00
                Speed = 0x1AF1654, //64, 63
                Laser = 0x1AEE3D9, //01, 00
                RedBoxes = 0x1AEE3DF, //15, 1
                ThirdPerson = 0x1AEE3DF, //14, 1
                ExoCloak = 0x1AEE3D8, //FF, 00
                NoFriction = 0x1AEE3D6, //01, 00
                ButtonMonitoring = 0x1AF1936,
                Origin = 0x1AEE3F8,
                Angles = 0x1AEE530;
        }
        public static int ClientIndex = 0;
        public static int MaxClients = 12;
        public class Addresses
        {
            public static uint
                Sv_GameSendServerCommand = 0x45799C,
                FPS = 0x4CABE4,
                Cbuf_AddText = 0x3AF41C,
                G_Client = 0x1AEE380,
                G_Entity = 0x19FE380,
                G_SetModel = 0x388294, 
                FPSTextSize = 0x4CAB3C,
                TextFPS = 0x7CC8DC; //fps: %f
        }
        public class ClassNames
        {
            public static uint
                Class1 = 0x2AEC351,
                Class2 = 0x2AEC3D1,
                Class3 = 0x2AEC451,
                Class4 = 0x2AEC4D1,
                Class5 = 0x2AEC551,
                Class6 = 0x2AEC5D1,
                Class7 = 0x2AEC651,
                Class8 = 0x2AEC6D1,
                Class9 = 0x2AEC751,
                Class10 = 0x2AEC7D1;

        }
        public class Stats
        {
            public static uint
              EntryStats = 0x2AE7568,
              Prestige = 0x2AE7575,
              Level = 0x2AE7611,
              Score = 0x2AE764E,
              Kills = 0x2AE7625,
              Deaths = 0x2AE75FD,
              Accuracy = 0x2AE75B9,
              Wins = 0x2AE67A,
              Losses = 0x2AE762D,
              GamePlayed = 0x2AE7615,
              TimePlayed = 0x2AE766A,
              UnlockAll = 0x2AECD9C;
        }

        public static class Lobby
        {
            public static uint
                AntiBan1 = 0x5BC8DC, 
                AntiBan2 = 0x5BC8E4,
                AntiBan3 = 0x5BCDD4,
                AntiBan4 = 0x5BEE7C,
                AntiBan5 = 0x5BEE54,
                AntiBan6 = 0x5BEE60,
                AntiBan7 = 0x5BEE68,
                KnockBack = 0x2736F3C,
                GunPosX = 0x274C4AC,
                GunPosY = 0x274C4F4,
                GunPosZ = 0x274C53C,
                FOV = 0x02751870,
                LobbyJump = 0x27516CC,
                LobbyGodMod = 0x323AD8;
        }


        public class Nonhost
        {
            public static uint
                AdvancedUAV = 0x1A7080, 
                Laser = 0x21BE34, 
                Name = 0x2A80BE8, 
                NoRecoil = 0x2290B0, 
                WallHack = 0x1DE210, 
                RedBoxes = 0x1AF6FC, 
                SteadyAim = 0x18787C; 
        }
    }
}
