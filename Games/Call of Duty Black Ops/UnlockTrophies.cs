﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Black_Ops
{
    class UnlockTrophies
    {
        public static void TrophyUnlocks_MP()
        {
            string[] Achievements = new string[75];
            Achievements[0] = "8 SP_WIN_CUBA";
            Achievements[1] = "8 SP_WIN_VORKUTA";
            Achievements[2] = "8 SP_WIN_PENTAGON";
            Achievements[3] = "8 SP_WIN_FLASHPOINT";
            Achievements[4] = "8 SP_WIN_KHE_SANH";
            Achievements[5] = "8 SP_WIN_HUE_CITY";
            Achievements[6] = "8 SP_WIN_KOWLOON";
            Achievements[7] = "8 SP_WIN_RIVER";
            Achievements[8] = "8 SP_WIN_FULLAHEAD";
            Achievements[9] = "8 SP_WIN_INTERROGATION_ESCAPE";
            Achievements[10] = "8 SP_WIN_UNDERWATERBASE";
            Achievements[11] = "8 SP_VWIN_FLASHPOINT";
            Achievements[12] = "8 SP_VWIN_HUE_CITY";
            Achievements[13] = "8 SP_VWIN_RIVER";
            Achievements[14] = "8 SP_VWIN_FULLAHEAD";
            Achievements[15] = "8 SP_VWIN_UNDERWATERBASE";
            Achievements[16] = "8 SP_LVL_CUBA_CASTRO_ONESHOT";
            Achievements[17] = "8 SP_LVL_VORKUTA_VEHICULAR";
            Achievements[18] = "8 SP_LVL_VORKUTA_SLINGSHOT";
            Achievements[19] = "8 SP_LVL_KHESANH_MISSILES";
            Achievements[20] = "8 SP_LVL_HUECITY_AIRSUPPORT";
            Achievements[21] = "8 SP_LVL_HUECITY_DRAGON";
            Achievements[22] = "8 SP_LVL_CREEK1_DESTROY_MG";
            Achievements[23] = "8 SP_LVL_CREEK1_KNIFING";
            Achievements[24] = "8 SP_LVL_KOWLOON_DUAL";
            Achievements[25] = "8 SP_LVL_RIVER_TARGETS";
            Achievements[26] = "8 SP_LVL_WMD_RSO";
            Achievements[27] = "8 SP_LVL_WMD_RELAY";
            Achievements[28] = "8 SP_LVL_POW_HIND";
            Achievements[29] = "8 SP_LVL_POW_FLAMETHROWER";
            Achievements[30] = "8 SP_LVL_FULLAHEAD_2MIN";
            Achievements[31] = "8 SP_LVL_REBIRTH_MONKEYS";
            Achievements[32] = "8 SP_LVL_REBIRTH_NOLEAKS";
            Achievements[33] = "8 SP_LVL_UNDERWATERBASE_MINI";
            Achievements[34] = "8 SP_LVL_FRONTEND_CHAIR";
            Achievements[35] = "8 SP_LVL_FRONTEND_ZORK";
            Achievements[36] = "8 SP_GEN_MASTER";
            Achievements[37] = "8 SP_GEN_FRAGMASTER";
            Achievements[38] = "8 SP_GEN_ROUGH_ECO";
            Achievements[39] = "8 SP_GEN_CROSSBOW";
            Achievements[40] = "8 SP_GEN_FOUNDFILMS";
            Achievements[41] = "8 SP_ZOM_COLLECTOR";
            Achievements[42] = "8 SP_ZOM_NODAMAGE";
            Achievements[43] = "8 SP_ZOM_TRAPS";
            Achievements[44] = "8 SP_ZOM_SILVERBACK";
            Achievements[45] = "8 SP_ZOM_CHICKENS";
            Achievements[46] = "8 SP_ZOM_FLAMINGBULL";
            Achievements[47] = "8 MP_FILM_CREATED";
            Achievements[48] = "8 MP_WAGER_MATCH";
            Achievements[49] = "8 MP_PLAY";
            Achievements[50] = "8 DLC1_ZOM_OLDTIMER";
            Achievements[51] = "8 DLC1_ZOM_HARDWAY";
            Achievements[52] = "8 DLC1_ZOM_PISTOLERO";
            Achievements[53] = "8 DLC1_ZOM_BIGBADDABOOM";
            Achievements[54] = "8 DLC1_ZOM_NOLEGS";
            Achievements[55] = "8 DLC2_ZOM_PROTECTEQUIP";
            Achievements[56] = "8 DLC2_ZOM_LUNARLANDERS";
            Achievements[57] = "8 DLC2_ZOM_FIREMONKEY";
            Achievements[58] = "8 DLC2_ZOM_BLACKHOLE";
            Achievements[59] = "8 DLC2_ZOM_PACKAPUNCH";
            Achievements[60] = "8 DLC3_ZOM_STUNTMAN";
            Achievements[61] = "8 DLC3_ZOM_SHOOTING_ON_LOCATION";
            Achievements[62] = "8 DLC3_ZOM_QUIET_ON_THE_SET";
            Achievements[63] = "8 DLC4_ZOM_TEMPLE_SIDEQUEST";
            Achievements[64] = "8 DLC5_ZOM_CRYOGENIC_PARTY";
            Achievements[65] = "8 DLC5_ZOM_BIG_BANG_THEORY";
            Achievements[66] = "8 DLC5_ZOM_GROUND_CONTROL";
            Achievements[67] = "8 DLC5_ZOM_ONE_SMALL_HACK";
            Achievements[68] = "8 DLC5_ZOM_ONE_GIANT_LEAP";
            Achievements[69] = "8 DLC5_ZOM_PERKS_IN_SPACE";
            Achievements[70] = "8 DLC5_ZOM_FULLY_ARMED";
            Achievements[71] = "8 DLC4_ZOM_ZOMB_DISPOSAL";
            Achievements[72] = "8 DLC4_ZOM_MONKEY_SEE_MONKEY_DONT";
            Achievements[73] = "8 DLC4_ZOM_BLINDED_BY_THE_FRIGHT";
            Achievements[74] = "8 DLC4_ZOM_SMALL_CONSOLATION";




            byte[] FT111 = new byte[] { 0x41 };
            byte[] FT11 = new byte[] { 0x40 };
            byte[] RPCON1 = new byte[] { 0x38, 0x60, 0xFF, 0xFF, 0x38, 0x80, 0x00, 0x00, 0x3C, 0xA0, 0x02, 0x00, 0x30, 0xA5, 0x50, 0x00, 0x4B, 0xF8, 0x2E, 0x2D, 0x4B, 0xFF, 0xFB, 0x78 };
            byte[] RPCOFF1 = new byte[] { 0x82, 0xB9, 0x00, 0x00, 0x3C, 0xE0, 0x00, 0xD7, 0x3D, 0x80, 0x00, 0x92, 0x56, 0xA4, 0x38, 0x30, 0x56, 0xBB, 0x18, 0x38, 0x3B, 0x87, 0x9D, 0x04 };




            for (int i = 0; i < 75; i++)
            {
                Form1.PS3.SetMemory(0x2005000, Encoding.ASCII.GetBytes(Achievements + "\0"));
                Form1.PS3.SetMemory(0x466298, FT111);
                Form1.PS3.SetMemory(0x4667B4, RPCON1);
                System.Threading.Thread.Sleep(15);
                Form1.PS3.SetMemory(0x466298, FT11);
                Form1.PS3.SetMemory(0x4667B4, RPCOFF1);
            }
        }
    }
}
