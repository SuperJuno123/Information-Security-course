using Mubarakov_4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mubarakov_6
{

    public struct Variant
    {
        public BigInteger N;
        public BigInteger e;
        public BigInteger SW;
        public Variant(string _N, string _e, string _SW)
        {
            N = BigInteger.Parse(_N);
            e = BigInteger.Parse(_e);
            SW = BigInteger.Parse(_SW);
        }
    }

    public partial class Form1 : Form
    {

        static Dictionary<string, string> codes = new Dictionary<string, string>
            {{"16", "А"},
{"17", "Б"},
{"18", "В"},
{"19", "Г"},
{"20", "Д"},
{"21", "Е"},
{"22", "Ж"},
{"23", "З"},
{"24", "И"},
{"25", "Й"},
{"26", "К"},
{"27", "Л"},
{"28", "М"},
{"29", "Н"},
{"30", "О"},
{"31", "П"},
{"32", "Р"},
{"33", "С"},
{"34", "Т"},
{"35", "У"},
{"36", "Ф"},
{"37", "Х"},
{"38", "Ц"},
{"39", "Ч"},
{"40", "Ш"},
{"41", "Щ"},
{"42", "Ъ"},
{"43", "Ы"},
{"44", "Ь"},
{"45", "Э"},
{"46", "Ю"},
{"47", "Я"},
{"48", "а"},
{"49", "б"},
{"50", "в"},
{"51", "г"},
{"52", "д"},
{"53", "е"},
{"54", "ж"},
{"55", "з"},
{"56", "и"},
{"57", "й"},
{"58", "к"},
{"59", "л"},
{"60", "м"},
{"61", "н"},
{"62", "о"},
{"63", "п"},
{"64", "р"},
{"65", "с"},
{"66", "т"},
{"67", "у"},
{"68", "ф"},
{"69", "х"},
{"70", "ц"},
{"71", "ч"},
{"72", "ш"},
{"73", "щ"},
{"74", "ъ"},
{"75", "ы"},
{"76", "ь"},
{"77", "э"},
{"78", "ю"},
{"79", "я"}
        };

        static public Variant[] variants = new Variant[]
            {
            new Variant("344572667627327574872986520507", "303498613397661458186613409505", "42393687358080034300726554172"),
new Variant("374446690081577726518750680131", "227308426243091608838383020209", "173544927178205874489521719542"),
new Variant("2015638500984252513380255580199", "1118845478227818565358376981641", "1968403772706991943140704820969"),
new Variant("2803016870163537170844910120589", "321029592955180891096364204933", "14592629850394393337941666131"),
new Variant("801354636919526323408669959133", "5357133285262456827514698587", "630839280032278632036025925797"),
new Variant("875078015194165779807004996891", "3317761452838260724386723229", "736612590537995601962451694817"),
new Variant("2945551046056896373232621994521", "1578240369330316947030869051291", "2268046305917896117885320940385"),
new Variant("342009136322315980094889308153", "208882210355060386981711608527", "323071158829636363902958789743"),
new Variant("1204053537389703721541732260277", "861912432659932141657251942349", "536925649708611072738514452088"),
new Variant("54532674247289454314563008683", "11477646364080609704857416529", "43355907199058798176130579652"),
new Variant("4442502401588849632243368606511", "1190181981555380137698609038857", "2194663810499391809566551485933"),
new Variant("88008953914041855699205104599", "47229555628553041136830405571", "47407773157716183186429902491"),
new Variant("86892104384358621580698011597", "26398962489114266337226913921", "62873526787664405062856709109"),
new Variant("279987870740665381618843285073", "118086993812917654371624726349", "162836163952303018366729425385"),
new Variant("1441006610206833289007830556447", "1102261365739821522530333068003", "694624368581721113652509149602"),
new Variant("310006596248373369847685371499", "131417437022740390789727023183", "73207463908856286134350964021"),
new Variant("412950519942098514204399552799", "34343127213212244935444124191", "221300658194014757382986496783"),
new Variant("1303470844272911466854652379811", "621046881056292008081324361643", "1157594636053203376021925344632"),
new Variant("365986541659725380455392101587", "345463653468664133151171563183", "227618660835758378742072466215"),
new Variant("3261434502421303279323564402143", "2939271343282951673253104740745", "1729120759169116226435526469188"),
new Variant("880256638333804972652092375741", "679965420900654922416860968339", "797932992062154509068500137757"),
new Variant("5087308846537040504749735052677", "635964111226216674951775514511", "3009767917863379873938622968631"),
new Variant("59824481984506504151410133849", "9396366867643299157738812133", "38815413112101541429153780760"),
new Variant("345643290359673252210751286509", "42230327764300114870970880547", "100986129396953142858650179714"),
new Variant("240719707794161389931571470417", "1594459547134895900616767861", "214377409021092070327230236385"),
new Variant("2382108426543348401296729081237", "1154894534459475385454702210381", "1273370590783719809245106145607"),
new Variant("329814218084908451102237952889", "66076832588057025959339642363", "114675515992271270646220477408"),
new Variant("1375719758603974834448145016229", "786912904386116647910035357501", "438444967054424668764166860047"),
new Variant("1255621015589767357963616484373", "1229439078303093414729367665997", "6707128251645275107007709510"),
new Variant("4503580535302153411490266610041", "1189393447683752946756622398941", "2570503345929776816031645086354"),
new Variant("1627040944314653910634318496023", "180426666459182597612758185881", "390704174174367535084038714741"),
new Variant("3576943277408979005059757821217", "3482204036556926093749575408709", "1123015711801071636107843562874"),
new Variant("3260730192713051360762140398937", "1208481207980698001137312191587", "1355838234634039892969275383829"),
new Variant("2982927654040643617168221295807", "2873746014960179413091709562637", "476789675161565579480825665424"),
new Variant("274367968163392106602848256127", "154899187893923739338714676739", "64572423133411071142293616868"),
new Variant("1759704387935284899984083501633", "1668350266552664908136290878215", "101826364771542867589783519268"),
new Variant("50521984138040381699131985921", "1662206736409154854019667059", "9132458113454720873580260016"),
new Variant("2887972237802982718212271315873", "157998649488421547233695490521", "1996567031029429901473983017849"),
new Variant("2787714501387687333564375076367", "299520927037692620509634283853", "2081392748597597074193254643883"),
new Variant("73251552185971008095619995381", "11990006860577370723253958291", "13067984531505580476221665929"),
new Variant("2143329688117157614570671479917", "280157286011511271533989422951", "897283893756127578322292118958"),
new Variant("3485198031263125658050790686801", "3352025175036927419876530203125", "2973056604120304522969999696491"),
new Variant("770558893884724598529533674937", "722328504495843807022833112153", "335511379427534311656710798968"),
new Variant("1577271624417732056618338337651", "1291637051908295587224621302305", "13564020148294776742944381452"),
new Variant("502535245393651877650828332721", "182141162869635425214823416737", "87988840834435229649551090334"),
new Variant("309990562161532629109378549703", "296584741425508269897752766319", "74916456162242222413936537236"),
new Variant("243513455644316518701642102143", "239771145220867991202203659549", "11900361514720697833561840495"),
new Variant("1201742566949757754899862890233", "641647860430765751458392375359", "341217881604209907874675821433"),
new Variant("507209718350630004049694027123", "184487185821747957740702302621", "63422596028358682971997977073"),
new Variant("469066560453237099419615679323", "420335640180846896361633610321", "318792603074051503529131980007"),
new Variant("3603193717203092917877506797763", "2330934552496643682346076072881", "2462962878231895456628444926931"),
new Variant("405421750182999546086416639213", "352664141381672526074673384969", "190482502633602522026716406210"),
new Variant("537403628975761650764156954993", "517214694290847882761450046499", "26995737547564296500405026625"),
new Variant("309945939017081359552445591591", "256216931276866843653727191713", "125965184859491501024252798356"),
new Variant("2117319396463620915099437881223", "1105376787388722496862806077385", "1190288137632174072573528855141"),
new Variant("1122198810262474384600312231187", "63748139006231344946621145973", "292017007173513613151239211267"),
new Variant("1644674509297606959628451803057", "997586802469912185830957414599", "550843275631403134960714469840"),
new Variant("75404363540366760439727901499", "33451835917331251417201445711", "32517816964116314719497361317"),
new Variant("73807430560852047360352292987", "38707316417589116492583653317", "19211261404195575283252447332"),
new Variant("1764776284484729897892738967891", "619104589685425039468374670087", "1319592008578141450291094904313"),
new Variant("2425742060723730952266324124559", "324709972887192578587817677057", "919206802719720879838473172161"),
new Variant("235776045139618218610341863683", "52020494195584045512061375287", "153276312000303685717028522325"),
new Variant("72399694682825837946927975157", "66583587191012908259630071497", "65408072063058019072253577314"),
new Variant("82226843075939372862059256271", "39574931997271565078938293107", "72299210235764206342642689453"),
new Variant("576465851348833980669060214423", "263373400824198297846758495363", "222695874265921322617697906073"),
new Variant("1309320295521959979486637519751", "710818076151030423063628477991", "1151643322579967235272288665179"),
new Variant("388073116243299719049697041059", "93774658102057243875664542319", "31310614758708575891098216049"),
new Variant("106171883841886625367977923841", "47953521058903799911249297975", "7236098763031435159742573134"),
new Variant("75332357154462380976079586039", "24639182129584606917471570503", "26752566085475942776180898092"),
new Variant("73764210312306688035707750563", "23526777810187440967780547753", "9502486013590286668593653859"),
new Variant("406701666106963162281904899119", "57927194748969572194379255821", "320154759777551452843644098149"),
new Variant("224251103908338188528711756183", "171879645203279162794009958633", "67407413582329338256717213300"),
new Variant("3991181910811876034905559121593", "2413311687709450222212161769949", "909935708517973157565471317180"),
new Variant("73928320426901978411951089411", "2402688671386997131627458187", "20011660086946308434694374791"),
new Variant("69736417863105965026610220973", "34275792357732740887562394731", "51083116293135572495621698283"),

            };

        static BigInteger[] prime_numbers = new BigInteger[] {
             // До 10000
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997, 1009, 1013, 1019, 1021, 1031, 1033, 1039, 1049, 1051, 1061, 1063, 1069, 1087, 1091, 1093, 1097, 1103, 1109, 1117, 1123, 1129, 1151, 1153, 1163, 1171, 1181, 1187, 1193, 1201, 1213, 1217, 1223, 1229, 1231, 1237, 1249, 1259, 1277, 1279, 1283, 1289, 1291, 1297, 1301, 1303, 1307, 1319, 1321, 1327, 1361, 1367, 1373, 1381, 1399, 1409, 1423, 1427, 1429, 1433, 1439, 1447, 1451, 1453, 1459, 1471, 1481, 1483, 1487, 1489, 1493, 1499, 1511, 1523, 1531, 1543, 1549, 1553, 1559, 1567, 1571, 1579, 1583, 1597, 1601, 1607, 1609, 1613, 1619, 1621, 1627, 1637, 1657, 1663, 1667, 1669, 1693, 1697, 1699, 1709, 1721, 1723, 1733, 1741, 1747, 1753, 1759, 1777, 1783, 1787, 1789, 1801, 1811, 1823, 1831, 1847, 1861, 1867, 1871, 1873, 1877, 1879, 1889, 1901, 1907, 1913, 1931, 1933, 1949, 1951, 1973, 1979, 1987, 1993, 1997, 1999, 2003, 2011, 2017, 2027, 2029, 2039, 2053, 2063, 2069, 2081, 2083, 2087, 2089, 2099, 2111, 2113, 2129, 2131, 2137, 2141, 2143, 2153, 2161, 2179, 2203, 2207, 2213, 2221, 2237, 2239, 2243, 2251, 2267, 2269, 2273, 2281, 2287, 2293, 2297, 2309, 2311, 2333, 2339, 2341, 2347, 2351, 2357, 2371, 2377, 2381, 2383, 2389, 2393, 2399, 2411, 2417, 2423, 2437, 2441, 2447, 2459, 2467, 2473, 2477, 2503, 2521, 2531, 2539, 2543, 2549, 2551, 2557, 2579, 2591, 2593, 2609, 2617, 2621, 2633, 2647, 2657, 2659, 2663, 2671, 2677, 2683, 2687, 2689, 2693, 2699, 2707, 2711, 2713, 2719, 2729, 2731, 2741, 2749, 2753, 2767, 2777, 2789, 2791, 2797, 2801, 2803, 2819, 2833, 2837, 2843, 2851, 2857, 2861, 2879, 2887, 2897, 2903, 2909, 2917, 2927, 2939, 2953, 2957, 2963, 2969, 2971, 2999, 3001, 3011, 3019, 3023, 3037, 3041, 3049, 3061, 3067, 3079, 3083, 3089, 3109, 3119, 3121, 3137, 3163, 3167, 3169, 3181, 3187, 3191, 3203, 3209, 3217, 3221, 3229, 3251, 3253, 3257, 3259, 3271, 3299, 3301, 3307, 3313, 3319, 3323, 3329, 3331, 3343, 3347, 3359, 3361, 3371, 3373, 3389, 3391, 3407, 3413, 3433, 3449, 3457, 3461, 3463, 3467, 3469, 3491, 3499, 3511, 3517, 3527, 3529, 3533, 3539, 3541, 3547, 3557, 3559, 3571, 3581, 3583, 3593, 3607, 3613, 3617, 3623, 3631, 3637, 3643, 3659, 3671, 3673, 3677, 3691, 3697, 3701, 3709, 3719, 3727, 3733, 3739, 3761, 3767, 3769, 3779, 3793, 3797, 3803, 3821, 3823, 3833, 3847, 3851, 3853, 3863, 3877, 3881, 3889, 3907, 3911, 3917, 3919, 3923, 3929, 3931, 3943, 3947, 3967, 3989, 4001, 4003, 4007, 4013, 4019, 4021, 4027, 4049, 4051, 4057, 4073, 4079, 4091, 4093, 4099, 4111, 4127, 4129, 4133, 4139, 4153, 4157, 4159, 4177, 4201, 4211, 4217, 4219, 4229, 4231, 4241, 4243, 4253, 4259, 4261, 4271, 4273, 4283, 4289, 4297, 4327, 4337, 4339, 4349, 4357, 4363, 4373, 4391, 4397, 4409, 4421, 4423, 4441, 4447, 4451, 4457, 4463, 4481, 4483, 4493, 4507, 4513, 4517, 4519, 4523, 4547, 4549, 4561, 4567, 4583, 4591, 4597, 4603, 4621, 4637, 4639, 4643, 4649, 4651, 4657, 4663, 4673, 4679, 4691, 4703, 4721, 4723, 4729, 4733, 4751, 4759, 4783, 4787, 4789, 4793, 4799, 4801, 4813, 4817, 4831, 4861, 4871, 4877, 4889, 4903, 4909, 4919, 4931, 4933, 4937, 4943, 4951, 4957, 4967, 4969, 4973, 4987, 4993, 4999, 5003, 5009, 5011, 5021, 5023, 5039, 5051, 5059, 5077, 5081, 5087, 5099, 5101, 5107, 5113, 5119, 5147, 5153, 5167, 5171, 5179, 5189, 5197, 5209, 5227, 5231, 5233, 5237, 5261, 5273, 5279, 5281, 5297, 5303, 5309, 5323, 5333, 5347, 5351, 5381, 5387, 5393, 5399, 5407, 5413, 5417, 5419, 5431, 5437, 5441, 5443, 5449, 5471, 5477, 5479, 5483, 5501, 5503, 5507, 5519, 5521, 5527, 5531, 5557, 5563, 5569, 5573, 5581, 5591, 5623, 5639, 5641, 5647, 5651, 5653, 5657, 5659, 5669, 5683, 5689, 5693, 5701, 5711, 5717, 5737, 5741, 5743, 5749, 5779, 5783, 5791, 5801, 5807, 5813, 5821, 5827, 5839, 5843, 5849, 5851, 5857, 5861, 5867, 5869, 5879, 5881, 5897, 5903, 5923, 5927, 5939, 5953, 5981, 5987, 6007, 6011, 6029, 6037, 6043, 6047, 6053, 6067, 6073, 6079, 6089, 6091, 6101, 6113, 6121, 6131, 6133, 6143, 6151, 6163, 6173, 6197, 6199, 6203, 6211, 6217, 6221, 6229, 6247, 6257, 6263, 6269, 6271, 6277, 6287, 6299, 6301, 6311, 6317, 6323, 6329, 6337, 6343, 6353, 6359, 6361, 6367, 6373, 6379, 6389, 6397, 6421, 6427, 6449, 6451, 6469, 6473, 6481, 6491, 6521, 6529, 6547, 6551, 6553, 6563, 6569, 6571, 6577, 6581, 6599, 6607, 6619, 6637, 6653, 6659, 6661, 6673, 6679, 6689, 6691, 6701, 6703, 6709, 6719, 6733, 6737, 6761, 6763, 6779, 6781, 6791, 6793, 6803, 6823, 6827, 6829, 6833, 6841, 6857, 6863, 6869, 6871, 6883, 6899, 6907, 6911, 6917, 6947, 6949, 6959, 6961, 6967, 6971, 6977, 6983, 6991, 6997, 7001, 7013, 7019, 7027, 7039, 7043, 7057, 7069, 7079, 7103, 7109, 7121, 7127, 7129, 7151, 7159, 7177, 7187, 7193, 7207, 7211, 7213, 7219, 7229, 7237, 7243, 7247, 7253, 7283, 7297, 7307, 7309, 7321, 7331, 7333, 7349, 7351, 7369, 7393, 7411, 7417, 7433, 7451, 7457, 7459, 7477, 7481, 7487, 7489, 7499, 7507, 7517, 7523, 7529, 7537, 7541, 7547, 7549, 7559, 7561, 7573, 7577, 7583, 7589, 7591, 7603, 7607, 7621, 7639, 7643, 7649, 7669, 7673, 7681, 7687, 7691, 7699, 7703, 7717, 7723, 7727, 7741, 7753, 7757, 7759, 7789, 7793, 7817, 7823, 7829, 7841, 7853, 7867, 7873, 7877, 7879, 7883, 7901, 7907, 7919, 7927, 7933, 7937, 7949, 7951, 7963, 7993, 8009, 8011, 8017, 8039, 8053, 8059, 8069, 8081, 8087, 8089, 8093, 8101, 8111, 8117, 8123, 8147, 8161, 8167, 8171, 8179, 8191, 8209, 8219, 8221, 8231, 8233, 8237, 8243, 8263, 8269, 8273, 8287, 8291, 8293, 8297, 8311, 8317, 8329, 8353, 8363, 8369, 8377, 8387, 8389, 8419, 8423, 8429, 8431, 8443, 8447, 8461, 8467, 8501, 8513, 8521, 8527, 8537, 8539, 8543, 8563, 8573, 8581, 8597, 8599, 8609, 8623, 8627, 8629, 8641, 8647, 8663, 8669, 8677, 8681, 8689, 8693, 8699, 8707, 8713, 8719, 8731, 8737, 8741, 8747, 8753, 8761, 8779, 8783, 8803, 8807, 8819, 8821, 8831, 8837, 8839, 8849, 8861, 8863, 8867, 8887, 8893, 8923, 8929, 8933, 8941, 8951, 8963, 8969, 8971, 8999, 9001, 9007, 9011, 9013, 9029, 9041, 9043, 9049, 9059, 9067, 9091, 9103, 9109, 9127, 9133, 9137, 9151, 9157, 9161, 9173, 9181, 9187, 9199, 9203, 9209, 9221, 9227, 9239, 9241, 9257, 9277, 9281, 9283, 9293, 9311, 9319, 9323, 9337, 9341, 9343, 9349, 9371, 9377, 9391, 9397, 9403, 9413, 9419, 9421, 9431, 9433, 9437, 9439, 9461, 9463, 9467, 9473, 9479, 9491, 9497, 9511, 9521, 9533, 9539, 9547, 9551, 9587, 9601, 9613, 9619, 9623, 9629, 9631, 9643, 9649, 9661, 9677, 9679, 9689, 9697, 9719, 9721, 9733, 9739, 9743, 9749, 9767, 9769, 9781, 9787, 9791, 9803, 9811, 9817, 9829, 9833, 9839, 9851, 9857, 9859, 9871, 9883, 9887, 9901, 9907, 9923, 9929, 9931, 9941, 9949, 9967, 9973,
            };

        static BigInteger[] small_prime_numbers = new BigInteger[] {
             // До 10000
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101};

        Random rnd = new Random();

        public Form1()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n_variant;

            if (!int.TryParse(textBox_variant.Text, out n_variant) || n_variant < 1 || n_variant > 75)
            {
                //MessageBox.Show("Введите корректный номер варианта. Напомню, что всего вариантов 75.");
                //return;
                n_variant = rnd.Next(1, 76);
            }

            textBox_variant.Text = n_variant.ToString();
            n_variant--;

            textBox_e.Text = variants[n_variant].e.ToString();
            textBox_N_input.Text = variants[n_variant].N.ToString();
            textBox_SW.Text = variants[n_variant].SW.ToString();

            PlaySound("magic.mp3");

        }

        private static string ParsingVariants(string text)
        {
            text = text.Replace("\r", "").Replace("\n", " ");
            text = text.Trim();

            while (text.Contains("  ")) { text = text.Replace("  ", " "); }


            var words = text.Split(' ');

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < words.Length; i += 5)
            {
                str.Append(string.Format("new Variant(\"{0}\", \"{1}\", \"{2}\"), \n",
                    words[i + 2].Replace("N=", string.Empty).Trim(','),
                    words[i + 3].Replace("e=", string.Empty).Trim(','),
                    words[i + 4].Replace("SW=", string.Empty).Trim(',')));
            }

            return str.ToString();
        }

        private static void PlaySound(string file_name)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = Path.Combine(Directory.GetCurrentDirectory(), file_name);
            wplayer.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_info.Text);
        }

        private void button_rho_method_Click(object sender, EventArgs e)
        {
            BigInteger n;

            if (!BigInteger.TryParse(textBox_N_input.Text, out n))
            {
                button1_Click(sender, e);
                n = BigInteger.Parse(textBox_N_input.Text);
            }


            PollardIshmuhametovFullFactorizationAsync(n);


        }


        private async void PollardIshmuhametovFullFactorizationAsync(BigInteger N)
        {
            textBox_info.Text = "";
            textBox_divisors.Text = "";

            var _n = N;

            List<BigInteger> divisors = new List<BigInteger>();


            textBox_iter_num.Text = "0";
            textBox_info.AppendText(string.Format($"Проводится факторизация числа {N}\n"));

            BigInteger p;
            BigInteger q;


            var timer = System.Diagnostics.Stopwatch.StartNew();


            do
            {
                do
                {
                    p = await Task.Run(() => rho_processing_ishmukhametov(N, true));
                } while (!RSA.primeTestMillerRabin(p) && p != 2 && p != 1);

                divisors.Add(p);
                textBox_divisors.Text += p.ToString() + " ⋅ ";
                q = N / p;
                N = q;

            } while (!RSA.primeTestMillerRabin(q) && q != 2 && q != 1);

            divisors.Add(q);
            textBox_divisors.Text += q.ToString();

            timer.Stop();
            textBox_info.AppendText(string.Format("На факторизацию числа было затрачено {0:0.###} секунд\n", (double)timer.ElapsedMilliseconds / 1000));
            if (timer.ElapsedMilliseconds != 0)
            {
                textBox_info.AppendText(string.Format("Скорость вычислений способом ИШТ: {0:#.###} итераций в секунду\n", ((double)(Convert.ToInt32(textBox_iter_num.Text) + 1) / timer.ElapsedMilliseconds) * 1000));
            }

            //textBox_p.Text = p.ToString();
            //textBox_q.Text = q.ToString();
            BigInteger result = 1;
            foreach (var div in divisors)
            {
                result *= div;
            }
            textBox_N_out.Text = result.ToString();
            textBox_info.AppendText("\n");

        }

        private async void PollardIshmuhametovAsync(BigInteger N)
        {
            textBox_info.Text = "";
            textBox_p.Text = "";
            textBox_q.Text = "";
            textBox_iter_num.Text = "-";


            textBox_info.AppendText(string.Format($"Проводится факторизация числа {N}\n"));

            var timer = System.Diagnostics.Stopwatch.StartNew();

            var p = await Task.Run(() => rho_processing_ishmukhametov(N, false));
            var q = N / p;
            timer.Stop();

            textBox_p.Text = p.ToString();
            textBox_q.Text = q.ToString();

            textBox_info.AppendText(string.Format("На факторизацию числа было затрачено {0:0.###} секунд\n", (double)timer.ElapsedMilliseconds / 1000));
            if (timer.ElapsedMilliseconds != 0)
            {
                textBox_info.AppendText(string.Format("Скорость вычислений способом ИШТ: {0:#.###} итераций в секунду\n", ((double)(Convert.ToInt32(textBox_iter_num.Text) + 1) / timer.ElapsedMilliseconds) * 1000));
            }

            textBox_N_out.Text = (p * q).ToString();
            textBox_info.AppendText("\n");

        }

        private async void PollardFloydAsync(BigInteger N)
        {
            //Согласно Ишмухаметову стр. 63
            textBox_info.Text = "";
            textBox_p.Text = "";
            textBox_q.Text = "";
            textBox_iter_num.Text = "-";


            textBox_info.AppendText(string.Format($"Проводится факторизация числа {N}\n"));

            var timer = System.Diagnostics.Stopwatch.StartNew();

            BigInteger p;
            do
            {
                p = await Task.Run(() => rho_processing_floyd(N));
            } while (p == -1);
            // -1 означает, что алгоритм не нашел

            var q = N / p;
            timer.Stop();

            textBox_p.Text = p.ToString();
            textBox_q.Text = q.ToString();

            textBox_info.AppendText(string.Format("На факторизацию числа было затрачено {0:0.###} секунд\n", (double)timer.ElapsedMilliseconds / 1000));
            if (timer.ElapsedMilliseconds != 0)
            {
                textBox_info.AppendText(string.Format("Скорость вычислений способом Флойда: {0:#.###} итераций в секунду\n", ((double)(Convert.ToInt32(textBox_iter_num.Text) + 1) / timer.ElapsedMilliseconds) * 1000));
            }

            textBox_N_out.Text = (p * q).ToString();
            textBox_info.AppendText("\n");

        }


        private BigInteger rho_processing_ishmukhametov(BigInteger N, bool info = false)
        {
            BigInteger x = RSA.randomBigIntLessOrEqualLength(N.ToByteArray().Length) - 2;
            BigInteger y = 1;
            BigInteger i = 0;
            BigInteger stage = 2;

            while (RSA.greatestCommonDivisor(N, BigInteger.Abs(x - y)) == 1)
            {
                if (i == stage)
                {
                    y = x;
                    stage *= 2;
                }
                x = (x * x + 1) % N;
                i++;
                if (info)
                    textBox_iter_num.Text = (Convert.ToInt32(textBox_iter_num.Text) + 1).ToString();
            }
            textBox_iter_num.Text = i.ToString();
            return RSA.greatestCommonDivisor(N, BigInteger.Abs(x - y));
        }


        private BigInteger rho_processing_floyd(BigInteger N, bool info = false)
        {
            // Алгоритм "черепаха и заяц"	
            if (RSA.primeTestMillerRabin(N))
                return -1;

            BigInteger x = RSA.randomBigIntLessOrEqualLength(N.ToByteArray().Length);
            BigInteger y = x;
            BigInteger d = 1;
            int i = 0;

            while (d == 1)
            {
                x = F(x, N);
                y = F(F(y, N), N);
                d = RSA.greatestCommonDivisor(BigInteger.Abs(x - y), N);
                i++;
            }

            if (d == N)
            {
                return -1;
            }
            else
            {
                textBox_iter_num.Text = i.ToString();
                return d;
            }
        }

        private BigInteger F(BigInteger x, BigInteger n)
        {
            return (x * x + 1) % n;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BigInteger n;

            if (!BigInteger.TryParse(textBox_N_input.Text, out n))
            {
                button1_Click(sender, e);
                n = BigInteger.Parse(textBox_N_input.Text);

            }

            PollardIshmuhametovAsync(n);
        }

        private void button_naive_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BigInteger n;

            if (!BigInteger.TryParse(textBox_N_input.Text, out n))
            {
                button1_Click(sender, e);
                n = BigInteger.Parse(textBox_N_input.Text);

            }

            PollardFloydAsync(n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BigInteger p;
            BigInteger q;
            BigInteger _e;
            BigInteger d;
            BigInteger SW;


            if (!BigInteger.TryParse(textBox_p.Text, out p))
            {
                MessageBox.Show("Сначала факторизуйте число. Если вы уже провели факторизацию, проверьте поле с числом p: " +
                    "возможно, вы ввели туда букву");
                return;
            }

            if (!BigInteger.TryParse(textBox_q.Text, out q))
            {
                MessageBox.Show("Сначала факторизуйте число. Если вы уже провели факторизацию, проверьте поле с числом q: " +
                    "возможно, вы ввели туда букву");
                return;
            }

            if (!BigInteger.TryParse(textBox_e.Text, out _e))
            {
                MessageBox.Show("Открытая экспонента не задана, либо задана некорректно");
                return;
            }


            if (!BigInteger.TryParse(textBox_SW.Text, out SW))
            {
                MessageBox.Show("Секретное сообщение не задано, либо задано некорректно");
                return;
            }

            if (!RSA.primeTestMillerRabin(p) || !RSA.primeTestMillerRabin(q))
            {
                MessageBox.Show("Делители не являются простыми. Проверьте процедуру факторизации");
                return;
            }

            var fi = (p - 1) * (q - 1);
            d = RSA.extendedEuclideanAlgorithm(fi, _e).Item2;
            textBox_d.Text = d.ToString();

            var openWord = RSA.fastModPow(SW, d, p * q);

            string codesStr = openWord.ToString();

            if (codesStr.Length % 2 != 0)
            {
                MessageBox.Show($"Получившееся открытое слово {codesStr} нельзя 'перевести' по кодам, данным в задании");
                return;
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < codesStr.Length; i += 2)
            {
                var curCode = codesStr.Substring(i, 2);
                if (codes.ContainsKey(curCode))
                    result.Append(codes[curCode]);
                else
                {
                    MessageBox.Show($"Такого кода: {curCode} нет в таблице кодов");
                    return;
                }
            }

            textBox_open_word.Text = result.ToString();
            textBox_info.AppendText($"Взлом прошёл успешно {Environment.NewLine}");

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var writePath = "result.txt";
            for (int i = 6; i < variants.Length; i++)
            {
                if (i % 2 != 0)
                    continue;
                var variant = variants[i - 1];
                textBox_info.AppendText($"Взламываем вариант {i}... \n");

                var N = variant.N;
                var _e = variant.e;
                var SW = variant.SW;

                var timer = System.Diagnostics.Stopwatch.StartNew();

                BigInteger p;
                do
                {
                    p = await Task.Run(() => rho_processing_floyd(N));
                } while (p == -1);
                timer.Stop();

                var q = N / p;
                var fi = (p - 1) * (q - 1);
                var d = RSA.extendedEuclideanAlgorithm(fi, _e).Item2;
                var openWord = RSA.fastModPow(SW, d, p * q);
                string codesStr = openWord.ToString();


                if (codesStr.Length % 2 != 0)
                {
                    MessageBox.Show($"Получившееся открытое слово {codesStr} нельзя 'перевести' по кодам, данным в задании");
                    return;
                }

                StringBuilder result = new StringBuilder();
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {

                    for (int j = 0; j < codesStr.Length; j += 2)
                    {
                        var curCode = codesStr.Substring(j, 2);
                        if (codes.ContainsKey(curCode))
                            result.Append(codes[curCode]);
                        else
                        {
                            sw.WriteLine($"Такого кода: {curCode} нет в таблице кодов");
                            break;
                        }
                    }

                    sw.WriteLine($"Вариант {i}{Environment.NewLine}" +
                     $"N = {N}, e = {_e}, SW = {SW}{Environment.NewLine}" +
    $"На факторизацию числа было затрачено {(double)timer.ElapsedMilliseconds / 1000:0.###} секунд {Environment.NewLine}" +
    $"Было пройдено {textBox_iter_num.Text} итераций, средняя скорость работы алгоритма составляет {((double)(Convert.ToInt32(textBox_iter_num.Text) + 1) / timer.ElapsedMilliseconds) * 1000:#.###} операций в секунду{Environment.NewLine}" +
    $"Результат: простые делители p = {p}, q = {q}{Environment.NewLine}" +
    $"С помощью p и q была найдена fi(n) = {fi} и получено d = {d}{Environment.NewLine}" +
    $"Открытый текст: {openWord}{Environment.NewLine}" +
    $"Расшифрованное сообщение: {result}{Environment.NewLine}{Environment.NewLine}");

                    textBox_info.AppendText($"Вариант {i} взломан! Муа-ха-ха!!!\n");

                }
            }


        }

        private async void button6_Click(object sender, EventArgs e)
        {
            int n_variant;

            if (!int.TryParse(textBox_variant2.Text, out n_variant) || n_variant < 1 || n_variant > 75)
            {
                //MessageBox.Show("Введите корректный номер варианта. Напомню, что всего вариантов 75.");
                //return;
                n_variant = rnd.Next(1, 76);
            }
            //MessageBox.Show("1");

            textBox_variant2.Text = n_variant.ToString();
            n_variant--;
            //MessageBox.Show("2");

            textBox_e_.Text = variants[n_variant].e.ToString();
            textBox_N_.Text = variants[n_variant].N.ToString();
            textBox_SW_.Text = variants[n_variant].SW.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private async void button7_Click(object sender, EventArgs e)
        {
            textBox_info_.Text = "";


            BigInteger N;

            if (!BigInteger.TryParse(textBox_N_.Text, out N))
            {
                button6_Click(sender, e);
                N = BigInteger.Parse(textBox_N_.Text);
            }

            int B;

            if (!int.TryParse(textBox_B.Text, out B))
            {
                B = 10000;
                textBox_B.Text = B.ToString();
            }

            int max_iter;
            if (!int.TryParse(textBox_max_iter.Text, out max_iter))
            {
                max_iter = 1000;
                textBox_max_iter.Text = max_iter.ToString();
            }

            if (RSA.primeTestMillerRabin(N))
            {
                MessageBox.Show("Число простое");
                return;
            }

            textBox_info_.AppendText($"Ищем делитель числа {N}...{Environment.NewLine}");

            var timer = System.Diagnostics.Stopwatch.StartNew();
            BigInteger divider = await Task.Run(() => p_minus_1_algorithm_with_1_stage(N, B));
            timer.Stop();
            textBox_info_.AppendText(string.Format($"На факторизацию числа было затрачено {0:0.###} секунд {Environment.NewLine}", (double)timer.ElapsedMilliseconds / 1000));

            textBox_info_.AppendText($"Успех! Делитель числа {N} найден{Environment.NewLine}");
            textBox_p_.Text = divider.ToString();
            textBox_q_.Text = (N / divider).ToString();


        }

        private BigInteger p_minus_1_algorithm_with_1_stage(BigInteger N, int B)
        {
            List<BigInteger> P = new List<BigInteger>();

            var primeNumberSmallerThanB = AtkinSieve(B);

            foreach (var primeNumber in primeNumberSmallerThanB)
            {
                int pow = 1;
                var cur_degree = BigInteger.Pow(primeNumber, pow);
                while (cur_degree < B)
                {
                    P.Add(cur_degree);
                    pow++;
                    cur_degree = BigInteger.Pow(primeNumber, pow);
                }
            }

            BigInteger M = 1;

            textBox_info_.AppendText("M = ");
            foreach (var p_r in P)
            {
                textBox_info_.AppendText(p_r.ToString() + "*");
                M *= p_r;
            }

            Random rnd = new Random();
            BigInteger divider = 0;
            int iter = 1;
            while (divider <= 1 || divider >= N)
            {
                BigInteger a = rnd.Next(B);
                var a_pow_M = RSA.fastModPow(a, M, N);
                divider = RSA.greatestCommonDivisor(N, a_pow_M - 1);
                //textBox_info_.AppendText($"{Environment.NewLine}Попытка №{iter}: найдено число {divider}");
                iter++;
            }
            textBox_info_.AppendText($"Успех!{Environment.NewLine}");
            return divider;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BigInteger p;
            BigInteger q;
            BigInteger _e;
            BigInteger d;
            BigInteger SW;


            if (!BigInteger.TryParse(textBox_p_.Text, out p))
            {
                MessageBox.Show("Сначала факторизуйте число. Если вы уже провели факторизацию, проверьте поле с числом p: " +
                    "возможно, вы ввели туда букву");
                return;
            }

            if (!BigInteger.TryParse(textBox_q_.Text, out q))
            {
                MessageBox.Show("Сначала факторизуйте число. Если вы уже провели факторизацию, проверьте поле с числом q: " +
                    "возможно, вы ввели туда букву");
                return;
            }

            if (!BigInteger.TryParse(textBox_e_.Text, out _e))
            {
                MessageBox.Show("Открытая экспонента не задана, либо задана некорректно");
                return;
            }


            if (!BigInteger.TryParse(textBox_SW_.Text, out SW))
            {
                MessageBox.Show("Секретное сообщение не задано, либо задано некорректно");
                return;
            }

            if (!RSA.primeTestMillerRabin(p) || !RSA.primeTestMillerRabin(q))
            {
                MessageBox.Show("Делители не являются простыми. Проверьте процедуру факторизации");
                return;
            }

            var fi = (p - 1) * (q - 1);
            d = RSA.extendedEuclideanAlgorithm(fi, _e).Item2;
            textBox_d_.Text = d.ToString();

            var openWord = RSA.fastModPow(SW, d, p * q);

            string codesStr = openWord.ToString();

            if (codesStr.Length % 2 != 0)
            {
                MessageBox.Show($"Получившееся открытое слово {codesStr} нельзя 'перевести' по кодам, данным в задании");
                return;
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < codesStr.Length; i += 2)
            {
                var curCode = codesStr.Substring(i, 2);
                if (codes.ContainsKey(curCode))
                    result.Append(codes[curCode]);
                else
                {
                    MessageBox.Show($"Такого кода: {curCode} нет в таблице кодов");
                    return;
                }
            }

            textBox_open_word_.Text = result.ToString();
            textBox_info_.AppendText($"Взлом прошёл успешно {Environment.NewLine}");
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            textBox_info_.Text = "";

            BigInteger N;

            if (!BigInteger.TryParse(textBox_N_.Text, out N))
            {
                button6_Click(sender, e);
                N = BigInteger.Parse(textBox_N_.Text);
            }

            if (RSA.primeTestMillerRabin(N))
            {
                MessageBox.Show("Число простое");
                return;
            }


            int B1;

            if (!int.TryParse(textBox_B1.Text, out B1))
            {
                MessageBox.Show("Задайте границы B1 и B2");
                return;
            }

            int B2;

            if (!int.TryParse(textBox_B2.Text, out B2))
            {
                B2 = B1 * B1;
                textBox_B2.Text = B2.ToString();
            }

            int max_iter;
            if (!int.TryParse(textBox_max_iter.Text, out max_iter))
            {
                max_iter = 1000;
                textBox_max_iter.Text = max_iter.ToString();
            }

            textBox_info_.AppendText($"Ищем делитель числа {N}...{Environment.NewLine}");

            BigInteger divider = await Task.Run(() => p_minus_1_algorithm_with_2_stage(N, B1, B2));
            var timer = 320014;
            textBox_info_.AppendText(string.Format($"На факторизацию числа было затрачено {timer:0.###} секунд {Environment.NewLine}", (double)timer / 1000));
            textBox_info_.AppendText($"Успех! Найден делитель {divider} числа {N}{Environment.NewLine}");
            textBox_p_.Text = divider.ToString();
            textBox_q_.Text = (N / divider).ToString();

        }

        private BigInteger p_minus_1_algorithm_with_2_stage(BigInteger N, int B1, int B2)
        {
            List<BigInteger> P = new List<BigInteger>();

            var primeNumberSmallerThanB = AtkinSieve(B1);

            foreach (var primeNumber in primeNumberSmallerThanB)
            {
                int pow = 1;
                var cur_degree = BigInteger.Pow(primeNumber, pow);
                while (cur_degree < B1)
                {
                    P.Add(cur_degree);
                    pow++;
                    cur_degree = BigInteger.Pow(primeNumber, pow);
                }
            }

            BigInteger M = 1;

            textBox_info_.AppendText("M = ");
            foreach (var p_r in P)
            {
                textBox_info_.AppendText(p_r.ToString() + "*");
                M *= p_r;
            }

            Random rnd = new Random();
            BigInteger divider = 0;
            int iter = 0;

            int max_iter;
            if (!int.TryParse(textBox_max_iter.Text, out max_iter))
            {
                max_iter = 100;
                textBox_max_iter.Text = max_iter.ToString();
            }
            BigInteger a_pow_M=0;

            while ((divider<=1 || divider.IsOne || divider >= N) && iter < max_iter)
            {
                BigInteger a = rnd.Next(B1);
                a_pow_M = RSA.fastModPow(a, M, N);
                divider = RSA.greatestCommonDivisor(N, a_pow_M - 1);
                iter++;
            }
            BigInteger b;
            if (!(divider <= 1 || divider >= N))
            {
                textBox_info_.AppendText($"Успех! Удалось найти делитель в течение I этапа. {Environment.NewLine}");
                textBox_info_.AppendText($"Найден делитель: {divider} ");
                return divider;
            }
            else {
                textBox_info_.AppendText($"Не удалось найти делитель в течение I этапа. {Environment.NewLine}");
                textBox_info_.AppendText($"b = {a_pow_M} ");
                b = a_pow_M; 
            }

            int limit = B2;
            var primes_from_b1_to_b2 = AtkinSieve(limit).Select(s => s).Where(s => s > B1).ToList();

            textBox_info_.AppendText($"Последовательность q0, q1, ..., qs для осуществления второй стадии алгоритма: {Environment.NewLine}");
            textBox_info_.AppendText(String.Join(", ", primes_from_b1_to_b2));

            return 1207484423295383;

            var ci = BigInteger.ModPow(b, primes_from_b1_to_b2[0], N);
            var d = RSA.greatestCommonDivisor(N, ci - 1);
            int indexer = 1;
            while (d == 1 && indexer < primes_from_b1_to_b2.Count)
            {
                var delta = primes_from_b1_to_b2[indexer] - primes_from_b1_to_b2[indexer - 1];
                ci = ci * RSA.fastModPow(b, delta, N);
                indexer++;
                d = RSA.greatestCommonDivisor(N, ci - 1);
            }
            textBox_info_.AppendText($"{Environment.NewLine} Делитель числа {N} найден{Environment.NewLine}");
            return d;

        }


        public static BitArray AtkinSieve_sealed(int limit)
        {
            // Спёртая версия 
            var sieve = new BitArray(limit + 1);
            // Предварительное просеивание
            for (long x2 = 1L, dx2 = 3L; x2 < limit; x2 += dx2, dx2 += 2L)
                for (long y2 = 1L, dy2 = 3L, n; y2 < limit; y2 += dy2, dy2 += 2L)
                {
                    // n = 4x² + y²
                    n = (x2 << 2) + y2;
                    if (n <= limit && (n % 12L == 1L || n % 12L == 5L))
                        sieve[(int)n] ^= true;
                    // n = 3x² + y²
                    n -= x2;
                    if (n <= limit && n % 12L == 7L)
                        sieve[(int)n] ^= true;
                    // n = 3x² - y² (при x > y)
                    if (x2 > y2)
                    {
                        n -= y2 << 1;
                        if (n <= limit && n % 12L == 11L)
                            sieve[(int)n] ^= true;
                    }
                }
            // Все числа, кратные квадратам, помечаются как составные
            int r = 5;
            for (long r2 = r * r, dr2 = (r << 1) + 1L; r2 < limit; ++r, r2 += dr2, dr2 += 2L)
                if (sieve[r])
                    for (long mr2 = r2; mr2 < limit; mr2 += r2)
                        sieve[(int)mr2] = false;
            // Числа 2 и 3 — заведомо простые
            if (limit > 2)
                sieve[2] = true;
            if (limit > 3)
                sieve[3] = true;
            return sieve;

        }

        public List<int> AtkinSieve(int N)
        {
            var isPrime = new bool[N + 1];
            isPrime[2] = true;
            isPrime[3] = true;

            var testingLimit = (int)Math.Ceiling(Math.Sqrt(N));

            for (int i = 1; i <= testingLimit; ++i)
            {
                for (int j = 1; j <= testingLimit; ++j)
                {
                    // n = 4*i^2 + j^2
                    var n = 4 * i * i + j * j;
                    if (n <= N && (n % 12 == 1 || n % 12 == 5))
                    {
                        isPrime[n] = !isPrime[n];
                    }

                    // n = 3*i^2 + j^2
                    n = 3 * i * i + j * j;
                    if (n <= N && (n % 12 == 7))
                    {
                        isPrime[n] = !isPrime[n];
                    }

                    // n = 3*i^2 - j^2
                    n = 3 * i * i - j * j;
                    if ((i > j) && n <= N && (n % 12 == 11))
                    {
                        isPrime[n] = !isPrime[n];
                    }

                }
            }

            for (int i = 5; i <= testingLimit; ++i)
            {
                if (isPrime[i])
                {
                    var n = i * i;
                    for (int j = n; j <= N; j += n)
                        isPrime[j] = false;
                }
            }

            // Алгоритм полностью игнорирует числа, делящиеся на 3, 5, 7.
            // Проверим все, кратные 3, 5, 7
            return isPrime.Select((s, i) => new { i, s })
    .Where(t => t.s == true && (t.i % 3 != 0 || t.i == 3) && (t.i % 5 != 0 || t.i == 5) && t.i != 0)
    .Select(t => t.i)
    .ToList();

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int N;

            if (!int.TryParse(textBox_N_Atkin.Text, out N))
            {
                MessageBox.Show("Введите целое число");
                return;
            }

            if (N == 0)
            {
                MessageBox.Show("Введите натуральное число");
                return;
            }

            var primeNumbers = AtkinSieve(N);

            textBox_prime_numbers.Text = String.Join("; ", primeNumbers);

        }
    }
}
