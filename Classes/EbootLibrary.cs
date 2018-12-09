using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjectRunningFox
{
    public class EbootLibrary
    {
        public void NavigateForward(Form1 f1)
        {
            Image[] AllImageArr = new Image[]
                {
                   ProjectRunningFox.Properties.Resources.EbootImage1,
                   ProjectRunningFox.Properties.Resources.EbootImage2,
                   ProjectRunningFox.Properties.Resources.EbootImage3,
                   ProjectRunningFox.Properties.Resources.EbootImage4, 
                   ProjectRunningFox.Properties.Resources.EbootImage51, 
                    ProjectRunningFox.Properties.Resources.EbootImage6,
                    ProjectRunningFox.Properties.Resources.EbootImage7,
                    ProjectRunningFox.Properties.Resources.EbootImage8, 
                    ProjectRunningFox.Properties.Resources.EbootImage9, 
                    ProjectRunningFox.Properties.Resources.EbootImage10, 
                    ProjectRunningFox.Properties.Resources.Ebootimage11,
                    ProjectRunningFox.Properties.Resources.EbootImage12, 
                    ProjectRunningFox.Properties.Resources.grand_theft_auto_san_andreas_conceptart_Xncfw,
                    ProjectRunningFox.Properties.Resources.EbootImage14, 
                    ProjectRunningFox.Properties.Resources.EbootImage15, 
                    ProjectRunningFox.Properties.Resources.EbootImage16, 
                    ProjectRunningFox.Properties.Resources.EbootImage17, 
                    ProjectRunningFox.Properties.Resources.EbootImage18, 
                    ProjectRunningFox.Properties.Resources.farcry4_temple_entrance_by_donglu_yu_additions_01,
                    ProjectRunningFox.Properties.Resources.EbootImage20, 
                    ProjectRunningFox.Properties.Resources.EbootImage21, 
                    ProjectRunningFox.Properties.Resources.EbootImage22,
                    ProjectRunningFox.Properties.Resources.acr_08_by_drazebot_d8a5djz,
                    ProjectRunningFox.Properties.Resources.EbootImage24 };

            if (f1.Gameindex > 0)
            {
                f1.Gameindex -= 1;
                f1.labelControl701.Text = ProjectRunningFox.EbootLibrary.Games[f1.Gameindex];
                f1.labelControl702.Text = ProjectRunningFox.EbootLibrary.Updates[f1.Gameindex];
                f1.memoEdit3.Text = ProjectRunningFox.EbootLibrary.Synopsis[f1.Gameindex];
                f1.labelControl703.Text = ProjectRunningFox.EbootLibrary.Region[f1.Gameindex];
                f1.memoEdit5.Text = ProjectRunningFox.EbootLibrary.VirusScan[f1.Gameindex];
                f1.pictureBox41.Image = AllImageArr[f1.Gameindex];
                f1.textEdit311.Text = ProjectRunningFox.EbootLibrary.Downloads[f1.Gameindex];
                f1.labelControl786.Text = ProjectRunningFox.EbootLibrary.availability[f1.Gameindex];
                f1.labelControl786.ForeColor = ProjectRunningFox.EbootLibrary.Colors[f1.Gameindex];
                f1.simpleButton146.Enabled = ProjectRunningFox.EbootLibrary.checks[f1.Gameindex];
            }
        }
        public void NavigateBack(Form1 f1)
        {
            Image[] AllImageArr = new Image[]
                {
                   ProjectRunningFox.Properties.Resources.EbootImage1,
                   ProjectRunningFox.Properties.Resources.EbootImage2,
                   ProjectRunningFox.Properties.Resources.EbootImage3,
                   ProjectRunningFox.Properties.Resources.EbootImage4,
                   ProjectRunningFox.Properties.Resources.EbootImage51, 
                    ProjectRunningFox.Properties.Resources.EbootImage6,
                    ProjectRunningFox.Properties.Resources.EbootImage7,
                    ProjectRunningFox.Properties.Resources.EbootImage8,
                    ProjectRunningFox.Properties.Resources.EbootImage9, 
                    ProjectRunningFox.Properties.Resources.EbootImage10, 
                   ProjectRunningFox.Properties.Resources.Ebootimage11,
                    ProjectRunningFox.Properties.Resources.EbootImage12, 
                   ProjectRunningFox.Properties.Resources.grand_theft_auto_san_andreas_conceptart_Xncfw,
                    ProjectRunningFox.Properties.Resources.EbootImage14, 
                    ProjectRunningFox.Properties.Resources.EbootImage15,
                    ProjectRunningFox.Properties.Resources.EbootImage16,
                    ProjectRunningFox.Properties.Resources.EbootImage17,
                    ProjectRunningFox.Properties.Resources.EbootImage18,
                    ProjectRunningFox.Properties.Resources.farcry4_temple_entrance_by_donglu_yu_additions_01,
                    ProjectRunningFox.Properties.Resources.EbootImage20,
                    ProjectRunningFox.Properties.Resources.EbootImage21,
                    ProjectRunningFox.Properties.Resources.EbootImage22,
                    ProjectRunningFox.Properties.Resources.acr_08_by_drazebot_d8a5djz,
                    ProjectRunningFox.Properties.Resources.EbootImage24 };


            if (f1.Gameindex < ProjectRunningFox.EbootLibrary.Games.Count() - 1)
            {
                f1.Gameindex += 1;
                f1.labelControl701.Text = ProjectRunningFox.EbootLibrary.Games[f1.Gameindex];
                f1.labelControl702.Text = ProjectRunningFox.EbootLibrary.Updates[f1.Gameindex];
                f1.memoEdit3.Text = ProjectRunningFox.EbootLibrary.Synopsis[f1.Gameindex];
                f1.labelControl703.Text = ProjectRunningFox.EbootLibrary.Region[f1.Gameindex];
                f1.memoEdit5.Text = ProjectRunningFox.EbootLibrary.VirusScan[f1.Gameindex];
                f1.pictureBox41.Image = AllImageArr[f1.Gameindex];
                f1.textEdit311.Text = ProjectRunningFox.EbootLibrary.Downloads[f1.Gameindex];
                f1.labelControl786.Text = ProjectRunningFox.EbootLibrary.availability[f1.Gameindex];
                f1.labelControl786.ForeColor = ProjectRunningFox.EbootLibrary.Colors[f1.Gameindex];
                f1.simpleButton146.Enabled = ProjectRunningFox.EbootLibrary.checks[f1.Gameindex];
            }
        }
        public static string[] Games = new string[] { "Call of Duty : World at War", 
            "Call of Duty : Ghosts",
            "Call of Duty : Modern Warfare 3",
            "Call of Duty : Advanced Warfare", 
            "Call of Duty : Black Ops", 
        "Call of Duty : Modern Warfare",
        "Call of Duty : Modern Warfare 2",
        "Call of Duty : Black Ops 3",
        "Grand Theft Auto V",
        "The Last of Us",
        "South Park : The Stick of Truth" ,
        "Dark Souls 2",
        "Grand Theft Auto San Andreas",
       "Just Cause 2", 
        "Minecraft PS3 Edition",
        "Skate 3", 
        "Skyrim",
        "Red Dead Redemption Game of the Year Edition",
        "FarCry 4" , 
        "Borderlands 2",
        "Battlefield : Hardline",
        "Battlefield 3",
        "Assassin's Creed : Rogue",
        "Battlefield 4"
        };

        public static string[] availability = new string[] { "Available",
             "Available",
              "Available",
              "Available",
              "Available",
              "Available",
              "Available",
              "Available",
              "Available",
              "Available",
              "Available",
              "Not Available",
              "Not Available",
              "Not Available",
              "Available",
              "Not Available",
              "Not Available",
              "Not Available",
              "Not Available",
              "Not Available",
              "Available",
              "Available",
              "Not Available",
              "Available",
        };

        public static bool[] checks = new bool[] { true,
             true,
              true,
              true,
              true,
              true,
              true,
             true,
             true,
             true,
             true,
             false,
              false,
              false,
            true,
              false,
               false,
             false,
             false,
              false,
              true,
             true,
              false,
              true,
        };

        public static Color[] Colors = new Color[] { Color.Green, 
             Color.Green,
               Color.Green,
               Color.Green,
              Color.Green,
               Color.Green,
              Color.Green,
              Color.Green,
              Color.Green,
              Color.Green,
             Color.Green,
             Color.Red,
              Color.Red,
              Color.Red,
             Color.Green,
              Color.Red,
             Color.Red,
             Color.Red,
             Color.Red,
              Color.Red,
               Color.Green,
              Color.Green,
              Color.Red,
               Color.Green,
        };

        public static string[] Updates = new string[] { "1.07",
            "1.16", 
            "1.24", 
            "1.20", 
            "1.13", 
        "1.40",
        "1.14",
        "1.07", 
        "1.27",
        "1.11", 
        "1.02" ,
        "1.10",
        "1.01",
        "1.02", 
        "1.73", 
        "1.05",
        "1.02",
        "1.01",
        "1.07" ,
        "1.15", 
        "1.08",
        "1.09",
        "1.01", 
        "1.20"};

        public static string[] Downloads = new string[] { "https://prfxml.000webhostapp.com/World at War.rar",
            "https://prfxml.000webhostapp.com/Ghosts.rar", 
            "https://prfxml.000webhostapp.com/Modern Warfare 3",
            "https://prfxml.000webhostapp.com/Advanced Warfare.rar",
            "https://prfxml.000webhostapp.com/Black Ops.rar", 
        "https://prfxml.000webhostapp.com/Modern Warfare 3.rar",
        "https://prfxml.000webhostapp.com/Modern Warfare 2.rar", 
        "https://prfxml.000webhostapp.com/Black Ops 3.rar", 
        "https://prfxml.000webhostapp.com/Grand Theft Auto V.rar", 
        "https://prfxml.000webhostapp.com/The Last of Us.rar", 
        "https://prfxml.000webhostapp.com/South Park.rar" ,
        "https://prfxml.000webhostapp.com/Dark Souls 2.rar",
        "https://prfxml.000webhostapp.com/Grand Theft Auto IV.rar",
        "https://prfxml.000webhostapp.com/Just Cause 2.rar", 
        "https://prfxml.000webhostapp.com/Minecraft.rar", 
        "https://prfxml.000webhostapp.com/Skate 3.rar",
        "https://prfxml.000webhostapp.com/Skyrim.rar", 
        "https://prfxml.000webhostapp.com/Red Dead Redemption.rar",
        "https://prfxml.000webhostapp.com/Saints Row The Third.rar" ,
        "https://prfxml.000webhostapp.com/Borderlands 2.rar", 
        "https://prfxml.000webhostapp.com/Battlefield Hardline.rar",
        "https://prfxml.000webhostapp.com/Battlefield 3.rar",
        "https://prfxml.000webhostapp.com/Assassins Creed Rogue.rar",
        "https://prfxml.000webhostapp.com/Battlefield 4.rar"};


        public static string[] Region = new string[] { "BLUS30192", 
            "BLUS31270",
            "BLUS30838", 
            "BLUS31466",
            "BLUS30591",
        "BLUS30072", 
        "BLUS30377",
        "BLES02166", 
        "BLES01807",
        "BCUS98174" ,
        "BLES01731", 
        "BLUS41045",
        "NPUB-31790", 
        "BLUS30400", 
        "NPUB31419", 
        "BLES00760", 
        "BLUS30778", 
        "BLES01294" ,
        "BLES02012", 
        "NPUB30898", 
        "BLUS31440",
        "BLUS30762", 
        "BLES02062",
        "BLUS31162"}; 

        public static string[] Tips = new string[] { "Changing the theme will also change the ForeColor of all controls.", "Press Enter to set your PSN ID while using the Standard Name Changer.", 
        "Want quick access to your favorite tools or programs? Visit the Add and Edit Tiles section in the settings!", "Customizable preset names are back! Go to the Tool Settings section in the settings.", "Restart the application if the settings do not set properly.",
        "Using Target Manager instead of CCAPI is recommended, but not required."
        };

        public static string[] VirusScan = new string[] { "https://www.virustotal.com/#/file/d1ca3017007a43db271c94fa5c70a866f53a1cfcc9b87662d03708d318849c43/detection",
            "https://www.virustotal.com/#/file/d7ee04dce3349425cbad95a9dcfb501d9298735fc68e9f7c35a12cd8d237e95a/detection",
            "https://www.virustotal.com/#/file/d40cb14d75614381313754367cb94eb228d28e165f073b0717f78f3b9a7cacf0/detection",
            "https://www.virustotal.com/#/file/3761155ec7a8c8c58a124c0a2237b4a8bb22fa1a7182c82872299d7f1a8b71da/detection",
            "https://www.virustotal.com/#/file/db57ebf7dc41fac9b8da3184d3117390ff0519edeb64471959f4d86193e12180/detection", 
        "https://www.virustotal.com/#/file/1ebab6196dce8ee6e8d9b875cd0387d92d09eb5128822dc74ae58d973f8d4da8/detection", 
        "https://www.virustotal.com/#/file/89ffc4c97c4a4b17afb55dd909c270f16e4201db24bbb42f1993cf7b4641fdfc/detection",
        "https://www.virustotal.com/#/file/fcce2f1942345707a870c95790651b1e2ddb6cf33089717bab28f9c2f42491b1/detection", 
        "https://www.virustotal.com/#/file/1498fc37f275e420c77ba5e8410b6f4b877df20f6b3dd3b3263874a21d05fb19/detection",
        "https://www.virustotal.com/#/file/4db10f9a3948ab5303a88454df1fc3c0b38930599023bc87add641465dd846c4/detection",
        "https://www.virustotal.com/#/file/bd3b82b0c2340655c19ebc1658e2d685742ed2c9e1c865a87a6401b9819773fb/detection", 
        "" ,
        "",
        "",
        "https://www.virustotal.com/#/file/6f1672836895445132067b21d89db089af309e506ce6bdac5554a9f2ec843547/detection", 
        "", 
        "", 
        "", 
        "" ,
        "", 
        "https://www.virustotal.com/#/file/36644847d2fc148dbc52e00408c2daf9e597aa9804438aff93708f501324374e/detection",
        "https://www.virustotal.com/#/file/36dd5b903d03cd266b19e6a5433bacf5fd8df4b011a8d37814bf0a28abce8162/detection", 
        "", 
        "https://www.virustotal.com/#/file/087577545147f50098b5251e12de95cdad6d69e7b495937f038a75ea25edc9b7/detection"};

        public static string[] AvatarCount = new string[] { "1", "2", "3", "4", "5", };
      

        public static string[] Synopsis = new string[] { "WAR LIKE YOU'VE NEVER EXPREIENCED BEFORE. Confront new and ruthless enemies  across the Pacific and European battlefields in the final days of WW2. Jump into   exciting multiplayer action with persistent stats, upgradable weapons, and more  perks than ever before. Harness the power of the online four-player Co-Op campaign mode.",
        "A CHANGED WORLD, REDIFINED MULTIPLAYER, AND ALL NEW SQUADS MODE.",
        "THE BEST-SELLING FRANCHIZE IN PS3 HISTORY IS BACK. THE DEFINITIVE MULTIPLAYER EXPERIENCE RETURNS BIGGER THAN EVER. SPECIAL OPS C0-OP REINVENTED WITH ALL NEW SURVIVAL MODE.",
        "POWER CHANGES EVERYTHING.",
        "THE BEST SELLING FRANCHIZE OF ALL TIME ON PS3 RETURNS.",
        "THE MOST PHOTO-REALISTIC VIDEO GAME WE'VE EVER SEEN - Game Informer", 
        "NO ONE IS BETTER AT DELIVERING JAW-DROPPING ACTION MOMENTS THAN INFINITY WARD.",
        "DELIVERING 3 EXPANSIVE AND DISTINCT GAME EXPERIENCES.", 
        "Los Santos : a sprawling metropolis full of self-help gurus, starlets and fading celebrities struggling to stay afloat in an era of economic uncertainty and cheap cable TV. Admidst the turmoil, three very different criminals risk everything in a series of daring and dangerous heists taht could set them up for life.", 
        "Joel and Ellie, brought together by harsh circumstance, must survive a brutal journey across the US in a dangerous post-pandemic world.", 
        "AN EPIC QUEST TO BECOME...COOL. From the perilous battlefields of the fourth-grade playground, a young hero will rise, destined to be South Park's savior.",
        "GO BEYOND DEATH. An unforgettable journey awaits you in a breathtaking world where each dark corner and unexpected encounter will test your resolve.Afflicted by the ancient curse of the undead. You will confront your own fears to emerge stronger than you could ever imagine. Go beyond what you thought was possible with unique online CO-OP and competitive play.",
        "FIVE YEARS AGO CARL JOHNSON ESCAPED FROM PRESSURES OF LIFE IN LOS SANTOS. SAN ANDREAS, A CITY TEARING ITSELF APART WITH GANG TROUBLE, DRUGS AND CORRUPTION. WHERE FILMSTARS DO THEIR BEST TO AVOID THE DEALERS AND GANGBANGERS.", 
        "RELENTLESS ADRENALINE-FUELED ACTION. Your job is simple : find, capture and kill a rogue agent. Create Chaos as you BASE jump, hijack, blow-up, race and sky-dive across 400 square miles of Panau Island. Hundreds of vehicles and weapons are at yoyr disposal, including the traversal Hook and Chute combat system. Prepare to enter a world with no vertical limit.",
        "BUILD! CRAFT! EXPLORE! Discover a world with the freedom to do whstever you want. Dig down into the unknown depths or build incredible structures, from humble homes to grand cityscapes. Go it alone or bring your friends along for the ride. The only limit is your imagination.",
        "Team up. Throw Down.", 
        "EPIC FANTASY REBORN. The next chapter in The Elder Scrolls saga arrives from Bethesda Game Studios, the makers of the 2006 and 2008 Games of the Year. Skyrim reimagines and revolutionizes the open-world fgantasy epic, bringing to life a complete virtual world open for you to explore any way you choose. The legendary freedom of choice, storytelling, and adventure of The Elder Scrolls is realized like never before. Dragons, long lost to the passages of the Elder Scrolls, have returned to Tamriel and the future of the Empire hangs in the balance. As Dragonborn, the prophesized hero born with the power of The Voice, you are the only one who can stand amongst them.", 
        "AMERICA, 1911, THE WILD WEST IS DYING. When federal agents threaten his family, former outlaw John Marston is forced to pick up his guns again and hunt down the gang of criminals he once called friends. Experience an epic fight for survival across the sprawling expanses of the American West and Mexico, as John Marston struggles to bury his blood-strained past, one man at a time.", 
        "EVERY SECOND IS A STORY. Traveling to the towering Himalayas to spread your mother's ashes across her native land, you find yourself caught up in a civil war to overthrow the oppresive regime of a ruthless dictator. Explore and survive this unfamiliar land, where unpredictable danger lurks around every corner.", 
        "A NEW ERA OF SHOOT AND LOOT. GET READY FOR A RIDE ON THE WILD SIDE as one of four new vault hunters seeking treasure and mayhem on the untamed planet of Pandora. Face off against masive new worlds, creatures, psychos, and the evil mastermind, Handsome Jack.", 
        "GET A PIECE OF THE ACTION. ITS GRIPPING, AND IT GETS YOUR HEART GOING. -GamesBeat", 
        "WINNER OF BEST ACTION GAME AND BEST ONLINE MULTIPLAYER. -E3 Game Critics 2011",
        "18th century, North America. Amid the chaos and violence of the French and Indian War. Shay Patrick Cormac, a fearless young member of the Assassin Brotherhood, undergoes a dark transformation that will forever shape the future of the American colonies. As Shay, you will experience the slow transformation from Assassin to Assassin Hunter and use all your skills to take down those who once called you brothers.",
        "ONLY IN BATTLEFIELD. OWN THE LAND, AIR, AND SEA. INTENSE SINGLE PLAYER CAMPAIGN.", };
       
    }
}
