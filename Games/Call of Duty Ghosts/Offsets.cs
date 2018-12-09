using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Ghosts
{
    class Offsets
    {

        public static int ClientIndex = 0;
        public static int MaxClients = 12;

        public class Client
        {
            public static uint
                Interval = 0x3700,
                UAV = 0xF47AE5,
                AllPerks = 0xF453AA,
                Kill = 0xF449A4,
                NoCLip = 0xF47C9F,
                Lazer = 0xF44AA5,
                ClientIndex = 0,
                ImpactBullets = 0xF47A53,
                RedBox = 0xF44993,
                SkateMod = 0xF4498E,
                ThirdPerson = 0xF44993,
                Teleport = 0xF4499B,
                mflag = 0xF47C9F,
                PlayerSpeed = 0xF479D0,
                GiveLag = 0xF4791F,
                Freeze = 0xF47C9F,
                ChangeTeam = 0xF479E3,
                GreenCheckBox = 0xF44DA3,
                AkimboPrimary = 0xF44CC1,
                AkimboSeonday = 0xF44CD1,
                GodMod = 0xE04B2A,
                JetPack = 0xF449B0,
                ButtonMonitoring = 0xF47CB0,
                Models = 0xE04AF1,
                ChangeName = 0xF47A1C,
                NameInGame = 0xF47A1C,
                NameInGame1 = 0xF4B11C,
                NameInGame2 = 0xF4E81C,
                NameInGame3 = 0xF51F1C,
                NameInGame4 = 0xF5561C,
                NameInGame5 = 0xF58D1C,
                NameInGame6 = 0xF5C41C,
                NameInGame7 = 0xF5FB1C,
                NameInGame8 = 0xF6321C,
                NameInGame9 = 0xF6691C,
                NameInGame10 = 0xF6A01C,
                NameInGame11 = 0xF6D71C,
                KillsParty = 0xF47AD3,
                DeathsParty = 0xF47AD5,
                ScoreParty = 0xF47AD0,
                AssistParty = 0xF47AD7,
                ExtMoney = 0x0C4ED1C,
                Ammo1 = 0xF44EDA,
                Ammo2 = 0xF44EEA,
                Ammo3 = 0xF44ECA,
                Ammo4 = 0xF44EBA,
                Ammo5 = 0xF44EFA;
        }
        public class HudAddresses
        {
            public static uint
                G_HudHelem = 0xD87C88,
                Fix_Hud = 0x3438F,
                Level_Locals_T = 0xDB5D04,
                G_LocalizedStringIndex = 0x34348,
                FPS1 = 0x36DB00,
                EnableFPS = 0x0036DB0E,
                FPSString = 0x00857BA8;
        }

        public class Protection
        {
            public static uint
                Antiban1 = 0x700ADC,
                Antiban2 = 0x6FF4D8,
                Antiban3 = 0x6FF164,
                Antiban4 = 0x700AD4,
                Antiban5 = 0x700AD8,
                Antiban6 = 0x6F41E8;
        }

        public class ClassNames
        {
            public static uint
               Class1 = 0x179EABB,
               Class2 = 0x179EB3B,
               Class3 = 0x179EBBB,
               Class4 = 0x179EC3B,
               Class5 = 0x179ECBB,
               Class6 = 0x179ED3B,
               Class7 = 0x17B9F95,
               Class8 = 0x17BA012,
               Class9 = 0x17BA08F,
               Class10 = 0x17BA10C,
               ClassNameInterval = 0x564;
        }

        public class Addresses
        {
            public static uint
                Function_Address = 0x4851456,
                Teleport = G_client + 0x1C,
                PlayerCmd_ClonePlayer = 0x2F19CC,
                G_Spawn = 0x290E58,
                Jetpack = G_client + 0x30,
                ClientInterval = 0x3700, 
                ClientIndex = 0,
                G_SetModel = 0x28FA4C,
                G_TempEntity = 0x2916AC,
                G_EffectIndex = 0x2E8AE8,
                G_SpawnTurret = 0x2A2A40,
                G_Entity = 0xE04980,
                G_client = 0xF44980,
                Cbuf_AddText = 0x2B1C14,
                SV_GameSendServerCommand = 0x672444,
                G_GivePlayerWeapon = 0x2947FC,
                Add_Ammo = 0x24879C,
                SetClientViewAngles = 0x231450,
                SV_LinkEntity = 0x32C420,
                SV_UnlinkEntity = 0x32C3A0,
                SV_SetBrushModel = 0x5ECF94,
                SP_Script_Model = 0x286710,
                G_GivePlayerWeapon1 = 0x2A8364,
                G_InitializeAmmo = 0x1E6838,
                Key_IsDown = 0x018EEB8,
                Dvar_GetBool = 0x04CE50C,
                Get_ServerDetails = 0x1072868,
                PlayersOnline = 0x3822E444,
                Disabled_CharCheck = 0x378620;
        }

       
        public class Stats
        {
            public static uint
               UnlockAll = 0x17A20B0,
               PreferredWeapon = 0x179DE3D,
               Prestige = 0x17A2D1C,
               XPSoldier = 0x179EDDA,
               Kills = 0x179DE79,
               Deaths = 0x179DE51,
               Score = 0x179DEA2,
               Wins = 0x179DECA,
               Losses = 0x179DE81,
               SquadPoints = 0x17A2A24,
               Killstreak = 0x179DE7D,
               Currentstreak = 0x179E74D,
               Winstreak = 0x179DE4D,
               Misses = 0x179DE86,
               Hits = 0x179DE71,
               GamesPlayed = 0x179DE69,
               soldier1 = 0x179eddc,
               soldier2 = 0x179f430,
               soldier3 = 0x179f8a5,
               soldier4 = 0x179fe08,
               soldier5 = 0x17a036d,
               soldier6 = 0x17a08d1,
               soldier7 = 0x17a0e35,
               soldier8 = 0x17a1398,
               soldier9 = 0x17a18fc,
               soldier10 = 0x17a1e61,
               TimePlayed = 0x179DEBE;
        }
        public class ExtinctionLoadOut
        {
            public static uint
               Class = 0x17A543C,
               PistolType = 0x17A543E,
               AmmoType = 0x17A544A,
               TeamSupport = 0x17A544C,
               StrikePackage = 0x17A544E,
               Equalizer = 0x17A5450;
        }

        public class LobbySettings
        {
            public static uint
                Knockback = 0x01CA2858,
                Timescale = 0x01CB5578,
                FlyMode = 0x5D5DE8,
                MaxFallDamage = 0xDE394,
                PlayerSpeed = 0x22E01E, 
                JumpHeight = 0xEC708,
                Gravity = 0x22FE72,
                Invisible = 0x0177EA25,
                MinFallDamage = 0xF905C,
               GodModeAll = 0x23D1E0,
               FullAuto = 0x10EA9C,
               WallBreach = 0x22DFCE;
        }

        public class ExtintionStats
        {
            public static uint
                Prestige = 0x17A551A,  
                Level = 0x17A5513,
                Teeth = 0x17A60E6,
                Revive = 0x17A550A,
                MissionCompleted = 0x17A5532,
                MaxRelics = 0x17A5522,
                AliensKilled = 0x17A552A,
                LBRevives = 0x17A5470,
                LBScore = 0x17A5574,
                LBKills = 0x17A558C,
                LBDowns = 0x17A54C8,
                LBCashFlow = 0x17A54FC,
                LBHivesDestroyed = 0x17A54CC,
                LBCompletedChallenges = 0x17A54F1,
                LBAttemteptedChallenges = 0x17A54F5;
        }
        public class Nonhost
        {
            public static uint
                AdvancedUAV = 0x140A3A,
                NoRecoil = 0x6C65C0,
                Laser = 0x52DDE7,
                ChromePlayer = 0x478D5B,
                PlayerColour = 0x01CBEDB8,
                SteadyAim = 0x1215CC,
                Name = 0x177A238,
                FOV = 0x2364240, 
                ClanTag = 0xCBFF6A,
                ToggleFPS = 0x0036DB0E,
                InitalizeFPS = 0x00857BA8,
                SkyColour = 0x01CBF0B8,
                WallhackGlow = 0x16AB63,
                RedBoxes = 0x149134,
                GlowPlayers = 0x16AB63,
                SuperTargetfinder = 0x01CC4B78,
                cg_fov = 0x008A4B46,
                UAV = 0x0082F7F0,
                ForceHost = 2462832u,
                Wallhack = 0x0086C664;

        }
    }
}
