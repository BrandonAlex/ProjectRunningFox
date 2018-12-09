using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops_2
{
    class offsets
    {
        public class Protection
        {
            #region Protection
            public static uint AntiBan1 = 0x50A38F;
            public static uint AntiBan2 = 0x50BA74;
            public static uint AntiBan3 = 0x547DD4;
            public static uint AntiBan4 = 0x548148;
            public static uint AntiBan5 = 0x50B61C;
            public static uint AntiBan6 = 0x50A3BC;
            public static uint AntiBan7 = 0x5300E8;
            public static uint AntiBan8 = 0x5300F4;
            #endregion
        }
        public class Nonhost
        {
            #region Non-host
            public static uint Name = 0x026C0658;
            public static uint RedBox0 = 0x000783E0;
            public static uint RedBox1 = 0x00078604;
            public static uint Laser = 0xEF68C;
            public static uint VSAT = 0x00033C60;
            public static uint UAV = 0x33CB4;
            public static uint WallHack0 = 0x1CBF9F8;
            public static uint WallHack1 = 0x000834D0;
            public static uint SteadyAim = 0x5F0A20;
            public static uint FPS1 = 0x8E3590;
            public static uint FPS2 = 0x37FEC;
            public static uint AntiFreeze = 0x67B824;
            public static uint FPSText = 0x8E3290;
            public static uint BigNames = 0x01cc6e98;
            public static uint SkyColor = 0x01cc28d8;
            public static uint BodyColor = 0x01CC143C;
            public static uint FOV = 0x1CC52D8;
            public static uint NoRecoil = 0xF9E54;
            public static uint FloatingBodies = 0x1CD03D8;
            public static uint TargetFinder = 0x1CC4BF8;
            public static uint ForceHost = 0x1cd6018;
            public static uint BlinkingBoddies = 0xEF68C;
            public static uint SubjectInvite = 0x30933206;
            public static uint MessageInvite = 0x30933223;
            public static uint EndProbation = 0x53FC6C;
            public static uint SplitScreen = 0x01cbe2b8;
            public static uint MapR = 0x1CC52D8;
            public static uint Clan = 0x2708238;
            #endregion
        }
        public class Stats
        {
            #region Stats
            public static uint Prestige = 0x26FD014;
            public static uint Level = 0x26FD02D;
            public static uint LevelL = 0x26FD02C;
            public static uint Tokens = 0x2706938;
            public static uint Wins = 0x26FD152;
            public static uint Losses = 0x26FCBE2;
            public static uint Kills = 0x26FCBE2;
            public static uint Deaths = 0x26FC942;
            public static uint Score = 0x26FD050;
            public static uint TimePlayed = 0x26FD10A;
            public static uint HeadShots = 0x26FCA44;
            public static uint Unlock10Classes = 0x02708522;
            public static uint UnlockAll = 0x26fc870;
            public static uint GhostCard = 0x02708199;
            public static uint RoxannCard = 0x0270819C;
            public static uint FourGuns = 0x27078DC;
            public static uint EndProbation = 0x53FC6C;
            public static uint Level55 = 0x26FD016;
            public static uint AWTitle = 0x27078C0;
            //League Play
            public static uint LadderPoints = 0x196821B;
            public static uint SeasonWins = 0x1968310;
            public static uint CareerWins = 0x1968324;
            public static uint Winstreak = 0x1968320;
            public static uint LeagueRank = 0x0196821B;
            public static uint Primary = 0x27078BA;
            public static uint Secondary = 0x27078C8;
            public static uint PerkGreed1 = 0x27078d9;
            public static uint PerkGreed2 = 0x27078da;
            public static uint PerkGreed3 = 0x27078db;
            public static uint Lethal = 0x27078DC;
            public static uint Tactical = 0x27078DE;
            public static uint StickyLocalGameName = 0x26c0658;
            #endregion
        }
        public class Lobby
        {
            #region Lobby
            public static uint TimeScale = 0x1CB7BF8;
            public static uint Melee1 = 0x1CAF0D8;
            public static uint Melee2 = 0x1CAF138;
            public static uint Melee3 = 0x1CAF198;
            public static uint Jump = 0x005BE0B4;
            public static uint Speed = 0x1CA4E78;
            public static uint Gravity = 0x1CAF9D8;
            public static uint KnockBack = 0x01CA4ED8;
            public static uint RapidFire = 0x01CB2AF2;
            public static uint ZombiesStopSpawning = 0x1CA5178;
            public static uint ZBNORecoil = 0xF9E54;
            public static uint ZMSTeadyaim = 0x5F0A20;
            public static uint ZMGod = 0x1786404;
            public static uint MaxPoints = 0x1786501;
            public static uint JumperZM = 0x1786418;
            public static uint BoxSCR = 0x178672B;
            public static uint BoxSCR1 = 0x1780F42;
            public static uint RemoveWeapon = 0x178641F;
            public static uint fakedown = 0x178672B;
            public static uint[] Screen = { 0x17814D0, 0x17814CC };
            public static uint teleport = 0x1780F50;
            public static uint ZMPrimaryWeapon = 0x178118F;
            public static uint MOTDPrimaryWeapon = 0x1781173;
            public static uint ZMSecondaryWeapon = 0x17811C7;
            public static uint MuleKick = 0x17811E3;
            public static uint ZMLethal = 0x17811AB;
            public static uint ZMTactical = 0x17811FF;
            public static uint DPAD1 = 0x178121B;
            public static uint DPAD2 = 0x1781237;
            public static uint DPAD3 = 0x1781253;

            #endregion
        }

        public class Multiplayermods
        {
            #region MultiplayerMods
            public static uint AllPerks = 0x1781470;
            public static uint NextClient = 0x5808;
            public static uint LobbyName = 0x026C0658;
            public static uint InGameName = 0x0178646c;
            public static uint ClanTagInGame = 0x17864D8;
            public static uint GodMode = 0x1780f43;
            public static uint POV3 = 0x1780fac;
            public static uint VSATIG = 0x1786717;
            public static uint Killstreak1 = 0x1781357;
            public static uint Killstreak2 = 0x1781359;
            public static uint Killstreak3 = 0x178135C;
            public static uint Speed2 = 0x1786418;
            public static uint SkateMod = 0x177DE37;
            public static uint Invisible = 0x1781025;
            public static uint Prone = 0x1786718;
            public static uint Freeze = 0x17865bf;
            public static uint lag = 0x1786363;
            public static uint TBAG = 0x1781027;
            public static uint EarthQuake = 0x1781087;
            public static uint WeaponFUp = 0x178641F;
            public static uint Jumper = 0x1786418;
            public static uint PlayerStatus = 0x178634B;
            public static uint PlayerTeam = 0x178642F;
            public static uint BlackScreen = 0x178102b;
            public static uint Vision = 0x178102B;
            public static uint PoisonVision = 0x178150B;
            public static uint NightVision = 0x1780F42;
            public static uint EMPVision = 0x1780F43;
            public static uint CamoOnline1 = 0x17811CB;
            public static uint CamoOnline2 = 0x17811AF;
            public static uint CamoLocal1 = 0x17811E7;
            public static uint CamoLocal2 = 0x1781203;
            public static uint G_Client = 0x1780F28;
            public static uint KillPlayer = 0x1780F58;
            public static uint AutoLoad = 0x4525F0;
            public static uint G_Spawn = 0x278AC0;
            public static uint Teleport = 0x1780F50;
            public static uint ChangeSC1 = 0x1781497;
            public static uint ChangeSC2 = 0x178148F;
            public static uint ChangeSC3 = 0x178148B;
            public static uint Enable1 = 0x1781487;
            public static uint Enable2 = 0x178147F;
            public static uint Enable3 = 0x178147B;
            public static uint PrimaryWeapon = 0x178118F;
            public static uint SecondaryWeapon = 0x17811C7;
            public static uint InGameName1 = 0x178BC74;
            public static uint InGameName2 = 0x179147C;
            public static uint InGameName3 = 0x1796C84;
            public static uint InGameName4 = 0x179C48C;
            public static uint InGameName5 = 0x17A1C94;
            public static uint InGameName6 = 0x17A749C;
            public static uint InGameName7 = 0x17ACCA4;
            public static uint InGameName8 = 0x17B24AC;
            public static uint InGameName9 = 0x17B7CB4;
            public static uint InGameName10 = 0x17BD4BC;
            public static uint InGameName11 = 0x17C2CC4;
            public static uint InGameName12 = 0x17C84CC;
            public static uint InGameName13 = 0x17CDCD4;
            public static uint InGameName14 = 0x17D34DC;
            public static uint InGameName15 = 0x17D8CE4;
            public static uint InGameName16 = 0x17DE4EC;
            public static uint InGameName17 = 0x17E3CF4;
            public static uint InGamePrestige = 0x1786497;
            public static uint InGameLevel = 0x1786493;
            public static uint Ammo1 = 0x0178135d;
            public static uint Ammo2 = 0x01781361;
            public static uint Ammo3 = 0x01781365;
            public static uint Ammo4 = 0x01781359;
            public static uint Ammo5 = 0x0178139d;
            public static uint Ammo6 = 0x01781395;
            public static uint Ammo7 = 0x01781391;
            public static uint Ammo8 = 0x0178138d;


            //Zombies
            public static uint PrimaryWeaponZm = 0x178118F;
            public static uint SecondaryWeaponZm = 0x17811C7;
            public static uint MuleKick = 0x17811E3;
            public static uint Lethal = 0x1781359;
            public static uint Tactical = 0x1781365;
            public static uint ammo1v1 = 0x1781355;
            public static uint ammo1v2 = 0x1781319;
            public static uint ammo1v3 = 0x1781339;
            public static uint ammo2v1 = 0x178135D;
            public static uint ammo2v2 = 0x1781321;

            #endregion
        }


        public class Zombiemods
        {
            #region Zombiemods
            public static uint Kills = 0x26FC90C;
            public static uint BulletsFired = 0x26FC940;
            public static uint Downs = 0x26FC910;
            public static uint Revives = 0x26FC914;
            public static uint GrenadeKills = 0x26FC934;
            public static uint Headshots = 0x26FC884;
            public static uint Deaths = 0x26FC948;
            public static uint Gibs = 0x26FC91C;
            public static uint PerksDrank = 0x26FC918;
            public static uint DoorsOpened = 0x26FC938;
            public static uint Hits = 0x26FC944;
            public static uint TraveledMiles = 0x26FC93C;
            public static uint Emblem1 = 0x026FC896;
            public static uint Emblem2 = 0x026FCA87;
            public static uint TallyMask = 0x26FCA8E;
            public static uint SoloLeaderboards = 0x26FCA80;

            #endregion
        }
        public class Classes
        {
            #region Classes
            public static uint Class1 = 0x2707AC7;
            public static uint Class2 = 0x2707AD7;
            public static uint Class3 = 0x2707AE7;
            public static uint Class4 = 0x2707AF7;
            public static uint Class5 = 0x2707B07;
            public static uint Class6 = 0x2707B17;
            public static uint Class7 = 0x2707B27;
            public static uint Class8 = 0x2707B37;
            public static uint Class9 = 0x2707B47;
            public static uint Class10 = 0x2707B57;
            #endregion
        }
        public class Client
        {
            #region  Clients Offsets
            public static uint Interval = 0x5808;
            public static uint HeldWeapon = 0x17810E3;
            public static uint Cbuf_AddText = 0x313c18;
            public static uint CamoLocal1 = 0x17811E7;
            public static uint CamoLocal2 = 0x1781203;
            public static uint CamoOnline1 = 0x17811CB;
            public static uint CamoOnline2 = 0x17811AF;
            #endregion
        }
    }
}

