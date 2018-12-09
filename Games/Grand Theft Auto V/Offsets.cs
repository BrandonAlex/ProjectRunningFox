using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunningFox.Games.Grand_Theft_Auto_V
{
    class Offsets
    {
        public class HostMods
        {
            public static uint
                Name1 = 0x200255C,
                Name2 = 0x41143344,
                Godmode = 0x118A548,
                Ammo = 0xFD3904,
                NoPolice = 0x1041FE0, 
                SuperJump = 0x5EE9B0,
                Money = 0x3DB190,
                NoGravity = 0x1A8C170,
                Superman = 0x1E459E4,
                SlowMotion = 0x1CC57A8,
                BigGuns = 0x1D260; 
        }

        public static int[] Rank = { 
        1,
        400,
        800,
        2100,
        3800,
        6100,
        9500,
        12500,
        16000,
        19800,
        24000,
        28500,
        33400,
        38700,
        44200,
        50200,
        56400,
        63000,
        69900,
        77100,
        84700,
        92500,
        100700,
        109200,
        118000,
        127100,
        136500,
        146200,
        156200,
        166500,
        177100,
        188000,
        199200,
        210700,
        222400,
        234500,
        246800,
        259400,
        272300,
        285500,
        299000,
        312700,
        326800,
        341000,
        355600,
        370500,
        385600,
        401000,
        416600,
        432600,
        448800,
        465200,
        482000,
        499000,
        516300,
        533800,
        551600,
        569600,
        588000,
        606500,
        625400,
        644500,
        663800,
        683400,
        703300,
        723400,
        743800,
        764500,
        785400,
        806500,
        827900,
        849600,
        871500,
        893600,
        916000,
        938700,
        961600,
        984700,
        1008100,
        1031800,
        1055700,
        1079800,
        1104200,
        1128800,
        1153700,
        1178800,
        1204200,
        1229800,
        1255600,
        1281700,
        1308100,
        1334600,
        1361400,
        1388500,
        1415800,
        1443300,
        1471100,
        1499100,
        1527300,
        1555800,
        1584350,
        1612950,
        1641600,
        1670300,
        1699050,
        1727850,
        1756700,
        1785600,
        1814550,
        1843550,
        1872600,
        1901700,
        1930850,
        1960050,
        1989300,
        2018600,
        2047950,
        2077350,
        2106800,
        2136300,
        2165850,
        2195450,
        2225100,
        2254800,
        2284550,
        2314350,
        2344200,
        2374100,
        2404050,
        2434050,
        2464100,
        2494200,
        2524350,
        2554550,
        2584800,
        2615100,
        2645450,
        2675850,
        2706300,
        2736800,
        2767350,
        2797950,
        2828600,
        2859300,
        2890050,
        2920850,
        2951700,
        2982600,
        3013550,
        3044550,
        3075600,
        3106700,
        3137850,
        3169050,
        3200300,
        3231600,
        3262950,
        3294350,
        3325800,
        3357300,
        3388850,
        3420450,
        3452100,
        3483800,
        3515550,
        3547350,
        3579200,
        3611100,
        3643050,
        3675050,
        3707100,
        3739200,
        3771350,
        3803550,
        3835800,
        3868100,
        3900450,
        3932850,
        3965300,
        3997800,
        4030350,
        4062950,
        4095600,
        4128300,
        4161050,
        4193850,
        4226700,
        4259600,
        4292550,
        4325550,
        4358600,
        4391700,
        4424850,
        4458050,
        4491300,
        4524600,
        4557950,
        4591350,
        4624800,
        4658300,
        4691850,
        4725450,
        4759100,
        4792800,
        4826550,
        4860350,
        4894200,
        4928100,
        4962050,
        4996050,
        5030100,
        5064200,
        5098350,
        5132550,
        5166800,
        5201100,
        5235450,
        5269850,
        5304300,
        5338800,
        5373350,
        5407950,
        5442600,
        5477300,
        5512050,
        5546850,
        5581700,
        5616600,
        5651550,
        5686550,
        5721600,
        5756700,
        5791850,
        5827050,
        5862300,
        5897600,
        5932950,
        5968350,
        6003800,
        6039300,
        6074850,
        6110450,
        6146100,
        6181800,
        6217550,
        6253350,
        6289200,
        6325100,
        6361050,
        6397050,
        6433100,
        6469200,
        6505350,
        6541550,
        6577800,
        6614100,
        6650450,
        6686850,
        6723300,
        6759800,
        6796350,
        6832950,
        6869600,
        6906300,
        6943050,
        6979850,
        7016700,
        7053600,
        7090550,
        7127550,
        7164600,
        7201700,
        7238850,
        7276050,
        7313300,
        7350600,
        7387950,
        7425350,
        7462800,
        7500300,
        7537850,
        7575450,
        7613100,
        7650800,
        7688550,
        7726350,
        7764200,
        7802100,
        7840050,
        7878050,
        7916100,
        7954200,
        7992350,
        8030550,
        8068800,
        8107100,
        8145450,
        8183850,
        8222300,
        8260800,
        8299350,
        8337950,
        8376600,
        8415300,
        8454050,
        8492850,
        8531700,
        8570600,
        8609550,
        8648550,
        8687600,
        8726700,
        8765850,
        8805050,
        8844300,
        8883600,
        8922950,
        8962350,
        9001800,
        9041300,
        9080850,
        9120450,
        9160100,
        9199800,
        9239550,
        9279350,
        9319200,
        9359100,
        9399050,
        9439050,
        9479100,
        9519200,
        9559350,
        9599550,
        9639800,
        9680100,
        9720450,
        9760850,
        9801300,
        9841800,
        9882350,
        9922950,
        9963600,
        10004300,
        10045050,
        10085850,
        10126700,
        10167600,
        10208550,
        10249550,
        10290600,
        10331700,
        10372850,
        10414050,
        10455300,
        10496600,
        10537950,
        10579350,
        10620800,
        10662300,
        10703850,
        10745450,
        10787100,
        10828800,
        10870550,
        10912350,
        10954200,
        10996100,
        11038050,
        11080050,
        11122100,
        11164200,
        11206350,
        11248550,
        11290800,
        11333100,
        11375450,
        11417850,
        11460300,
        11502800,
        11545350,
        11587950,
        11630600,
        11673300,
        11716050,
        11758850,
        11801700,
        11844600,
        11887550,
        11930550,
        11973600,
        12016700,
        12059850,
        12103050,
        12146300,
        12189600,
        12232950,
        12276350,
        12319800,
        12363300,
        12406850,
        12450450,
        12494100,
        12537800,
        12581550,
        12625350,
        12669200,
        12713100,
        12757050,
        12801050,
        12845100,
        12889200,
        12933350,
        12977550,
        13021800,
        13066100,
        13110450,
        13154850,
        13199300,
        13243800,
        13288350,
        13332950,
        13377600,
        13422300,
        13467050,
        13511850,
        13556700,
        13601600,
        13646550,
        13691550,
        13736600,
        13781700,
        13826850,
        13872050,
        13917300,
        13962600,
        14007950,
        14053350,
        14098800,
        14144300,
        14189850,
        14235450,
        14281100,
        14326800,
        14372550,
        14418350,
        14464200,
        14510100,
        14556050,
        14602050,
        14648100,
        14694200,
        14740350,
        14786550,
        14832800,
        14879100,
        14925450,
        14971850,
        15018300,
        15064800,
        15111350,
        15157950,
        15204600,
        15251300,
        15298050,
        15344850,
        15391700,
        15438600,
        15485550,
        15532550,
        15579600,
        15626700,
        15673850,
        15721050,
        15768300,
        15815600,
        15862950,
        15910350,
        15957800,
        16005300,
        16052850,
        16100450,
        16148100,
        16195800,
        16243550,
        16291350,
        16339200,
        16387100,
        16435050,
        16483050,
        16531100,
        16579200,
        16627350,
        16675550,
        16723800,
        16772100,
        16820450,
        16868850,
        16917300,
        16965800,
        17014350,
        17062950,
        17111600,
        17160300,
        17209050,
        17257850,
        17306700,
        17355600,
        17404550,
        17453550,
        17502600,
        17551700,
        17600850,
        17650050,
        17699300,
        17748600,
        17797950,
        17847350,
        17896800,
        17946300,
        17995850,
        18045450,
        18095100,
        18144800,
        18194550,
        18244350,
        18294200,
        18344100,
        18394050,
        18444050,
        18494100,
        18544200,
        18594350,
        18644550,
        18694800,
        18745100,
        18795450,
        18845850,
        18896300,
        18946800,
        18997350,
        19047950,
        19098600,
        19149300,
        19200050,
        19250850,
        19301700,
        19352600,
        19403550,
        19454550,
        19505600,
        19556700,
        19607850,
        19659050,
        19710300,
        19761600,
        19812950,
        19864350,
        19915800,
        19967300,
        20018850,
        20070450,
        20122100,
        20173800,
        20225550,
        20277350,
        20329200,
        20381100,
        20433050,
        20485050,
        20537100,
        20589200,
        20641350,
        20693550,
        20745800,
        20798100,
        20850450,
        20902850,
        20955300,
        21007800,
        21060350,
        21112950,
        21165600,
        21218300,
        21271050,
        21323850,
        21376700,
        21429600,
        21482550,
        21535550,
        21588600,
        21641700,
        21694850,
        21748050,
        21801300,
        21854600,
        21907950,
        21961350,
        22014800,
        22068300,
        22121850,
        22175450,
        22229100,
        22282800,
        22336550,
        22390350,
        22444200,
        22498100,
        22552050,
        22606050,
        22660100,
        22714200,
        22768350,
        22822550,
        22876800,
        22931100,
        22985450,
        23039850,
        23094300,
        23148800,
        23203350,
        23257950,
        23312600,
        23367300,
        23422050,
        23476850,
        23531700,
        23586600,
        23641550,
        23696550,
        23751600,
        23806700,
        23861850,
        23917050,
        23972300,
        24027600,
        24082950,
        24138350,
        24193800,
        24249300,
        24304850,
        24360450,
        24416100,
        24471800,
        24527550,
        24583350,
        24639200,
        24695100,
        24751050,
        24807050,
        24863100,
        24919200,
        24975350,
        25031550,
        25087800,
        25144100,
        25200450,
        25256850,
        25313300,
        25369800,
        25426350,
        25482950,
        25539600,
        25596300,
        25653050,
        25709850,
        25766700,
        25823600,
        25880550,
        25937550,
        25994600,
        26051700,
        26108850,
        26166050,
        26223300,
        26280600,
        26337950,
        26395350,
        26452800,
        26510300,
        26567850,
        26625450,
        26683100,
        26740800,
        26798550,
        26856350,
        26914200,
        26972100,
        27030050,
        27088050,
        27146100,
        27204200,
        27262350,
        27320550,
        27378800,
        27437100,
        27495450,
        27553850,
        27612300,
        27670800,
        27729350,
        27787950,
        27846600,
        27905300,
        27964050,
        28022850,
        28081700,
        28140600,
        28199550,
        28258550,
        28317600,
        28376700,
        28435850,
        28495050,
        28554300,
        28613600,
        28672950,
        28732350,
        28791800,
        28851300,
        28910850,
        28970450,
        29030100,
        29089800,
        29149550,
        29209350,
        29269200,
        29329100,
        29389050,
        29449050,
        29509100,
        29569200,
        29629350,
        29689550,
        29749800,
        29810100,
        29870450,
        29930850,
        29991300,
        30051800,
        30112350,
        30172950,
        30233600,
        30294300,
        30355050,
        30415850,
        30476700,
        30537600,
        30598550,
        30659550,
        30720600,
        30781700,
        30842850,
        30904050,
        30965300,
        31026600,
        31087950,
        31149350,
        31210800,
        31272300,
        31333850,
        31395450,
        31457100,
        31518800,
        31580550,
        31642350,
        31704200,
        31766100,
        31828050,
        31890050,
        31952100,
        32014200,
        32076350,
        32138550,
        32200800,
        32263100,
        32325450,
        32387850,
        32450300,
        32512800,
        32575350,
        32637950,
        32700600,
        32763300,
        32826050,
        32888850,
        32951700,
        33014600,
        33077550,
        33140550,
        33203600,
        33266700,
        33329850,
        33393050,
        33456300,
        33519600,
        33582950,
        33646350,
        33709800,
        33773300,
        33836850,
        33900450,
        33964100,
        34027800,
        34091550,
        34155350,
        34219200,
        34283100,
        34347050,
        34411050,
        34475100,
        34539200,
        34603350,
        34667550,
        34731800,
        34796100,
        34860450,
        34924850,
        34989300,
        35053800,
        35118350,
        35182950,
        35247600,
        35312300,
        35377050,
        35441850,
        35506700,
        35571600,
        35636550,
        35701550,
        35766600,
        35831700,
        35896850,
        35962050,
        36027300,
        36092600,
        36157950,
        36223350,
        36288800,
        36354300,
        36419850,
        36485450,
        36551100,
        36616800,
        36682550,
        36748350,
        36814200,
        36880100,
        36946050,
        37012050,
        37078100,
        37144200,
        37210350,
        37276550,
        37342800,
        37409100,
        37475450,
        37541850,
        37608300,
        37674800,
        37741350,
        37807950,
        37874600,
        37941300,
        38008050,
        38074850,
        38141700,
        38208600,
        38275550,
        38342550,
        38409600,
        38476700,
        38543850,
        38611050,
        38678300,
        38745600,
        38812950,
        38880350,
        38947800,
        39015300,
        39082850,
        39150450,
        39218100,
        39285800,
        39353550,
        39421350,
        39489200,
        39557100,
        39625050,
        39693050,
        39761100,
        39829200,
        39897350,
        39965550,
        40033800,
        40102100,
        40170450,
        40238850,
        40307300,
        40375800,
        40444350,
        40512950,
        40581600,
        40650300,
        40719050,
        40787850,
        40856700,
        40925600,
        40994550,
        41063550,
        41132600,
        41201700,
        41270850,
        41340050,
        41409300,
        41478600,
        41547950,
        41617350,
        41686800,
        41756300,
        41825850,
        41895450,
        41965100,
        42034800,
        42104550,
        42174350,
        42244200,
        42314100,
        42384050,
        42454050,
        42524100,
        42594200,
        42664350,
        42734550,
        42804800,
        42875100,
        42945450,
        43015850,
        43086300,
        43156800,
        43227350,
        43297950,
        43368600,
        43439300,
        43510050,
        43580850,
        43651700,
        43722600,
        43793550,
        43864550,
        43935600,
        44006700,
        44077850,
        44149050,
        44220300,
        44291600,
        44362950,
        44434350,
        44505800,
        44577300,
        44648850,
        44720450,
        44792100,
        44863800,
        44935550,
        45007350,
        45079200,
        45151100,
        45223050,
        45295050,
        45367100,
        45439200,
        45511350,
        45583550,
        45655800,
        45728100,
        45800450,
        45872850,
        45945300,
        46017800,
        46090350,
        46162950,
        46235600,
        46308300,
        46381050,
        46453850,
        46526700,
        46599600,
        46672550,
        46745550,
        46818600,
        46891700,
        46964850,
        47038050,
        47111300,
        47184600,
        47257950,
        47331350,
        47404800,
        47478300,
        47478500 };
    

        public class Addresses
        {
            public static uint ABSF = 0X3D6CAC;
            public static uint ABSI = 0X3D6C9C;
            public static uint ACOS = 0X3D4C60;
            public static uint ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID = 0X3ECBA0;
            public static uint ACTIVATE_FRONTEND_MENU = 0X3CD45C;
            public static uint ACTIVATE_PHYSICS = 0X420C50;
            public static uint ADD_AMMO_TO_PED = 0X466CD0;
            public static uint ADD_ARMOUR_TO_PED = 0X407EF8;
            public static uint ADD_BLIP_FOR_COORD = 0X3CA758;
            public static uint ADD_BLIP_FOR_ENTITY = 0X3CA498;
            public static uint ADD_BLIP_FOR_PICKUP = 0X3CA68C;
            public static uint ADD_BLIP_FOR_RADIUS = 0X3CA408;
            public static uint ADD_CAM_SPLINE_NODE = 0X3A4A80;
            public static uint ADD_COVER_BLOCKING_AREA = 0X4474A8;
            public static uint ADD_COVER_POINT = 0X4463DC;
            public static uint ADD_DECAL = 0X3C3268;
            public static uint ADD_ENTITY_ICON = 0X3C1104;
            public static uint ADD_ENTITY_ICON_BY_VECTOR = 0X3C12D0;
            public static uint ADD_EXPLOSION = 0X3BD304;
            public static uint ADD_FOLLOW_NAVMESH_TO_PHONE_TASK = 0X444CE4;
            public static uint ADD_HOSPITAL_RESTART = 0X3D3330;
            public static uint ADD_LINE_TO_CONVERSATION = 0X39CBD8;
            public static uint ADD_NAVMESH_BLOCKING_OBJECT = 0X403804;
            public static uint ADD_NAVMESH_REQUIRED_REGION = 0X403118;
            public static uint ADD_NEXT_MESSAGE_TO_PREVIOUS_BRIEFS = 0X3C9640;
            public static uint ADD_OWNED_EXPLOSION = 0X3BD40C;
            public static uint ADD_PATROL_ROUTE_LINK = 0X4494D0;
            public static uint ADD_PATROL_ROUTE_NODE = 0X449460;
            public static uint ADD_PED_TO_CONVERSATION = 0X39CCA4;
            public static uint ADD_PETROL_DECAL = 0X3C34D0;
            public static uint ADD_PICKUP_TO_INTERIOR_ROOM_BY_NAME = 0X3D202C;
            public static uint ADD_POLICE_RESTART = 0X3D3460;
            public static uint ADD_RELATIONSHIP_GROUP = 0X40DCA4;
            public static uint ADD_ROPE = 0X41FA90;
            public static uint ADD_SCENARIO_BLOCKING_AREA = 0X415B08;
            public static uint ADD_SCRIPT_TO_RANDOM_PED = 0X3A2688;
            public static uint ADD_SHOCKING_EVENT_AT_POSITION = 0X3BC880;
            public static uint ADD_SHOCKING_EVENT_FOR_ENTITY = 0X3BC938;
            public static uint ADD_STUNT_JUMP = 0X3D7680;
            public static uint ADD_STUNT_JUMP_ANGLED = 0X3D7760;
            public static uint ADD_TEXT_COMPONENT_FLOAT = 0X3C856C;
            public static uint ADD_TEXT_COMPONENT_INTEGER = 0X3C854C;
            public static uint ADD_TEXT_COMPONENT_STRING = 0X3C85D0;
            public static uint ADD_TO_CLOCK_TIME = 0X3A9388;
            public static uint ADD_TO_ITEMSET = 0X3D2E14;
            public static uint ADD_TREVOR_RANDOM_MODIFIER = 0X3CCD2C;
            public static uint ADD_VEHICLE_STUCK_CHECK_WITH_WARP = 0X45423C;
            public static uint ADD_VEHICLE_SUBTASK_ATTACK_PED = 0X4423A8;
            public static uint ADD_VEHICLE_UPSIDEDOWN_CHECK = 0X44EFD4;
            public static uint ANIMATED_SHAKE_CAM = 0X3A5AF0;
            public static uint APP_CLEAR_BLOCK = 0X39C694;
            public static uint APP_CLOSE_APP = 0X39C52C;
            public static uint APP_CLOSE_BLOCK = 0X39C574;
            public static uint APP_DATA_VALID = 0X39BEDC;
            public static uint APP_DELETE_APP_DATA = 0X39C66C;
            public static uint APP_GET_FLOAT = 0X39C028;
            public static uint APP_GET_INT = 0X39BF8C;
            public static uint APP_GET_STRING = 0X39C0E8;
            public static uint APP_HAS_SYNCED_DATA = 0X39C714;
            public static uint APP_SAVE_DATA = 0X39C608;
            public static uint APP_SET_APP = 0X39C488;
            public static uint APP_SET_BLOCK = 0X39C5BC;
            public static uint APP_SET_FLOAT = 0X39C270;
            public static uint APP_SET_INT = 0X39C188;
            public static uint APP_SET_STRING = 0X39C368;
            public static uint APPLY_DAMAGE_TO_PED = 0X40EE70;
            public static uint APPLY_FORCE_TO_ENTITY = 0X3AF468;
            public static uint APPLY_PED_BLOOD = 0X414B60;
            public static uint APPLY_PED_DAMAGE_DECAL = 0X414E00;
            public static uint APPLY_PED_DAMAGE_PACK = 0X414EF8;
            public static uint ARE_ALL_NAVMESH_REGIONS_LOADED = 0X1F0B0;
            public static uint ARE_PLAYER_FLASHING_STARS_ABOUT_TO_DROP = 0X4221F4;
            public static uint ARE_PLAYER_STARS_GREYED_OUT = 0X42226C;
            public static uint ARE_STRINGS_EQUAL = 0X3D6BFC;
            public static uint ASIN = 0X3D4BE0;
            public static uint ASSISTED_MOVEMENT_CLOSE_ROUTE = 0X424E28;
            public static uint ASSISTED_MOVEMENT_FLUSH_ROUTE = 0X424E80;
            public static uint ASSISTED_MOVEMENT_REMOVE_ROUTE = 0X44DACC;
            public static uint ASSISTED_MOVEMENT_REQUEST_ROUTE = 0X44DA5C;
            public static uint ATAN = 0X3D4D40;
            public static uint ATAN2 = 0X3D4D78;
            public static uint ATTACH_CAM_TO_ENTITY = 0X3A41A4;
            public static uint ATTACH_CAM_TO_PED_BONE = 0X3A42BC;
            public static uint ATTACH_ENTITIES_TO_ROPE = 0X420358;
            public static uint ATTACH_ENTITY_TO_ENTITY = 0X3B0088;
            public static uint ATTACH_ENTITY_TO_ENTITY_PHYSICALLY = 0X3B0390;
            public static uint ATTACH_PORTABLE_PICKUP_TO_PED = 0X3FA9CC;
            public static uint ATTACH_ROPE_TO_ENTITY = 0X420620;
            public static uint ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY = 0X41B068;
            public static uint ATTACH_TV_AUDIO_TO_ENTITY = 0X3C155C;
            public static uint ATTACH_VEHICLE_TO_CARGOBOB = 0X45CCF0;
            public static uint ATTACH_VEHICLE_TO_TOW_TRUCK = 0X45BF28;
            public static uint ATTACH_VEHICLE_TO_TRAILER = 0X452C50;
            public static uint AUDIO_IS_SCRIPTED_MUSIC_PLAYING = 0X3A0534;
            public static uint BEGIN_REPLAY_STATS = 0X3D38C0;
            public static uint BEGIN_SRL = 0X437F44;
            public static uint BLIP_SIREN = 0X39F790;
            public static uint BREAK_ENTITY_GLASS = 0X421008;
            public static uint CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS = 0X404408;
            public static uint CAN_CREATE_RANDOM_COPS = 0X4100E4;
            public static uint CAN_CREATE_RANDOM_DRIVER = 0X408AE4;
            public static uint CAN_CREATE_RANDOM_PED = 0X4087FC;
            public static uint CAN_PED_RAGDOLL = 0X412E98;
            public static uint CAN_PHONE_BE_SEEN_ON_SCREEN = 0X15AF0;
            public static uint CAN_PLAYER_START_MISSION = 0X4233F0;
            public static uint CAN_REGISTER_MISSION_ENTITIES = 0X3ED0A4;
            public static uint CAN_REGISTER_MISSION_OBJECTS = 0X3ECF34;
            public static uint CAN_REGISTER_MISSION_PEDS = 0X3ECFAC;
            public static uint CAN_REGISTER_MISSION_VEHICLES = 0X3ED024;
            public static uint CAN_SET_ENTER_STATE_FOR_REGISTERED_ENTITY = 0X3B74A8;
            public static uint CAN_SET_EXIT_STATE_FOR_CAMERA = 0X3B74F4;
            public static uint CAN_SET_EXIT_STATE_FOR_REGISTERED_ENTITY = 0X3B745C;
            public static uint CANCEL_MUSIC_EVENT = 0X3A05C4;
            public static uint CANCEL_STUNT_JUMP = 0X3D79F4;
            public static uint CAP_INTERIOR = 0X3D26B4;
            public static uint CEIL = 0X9B89E0;
            public static uint CELL_CAM_ACTIVATE = 0X439150;
            public static uint CELL_CAM_IS_CHAR_VISIBLE_NO_FACE_CHECK = 0X4391E4;
            public static uint CHANGE_PLAYER_PED = 0X4218B4;
            public static uint CLEAN_ITEMSET = 0X3D300C;
            public static uint CLEAR_ADDITIONAL_TEXT = 0X3C9034;
            public static uint CLEAR_ALL_HELP_MESSAGES = 0X3C8E5C;
            public static uint CLEAR_ALL_PED_PROPS = 0X411DF8;
            public static uint CLEAR_AMBIENT_ZONE_LIST_STATE = 0X39F510;
            public static uint CLEAR_AMBIENT_ZONE_STATE = 0X39F404;
            public static uint CLEAR_ANGLED_AREA_OF_VEHICLES = 0X3D59B4;
            public static uint CLEAR_AREA = 0X3D5608;
            public static uint CLEAR_AREA_OF_COPS = 0X3D5C60;
            public static uint CLEAR_AREA_OF_OBJECTS = 0X3D5B50;
            public static uint CLEAR_AREA_OF_PEDS = 0X3D5B78;
            public static uint CLEAR_AREA_OF_PROJECTILES = 0X3D54F0;
            public static uint CLEAR_AREA_OF_VEHICLES = 0X3D5878;
            public static uint CLEAR_BIT = 0X3D6814;
            public static uint CLEAR_BRIEF = 0X3C8E2C;
            public static uint CLEAR_DECISION_MAKER_EVENT_RESPONSE = 0X3BC030;
            public static uint CLEAR_DRAW_ORIGIN = 0X3C154C;
            public static uint CLEAR_ENTITY_LAST_DAMAGE_ENTITY = 0X3B06B0;
            public static uint CLEAR_ENTITY_LAST_WEAPON_DAMAGE = 0X468078;
            public static uint CLEAR_FACIAL_IDLE_ANIM_OVERRIDE = 0X416C60;
            public static uint CLEAR_FLOATING_HELP = 0X3C9FC0;
            public static uint CLEAR_FOCUS = 0X436CD0;
            public static uint CLEAR_GPS_FLAGS = 0X3CBF10;
            public static uint CLEAR_GPS_PLAYER_WAYPOINT = 0X3CBE74;
            public static uint CLEAR_GPS_RACE_TRACK = 0X3CC0CC;
            public static uint CLEAR_HD_AREA = 0X438134;
            public static uint CLEAR_HELP = 0X3C9D1C;
            public static uint CLEAR_OVERRIDE_WEATHER = 0X3D4180;
            public static uint CLEAR_PED_ALTERNATE_MOVEMENT_ANIM = 0X4074D8;
            public static uint CLEAR_PED_BLOOD_DAMAGE = 0X4150D8;
            public static uint CLEAR_PED_DECORATIONS = 0X415588;
            public static uint CLEAR_PED_IN_PAUSE_MENU = 0X3CE12C;
            public static uint CLEAR_PED_LAST_DAMAGE_BONE = 0X40A504;
            public static uint CLEAR_PED_LAST_WEAPON_DAMAGE = 0X467F5C;
            public static uint CLEAR_PED_NON_CREATION_AREA = 0X4090B8;
            public static uint CLEAR_PED_PROP = 0X411D64;
            public static uint CLEAR_PED_SECONDARY_TASK = 0X440424;
            public static uint CLEAR_PED_TASKS = 0X4402F4;
            public static uint CLEAR_PED_TASKS_IMMEDIATELY = 0X445478;
            public static uint CLEAR_PED_WETNESS = 0X415374;
            public static uint CLEAR_PLAYER_BAILED_FROM_PLAYERICLE = 0X3EADA8;
            public static uint CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED = 0X424B5C;
            public static uint CLEAR_PLAYER_WANTED_LEVEL = 0X422390;
            public static uint CLEAR_PRINTS = 0X3C8E0C;
            public static uint CLEAR_RELATIONSHIP_BETWEEN_GROUPS = 0X40DC58;
            public static uint CLEAR_REPLAY_STATS = 0X3D39CC;
            public static uint CLEAR_ROOM_FOR_ENTITY = 0X3D1980;
            public static uint CLEAR_SEQUENCE_TASK = 0X43EE14;
            public static uint CLEAR_SMALL_PRINTS = 0X3C8F40;
            public static uint CLEAR_TEXT_LABEL = 0X264EB8;
            public static uint CLEAR_THIS_PRINT = 0X3C8E84;
            public static uint CLEAR_TIMECYCLE_MODIFIER = 0X3C4098;
            public static uint CLEAR_VEHICLE_CUSTOM_PRIMARY_COLOUR = 0X45015C;
            public static uint CLEAR_VEHICLE_CUSTOM_SECONDARY_COLOUR = 0X450398;
            public static uint CLEAR_WEATHER_TYPE_PERSIST = 0X3D402C;
            public static uint CLONE_PED = 0X405078;
            public static uint CLOSE_PATROL_ROUTE = 0X449438;
            public static uint CLOSE_SEQUENCE_TASK = 0X43ECE0;
            public static uint CLOUD_REQUEST_MEMBER_FILE = 0X00;
            public static uint COMPARE_STRINGS = 0X3D6C48;
            public static uint COS = 0X9B88D0;
            public static uint CREATE_AMBIENT_PICKUP = 0X3FA4D8;
            public static uint CREATE_CAM = 0X3A2E70;
            public static uint CREATE_CAM_WITH_PARAMS = 0X3A3080;
            public static uint CREATE_CAMERA = 0X3A2EC8;
            public static uint CREATE_CAMERA_WITH_PARAMS = 0X3A2F20;
            public static uint CREATE_CHECKPOINT = 0X3BEFE8;
            public static uint CREATE_CINEMATIC_SHOT = 0X3A7330;
            public static uint CREATE_FORCED_OBJECT = 0X3B4EF0;
            public static uint CREATE_GROUP = 0X40BE68;
            public static uint CREATE_INCIDENT = 0X3D7FF0;
            public static uint CREATE_INCIDENT_WITH_ENTITY = 0X3D81E4;
            public static uint CREATE_ITEMSET = 0X3D2D48;
            public static uint CREATE_MISSION_TRAIN = 0X453700;
            public static uint CREATE_MOBILE_PHONE = 0X438F08;
            public static uint CREATE_MODEL_HIDE = 0X3B4E10;
            public static uint CREATE_MODEL_SWAP = 0X3B4C00;
            public static uint CREATE_MONEY_PICKUPS = 0X3FB084;
            public static uint CREATE_NEW_SCRIPTED_CONVERSATION = 0X39CBA4;
            public static uint CREATE_NM_MESSAGE = 0X415868;
            public static uint CREATE_OBJECT = 0X3F8F0C;
            public static uint CREATE_OBJECT_NO_OFFSET = 0X3F8F68;
            public static uint CREATE_PATROL_ROUTE = 0X449500;
            public static uint CREATE_PED = 0X404A30;
            public static uint CREATE_PED_INSIDE_VEHICLE = 0X4062FC;
            public static uint CREATE_PICKUP = 0X3F9A98;
            public static uint CREATE_PICKUP_ROTATE = 0X3F9D90;
            public static uint CREATE_PORTABLE_PICKUP = 0X3FA97C;
            public static uint CREATE_RANDOM_PED = 0X4088E8;
            public static uint CREATE_RANDOM_PED_AS_DRIVER = 0X408944;
            public static uint CREATE_SCRIPT_VEHICLE_GENERATOR = 0X44E8A8;
            public static uint CREATE_SYNCHRONIZED_SCENE = 0X41A5F0;
            public static uint CREATE_TRACKED_POINT = 0X3BFAE4;
            public static uint CREATE_VEHICLE = 0X44E138;
            public static uint CREATE_WEAPON_OBJECT = 0X469AF0;
            public static uint DATAFILE_CREATE = 0X3B9368;
            public static uint DATAFILE_DELETE = 0X3B93D8;
            public static uint DELETE_ALL_TRAINS = 0X45380C;
            public static uint DELETE_CHECKPOINT = 0X3BF30C;
            public static uint DELETE_CHILD_ROPE = 0X420038;
            public static uint DELETE_ENTITY = 0X3B0724;
            public static uint DELETE_INCIDENT = 0X3D8400;
            public static uint DELETE_MISSION_TRAIN = 0X454D84;
            public static uint DELETE_OBJECT = 0X3F901C;
            public static uint DELETE_PATROL_ROUTE = 0X449528;
            public static uint DELETE_PED = 0X405288;
            public static uint DELETE_ROPE = 0X42006C;
            public static uint DELETE_SCRIPT_VEHICLE_GENERATOR = 0X44E9E8;
            public static uint DELETE_STUNT_JUMP = 0X3D7844;
            public static uint DELETE_VEHICLE = 0X44E4DC;
            public static uint DESTROY_ALL_CAMS = 0X3A3240;
            public static uint DESTROY_CAM = 0X3A31D8;
            public static uint DESTROY_ITEMSET = 0X3D2D98;
            public static uint DESTROY_MOBILE_PHONE = 0X438FA0;
            public static uint DESTROY_TRACKED_POINT = 0X3BFC58;
            public static uint DETACH_CAM = 0X3A43D8;
            public static uint DETACH_ENTITY = 0X3B0804;
            public static uint DETACH_PORTABLE_PICKUP_FROM_PED = 0X3FAAF0;
            public static uint DETACH_ROPE_FROM_ENTITY = 0X420740;
            public static uint DETACH_SYNCHRONIZED_SCENE = 0X41B0E8;
            public static uint DETACH_VEHICLE_FROM_ANY_CARGOBOB = 0X45C78C;
            public static uint DETACH_VEHICLE_FROM_ANY_TOW_TRUCK = 0X45C2D4;
            public static uint DETACH_VEHICLE_FROM_CARGOBOB = 0X45C630;
            public static uint DETACH_VEHICLE_FROM_TOW_TRUCK = 0X45C1C8;
            public static uint DISABLE_ALL_CONTROL_ACTIONS = 0X400EC8;
            public static uint DISABLE_BLIP_NAME_FOR_VAR = 0X3CB154;
            public static uint DISABLE_CONTROL_ACTION = 0X400D04;
            public static uint DISABLE_FRONTEND_THIS_FRAME = 0X3CD53C;
            public static uint DISABLE_HOSPITAL_RESTART = 0X3D3434;
            public static uint DISABLE_INTERIOR = 0X3D25A0;
            public static uint DISABLE_NAVMESH_IN_AREA = 0X401C08;
            public static uint DISABLE_PED_PAIN_AUDIO = 0X39FC44;
            public static uint DISABLE_PLANE_AILERON = 0X45B2C8;
            public static uint DISABLE_PLAYER_FIRING = 0X425028;
            public static uint DISABLE_POLICE_RESTART = 0X3D3564;
            public static uint DISABLE_SCRIPT_BRAIN_SET = 0X3A2B54;
            public static uint DISABLE_STUNT_JUMP_SET = 0X3D78AC;
            public static uint DISABLE_VEHICLE_DISTANTLIGHTS = 0X3C3F24;
            public static uint DISABLE_VEHICLE_IMPACT_EXPLOSION_ACTIVATION = 0X44EEE8;
            public static uint DISABLE_VEHICLE_WEAPON = 0X461A5C;
            public static uint DISPLAY_AMMO_THIS_FRAME = 0X3CBC8C;
            public static uint DISPLAY_AREA_NAME = 0X3CBBD0;
            public static uint DISPLAY_CASH = 0X3CBC0C;
            public static uint DISPLAY_HELP_TEXT_THIS_FRAME = 0X3C9C34;
            public static uint DISPLAY_HUD = 0X3C9588;
            public static uint DISPLAY_ONSCREEN_KEYBOARD = 0X3D962C;
            public static uint DISPLAY_RADAR = 0X3CA8D0;
            public static uint DISPLAY_SNIPER_SCOPE_THIS_FRAME = 0X3CBCC8;
            public static uint DISPLAY_SYSTEM_SIGNIN_UI = 0X4248B8;
            public static uint DO_AUTO_SAVE = 0X3D37D8;
            public static uint DO_SCREEN_FADE_IN = 0X3A6528;
            public static uint DO_SCREEN_FADE_OUT = 0X3A6548;
            public static uint DOES_BLIP_EXIST = 0X3CB938;
            public static uint DOES_CAM_EXIST = 0X3A3288;
            public static uint DOES_CUTSCENE_ENTITY_EXIST = 0X3B7B50;
            public static uint DOES_ENTITY_EXIST = 0X3AA018;
            public static uint DOES_ENTITY_HAVE_DRAWABLE = 0X3AA150;
            public static uint DOES_ENTITY_HAVE_ICON_ID = 0X3C1340;
            public static uint DOES_ENTITY_HAVE_PHYSICS = 0X3AA1D8;
            public static uint DOES_EXTRA_EXIST = 0X45985C;
            public static uint DOES_GROUP_EXIST = 0X40E7BC;
            public static uint DOES_OBJECT_EXIST_WITH_DECORATOR = 0X3FF930;
            public static uint DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS = 0X3FD448;
            public static uint DOES_PARTICLE_FX_LOOPED_EXIST = 0X3C2674;
            public static uint DOES_PED_EXIST_WITH_DECORATOR = 0X00;
            public static uint DOES_PICKUP_EXIST = 0X3FD560;
            public static uint DOES_PICKUP_OBJECT_EXIST = 0X3FD5C4;
            public static uint DOES_ROPE_EXIST = 0X41FCA0;
            public static uint DOES_SCENARIO_EXIST_IN_AREA = 0X4477B0;
            public static uint DOES_SCENARIO_GROUP_EXIST = 0X447E28;
            public static uint DOES_SCRIPT_EXIST = 0X439670;
            public static uint DOES_SCRIPT_VEHICLE_GENERATOR_EXIST = 0X44E7E0;
            public static uint DOES_TEXT_BLOCK_EXIST = 0X3C8F60;
            public static uint DOES_TEXT_LABEL_EXIST = 0X3C90D4;
            public static uint DOES_VEHICLE_EXIST_WITH_DECORATOR = 0X462478;
            public static uint DOES_VEHICLE_HAVE_ROOF = 0X457E50;
            public static uint DOES_VEHICLE_HAVE_STUCK_VEHICLE_CHECK = 0X4539F8;
            public static uint DOES_VEHICLE_HAVE_WEAPONS = 0X4619CC;
            public static uint DRAW_DEBUG_BOX = 0X10FA0;
            public static uint DRAW_DEBUG_LINE = 0X10FA0;
            public static uint DRAW_DEBUG_LINE_WITH_TWO_COLOURS = 0X10FA0;
            public static uint DRAW_DEBUG_SPHERE = 0X10FA0;
            public static uint DRAW_DEBUG_TEXT = 0X10FA0;
            public static uint DRAW_DEBUG_TEXT_2D = 0X10FA0;
            public static uint DRAW_LIGHT_WITH_RANGE = 0X3BE150;
            public static uint DRAW_LINE = 0X3BDA90;
            public static uint DRAW_MARKER = 0X3BEBC0;
            public static uint DRAW_POLY = 0X3BDB90;
            public static uint DRAW_RECT = 0X3BFC98;
            public static uint DRAW_SCALEFORM_MOVIE = 0X3BFDD8;
            public static uint DRAW_SPOT_LIGHT = 0X3BE3F8;
            public static uint DRAW_SPRITE = 0X3C0FFC;
            public static uint DRAW_TEXT = 0X3C82CC;
            public static uint DRAW_TV_CHANNEL = 0X3C51D4;
            public static uint ENABLE_ALL_CONTROL_ACTIONS = 0X400F38;
            public static uint ENABLE_CONTROL_ACTION = 0X400DFC;
            public static uint ENABLE_DEATHBLOOD_SEETHROUGH = 0X3CD868;
            public static uint ENABLE_LASER_SIGHT_RENDERING = 0X466834;
            public static uint ENABLE_MOVIE_SUBTITLES = 0X3C5384;
            public static uint ENABLE_SCRIPT_BRAIN_SET = 0X3A2B28;
            public static uint ENABLE_SPECIAL_ABILITY = 0X4257A0;
            public static uint ENABLE_STUNT_JUMP_SET = 0X3D7878;
            public static uint ENABLE_TENNIS_MODE = 0X3D891C;
            public static uint END_REPLAY_STATS = 0X3D391C;
            public static uint END_SRL = 0X437F6C;
            public static uint EXPLODE_PED_HEAD = 0X407CB8;
            public static uint EXPLODE_PROJECTILES = 0X469154;
            public static uint EXPLODE_VEHICLE = 0X44F8FC;
            public static uint EXPLODE_VEHICLE_IN_CUTSCENE = 0X4541A0;
            public static uint FADE_DECALS_IN_RANGE = 0X3C2F90;
            public static uint FADE_OUT_LOCAL_PLAYER = 0X3F1188;
            public static uint FILLOUT_PM_PLAYER_LIST = 0X3E785C;
            public static uint FILLOUT_PM_PLAYER_LIST_WITH_NAMES = 0X3E7CA8;
            public static uint FIND_RADIO_STATION_INDEX = 0X39E728;
            public static uint FIND_SPAWN_POINT_IN_DIRECTION = 0X00;
            public static uint FIX_VEHICLE_WINDOW = 0X452934;
            public static uint FLASH_ABILITY_BAR = 0X3CBB78;
            public static uint FLASH_MINIMAP_DISPLAY = 0X3CC0FC;
            public static uint FLASH_WANTED_DISPLAY = 0X3CBBB8;
            public static uint FLOOR = 0X9B89B0;
            public static uint FOCUS_USE_SPLINE = 0X3B9FE0;
            public static uint FORCE_CLEANUP = 0X424410;
            public static uint FORCE_PED_MOTION_STATE = 0X41B15C;
            public static uint FORCE_ROOM_FOR_ENTITY = 0X3D1AA8;
            public static uint FREEZE_ENTITY_POSITION = 0X3B0A48;
            public static uint FREEZE_RADIO_STATION = 0X39EA64;
            public static uint GENERATE_DIRECTIONS_TO_COORD = 0X403B54;
            public static uint GET_AMMO_IN_CLIP = 0X468A8C;
            public static uint GET_AMMO_IN_PED_WEAPON = 0X467A5C;
            public static uint GET_ANGLE_BETWEEN_2D_VECTORS = 0X3D5FB8;
            public static uint GET_AUDIBLE_MUSIC_TRACK_TEXT_ID = 0X39EA38;
            public static uint GET_BEST_PED_WEAPON = 0X4672E8;
            public static uint GET_BITS_IN_RANGE = 0X3D7628;
            public static uint GET_BLIP_ALPHA = 0X3CADC4;
            public static uint GET_BLIP_COLOUR = 0X3CAF00;
            public static uint GET_BLIP_COORDS = 0X3CA1B0;
            public static uint GET_BLIP_FROM_ENTITY = 0X3CA2A4;
            public static uint GET_BLIP_HUD_COLOUR = 0X3CAF3C;
            public static uint GET_BLIP_INFO_ID_COORD = 0X3CA1B0;
            public static uint GET_BLIP_INFO_ID_DISPLAY = 0X3CA22C;
            public static uint GET_BLIP_INFO_ID_ENTITY_INDEX = 0X3CA390;
            public static uint GET_BLIP_INFO_ID_PICKUP_INDEX = 0X53E80;
            public static uint GET_BLIP_INFO_ID_TYPE = 0X3CA268;
            public static uint GET_BLIP_SPRITE = 0X3CAB88;
            public static uint GET_CAM_ANIM_CURRENT_PHASE = 0X3A6130;
            public static uint GET_CAM_COORD = 0X3A3468;
            public static uint GET_CAM_FAR_CLIP = 0X3A3688;
            public static uint GET_CAM_FAR_DOF = 0X3A36F8;
            public static uint GET_CAM_FOV = 0X3A35B8;
            public static uint GET_CAM_NEAR_CLIP = 0X3A3620;
            public static uint GET_CAM_ROT = 0X3A34F4;
            public static uint GET_CAM_SPLINE_NODE_INDEX = 0X3A4FF8;
            public static uint GET_CAM_SPLINE_NODE_PHASE = 0X3A4F68;
            public static uint GET_CAM_SPLINE_PHASE = 0X3A4EB8;
            public static uint GET_CLOCK_DAY_OF_MONTH = 0X3A9420;
            public static uint GET_CLOCK_DAY_OF_WEEK = 0X3A9410;
            public static uint GET_CLOCK_HOURS = 0X1520E34;
            public static uint GET_CLOCK_MINUTES = 0X3A9328;
            public static uint GET_CLOCK_MONTH = 0X3A9434;
            public static uint GET_CLOCK_SECONDS = 0X3A933C;
            public static uint GET_CLOCK_YEAR = 0X3A9448;
            public static uint GET_CLOSEST_FIRE_POS = 0X00;
            public static uint GET_CLOSEST_MAJOR_VEHICLE_NODE = 0X00;
            public static uint GET_CLOSEST_OBJECT_OF_TYPE = 0X3FB5E0;
            public static uint GET_CLOSEST_PED = 0X412B1C;
            public static uint GET_CLOSEST_ROAD = 0X00;
            public static uint GET_CLOSEST_VEHICLE = 0X4549C8;
            public static uint GET_CLOSEST_VEHICLE_NODE = 0X00;
            public static uint GET_CLOSEST_VEHICLE_NODE_WITH_HEADING = 0X00;
            public static uint GET_CLOSEST_VEHICLE_TURNING_BLOODSPRAY = 0X45D390;
            public static uint GET_COMBAT_FLOAT = 0X40E688;
            public static uint GET_CONTROL_NORMAL = 0X400658;
            public static uint GET_CONTROL_VALUE = 0X4005B8;
            public static uint GET_CONVERTIBLE_ROOF_STATE = 0X455D48;
            public static uint GET_CURRENT_LANGUAGE = 0X3D6B9C;
            public static uint GET_CURRENT_PED_VEHICLE_WEAPON = 0X467434;
            public static uint GET_CURRENT_PED_WEAPON = 0X4671AC;
            public static uint GET_CURRENT_PLAYBACK_FOR_VEHICLE = 0X4525F0;
            public static uint GET_CURRENT_SCRIPTED_CONVERSATION_LINE = 0X39D054;
            public static uint GET_CURRENT_WEBSITE_ID = 0X3CD0B8;
            public static uint GET_CUTSCENE_SECTION_PLAYING = 0X3B6F98;
            public static uint GET_CUTSCENE_TIME = 0X3B6DF0;
            public static uint GET_CUTSCENE_TOTAL_DURATION = 0X3B6E38;
            public static uint GET_DEAD_PED_PICKUP_COORDS = 0X409C40;
            public static uint GET_DECAL_WASH_LEVEL = 0X3C3730;
            public static uint GET_DEFAULT_SCRIPT_RENDERTARGET_RENDER_ID = 0X15AF0;
            public static uint GET_DISABLED_CONTROL_NORMAL = 0X400898;
            public static uint GET_DISPLAY_NAME_FROM_VEHICLE_MODEL = 0X45A780;
            public static uint GET_DISTANCE_BETWEEN_COORDS = 0X3D5EEC;
            public static uint GET_DLC_VEHICLE_DATA = 0X3BAC08;
            public static uint GET_DLC_VEHICLE_FLAGS = 0X3BAC64;
            public static uint GET_DLC_VEHICLE_MODEL = 0X3BABD0;
            public static uint GET_DLC_WEAPON_COMPONENT_DATA = 0X3BBA34;
            public static uint GET_DLC_WEAPON_DATA = 0X3BB8CC;
            public static uint GET_ENTITY_ALPHA = 0X3B4928;
            public static uint GET_ENTITY_ANIM_CURRENT_TIME = 0X3AAF38;
            public static uint GET_ENTITY_ANIM_TOTAL_TIME = 0X3AB108;
            public static uint GET_ENTITY_ATTACHED_TO = 0X3AB3AC;
            public static uint GET_ENTITY_ATTACHED_TO_TOW_TRUCK = 0X45C578;
            public static uint GET_ENTITY_COORDS = 0X3AB420;
            public static uint GET_ENTITY_FORWARD_VECTOR = 0X3AB4D0;
            public static uint GET_ENTITY_FORWARD_X = 0X3AB568;
            public static uint GET_ENTITY_FORWARD_Y = 0X3AB610;
            public static uint GET_ENTITY_HEADING = 0X3AB6C0;
            public static uint GET_ENTITY_HEALTH = 0X3AB9F8;
            public static uint GET_ENTITY_HEIGHT = 0X3ABB70;
            public static uint GET_ENTITY_HEIGHT_ABOVE_GROUND = 0X3AC0C0;
            public static uint GET_ENTITY_INDEX_OF_CUTSCENE_ENTITY = 0X3B7BC4;
            public static uint GET_ENTITY_INDEX_OF_REGISTERED_ENTITY = 0X3B72C8;
            public static uint GET_ENTITY_MATRIX = 0X00;
            public static uint GET_ENTITY_MAX_HEALTH = 0X3ABA64;
            public static uint GET_ENTITY_MODEL = 0X3AC274;
            public static uint GET_ENTITY_PITCH = 0X3AC540;
            public static uint GET_ENTITY_QUATERNION = 0X3AC5F0;
            public static uint GET_ENTITY_ROLL = 0X3AC8C0;
            public static uint GET_ENTITY_ROTATION = 0X3AC948;
            public static uint GET_ENTITY_ROTATION_VELOCITY = 0X3ACA3C;
            public static uint GET_ENTITY_SCRIPT = 0X3ACAF0;
            public static uint GET_ENTITY_SPEED = 0X3ACB60;
            public static uint GET_ENTITY_SPEED_VECTOR = 0X3ACC10;
            public static uint GET_ENTITY_TYPE = 0X3AD214;
            public static uint GET_ENTITY_UPRIGHT_VALUE = 0X3ACEA8;
            public static uint GET_ENTITY_VELOCITY = 0X3ACF30;
            public static uint GET_EVENT_AT_INDEX = 0X4284D0;
            public static uint GET_EVENT_DATA = 0X42851C;
            public static uint GET_EVENT_EXISTS = 0X4281FC;
            public static uint GET_FIRST_BLIP_INFO_ID = 0X3CA10C;
            public static uint GET_FOLLOW_PED_CAM_VIEW_MODE = 0X3A697C;
            public static uint GET_FOLLOW_PED_CAM_ZOOM_LEVEL = 0X3A697C;
            public static uint GET_FOLLOW_VEHICLE_CAM_VIEW_MODE = 0X3A6A8C;
            public static uint GET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL = 0X3A6A8C;
            public static uint GET_FORCED_COMPONENT = 0X3BB730;
            public static uint GET_FORCED_PROP = 0X3BB774;
            public static uint GET_FRAME_COUNT = 0X3D454C;
            public static uint GET_FRAME_TIME = 0X3D453C;
            public static uint GET_GAME_TIMER = 0X3D4510;
            public static uint GET_GAMEPLAY_CAM_COORD = 0X3A659C;
            public static uint GET_GAMEPLAY_CAM_FOV = 0X3A6650;
            public static uint GET_GAMEPLAY_CAM_RELATIVE_HEADING = 0X3A6710;
            public static uint GET_GAMEPLAY_CAM_RELATIVE_PITCH = 0X3A67F8;
            public static uint GET_GAMEPLAY_CAM_ROT = 0X3A65D4;
            public static uint GET_GROUND_Z_FOR_3D_COORD = 0X3D4690;
            public static uint GET_GROUP_SIZE = 0X40E710;
            public static uint GET_HASH_KEY = 0X110C78;
            public static uint GET_HEADING_FROM_VECTOR_2D = 0X3D60C0;
            public static uint GET_HUD_COLOUR = 0X3CBA58;
            public static uint GET_HUD_COMPONENT_POSITION = 0X3CC7D8;
            public static uint GET_ID_OF_THIS_THREAD = 0X439A90;
            public static uint GET_IDEAL_PLAYER_SWITCH_TYPE = 0X437600;
            public static uint GET_INDEX_OF_CURRENT_LEVEL = 0X3D7B04;
            public static uint GET_INDEXED_ITEM_IN_ITEMSET = 0X3D2F3C;
            public static uint GET_INTERIOR_AT_COORDS = 0X3D1940;
            public static uint GET_INTERIOR_FROM_COLLISION = 0X3D2250;
            public static uint GET_INTERIOR_FROM_ENTITY = 0X3D1DC4;
            public static uint GET_INTERIOR_GROUP_ID = 0X3D1354;
            public static uint GET_IS_HIDEF = 0X3BF520;
            public static uint GET_IS_MULTIPLAYER_BRIEF = 0X3A78AC;
            public static uint GET_IS_TASK_ACTIVE = 0X43F004;
            public static uint GET_IS_WIDESCREEN = 0X3BF500;
            public static uint GET_ITEMSET_SIZE = 0X3D2EE4;
            public static uint GET_JACK_TARGET = 0X40CF4C;
            public static uint GET_KEY_FOR_ENTITY_IN_ROOM = 0X3D1D1C;
            public static uint GET_LENGTH_OF_LITERAL_STRING = 0X3C9458;
            public static uint GET_LENGTH_OF_STRING_WITH_THIS_TEXT_LABEL = 0X3C918C;
            public static uint GET_LIVERY_NAME = 0X45F974;
            public static uint GET_LOCAL_TIME = 0X156F3F8;
            public static uint GET_MAIN_PLAYER_BLIP_ID = 0X3CB900;
            public static uint GET_MAX_AMMO = 0X468CC8;
            public static uint GET_MAX_AMMO_IN_CLIP = 0X46896C;
            public static uint GET_MAX_WANTED_LEVEL = 0X423AF4;
            public static uint GET_MAXIMUM_NUMBER_OF_PHOTOS = 0X53E80;
            public static uint GET_MISSION_FLAG = 0X3D3BB8;
            public static uint GET_MOBILE_PHONE_POSITION = 0X9B8810;
            public static uint GET_MOBILE_PHONE_RENDER_ID = 0XB7B48;
            public static uint GET_MOBILE_PHONE_ROTATION = 0X00;
            public static uint GET_MOD_SLOT_NAME = 0X45F8E8;
            public static uint GET_MOD_TEXT_LABEL = 0X45F848;
            public static uint GET_MODEL_DIMENSIONS = 0X00;
            public static uint GET_MOUNT = 0X409234;
            public static uint GET_MUSIC_PLAYTIME = 0X3A0644;
            public static uint GET_NAME_OF_ZONE = 0X46B538;
            public static uint GET_NAMED_RENDERTARGET_RENDER_ID = 0X3C98E8;
            public static uint GET_NAVMESH_ROUTE_DISTANCE_REMAINING = 0X43CB2C;
            public static uint GET_NAVMESH_ROUTE_RESULT = 0X43CC04;
            public static uint GET_NEAREST_PLAYER_TO_ENTITY = 0X3B54D8;
            public static uint GET_NETWORK_ID_FROM_SOUND_ID = 0X39D850;
            public static uint GET_NETWORK_TIME = 0X3ED420;
            public static uint GET_NEXT_BLIP_INFO_ID = 0X3CA068;
            public static uint GET_NTH_CLOSEST_VEHICLE_NODE = 0X00;
            public static uint GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION = 0X00;
            public static uint GET_NTH_CLOSEST_VEHICLE_NODE_ID = 0X402664;
            public static uint GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING = 0X402728;
            public static uint GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING = 0X00;
            public static uint GET_NUM_MOD_KITS = 0X45EC44;
            public static uint GET_NUM_RESERVED_MISSION_OBJECTS = 0X3ED154;
            public static uint GET_NUM_RESERVED_MISSION_PEDS = 0X3ED1BC;
            public static uint GET_NUM_RESERVED_MISSION_VEHICLES = 0X3ED224;
            public static uint GET_NUM_VEHICLE_MODS = 0X45F604;
            public static uint GET_NUMBER_OF_ACTIVE_BLIPS = 0X3C9FEC;
            public static uint GET_NUMBER_OF_EVENTS = 0X42819C;
            public static uint GET_NUMBER_OF_FIRES_IN_RANGE = 0X3BD190;
            public static uint GET_NUMBER_OF_PASSENGER_VOICE_VARIATIONS = 0X39E9E8;
            public static uint GET_NUMBER_OF_PED_DRAWABLE_VARIATIONS = 0X410608;
            public static uint GET_NUMBER_OF_PED_TEXTURE_VARIATIONS = 0X410770;
            public static uint GET_NUMBER_OF_PLAYERS = 0X421AD0;
            public static uint GET_NUMBER_OF_STREAMING_REQUESTS = 0X436630;
            public static uint GET_NUMBER_OF_VEHICLE_COLOURS = 0X457F98;
            public static uint GET_NUMBER_OF_VEHICLE_MODEL_COLOURS = 0X457F3C;
            public static uint GET_NUMBER_OF_VEHICLE_NUMBER_PLATES = 0X453518;
            public static uint GET_OBJ_ENTITY = 0X3EB0B4;
            public static uint GET_OBJECT_FRAGMENT_DAMAGE_HEALTH = 0X3FDF50;
            public static uint GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS = 0X3AC330;
            public static uint GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS = 0X3AC404;
            public static uint GET_OFFSET_FROM_INTERIOR_IN_WORLD_COORDS = 0X3D1390;
            public static uint GET_ONSCREEN_KEYBOARD_RESULT = 0X3D9688;
            public static uint GET_PAUSE_MENU_STATE = 0X3CD70C;
            public static uint GET_PED_ACCURACY = 0X407B28;
            public static uint GET_PED_ALERTNESS = 0X408350;
            public static uint GET_PED_AMMO_BY_TYPE = 0X468DC0;
            public static uint GET_PED_ARMOUR = 0X40A2E8;
            public static uint GET_PED_AS_GROUP_MEMBER = 0X40FC84;
            public static uint GET_PED_BONE_COORDS = 0X4156D0;
            public static uint GET_PED_BONE_INDEX = 0X41A0FC;
            public static uint GET_PED_CAUSE_OF_DEATH = 0X40D9A8;
            public static uint GET_PED_COMBAT_MOVEMENT = 0X418CCC;
            public static uint GET_PED_COMBAT_RANGE = 0X418DF4;
            public static uint GET_PED_CONFIG_FLAG = 0X417550;
            public static uint GET_PED_DEFENSIVE_AREA_POSITION = 0X414008;
            public static uint GET_PED_DESIRED_MOVE_BLEND_RATIO = 0X445690;
            public static uint GET_PED_DRAWABLE_VARIATION = 0X4104D8;
            public static uint GET_PED_ENVEFF_SCALE = 0X41A268;
            public static uint GET_PED_EXTRACTED_DISPLACEMENT = 0X4143E0;
            public static uint GET_PED_FLOOD_INVINCIBILITY = 0X419C60;
            public static uint GET_PED_GROUP_INDEX = 0X40E804;
            public static uint GET_PED_HEAD_OVERLAY = 0X00;
            public static uint GET_PED_IN_VEHICLE_SEAT = 0X451268;
            public static uint GET_PED_LAST_DAMAGE_BONE = 0X40A440;
            public static uint GET_PED_LAST_WEAPON_IMPACT_COORD = 0X468F40;
            public static uint GET_PED_MAX_HEALTH = 0X40F370;
            public static uint GET_PED_MONEY = 0X40916C;
            public static uint GET_PED_NEARBY_PEDS = 0X41B59C;
            public static uint GET_PED_NEARBY_VEHICLES = 0X41B468;
            public static uint GET_PED_PALETTE_VARIATION = 0X4109BC;
            public static uint GET_PED_PARACHUTE_STATE = 0X40AD40;
            public static uint GET_PED_PARACHUTE_TINT_INDEX = 0X40AF50;
            public static uint GET_PED_PROP_INDEX = 0X411B14;
            public static uint GET_PED_PROP_TEXTURE_INDEX = 0X411CFC;
            public static uint GET_PED_RAGDOLL_BONE_INDEX = 0X41A168;
            public static uint GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH = 0X40E1CC;
            public static uint GET_PED_RELATIONSHIP_GROUP_HASH = 0X40E234;
            public static uint GET_PED_RESET_FLAG = 0X4175F0;
            public static uint GET_PED_STEALTH_MOVEMENT = 0X40B95C;
            public static uint GET_PED_TEXTURE_VARIATION = 0X410708;
            public static uint GET_PED_TIME_OF_DEATH = 0X40DA04;
            public static uint GET_PED_TYPE = 0X40F1E0;
            public static uint GET_PED_WAYPOINT_DISTANCE = 0X44D4B8;
            public static uint GET_PED_WAYPOINT_PROGRESS = 0X44D474;
            public static uint GET_PED_WEAPON_TINT_INDEX = 0X46A1E8;
            public static uint GET_PED_WEAPONTYPE_IN_SLOT = 0X467964;
            public static uint GET_PEDHEADSHOT_TXD_STRING = 0X41BB54;
            public static uint GET_PEDS_JACKER = 0X40CE38;
            public static uint GET_PICKUP_COORDS = 0X3FAE08;
            public static uint GET_PLAYER_CURRENT_STEALTH_NOISE = 0X425DA8;
            public static uint GET_PLAYER_GROUP = 0X423DCC;
            public static uint GET_PLAYER_HEADSET_SOUND_ALTERNATE = 0X39F734;
            public static uint GET_PLAYER_INDEX = 0X424290;
            public static uint GET_PLAYER_INVINCIBLE = 0X424960;
            public static uint GET_PLAYER_MAX_ARMOUR = 0X423E60;
            public static uint GET_PLAYER_NAME = 0X421C44;
            public static uint GET_PLAYER_PARACHUTE_TINT_INDEX = 0X42604C;
            public static uint GET_PLAYER_PED = 0X4219C8;
            public static uint GET_PLAYER_PED_SCRIPT_INDEX = 0X421A28;
            public static uint GET_PLAYER_RADIO_STATION_GENRE = 0X39E7B8;
            public static uint GET_PLAYER_RADIO_STATION_INDEX = 0X39E680;
            public static uint GET_PLAYER_RADIO_STATION_NAME = 0X39E6C0;
            public static uint GET_PLAYER_RGB_COLOUR = 0X421A68;
            public static uint GET_PLAYER_SHORT_SWITCH_STATE = 0X437824;
            public static uint GET_PLAYER_SPRINT_TIME_REMAINING = 0X423C98;
            public static uint GET_PLAYER_SWITCH_STATE = 0X437810;
            public static uint GET_PLAYER_SWITCH_TYPE = 0X4375E4;
            public static uint GET_PLAYER_TARGET_ENTITY = 0X4237C4;
            public static uint GET_PLAYER_TEAM = 0X421AFC;
            public static uint GET_PLAYER_UNDERWATER_TIME_REMAINING = 0X423D00;
            public static uint GET_PLAYER_WANTED_CENTRE_POSITION = 0X421C90;
            public static uint GET_PLAYER_WANTED_LEVEL = 0X422A80;
            public static uint GET_PLAYERS_LAST_VEHICLE = 0X424254;
            public static uint GET_POSITION_IN_RECORDING = 0X4540C0;
            public static uint GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME = 0X4582F0;
            public static uint GET_POSIX_TIME = 0X156F3F8;
            public static uint GET_PROFILE_SETTING = 0X3D6BD0;
            public static uint GET_RADIO_STATION_NAME = 0X39E6E8;
            public static uint GET_RAIN_LEVEL = 0X3D438C;
            public static uint GET_RANDOM_EVENT_FLAG = 0X3D3C54;
            public static uint GET_RANDOM_FLOAT_IN_RANGE = 0X3D45D0;
            public static uint GET_RANDOM_INT_IN_RANGE = 0X3D463C;
            public static uint GET_RANDOM_PED_AT_COORD = 0X412860;
            public static uint GET_RANDOM_VEHICLE_BACK_BUMPER_IN_SPHERE = 0X454970;
            public static uint GET_RANDOM_VEHICLE_FRONT_BUMPER_IN_SPHERE = 0X45492C;
            public static uint GET_RANDOM_VEHICLE_IN_SPHERE = 0X4548E8;
            public static uint GET_RANDOM_VEHICLE_MODEL_IN_MEMORY = 0X10FA0;
            public static uint GET_RANDOM_VEHICLE_NODE = 0X00;
            public static uint GET_RELATIONSHIP_BETWEEN_GROUPS = 0X40E29C;
            public static uint GET_RELATIONSHIP_BETWEEN_PEDS = 0X40E0F0;
            public static uint GET_RENDERING_CAM = 0X3A3410;
            public static uint GET_ROOM_KEY_FROM_ENTITY = 0X3D1F78;
            public static uint GET_ROPE_LAST_VERTEX_COORD = 0X41F960;
            public static uint GET_ROPE_VERTEX_COORD = 0X41F9D0;
            public static uint GET_ROPE_VERTEX_COUNT = 0X41FA28;
            public static uint GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME = 0X4583AC;
            public static uint GET_SAFE_COORD_FOR_PED = 0X00;
            public static uint GET_SAFE_PICKUP_COORDS = 0X3F91D0;
            public static uint GET_SCREEN_RESOLUTION = 0X3C16C0;
            public static uint GET_SCRIPT_TASK_STATUS = 0X43F210;
            public static uint GET_SELECTED_PED_WEAPON = 0X469078;
            public static uint GET_SEQUENCE_PROGRESS = 0X43EEF8;
            public static uint GET_SHOP_PED_COMPONENT = 0X3BB220;
            public static uint GET_SHOP_PED_OUTFIT_COMPONENT = 0X3BB418;
            public static uint GET_SHOP_PED_OUTFIT_PROP = 0X3BB480;
            public static uint GET_SHOP_PED_PROP = 0X3BB2D0;
            public static uint GET_SHOP_PED_QUERY_COMPONENT = 0X3BB1C8;
            public static uint GET_SHOP_PED_QUERY_OUTFIT = 0X3BB328;
            public static uint GET_SHOP_PED_QUERY_PROP = 0X3BB278;
            public static uint GET_SNOW_LEVEL = 0X3D439C;
            public static uint GET_SOUND_ID = 0X39D584;
            public static uint GET_STATE_OF_CLOSEST_DOOR_OF_TYPE = 0X3FC628;
            public static uint GET_STREAM_PLAY_TIME = 0X39F95C;
            public static uint GET_STREET_NAME_AT_COORD = 0X4030B8;
            public static uint GET_STREET_NAME_FROM_HASH_KEY = 0X3C94BC;
            public static uint GET_SYNCHRONIZED_SCENE_PHASE = 0X41AF08;
            public static uint GET_SYNCHRONIZED_SCENE_RATE = 0X41AE70;
            public static uint GET_TEXTURE_RESOLUTION = 0X3C098C;
            public static uint GET_THIS_SCRIPT_NAME = 0X439AB8;
            public static uint GET_TIME_DIFFERENCE = 0X3ED594;
            public static uint GET_TIME_OFFSET = 0X3ED548;
            public static uint GET_TIME_POSITION_IN_RECORDING = 0X454130;
            public static uint GET_TIME_SINCE_LAST_ARREST = 0X424DCC;
            public static uint GET_TIME_SINCE_LAST_DEATH = 0X424DF8;
            public static uint GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC = 0X42439C;
            public static uint GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT = 0X42435C;
            public static uint GET_TIME_SINCE_PLAYER_HIT_PED = 0X42431C;
            public static uint GET_TIME_SINCE_PLAYER_HIT_VEHICLE = 0X4242DC;
            public static uint GET_TIMECYCLE_MODIFIER_INDEX = 0X3C40CC;
            public static uint GET_TOTAL_DURATION_OF_VEHICLE_RECORDING = 0X458450;
            public static uint GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID = 0X458428;
            public static uint GET_TRAIN_CARRIAGE = 0X454D0C;
            public static uint GET_TV_CHANNEL = 0X3C518C;
            public static uint GET_TV_VOLUME = 0X3C51BC;
            public static uint GET_VEH_ROCKSTAR_ATAN2 = 0X4513A0;
            public static uint GET_VEHICLE_ACCELERATION = 0X456FD0;
            public static uint GET_VEHICLE_ATTACHED_TO_CARGOBOB = 0X45CAD0;
            public static uint GET_VEHICLE_CAUSE_OF_DESTRUCTION = 0X460040;
            public static uint GET_VEHICLE_CLASS = 0X461D0C;
            public static uint GET_VEHICLE_CLASS_FROM_NAME = 0X461D70;
            public static uint GET_VEHICLE_CLASS_MAX_ACCELERATION = 0X457780;
            public static uint GET_VEHICLE_CLASS_MAX_AGILITY = 0X457740;
            public static uint GET_VEHICLE_CLASS_MAX_BRAKING = 0X4577C0;
            public static uint GET_VEHICLE_CLASS_MAX_TRACTION = 0X457700;
            public static uint GET_VEHICLE_COLOR = 0X45FE48;
            public static uint GET_VEHICLE_COLOUR_COMBINATION = 0X4580EC;
            public static uint GET_VEHICLE_COLOURS = 0X4510FC;
            public static uint GET_VEHICLE_CUSTOM_PRIMARY_COLOUR = 0X4500D4;
            public static uint GET_VEHICLE_CUSTOM_SECONDARY_COLOUR = 0X450310;
            public static uint GET_VEHICLE_DEFAULT_HORN = 0X3A0C14;
            public static uint GET_VEHICLE_DEFORMATION_AT_POS = 0X45A8E0;
            public static uint GET_VEHICLE_DEFORMATION_GET_TREE = 0X462338;
            public static uint GET_VEHICLE_DIRT_LEVEL = 0X456730;
            public static uint GET_VEHICLE_DOOR_ANGLE_RATIO = 0X457800;
            public static uint GET_VEHICLE_DOOR_LOCK_STATUS = 0X458700;
            public static uint GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER = 0X44F6CC;
            public static uint GET_VEHICLE_ENGINE_HEALTH = 0X459E40;
            public static uint GET_VEHICLE_EXTRA_COLOURS = 0X458FC8;
            public static uint GET_VEHICLE_HAS_BACK_RECURSIVE = 0X45D40C;
            public static uint GET_VEHICLE_LAYOUT_HASH = 0X45A7DC;
            public static uint GET_VEHICLE_LIGHTS_STATE = 0X451440;
            public static uint GET_VEHICLE_LIVERY = 0X45AA54;
            public static uint GET_VEHICLE_LIVERY_COUNT = 0X45AAB4;
            public static uint GET_VEHICLE_MAX_BRAKING = 0X456E48;
            public static uint GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS = 0X44F148;
            public static uint GET_VEHICLE_MAX_TRACTION = 0X456F10;
            public static uint GET_VEHICLE_MOD = 0X45F498;
            public static uint GET_VEHICLE_MOD_COLOR_1 = 0X45F0CC;
            public static uint GET_VEHICLE_MOD_COLOR_2 = 0X45F16C;
            public static uint GET_VEHICLE_MOD_KIT = 0X45ED28;
            public static uint GET_VEHICLE_MOD_KIT_TYPE = 0X45ED88;
            public static uint GET_VEHICLE_MOD_MODIFIER_VALUE = 0X45FA00;
            public static uint GET_VEHICLE_MOD_VARIATION = 0X45F550;
            public static uint GET_VEHICLE_MODEL_ACCELERATION = 0X457390;
            public static uint GET_VEHICLE_MODEL_MAX_BRAKING = 0X457528;
            public static uint GET_VEHICLE_MODEL_MAX_TRACTION = 0X457180;
            public static uint GET_VEHICLE_MODEL_VALUE = 0X458E18;
            public static uint GET_VEHICLE_NODE_POSITION = 0X00;
            public static uint GET_VEHICLE_NODE_PROPERTIES = 0X402310;
            public static uint GET_VEHICLE_NUMBER_OF_PASSENGERS = 0X44F0D8;
            public static uint GET_VEHICLE_NUMBER_PLATE_TEXT = 0X4534B0;
            public static uint GET_VEHICLE_PED_IS_IN = 0X408DA8;
            public static uint GET_VEHICLE_PED_IS_USING = 0X40ED1C;
            public static uint GET_VEHICLE_PETROL_TANK_HEALTH = 0X459FA8;
            public static uint GET_VEHICLE_PLATE_TYPE = 0X461090;
            public static uint GET_VEHICLE_RECORDING_ID = 0X451EB0;
            public static uint GET_VEHICLE_TRAILER_VEHICLE = 0X45E580;
            public static uint GET_VEHICLE_TYRE_SMOKE_COLOR = 0X45FCFC;
            public static uint GET_VEHICLE_TYRES_CAN_BURST = 0X451DD8;
            public static uint GET_VEHICLE_WAYPOINT_PROGRESS = 0X44DFB4;
            public static uint GET_VEHICLE_WAYPOINT_TARGET_POINT = 0X44DFF4;
            public static uint GET_VEHICLE_WHEEL_TYPE = 0X45EE14;
            public static uint GET_VEHICLE_WINDOW_TINT = 0X45FDD0;
            public static uint GET_WANTED_LEVEL_RADIUS = 0X421C6C;
            public static uint GET_WANTED_LEVEL_THRESHOLD = 0X421E50;
            public static uint GET_WATER_HEIGHT = 0X465CA0;
            public static uint GET_WATER_HEIGHT_NO_WAVES = 0X465E00;
            public static uint GET_WEAPON_CLIP_SIZE = 0X46A59C;
            public static uint GET_WEAPON_COMPONENT_HUD_STATS = 0X46A3F8;
            public static uint GET_WEAPON_DAMAGE_TYPE = 0X46AB00;
            public static uint GET_WEAPON_HUD_STATS = 0X46A380;
            public static uint GET_WEAPON_OBJECT_FROM_PED = 0X46A054;
            public static uint GET_WEAPON_OBJECT_TINT_INDEX = 0X46A2CC;
            public static uint GET_WEAPON_TINT_COUNT = 0X46A334;
            public static uint GET_WEAPONTYPE_GROUP = 0X466A2C;
            public static uint GET_WEAPONTYPE_MODEL = 0X466904;
            public static uint GET_WEAPONTYPE_SLOT = 0X4669F0;
            public static uint GET_WIND_DIRECTION = 0X3D432C;
            public static uint GET_WIND_SPEED = 0X3D4300;
            public static uint GET_ZONE_AT_COORDS = 0X46B444;
            public static uint GET_ZONE_POPSCHEDULE = 0X46B4D4;
            public static uint GET_ZONE_SCUMMINESS = 0X46B600;
            public static uint GIVE_ACHIEVEMENT_TO_PLAYER = 0X424600;
            public static uint GIVE_DELAYED_WEAPON_TO_PED = 0X466BF8;
            public static uint GIVE_PED_HELMET = 0X41837C;
            public static uint GIVE_PED_NM_MESSAGE = 0X4158E4;
            public static uint GIVE_PED_TO_PAUSE_MENU = 0X3CE1EC;
            public static uint GIVE_PLAYER_RAGDOLL_CONTROL = 0X424A58;
            public static uint GIVE_WEAPON_COMPONENT_TO_PED = 0X469500;
            public static uint GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT = 0X469BE0;
            public static uint GIVE_WEAPON_OBJECT_TO_PED = 0X469DB4;
            public static uint GIVE_WEAPON_TO_PED = 0X466A68;
            public static uint HAS_ACHIEVEMENT_BEEN_PASSED = 0X42462C;
            public static uint HAS_ACTION_MODE_ASSET_LOADED = 0X41C460;
            public static uint HAS_ADDITIONAL_TEXT_LOADED = 0X3C9008;
            public static uint HAS_ANIM_DICT_LOADED = 0X435E34;
            public static uint HAS_ANIM_SET_LOADED = 0X435FBC;
            public static uint HAS_BULLET_IMPACTED_IN_AREA = 0X3D4924;
            public static uint HAS_BULLET_IMPACTED_IN_BOX = 0X3D4AF0;
            public static uint HAS_CLIP_SET_LOADED = 0X435FBC;
            public static uint HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN = 0X3FB990;
            public static uint HAS_COLLISION_FOR_MODEL_LOADED = 0X435C30;
            public static uint HAS_CUTSCENE_FINISHED = 0X3B6EBC;
            public static uint HAS_CUTSCENE_LOADED = 0X3B6F30;
            public static uint HAS_ENTITY_ANIM_FINISHED = 0X3AA250;
            public static uint HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT = 0X3AA4D8;
            public static uint HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED = 0X3AA544;
            public static uint HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE = 0X3AA5B0;
            public static uint HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY = 0X3AA61C;
            public static uint HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON = 0X467FD0;
            public static uint HAS_ENTITY_CLEAR_LOS_TO_ENTITY = 0X3AA804;
            public static uint HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT = 0X3AAA48;
            public static uint HAS_ENTITY_COLLIDED_WITH_ANYTHING = 0X3AACEC;
            public static uint HAS_MODEL_LOADED = 0X43595C;
            public static uint HAS_OBJECT_BEEN_BROKEN = 0X3FB8D0;
            public static uint HAS_PED_BEEN_DAMAGED_BY_WEAPON = 0X467EC4;
            public static uint HAS_PED_GOT_WEAPON = 0X46770C;
            public static uint HAS_PED_GOT_WEAPON_COMPONENT = 0X4695E8;
            public static uint HAS_PED_HEAD_BLEND_FINISHED = 0X4115A8;
            public static uint HAS_PED_RECEIVED_EVENT = 0X419E4C;
            public static uint HAS_PICKUP_BEEN_COLLECTED = 0X3FAEF4;
            public static uint HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED = 0X424B9C;
            public static uint HAS_PRELOAD_MODS_FINISHED = 0X45FBC8;
            public static uint HAS_PTFX_ASSET_LOADED = 0X43676C;
            public static uint HAS_SCALEFORM_MOVIE_LOADED = 0X3C44A4;
            public static uint HAS_SCRIPT_LOADED = 0X4395C8;
            public static uint HAS_SOUND_FINISHED = 0X39D968;
            public static uint HAS_STEALTH_MODE_ASSET_LOADED = 0X41C4CC;
            public static uint HAS_STREAMED_TEXTURE_DICT_LOADED = 0X3BF414;
            public static uint HAS_THIS_ADDITIONAL_TEXT_LOADED = 0X3C9084;
            public static uint HAS_THIS_CUTSCENE_LOADED = 0X3B6F54;
            public static uint HAS_VEHICLE_ASSET_LOADED = 0X454F74;
            public static uint HAS_VEHICLE_GOT_PROJECTILE_ATTACHED = 0X4693A8;
            public static uint HAS_VEHICLE_RECORDING_BEEN_LOADED = 0X45516C;
            public static uint HAS_WEAPON_ASSET_LOADED = 0X469914;
            public static uint HAS_WEAPON_GOT_WEAPON_COMPONENT = 0X469D08;
            public static uint HIDE_HELP_TEXT_THIS_FRAME = 0X3C9C10;
            public static uint HIDE_HUD_AND_RADAR_THIS_FRAME = 0X3CBCEC;
            public static uint HIDE_HUD_COMPONENT_THIS_FRAME = 0X3CC6DC;
            public static uint HIDE_LOADING_ON_FADE_THIS_FRAME = 0X3CBDE4;
            public static uint HIDE_NUMBER_ON_BLIP = 0X3CB604;
            public static uint HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE = 0X467C40;
            public static uint HIDE_SCRIPTED_HUD_COMPONENT_THIS_FRAME = 0X3CC688;
            public static uint HIDE_SPECIAL_ABILITY_LOCKON_OPERATION = 0X3CE62C;
            public static uint HINT_AMBIENT_AUDIO_BANK = 0X39D4C0;
            public static uint HINT_SCRIPT_AUDIO_BANK = 0X39D4C0;
            public static uint IGNORE_NEXT_RESTART = 0X3D359C;
            public static uint INIT_SHOP_PED_COMPONENT = 0X3BAE84;
            public static uint INIT_SHOP_PED_PROP = 0X3BAE84;
            public static uint INT_TO_PLAYERINDEX = 0X10FA0;
            public static uint INTERRUPT_CONVERSATION = 0X39D10C;
            public static uint IS_AIM_CAM_ACTIVE = 0X3A6B18;
            public static uint IS_ALARM_PLAYING = 0X3A0BBC;
            public static uint IS_AMBIENT_SPEECH_DISABLED = 0X39FCAC;
            public static uint IS_AMBIENT_SPEECH_PLAYING = 0X39E1CC;
            public static uint IS_AMBIENT_ZONE_ENABLED = 0X39F620;
            public static uint IS_AN_ENTITY = 0X3AD3B4;
            public static uint IS_ANY_OBJECT_NEAR_POINT = 0X3FE010;
            public static uint IS_ANY_PED_NEAR_POINT = 0X419850;
            public static uint IS_ANY_PED_SHOOTING_IN_AREA = 0X407888;
            public static uint IS_ANY_SPEECH_PLAYING = 0X39E2AC;
            public static uint IS_ANY_VEHICLE_NEAR_POINT = 0X45B4D8;
            public static uint IS_AREA_OCCUPIED = 0X3D5204;
            public static uint IS_AUDIO_SCENE_ACTIVE = 0X3A06E8;
            public static uint IS_AUSSIE_VERSION = 0X53E80;
            public static uint IS_AUTO_SAVE_IN_PROGRESS = 0X3D3864;
            public static uint IS_BIG_VEHICLE = 0X457ED0;
            public static uint IS_BIT_SET = 0X3D67B8;
            public static uint IS_BLIP_FLASHING = 0X3CB290;
            public static uint IS_BLIP_ON_MINIMAP = 0X3CAFE8;
            public static uint IS_BLIP_SHORT_RANGE = 0X3CAFA8;
            public static uint IS_BULLET_IN_ANGLED_AREA = 0X3D47C8;
            public static uint IS_BULLET_IN_AREA = 0X3D4884;
            public static uint IS_BULLET_IN_BOX = 0X3D4A24;
            public static uint IS_CAM_ACTIVE = 0X3A3348;
            public static uint IS_CAM_INTERPOLATING = 0X3A57D0;
            public static uint IS_CAM_PLAYING_ANIM = 0X3A6010;
            public static uint IS_CAM_RENDERING = 0X3A33A8;
            public static uint IS_CAM_SHAKING = 0X3A5B88;
            public static uint IS_CAM_SPLINE_PAUSED = 0X3A5608;
            public static uint IS_CAM_TRANSITIONING = 0X53E80;
            public static uint IS_CINEMATIC_CAM_RENDERING = 0X3A70E0;
            public static uint IS_CINEMATIC_CAM_SHAKING = 0X3A7144;
            public static uint IS_CINEMATIC_SHOT_ACTIVE = 0X3A7470;
            public static uint IS_CONTROL_ENABLED = 0X40039C;
            public static uint IS_CONTROL_JUST_PRESSED = 0X4004E4;
            public static uint IS_CONTROL_JUST_RELEASED = 0X40054C;
            public static uint IS_CONTROL_PRESSED = 0X400414;
            public static uint IS_CONTROL_RELEASED = 0X40047C;
            public static uint IS_CONVERSATION_PED_DEAD = 0X405D80;
            public static uint IS_COP_PED_IN_AREA_3D = 0X4179EC;
            public static uint IS_COP_VEHICLE_IN_AREA_3D = 0X458AE4;
            public static uint IS_CUTSCENE_ACTIVE = 0X3B6F0C;
            public static uint IS_CUTSCENE_PLAYING = 0X3B6EE8;
            public static uint IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID = 0X3ECB04;
            public static uint IS_DECAL_ALIVE = 0X3C3704;
            public static uint IS_DISABLED_CONTROL_JUST_PRESSED = 0X400798;
            public static uint IS_DISABLED_CONTROL_JUST_RELEASED = 0X400818;
            public static uint IS_DISABLED_CONTROL_PRESSED = 0X400718;
            public static uint IS_DLC_PRESENT = 0X3E3028;
            public static uint IS_DOOR_CLOSED = 0X3FD18C;
            public static uint IS_DURANGO_VERSION = 0X53E80;
            public static uint IS_ENTITY_A_MISSION_ENTITY = 0X3AD470;
            public static uint IS_ENTITY_A_PED = 0X3AD408;
            public static uint IS_ENTITY_A_VEHICLE = 0X3AD4E4;
            public static uint IS_ENTITY_AN_OBJECT = 0X3AD54C;
            public static uint IS_ENTITY_AT_COORD = 0X3AD5C0;
            public static uint IS_ENTITY_AT_ENTITY = 0X3AD750;
            public static uint IS_ENTITY_ATTACHED = 0X3AD900;
            public static uint IS_ENTITY_ATTACHED_TO_ANY_OBJECT = 0X3AD9A4;
            public static uint IS_ENTITY_ATTACHED_TO_ANY_PED = 0X3ADA1C;
            public static uint IS_ENTITY_ATTACHED_TO_ANY_VEHICLE = 0X3ADA94;
            public static uint IS_ENTITY_ATTACHED_TO_ENTITY = 0X3ADB0C;
            public static uint IS_ENTITY_DEAD = 0X3ADBF0;
            public static uint IS_ENTITY_FOCUS = 0X436EE0;
            public static uint IS_ENTITY_IN_AIR = 0X3ADCE0;
            public static uint IS_ENTITY_IN_ANGLED_AREA = 0X3ADED8;
            public static uint IS_ENTITY_IN_AREA = 0X3ADFE8;
            public static uint IS_ENTITY_IN_WATER = 0X3AE1A8;
            public static uint IS_ENTITY_IN_ZONE = 0X3AE0F8;
            public static uint IS_ENTITY_OCCLUDED = 0X3AEDD0;
            public static uint IS_ENTITY_ON_FIRE = 0X3BD0F4;
            public static uint IS_ENTITY_ON_SCREEN = 0X3AE424;
            public static uint IS_ENTITY_PLAYING_ANIM = 0X3AE4C8;
            public static uint IS_ENTITY_STATIC = 0X3AE650;
            public static uint IS_ENTITY_TOUCHING_ENTITY = 0X3AE6B4;
            public static uint IS_ENTITY_UPRIGHT = 0X3AEB68;
            public static uint IS_ENTITY_UPSIDEDOWN = 0X3AEC38;
            public static uint IS_ENTITY_VISIBLE = 0X3AECCC;
            public static uint IS_ENTITY_VISIBLE_TO_SCRIPT = 0X3AED2C;
            public static uint IS_ENTITY_WAITING_FOR_WORLD_COLLISION = 0X3AF3A8;
            public static uint IS_EXPLOSION_IN_ANGLED_AREA = 0X3BD83C;
            public static uint IS_EXPLOSION_IN_AREA = 0X3BD654;
            public static uint IS_EXPLOSION_IN_SPHERE = 0X3BD7D4;
            public static uint IS_FIRST_PERSON_AIM_CAM_ACTIVE = 0X3A6BBC;
            public static uint IS_FOLLOW_PED_CAM_ACTIVE = 0X3A68D8;
            public static uint IS_FOLLOW_VEHICLE_CAM_ACTIVE = 0X3A69C8;
            public static uint IS_FRONTEND_FADING = 0X53E80;
            public static uint IS_GAME_IN_CONTROL_OF_MUSIC = 0X39FBB4;
            public static uint IS_GAMEPLAY_CAM_LOOKING_BEHIND = 0X3A5944;
            public static uint IS_GAMEPLAY_CAM_RENDERING = 0X3A7088;
            public static uint IS_GAMEPLAY_CAM_SHAKING = 0X3A6F28;
            public static uint IS_GAMEPLAY_HINT_ACTIVE = 0X3A79CC;
            public static uint IS_GAMERTAG_CACHE_RELOADED = 0X00;
            public static uint IS_GARAGE_EMPTY = 0X3FEF68;
            public static uint IS_HELI_PART_BROKEN = 0X45AEDC;
            public static uint IS_HELP_MESSAGE_BEING_DISPLAYED = 0X3C9DB0;
            public static uint IS_HELP_MESSAGE_FADING_OUT = 0X3C9DD4;
            public static uint IS_HELP_MESSAGE_ON_SCREEN = 0X3C9D44;
            public static uint IS_HORN_ACTIVE = 0X39F854;
            public static uint IS_HUD_COMPONENT_ACTIVE = 0X3CC62C;
            public static uint IS_HUD_HIDDEN = 0X3CA8FC;
            public static uint IS_HUD_PREFERENCE_SWITCHED_ON = 0X3C9528;
            public static uint IS_IN_ITEMSET = 0X3D2FA0;
            public static uint IS_INCIDENT_VALID = 0X3D8444;
            public static uint IS_INTERIOR_CAPPED = 0X3D2760;
            public static uint IS_INTERIOR_DISABLED = 0X3D264C;
            public static uint IS_INTERIOR_READY = 0X3D1A54;
            public static uint IS_INTERIOR_SCENE = 0X3D1478;
            public static uint IS_IPL_ACTIVE = 0X436208;
            public static uint IS_ITEMSET_VALID = 0X3D2DDC;
            public static uint IS_LOOK_INVERTED = 0X400C10;
            public static uint IS_MEMORY_CARD_IN_USE = 0X3D3A58;
            public static uint IS_MESSAGE_BEING_DISPLAYED = 0X3C90B4;
            public static uint IS_MINIGAME_IN_PROGRESS = 0X3D6B38;
            public static uint IS_MISSION_COMPLETE_PLAYING = 0X3A0468;
            public static uint IS_MISSION_CREATOR_BLIP = 0X3CB114;
            public static uint IS_MOBILE_PHONE_CALL_ONGOING = 0X39D36C;
            public static uint IS_MOBILE_PHONE_RADIO_ACTIVE = 0X39E648;
            public static uint IS_MODEL_A_VEHICLE = 0X4364EC;
            public static uint IS_MODEL_IN_CDIMAGE = 0X436370;
            public static uint IS_MODEL_VALID = 0X436424;
            public static uint IS_NAMED_RENDERTARGET_LINKED = 0X3C99F4;
            public static uint IS_NAMED_RENDERTARGET_REGISTERED = 0X3C99B0;
            public static uint IS_NAVMESH_LOADED_IN_AREA = 0X4031B8;
            public static uint IS_NETWORK_LOADING_SCENE = 0X436360;
            public static uint IS_NETWORK_VEHICLE_BEEN_DAMAGED_BY_ANY_OBJECT = 0X3EBD70;
            public static uint IS_NEW_LOAD_SCENE_ACTIVE = 0X437468;
            public static uint IS_NEW_LOAD_SCENE_LOADED = 0X437478;
            public static uint IS_NEXT_WEATHER_TYPE = 0X3D3DD4;
            public static uint IS_OBJECT_NEAR_POINT = 0X3FE210;
            public static uint IS_OBJECT_VISIBLE = 0X3FC220;
            public static uint IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE = 0X3A28D0;
            public static uint IS_ORBIS_VERSION = 0X53E80;
            public static uint IS_PARTICLE_FX_DELAYED_BLINK = 0X3BF8E0;
            public static uint IS_PAUSE_MENU_ACTIVE = 0X3CD6B8;
            public static uint IS_PAUSE_MENU_RESTARTING = 0X3CD72C;
            public static uint IS_PC_VERSION = 0X53E80;
            public static uint IS_PED_A_PLAYER = 0X405AB4;
            public static uint IS_PED_ACTIVE_IN_SCENARIO = 0X448980;
            public static uint IS_PED_AIMING_FROM_COVER = 0X4059B8;
            public static uint IS_PED_ARMED = 0X46752C;
            public static uint IS_PED_BEING_ARRESTED = 0X53E80;
            public static uint IS_PED_BEING_JACKED = 0X40CAD0;
            public static uint IS_PED_BEING_STEALTH_KILLED = 0X419250;
            public static uint IS_PED_BEING_STUNNED = 0X40CBE8;
            public static uint IS_PED_CLIMBING = 0X40AA18;
            public static uint IS_PED_COMPONENT_VARIATION_VALID = 0X410BD4;
            public static uint IS_PED_CUFFED = 0X44B2EC;
            public static uint IS_PED_DIVING = 0X40AAF0;
            public static uint IS_PED_DOING_DRIVEBY = 0X40C8F0;
            public static uint IS_PED_DUCKING = 0X40B1D4;
            public static uint IS_PED_EVASIVE_DIVING = 0X41777C;
            public static uint IS_PED_FACING_PED = 0X406030;
            public static uint IS_PED_FALLING = 0X40A93C;
            public static uint IS_PED_FATALLY_INJURED = 0X405C2C;
            public static uint IS_PED_FLEEING = 0X40D060;
            public static uint IS_PED_GETTING_INTO_A_VEHICLE = 0X4102A0;
            public static uint IS_PED_GETTING_UP = 0X44925C;
            public static uint IS_PED_GOING_INTO_COVER = 0X40D5B0;
            public static uint IS_PED_GROUP_MEMBER = 0X40C3B8;
            public static uint IS_PED_HEADTRACKING_ENTITY = 0X417158;
            public static uint IS_PED_HEADTRACKING_PED = 0X417074;
            public static uint IS_PED_HUMAN = 0X408D18;
            public static uint IS_PED_HURT = 0X405BAC;
            public static uint IS_PED_IN_ANY_BOAT = 0X409DF0;
            public static uint IS_PED_IN_ANY_HELI = 0X409EF8;
            public static uint IS_PED_IN_ANY_PLANE = 0X409F84;
            public static uint IS_PED_IN_ANY_POLICE_VEHICLE = 0X40A83C;
            public static uint IS_PED_IN_ANY_SUB = 0X409E74;
            public static uint IS_PED_IN_ANY_TAXI = 0X40B234;
            public static uint IS_PED_IN_ANY_TRAIN = 0X410200;
            public static uint IS_PED_IN_ANY_VEHICLE = 0X4056A8;
            public static uint IS_PED_IN_COMBAT = 0X40C680;
            public static uint IS_PED_IN_COVER = 0X40D21C;
            public static uint IS_PED_IN_COVER_FACING_LEFT = 0X40D358;
            public static uint IS_PED_IN_CURRENT_CONVERSATION = 0X39E3D0;
            public static uint IS_PED_IN_FLYING_VEHICLE = 0X40A008;
            public static uint IS_PED_IN_GROUP = 0X40E90C;
            public static uint IS_PED_IN_MELEE_COMBAT = 0X406284;
            public static uint IS_PED_IN_MODEL = 0X40557C;
            public static uint IS_PED_IN_VEHICLE = 0X405368;
            public static uint IS_PED_IN_WRITHE = 0X44939C;
            public static uint IS_PED_INJURED = 0X405B28;
            public static uint IS_PED_JACKING = 0X40C9B8;
            public static uint IS_PED_JUMPING = 0X40A9AC;
            public static uint IS_PED_MALE = 0X408C9C;
            public static uint IS_PED_MODEL = 0X407BA8;
            public static uint IS_PED_ON_ANY_BIKE = 0X409B24;
            public static uint IS_PED_ON_FOOT = 0X409A00;
            public static uint IS_PED_ON_MOUNT = 0X40927C;
            public static uint IS_PED_ON_SPECIFIC_VEHICLE = 0X409344;
            public static uint IS_PED_ON_VEHICLE = 0X4092CC;
            public static uint IS_PED_PERFORMING_STEALTH_KILL = 0X4190F0;
            public static uint IS_PED_PLANTING_BOMB = 0X409BB0;
            public static uint IS_PED_PRONE = 0X40C888;
            public static uint IS_PED_RAGDOLL = 0X4133D0;
            public static uint IS_PED_RELOADING = 0X405948;
            public static uint IS_PED_RESPONDING_TO_EVENT = 0X40E308;
            public static uint IS_PED_RINGTONE_PLAYING = 0X39CAB0;
            public static uint IS_PED_RUNNING = 0X44AA40;
            public static uint IS_PED_RUNNING_ARREST_TASK = 0X44B240;
            public static uint IS_PED_RUNNING_MOBILE_PHONE_TASK = 0X4135F8;
            public static uint IS_PED_RUNNING_RAGDOLL_TASK = 0X413440;
            public static uint IS_PED_SHOOTING = 0X4079DC;
            public static uint IS_PED_SHOOTING_IN_AREA = 0X4076A8;
            public static uint IS_PED_SITTING_IN_ANY_VEHICLE = 0X4098F0;
            public static uint IS_PED_SITTING_IN_VEHICLE = 0X409794;
            public static uint IS_PED_SPRINTING = 0X44AB34;
            public static uint IS_PED_STILL = 0X44A880;
            public static uint IS_PED_STOPPED = 0X407628;
            public static uint IS_PED_STRAFING = 0X44ABF8;
            public static uint IS_PED_SWIMMING = 0X40FE74;
            public static uint IS_PED_SWIMMING_UNDER_WATER = 0X40FEE0;
            public static uint IS_PED_TRACKED = 0X419DE0;
            public static uint IS_PED_TRYING_TO_ENTER_A_LOCKED_VEHICLE = 0X410388;
            public static uint IS_PED_USING_ACTION_MODE = 0X41B740;
            public static uint IS_PED_USING_ANY_SCENARIO = 0X415EA8;
            public static uint IS_PED_USING_SCENARIO = 0X415D64;
            public static uint IS_PED_WALKING = 0X44A94C;
            public static uint IS_PED_WEAPON_COMPONENT_ACTIVE = 0X4696A4;
            public static uint IS_PED_WEARING_HELMET = 0X4181F8;
            public static uint IS_PEDHEADSHOT_READY = 0X41BB28;
            public static uint IS_PEDHEADSHOT_VALID = 0X41BADC;
            public static uint IS_PLAYBACK_GOING_ON_FOR_VEHICLE = 0X45251C;
            public static uint IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE = 0X45257C;
            public static uint IS_PLAYER_BEING_ARRESTED = 0X423FD4;
            public static uint IS_PLAYER_CLIMBING = 0X423F90;
            public static uint IS_PLAYER_CONTROL_ON = 0X423EA8;
            public static uint IS_PLAYER_DEAD = 0X422460;
            public static uint IS_PLAYER_FREE_AIMING = 0X423828;
            public static uint IS_PLAYER_FREE_AIMING_AT_ENTITY = 0X42387C;
            public static uint IS_PLAYER_FREE_FOR_AMBIENT_TASK = 0X424084;
            public static uint IS_PLAYER_IN_CUTSCENE = 0X3EC8EC;
            public static uint IS_PLAYER_LOGGING_IN_NP = 0X424860;
            public static uint IS_PLAYER_ONLINE = 0X3E3A20;
            public static uint IS_PLAYER_PLAYING = 0X422B94;
            public static uint IS_PLAYER_PRESSING_HORN = 0X4224B0;
            public static uint IS_PLAYER_READY_FOR_CUTSCENE = 0X423430;
            public static uint IS_PLAYER_RIDING_TRAIN = 0X42697C;
            public static uint IS_PLAYER_SCRIPT_CONTROL_ON = 0X423F30;
            public static uint IS_PLAYER_TARGETTING_ANYTHING = 0X423B04;
            public static uint IS_PLAYER_TARGETTING_ENTITY = 0X4236EC;
            public static uint IS_PLAYER_TELEPORT_ACTIVE = 0X425D84;
            public static uint IS_PLAYER_WANTED_LEVEL_GREATER = 0X422330;
            public static uint IS_POINT_IN_ANGLED_AREA = 0X3FD4C4;
            public static uint IS_POINT_OBSCURED_BY_A_MISSION_ENTITY = 0X3D53A8;
            public static uint IS_POINT_ON_ROAD = 0X4042C8;
            public static uint IS_POSITION_OCCUPIED = 0X3D5300;
            public static uint IS_PREV_WEATHER_TYPE = 0X3D3D78;
            public static uint IS_PROJECTILE_IN_AREA = 0X3D6D34;
            public static uint IS_PROJECTILE_TYPE_IN_ANGLED_AREA = 0X3D7180;
            public static uint IS_PROJECTILE_TYPE_IN_AREA = 0X3D7158;
            public static uint IS_PS3_VERSION = 0X15AF0;
            public static uint IS_RADAR_HIDDEN = 0X3CA910;
            public static uint IS_RADAR_PREFERENCE_SWITCHED_ON = 0X3C9548;
            public static uint IS_RADIO_RETUNING = 0X39E7F8;
            public static uint IS_SCENARIO_GROUP_ENABLED = 0X447E60;
            public static uint IS_SCENARIO_OCCUPIED = 0X447938;
            public static uint IS_SCENARIO_TYPE_ENABLED = 0X447F90;
            public static uint IS_SCREEN_FADED_IN = 0X3A6508;
            public static uint IS_SCREEN_FADED_OUT = 0X3A64E8;
            public static uint IS_SCREEN_FADING_IN = 0X3A64A8;
            public static uint IS_SCREEN_FADING_OUT = 0X3A64C8;
            public static uint IS_SCRIPTED_CONVERSATION_LOADED = 0X39D02C;
            public static uint IS_SCRIPTED_CONVERSATION_ONGOING = 0X39CFD4;
            public static uint IS_SCRIPTED_HUD_COMPONENT_ACTIVE = 0X3CC660;
            public static uint IS_SCRIPTED_SPEECH_PLAYING = 0X39E23C;
            public static uint IS_SHOCKING_EVENT_IN_SPHERE = 0X3BCA78;
            public static uint IS_SNIPER_BULLET_IN_AREA = 0X3D6CB4;
            public static uint IS_SNIPER_INVERTED = 0X53E80;
            public static uint IS_SPECIAL_ABILITY_ACTIVE = 0X425700;
            public static uint IS_SPECIAL_ABILITY_ENABLED = 0X425804;
            public static uint IS_SPECIAL_ABILITY_METER_FULL = 0X425750;
            public static uint IS_SPECIAL_ABILITY_UNLOCKED = 0X4256DC;
            public static uint IS_SPHERE_VISIBLE = 0X3A6EAC;
            public static uint IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE = 0X3ECC50;
            public static uint IS_SPHERE_VISIBLE_TO_PLAYER = 0X3ECCC0;
            public static uint IS_SRL_LOADED = 0X437EFC;
            public static uint IS_STREAM_PLAYING = 0X39F934;
            public static uint IS_STREAMING_ADDITIONAL_TEXT = 0X3C9058;
            public static uint IS_STRING_NULL = 0X3D74B4;
            public static uint IS_STRING_NULL_OR_EMPTY = 0X3D74CC;
            public static uint IS_STUNT_JUMP_IN_PROGRESS = 0X3D7914;
            public static uint IS_SUBTITLE_PREFERENCE_SWITCHED_ON = 0X3C9568;
            public static uint IS_SYNCHRONIZED_SCENE_LOOPED = 0X41AF90;
            public static uint IS_SYNCHRONIZED_SCENE_RUNNING = 0X41ACDC;
            public static uint IS_SYSTEM_UI_BEING_DISPLAYED = 0X4248E8;
            public static uint IS_TAXI_LIGHT_ON = 0X44FE54;
            public static uint IS_TENNIS_MODE = 0X3D8A3C;
            public static uint IS_THIS_A_MINIGAME_SCRIPT = 0X3D6B54;
            public static uint IS_THIS_MODEL_A_BICYCLE = 0X4561B0;
            public static uint IS_THIS_MODEL_A_BIKE = 0X456148;
            public static uint IS_THIS_MODEL_A_BOAT = 0X455F68;
            public static uint IS_THIS_MODEL_A_CAR = 0X456088;
            public static uint IS_THIS_MODEL_A_HELI = 0X456028;
            public static uint IS_THIS_MODEL_A_PLANE = 0X455FC8;
            public static uint IS_THIS_MODEL_A_QUADBIKE = 0X456210;
            public static uint IS_THIS_MODEL_A_TRAIN = 0X4560E8;
            public static uint IS_THREAD_ACTIVE = 0X439A50;
            public static uint IS_TOGGLE_MOD_ON = 0X45F7CC;
            public static uint IS_TRACKED_PED_VISIBLE = 0X419D20;
            public static uint IS_TRACKED_POINT_VISIBLE = 0X3BFC20;
            public static uint IS_VALID_INTERIOR = 0X3D1484;
            public static uint IS_VEHICLE_A_CONVERTIBLE = 0X455DA8;
            public static uint IS_VEHICLE_ALARM_ACTIVATED = 0X45A690;
            public static uint IS_VEHICLE_ATTACHED_TO_CARGOBOB = 0X45C96C;
            public static uint IS_VEHICLE_ATTACHED_TO_TOW_TRUCK = 0X45C464;
            public static uint IS_VEHICLE_ATTACHED_TO_TRAILER = 0X4532C0;
            public static uint IS_VEHICLE_BUMPER_BROKEN_OFF = 0X458980;
            public static uint IS_VEHICLE_DOOR_DAMAGED = 0X45876C;
            public static uint IS_VEHICLE_DOOR_FULLY_OPEN = 0X4568B0;
            public static uint IS_VEHICLE_DRIVEABLE = 0X45A234;
            public static uint IS_VEHICLE_EXTRA_TURNED_ON = 0X459724;
            public static uint IS_VEHICLE_HIGH_DETAIL = 0X45B72C;
            public static uint IS_VEHICLE_IN_BURNOUT = 0X45C0D4;
            public static uint IS_VEHICLE_IN_GARAGE_AREA = 0X44FEE4;
            public static uint IS_VEHICLE_MODEL = 0X44E6D8;
            public static uint IS_VEHICLE_NODE_ID_VALID = 0X402844;
            public static uint IS_VEHICLE_ON_ALL_WHEELS = 0X458D98;
            public static uint IS_VEHICLE_SEARCHLIGHT_ON = 0X45EA70;
            public static uint IS_VEHICLE_SEAT_FREE = 0X45117C;
            public static uint IS_VEHICLE_SIREN_ON = 0X450EFC;
            public static uint IS_VEHICLE_STOLEN = 0X461794;
            public static uint IS_VEHICLE_STOPPED = 0X44F05C;
            public static uint IS_VEHICLE_STOPPED_AT_TRAFFIC_LIGHTS = 0X459998;
            public static uint IS_VEHICLE_STUCK_ON_ROOF = 0X44EF48;
            public static uint IS_VEHICLE_STUCK_TIMER_UP = 0X45A14C;
            public static uint IS_VEHICLE_TYRE_BURST = 0X4514D8;
            public static uint IS_VEHICLE_VISIBLE = 0X461150;
            public static uint IS_VEHICLE_WINDOW_INTACT = 0X45AB1C;
            public static uint IS_WAYPOINT_ACTIVE = 0X3CB9D4;
            public static uint IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED = 0X44D434;
            public static uint IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE = 0X44DF78;
            public static uint IS_WEAPON_VALID = 0X467680;
            public static uint IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE = 0X3A2A4C;
            public static uint IS_XBOX360_VERSION = 0X53E80;
            public static uint KEY_HUD_COLOUR = 0X3CC448;
            public static uint KNOCK_OFF_PED_PROP = 0X411C60;
            public static uint KNOCK_PED_OFF_VEHICLE = 0X40FA38;
            public static uint LEADERBOARDS2_READ_BY_HANDLE = 0X430E90;
            public static uint LEADERBOARDS2_READ_BY_RADIUS = 0X431040;
            public static uint LEADERBOARDS2_READ_BY_RANK = 0X430F84;
            public static uint LEADERBOARDS2_READ_BY_ROW = 0X430CCC;
            public static uint LEADERBOARDS2_READ_BY_SCORE_FLOAT = 0X4311F8;
            public static uint LEADERBOARDS2_READ_BY_SCORE_INT = 0X43113C;
            public static uint LEADERBOARDS2_READ_FRIENDS_BY_ROW = 0X430BAC;
            public static uint LEADERBOARDS2_WRITE_DATA = 0X4327BC;
            public static uint LEADERBOARDS_CACHE_DATA_ROW = 0X43283C;
            public static uint LEADERBOARDS_CLEAR_CACHE_DATA = 0X4327E0;
            public static uint LEADERBOARDS_GET_CACHE_DATA_ROW = 0X432E88;
            public static uint LEADERBOARDS_GET_CACHE_EXISTS = 0X432D60;
            public static uint LEADERBOARDS_GET_CACHE_TIME = 0X432DAC;
            public static uint LEADERBOARDS_GET_COLUMN_ID = 0X4307E8;
            public static uint LEADERBOARDS_GET_COLUMN_TYPE = 0X430854;
            public static uint LEADERBOARDS_GET_NUMBER_OF_COLUMNS = 0X4307AC;
            public static uint LEADERBOARDS_READ_CLEAR = 0X43092C;
            public static uint LEADERBOARDS_READ_CLEAR_ALL = 0X4308DC;
            public static uint LEADERBOARDS_READ_PENDING = 0X430A04;
            public static uint LEADERBOARDS_READ_SUCCESSFUL = 0X430B14;
            public static uint LINK_NAMED_RENDERTARGET = 0X3C9B1C;
            public static uint LOAD_ALL_OBJECTS_NOW = 0X43627C;
            public static uint LOAD_ALL_PATH_NODES = 0X402C20;
            public static uint LOAD_MOVIE_MESH_SET = 0X3C15F4;
            public static uint LOAD_ROPE_DATA = 0X42012C;
            public static uint LOAD_SCENE = 0X4362B4;
            public static uint LOAD_STREAM = 0X39F984;
            public static uint LOAD_STREAM_WITH_START_OFFSET = 0X39F9B8;
            public static uint LOCK_MINIMAP_ANGLE = 0X3CC278;
            public static uint LOCK_MINIMAP_POSITION = 0X3CC2B0;
            public static uint LOWER_CONVERTIBLE_ROOF = 0X455C88;
            public static uint MAKE_PED_RELOAD = 0X4697E4;
            public static uint MELEE_SEETHROUGH_SKIPPED = 0X3BDF2C;
            public static uint MODIFY_WATER = 0X4665DC;
            public static uint MOVE_VEHICLE_DECALS = 0X3C38D8;
            public static uint NET_BUT = 0X3E8EC4;
            public static uint NET_TO_ENT = 0X3E9BB4;
            public static uint NET_TO_OBJ = 0X3E9BB4;
            public static uint NET_TO_PED = 0X3E9BB4;
            public static uint NET_TO_VEH = 0X3E9BB4;
            public static uint NETWORK_ACCEPT_PRESENCE_INVITE = 0X3E6CF8;
            public static uint NETWORK_ADD_ENTITY_AREA = 0X3EFB18;
            public static uint NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE = 0X3EF76C;
            public static uint NETWORK_ADD_FRIEND = 0X3EAFF8;
            public static uint NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE = 0X3EF6B4;
            public static uint NETWORK_AM_I_BLOCKED_BY_PLAYER = 0X3EB778;
            public static uint NETWORK_AM_I_MUTED_BY_PLAYER = 0X3EB6C0;
            public static uint NETWORK_ARE_HANDLES_THE_SAME = 0X3EA838;
            public static uint NETWORK_ATTACH_SYNCHRONISED_SCENE_TO_ENTITY = 0X3EF860;
            public static uint NETWORK_BAIL = 0X3E3CA8;
            public static uint NETWORK_BLOCK_INVITES = 0X3E4DCC;
            public static uint NETWORK_BUY_AIRSTRIKE = 0X3DF720;
            public static uint NETWORK_BUY_BOUNTY = 0X3DFBE8;
            public static uint NETWORK_BUY_HEALTHCARE = 0X3DF430;
            public static uint NETWORK_BUY_ITEM = 0X3DE010;
            public static uint NETWORK_BUY_PROPERTY = 0X3DFDA8;
            public static uint NETWORK_BUY_SMOKES = 0X3DFF30;
            public static uint NETWORK_CAN_COMMUNICATE_WITH_GAMER = 0X3EB3CC;
            public static uint NETWORK_CAN_ENTER_MULTIPLAYER = 0X3E3DE0;
            public static uint NETWORK_CAN_RECEIVE_PLAYER_CASH = 0X3E26A4;
            public static uint NETWORK_CAN_SESSION_END = 0X3E4FC0;
            public static uint NETWORK_CAN_SET_WAYPOINT = 0X3EB140;
            public static uint NETWORK_CHECK_GIVE_PLAYER_CASH = 0X00;
            public static uint NETWORK_CHECK_RECEIVE_PLAYER_CASH = 0X00;
            public static uint NETWORK_CLAN_DOWNLOAD_MEMBERSHIP = 0X3EEEF0;
            public static uint NETWORK_CLAN_DOWNLOAD_MEMBERSHIP_PENDING = 0X3EEF90;
            public static uint NETWORK_CLAN_GET_MEMBERSHIP = 0X3EF2B4;
            public static uint NETWORK_CLAN_GET_MEMBERSHIP_COUNT = 0X3EF3B0;
            public static uint NETWORK_CLAN_GET_MEMBERSHIP_VALID = 0X3EF190;
            public static uint NETWORK_CLAN_JOIN = 0X3EF468;
            public static uint NETWORK_CLAN_PLAYER_GET_DESC = 0X3EE97C;
            public static uint NETWORK_CLAN_PLAYER_IS_ACTIVE = 0X3EE6D4;
            public static uint NETWORK_CLEAR_FOUND_GAMERS = 0X3E4A48;
            public static uint NETWORK_CLEAR_TRANSITION_CREATOR_HANDLE = 0X3E598C;
            public static uint NETWORK_CREATE_SYNCHRONISED_SCENE = 0X3EF4D0;
            public static uint NETWORK_DELETE_CHARACTER = 0X3DBB7C;
            public static uint NETWORK_DO_TRANSITION_TO_FREEMODE = 0X3E5EBC;
            public static uint NETWORK_DO_TRANSITION_TO_GAME = 0X3E5C48;
            public static uint NETWORK_DO_TRANSITION_TO_NEW_FREEMODE = 0X3E5FC4;
            public static uint NETWORK_DO_TRANSITION_TO_NEW_GAME = 0X3E5D78;
            public static uint NETWORK_DOES_ENTITY_EXIST_WITH_NETWORK_ID = 0X3E9EF0;
            public static uint NETWORK_DOES_NETWORK_ID_EXIST = 0X3E9EBC;
            public static uint NETWORK_DOES_TUNABLE_EXIST = 0X3F00B4;
            public static uint NETWORK_EARN_FROM_BANK_INTEREST = 0X00;
            public static uint NETWORK_EARN_FROM_BETTING = 0X3DC464;
            public static uint NETWORK_EARN_FROM_BOUNTY = 0X3DCBB8;
            public static uint NETWORK_EARN_FROM_HOLDUPS = 0X3DCF60;
            public static uint NETWORK_EARN_FROM_JOB = 0X3DC620;
            public static uint NETWORK_EARN_FROM_PICKUP = 0X3DBFDC;
            public static uint NETWORK_EARN_FROM_PROPERTY = 0X3DD080;
            public static uint NETWORK_EARN_FROM_ROCKSTAR = 0X3DD408;
            public static uint NETWORK_EARN_FROM_VEHICLE = 0X3DD648;
            public static uint NETWORK_END_TUTORIAL_SESSION = 0X3EE014;
            public static uint NETWORK_EXPLODE_VEHICLE = 0X3F0828;
            public static uint NETWORK_FADE_IN_ENTITY = 0X3F13BC;
            public static uint NETWORK_FADE_OUT_ENTITY = 0X3F1240;
            public static uint NETWORK_GAMER_HAS_HEADSET = 0X3EB294;
            public static uint NETWORK_GAMERTAG_FROM_HANDLE_PENDING = 0X53E80;
            public static uint NETWORK_GAMERTAG_FROM_HANDLE_START = 0X53E80;
            public static uint NETWORK_GAMERTAG_FROM_HANDLE_SUCCEEDED = 0X53E80;
            public static uint NETWORK_GET_ACTIVITY_PLAYER_MAX = 0X00;
            public static uint NETWORK_GET_ACTIVITY_PLAYER_NUM = 0X3E5450;
            public static uint NETWORK_GET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU = 0X3E72DC;
            public static uint NETWORK_GET_DESTROYER_OF_NETWORK_ID = 0X3E98DC;
            public static uint NETWORK_GET_ENTITY_FROM_NETWORK_ID = 0X3E9BB4;
            public static uint NETWORK_GET_ENTITY_IS_LOCAL = 0X3E9C6C;
            public static uint NETWORK_GET_ENTITY_KILLER_OF_PLAYER = 0X3E96F4;
            public static uint NETWORK_GET_FOUND_GAMER = 0X3E49C8;
            public static uint NETWORK_GET_FRIEND_COUNT = 0X3EACEC;
            public static uint NETWORK_GET_FRIEND_NAME = 0X3EAD10;
            public static uint NETWORK_GET_GAME_REGION = 0X3EAAAC;
            public static uint NETWORK_GET_GAMERTAG_FROM_HANDLE = 0X3EA79C;
            public static uint NETWORK_GET_HOST_OF_SCRIPT = 0X3E8F48;
            public static uint NETWORK_GET_HOST_OF_THIS_SCRIPT = 0X3E8EFC;
            public static uint NETWORK_GET_KILLER_OF_PLAYER = 0X00;
            public static uint NETWORK_GET_LOCAL_HANDLE = 0X3EA380;
            public static uint NETWORK_GET_MAX_FRIENDS = 0X151CF1C;
            public static uint NETWORK_GET_NETWORK_ID_FROM_ENTITY = 0X3E9B30;
            public static uint NETWORK_GET_NUM_CONNECTED_PLAYERS = 0X3E8C28;
            public static uint NETWORK_GET_NUM_FOUND_GAMERS = 0X3E49A4;
            public static uint NETWORK_GET_PARTICIPANT_INDEX = 0X3E8AB8;
            public static uint NETWORK_GET_PLAYER_FROM_GAMER_HANDLE = 0X3EA8C0;
            public static uint NETWORK_GET_PLAYER_INDEX = 0X3E8BAC;
            public static uint NETWORK_GET_PLAYER_LOUDNESS = 0X3EB828;
            public static uint NETWORK_GET_PRESENCE_INVITE_HANDLE = 0X3E6DAC;
            public static uint NETWORK_GET_RESPAWN_RESULT = 0X00;
            public static uint NETWORK_GET_SCRIPT_STATUS = 0X3E8818;
            public static uint NETWORK_GET_TALKER_PROXIMITY = 0X3EB8C4;
            public static uint NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT = 0X3E8778;
            public static uint NETWORK_GET_TRANSITION_HOST = 0X3E643C;
            public static uint NETWORK_GET_TRANSITION_MEMBERS = 0X3E60F4;
            public static uint NETWORK_GIVE_PLAYER_JOBSHARE_CASH = 0X3DBCE0;
            public static uint NETWORK_HANDLE_FROM_FRIEND = 0X3EA640;
            public static uint NETWORK_HANDLE_FROM_MEMBER_ID = 0X3EA418;
            public static uint NETWORK_HANDLE_FROM_PLAYER = 0X3EA484;
            public static uint NETWORK_HANDLE_FROM_USER_ID = 0X3EA3C4;
            public static uint NETWORK_HAS_CONTROL_OF_DOOR = 0X3EA2E8;
            public static uint NETWORK_HAS_CONTROL_OF_ENTITY = 0X3EA180;
            public static uint NETWORK_HAS_CONTROL_OF_NETWORK_ID = 0X3E9FAC;
            public static uint NETWORK_HAS_CONTROL_OF_PICKUP = 0X3EA200;
            public static uint NETWORK_HAS_HEADSET = 0X3EB1CC;
            public static uint NETWORK_HAS_PENDING_INVITE = 0X3E4C88;
            public static uint NETWORK_HAS_PLAYER_STARTED_TRANSITION = 0X3E67D4;
            public static uint NETWORK_HAVE_ONLINE_PRIVILEGES = 0X3E3B2C;
            public static uint NETWORK_HOST_TRANSITION = 0X3E54E0;
            public static uint NETWORK_INVITE_GAMER = 0X00;
            public static uint NETWORK_INVITE_GAMER_TO_TRANSITION = 0X00;
            public static uint NETWORK_INVITE_GAMERS = 0X3E7100;
            public static uint NETWORK_INVITE_GAMERS_TO_TRANSITION = 0X3E59CC;
            public static uint NETWORK_IS_ACTIVITY_SESSION = 0X3E6A6C;
            public static uint NETWORK_IS_ACTIVITY_SPECTATOR = 0X3E53E0;
            public static uint NETWORK_IS_ACTIVITY_SPECTATOR_FROM_HANDLE = 0X3E5480;
            public static uint NETWORK_IS_ADDING_FRIEND = 0X3EAFD8;
            public static uint NETWORK_IS_CLOUD_AVAILABLE = 0X3E3A90;
            public static uint NETWORK_IS_FINDING_GAMERS = 0X3E4964;
            public static uint NETWORK_IS_FRIEND = 0X3EAF54;
            public static uint NETWORK_IS_FRIEND_IN_MULTIPLAYER = 0X3EAE44;
            public static uint NETWORK_IS_FRIEND_IN_SAME_TITLE = 0X3EADE8;
            public static uint NETWORK_IS_FRIEND_ONLINE = 0X3EAD4C;
            public static uint NETWORK_IS_GAME_IN_PROGRESS = 0X3E4F34;
            public static uint NETWORK_IS_GAMER_IN_MY_SESSION = 0X3EA9FC;
            public static uint NETWORK_IS_GAMER_MUTED_BY_ME = 0X3EB42C;
            public static uint NETWORK_IS_GAMER_TALKING = 0X3EB2F4;
            public static uint NETWORK_IS_HANDLE_VALID = 0X3EA6A8;
            public static uint NETWORK_IS_HOST = 0X3E3B00;
            public static uint NETWORK_IS_IN_MP_CUTSCENE = 0X3ED98C;
            public static uint NETWORK_IS_IN_PARTY = 0X53E80;
            public static uint NETWORK_IS_IN_SESSION = 0X3E4F60;
            public static uint NETWORK_IS_IN_SPECTATOR_MODE = 0X3ED914;
            public static uint NETWORK_IS_IN_TRANSITION = 0X3E649C;
            public static uint NETWORK_IS_IN_TUTORIAL_SESSION = 0X3EE05C;
            public static uint NETWORK_IS_INACTIVE_PROFILE = 0X3EAEA0;
            public static uint NETWORK_IS_LOCAL_PLAYER_INVINCIBLE = 0X3E9620;
            public static uint NETWORK_IS_PARTICIPANT_ACTIVE = 0X3E8D68;
            public static uint NETWORK_IS_PARTY_MEMBER = 0X53E80;
            public static uint NETWORK_IS_PENDING_FRIEND = 0X53E80;
            public static uint NETWORK_IS_PLAYER_A_PARTICIPANT = 0X3E8E88;
            public static uint NETWORK_IS_PLAYER_ACTIVE = 0X3E8DA8;
            public static uint NETWORK_IS_PLAYER_ANIMATION_DRAWING_SYNCHRONIZED = 0X3E4BCC;
            public static uint NETWORK_IS_PLAYER_BLOCKED_BY_ME = 0X3EB71C;
            public static uint NETWORK_IS_PLAYER_CONNECTED = 0X3E8C4C;
            public static uint NETWORK_IS_PLAYER_IN_MP_CUTSCENE = 0X3ED998;
            public static uint NETWORK_IS_PLAYER_MUTED_BY_ME = 0X3EB664;
            public static uint NETWORK_IS_PLAYER_TALKING = 0X3EB5AC;
            public static uint NETWORK_IS_ROCKSTAR_DEV = 0X00;
            public static uint NETWORK_IS_SCRIPT_ACTIVE = 0X3E90A8;
            public static uint NETWORK_IS_SESSION_ACTIVE = 0X3E4F40;
            public static uint NETWORK_IS_SESSION_BUSY = 0X3E4FA0;
            public static uint NETWORK_IS_SESSION_STARTED = 0X3E4F80;
            public static uint NETWORK_IS_SIGNED_IN = 0X3E3A00;
            public static uint NETWORK_IS_SIGNED_ONLINE = 0X3E3A20;
            public static uint NETWORK_IS_TRANSITION_BUSY = 0X3E64E4;
            public static uint NETWORK_IS_TRANSITION_HOST = 0X3E6390;
            public static uint NETWORK_IS_TRANSITION_HOST_FROM_HANDLE = 0X3E63BC;
            public static uint NETWORK_IS_TRANSITION_STARTED = 0X3E64C0;
            public static uint NETWORK_IS_TRANSITION_TO_GAME = 0X3E60DC;
            public static uint NETWORK_IS_UNLOCKED = 0X00;
            public static uint NETWORK_JOIN_TRANSITION = 0X3E68F8;
            public static uint NETWORK_LAUNCH_TRANSITION = 0X3E5B9C;
            public static uint NETWORK_LEAVE_TRANSITION = 0X3E5B40;
            public static uint NETWORK_MARK_TRANSITION_GAMER_AS_FULLY_JOINED = 0X3E6308;
            public static uint NETWORK_MEMBER_ID_FROM_GAMER_HANDLE = 0X3EA98C;
            public static uint NETWORK_OVERRIDE_CLOCK_TIME = 0X3EFA10;
            public static uint NETWORK_PLAYER_GET_NAME = 0X3EAACC;
            public static uint NETWORK_PLAYER_HAS_HEADSET = 0X3EB608;
            public static uint NETWORK_PLAYER_IS_CHEATER = 0X3F1CBC;
            public static uint NETWORK_PLAYER_IS_ROCKSTAR_DEV = 0X3EAC24;
            public static uint NETWORK_RECEIVE_PLAYER_JOBSHARE_CASH = 0X3DBEEC;
            public static uint NETWORK_REGISTER_HOST_BROADCAST_VARIABLES = 0X3E88B8;
            public static uint NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES = 0X3E893C;
            public static uint NETWORK_REMOVE_ALL_INVITES = 0X00;
            public static uint NETWORK_REMOVE_ENTITY_AREA = 0X3EFDFC;
            public static uint NETWORK_REMOVE_TRANSITION_INVITE = 0X3E7054;
            public static uint NETWORK_REQUEST_CONTROL_OF_DOOR = 0X3EA10C;
            public static uint NETWORK_REQUEST_CONTROL_OF_ENTITY = 0X3EA00C;
            public static uint NETWORK_REQUEST_CONTROL_OF_NETWORK_ID = 0X3E9F2C;
            public static uint NETWORK_RESET_BODY_TRACKER = 0X3F06D8;
            public static uint NETWORK_RESURRECT_LOCAL_PLAYER = 0X3E9460;
            public static uint NETWORK_SEND_TRANSITION_GAMER_INSTRUCTION = 0X3E625C;
            public static uint NETWORK_SESSION_CANCEL_INVITE = 0X3E4BF4;
            public static uint NETWORK_SESSION_END = 0X3E4170;
            public static uint NETWORK_SESSION_ENTER = 0X3E3E08;
            public static uint NETWORK_SESSION_GET_INVITER = 0X3E4D0C;
            public static uint NETWORK_SESSION_HOST = 0X3E3FBC;
            public static uint NETWORK_SESSION_HOST_FRIENDS_ONLY = 0X3E4060;
            public static uint NETWORK_SESSION_HOST_SINGLE_PLAYER = 0X3E4EDC;
            public static uint NETWORK_SESSION_KICK_PLAYER = 0X3E41B0;
            public static uint NETWORK_SESSION_LEAVE_SINGLE_PLAYER = 0X3E4F04;
            public static uint NETWORK_SESSION_VOICE_HOST = 0X3E51B0;
            public static uint NETWORK_SESSION_VOICE_LEAVE = 0X3E51D8;
            public static uint NETWORK_SET_ACTIVITY_SPECTATOR = 0X3E53B4;
            public static uint NETWORK_SET_ACTIVITY_SPECTATOR_MAX = 0X3E5424;
            public static uint NETWORK_SET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU = 0X3E733C;
            public static uint NETWORK_SET_ENTITY_CAN_BLEND = 0X3EC284;
            public static uint NETWORK_SET_FRIENDLY_FIRE_OPTION = 0X3EBF24;
            public static uint NETWORK_SET_GAMER_INVITED_TO_TRANSITION = 0X3E5ABC;
            public static uint NETWORK_SET_IN_MP_CUTSCENE = 0X3ED954;
            public static uint NETWORK_SET_IN_SPECTATOR_MODE = 0X3ED74C;
            public static uint NETWORK_SET_KEEP_FOCUSPOINT = 0X3E5258;
            public static uint NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME = 0X3E95E4;
            public static uint NETWORK_SET_MISSION_FINISHED = 0X3E905C;
            public static uint NETWORK_SET_OVERRIDE_SPECTATOR_MODE = 0X3EBB6C;
            public static uint NETWORK_SET_PLAYER_MUTED = 0X00;
            public static uint NETWORK_SET_PROPERTY_ID = 0X3F0DE0;
            public static uint NETWORK_SET_RICH_PRESENCE = 0X10FA0;
            public static uint NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME = 0X3D5EB4;
            public static uint NETWORK_SET_TALKER_PROXIMITY = 0X3EB894;
            public static uint NETWORK_SET_TEAM_ONLY_CHAT = 0X3EB9A8;
            public static uint NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT = 0X3E86F4;
            public static uint NETWORK_SET_TRANSITION_CREATOR_HANDLE = 0X3E5934;
            public static uint NETWORK_SET_VOICE_ACTIVE = 0X3EB924;
            public static uint NETWORK_SET_VOICE_CHANNEL = 0X3EBCC0;
            public static uint NETWORK_SHOW_PROFILE_UI = 0X3EAA5C;
            public static uint NETWORK_SPENT_AMMO_DROP = 0X3DFAB8;
            public static uint NETWORK_SPENT_BANK_INTEREST = 0X3E12D8;
            public static uint NETWORK_SPENT_BETTING = 0X3DED60;
            public static uint NETWORK_SPENT_BOAT_PICKUP = 0X3E0190;
            public static uint NETWORK_SPENT_BOUNTY = 0X3E19F0;
            public static uint NETWORK_SPENT_BUY_WANTEDLEVEL = 0X3E08B0;
            public static uint NETWORK_SPENT_CALL_PLAYER = 0X3E1830;
            public static uint NETWORK_SPENT_CARWASH = 0X3E0CD0;
            public static uint NETWORK_SPENT_CASH_DROP = 0X3E03F0;
            public static uint NETWORK_SPENT_CINEMA = 0X3E0E10;
            public static uint NETWORK_SPENT_HELI_PICKUP = 0X3E0060;
            public static uint NETWORK_SPENT_HOLDUPS = 0X3E1078;
            public static uint NETWORK_SPENT_PAY_VEHICLE_INSURANCE_PREMIUM = 0X3E1658;
            public static uint NETWORK_SPENT_TAXI = 0X3DE404;
            public static uint NETWORK_SPENT_TELESCOPE = 0X3E0F48;
            public static uint NETWORK_START_SYNCHRONISED_SCENE = 0X3EF908;
            public static uint NETWORK_STOP_LOAD_SCENE = 0X436338;
            public static uint NETWORK_STOP_SYNCHRONISED_SCENE = 0X3EF958;
            public static uint NETWORK_SUPPRESS_INVITE = 0X3E4DA0;
            public static uint NETWORK_UPDATE_LOAD_SCENE = 0X436310;
            public static uint NEW_LOAD_SCENE_START = 0X4372C0;
            public static uint NEW_LOAD_SCENE_STOP = 0X437440;
            public static uint OBJ_TO_NET = 0X3E9B30;
            public static uint OBJECT_DECAL_TOGGLE = 0X3CD770;
            public static uint OPEN_PATROL_ROUTE = 0X44940C;
            public static uint OPEN_SEQUENCE_TASK = 0X43EC94;
            public static uint OVERIDE_TEXTURENAMES = 0X3BA00C;
            public static uint OVERRIDE_CAM_SPLINE_MOTION_BLUR = 0X3A5428;
            public static uint OVERRIDE_CAM_SPLINE_VELOCITY = 0X3A5348;
            public static uint OVERRIDE_SAVE_HOUSE = 0X00;
            public static uint OVERRIDE_TREVOR_RAGE = 0X39DE24;
            public static uint OVERRIDE_UNDERWATER_STREAM = 0X39D908;
            public static uint OVERRIDE_VEH_HORN = 0X39F7E8;
            public static uint PARTICIPANT_ID = 0X3E9408;
            public static uint PARTICIPANT_ID_TO_INT = 0X3E9408;
            public static uint PAUSE_CLOCK = 0X3A93C0;
            public static uint PAUSE_PLAYBACK_RECORDED_VEHICLE = 0X45246C;
            public static uint PAUSE_SCRIPTED_CONVERSATION = 0X39D084;
            public static uint PED_TO_NET = 0X3E9B30;
            public static uint PIN_ROPE_VERTEX = 0X420170;
            public static uint PLACE_OBJECT_ON_GROUND_PROPERLY = 0X3F9110;
            public static uint PLAY_CAM_ANIM = 0X3A5DC0;
            public static uint PLAY_END_CREDITS_MUSIC = 0X39EB6C;
            public static uint PLAY_ENTITY_ANIM = 0X3B0CA0;
            public static uint PLAY_ENTITY_SCRIPTED_ANIM = 0X43D994;
            public static uint PLAY_FACIAL_ANIM = 0X416A48;
            public static uint PLAY_MISSION_COMPLETE_AUDIO = 0X3A0438;
            public static uint PLAY_PAIN = 0X39DEEC;
            public static uint PLAY_PED_RINGTONE = 0X39C8DC;
            public static uint PLAY_POLICE_REPORT = 0X39E61C;
            public static uint PLAY_SOUND = 0X39D768;
            public static uint PLAY_SOUND_FROM_COORD = 0X39D6FC;
            public static uint PLAY_SOUND_FROM_ENTITY = 0X39D668;
            public static uint PLAY_SOUND_FRONTEND = 0X39D7A8;
            public static uint PLAY_STREAM_FROM_OBJECT = 0X39FB1C;
            public static uint PLAY_STREAM_FROM_VEHICLE = 0X39FABC;
            public static uint PLAY_STREAM_FRONTEND = 0X39F9F0;
            public static uint PLAY_SYNCHRONIZED_AUDIO_EVENT = 0X3A0F40;
            public static uint PLAY_SYNCHRONIZED_CAM_ANIM = 0X3A5F4C;
            public static uint PLAY_SYNCHRONIZED_ENTITY_ANIM = 0X3B11CC;
            public static uint PLAY_VEHICLE_DOOR_CLOSE_SOUND = 0X3A01F4;
            public static uint PLAY_VEHICLE_DOOR_OPEN_SOUND = 0X3A02CC;
            public static uint PLAYER_ID = 0X4241D4;
            public static uint PLAYER_PED_ID = 0X424218;
            public static uint PLAYSTATS_AWARD_XP = 0X42DC94;
            public static uint PLAYSTATS_CHEAT_APPLIED = 0X42E990;
            public static uint PLAYSTATS_CLOTH_CHANGE = 0X42E82C;
            public static uint PLAYSTATS_FRIEND_ACTIVITY = 0X42E730;
            public static uint PLAYSTATS_MATCH_ENDED = 0X00;
            public static uint PLAYSTATS_MATCH_STARTED = 0X42E3A4;
            public static uint PLAYSTATS_MISSION_CHECKPOINT = 0X42E1C4;
            public static uint PLAYSTATS_MISSION_OVER = 0X42E13C;
            public static uint PLAYSTATS_MISSION_STARTED = 0X42E084;
            public static uint PLAYSTATS_NPC_INVITE = 0X42DBC4;
            public static uint PLAYSTATS_ODDJOB_DONE = 0X10FA0;
            public static uint PLAYSTATS_POST_MATCH_BLOB = 0X00;
            public static uint PLAYSTATS_PROP_CHANGE = 0X42E788;
            public static uint PLAYSTATS_RACE_CHECKPOINT = 0X42E2A8;
            public static uint PLAYSTATS_RANK_UP = 0X42DE2C;
            public static uint PLAYSTATS_SHOP_ITEM = 0X42E484;
            public static uint POINT_CAM_AT_COORD = 0X3A4544;
            public static uint POINT_CAM_AT_ENTITY = 0X3A45E8;
            public static uint POINT_CAM_AT_PED_BONE = 0X3A4700;
            public static uint POP_TIMECYCLE_MODIFIER = 0X3C4144;
            public static uint POPULATE_NOW = 0X3D7AE0;
            public static uint POW = 0X9B890C;
            public static uint PREFETCH_SRL = 0X437ECC;
            public static uint PRELOAD_FIND = 0X3B9704;
            public static uint PRELOAD_SCRIPT_CONVERSATION = 0X39CF34;
            public static uint PRELOAD_SCRIPT_PHONE_CONVERSATION = 0X39D32C;
            public static uint PRELOAD_VEHICLE_MOD = 0X45FB30;
            public static uint PREPARE_ALARM = 0X3A0AFC;
            public static uint PREPARE_MUSIC_EVENT = 0X3A055C;
            public static uint PREPARE_SYNCHRONIZED_AUDIO_EVENT = 0X3A0EDC;
            public static uint PREPARE_SYNCHRONIZED_AUDIO_EVENT_FOR_SCENE = 0X3A0EFC;
            public static uint PULSE_BLIP = 0X3CB57C;
            public static uint PUSH_TIMECYCLE_MODIFIER = 0X3C40F4;
            public static uint RAISE_CONVERTIBLE_ROOF = 0X455CE8;
            public static uint REFRESH_INTERIOR = 0X3D24E4;
            public static uint REFRESH_WAYPOINT = 0X3CB9B4;
            public static uint REGISTER_BOOL_TO_SAVE = 0X3D7C80;
            public static uint REGISTER_ENTITY_FOR_CUTSCENE = 0X3B7070;
            public static uint REGISTER_FLOAT_TO_SAVE = 0X3D7CC0;
            public static uint REGISTER_HATED_TARGETS_AROUND_PED = 0X4124C4;
            public static uint REGISTER_INT_TO_SAVE = 0X3D7C80;
            public static uint REGISTER_NAMED_RENDERTARGET = 0X3C9924;
            public static uint REGISTER_OBJECT_SCRIPT_BRAIN = 0X3A27EC;
            public static uint REGISTER_PEDHEADSHOT = 0X41B9D0;
            public static uint REGISTER_SAVE_HOUSE = 0X3D3624;
            public static uint REGISTER_SCRIPT_WITH_AUDIO = 0X10FA0;
            public static uint REGISTER_SYNCHRONISED_SCRIPT_SPEECH = 0X3B7784;
            public static uint REGISTER_TARGET = 0X41215C;
            public static uint REGISTER_TEXT_LABEL_TO_SAVE = 0X3D7D00;
            public static uint REGISTER_WORLD_POINT_SCRIPT_BRAIN = 0X3A2970;
            public static uint RELEASE_AMBIENT_AUDIO_BANK = 0X39D4FC;
            public static uint RELEASE_MISSION_AUDIO_BANK = 0X39D4FC;
            public static uint RELEASE_MOVIE_MESH_SET = 0X3C1644;
            public static uint RELEASE_NAMED_RENDERTARGET = 0X3C9AE4;
            public static uint RELEASE_NAMED_SCRIPT_AUDIO_BANK = 0X39D524;
            public static uint RELEASE_PRELOAD_MODS = 0X45FC2C;
            public static uint RELEASE_SCRIPT_AUDIO_BANK = 0X39D4FC;
            public static uint RELEASE_SOUND_ID = 0X39D63C;
            public static uint RELEASE_WEAPON_AUDIO = 0X39D414;
            public static uint REMOVE_ACTION_MODE_ASSET = 0X41C484;
            public static uint REMOVE_ALL_COVER_BLOCKING_AREAS = 0X447510;
            public static uint REMOVE_ALL_PED_WEAPONS = 0X467BB0;
            public static uint REMOVE_ALL_PICKUPS_OF_TYPE = 0X3FAEC0;
            public static uint REMOVE_ALL_PROJECTILES_OF_TYPE = 0X46920C;
            public static uint REMOVE_ALL_SHOCKING_EVENTS = 0X3BCCB4;
            public static uint REMOVE_ANIM_DICT = 0X435E98;
            public static uint REMOVE_ANIM_SET = 0X436030;
            public static uint REMOVE_BLIP = 0X3CB4BC;
            public static uint REMOVE_CLIP_SET = 0X436030;
            public static uint REMOVE_COVER_POINT = 0X446458;
            public static uint REMOVE_CUTSCENE = 0X3B6574;
            public static uint REMOVE_DECAL = 0X3C36D8;
            public static uint REMOVE_DECALS_FROM_OBJECT = 0X3C309C;
            public static uint REMOVE_DECALS_FROM_OBJECT_FACING = 0X3C3110;
            public static uint REMOVE_DECALS_FROM_VEHICLE = 0X3C31B4;
            public static uint REMOVE_DECALS_IN_RANGE = 0X3C3020;
            public static uint REMOVE_DISPATCH_SPAWN_BLOCKING_AREA = 0X3D91CC;
            public static uint REMOVE_FORCED_OBJECT = 0X3B4FB0;
            public static uint REMOVE_FROM_ITEMSET = 0X3D2E80;
            public static uint REMOVE_GROUP = 0X40C230;
            public static uint REMOVE_IPL = 0X43614C;
            public static uint REMOVE_MODEL_HIDE = 0X3B4E60;
            public static uint REMOVE_MODEL_SWAP = 0X3B4CC0;
            public static uint REMOVE_MULTIPLAYER_BANK_CASH = 0X3CBD8C;
            public static uint REMOVE_MULTIPLAYER_HUD_CASH = 0X3CBDAC;
            public static uint REMOVE_NAVMESH_BLOCKING_OBJECT = 0X40397C;
            public static uint REMOVE_NAVMESH_REQUIRED_REGIONS = 0X40315C;
            public static uint REMOVE_NIGHTVISION_MELEE = 0X4108EC;
            public static uint REMOVE_PARTICLE_FX = 0X3C24E8;
            public static uint REMOVE_PARTICLE_FX_FROM_ENTITY = 0X3C25A4;
            public static uint REMOVE_PARTICLE_FX_IN_RANGE = 0X3C2610;
            public static uint REMOVE_PED_DEFENSIVE_AREA = 0X413F94;
            public static uint REMOVE_PED_ELEGANTLY = 0X407DE4;
            public static uint REMOVE_PED_FROM_GROUP = 0X40C304;
            public static uint REMOVE_PED_HELMET = 0X4183A0;
            public static uint REMOVE_PICKUP = 0X3FAF80;
            public static uint REMOVE_PLAYER_HELMET = 0X4249F4;
            public static uint REMOVE_PTFX_ASSET = 0X436874;
            public static uint REMOVE_RELATIONSHIP_GROUP = 0X40DCF4;
            public static uint REMOVE_SCENARIO_BLOCKING_AREA = 0X415C74;
            public static uint REMOVE_SCENARIO_BLOCKING_AREAS = 0X415C4C;
            public static uint REMOVE_SCRIPT_FIRE = 0X3BCF44;
            public static uint REMOVE_SHOCKING_EVENT = 0X3BCBF8;
            public static uint REMOVE_STEALTH_MODE_ASSET = 0X41C4F0;
            public static uint REMOVE_VEHICLE_ASSET = 0X455084;
            public static uint REMOVE_VEHICLE_HIGH_DETAIL_MODEL = 0X45B6CC;
            public static uint REMOVE_VEHICLE_MOD = 0X45F6A0;
            public static uint REMOVE_VEHICLE_MOD_KIT = 0X45F384;
            public static uint REMOVE_VEHICLE_RECORDING = 0X4551B4;
            public static uint REMOVE_VEHICLE_STUCK_CHECK = 0X4510D0;
            public static uint REMOVE_VEHICLE_UPSIDEDOWN_CHECK = 0X44F030;
            public static uint REMOVE_VEHICLE_WINDOW = 0X4527A8;
            public static uint REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA = 0X459598;
            public static uint REMOVE_WAYPOINT_RECORDING = 0X44CF84;
            public static uint REMOVE_WEAPON_ASSET = 0X469A80;
            public static uint REMOVE_WEAPON_COMPONENT_FROM_PED = 0X469574;
            public static uint REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT = 0X469C44;
            public static uint REMOVE_WEAPON_FROM_PED = 0X467B08;
            public static uint RENDER_SCRIPT_CAMS = 0X3A2D38;
            public static uint REPORT_CRIME = 0X422FD8;
            public static uint REQUEST_ACTION_MODE_ASSET = 0X41C43C;
            public static uint REQUEST_ADDITIONAL_COLLISION_AT_COORD = 0X436580;
            public static uint REQUEST_ADDITIONAL_TEXT = 0X3C8FA0;
            public static uint REQUEST_AMBIENT_AUDIO_BANK = 0X39D480;
            public static uint REQUEST_ANIM_DICT = 0X435D9C;
            public static uint REQUEST_ANIM_SET = 0X435F04;
            public static uint REQUEST_CLIP_SET = 0X435F04;
            public static uint REQUEST_COLLISION_AT_COORD = 0X435BB0;
            public static uint REQUEST_COLLISION_FOR_MODEL = 0X435C10;
            public static uint REQUEST_CUTSCENE = 0X3B64BC;
            public static uint REQUEST_IPL = 0X4360C0;
            public static uint REQUEST_MISSION_AUDIO_BANK = 0X39D448;
            public static uint REQUEST_MODEL = 0X4357D4;
            public static uint REQUEST_PTFX_ASSET = 0X436650;
            public static uint REQUEST_SCALEFORM_MOVIE = 0X3C43E4;
            public static uint REQUEST_SCRIPT = 0X439498;
            public static uint REQUEST_SCRIPT_AUDIO_BANK = 0X39D480;
            public static uint REQUEST_STEALTH_MODE_ASSET = 0X41C4A8;
            public static uint REQUEST_STREAMED_TEXTURE_DICT = 0X3BF368;
            public static uint REQUEST_VEHICLE_ASSET = 0X454ECC;
            public static uint REQUEST_VEHICLE_HIGH_DETAIL_MODEL = 0X45B670;
            public static uint REQUEST_VEHICLE_RECORDING = 0X455100;
            public static uint REQUEST_WAYPOINT_RECORDING = 0X44CF10;
            public static uint REQUEST_WEAPON_ASSET = 0X46988C;
            public static uint RESERVE_NETWORK_MISSION_OBJECTS = 0X3ECD3C;
            public static uint RESERVE_NETWORK_MISSION_PEDS = 0X3ECDE4;
            public static uint RESERVE_NETWORK_MISSION_VEHICLES = 0X3ECE8C;
            public static uint RESET_AI_WEAPON_DAMAGE_MODIFIER = 0X40A4D0;
            public static uint RESET_DISPATCH_IDEAL_SPAWN_DISTANCE = 0X3D8E70;
            public static uint RESET_DISPATCH_SPAWN_BLOCKING_AREAS = 0X3D91F4;
            public static uint RESET_DISPATCH_TIME_BETWEEN_SPAWN_ATTEMPTS = 0X3D8ED0;
            public static uint RESET_ENTITY_ALPHA = 0X3B4A38;
            public static uint RESET_EXCLUSIVE_SCENARIO_GROUP = 0X447F70;
            public static uint RESET_HUD_COMPONENT_VALUES = 0X3CC7B8;
            public static uint RESET_PED_AUDIO_FLAGS = 0X3A0D18;
            public static uint RESET_PED_IN_VEHICLE_CONTEXT = 0X406F00;
            public static uint RESET_PED_LAST_VEHICLE = 0X408F44;
            public static uint RESET_PED_MOVEMENT_CLIPSET = 0X406768;
            public static uint RESET_PED_RAGDOLL_TIMER = 0X413708;
            public static uint RESET_PED_STRAFE_CLIPSET = 0X4068D8;
            public static uint RESET_PED_VISIBLE_DAMAGE = 0X414984;
            public static uint RESET_PED_WEAPON_MOVEMENT_CLIPSET = 0X406A2C;
            public static uint RESET_PLAYER_INPUT_GAIT = 0X4263C4;
            public static uint RESET_PLAYER_STAMINA = 0X423B98;
            public static uint RESET_RETICULE_VALUES = 0X3CC758;
            public static uint RESET_SPECIAL_ABILITY_CONTROLS_CINEMATIC = 0X42558C;
            public static uint RESET_TREVOR_RAGE = 0X39DE48;
            public static uint RESET_VEHICLE_STUCK_TIMER = 0X45A1D4;
            public static uint RESET_VEHICLE_WHEELS = 0X45AC9C;
            public static uint RESET_WANTED_LEVEL_DIFFICULTY = 0X422F18;
            public static uint RESPONDING_AS_TEMP = 0X3CA938;
            public static uint RESTART_FRONTEND_MENU = 0X3CD4A8;
            public static uint RESTART_SCRIPTED_CONVERSATION = 0X39CF78;
            public static uint RESTORE_PLAYER_STAMINA = 0X423BD8;
            public static uint RESURRECT_PED = 0X4142D8;
            public static uint REVIVE_INJURED_PED = 0X414230;
            public static uint ROLL_DOWN_WINDOW = 0X45ADE0;
            public static uint ROLL_DOWN_WINDOWS = 0X45AD2C;
            public static uint ROLL_UP_WINDOW = 0X45AE60;
            public static uint ROPE_FORCE_LENGTH = 0X420838;
            public static uint ROPE_LOAD_TEXTURES = 0X41FDD8;
            public static uint ROPE_RESET_LENGTH = 0X420884;
            public static uint ROPE_UNLOAD_TEXTURES = 0X41FE38;
            public static uint ROUND = 0X9B8A18;
            public static uint SC_INBOX_MESSAGE_GET_DATA_FLOAT = 0X429F60;
            public static uint SC_INBOX_MESSAGE_GET_DATA_INT = 0X429F2C;
            public static uint SC_INBOX_MESSAGE_GET_DATA_STRING = 0X429F94;
            public static uint SC_INBOX_MESSAGE_GET_UGCDATA = 0X42A188;
            public static uint SCRIPT_IS_MOVING_MOBILE_PHONE_OFFSCREEN = 0X439138;
            public static uint SEETHROUGH_RESET = 0X3BF5D8;
            public static uint SET_ABILITY_BAR_VALUE = 0X3CBB98;
            public static uint SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN = 0X3F88D8;
            public static uint SET_AGGRESSIVE_HORNS = 0X39F8C4;
            public static uint SET_AI_WEAPON_DAMAGE_MODIFIER = 0X40A4C4;
            public static uint SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE = 0X424C88;
            public static uint SET_ALL_LOW_PRIORITY_VEHICLE_GENERATORS_ACTIVE = 0X44ECE0;
            public static uint SET_ALL_RANDOM_PEDS_FLEE = 0X422C5C;
            public static uint SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME = 0X422CCC;
            public static uint SET_ALL_VEHICLE_GENERATORS_ACTIVE = 0X44ECC0;
            public static uint SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA = 0X44EBA4;
            public static uint SET_ALL_VEHICLES_SPAWN = 0X44ED6C;
            public static uint SET_AMBIENT_VOICE_NAME = 0X39E078;
            public static uint SET_AMBIENT_ZONE_LIST_STATE = 0X39F484;
            public static uint SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT = 0X39F594;
            public static uint SET_AMBIENT_ZONE_STATE = 0X39F3C0;
            public static uint SET_AMBIENT_ZONE_STATE_PERSISTENT = 0X39F440;
            public static uint SET_AMMO_IN_CLIP = 0X468B40;
            public static uint SET_ANIM_LOOPED = 0X43E560;
            public static uint SET_ANIM_RATE = 0X43E48C;
            public static uint SET_ANIM_WEIGHT = 0X43E078;
            public static uint SET_ANIMAL_MOOD = 0X39E5A0;
            public static uint SET_AUDIO_FLAG = 0X39EF90;
            public static uint SET_AUDIO_SCENE_VARIABLE = 0X3A071C;
            public static uint SET_AUDIO_VEHICLE_PRIORITY = 0X39FDA4;
            public static uint SET_BALANCE_ADD_MACHINE = 0X3F25B4;
            public static uint SET_BALANCE_ADD_MACHINES = 0X3F261C;
            public static uint SET_BIT = 0X3D67EC;
            public static uint SET_BITS_IN_RANGE = 0X3D75C8;
            public static uint SET_BLIP_ALPHA = 0X3CAD80;
            public static uint SET_BLIP_AS_FRIENDLY = 0X3CB544;
            public static uint SET_BLIP_AS_MISSION_CREATOR_BLIP = 0X3CB0DC;
            public static uint SET_BLIP_AS_SHORT_RANGE = 0X3CB310;
            public static uint SET_BLIP_BRIGHT = 0X3CB868;
            public static uint SET_BLIP_CATEGORY = 0X3CB41C;
            public static uint SET_BLIP_COLOUR = 0X3CAC78;
            public static uint SET_BLIP_COORDS = 0X3CA830;
            public static uint SET_BLIP_DISPLAY = 0X3CB3E8;
            public static uint SET_BLIP_FADE = 0X3CAE00;
            public static uint SET_BLIP_FLASH_INTERVAL = 0X3CAECC;
            public static uint SET_BLIP_FLASH_TIMER = 0X3CAE98;
            public static uint SET_BLIP_FLASHES = 0X3CB258;
            public static uint SET_BLIP_FLASHES_ALTERNATE = 0X3CB2D8;
            public static uint SET_BLIP_HIGH_DETAIL = 0X3CB0A4;
            public static uint SET_BLIP_NAME_FROM_TEXT_FILE = 0X3CABC8;
            public static uint SET_BLIP_NAME_TO_PLAYER_NAME = 0X3CAC28;
            public static uint SET_BLIP_PRIORITY = 0X3CB450;
            public static uint SET_BLIP_ROTATION = 0X3CAE5C;
            public static uint SET_BLIP_ROUTE = 0X3CB348;
            public static uint SET_BLIP_ROUTE_COLOUR = 0X3CB380;
            public static uint SET_BLIP_SCALE = 0X3CB3B4;
            public static uint SET_BLIP_SECONDARY_COLOUR = 0X3CACAC;
            public static uint SET_BLIP_SHOW_CONE = 0X3CB89C;
            public static uint SET_BLIP_SPRITE = 0X3CB484;
            public static uint SET_BLOCKING_OF_NON_TEMPORARY_EVENTS = 0X412078;
            public static uint SET_BOAT_ANCHOR = 0X45087C;
            public static uint SET_CAM_ACTIVE = 0X3A32CC;
            public static uint SET_CAM_ACTIVE_WITH_INTERP = 0X3A56A4;
            public static uint SET_CAM_ANIM_CURRENT_PHASE = 0X3A60B0;
            public static uint SET_CAM_COORD = 0X3A38D0;
            public static uint SET_CAM_DEBUG_NAME = 0X10FA0;
            public static uint SET_CAM_DOF_PLANES = 0X3A3FBC;
            public static uint SET_CAM_DOF_STRENGTH = 0X3A3F18;
            public static uint SET_CAM_FAR_CLIP = 0X3A3D78;
            public static uint SET_CAM_FAR_DOF = 0X3A3E90;
            public static uint SET_CAM_FOV = 0X3A3C38;
            public static uint SET_CAM_INHERIT_ROLL_VEHICLE = 0X3A4478;
            public static uint SET_CAM_MOTION_BLUR_STRENGTH = 0X3A4110;
            public static uint SET_CAM_NEAR_CLIP = 0X3A3D0C;
            public static uint SET_CAM_NEAR_DOF = 0X3A3E14;
            public static uint SET_CAM_PARAMS = 0X3A3780;
            public static uint SET_CAM_ROT = 0X3A39D8;
            public static uint SET_CAM_SHAKE_AMPLITUDE = 0X3A5BF4;
            public static uint SET_CAM_SPLINE_DURATION = 0X3A508C;
            public static uint SET_CAM_SPLINE_PHASE = 0X3A4E04;
            public static uint SET_CAMERA_CAMERA_FORWARD = 0X3C3578;
            public static uint SET_CAMERA_ENDTIME = 0X3C2B2C;
            public static uint SET_CAN_ATTACK_FRIENDLY = 0X4082BC;
            public static uint SET_CAN_RESPRAY_VEHICLE = 0X4506B8;
            public static uint SET_CHECKPOINT_CYLINDER_HEIGHT = 0X3BF0F8;
            public static uint SET_CHECKPOINT_RGBA = 0X3BF168;
            public static uint SET_CINEMATIC_BUTTON_ACTIVE = 0X3A70AC;
            public static uint SET_CINEMATIC_CAM_SHAKE_AMPLITUDE = 0X3A7168;
            public static uint SET_CINEMATIC_MODE_ACTIVE = 0X3A75E4;
            public static uint SET_CLOCK_DATE = 0X3A93F0;
            public static uint SET_CLOCK_TIME = 0X3A92E0;
            public static uint SET_COMBAT_FLOAT = 0X40E5F8;
            public static uint SET_CONTROL_SHAKE = 0X400B30;
            public static uint SET_CONVERTIBLE_ROOF = 0X4598F8;
            public static uint SET_CREATE_RANDOM_COPS = 0X410070;
            public static uint SET_CREDITS_ACTIVE = 0X3D5E28;
            public static uint SET_CURRENT_PED_VEHICLE_WEAPON = 0X467360;
            public static uint SET_CURRENT_PED_WEAPON = 0X4670AC;
            public static uint SET_CUTSCENE_AUDIO_OVERRIDE = 0X39F6F4;
            public static uint SET_CUTSCENE_ENTITY_MODEL = 0X3B79CC;
            public static uint SET_CUTSCENE_FADE_VALUES = 0X3B7550;
            public static uint SET_CUTSCENE_ORIGIN = 0X3B6328;
            public static uint SET_CUTSCENE_PED_COMPONENT_VARIATION = 0X3B77CC;
            public static uint SET_CUTSCENE_TRIGGER_AREA = 0X3B73F0;
            public static uint SET_DAMPING = 0X420BB0;
            public static uint SET_DANCE_MAPPERS = 0X3CD1D8;
            public static uint SET_DEBUG_LINES_AND_SPHERES_DRAWING_ACTIVE = 0X10FA0;
            public static uint SET_DECISION_MAKER = 0X3BBFB4;
            public static uint SET_DISABLE_BREAKING = 0X421120;
            public static uint SET_DISPATCH_COPS_FOR_PLAYER = 0X4222D8;
            public static uint SET_DISPATCH_IDEAL_SPAWN_DISTANCE = 0X3D8EA0;
            public static uint SET_DISPATCH_TIME_BETWEEN_SPAWN_ATTEMPTS = 0X3D8F30;
            public static uint SET_DISPATCH_TIME_BETWEEN_SPAWN_ATTEMPTS_MULTIPLIER = 0X3D8FEC;
            public static uint SET_DITCH_POLICE_MODELS = 0X10FA0;
            public static uint SET_DRAW_ORIGIN = 0X3C14AC;
            public static uint SET_DRIVE_TASK_CRUISE_SPEED = 0X4471D0;
            public static uint SET_DRIVE_TASK_MAX_CRUISE_SPEED = 0X4472F8;
            public static uint SET_DRIVEBY_TASK_TARGET = 0X4444F4;
            public static uint SET_DRIVER_ABILITY = 0X412D60;
            public static uint SET_DRIVER_AGGRESSIVENESS = 0X412E00;
            public static uint SET_EMITTER_RADIO_STATION = 0X39EE50;
            public static uint SET_ENABLE_BOUND_ANKLES = 0X4081BC;
            public static uint SET_ENABLE_HANDCUFFS = 0X408128;
            public static uint SET_ENABLE_PED_ENVEFF_SCALE = 0X41A31C;
            public static uint SET_ENTITY_ALPHA = 0X3B4888;
            public static uint SET_ENTITY_ANIM_CURRENT_TIME = 0X3B1F70;
            public static uint SET_ENTITY_ANIM_SPEED = 0X3B2178;
            public static uint SET_ENTITY_AS_MISSION_ENTITY = 0X3B2350;
            public static uint SET_ENTITY_AS_NO_LONGER_NEEDED = 0X3B2788;
            public static uint SET_ENTITY_CAN_BE_DAMAGED = 0X3B2888;
            public static uint SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP = 0X3B297C;
            public static uint SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS = 0X3B2A18;
            public static uint SET_ENTITY_COLLISION = 0X3B2D54;
            public static uint SET_ENTITY_COORDS = 0X3B3160;
            public static uint SET_ENTITY_COORDS_NO_OFFSET = 0X3B31D8;
            public static uint SET_ENTITY_DYNAMIC = 0X3B33A4;
            public static uint SET_ENTITY_HAS_GRAVITY = 0X3B4460;
            public static uint SET_ENTITY_HEADING = 0X3B3478;
            public static uint SET_ENTITY_HEALTH = 0X3B36F0;
            public static uint SET_ENTITY_ICON_COLOR = 0X3C1228;
            public static uint SET_ENTITY_ICON_ID_COLOR = 0X3C1434;
            public static uint SET_ENTITY_ICON_ID_VISIBILITY = 0X3C138C;
            public static uint SET_ENTITY_ICON_VISIBILITY = 0X3C11A8;
            public static uint SET_ENTITY_INVINCIBLE = 0X3B3934;
            public static uint SET_ENTITY_IS_TARGET_PRIORITY = 0X3B3A04;
            public static uint SET_ENTITY_LIGHTS = 0X3B3B1C;
            public static uint SET_ENTITY_LOAD_COLLISION_FLAG = 0X3B3B9C;
            public static uint SET_ENTITY_LOCALLY_INVISIBLE = 0X3ECA1C;
            public static uint SET_ENTITY_LOCALLY_VISIBLE = 0X3ECA90;
            public static uint SET_ENTITY_LOD_DIST = 0X3B44D4;
            public static uint SET_ENTITY_MAX_HEALTH = 0X3ABAD0;
            public static uint SET_ENTITY_MAX_SPEED = 0X3B3CC8;
            public static uint SET_ENTITY_MOTION_BLUR = 0X3B4374;
            public static uint SET_ENTITY_NO_COLLISION_ENTITY = 0X3B5038;
            public static uint SET_ENTITY_ONLY_DAMAGED_BY_PLAYER = 0X3B3D50;
            public static uint SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP = 0X3B3DB0;
            public static uint SET_ENTITY_PROOFS = 0X3B3E5C;
            public static uint SET_ENTITY_QUATERNION = 0X3B3F00;
            public static uint SET_ENTITY_RECORDS_COLLISIONS = 0X3B4074;
            public static uint SET_ENTITY_RENDER_SCORCHED = 0X3B4B14;
            public static uint SET_ENTITY_ROTATION = 0X3B40CC;
            public static uint SET_ENTITY_VELOCITY = 0X3B43DC;
            public static uint SET_ENTITY_VISIBLE = 0X3B4280;
            public static uint SET_ENTITY_VISIBLE_IN_CUTSCENE = 0X3EC950;
            public static uint SET_EVERYONE_IGNORE_PLAYER = 0X422BD8;
            public static uint SET_EXCLUSIVE_PHONE_RELATIONSHIPS = 0X40EC18;
            public static uint SET_EXCLUSIVE_SCENARIO_GROUP = 0X447F2C;
            public static uint SET_EXPLOSIVE_AMMO_THIS_FRAME = 0X3D973C;
            public static uint SET_EXPLOSIVE_MELEE_THIS_FRAME = 0X3D97B4;
            public static uint SET_FACIAL_IDLE_ANIM_OVERRIDE = 0X416B08;
            public static uint SET_FADE_IN_AFTER_DEATH_ARREST = 0X3D35F0;
            public static uint SET_FADE_IN_AFTER_LOAD = 0X3D3608;
            public static uint SET_FAKE_WANTED_LEVEL = 0X3D4560;
            public static uint SET_FAR_DRAW_VEHICLES = 0X44F4A0;
            public static uint SET_FIRE_AMMO_THIS_FRAME = 0X3D9778;
            public static uint SET_FLASH = 0X3BFA28;
            public static uint SET_FOCUS_ENTITY = 0X436D90;
            public static uint SET_FOLLOW_PED_CAM_CUTSCENE_CHAT = 0X3A6910;
            public static uint SET_FOLLOW_PED_CAM_VIEW_MODE = 0X3A69A0;
            public static uint SET_FOLLOW_VEHICLE_CAM_VIEW_MODE = 0X3A6AB0;
            public static uint SET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL = 0X3A6A64;
            public static uint SET_FORCE_OBJECT_THIS_FRAME = 0X3FF830;
            public static uint SET_FRONTEND_ACTIVE = 0X3CD584;
            public static uint SET_FRONTEND_RADIO_ACTIVE = 0X39E91C;
            public static uint SET_GAME_PAUSED = 0X3D7A24;
            public static uint SET_GAME_PAUSES_FOR_STREAMING = 0X4365C8;
            public static uint SET_GAMEPLAY_CAM_RELATIVE_HEADING = 0X3A6760;
            public static uint SET_GAMEPLAY_CAM_RELATIVE_PITCH = 0X3A6848;
            public static uint SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE = 0X3A6F4C;
            public static uint SET_GAMEPLAY_COORD_HINT = 0X3A78D0;
            public static uint SET_GAMEPLAY_ENTITY_HINT = 0X3A792C;
            public static uint SET_GAMEPLAY_HINT_FOV = 0X3A77B0;
            public static uint SET_GAMEPLAY_PED_HINT = 0X3A7FA0;
            public static uint SET_GAMEPLAY_VEHICLE_HINT = 0X3A803C;
            public static uint SET_GARBAGE_TRUCKS = 0X4539EC;
            public static uint SET_GPS_ACTIVE = 0X3A0420;
            public static uint SET_GPS_DISABLED_ZONE = 0X403C9C;
            public static uint SET_GPS_FLAGS = 0X3CBEC8;
            public static uint SET_GPS_FLASHES = 0X3CBEA4;
            public static uint SET_GRAVITY_LEVEL = 0X3D7B3C;
            public static uint SET_GROUP_FORMATION = 0X40EA28;
            public static uint SET_GROUP_FORMATION_SPACING = 0X40EABC;
            public static uint SET_GROUP_SEPARATION_RANGE = 0X40C578;
            public static uint SET_HD_AREA = 0X4380B0;
            public static uint SET_HELI_BLADES_FULL_SPEED = 0X4563A0;
            public static uint SET_HELI_BLADES_SPEED = 0X456490;
            public static uint SET_HIGH_FALL_TASK = 0X4499C8;
            public static uint SET_HORN_ENABLED = 0X39FE0C;
            public static uint SET_HUD_COMPONENT_POSITION = 0X3CC78C;
            public static uint SET_IGNORE_LOW_PRIORITY_SHOCKING_EVENTS = 0X422E0C;
            public static uint SET_IGNORE_NO_GPS_FLAG = 0X403B9C;
            public static uint SET_IK_TARGET = 0X41C07C;
            public static uint SET_INITIAL_PLAYER_STATION = 0X39EAE0;
            public static uint SET_INPUT_EXCLUSIVE = 0X400C98;
            public static uint SET_INTERIOR_ACTIVE = 0X435B1C;
            public static uint SET_LOCAL_PLAYER_INVISIBLE_LOCALLY = 0X3EC624;
            public static uint SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE = 0X3EC5BC;
            public static uint SET_LOCAL_PLAYER_VISIBLE_LOCALLY = 0X3EC6D4;
            public static uint SET_MAX_WANTED_LEVEL = 0X422ACC;
            public static uint SET_MICROPHONE_POSITION = 0X39CD94;
            public static uint SET_MINIGAME_IN_PROGRESS = 0X3D6AB8;
            public static uint SET_MINIMAP_BLOCK_WAYPOINT = 0X3CC204;
            public static uint SET_MINIMAP_COMPONENT = 0X3CB8D4;
            public static uint SET_MISSION_FLAG = 0X3D3B38;
            public static uint SET_MISSION_NAME = 0X3CC4D4;
            public static uint SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED = 0X454E24;
            public static uint SET_MISSION_TRAIN_COORDS = 0X455210;
            public static uint SET_MOBILE_PHONE_POSITION = 0X4390F4;
            public static uint SET_MOBILE_PHONE_RADIO_STATE = 0X39E654;
            public static uint SET_MOBILE_PHONE_ROTATION = 0X438FF0;
            public static uint SET_MOBILE_PHONE_SCALE = 0X438FD8;
            public static uint SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY = 0X39EEBC;
            public static uint SET_MODEL_AS_NO_LONGER_NEEDED = 0X435B48;
            public static uint SET_MULTIPLAYER_BANK_CASH = 0X3CBD70;
            public static uint SET_MULTIPLAYER_HUD_CASH = 0X10FA0;
            public static uint SET_NETWORK_ID_CAN_MIGRATE = 0X3EC06C;
            public static uint SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES = 0X3EC144;
            public static uint SET_NETWORK_ID_VISIBLE_IN_CUTSCENE = 0X3EC394;
            public static uint SET_NETWORK_VEHICLE_RESPOT_TIMER = 0X3ED9DC;
            public static uint SET_NEW_WAYPOINT = 0X3CBA04;
            public static uint SET_NEXT_DESIRED_MOVE_STATE = 0X10FA0;
            public static uint SET_NIGHTVISION = 0X3BF544;
            public static uint SET_NO_LOADING_SCREEN = 0X4286C0;
            public static uint SET_NOISEOVERIDE = 0X3BF730;
            public static uint SET_NOISINESSOVERIDE = 0X3BF73C;
            public static uint SET_NUMBER_OF_PARKED_VEHICLES = 0X44F4CC;
            public static uint SET_OBJECT_AS_NO_LONGER_NEEDED = 0X3B2788;
            public static uint SET_OBJECT_PHYSICS_PARAMS = 0X3FDA68;
            public static uint SET_OBJECT_TARGETTABLE = 0X3FB4CC;
            public static uint SET_OVERRIDE_WEATHER = 0X3D4130;
            public static uint SET_PAD_SHAKE = 0X400998;
            public static uint SET_PARACHUTE_TASK_TARGET = 0X449000;
            public static uint SET_PARACHUTE_TASK_THRUST = 0X4490B4;
            public static uint SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME = 0X44F444;
            public static uint SET_PARTICLE_FX_BLOOD_SCALE = 0X3C2AE0;
            public static uint SET_PARTICLE_FX_CAM_INSIDE_VEHICLE = 0X3C2958;
            public static uint SET_PARTICLE_FX_LOOPED_ALPHA = 0X3C2840;
            public static uint SET_PARTICLE_FX_LOOPED_COLOUR = 0X3C277C;
            public static uint SET_PARTICLE_FX_LOOPED_EVOLUTION = 0X3C28A0;
            public static uint SET_PARTICLE_FX_LOOPED_OFFSETS = 0X3C26D0;
            public static uint SET_PARTICLE_FX_LOOPED_SCALE = 0X3C2860;
            public static uint SET_PARTICLE_FX_NON_LOOPED_ALPHA = 0X3C1D04;
            public static uint SET_PAUSE_MENU_ACTIVE = 0X3CD56C;
            public static uint SET_PED_ACCURACY = 0X407A58;
            public static uint SET_PED_ALERTNESS = 0X4083B4;
            public static uint SET_PED_ALLOWED_TO_DUCK = 0X40F0C4;
            public static uint SET_PED_ALTERNATE_MOVEMENT_ANIM = 0X407388;
            public static uint SET_PED_AMMO = 0X466D40;
            public static uint SET_PED_AMMO_BY_TYPE = 0X468D48;
            public static uint SET_PED_AMMO_TO_DROP = 0X468E34;
            public static uint SET_PED_ANGLED_DEFENSIVE_AREA = 0X413974;
            public static uint SET_PED_ARMOUR = 0X408018;
            public static uint SET_PED_AS_COP = 0X40F248;
            public static uint SET_PED_AS_ENEMY = 0X41010C;
            public static uint SET_PED_AS_GROUP_LEADER = 0X40BEBC;
            public static uint SET_PED_AS_GROUP_MEMBER = 0X40BF9C;
            public static uint SET_PED_AS_NO_LONGER_NEEDED = 0X3B2788;
            public static uint SET_PED_BLEND_FROM_PARENTS = 0X410EE8;
            public static uint SET_PED_BOUNDS_ORIENTATION = 0X411FC0;
            public static uint SET_PED_CAN_BE_DRAGGED_OUT = 0X408C18;
            public static uint SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE = 0X40F6D0;
            public static uint SET_PED_CAN_BE_SHOT_IN_VEHICLE = 0X40A3C4;
            public static uint SET_PED_CAN_BE_TARGETED_WHEN_INJURED = 0X417FB0;
            public static uint SET_PED_CAN_BE_TARGETED_WITHOUT_LOS = 0X40E374;
            public static uint SET_PED_CAN_BE_TARGETTED = 0X40A5E4;
            public static uint SET_PED_CAN_BE_TARGETTED_BY_PLAYER = 0X40A6DC;
            public static uint SET_PED_CAN_BE_TARGETTED_BY_TEAM = 0X40A65C;
            public static uint SET_PED_CAN_COWER_IN_COVER = 0X418894;
            public static uint SET_PED_CAN_EVASIVE_DIVE = 0X417704;
            public static uint SET_PED_CAN_HEAD_IK = 0X416DB0;
            public static uint SET_PED_CAN_LEG_IK = 0X416E28;
            public static uint SET_PED_CAN_PEEK_IN_COVER = 0X41890C;
            public static uint SET_PED_CAN_PLAY_AMBIENT_ANIMS = 0X4168E0;
            public static uint SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS = 0X416958;
            public static uint SET_PED_CAN_PLAY_GESTURE_ANIMS = 0X416760;
            public static uint SET_PED_CAN_PLAY_VISEME_ANIMS = 0X4167CC;
            public static uint SET_PED_CAN_RAGDOLL = 0X413784;
            public static uint SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT = 0X418020;
            public static uint SET_PED_CAN_SMASH_GLASS = 0X410178;
            public static uint SET_PED_CAN_SWITCH_WEAPON = 0X418A78;
            public static uint SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT = 0X417008;
            public static uint SET_PED_CAPSULE = 0X41B968;
            public static uint SET_PED_COMBAT_ABILITY = 0X418D3C;
            public static uint SET_PED_COMBAT_ATTRIBUTES = 0X418E64;
            public static uint SET_PED_COMBAT_MOVEMENT = 0X418C70;
            public static uint SET_PED_COMBAT_RANGE = 0X418D98;
            public static uint SET_PED_COMPONENT_VARIATION = 0X410C4C;
            public static uint SET_PED_CONFIG_FLAG = 0X4173CC;
            public static uint SET_PED_COORDS_KEEP_VEHICLE = 0X40FF64;
            public static uint SET_PED_COORDS_NO_GANG = 0X40FC00;
            public static uint SET_PED_COWER_HASH = 0X418FF8;
            public static uint SET_PED_CURRENT_WEAPON_VISIBLE = 0X467CF4;
            public static uint SET_PED_DEFAULT_COMPONENT_VARIATION = 0X410E5C;
            public static uint SET_PED_DEFENSIVE_AREA_ATTACHED_TO_PED = 0X413D9C;
            public static uint SET_PED_DENSITY_MULTIPLIER_THIS_FRAME = 0X408FC4;
            public static uint SET_PED_DESIRED_HEADING = 0X405E10;
            public static uint SET_PED_DESIRED_MOVE_BLEND_RATIO = 0X4456F8;
            public static uint SET_PED_DIES_IN_SINKING_VEHICLE = 0X40A174;
            public static uint SET_PED_DIES_IN_VEHICLE = 0X40FFF0;
            public static uint SET_PED_DIES_IN_WATER = 0X40A09C;
            public static uint SET_PED_DIES_INSTANTLY_IN_WATER = 0X40A108;
            public static uint SET_PED_DIES_WHEN_INJURED = 0X40A1E0;
            public static uint SET_PED_DROPS_INVENTORY_WEAPON = 0X468288;
            public static uint SET_PED_DROPS_WEAPON = 0X4680EC;
            public static uint SET_PED_DROPS_WEAPONS_WHEN_DEAD = 0X467E0C;
            public static uint SET_PED_DUCKING = 0X40B168;
            public static uint SET_PED_ENABLE_WEAPON_BLOCKING = 0X40A26C;
            public static uint SET_PED_ENABLED_BIKE_RINGTONE = 0X455584;
            public static uint SET_PED_ENVEFF_SCALE = 0X41A180;
            public static uint SET_PED_FIRING_PATTERN = 0X40E3E4;
            public static uint SET_PED_FLEE_ATTRIBUTES = 0X418F70;
            public static uint SET_PED_GADGET = 0X468FDC;
            public static uint SET_PED_GENERATES_DEAD_BODY_EVENTS = 0X417818;
            public static uint SET_PED_GESTURE_GROUP = 0X40759C;
            public static uint SET_PED_GET_OUT_UPSIDE_DOWN_VEHICLE = 0X410468;
            public static uint SET_PED_GRAVITY = 0X40EDAC;
            public static uint SET_PED_GROUP_MEMBER_PASSENGER_INDEX = 0X417698;
            public static uint SET_PED_HEAD_BLEND_DATA = 0X411250;
            public static uint SET_PED_HEAD_OVERLAY = 0X411480;
            public static uint SET_PED_HEARING_RANGE = 0X40B36C;
            public static uint SET_PED_HELMET = 0X41852C;
            public static uint SET_PED_HELMET_FLAG = 0X418098;
            public static uint SET_PED_HELMET_PROP_INDEX = 0X418100;
            public static uint SET_PED_HELMET_TEXTURE_INDEX = 0X418180;
            public static uint SET_PED_ID_RANGE = 0X40B3D8;
            public static uint SET_PED_IN_VEHICLE_CONTEXT = 0X406E7C;
            public static uint SET_PED_INFINITE_AMMO = 0X466F38;
            public static uint SET_PED_INTO_VEHICLE = 0X40940C;
            public static uint SET_PED_IS_DRUNK = 0X39E440;
            public static uint SET_PED_KEEP_TASK = 0X40FD98;
            public static uint SET_PED_LEG_IK_MODE = 0X41898C;
            public static uint SET_PED_LOD_MULTIPLIER = 0X41C538;
            public static uint SET_PED_MAX_HEALTH = 0X40F2D8;
            public static uint SET_PED_MAX_MOVE_BLEND_RATIO = 0X41B258;
            public static uint SET_PED_MAX_TIME_IN_WATER = 0X40F3F8;
            public static uint SET_PED_MAX_TIME_UNDERWATER = 0X40F4A0;
            public static uint SET_PED_MIN_MOVE_BLEND_RATIO = 0X41B2C0;
            public static uint SET_PED_MODEL_IS_SUPPRESSED = 0X417E70;
            public static uint SET_PED_MONEY = 0X4090F8;
            public static uint SET_PED_MOTION_BLUR = 0X4189FC;
            public static uint SET_PED_MOVE_ANIMS_BLEND_OUT = 0X408BA0;
            public static uint SET_PED_MOVE_RATE_OVERRIDE = 0X41B350;
            public static uint SET_PED_MOVEMENT_CLIPSET = 0X406668;
            public static uint SET_PED_NAME_DEBUG = 0X10FA0;
            public static uint SET_PED_NEVER_LEAVES_GROUP = 0X40F160;
            public static uint SET_PED_NON_CREATION_AREA = 0X409060;
            public static uint SET_PED_PARACHUTE_TINT_INDEX = 0X40AEF4;
            public static uint SET_PED_PATH_AVOID_FIRE = 0X43CA84;
            public static uint SET_PED_PATH_CAN_DROP_FROM_HEIGHT = 0X43C84C;
            public static uint SET_PED_PATH_CAN_USE_CLIMBOVERS = 0X43C744;
            public static uint SET_PED_PATH_CAN_USE_LADDERS = 0X43C7C8;
            public static uint SET_PED_PATH_PREFER_TO_AVOID_WATER = 0X43CA00;
            public static uint SET_PED_PATHS_BACK_TO_ORIGINAL = 0X402F6C;
            public static uint SET_PED_PATHS_IN_AREA = 0X401A68;
            public static uint SET_PED_PATHS_WIDTH_PLANT = 0X43C97C;
            public static uint SET_PED_PINNED_DOWN = 0X40D6A0;
            public static uint SET_PED_PLAYS_HEAD_ON_HORN_ANIM_WHEN_DIES_IN_VEHICLE = 0X10FA0;
            public static uint SET_PED_POPULATION_BUDGET = 0X436C94;
            public static uint SET_PED_PRIMARY_LOOKAT = 0X417238;
            public static uint SET_PED_PROP_INDEX = 0X411B7C;
            public static uint SET_PED_RAGDOLL_FORCE_FALL = 0X4134E4;
            public static uint SET_PED_RAGDOLL_ON_COLLISION = 0X413250;
            public static uint SET_PED_RANDOM_COMPONENT_VARIATION = 0X410CFC;
            public static uint SET_PED_RANDOM_PROPS = 0X410DA8;
            public static uint SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH = 0X40DED8;
            public static uint SET_PED_RELATIONSHIP_GROUP_HASH = 0X40DF48;
            public static uint SET_PED_RESET_FLAG = 0X4174B4;
            public static uint SET_PED_SEEING_RANGE = 0X40B300;
            public static uint SET_PED_SHOOT_RATE = 0X40E508;
            public static uint SET_PED_SHOOTS_AT_COORD = 0X417A60;
            public static uint SET_PED_SPHERE_DEFENSIVE_AREA = 0X413A74;
            public static uint SET_PED_STAY_IN_VEHICLE_WHEN_JACKED = 0X40A354;
            public static uint SET_PED_STEALTH_MOVEMENT = 0X40B8A8;
            public static uint SET_PED_STEERS_AROUND_OBJECTS = 0X4195AC;
            public static uint SET_PED_STEERS_AROUND_PEDS = 0X419540;
            public static uint SET_PED_STEERS_AROUND_VEHICLES = 0X419618;
            public static uint SET_PED_STRAFE_CLIPSET = 0X4067F0;
            public static uint SET_PED_SUFFERS_CRITICAL_HITS = 0X409680;
            public static uint SET_PED_SWEAT = 0X415520;
            public static uint SET_PED_TARGET_LOSS_RESPONSE = 0X418F14;
            public static uint SET_PED_TARGETTABLE_VEHICLE_DESTROY = 0X44F538;
            public static uint SET_PED_TO_INFORM_RESPECTED_FRIENDS = 0X40E068;
            public static uint SET_PED_TO_LOAD_COVER = 0X418824;
            public static uint SET_PED_TO_RAGDOLL = 0X412F38;
            public static uint SET_PED_TO_RAGDOLL_WITH_FALL = 0X4130F0;
            public static uint SET_PED_USING_ACTION_MODE = 0X41B7A8;
            public static uint SET_PED_VISUAL_FIELD_MAX_ANGLE = 0X40B50C;
            public static uint SET_PED_VISUAL_FIELD_MAX_ELEVATION_ANGLE = 0X40B5E4;
            public static uint SET_PED_VISUAL_FIELD_MIN_ANGLE = 0X40B4A0;
            public static uint SET_PED_VISUAL_FIELD_MIN_ELEVATION_ANGLE = 0X40B578;
            public static uint SET_PED_WAYPOINT_ROUTE_OFFSET = 0X44D500;
            public static uint SET_PED_WEAPON_MOVEMENT_CLIPSET = 0X406944;
            public static uint SET_PED_WEAPON_TINT_INDEX = 0X46A128;
            public static uint SET_PED_WETNESS_ENABLED_THIS_FRAME = 0X41546C;
            public static uint SET_PED_WETNESS_HEIGHT = 0X4153E8;
            public static uint SET_PEDHEADSHOT_CUSTOM_LIGHT = 0X41BBB4;
            public static uint SET_PEDHEADSHOT_CUSTOM_LIGHTING = 0X41BB80;
            public static uint SET_PICKUP_REGENERATION_TIME = 0X3FEA60;
            public static uint SET_PLAYBACK_SPEED = 0X453A9C;
            public static uint SET_PLAYBACK_TO_USE_AI = 0X4581CC;
            public static uint SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER = 0X458234;
            public static uint SET_PLAYER_ANGRY = 0X39DE6C;
            public static uint SET_PLAYER_CAN_BE_HASSLED_BY_GANGS = 0X423A7C;
            public static uint SET_PLAYER_CAN_DO_DRIVE_BY = 0X423A40;
            public static uint SET_PLAYER_CAN_USE_COVER = 0X423AB8;
            public static uint SET_PLAYER_CONTROL = 0X4229B8;
            public static uint SET_PLAYER_FORCED_AIM = 0X424EDC;
            public static uint SET_PLAYER_FORCED_ZOOM = 0X424F20;
            public static uint SET_PLAYER_INVERTED_UP = 0X437BDC;
            public static uint SET_PLAYER_INVINCIBLE = 0X424908;
            public static uint SET_PLAYER_INVISIBLE_LOCALLY = 0X3EC784;
            public static uint SET_PLAYER_LOCKON = 0X424AAC;
            public static uint SET_PLAYER_MAX_ARMOUR = 0X4251C4;
            public static uint SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE = 0X424550;
            public static uint SET_PLAYER_MODEL = 0X421648;
            public static uint SET_PLAYER_NOISE_MULTIPLIER = 0X42465C;
            public static uint SET_PLAYER_PARACHUTE_TINT_INDEX = 0X426018;
            public static uint SET_PLAYER_SIMULATE_AIMING = 0X42671C;
            public static uint SET_PLAYER_SPRINT = 0X423B54;
            public static uint SET_PLAYER_TARGETING_MODE = 0X424B00;
            public static uint SET_PLAYER_TEAM = 0X421B34;
            public static uint SET_PLAYER_VEHICLE_DAMAGE_MODIFIER = 0X425F78;
            public static uint SET_PLAYER_VISIBLE_LOCALLY = 0X3EC838;
            public static uint SET_PLAYER_WANTED_CENTRE_POSITION = 0X421D70;
            public static uint SET_PLAYER_WANTED_LEVEL = 0X421E70;
            public static uint SET_PLAYER_WANTED_LEVEL_NO_DROP = 0X421FBC;
            public static uint SET_PLAYER_WANTED_LEVEL_NOW = 0X4220BC;
            public static uint SET_PLAYER_WEAPON_DAMAGE_MODIFIER = 0X425E38;
            public static uint SET_PLAYERPAD_SHAKES_WHEN_CONTROLLER_DISABLED = 0X400C84;
            public static uint SET_PLAYERS_LAST_VEHICLE = 0X461E30;
            public static uint SET_POLICE_IGNORE_PLAYER = 0X422B10;
            public static uint SET_POLICE_RADAR_BLIPS = 0X422B00;
            public static uint SET_RADAR_AS_EXTERIOR_THIS_FRAME = 0X3CBE24;
            public static uint SET_RADAR_AS_INTERIOR_THIS_FRAME = 0X3CBDF4;
            public static uint SET_RADAR_ZOOM = 0X3CA990;
            public static uint SET_RADIO_AUTO_UNFREEZE = 0X39EAC8;
            public static uint SET_RADIO_TO_STATION_INDEX = 0X39E8E8;
            public static uint SET_RADIO_TO_STATION_NAME = 0X39E8BC;
            public static uint SET_RADIO_TRACK = 0X39EB14;
            public static uint SET_RANDOM_BOATS = 0X4539E0;
            public static uint SET_RANDOM_EVENT_FLAG = 0X3D3BD8;
            public static uint SET_RANDOM_SEED = 0X3D3A8C;
            public static uint SET_RANDOM_TRAINS = 0X453654;
            public static uint SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME = 0X44F42C;
            public static uint SET_RANDOM_WEATHER_TYPE = 0X3D3FEC;
            public static uint SET_REDUCE_PED_MODEL_BUDGET = 0X4365D4;
            public static uint SET_REDUCE_VEHICLE_MODEL_BUDGET = 0X436600;
            public static uint SET_RELATIONSHIP_BETWEEN_GROUPS = 0X40DBD4;
            public static uint SET_RENDER_TRAIN_AS_DERAILED = 0X45392C;
            public static uint SET_ROADS_BACK_TO_ORIGINAL = 0X402D24;
            public static uint SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA = 0X402E74;
            public static uint SET_ROADS_IN_ANGLED_AREA = 0X4018A4;
            public static uint SET_ROADS_IN_AREA = 0X40168C;
            public static uint SET_SAVE_HOUSE = 0X3D367C;
            public static uint SET_SAVE_MENU_ACTIVE = 0X3D5D3C;
            public static uint SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED = 0X3C4704;
            public static uint SET_SCENARIO_GROUP_ENABLED = 0X447EB8;
            public static uint SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME = 0X408FE4;
            public static uint SET_SCENARIO_PEDS_SPAWN_IN_SPHERE_AREA = 0X415D14;
            public static uint SET_SCENARIO_PEDS_TO_BE_RETURNED_BY_NEXT_COMMAND = 0X412BCC;
            public static uint SET_SCENARIO_TYPE_ENABLED = 0X448008;
            public static uint SET_SCRIPT_AS_NO_LONGER_NEEDED = 0X43953C;
            public static uint SET_SCRIPT_VEHICLE_GENERATOR = 0X44EAB8;
            public static uint SET_SCRIPTED_ANIM_SEAT_OFFSET = 0X418C08;
            public static uint SET_SEETHROUGH = 0X3BF598;
            public static uint SET_SEQUENCE_TO_REPEAT = 0X43EE60;
            public static uint SET_SIREN_WITH_NO_DRIVER = 0X39FD2C;
            public static uint SET_SPECIAL_ABILITY_MULTIPLIER = 0X425854;
            public static uint SET_SRL_TIME = 0X437F94;
            public static uint SET_STATE_OF_CLOSEST_DOOR_OF_TYPE = 0X3FC548;
            public static uint SET_STATIC_EMITTER_ENABLED = 0X39EE80;
            public static uint SET_STORE_ENABLED = 0X3F1A54;
            public static uint SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED = 0X3BF488;
            public static uint SET_STREAMING = 0X436540;
            public static uint SET_SUPER_JUMP_THIS_FRAME = 0X3D97F0;
            public static uint SET_SYNCHRONIZED_SCENE_LOOPED = 0X41AF54;
            public static uint SET_SYNCHRONIZED_SCENE_ORIGIN = 0X41AD00;
            public static uint SET_SYNCHRONIZED_SCENE_PHASE = 0X41AEB4;
            public static uint SET_SYNCHRONIZED_SCENE_RATE = 0X41ADF4;
            public static uint SET_TAXI_LIGHTS = 0X44FDB0;
            public static uint SET_TEAM_PICKUP_OBJECT = 0X3FEBD0;
            public static uint SET_TEXT_CENTRE = 0X3C9770;
            public static uint SET_TEXT_COLOUR = 0X3C9738;
            public static uint SET_TEXT_DROP_SHADOW = 0X3C97FC;
            public static uint SET_TEXT_DROPSHADOW = 0X3C9810;
            public static uint SET_TEXT_EDGE = 0X10FA0;
            public static uint SET_TEXT_FONT = 0X3C97EC;
            public static uint SET_TEXT_LEADING = 0X3C97D8;
            public static uint SET_TEXT_OUTLINE = 0X3C9840;
            public static uint SET_TEXT_PROPORTIONAL = 0X10FA0;
            public static uint SET_TEXT_RENDER_ID = 0X3C9858;
            public static uint SET_TEXT_RIGHT_JUSTIFY = 0X3C9790;
            public static uint SET_TEXT_SCALE = 0X3C9724;
            public static uint SET_TEXT_WRAP = 0X3C97C4;
            public static uint SET_TEXT_ENTRY = 0X3C8294;
            public static uint SET_THIS_SCRIPT_CAN_BE_PAUSED = 0X3D7A64;
            public static uint SET_THIS_SCRIPT_CAN_REMOVE_BLIPS_CREATED_BY_ANY_SCRIPT = 0X3D7A88;
            public static uint SET_TIME_EXCLUSIVE_DISPLAY_TEXTURE = 0X40A7CC;
            public static uint SET_TIME_SCALE = 0X3D3AC0;
            public static uint SET_TIMECYCLE_MODIFIER = 0X3C3FA4;
            public static uint SET_TIMECYCLE_MODIFIER_STRENGTH = 0X3C4008;
            public static uint SET_TRACKED_POINT_INFO = 0X3BFB50;
            public static uint SET_TRAIN_CRUISE_SPEED = 0X4538AC;
            public static uint SET_TRAIN_SPEED = 0X45382C;
            public static uint SET_TRANSITION_TIMECYCLE_MODIFIER = 0X3C4018;
            public static uint SET_TV_AUDIO_FRONTEND = 0X3C15E8;
            public static uint SET_TV_CHANNEL = 0X3C516C;
            public static uint SET_TV_VOLUME = 0X3C519C;
            public static uint SET_USER_RADIO_CONTROL_ENABLED = 0X39E970;
            public static uint SET_USERIDS_UIHIDDEN = 0X3CDC84;
            public static uint SET_VARIABLE_ON_SOUND = 0X39D8AC;
            public static uint SET_VARIABLE_ON_STREAM = 0X39D8DC;
            public static uint SET_VEH_RADIO_STATION = 0X39ED90;
            public static uint SET_VEHICLE_ALARM = 0X45A5C8;
            public static uint SET_VEHICLE_AS_NO_LONGER_NEEDED = 0X3B2788;
            public static uint SET_VEHICLE_AUTOMATICALLY_ATTACHES = 0X45E294;
            public static uint SET_VEHICLE_BOOST_ACTIVE = 0X3A0098;
            public static uint SET_VEHICLE_BRAKE = 0X45E4C8;
            public static uint SET_VEHICLE_BRAKE_LIGHTS = 0X45E3C8;
            public static uint SET_VEHICLE_BURNOUT = 0X45C060;
            public static uint SET_VEHICLE_CAN_BE_TARGETTED = 0X4564B0;
            public static uint SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED = 0X45660C;
            public static uint SET_VEHICLE_CAN_BREAK = 0X457DB0;
            public static uint SET_VEHICLE_COLOUR_COMBINATION = 0X458014;
            public static uint SET_VEHICLE_COLOURS = 0X44FF60;
            public static uint SET_VEHICLE_CUSTOM_PRIMARY_COLOUR = 0X44FFFC;
            public static uint SET_VEHICLE_CUSTOM_SECONDARY_COLOUR = 0X450238;
            public static uint SET_VEHICLE_DAMAGE = 0X459AA0;
            public static uint SET_VEHICLE_DEFORMATION_FIXED = 0X4590FC;
            public static uint SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME = 0X44F400;
            public static uint SET_VEHICLE_DIRT_LEVEL = 0X4567A0;
            public static uint SET_VEHICLE_DOOR_BROKEN = 0X457AEC;
            public static uint SET_VEHICLE_DOOR_CONTROL = 0X456B30;
            public static uint SET_VEHICLE_DOOR_LATCHED = 0X456C34;
            public static uint SET_VEHICLE_DOOR_OPEN = 0X4526C0;
            public static uint SET_VEHICLE_DOOR_SHUT = 0X4579F0;
            public static uint SET_VEHICLE_DOORS_LOCKED = 0X44F4D8;
            public static uint SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS = 0X44F740;
            public static uint SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER = 0X44F5C4;
            public static uint SET_VEHICLE_DOORS_LOCKED_FOR_TEAM = 0X44F87C;
            public static uint SET_VEHICLE_DOORS_SHUT = 0X4519B0;
            public static uint SET_VEHICLE_ENGINE_HEALTH = 0X459EB0;
            public static uint SET_VEHICLE_ENGINE_ON = 0X456954;
            public static uint SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE = 0X45B198;
            public static uint SET_VEHICLE_EXTRA = 0X4597A0;
            public static uint SET_VEHICLE_EXTRA_COLOURS = 0X458F28;
            public static uint SET_VEHICLE_FIXED = 0X459070;
            public static uint SET_VEHICLE_FORWARD_SPEED = 0X451600;
            public static uint SET_VEHICLE_FRICTION_OVERRIDE = 0X461F00;
            public static uint SET_VEHICLE_FULLBEAM = 0X4505C0;
            public static uint SET_VEHICLE_GRAVITY = 0X4611D8;
            public static uint SET_VEHICLE_HANDBRAKE = 0X45E440;
            public static uint SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER = 0X45A2DC;
            public static uint SET_VEHICLE_HAS_STRONG_AXLES = 0X45A568;
            public static uint SET_VEHICLE_INDICATOR_LIGHTS = 0X45E340;
            public static uint SET_VEHICLE_INTERIORLIGHT = 0X45A720;
            public static uint SET_VEHICLE_IS_CONSIDERED_BY_PLAYER = 0X45848C;
            public static uint SET_VEHICLE_IS_STOLEN = 0X461800;
            public static uint SET_VEHICLE_IS_WANTED = 0X460604;
            public static uint SET_VEHICLE_LIGHT_MULTIPLIER = 0X452BD8;
            public static uint SET_VEHICLE_LIGHTS = 0X452AD8;
            public static uint SET_VEHICLE_LIVERY = 0X45A9E0;
            public static uint SET_VEHICLE_LOD_MULTIPLIER = 0X460A58;
            public static uint SET_VEHICLE_MAP_COORD = 0X453210;
            public static uint SET_VEHICLE_MAX_STR_TRAP = 0X4622C4;
            public static uint SET_VEHICLE_MOD = 0X45F3E0;
            public static uint SET_VEHICLE_MOD_COLOR_1 = 0X45EF94;
            public static uint SET_VEHICLE_MOD_COLOR_2 = 0X45F034;
            public static uint SET_VEHICLE_MOD_KIT = 0X45ECA4;
            public static uint SET_VEHICLE_MODEL_IS_SUPPRESSED = 0X454320;
            public static uint SET_VEHICLE_NAME_DEBUG = 0X10FA0;
            public static uint SET_VEHICLE_NEEDS_TO_BE_HOTWIRED = 0X45A33C;
            public static uint SET_VEHICLE_NUMBER_PLATE_TEXT = 0X45344C;
            public static uint SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX = 0X453528;
            public static uint SET_VEHICLE_ON_GROUND_PROPERLY = 0X44EE48;
            public static uint SET_VEHICLE_OUT_OF_CONTROL = 0X44F9E0;
            public static uint SET_VEHICLE_PETROL_TANK_HEALTH = 0X45A00C;
            public static uint SET_VEHICLE_POPULATION_BUDGET = 0X436C58;
            public static uint SET_VEHICLE_PROVIDES_COVER = 0X456AD0;
            public static uint SET_VEHICLE_POWER_MULTIPLICATEUR = 0X46018C; //0XE943B09C
            public static uint SET_VEHICLE_RADIO_ENABLED = 0X39ECB4;
            public static uint SET_VEHICLE_RADIO_LOUD = 0X39EBA8;
            public static uint SET_VEHICLE_REDUCE_GRIP = 0X45C154;
            public static uint SET_VEHICLE_RUDDER_BROKEN = 0X457CB0;
            public static uint SET_VEHICLE_SEARCHLIGHT = 0X45EB54;
            public static uint SET_VEHICLE_SHOOT_AT_TARGET = 0X460DEC;
            public static uint SET_VEHICLE_SIREN = 0X450E6C;
            public static uint SET_VEHICLE_STEER_BIAS = 0X4595D0;
            public static uint SET_VEHICLE_STRONG = 0X45104C;
            public static uint SET_VEHICLE_TIMED_EXPLOSION = 0X44FA8C;
            public static uint SET_VEHICLE_TYRE_BURST = 0X451890;
            public static uint SET_VEHICLE_TYRE_FIXED = 0X4533A4;
            public static uint SET_VEHICLE_TYRE_SMOKE_COLOR = 0X45FC90;
            public static uint SET_VEHICLE_TYRES_CAN_BURST = 0X451D5C;
            public static uint SET_VEHICLE_UNDRIVEABLE = 0X456A38;
            public static uint SET_VEHICLE_WHEEL_TYPE = 0X45EE7C;
            public static uint SET_VEHICLE_WHEELS_CAN_BREAK = 0X451E40;
            public static uint SET_VEHICLE_WINDOW_TINT = 0X45FD74;
            public static uint SET_WANTED_LEVEL_DIFFICULTY = 0X422EAC;
            public static uint SET_WANTED_LEVEL_MULTIPLIER = 0X422E7C;
            public static uint SET_WARNING_MESSAGE = 0X3CD310;
            public static uint SET_WAYPOINT_OFF = 0X3CB968;
            public static uint SET_WEAPON_ANIMATION_OVERRIDE = 0X46AA88;
            public static uint SET_WEAPON_OBJECT_TINT_INDEX = 0X46A264;
            public static uint SET_WEAPON_SMOKEGRENADE_ASSIGNED = 0X46A9D8;
            public static uint SET_WEATHER_TYPE_NOW = 0X3D3F04;
            public static uint SET_WEATHER_TYPE_NOW_PERSIST = 0X3D3E90;
            public static uint SET_WEATHER_TYPE_PERSIST = 0X3D3E30;
            public static uint SET_WIDESCREEN_BORDERS = 0X3A656C;
            public static uint SET_WIDESCREEN_FORMAT = 0X3C970C;
            public static uint SET_WIND = 0X3D42B8;
            public static uint SET_WIND_DIRECTION = 0X3D431C;
            public static uint SET_WIND_SPEED = 0X3D42D0;
            public static uint SET_ZONE_ENABLED = 0X46B5D0;
            public static uint SETTIMERA = 0X9B8500;
            public static uint SETTIMERB = 0X9B850C;
            public static uint SHAKE_CAM = 0X3A5A60;
            public static uint SHAKE_CINEMATIC_CAM = 0X3A7104;
            public static uint SHAKE_GAMEPLAY_CAM = 0X3A6EE8;
            public static uint SHIFT_LEFT = 0X9B89A4;
            public static uint SHIFT_RIGHT = 0X9B899C;
            public static uint SHOOT_SINGLE_BULLET_BETWEEN_COORDS = 0X3D66E0;
            public static uint SHOW_HUD_COMPONENT_THIS_FRAME = 0X3CC728;
            public static uint SHOW_NUMBER_ON_BLIP = 0X3CB5B0;
            public static uint SHUTDOWN_AND_LAUNCH_SINGLE_PLAYER_GAME = 0X3EBEFC;
            public static uint SHUTDOWN_LOADING_SCREEN = 0X42869C;
            public static uint SIMULATE_PLAYER_INPUT_GAIT = 0X426338;
            public static uint SIN = 0X9B8898;
            public static uint SITTING_TV = 0X3C4D98;
            public static uint SKIP_RADIO_FORWARD = 0X39EB44;
            public static uint SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE = 0X453CD0;
            public static uint SKIP_TO_END_AND_STOP_PLAYBACK_RECORDED_VEHICLE = 0X4535FC;
            public static uint SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE = 0X39D0E4;
            public static uint SLIDE_OBJECT = 0X3FB1E8;
            public static uint SMASH_VEHICLE_WINDOW = 0X452830;
            public static uint SNPRINTF = 0X14F9F8C;
            public static uint SPECIAL_ABILITY_DEACTIVATE = 0X425218;
            public static uint SPECIAL_ABILITY_LOCK = 0X42568C;
            public static uint SPECIAL_ABILITY_RESET = 0X4252A8;
            public static uint SPECIAL_ABILITY_UNLOCK = 0X4256B4;
            public static uint SPECIAL_FRONTEND_EQUAL = 0X39FA18;
            public static uint SQRT = 0X9B8904;
            public static uint START_ALARM = 0X3A0B28;
            public static uint START_AUDIO_SCENE = 0X3A0658;
            public static uint START_CUTSCENE = 0X3B6C0C;
            public static uint START_CUTSCENE_AT_COORDS = 0X3B6C44;
            public static uint START_ENTITY_FIRE = 0X3BCF90;
            public static uint START_FIRING_AMNESTY = 0X422F84;
            public static uint START_NEW_SCRIPT = 0X9B83CC;
            public static uint START_NEW_SCRIPT_WITH_ARGS = 0X9B83CC;
            public static uint START_PARTICLE_FX_LOOPED_AT_COORD = 0X3C1D30;
            public static uint START_PARTICLE_FX_LOOPED_ON_ENTITY = 0X1576784;
            public static uint START_PARTICLE_FX_LOOPED_ON_PED_BONE = 0X157669C;
            public static uint START_PARTICLE_FX_NON_LOOPED_AT_COORD = 0X3C1B18;
            public static uint START_PARTICLE_FX_NON_LOOPED_ON_ENTITY = 0X1576784;
            public static uint START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE = 0X157669C;
            public static uint START_PLAYBACK_RECORDED_VEHICLE = 0X451EE0;
            public static uint START_PLAYBACK_RECORDED_VEHICLE_USING_AI = 0X453B0C;
            public static uint START_PLAYBACK_RECORDED_VEHICLE_WITH_FLAGS = 0X452108;
            public static uint START_PLAYER_SWITCH = 0X4374FC;
            public static uint START_PLAYER_TELEPORT = 0X425C40;
            public static uint START_PRELOADED_CONVERSATION = 0X39CF78;
            public static uint START_SAVE_DATA = 0X3D7BD4;
            public static uint START_SCRIPT_CONVERSATION = 0X39CEF0;
            public static uint START_SCRIPT_FIRE = 0X3BCE90;
            public static uint START_SCRIPT_PHONE_CONVERSATION = 0X39D2EC;
            public static uint START_VEHICLE_ALARM = 0X45A638;
            public static uint START_VEHICLE_HORN = 0X45A408;
            public static uint STAT_DELETE_SLOT = 0X4338AC;
            public static uint STAT_GET_BOOL = 0X42D020;
            public static uint STAT_GET_BOOL_MASKED = 0X4344FC;
            public static uint STAT_GET_DATE = 0X42D134;
            public static uint STAT_GET_FLOAT = 0X42CF24;
            public static uint STAT_GET_INT = 0X42CE54;
            public static uint STAT_GET_MASKED_INT = 0X42D4B8;
            public static uint STAT_GET_POS = 0X42D390;
            public static uint STAT_GET_STRING = 0X42D2A0;
            public static uint STAT_GET_USER_ID = 0X42D55C;
            public static uint STAT_INCREMENT = 0X42D820;
            public static uint STAT_LOAD = 0X433A28;
            public static uint STAT_LOAD_PENDING = 0X43381C;
            public static uint STAT_SAVE = 0X433E40;
            public static uint STAT_SAVE_PENDING = 0X43383C;
            public static uint STAT_SET_BOOL = 0X42C2A4;
            public static uint STAT_SET_BOOL_MASKED = 0X434554;
            public static uint STAT_SET_DATE = 0X42C524;
            public static uint STAT_SET_FLOAT = 0X42C178;
            public static uint STAT_SET_INT = 0X42BE0C;
            public static uint STAT_SET_MASKED_INT = 0X42C968;
            public static uint STAT_SET_POS = 0X42C810;
            public static uint STAT_SET_STRING = 0X42C6D0;
            public static uint STAT_SET_USER_ID = 0X42CA54;
            public static uint STEER_UNLOCK_BIAS = 0X45063C;
            public static uint STOP_ALARM = 0X3A0B5C;
            public static uint STOP_ALL_ALARMS = 0X3A0B90;
            public static uint STOP_ALL_GARAGE_ACTIVITY = 0X459044;
            public static uint STOP_ANIM_PLAYBACK = 0X43DE70;
            public static uint STOP_ANIM_TASK = 0X43E7E0;
            public static uint STOP_ANY_PED_MODEL_BEING_SUPPRESSED = 0X417F88;
            public static uint STOP_AUDIO_SCENE = 0X3A068C;
            public static uint STOP_AUDIO_SCENES = 0X3A06C0;
            public static uint STOP_CAM_POINTING = 0X3A481C;
            public static uint STOP_CAM_SHAKING = 0X3A5C6C;
            public static uint STOP_CINEMATIC_CAM_SHAKING = 0X3A7190;
            public static uint STOP_CINEMATIC_SHOT = 0X3A74E4;
            public static uint STOP_CURRENT_PLAYING_AMBIENT_SPEECH = 0X39E164;
            public static uint STOP_CUTSCENE = 0X3B6D78;
            public static uint STOP_CUTSCENE_CAM_SHAKING = 0X3A6FA0;
            public static uint STOP_CUTSCENE_IMMEDIATELY = 0X3B6DA8;
            public static uint STOP_ENTITY_ANIM = 0X3B1710;
            public static uint STOP_ENTITY_FIRE = 0X3BD070;
            public static uint STOP_FIRE_IN_RANGE = 0X3BD200;
            public static uint STOP_GAMEPLAY_CAM_SHAKING = 0X3A6F74;
            public static uint STOP_GAMEPLAY_HINT = 0X3A7A18;
            public static uint STOP_PAD_SHAKE = 0X400A80;
            public static uint STOP_PARTICLE_FX_LOOPED = 0X3C2424;
            public static uint STOP_PED_RINGTONE = 0X39CB20;
            public static uint STOP_PED_SPEAKING = 0X39FBDC;
            public static uint STOP_PED_WEAPON_FIRING_WHEN_DROPPED = 0X418B98;
            public static uint STOP_PLAYBACK_RECORDED_VEHICLE = 0X452414;
            public static uint STOP_PLAYER_REMAIN_ARCADE = 0X4377E8;
            public static uint STOP_PLAYER_SWITCH = 0X437BA4;
            public static uint STOP_PLAYER_TELEPORT = 0X425D64;
            public static uint STOP_SAVE_ARRAY = 0X3D7C20;
            public static uint STOP_SAVE_DATA = 0X3D7C20;
            public static uint STOP_SAVE_STRUCT = 0X3D7C20;
            public static uint STOP_SCRIPTED_CONVERSATION = 0X39D0B8;
            public static uint STOP_SOUND = 0X39D824;
            public static uint STOP_STREAM = 0X39FB84;
            public static uint STOP_SYNCHRONIZED_AUDIO_EVENT = 0X3A0F7C;
            public static uint STOP_SYNCHRONIZED_ENTITY_ANIM = 0X3B18C0;
            public static uint STRING_TO_INT = 0X3D7508;
            public static uint SWITCH_TRAIN_TRACK = 0X453690;
            public static uint TAN = 0X3D4CE0;
            public static uint TASK_ACHIEVE_HEADING = 0X43B060;
            public static uint TASK_AIM_GUN_AT_COORD = 0X43FE48;
            public static uint TASK_AIM_GUN_AT_ENTITY = 0X43FBC0;
            public static uint TASK_AIM_GUN_SCRIPTED = 0X43F3B8;
            public static uint TASK_AIM_GUN_SCRIPTED_WITH_TARGET = 0X43F698;
            public static uint TASK_ARREST_PED = 0X44B0AC;
            public static uint TASK_BOAT_MISSION = 0X442918;
            public static uint TASK_CHAT_TO_PED = 0X444FB8;
            public static uint TASK_CLEAR_DEFENSIVE_AREA = 0X445B3C;
            public static uint TASK_CLEAR_LOOK_AT = 0X441068;
            public static uint TASK_CLIMB = 0X44538C;
            public static uint TASK_CLIMB_LADDER = 0X4453F4;
            public static uint TASK_COMBAT_HATED_TARGETS_AROUND_PED = 0X43BF30;
            public static uint TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED = 0X43C020;
            public static uint TASK_COMBAT_HATED_TARGETS_IN_AREA = 0X43BE40;
            public static uint TASK_COMBAT_PED = 0X43BD38;
            public static uint TASK_COMBAT_PED_TIMED = 0X43C120;
            public static uint TASK_COWER = 0X439F40;
            public static uint TASK_DRIVE_BY = 0X444188;
            public static uint TASK_ENTER_VEHICLE = 0X43A510;
            public static uint TASK_EVERYONE_LEAVE_VEHICLE = 0X440490;
            public static uint TASK_EXIT_COVER = 0X446DF4;
            public static uint TASK_EXTEND_ROUTE = 0X43B1B0;
            public static uint TASK_FLUSH_ROUTE = 0X43B198;
            public static uint TASK_FOLLOW_NAV_MESH_TO_COORD = 0X43C458;
            public static uint TASK_FOLLOW_POINT_ROUTE = 0X43B3A0;
            public static uint TASK_FOLLOW_TO_OFFSET_OF_ENTITY = 0X43B238;
            public static uint TASK_FOLLOW_WAYPOINT_RECORDING = 0X44D2FC;
            public static uint TASK_FORCE_MOTION_STATE = 0X449B70;
            public static uint TASK_GO_STRAIGHT_TO_COORD = 0X43AD40;
            public static uint TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY = 0X43AF08;
            public static uint TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD = 0X441580;
            public static uint TASK_GO_TO_COORD_ANY_MEANS = 0X43CD80;
            public static uint TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD = 0X4412A8;
            public static uint TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY = 0X441400;
            public static uint TASK_GO_TO_ENTITY = 0X43B4D8;
            public static uint TASK_GO_TO_ENTITY_WHILE_AIMING_AT_COORD = 0X4416EC;
            public static uint TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY = 0X441860;
            public static uint TASK_GOTO_ENTITY_AIMING = 0X445850;
            public static uint TASK_GOTO_ENTITY_OFFSET = 0X440630;
            public static uint TASK_GOTO_ENTITY_OFFSET_XY = 0X440810;
            public static uint TASK_GUARD_CURRENT_POSITION = 0X446118;
            public static uint TASK_GUARD_SPHERE_DEFENSIVE_AREA = 0X445FB0;
            public static uint TASK_HANDS_UP = 0X439FC0;
            public static uint TASK_HELI_CHASE = 0X443CE0;
            public static uint TASK_HELI_MISSION = 0X442488;
            public static uint TASK_JUMP = 0X439ED8;
            public static uint TASK_LEAVE_ANY_VEHICLE = 0X43F294;
            public static uint TASK_LEAVE_VEHICLE = 0X43A740;
            public static uint TASK_LOOK_AT_COORD = 0X440C38;
            public static uint TASK_LOOK_AT_ENTITY = 0X440DF0;
            public static uint TASK_OPEN_VEHICLE_DOOR = 0X43A358;
            public static uint TASK_PARACHUTE = 0X448ED4;
            public static uint TASK_PARACHUTE_TO_TARGET = 0X448F50;
            public static uint TASK_PATROL = 0X449574;
            public static uint TASK_PAUSE = 0X439DD4;
            public static uint TASK_PED_SLIDE_TO_COORD = 0X445E28;
            public static uint TASK_PED_SLIDE_TO_COORD_HDG_RATE = 0X445C58;
            public static uint TASK_PERFORM_SEQUENCE = 0X43ED40;
            public static uint TASK_PERFORM_SEQUENCE_FROM_PROGRESS = 0X445590;
            public static uint TASK_PLANE_CHASE = 0X4439D4;
            public static uint TASK_PLANE_LAND = 0X443B40;
            public static uint TASK_PLANE_MISSION = 0X4426D8;
            public static uint TASK_PLANT_BOMB = 0X442F18;
            public static uint TASK_PLAY_ANIM = 0X43D6F4;
            public static uint TASK_PUT_PED_DIRECTLY_INTO_COVER = 0X446D14;
            public static uint TASK_PUT_PED_DIRECTLY_INTO_MELEE = 0X446F90;
            public static uint TASK_RAPPEL_FROM_HELI = 0X4491C8;
            public static uint TASK_REACT_AND_FLEE_PED = 0X43B8E8;
            public static uint TASK_RELOAD_WEAPON = 0X448D14;
            public static uint TASK_SCRIPTED_ANIMATION = 0X43D788;
            public static uint TASK_SEEK_COVER_FROM_PED = 0X446720;
            public static uint TASK_SEEK_COVER_FROM_POS = 0X4465C8;
            public static uint TASK_SEEK_COVER_TO_COORDS = 0X446A08;
            public static uint TASK_SEEK_COVER_TO_COVER_POINT = 0X446890;
            public static uint TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS = 0X449AF0;
            public static uint TASK_SET_DECISION_MAKER = 0X445914;
            public static uint TASK_SET_SPHERE_DEFENSIVE_AREA = 0X445A04;
            public static uint TASK_SHOCKING_EVENT_REACT = 0X43BA74;
            public static uint TASK_SHOOT_AT_COORD = 0X43FFA0;
            public static uint TASK_SHOOT_AT_ENTITY = 0X445258;
            public static uint TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT = 0X44019C;
            public static uint TASK_SKY_DIVE = 0X448DE0;
            public static uint TASK_SMART_FLEE_COORD = 0X43B680;
            public static uint TASK_SMART_FLEE_PED = 0X43B7A8;
            public static uint TASK_STAND_GUARD = 0X4462A0;
            public static uint TASK_STAND_STILL = 0X439E44;
            public static uint TASK_START_SCENARIO_AT_POSITION = 0X447638;
            public static uint TASK_START_SCENARIO_IN_PLACE = 0X447528;
            public static uint TASK_STAY_IN_COVER = 0X449624;
            public static uint TASK_STEALTH_KILL = 0X442D64;
            public static uint TASK_SWAP_WEAPON = 0X448C98;
            public static uint TASK_SYNCHRONIZED_SCENE = 0X43E9F8;
            public static uint TASK_THROW_PROJECTILE = 0X43C288;
            public static uint TASK_TOGGLE_DUCK = 0X439D50;
            public static uint TASK_TURN_PED_TO_FACE_COORD = 0X4411B0;
            public static uint TASK_TURN_PED_TO_FACE_ENTITY = 0X43FD28;
            public static uint TASK_USE_MOBILE_PHONE = 0X4448C4;
            public static uint TASK_USE_MOBILE_PHONE_TIMED = 0X444E24;
            public static uint TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD = 0X448808;
            public static uint TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP = 0X4488C4;
            public static uint TASK_USE_NEAREST_SCENARIO_TO_COORD = 0X448518;
            public static uint TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP = 0X4485E8;
            public static uint TASK_VEHICLE_AIM_AT_COORD = 0X449908;
            public static uint TASK_VEHICLE_AIM_AT_PED = 0X449770;
            public static uint TASK_VEHICLE_CHASE = 0X4436CC;
            public static uint TASK_VEHICLE_DRIVE_TO_COORD = 0X43A9AC;
            public static uint TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE = 0X43A9F0;
            public static uint TASK_VEHICLE_DRIVE_WANDER = 0X43AC24;
            public static uint TASK_VEHICLE_ESCORT = 0X443008;
            public static uint TASK_VEHICLE_FOLLOW = 0X443258;
            public static uint TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING = 0X44DC88;
            public static uint TASK_VEHICLE_GOTO_NAVMESH = 0X44B410;
            public static uint TASK_VEHICLE_HELI_PROTECT = 0X443484;
            public static uint TASK_VEHICLE_MISSION = 0X15AB5B0;
            public static uint TASK_VEHICLE_MISSION_COORS_TARGET = 0X441FF4;
            public static uint TASK_VEHICLE_MISSION_PED_TARGET = 0X15AB5B0;
            public static uint TASK_VEHICLE_PARK = 0X442B28;
            public static uint TASK_VEHICLE_PLAY_ANIM = 0X44A7B8;
            public static uint TASK_VEHICLE_SHOOT_AT_COORD = 0X449844;
            public static uint TASK_VEHICLE_SHOOT_AT_PED = 0X44968C;
            public static uint TASK_VEHICLE_TEMP_ACTION = 0X441A18;
            public static uint TASK_WANDER_IN_AREA = 0X43BAF0;
            public static uint TASK_WANDER_STANDARD = 0X43BC10;
            public static uint TASK_WARP_PED_INTO_VEHICLE = 0X4450EC;
            public static uint TASK_WRITHE = 0X4492BC;
            public static uint TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME = 0X3D5E7C;
            public static uint TERMINATE_THIS_THREAD = 0X428048;
            public static uint TERMINATE_THREAD = 0X439A30;
            public static uint TEXTURE_DOWNLOAD_GET_NAME = 0X3F36FC;
            public static uint TEXTURE_DOWNLOAD_RELEASE = 0X3F36A4;
            public static uint TEXTURE_DOWNLOAD_REQUEST = 0X3F344C;
            public static uint TIMERA = 0X9B84E0;
            public static uint TIMERB = 0X9B84F0;
            public static uint TIMESTEP = 0X9B8518;
            public static uint TO_FLOAT = 0X9B8A58;
            public static uint TOGGLE_STEALTH_RADAR = 0X3CC140;
            public static uint TOGGLE_VEHICLE_MOD = 0X45F750;
            public static uint TRACK_OBJECT_VISIBILITY = 0X3FC1C4;
            public static uint TRACK_VEHICLE_VISIBILITY = 0X4610F4;
            public static uint TRIGGER_MUSIC_EVENT = 0X3A05F4;
            public static uint TRIGGER_SCRIPT_EVENT = 0X428574;
            public static uint UNCUFF_PED = 0X44B360;
            public static uint UNFREEZE_RADIO_STATION = 0X39EAA0;
            public static uint UNLOCK_MINIMAP_ANGLE = 0X3CC2A0;
            public static uint UNLOCK_MINIMAP_POSITION = 0X3CC2C4;
            public static uint UNLOCK_MISSION_NEWS_STORY = 0X39E9C4;
            public static uint UNPAUSE_PLAYBACK_RECORDED_VEHICLE = 0X4524C4;
            public static uint UNPIN_INTERIOR = 0X3D20F8;
            public static uint UNPIN_ROPE_VERTEX = 0X420228;
            public static uint UNREGISTER_PEDHEADSHOT = 0X41BAB0;
            public static uint UNREGISTER_SCRIPT_WITH_AUDIO = 0X10FA0;
            public static uint UPDATE_NAVMESH_BLOCKING_OBJECT = 0X4038BC;
            public static uint UPDATE_ONSCREEN_KEYBOARD = 0X3D9668;
            public static uint UPDATE_PED_HEAD_BLEND_DATA = 0X4113F4;
            public static uint USE_PLAYER_COLOUR_INSTEAD_OF_TEAM_COLOUR = 0X3EE2D0;
            public static uint USE_SIREN_AS_HORN = 0X39FF9C;
            public static uint USING_MISSION_CREATOR = 0X3D6A3C;
            public static uint USING_NETWORK_WEAPONTYPE = 0X3E8214;
            public static uint VDIST = 0X9B8930;
            public static uint VDIST2 = 0X9B8968;
            public static uint VEH_TO_NET = 0X3E9B30;
            public static uint VEHICLE_NET_ATTACH_CHAR_TO_CHAR_PHYSICALLY = 0X3EB250;
            public static uint VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED = 0X44E0F8;
            public static uint VEHICLE_WAYPOINT_PLAYBACK_PAUSE = 0X44E050;
            public static uint VEHICLE_WAYPOINT_PLAYBACK_RESUME = 0X44E090;
            public static uint VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED = 0X44E0C4;
            public static uint VMAG = 0X15253B4;
            public static uint VMAG2 = 0X150B908;
            public static uint WAIT = 0XFC9B85AF;
            public static uint WAITUNPAUSED = 0XFC9B86DF;
            public static uint WAITUNWARPED = 0XFC9B863F;
            public static uint WAS_COUNTER_ACTIVATED = 0X45B128;
            public static uint WAS_CUTSCENE_SKIPPED = 0X3B6E98;
            public static uint WAS_PED_KILLED_BY_STEALTH = 0X41938C;
            public static uint WAS_PED_KILLED_BY_TAKEDOWN = 0X4193F8;
            public static uint WAS_PED_SKELETON_UPDATED = 0X41566C;
            public static uint WASH_DECALS_FROM_VEHICLE = 0X3C2F0C;
            public static uint WASH_DECALS_IN_RANGE = 0X3C2E90;
            public static uint WAYPOINT_PLAYBACK_GET_IS_PAUSED = 0X44D644;
            public static uint WAYPOINT_PLAYBACK_OVERRIDE_SPEED = 0X44D708;
            public static uint WAYPOINT_PLAYBACK_PAUSE = 0X44D600;
            public static uint WAYPOINT_PLAYBACK_RESUME = 0X44D684;
            public static uint WAYPOINT_PLAYBACK_START_AIMING_AT_COORD = 0X44D808;
            public static uint WAYPOINT_PLAYBACK_START_AIMING_AT_PED = 0X44D778;
            public static uint WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD = 0X44D958;
            public static uint WAYPOINT_PLAYBACK_START_SHOOTING_AT_PED = 0X44D860;
            public static uint WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING = 0X44DA24;
            public static uint WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED = 0X44D6D0;
        }
  
    }
}

