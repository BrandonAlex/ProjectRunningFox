using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Skyrim
{
    class Offsets
    {
        public static void InfiniteHPMPStaminaON()
        {
            Form1.PS3.SetMemory(0x143C794, new byte[] { 0xD3, 0xDF, 0x01, 0x88 });
            Form1.PS3.SetMemory(0x143C798, new byte[] { 0x3D, 0xE0, 0x01, 0x71 });
            Form1.PS3.SetMemory(0x143C79C, new byte[] { 0x61, 0xEF, 0xA3, 0x7C });
            Form1.PS3.SetMemory(0x143C7A0, new byte[] { 0x81, 0xEF, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7A4, new byte[] { 0x2C, 0x0F, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7A8, new byte[] { 0x41, 0x82, 0x00, 0x14 });
            Form1.PS3.SetMemory(0x143C7AC, new byte[] { 0x3A, 0xA0, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7B0, new byte[] { 0x92, 0xAF, 0x01, 0x78 });
            Form1.PS3.SetMemory(0x143C7B4, new byte[] { 0x92, 0xAF, 0x01, 0x6C });
            Form1.PS3.SetMemory(0x143C7B8, new byte[] { 0x92, 0xAF, 0x01, 0x60 });
            Form1.PS3.SetMemory(0x143C7BC, new byte[] { 0x48, 0x19, 0x83, 0x13 });
            Form1.PS3.SetMemory(0x19830C, new byte[] { 0x49, 0x43, 0xC7, 0x97 });

        }

        public class HostMods
        {
            public static uint
                InfiniteDragonSouls = 0x715A64,
                InfiniteShout = 0x8EA00, 
                InfiniteArrows = 0x2AEE54,
                Carryweightnoincrease = 0x414FCC,
                Maxshopgold = 0x2F0B5C,
                Craftnomaterial = 0x478894;
        }

        public static void InfiniteHPMPStaminaOFF()
        {
            Form1.PS3.SetMemory(0x143C794, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C798, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C79C, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7A0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7A4, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7A8, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7AC, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7B0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7B4, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7B8, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x143C7BC, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            Form1.PS3.SetMemory(0x19830C, new byte[] { 0xD3, 0xDF, 0x01, 0x88 });

        }
    }
}
