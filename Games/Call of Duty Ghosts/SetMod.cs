using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Call_of_Duty_Ghosts
{
    class SetMod
    {
        //Extinction

        public void ExtinctionSecondaryAkimboOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboSeonday + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Secondary Akimbo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboSeonday + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Secondary Akimbo ^1Off");
            }
        }
        public void ExtinctionSecondaryAkimboON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboSeonday + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Secondary Akimbo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboSeonday + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Secondary Akimbo ^2On");
            }
        }
        public void ExtinctionPrimaryAkimboOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboPrimary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Primary Akimbo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboPrimary + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Primary Akimbo ^1Off");
            }
        }
        public void ExtinctionPrimaryAkimboON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboPrimary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Primary Akimbo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboPrimary + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Primary Akimbo ^2On");
            }
        }
        public void ExtinctionUFOModeOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "UFO Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "UFO Mode ^1Off");
            }
        }
        public void ExtinctionUFOModeON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "UFO Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "UFO Mode ^2On");
            }
        }
        public void ExtinctionLaserOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Lazer + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Laser ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Lazer + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Laser ^1Off");
            }
        }
        public void ExtinctionLaserON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Lazer + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x04 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Laser ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Lazer + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x04 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Laser ^2On");
            }
        }
        public void ExtinctionUAVOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.UAV + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "UAV ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.UAV + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "UAV ^1Off");
            }
        }
        public void ExtinctionUAVON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.UAV + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "UAV ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.UAV + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "UAV ^2On");
            }
        }
        public void ExtinctionFreezePlayerOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Freeze Player ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Freeze Player ^1Off");
            }
        }
        public void ExtinctionFreezePlayerON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x04 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Freeze Player ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x04 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Freeze Player ^2On");
            }
        }
        public void ExtinctionNoClipOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NoCLip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "No Clip ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NoCLip + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "No Clip ^1Off");
            }
        }
        public void ExtinctionNoClipON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NoCLip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "No Clip ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NoCLip + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "No Clip ^2On");
            }
        }
        public void ExtinctionLagOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GiveLag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Lag ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GiveLag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Lag ^1Off");
            }
        }
        public void ExtinctionLagON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GiveLag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Lag ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GiveLag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Lag ^2On");
            }
        }
        public void ExtinctionDoubleSpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.PlayerSpeed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x3F });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Speed X2 ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.PlayerSpeed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x3F });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Speed X2 ^1Off");
            }
        }
        public void ExtinctionDoubleSpeedON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.PlayerSpeed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x40 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Speed X2 ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.PlayerSpeed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x40 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Speed X2 ^2On");
            }
        }
        public void ExtinctionAllPerks(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AllPerks + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "All Perks ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AllPerks + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "All Perks ^2On");
            }
        }
        public void ExtinctionRedBoxesOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.RedBox + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Red Boxes ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.RedBox + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Red Boxes ^1Off");
            }
        }
        public void ExtinctionRedBoxesON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.RedBox + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x50 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Red Boxes ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.RedBox + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x50 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Red Boxes ^2On");
            }
        }
        public void ExtinctionThirdPersonOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.ThirdPerson + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Third Person ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.ThirdPerson + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Third Person ^1Off");
            }
        }
        public void ExtinctionThirdPersonON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.ThirdPerson + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x07 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Third Person ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.ThirdPerson + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x07 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Third Person ^2On");
            }
        }
        public void ExtinctionAmmoOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo4 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo5 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Unlimited Ammo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Unlimited Ammo ^1Off");
            }
        }
        public void ExtinctionAmmoON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo4 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo5 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo4 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo5 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Unlimited Ammo ^2On");
            }
        }
        public void ExtinctionGodModeON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GodMod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "God Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GodMod + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }

        public void ExtinctionGodModeOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GodMod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "God Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GodMod + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }

        //Extinction
        public void SecondaryAkimboOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboSeonday + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Secondary Akimbo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboSeonday + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Secondary Akimbo ^1Off");
            }
        }
        public void SecondaryAkimboON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboSeonday + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Secondary Akimbo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboSeonday + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Secondary Akimbo ^2On");
            }
        }
        public void PrimaryAkimboOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboPrimary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Primary Akimbo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboPrimary + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Primary Akimbo ^1Off");
            }
        }
        public void PrimaryAkimboON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboPrimary + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Primary Akimbo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AkimboPrimary + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Primary Akimbo ^2On");
            }
        }
        public void UFOModeOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "UFO Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "UFO Mode ^1Off");
            }
        }
        public void UFOModeON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "UFO Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "UFO Mode ^2On");
            }
        }
        public void LaserOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Lazer + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Laser ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Lazer + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Laser ^1Off");
            }
        }
        public void LaserON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Lazer + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x04 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Laser ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Lazer + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x04 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Laser ^2On");
            }
        }
        public void UAVOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.UAV + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "UAV ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.UAV + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "UAV ^1Off");
            }
        }
        public void UAVON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.UAV + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "UAV ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.UAV + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "UAV ^2On");
            }
        }
        public void FreezePlayerOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Freeze Player ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Freeze Player ^1Off");
            }
        }
        public void FreezePlayerON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x04 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Freeze Player ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Freeze + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x04 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Freeze Player ^2On");
            }
        }
        public void NoClipOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NoCLip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "No Clip ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NoCLip + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "No Clip ^1Off");
            }
        }
        public void NoClipON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NoCLip + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "No Clip ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.NoCLip + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x01 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "No Clip ^2On");
            }
        }
        public void LagOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GiveLag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x02 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Lag ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GiveLag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x02 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Lag ^1Off");
            }
        }
        public void LagON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GiveLag + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Lag ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GiveLag + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Lag ^2On");
            }
        }
        public void DoubleSpeedOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.PlayerSpeed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x3F });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Speed X2 ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.PlayerSpeed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x3F });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Speed X2 ^1Off");
            }
        }
        public void DoubleSpeedON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.PlayerSpeed + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x40 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Speed X2 ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.PlayerSpeed + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x40 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Speed X2 ^2On");
            }
        }
        public void AllPerks(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AllPerks + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "All Perks ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.AllPerks + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "All Perks ^2On");
            }
        }
        public void RedBoxesOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.RedBox + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Red Boxes ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.RedBox + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Red Boxes ^1Off");
            }
        }
        public void RedBoxesON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.RedBox + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x50 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Red Boxes ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.RedBox + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x50 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Red Boxes ^2On");
            }
        }
        public void ThirdPersonOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.ThirdPerson + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Third Person ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.ThirdPerson + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Third Person ^1Off");
            }
        }
        public void ThirdPersonON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.ThirdPerson + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x07 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Third Person ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.ThirdPerson + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x07 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Third Person ^2On");
            }
        }
        public void AmmoOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo4 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo5 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Unlimited Ammo ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Unlimited Ammo ^1Off");
            }
        }
        public void AmmoON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo2 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo3 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo4 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo5 + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "Unlimited Ammo ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo1 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo2 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo3 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo4 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Ammo5 + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "Unlimited Ammo ^2On");
            }
        }
        public void GodModeOFF(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GodMod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "God Mode ^1Off");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GodMod + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "God Mode ^1Off");
            }
        }
        public void GodModeON(Form1 f1)
        {
            if (f1.listBoxControl9.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GodMod + ((uint)i * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                    ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(i, "God Mode ^2On");
                }
            }
            else
            {
                Form1.PS3.Extension.WriteBytes(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.GodMod + ((uint)ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex * ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.Client.Interval), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.RPCText1.Set(0, ProjectRunningFox.Games.Call_of_Duty_Ghosts.Scripts.GetNames(ProjectRunningFox.Games.Call_of_Duty_Ghosts.Offsets.ClientIndex) + "God Mode ^2On");
            }
        }
    }
}
