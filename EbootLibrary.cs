using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjectRunningFox
{
    public static class EbootLibrary
    {
        public static string[] Games = new string[] { "Call of Duty : World at War", "Call of Duty : Ghosts", "Call of Duty : Modern Warfare 3", "Call of Duty : Advanced Warfare", "Call of Duty : Black Ops", 
        "Call of Duty : Modern Warfare", "Call of Duty : Modern Warfare 2", "Call of Duty : Black Ops 3", "Grand Theft Auto V", "The Last of Us", "South Park : The Stick of Truth" ,
        "Dark Souls 2", "Grand Theft Auto IV", "Just Cause 2", "Minecraft PS3 Edition", "Skate 3", "Skyrim", "Red Dead Redemption", "Saints Row : The Third" , "Borderlands 2", "Battlefield : Hardline",
        "Battlefield 3", "Battlefield : Bad Company 2", "Battlefield 4"};

        public static string[] Updates = new string[] { "1.07", "1.16", "1.24", "1.20", "1.13", 
        "1.40", "1.14", "1.07", "1.27", "1.11", "1.02" ,
        "1.10", "1.08", "1.02", "1.71", "1.05", "1.09", "1.08", "1.04" , "1.15", "1.08",
        "1.09", "Unknown", "1.20"};

        public static string[] Downloads = new string[] { "https://prfxml.000webhostapp.com/World at War.rar", "https://prfxml.000webhostapp.com/Ghosts.rar", "https://prfxml.000webhostapp.com/Modern Warfare 3", "https://prfxml.000webhostapp.com/Advanced Warfare.rar", "https://prfxml.000webhostapp.com/Black Ops.rar", 
        "https://prfxml.000webhostapp.com/Modern Warfare 3.rar", "https://prfxml.000webhostapp.com/Modern Warfare 2.rar", "https://prfxml.000webhostapp.com/Black Ops 3.rar", "https://prfxml.000webhostapp.com/Grand Theft Auto V.rar", "https://prfxml.000webhostapp.com/The Last of Us.rar", "https://prfxml.000webhostapp.com/South Park.rar" ,
        "https://prfxml.000webhostapp.com/Dark Souls 2.rar", "https://prfxml.000webhostapp.com/Grand Theft Auto IV.rar", "https://prfxml.000webhostapp.com/Just Cause 2.rar", "https://prfxml.000webhostapp.com/Minecraft.rar", "https://prfxml.000webhostapp.com/Skate 3.rar", "https://prfxml.000webhostapp.com/Skyrim.rar", "https://prfxml.000webhostapp.com/Red Dead Redemption.rar", "https://prfxml.000webhostapp.com/Saints Row The Third.rar" , "https://prfxml.000webhostapp.com/Borderlands 2.rar", "https://prfxml.000webhostapp.com/Battlefield Hardline.rar",
        "https://prfxml.000webhostapp.com/Battlefield 3.rar", "https://prfxml.000webhostapp.com/Battlefield Bad Company 2.rar", "https://prfxml.000webhostapp.com/Battlefield 4.rar"};

        public static string[] Features = new string[] { "", "", "", "", "", 
        "", "", "", "", "" ,
        "", "", "", "", "", "", "", "" , "", "",
        "", "", ""};

        public static string[] Credits = new string[] { "", "", "", "", "", 
        "", "", "", "", "", "" ,
        "", "", "", "", "", "", "", "" , "", "",
        "", "", ""};

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
        "What does the American dream mean today? For Niko Bellic fresh off the boat from Europe, it is the hope he can escape his past. For his cousin, Roman, it is the vision that together they can find fortune in Liberty City, gateway to the land of opportunity. As they slip into debt and get dragged into a criminal underworld by a series of shysters, theives and sociopaths, they discover that the reality is very different from the dream in a city that worships money and status, and is heaven for those who have them and a living nightmare for those who dont.", 
        "RELENTLESS ADRENALINE-FUELED ACTION. Your job is simple : find, capture and kill a rogue agent. Create Chaos as you BASE jump, hijack, blow-up, race and sky-dive across 400 square miles of Panau Island. Hundreds of vehicles and weapons are at yoyr disposal, including the traversal Hook and Chute combat system. Prepare to enter a world with no vertical limit.",
        "BUILD! CRAFT! EXPLORE! Discover a world with the freedom to do whstever you want. Dig down into the unknown depths or build incredible structures, from humble homes to grand cityscapes. Go it alone or bring your friends along for the ride. The only limit is your imagination.",
        "Team up. Throw Down.", 
        "EPIC FANTASY REBORN. The next chapter in The Elder Scrolls saga arrives from Bethesda Game Studios, the makers of the 2006 and 2008 Games of the Year. Skyrim reimagines and revolutionizes the open-world fgantasy epic, bringing to life a complete virtual world open for you to explore any way you choose. The legendary freedom of choice, storytelling, and adventure of The Elder Scrolls is realized like never before. Dragons, long lost to the passages of the Elder Scrolls, have returned to Tamriel and the future of the Empire hangs in the balance. As Dragonborn, the prophesized hero born with the power of The Voice, you are the only one who can stand amongst them.", 
        "AMERICA, 1911, THE WILD WEST IS DYING. When federal agents threaten his family, former outlaw John Marston is forced to pick up his guns again and hunt down the gang of criminals he once called friends. Experience an epic fight for survival across the sprawling expanses of the American West and Mexico, as John Marston struggles to bury his blood-strained past, one man at a time.", 
        "STRAP IT ON. The Third Street Saints are at the height of power, and they are yours to control. Bring the fight to Steelport, a sordid city of sin drowning in sex, drugs, and guns. This is your city. These are your rules.", 
        "A NEW ERA OF SHOOT AND LOOT. GET READY FOR A RIDE ON THE WILD SIDE as one of four new vault hunters seeking treasure and mayhem on the untamed planet of Pandora. Face off against masive new worlds, creatures, psychos, and the evil mastermind, Handsome Jack.", 
        "GET A PIECE OF THE ACTION. ITS GRIPPING, AND IT GETS YOUR HEART GOING. -GamesBeat", 
        "WINNER OF BEST ACTION GAME AND BEST ONLINE MULTIPLAYER. -E3 Game Critics 2011",
        "FROM THE CREATORS OF THE AWARD WINNING BATTLEFIELD SERIES.Defining Online Warfare--Become the master of air, land, and sea.Stand Up--Fight in four-man teams in full-on multiplayer action.Tactical Destruction--Blow away enemy cover and take down entire buildings.Intense Solo Campaign--Join Bad Company on a mission to prevent WW2.",
        "ONLY IN BATTLEFIELD. OWN THE LAND, AIR, AND SEA. INTENSE SINGLE PLAYER CAMPAIGN.", };
       
    }
}
