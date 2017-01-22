using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class Solution2
    {
        static void Main(string[] args)
        {
            Solution2 pro = new Solution2();
            pro.test();
        }
        void test()
        {
            int mp = MaxProfit(new int[] { 1, 7, 8, 6, 7, 8 });

            List<string> dic = new List<string> { "leet", "code" };
            HashSet<string> hs = new HashSet<string>(dic);
            bool bWB = WordBreak("leetcode", hs);

            dic = new List<string> { "leet", "code" };
            hs = new HashSet<string>(dic);
            bWB = WordBreak("leet1code", hs);


            dic = new List<string> { "aaaa", "aa" };
            hs = new HashSet<string>(dic);
            bWB = WordBreak("aaaaaaa", hs);

            dic = new List<string> { "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaa" };
            hs = new HashSet<string>(dic);
            bWB = WordBreak("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", hs);

            var rw = ReverseWords("the sky is blue");
            rw = ReverseWords("a  b ");

            var sb = new StringBuilder(" tu  hai");
            ShiftBlank(sb);


            sb = new StringBuilder(" tu  hai   ");
            ShiftBlank(sb);


            sb = new StringBuilder(" a  aa   ");
            ShiftBlank(sb);

            sb = new StringBuilder(" a  a   ");
            ShiftBlank(sb);

            sb = new StringBuilder(" a    a");
            ShiftBlank(sb);

            var wpr = WordPattern("abba", "dog cat cat dog");
            wpr = WordPattern("abba", "dog cat1 cat dog");
            wpr = WordPattern("abba", "dog dog dog dog");

            wpr = WordPattern("ab", "dog dog");

            wpr = WordPattern("abba", "dog cat cat fish");


            dic = new List<string> { "hot", "dot", "dog", "lot", "log" };
            hs = new HashSet<string>(dic);
            var llResult = LadderLength("hit", "cog", hs);


            dic = new List<string> { "si", "go", "se", "cm", "so", "ph", "mt", "db", "mb", "sb", "kr", "ln", "tm", "le", "av", "sm", "ar", "ci", "ca", "br", "ti", "ba", "to", "ra", "fa", "yo", "ow", "sn", "ya", "cr", "po", "fe", "ho", "ma", "re", "or", "rn", "au", "ur", "rh", "sr", "tc", "lt", "lo", "as", "fr", "nb", "yb", "if", "pb", "ge", "th", "pm", "rb", "sh", "co", "ga", "li", "ha", "hz", "no", "bi", "di", "hi", "qa", "pi", "os", "uh", "wm", "an", "me", "mo", "na", "la", "st", "er", "sc", "ne", "mn", "mi", "am", "ex", "pt", "io", "be", "fm", "ta", "tb", "ni", "mr", "pa", "he", "lr", "sq", "ye" };
            hs = new HashSet<string>(dic);
            llResult = LadderLength("qa", "sq", hs);


            //3
            dic = new List<string> { "talk", "tons", "fall", "tail", "gale", "hall", "negs" };
            hs = new HashSet<string>(dic);
            llResult = LadderLength("talk", "tail", hs);//talk 

            //3
            dic = new List<string> { "frye", "heat", "tree", "thee", "game", "free", "hell", "fame", "faye" };
            hs = new HashSet<string>(dic);
            llResult = LadderLength("game", "thee", hs);

            //3
            dic = new List<string> { "miss", "dusk", "kiss", "musk", "tusk", "diss", "disk", "sang", "ties", "muss" };
            hs = new HashSet<string>(dic);
            llResult = LadderLength("kiss", "tusk", hs);//kiss  tusk

            //
            dic = new List<string> { "kid", "tag", "pup", "ail", "tun", "woo", "erg", "luz", "brr", "gay", "sip", "kay", "per", "val", "mes", "ohs", "now", "boa", "cet", "pal", "bar", "die", "war", "hay", "eco", "pub", "lob", "rue", "fry", "lit", "rex", "jan", "cot", "bid", "ali", "pay", "col", "gum", "ger", "row", "won", "dan", "rum", "fad", "tut", "sag", "yip", "sui", "ark", "has", "zip", "fez", "own", "ump", "dis", "ads", "max", "jaw", "out", "btu", "ana", "gap", "cry", "led", "abe", "box", "ore", "pig", "fie", "toy", "fat", "cal", "lie", "noh", "sew", "ono", "tam", "flu", "mgm", "ply", "awe", "pry", "tit", "tie", "yet", "too", "tax", "jim", "san", "pan", "map", "ski", "ova", "wed", "non", "wac", "nut", "why", "bye", "lye", "oct", "old", "fin", "feb", "chi", "sap", "owl", "log", "tod", "dot", "bow", "fob", "for", "joe", "ivy", "fan", "age", "fax", "hip", "jib", "mel", "hus", "sob", "ifs", "tab", "ara", "dab", "jag", "jar", "arm", "lot", "tom", "sax", "tex", "yum", "pei", "wen", "wry", "ire", "irk", "far", "mew", "wit", "doe", "gas", "rte", "ian", "pot", "ask", "wag", "hag", "amy", "nag", "ron", "soy", "gin", "don", "tug", "fay", "vic", "boo", "nam", "ave", "buy", "sop", "but", "orb", "fen", "paw", "his", "sub", "bob", "yea", "oft", "inn", "rod", "yam", "pew", "web", "hod", "hun", "gyp", "wei", "wis", "rob", "gad", "pie", "mon", "dog", "bib", "rub", "ere", "dig", "era", "cat", "fox", "bee", "mod", "day", "apr", "vie", "nev", "jam", "pam", "new", "aye", "ani", "and", "ibm", "yap", "can", "pyx", "tar", "kin", "fog", "hum", "pip", "cup", "dye", "lyx", "jog", "nun", "par", "wan", "fey", "bus", "oak", "bad", "ats", "set", "qom", "vat", "eat", "pus", "rev", "axe", "ion", "six", "ila", "lao", "mom", "mas", "pro", "few", "opt", "poe", "art", "ash", "oar", "cap", "lop", "may", "shy", "rid", "bat", "sum", "rim", "fee", "bmw", "sky", "maj", "hue", "thy", "ava", "rap", "den", "fla", "auk", "cox", "ibo", "hey", "saw", "vim", "sec", "ltd", "you", "its", "tat", "dew", "eva", "tog", "ram", "let", "see", "zit", "maw", "nix", "ate", "gig", "rep", "owe", "ind", "hog", "eve", "sam", "zoo", "any", "dow", "cod", "bed", "vet", "ham", "sis", "hex", "via", "fir", "nod", "mao", "aug", "mum", "hoe", "bah", "hal", "keg", "hew", "zed", "tow", "gog", "ass", "dem", "who", "bet", "gos", "son", "ear", "spy", "kit", "boy", "due", "sen", "oaf", "mix", "hep", "fur", "ada", "bin", "nil", "mia", "ewe", "hit", "fix", "sad", "rib", "eye", "hop", "haw", "wax", "mid", "tad", "ken", "wad", "rye", "pap", "bog", "gut", "ito", "woe", "our", "ado", "sin", "mad", "ray", "hon", "roy", "dip", "hen", "iva", "lug", "asp", "hui", "yak", "bay", "poi", "yep", "bun", "try", "lad", "elm", "nat", "wyo", "gym", "dug", "toe", "dee", "wig", "sly", "rip", "geo", "cog", "pas", "zen", "odd", "nan", "lay", "pod", "fit", "hem", "joy", "bum", "rio", "yon", "dec", "leg", "put", "sue", "dim", "pet", "yaw", "nub", "bit", "bur", "sid", "sun", "oil", "red", "doc", "moe", "caw", "eel", "dix", "cub", "end", "gem", "off", "yew", "hug", "pop", "tub", "sgt", "lid", "pun", "ton", "sol", "din", "yup", "jab", "pea", "bug", "gag", "mil", "jig", "hub", "low", "did", "tin", "get", "gte", "sox", "lei", "mig", "fig", "lon", "use", "ban", "flo", "nov", "jut", "bag", "mir", "sty", "lap", "two", "ins", "con", "ant", "net", "tux", "ode", "stu", "mug", "cad", "nap", "gun", "fop", "tot", "sow", "sal", "sic", "ted", "wot", "del", "imp", "cob", "way", "ann", "tan", "mci", "job", "wet", "ism", "err", "him", "all", "pad", "hah", "hie", "aim", "ike", "jed", "ego", "mac", "baa", "min", "com", "ill", "was", "cab", "ago", "ina", "big", "ilk", "gal", "tap", "duh", "ola", "ran", "lab", "top", "gob", "hot", "ora", "tia", "kip", "han", "met", "hut", "she", "sac", "fed", "goo", "tee", "ell", "not", "act", "gil", "rut", "ala", "ape", "rig", "cid", "god", "duo", "lin", "aid", "gel", "awl", "lag", "elf", "liz", "ref", "aha", "fib", "oho", "tho", "her", "nor", "ace", "adz", "fun", "ned", "coo", "win", "tao", "coy", "van", "man", "pit", "guy", "foe", "hid", "mai", "sup", "jay", "hob", "mow", "jot", "are", "pol", "arc", "lax", "aft", "alb", "len", "air", "pug", "pox", "vow", "got", "meg", "zoe", "amp", "ale", "bud", "gee", "pin", "dun", "pat", "ten", "mob" };
            hs = new HashSet<string>(dic);
            llResult = LadderLength("cet", "ism", hs);//kiss  tusk


            dic = new List<string> { "slit", "bunk", "wars", "ping", "viva", "wynn", "wows", "irks", "gang", "pool", "mock", "fort", "heel", "send", "ship", "cols", "alec", "foal", "nabs", "gaze", "giza", "mays", "dogs", "karo", "cums", "jedi", "webb", "lend", "mire", "jose", "catt", "grow", "toss", "magi", "leis", "bead", "kara", "hoof", "than", "ires", "baas", "vein", "kari", "riga", "oars", "gags", "thug", "yawn", "wive", "view", "germ", "flab", "july", "tuck", "rory", "bean", "feed", "rhee", "jeez", "gobs", "lath", "desk", "yoko", "cute", "zeus", "thus", "dims", "link", "dirt", "mara", "disc", "limy", "lewd", "maud", "duly", "elsa", "hart", "rays", "rues", "camp", "lack", "okra", "tome", "math", "plug", "monk", "orly", "friz", "hogs", "yoda", "poop", "tick", "plod", "cloy", "pees", "imps", "lead", "pope", "mall", "frey", "been", "plea", "poll", "male", "teak", "soho", "glob", "bell", "mary", "hail", "scan", "yips", "like", "mull", "kory", "odor", "byte", "kaye", "word", "honk", "asks", "slid", "hopi", "toke", "gore", "flew", "tins", "mown", "oise", "hall", "vega", "sing", "fool", "boat", "bobs", "lain", "soft", "hard", "rots", "sees", "apex", "chan", "told", "woos", "unit", "scow", "gilt", "beef", "jars", "tyre", "imus", "neon", "soap", "dabs", "rein", "ovid", "hose", "husk", "loll", "asia", "cope", "tail", "hazy", "clad", "lash", "sags", "moll", "eddy", "fuel", "lift", "flog", "land", "sigh", "saks", "sail", "hook", "visa", "tier", "maws", "roeg", "gila", "eyes", "noah", "hypo", "tore", "eggs", "rove", "chap", "room", "wait", "lurk", "race", "host", "dada", "lola", "gabs", "sobs", "joel", "keck", "axed", "mead", "gust", "laid", "ends", "oort", "nose", "peer", "kept", "abet", "iran", "mick", "dead", "hags", "tens", "gown", "sick", "odis", "miro", "bill", "fawn", "sumo", "kilt", "huge", "ores", "oran", "flag", "tost", "seth", "sift", "poet", "reds", "pips", "cape", "togo", "wale", "limn", "toll", "ploy", "inns", "snag", "hoes", "jerk", "flux", "fido", "zane", "arab", "gamy", "raze", "lank", "hurt", "rail", "hind", "hoot", "dogy", "away", "pest", "hoed", "pose", "lose", "pole", "alva", "dino", "kind", "clan", "dips", "soup", "veto", "edna", "damp", "gush", "amen", "wits", "pubs", "fuzz", "cash", "pine", "trod", "gunk", "nude", "lost", "rite", "cory", "walt", "mica", "cart", "avow", "wind", "book", "leon", "life", "bang", "draw", "leek", "skis", "dram", "ripe", "mine", "urea", "tiff", "over", "gale", "weir", "defy", "norm", "tull", "whiz", "gill", "ward", "crag", "when", "mill", "firs", "sans", "flue", "reid", "ekes", "jain", "mutt", "hems", "laps", "piss", "pall", "rowe", "prey", "cull", "knew", "size", "wets", "hurl", "wont", "suva", "girt", "prys", "prow", "warn", "naps", "gong", "thru", "livy", "boar", "sade", "amok", "vice", "slat", "emir", "jade", "karl", "loyd", "cerf", "bess", "loss", "rums", "lats", "bode", "subs", "muss", "maim", "kits", "thin", "york", "punt", "gays", "alpo", "aids", "drag", "eras", "mats", "pyre", "clot", "step", "oath", "lout", "wary", "carp", "hums", "tang", "pout", "whip", "fled", "omar", "such", "kano", "jake", "stan", "loop", "fuss", "mini", "byrd", "exit", "fizz", "lire", "emil", "prop", "noes", "awed", "gift", "soli", "sale", "gage", "orin", "slur", "limp", "saar", "arks", "mast", "gnat", "port", "into", "geed", "pave", "awls", "cent", "cunt", "full", "dint", "hank", "mate", "coin", "tars", "scud", "veer", "coax", "bops", "uris", "loom", "shod", "crib", "lids", "drys", "fish", "edit", "dick", "erna", "else", "hahs", "alga", "moho", "wire", "fora", "tums", "ruth", "bets", "duns", "mold", "mush", "swop", "ruby", "bolt", "nave", "kite", "ahem", "brad", "tern", "nips", "whew", "bait", "ooze", "gino", "yuck", "drum", "shoe", "lobe", "dusk", "cult", "paws", "anew", "dado", "nook", "half", "lams", "rich", "cato", "java", "kemp", "vain", "fees", "sham", "auks", "gish", "fire", "elam", "salt", "sour", "loth", "whit", "yogi", "shes", "scam", "yous", "lucy", "inez", "geld", "whig", "thee", "kelp", "loaf", "harm", "tomb", "ever", "airs", "page", "laud", "stun", "paid", "goop", "cobs", "judy", "grab", "doha", "crew", "item", "fogs", "tong", "blip", "vest", "bran", "wend", "bawl", "feel", "jets", "mixt", "tell", "dire", "devi", "milo", "deng", "yews", "weak", "mark", "doug", "fare", "rigs", "poke", "hies", "sian", "suez", "quip", "kens", "lass", "zips", "elva", "brat", "cosy", "teri", "hull", "spun", "russ", "pupa", "weed", "pulp", "main", "grim", "hone", "cord", "barf", "olav", "gaps", "rote", "wilt", "lars", "roll", "balm", "jana", "give", "eire", "faun", "suck", "kegs", "nita", "weer", "tush", "spry", "loge", "nays", "heir", "dope", "roar", "peep", "nags", "ates", "bane", "seas", "sign", "fred", "they", "lien", "kiev", "fops", "said", "lawn", "lind", "miff", "mass", "trig", "sins", "furl", "ruin", "sent", "cray", "maya", "clog", "puns", "silk", "axis", "grog", "jots", "dyer", "mope", "rand", "vend", "keen", "chou", "dose", "rain", "eats", "sped", "maui", "evan", "time", "todd", "skit", "lief", "sops", "outs", "moot", "faze", "biro", "gook", "fill", "oval", "skew", "veil", "born", "slob", "hyde", "twin", "eloy", "beat", "ergs", "sure", "kobe", "eggo", "hens", "jive", "flax", "mons", "dunk", "yest", "begs", "dial", "lodz", "burp", "pile", "much", "dock", "rene", "sago", "racy", "have", "yalu", "glow", "move", "peps", "hods", "kins", "salk", "hand", "cons", "dare", "myra", "sega", "type", "mari", "pelt", "hula", "gulf", "jugs", "flay", "fest", "spat", "toms", "zeno", "taps", "deny", "swag", "afro", "baud", "jabs", "smut", "egos", "lara", "toes", "song", "fray", "luis", "brut", "olen", "mere", "ruff", "slum", "glad", "buds", "silt", "rued", "gelt", "hive", "teem", "ides", "sink", "ands", "wisp", "omen", "lyre", "yuks", "curb", "loam", "darn", "liar", "pugs", "pane", "carl", "sang", "scar", "zeds", "claw", "berg", "hits", "mile", "lite", "khan", "erik", "slug", "loon", "dena", "ruse", "talk", "tusk", "gaol", "tads", "beds", "sock", "howe", "gave", "snob", "ahab", "part", "meir", "jell", "stir", "tels", "spit", "hash", "omit", "jinx", "lyra", "puck", "laue", "beep", "eros", "owed", "cede", "brew", "slue", "mitt", "jest", "lynx", "wads", "gena", "dank", "volt", "gray", "pony", "veld", "bask", "fens", "argo", "work", "taxi", "afar", "boon", "lube", "pass", "lazy", "mist", "blot", "mach", "poky", "rams", "sits", "rend", "dome", "pray", "duck", "hers", "lure", "keep", "gory", "chat", "runt", "jams", "lays", "posy", "bats", "hoff", "rock", "keri", "raul", "yves", "lama", "ramp", "vote", "jody", "pock", "gist", "sass", "iago", "coos", "rank", "lowe", "vows", "koch", "taco", "jinn", "juno", "rape", "band", "aces", "goal", "huck", "lila", "tuft", "swan", "blab", "leda", "gems", "hide", "tack", "porn", "scum", "frat", "plum", "duds", "shad", "arms", "pare", "chin", "gain", "knee", "foot", "line", "dove", "vera", "jays", "fund", "reno", "skid", "boys", "corn", "gwyn", "sash", "weld", "ruiz", "dior", "jess", "leaf", "pars", "cote", "zing", "scat", "nice", "dart", "only", "owls", "hike", "trey", "whys", "ding", "klan", "ross", "barb", "ants", "lean", "dopy", "hock", "tour", "grip", "aldo", "whim", "prom", "rear", "dins", "duff", "dell", "loch", "lava", "sung", "yank", "thar", "curl", "venn", "blow", "pomp", "heat", "trap", "dali", "nets", "seen", "gash", "twig", "dads", "emmy", "rhea", "navy", "haws", "mite", "bows", "alas", "ives", "play", "soon", "doll", "chum", "ajar", "foam", "call", "puke", "kris", "wily", "came", "ales", "reef", "raid", "diet", "prod", "prut", "loot", "soar", "coed", "celt", "seam", "dray", "lump", "jags", "nods", "sole", "kink", "peso", "howl", "cost", "tsar", "uric", "sore", "woes", "sewn", "sake", "cask", "caps", "burl", "tame", "bulk", "neva", "from", "meet", "webs", "spar", "fuck", "buoy", "wept", "west", "dual", "pica", "sold", "seed", "gads", "riff", "neck", "deed", "rudy", "drop", "vale", "flit", "romp", "peak", "jape", "jews", "fain", "dens", "hugo", "elba", "mink", "town", "clam", "feud", "fern", "dung", "newt", "mime", "deem", "inti", "gigs", "sosa", "lope", "lard", "cara", "smug", "lego", "flex", "doth", "paar", "moon", "wren", "tale", "kant", "eels", "muck", "toga", "zens", "lops", "duet", "coil", "gall", "teal", "glib", "muir", "ails", "boer", "them", "rake", "conn", "neat", "frog", "trip", "coma", "must", "mono", "lira", "craw", "sled", "wear", "toby", "reel", "hips", "nate", "pump", "mont", "died", "moss", "lair", "jibe", "oils", "pied", "hobs", "cads", "haze", "muse", "cogs", "figs", "cues", "roes", "whet", "boru", "cozy", "amos", "tans", "news", "hake", "cots", "boas", "tutu", "wavy", "pipe", "typo", "albs", "boom", "dyke", "wail", "woke", "ware", "rita", "fail", "slab", "owes", "jane", "rack", "hell", "lags", "mend", "mask", "hume", "wane", "acne", "team", "holy", "runs", "exes", "dole", "trim", "zola", "trek", "puma", "wacs", "veep", "yaps", "sums", "lush", "tubs", "most", "witt", "bong", "rule", "hear", "awry", "sots", "nils", "bash", "gasp", "inch", "pens", "fies", "juts", "pate", "vine", "zulu", "this", "bare", "veal", "josh", "reek", "ours", "cowl", "club", "farm", "teat", "coat", "dish", "fore", "weft", "exam", "vlad", "floe", "beak", "lane", "ella", "warp", "goth", "ming", "pits", "rent", "tito", "wish", "amps", "says", "hawk", "ways", "punk", "nark", "cagy", "east", "paul", "bose", "solo", "teed", "text", "hews", "snip", "lips", "emit", "orgy", "icon", "tuna", "soul", "kurd", "clod", "calk", "aunt", "bake", "copy", "acid", "duse", "kiln", "spec", "fans", "bani", "irma", "pads", "batu", "logo", "pack", "oder", "atop", "funk", "gide", "bede", "bibs", "taut", "guns", "dana", "puff", "lyme", "flat", "lake", "june", "sets", "gull", "hops", "earn", "clip", "fell", "kama", "seal", "diaz", "cite", "chew", "cuba", "bury", "yard", "bank", "byes", "apia", "cree", "nosh", "judo", "walk", "tape", "taro", "boot", "cods", "lade", "cong", "deft", "slim", "jeri", "rile", "park", "aeon", "fact", "slow", "goff", "cane", "earp", "tart", "does", "acts", "hope", "cant", "buts", "shin", "dude", "ergo", "mode", "gene", "lept", "chen", "beta", "eden", "pang", "saab", "fang", "whir", "cove", "perk", "fads", "rugs", "herb", "putt", "nous", "vane", "corm", "stay", "bids", "vela", "roof", "isms", "sics", "gone", "swum", "wiry", "cram", "rink", "pert", "heap", "sikh", "dais", "cell", "peel", "nuke", "buss", "rasp", "none", "slut", "bent", "dams", "serb", "dork", "bays", "kale", "cora", "wake", "welt", "rind", "trot", "sloe", "pity", "rout", "eves", "fats", "furs", "pogo", "beth", "hued", "edam", "iamb", "glee", "lute", "keel", "airy", "easy", "tire", "rube", "bogy", "sine", "chop", "rood", "elbe", "mike", "garb", "jill", "gaul", "chit", "dons", "bars", "ride", "beck", "toad", "make", "head", "suds", "pike", "snot", "swat", "peed", "same", "gaza", "lent", "gait", "gael", "elks", "hang", "nerf", "rosy", "shut", "glop", "pain", "dion", "deaf", "hero", "doer", "wost", "wage", "wash", "pats", "narc", "ions", "dice", "quay", "vied", "eons", "case", "pour", "urns", "reva", "rags", "aden", "bone", "rang", "aura", "iraq", "toot", "rome", "hals", "megs", "pond", "john", "yeps", "pawl", "warm", "bird", "tint", "jowl", "gibe", "come", "hold", "pail", "wipe", "bike", "rips", "eery", "kent", "hims", "inks", "fink", "mott", "ices", "macy", "serf", "keys", "tarp", "cops", "sods", "feet", "tear", "benz", "buys", "colo", "boil", "sews", "enos", "watt", "pull", "brag", "cork", "save", "mint", "feat", "jamb", "rubs", "roxy", "toys", "nosy", "yowl", "tamp", "lobs", "foul", "doom", "sown", "pigs", "hemp", "fame", "boor", "cube", "tops", "loco", "lads", "eyre", "alta", "aged", "flop", "pram", "lesa", "sawn", "plow", "aral", "load", "lied", "pled", "boob", "bert", "rows", "zits", "rick", "hint", "dido", "fist", "marc", "wuss", "node", "smog", "nora", "shim", "glut", "bale", "perl", "what", "tort", "meek", "brie", "bind", "cake", "psst", "dour", "jove", "tree", "chip", "stud", "thou", "mobs", "sows", "opts", "diva", "perm", "wise", "cuds", "sols", "alan", "mild", "pure", "gail", "wins", "offs", "nile", "yelp", "minn", "tors", "tran", "homy", "sadr", "erse", "nero", "scab", "finn", "mich", "turd", "then", "poem", "noun", "oxus", "brow", "door", "saws", "eben", "wart", "wand", "rosa", "left", "lina", "cabs", "rapt", "olin", "suet", "kalb", "mans", "dawn", "riel", "temp", "chug", "peal", "drew", "null", "hath", "many", "took", "fond", "gate", "sate", "leak", "zany", "vans", "mart", "hess", "home", "long", "dirk", "bile", "lace", "moog", "axes", "zone", "fork", "duct", "rico", "rife", "deep", "tiny", "hugh", "bilk", "waft", "swig", "pans", "with", "kern", "busy", "film", "lulu", "king", "lord", "veda", "tray", "legs", "soot", "ells", "wasp", "hunt", "earl", "ouch", "diem", "yell", "pegs", "blvd", "polk", "soda", "zorn", "liza", "slop", "week", "kill", "rusk", "eric", "sump", "haul", "rims", "crop", "blob", "face", "bins", "read", "care", "pele", "ritz", "beau", "golf", "drip", "dike", "stab", "jibs", "hove", "junk", "hoax", "tats", "fief", "quad", "peat", "ream", "hats", "root", "flak", "grit", "clap", "pugh", "bosh", "lock", "mute", "crow", "iced", "lisa", "bela", "fems", "oxes", "vies", "gybe", "huff", "bull", "cuss", "sunk", "pups", "fobs", "turf", "sect", "atom", "debt", "sane", "writ", "anon", "mayo", "aria", "seer", "thor", "brim", "gawk", "jack", "jazz", "menu", "yolk", "surf", "libs", "lets", "bans", "toil", "open", "aced", "poor", "mess", "wham", "fran", "gina", "dote", "love", "mood", "pale", "reps", "ines", "shot", "alar", "twit", "site", "dill", "yoga", "sear", "vamp", "abel", "lieu", "cuff", "orbs", "rose", "tank", "gape", "guam", "adar", "vole", "your", "dean", "dear", "hebe", "crab", "hump", "mole", "vase", "rode", "dash", "sera", "balk", "lela", "inca", "gaea", "bush", "loud", "pies", "aide", "blew", "mien", "side", "kerr", "ring", "tess", "prep", "rant", "lugs", "hobo", "joke", "odds", "yule", "aida", "true", "pone", "lode", "nona", "weep", "coda", "elmo", "skim", "wink", "bras", "pier", "bung", "pets", "tabs", "ryan", "jock", "body", "sofa", "joey", "zion", "mace", "kick", "vile", "leno", "bali", "fart", "that", "redo", "ills", "jogs", "pent", "drub", "slaw", "tide", "lena", "seep", "gyps", "wave", "amid", "fear", "ties", "flan", "wimp", "kali", "shun", "crap", "sage", "rune", "logs", "cain", "digs", "abut", "obit", "paps", "rids", "fair", "hack", "huns", "road", "caws", "curt", "jute", "fisk", "fowl", "duty", "holt", "miss", "rude", "vito", "baal", "ural", "mann", "mind", "belt", "clem", "last", "musk", "roam", "abed", "days", "bore", "fuze", "fall", "pict", "dump", "dies", "fiat", "vent", "pork", "eyed", "docs", "rive", "spas", "rope", "ariz", "tout", "game", "jump", "blur", "anti", "lisp", "turn", "sand", "food", "moos", "hoop", "saul", "arch", "fury", "rise", "diss", "hubs", "burs", "grid", "ilks", "suns", "flea", "soil", "lung", "want", "nola", "fins", "thud", "kidd", "juan", "heps", "nape", "rash", "burt", "bump", "tots", "brit", "mums", "bole", "shah", "tees", "skip", "limb", "umps", "ache", "arcs", "raft", "halo", "luce", "bahs", "leta", "conk", "duos", "siva", "went", "peek", "sulk", "reap", "free", "dubs", "lang", "toto", "hasp", "ball", "rats", "nair", "myst", "wang", "snug", "nash", "laos", "ante", "opal", "tina", "pore", "bite", "haas", "myth", "yugo", "foci", "dent", "bade", "pear", "mods", "auto", "shop", "etch", "lyly", "curs", "aron", "slew", "tyro", "sack", "wade", "clio", "gyro", "butt", "icky", "char", "itch", "halt", "gals", "yang", "tend", "pact", "bees", "suit", "puny", "hows", "nina", "brno", "oops", "lick", "sons", "kilo", "bust", "nome", "mona", "dull", "join", "hour", "papa", "stag", "bern", "wove", "lull", "slip", "laze", "roil", "alto", "bath", "buck", "alma", "anus", "evil", "dumb", "oreo", "rare", "near", "cure", "isis", "hill", "kyle", "pace", "comb", "nits", "flip", "clop", "mort", "thea", "wall", "kiel", "judd", "coop", "dave", "very", "amie", "blah", "flub", "talc", "bold", "fogy", "idea", "prof", "horn", "shoo", "aped", "pins", "helm", "wees", "beer", "womb", "clue", "alba", "aloe", "fine", "bard", "limo", "shaw", "pint", "swim", "dust", "indy", "hale", "cats", "troy", "wens", "luke", "vern", "deli", "both", "brig", "daub", "sara", "sued", "bier", "noel", "olga", "dupe", "look", "pisa", "knox", "murk", "dame", "matt", "gold", "jame", "toge", "luck", "peck", "tass", "calf", "pill", "wore", "wadi", "thur", "parr", "maul", "tzar", "ones", "lees", "dark", "fake", "bast", "zoom", "here", "moro", "wine", "bums", "cows", "jean", "palm", "fume", "plop", "help", "tuba", "leap", "cans", "back", "avid", "lice", "lust", "polo", "dory", "stew", "kate", "rama", "coke", "bled", "mugs", "ajax", "arts", "drug", "pena", "cody", "hole", "sean", "deck", "guts", "kong", "bate", "pitt", "como", "lyle", "siam", "rook", "baby", "jigs", "bret", "bark", "lori", "reba", "sups", "made", "buzz", "gnaw", "alps", "clay", "post", "viol", "dina", "card", "lana", "doff", "yups", "tons", "live", "kids", "pair", "yawl", "name", "oven", "sirs", "gyms", "prig", "down", "leos", "noon", "nibs", "cook", "safe", "cobb", "raja", "awes", "sari", "nerd", "fold", "lots", "pete", "deal", "bias", "zeal", "girl", "rage", "cool", "gout", "whey", "soak", "thaw", "bear", "wing", "nagy", "well", "oink", "sven", "kurt", "etna", "held", "wood", "high", "feta", "twee", "ford", "cave", "knot", "tory", "ibis", "yaks", "vets", "foxy", "sank", "cone", "pius", "tall", "seem", "wool", "flap", "gird", "lore", "coot", "mewl", "sere", "real", "puts", "sell", "nuts", "foil", "lilt", "saga", "heft", "dyed", "goat", "spew", "daze", "frye", "adds", "glen", "tojo", "pixy", "gobi", "stop", "tile", "hiss", "shed", "hahn", "baku", "ahas", "sill", "swap", "also", "carr", "manx", "lime", "debs", "moat", "eked", "bola", "pods", "coon", "lacy", "tube", "minx", "buff", "pres", "clew", "gaff", "flee", "burn", "whom", "cola", "fret", "purl", "wick", "wigs", "donn", "guys", "toni", "oxen", "wite", "vial", "spam", "huts", "vats", "lima", "core", "eula", "thad", "peon", "erie", "oats", "boyd", "cued", "olaf", "tams", "secs", "urey", "wile", "penn", "bred", "rill", "vary", "sues", "mail", "feds", "aves", "code", "beam", "reed", "neil", "hark", "pols", "gris", "gods", "mesa", "test", "coup", "heed", "dora", "hied", "tune", "doze", "pews", "oaks", "bloc", "tips", "maid", "goof", "four", "woof", "silo", "bray", "zest", "kiss", "yong", "file", "hilt", "iris", "tuns", "lily", "ears", "pant", "jury", "taft", "data", "gild", "pick", "kook", "colt", "bohr", "anal", "asps", "babe", "bach", "mash", "biko", "bowl", "huey", "jilt", "goes", "guff", "bend", "nike", "tami", "gosh", "tike", "gees", "urge", "path", "bony", "jude", "lynn", "lois", "teas", "dunn", "elul", "bonn", "moms", "bugs", "slay", "yeah", "loan", "hulk", "lows", "damn", "nell", "jung", "avis", "mane", "waco", "loin", "knob", "tyke", "anna", "hire", "luau", "tidy", "nuns", "pots", "quid", "exec", "hans", "hera", "hush", "shag", "scot", "moan", "wald", "ursa", "lorn", "hunk", "loft", "yore", "alum", "mows", "slog", "emma", "spud", "rice", "worn", "erma", "need", "bags", "lark", "kirk", "pooh", "dyes", "area", "dime", "luvs", "foch", "refs", "cast", "alit", "tugs", "even", "role", "toed", "caph", "nigh", "sony", "bide", "robs", "folk", "daft", "past", "blue", "flaw", "sana", "fits", "barr", "riot", "dots", "lamp", "cock", "fibs", "harp", "tent", "hate", "mali", "togs", "gear", "tues", "bass", "pros", "numb", "emus", "hare", "fate", "wife", "mean", "pink", "dune", "ares", "dine", "oily", "tony", "czar", "spay", "push", "glum", "till", "moth", "glue", "dive", "scad", "pops", "woks", "andy", "leah", "cusp", "hair", "alex", "vibe", "bulb", "boll", "firm", "joys", "tara", "cole", "levy", "owen", "chow", "rump", "jail", "lapp", "beet", "slap", "kith", "more", "maps", "bond", "hick", "opus", "rust", "wist", "shat", "phil", "snow", "lott", "lora", "cary", "mote", "rift", "oust", "klee", "goad", "pith", "heep", "lupe", "ivan", "mimi", "bald", "fuse", "cuts", "lens", "leer", "eyry", "know", "razz", "tare", "pals", "geek", "greg", "teen", "clef", "wags", "weal", "each", "haft", "nova", "waif", "rate", "katy", "yale", "dale", "leas", "axum", "quiz", "pawn", "fend", "capt", "laws", "city", "chad", "coal", "nail", "zaps", "sort", "loci", "less", "spur", "note", "foes", "fags", "gulp", "snap", "bogs", "wrap", "dane", "melt", "ease", "felt", "shea", "calm", "star", "swam", "aery", "year", "plan", "odin", "curd", "mira", "mops", "shit", "davy", "apes", "inky", "hues", "lome", "bits", "vila", "show", "best", "mice", "gins", "next", "roan", "ymir", "mars", "oman", "wild", "heal", "plus", "erin", "rave", "robe", "fast", "hutu", "aver", "jodi", "alms", "yams", "zero", "revs", "wean", "chic", "self", "jeep", "jobs", "waxy", "duel", "seek", "spot", "raps", "pimp", "adan", "slam", "tool", "morn", "futz", "ewes", "errs", "knit", "rung", "kans", "muff", "huhs", "tows", "lest", "meal", "azov", "gnus", "agar", "sips", "sway", "otis", "tone", "tate", "epic", "trio", "tics", "fade", "lear", "owns", "robt", "weds", "five", "lyon", "terr", "arno", "mama", "grey", "disk", "sept", "sire", "bart", "saps", "whoa", "turk", "stow", "pyle", "joni", "zinc", "negs", "task", "leif", "ribs", "malt", "nine", "bunt", "grin", "dona", "nope", "hams", "some", "molt", "smit", "sacs", "joan", "slav", "lady", "base", "heck", "list", "take", "herd", "will", "nubs", "burg", "hugs", "peru", "coif", "zoos", "nick", "idol", "levi", "grub", "roth", "adam", "elma", "tags", "tote", "yaws", "cali", "mete", "lula", "cubs", "prim", "luna", "jolt", "span", "pita", "dodo", "puss", "deer", "term", "dolt", "goon", "gary", "yarn", "aims", "just", "rena", "tine", "cyst", "meld", "loki", "wong", "were", "hung", "maze", "arid", "cars", "wolf", "marx", "faye", "eave", "raga", "flow", "neal", "lone", "anne", "cage", "tied", "tilt", "soto", "opel", "date", "buns", "dorm", "kane", "akin", "ewer", "drab", "thai", "jeer", "grad", "berm", "rods", "saki", "grus", "vast", "late", "lint", "mule", "risk", "labs", "snit", "gala", "find", "spin", "ired", "slot", "oafs", "lies", "mews", "wino", "milk", "bout", "onus", "tram", "jaws", "peas", "cleo", "seat", "gums", "cold", "vang", "dewy", "hood", "rush", "mack", "yuan", "odes", "boos", "jami", "mare", "plot", "swab", "borg", "hays", "form", "mesh", "mani", "fife", "good", "gram", "lion", "myna", "moor", "skin", "posh", "burr", "rime", "done", "ruts", "pays", "stem", "ting", "arty", "slag", "iron", "ayes", "stub", "oral", "gets", "chid", "yens", "snub", "ages", "wide", "bail", "verb", "lamb", "bomb", "army", "yoke", "gels", "tits", "bork", "mils", "nary", "barn", "hype", "odom", "avon", "hewn", "rios", "cams", "tact", "boss", "oleo", "duke", "eris", "gwen", "elms", "deon", "sims", "quit", "nest", "font", "dues", "yeas", "zeta", "bevy", "gent", "torn", "cups", "worm", "baum", "axon", "purr", "vise", "grew", "govs", "meat", "chef", "rest", "lame" };
            hs = new HashSet<string>(dic);
            llResult = LadderLength("sand", "acne", hs);


            dic = new List<string> { "slit", "bunk", "wars", "ping", "viva", "wynn", "wows", "irks", "gang", "pool", "mock", "fort", "heel", "send", "ship", "cols", "alec", "foal", "nabs", "gaze", "giza", "mays", "dogs", "karo", "cums", "jedi", "webb", "lend", "mire", "jose", "catt", "grow", "toss", "magi", "leis", "bead", "kara", "hoof", "than", "ires", "baas", "vein", "kari", "riga", "oars", "gags", "thug", "yawn", "wive", "view", "germ", "flab", "july", "tuck", "rory", "bean", "feed", "rhee", "jeez", "gobs", "lath", "desk", "yoko", "cute", "zeus", "thus", "dims", "link", "dirt", "mara", "disc", "limy", "lewd", "maud", "duly", "elsa", "hart", "rays", "rues", "camp", "lack", "okra", "tome", "math", "plug", "monk", "orly", "friz", "hogs", "yoda", "poop", "tick", "plod", "cloy", "pees", "imps", "lead", "pope", "mall", "frey", "been", "plea", "poll", "male", "teak", "soho", "glob", "bell", "mary", "hail", "scan", "yips", "like", "mull", "kory", "odor", "byte", "kaye", "word", "honk", "asks", "slid", "hopi", "toke", "gore", "flew", "tins", "mown", "oise", "hall", "vega", "sing", "fool", "boat", "bobs", "lain", "soft", "hard", "rots", "sees", "apex", "chan", "told", "woos", "unit", "scow", "gilt", "beef", "jars", "tyre", "imus", "neon", "soap", "dabs", "rein", "ovid", "hose", "husk", "loll", "asia", "cope", "tail", "hazy", "clad", "lash", "sags", "moll", "eddy", "fuel", "lift", "flog", "land", "sigh", "saks", "sail", "hook", "visa", "tier", "maws", "roeg", "gila", "eyes", "noah", "hypo", "tore", "eggs", "rove", "chap", "room", "wait", "lurk", "race", "host", "dada", "lola", "gabs", "sobs", "joel", "keck", "axed", "mead", "gust", "laid", "ends", "oort", "nose", "peer", "kept", "abet", "iran", "mick", "dead", "hags", "tens", "gown", "sick", "odis", "miro", "bill", "fawn", "sumo", "kilt", "huge", "ores", "oran", "flag", "tost", "seth", "sift", "poet", "reds", "pips", "cape", "togo", "wale", "limn", "toll", "ploy", "inns", "snag", "hoes", "jerk", "flux", "fido", "zane", "arab", "gamy", "raze", "lank", "hurt", "rail", "hind", "hoot", "dogy", "away", "pest", "hoed", "pose", "lose", "pole", "alva", "dino", "kind", "clan", "dips", "soup", "veto", "edna", "damp", "gush", "amen", "wits", "pubs", "fuzz", "cash", "pine", "trod", "gunk", "nude", "lost", "rite", "cory", "walt", "mica", "cart", "avow", "wind", "book", "leon", "life", "bang", "draw", "leek", "skis", "dram", "ripe", "mine", "urea", "tiff", "over", "gale", "weir", "defy", "norm", "tull", "whiz", "gill", "ward", "crag", "when", "mill", "firs", "sans", "flue", "reid", "ekes", "jain", "mutt", "hems", "laps", "piss", "pall", "rowe", "prey", "cull", "knew", "size", "wets", "hurl", "wont", "suva", "girt", "prys", "prow", "warn", "naps", "gong", "thru", "livy", "boar", "sade", "amok", "vice", "slat", "emir", "jade", "karl", "loyd", "cerf", "bess", "loss", "rums", "lats", "bode", "subs", "muss", "maim", "kits", "thin", "york", "punt", "gays", "alpo", "aids", "drag", "eras", "mats", "pyre", "clot", "step", "oath", "lout", "wary", "carp", "hums", "tang", "pout", "whip", "fled", "omar", "such", "kano", "jake", "stan", "loop", "fuss", "mini", "byrd", "exit", "fizz", "lire", "emil", "prop", "noes", "awed", "gift", "soli", "sale", "gage", "orin", "slur", "limp", "saar", "arks", "mast", "gnat", "port", "into", "geed", "pave", "awls", "cent", "cunt", "full", "dint", "hank", "mate", "coin", "tars", "scud", "veer", "coax", "bops", "uris", "loom", "shod", "crib", "lids", "drys", "fish", "edit", "dick", "erna", "else", "hahs", "alga", "moho", "wire", "fora", "tums", "ruth", "bets", "duns", "mold", "mush", "swop", "ruby", "bolt", "nave", "kite", "ahem", "brad", "tern", "nips", "whew", "bait", "ooze", "gino", "yuck", "drum", "shoe", "lobe", "dusk", "cult", "paws", "anew", "dado", "nook", "half", "lams", "rich", "cato", "java", "kemp", "vain", "fees", "sham", "auks", "gish", "fire", "elam", "salt", "sour", "loth", "whit", "yogi", "shes", "scam", "yous", "lucy", "inez", "geld", "whig", "thee", "kelp", "loaf", "harm", "tomb", "ever", "airs", "page", "laud", "stun", "paid", "goop", "cobs", "judy", "grab", "doha", "crew", "item", "fogs", "tong", "blip", "vest", "bran", "wend", "bawl", "feel", "jets", "mixt", "tell", "dire", "devi", "milo", "deng", "yews", "weak", "mark", "doug", "fare", "rigs", "poke", "hies", "sian", "suez", "quip", "kens", "lass", "zips", "elva", "brat", "cosy", "teri", "hull", "spun", "russ", "pupa", "weed", "pulp", "main", "grim", "hone", "cord", "barf", "olav", "gaps", "rote", "wilt", "lars", "roll", "balm", "jana", "give", "eire", "faun", "suck", "kegs", "nita", "weer", "tush", "spry", "loge", "nays", "heir", "dope", "roar", "peep", "nags", "ates", "bane", "seas", "sign", "fred", "they", "lien", "kiev", "fops", "said", "lawn", "lind", "miff", "mass", "trig", "sins", "furl", "ruin", "sent", "cray", "maya", "clog", "puns", "silk", "axis", "grog", "jots", "dyer", "mope", "rand", "vend", "keen", "chou", "dose", "rain", "eats", "sped", "maui", "evan", "time", "todd", "skit", "lief", "sops", "outs", "moot", "faze", "biro", "gook", "fill", "oval", "skew", "veil", "born", "slob", "hyde", "twin", "eloy", "beat", "ergs", "sure", "kobe", "eggo", "hens", "jive", "flax", "mons", "dunk", "yest", "begs", "dial", "lodz", "burp", "pile", "much", "dock", "rene", "sago", "racy", "have", "yalu", "glow", "move", "peps", "hods", "kins", "salk", "hand", "cons", "dare", "myra", "sega", "type", "mari", "pelt", "hula", "gulf", "jugs", "flay", "fest", "spat", "toms", "zeno", "taps", "deny", "swag", "afro", "baud", "jabs", "smut", "egos", "lara", "toes", "song", "fray", "luis", "brut", "olen", "mere", "ruff", "slum", "glad", "buds", "silt", "rued", "gelt", "hive", "teem", "ides", "sink", "ands", "wisp", "omen", "lyre", "yuks", "curb", "loam", "darn", "liar", "pugs", "pane", "carl", "sang", "scar", "zeds", "claw", "berg", "hits", "mile", "lite", "khan", "erik", "slug", "loon", "dena", "ruse", "talk", "tusk", "gaol", "tads", "beds", "sock", "howe", "gave", "snob", "ahab", "part", "meir", "jell", "stir", "tels", "spit", "hash", "omit", "jinx", "lyra", "puck", "laue", "beep", "eros", "owed", "cede", "brew", "slue", "mitt", "jest", "lynx", "wads", "gena", "dank", "volt", "gray", "pony", "veld", "bask", "fens", "argo", "work", "taxi", "afar", "boon", "lube", "pass", "lazy", "mist", "blot", "mach", "poky", "rams", "sits", "rend", "dome", "pray", "duck", "hers", "lure", "keep", "gory", "chat", "runt", "jams", "lays", "posy", "bats", "hoff", "rock", "keri", "raul", "yves", "lama", "ramp", "vote", "jody", "pock", "gist", "sass", "iago", "coos", "rank", "lowe", "vows", "koch", "taco", "jinn", "juno", "rape", "band", "aces", "goal", "huck", "lila", "tuft", "swan", "blab", "leda", "gems", "hide", "tack", "porn", "scum", "frat", "plum", "duds", "shad", "arms", "pare", "chin", "gain", "knee", "foot", "line", "dove", "vera", "jays", "fund", "reno", "skid", "boys", "corn", "gwyn", "sash", "weld", "ruiz", "dior", "jess", "leaf", "pars", "cote", "zing", "scat", "nice", "dart", "only", "owls", "hike", "trey", "whys", "ding", "klan", "ross", "barb", "ants", "lean", "dopy", "hock", "tour", "grip", "aldo", "whim", "prom", "rear", "dins", "duff", "dell", "loch", "lava", "sung", "yank", "thar", "curl", "venn", "blow", "pomp", "heat", "trap", "dali", "nets", "seen", "gash", "twig", "dads", "emmy", "rhea", "navy", "haws", "mite", "bows", "alas", "ives", "play", "soon", "doll", "chum", "ajar", "foam", "call", "puke", "kris", "wily", "came", "ales", "reef", "raid", "diet", "prod", "prut", "loot", "soar", "coed", "celt", "seam", "dray", "lump", "jags", "nods", "sole", "kink", "peso", "howl", "cost", "tsar", "uric", "sore", "woes", "sewn", "sake", "cask", "caps", "burl", "tame", "bulk", "neva", "from", "meet", "webs", "spar", "fuck", "buoy", "wept", "west", "dual", "pica", "sold", "seed", "gads", "riff", "neck", "deed", "rudy", "drop", "vale", "flit", "romp", "peak", "jape", "jews", "fain", "dens", "hugo", "elba", "mink", "town", "clam", "feud", "fern", "dung", "newt", "mime", "deem", "inti", "gigs", "sosa", "lope", "lard", "cara", "smug", "lego", "flex", "doth", "paar", "moon", "wren", "tale", "kant", "eels", "muck", "toga", "zens", "lops", "duet", "coil", "gall", "teal", "glib", "muir", "ails", "boer", "them", "rake", "conn", "neat", "frog", "trip", "coma", "must", "mono", "lira", "craw", "sled", "wear", "toby", "reel", "hips", "nate", "pump", "mont", "died", "moss", "lair", "jibe", "oils", "pied", "hobs", "cads", "haze", "muse", "cogs", "figs", "cues", "roes", "whet", "boru", "cozy", "amos", "tans", "news", "hake", "cots", "boas", "tutu", "wavy", "pipe", "typo", "albs", "boom", "dyke", "wail", "woke", "ware", "rita", "fail", "slab", "owes", "jane", "rack", "hell", "lags", "mend", "mask", "hume", "wane", "acne", "team", "holy", "runs", "exes", "dole", "trim", "zola", "trek", "puma", "wacs", "veep", "yaps", "sums", "lush", "tubs", "most", "witt", "bong", "rule", "hear", "awry", "sots", "nils", "bash", "gasp", "inch", "pens", "fies", "juts", "pate", "vine", "zulu", "this", "bare", "veal", "josh", "reek", "ours", "cowl", "club", "farm", "teat", "coat", "dish", "fore", "weft", "exam", "vlad", "floe", "beak", "lane", "ella", "warp", "goth", "ming", "pits", "rent", "tito", "wish", "amps", "says", "hawk", "ways", "punk", "nark", "cagy", "east", "paul", "bose", "solo", "teed", "text", "hews", "snip", "lips", "emit", "orgy", "icon", "tuna", "soul", "kurd", "clod", "calk", "aunt", "bake", "copy", "acid", "duse", "kiln", "spec", "fans", "bani", "irma", "pads", "batu", "logo", "pack", "oder", "atop", "funk", "gide", "bede", "bibs", "taut", "guns", "dana", "puff", "lyme", "flat", "lake", "june", "sets", "gull", "hops", "earn", "clip", "fell", "kama", "seal", "diaz", "cite", "chew", "cuba", "bury", "yard", "bank", "byes", "apia", "cree", "nosh", "judo", "walk", "tape", "taro", "boot", "cods", "lade", "cong", "deft", "slim", "jeri", "rile", "park", "aeon", "fact", "slow", "goff", "cane", "earp", "tart", "does", "acts", "hope", "cant", "buts", "shin", "dude", "ergo", "mode", "gene", "lept", "chen", "beta", "eden", "pang", "saab", "fang", "whir", "cove", "perk", "fads", "rugs", "herb", "putt", "nous", "vane", "corm", "stay", "bids", "vela", "roof", "isms", "sics", "gone", "swum", "wiry", "cram", "rink", "pert", "heap", "sikh", "dais", "cell", "peel", "nuke", "buss", "rasp", "none", "slut", "bent", "dams", "serb", "dork", "bays", "kale", "cora", "wake", "welt", "rind", "trot", "sloe", "pity", "rout", "eves", "fats", "furs", "pogo", "beth", "hued", "edam", "iamb", "glee", "lute", "keel", "airy", "easy", "tire", "rube", "bogy", "sine", "chop", "rood", "elbe", "mike", "garb", "jill", "gaul", "chit", "dons", "bars", "ride", "beck", "toad", "make", "head", "suds", "pike", "snot", "swat", "peed", "same", "gaza", "lent", "gait", "gael", "elks", "hang", "nerf", "rosy", "shut", "glop", "pain", "dion", "deaf", "hero", "doer", "wost", "wage", "wash", "pats", "narc", "ions", "dice", "quay", "vied", "eons", "case", "pour", "urns", "reva", "rags", "aden", "bone", "rang", "aura", "iraq", "toot", "rome", "hals", "megs", "pond", "john", "yeps", "pawl", "warm", "bird", "tint", "jowl", "gibe", "come", "hold", "pail", "wipe", "bike", "rips", "eery", "kent", "hims", "inks", "fink", "mott", "ices", "macy", "serf", "keys", "tarp", "cops", "sods", "feet", "tear", "benz", "buys", "colo", "boil", "sews", "enos", "watt", "pull", "brag", "cork", "save", "mint", "feat", "jamb", "rubs", "roxy", "toys", "nosy", "yowl", "tamp", "lobs", "foul", "doom", "sown", "pigs", "hemp", "fame", "boor", "cube", "tops", "loco", "lads", "eyre", "alta", "aged", "flop", "pram", "lesa", "sawn", "plow", "aral", "load", "lied", "pled", "boob", "bert", "rows", "zits", "rick", "hint", "dido", "fist", "marc", "wuss", "node", "smog", "nora", "shim", "glut", "bale", "perl", "what", "tort", "meek", "brie", "bind", "cake", "psst", "dour", "jove", "tree", "chip", "stud", "thou", "mobs", "sows", "opts", "diva", "perm", "wise", "cuds", "sols", "alan", "mild", "pure", "gail", "wins", "offs", "nile", "yelp", "minn", "tors", "tran", "homy", "sadr", "erse", "nero", "scab", "finn", "mich", "turd", "then", "poem", "noun", "oxus", "brow", "door", "saws", "eben", "wart", "wand", "rosa", "left", "lina", "cabs", "rapt", "olin", "suet", "kalb", "mans", "dawn", "riel", "temp", "chug", "peal", "drew", "null", "hath", "many", "took", "fond", "gate", "sate", "leak", "zany", "vans", "mart", "hess", "home", "long", "dirk", "bile", "lace", "moog", "axes", "zone", "fork", "duct", "rico", "rife", "deep", "tiny", "hugh", "bilk", "waft", "swig", "pans", "with", "kern", "busy", "film", "lulu", "king", "lord", "veda", "tray", "legs", "soot", "ells", "wasp", "hunt", "earl", "ouch", "diem", "yell", "pegs", "blvd", "polk", "soda", "zorn", "liza", "slop", "week", "kill", "rusk", "eric", "sump", "haul", "rims", "crop", "blob", "face", "bins", "read", "care", "pele", "ritz", "beau", "golf", "drip", "dike", "stab", "jibs", "hove", "junk", "hoax", "tats", "fief", "quad", "peat", "ream", "hats", "root", "flak", "grit", "clap", "pugh", "bosh", "lock", "mute", "crow", "iced", "lisa", "bela", "fems", "oxes", "vies", "gybe", "huff", "bull", "cuss", "sunk", "pups", "fobs", "turf", "sect", "atom", "debt", "sane", "writ", "anon", "mayo", "aria", "seer", "thor", "brim", "gawk", "jack", "jazz", "menu", "yolk", "surf", "libs", "lets", "bans", "toil", "open", "aced", "poor", "mess", "wham", "fran", "gina", "dote", "love", "mood", "pale", "reps", "ines", "shot", "alar", "twit", "site", "dill", "yoga", "sear", "vamp", "abel", "lieu", "cuff", "orbs", "rose", "tank", "gape", "guam", "adar", "vole", "your", "dean", "dear", "hebe", "crab", "hump", "mole", "vase", "rode", "dash", "sera", "balk", "lela", "inca", "gaea", "bush", "loud", "pies", "aide", "blew", "mien", "side", "kerr", "ring", "tess", "prep", "rant", "lugs", "hobo", "joke", "odds", "yule", "aida", "true", "pone", "lode", "nona", "weep", "coda", "elmo", "skim", "wink", "bras", "pier", "bung", "pets", "tabs", "ryan", "jock", "body", "sofa", "joey", "zion", "mace", "kick", "vile", "leno", "bali", "fart", "that", "redo", "ills", "jogs", "pent", "drub", "slaw", "tide", "lena", "seep", "gyps", "wave", "amid", "fear", "ties", "flan", "wimp", "kali", "shun", "crap", "sage", "rune", "logs", "cain", "digs", "abut", "obit", "paps", "rids", "fair", "hack", "huns", "road", "caws", "curt", "jute", "fisk", "fowl", "duty", "holt", "miss", "rude", "vito", "baal", "ural", "mann", "mind", "belt", "clem", "last", "musk", "roam", "abed", "days", "bore", "fuze", "fall", "pict", "dump", "dies", "fiat", "vent", "pork", "eyed", "docs", "rive", "spas", "rope", "ariz", "tout", "game", "jump", "blur", "anti", "lisp", "turn", "sand", "food", "moos", "hoop", "saul", "arch", "fury", "rise", "diss", "hubs", "burs", "grid", "ilks", "suns", "flea", "soil", "lung", "want", "nola", "fins", "thud", "kidd", "juan", "heps", "nape", "rash", "burt", "bump", "tots", "brit", "mums", "bole", "shah", "tees", "skip", "limb", "umps", "ache", "arcs", "raft", "halo", "luce", "bahs", "leta", "conk", "duos", "siva", "went", "peek", "sulk", "reap", "free", "dubs", "lang", "toto", "hasp", "ball", "rats", "nair", "myst", "wang", "snug", "nash", "laos", "ante", "opal", "tina", "pore", "bite", "haas", "myth", "yugo", "foci", "dent", "bade", "pear", "mods", "auto", "shop", "etch", "lyly", "curs", "aron", "slew", "tyro", "sack", "wade", "clio", "gyro", "butt", "icky", "char", "itch", "halt", "gals", "yang", "tend", "pact", "bees", "suit", "puny", "hows", "nina", "brno", "oops", "lick", "sons", "kilo", "bust", "nome", "mona", "dull", "join", "hour", "papa", "stag", "bern", "wove", "lull", "slip", "laze", "roil", "alto", "bath", "buck", "alma", "anus", "evil", "dumb", "oreo", "rare", "near", "cure", "isis", "hill", "kyle", "pace", "comb", "nits", "flip", "clop", "mort", "thea", "wall", "kiel", "judd", "coop", "dave", "very", "amie", "blah", "flub", "talc", "bold", "fogy", "idea", "prof", "horn", "shoo", "aped", "pins", "helm", "wees", "beer", "womb", "clue", "alba", "aloe", "fine", "bard", "limo", "shaw", "pint", "swim", "dust", "indy", "hale", "cats", "troy", "wens", "luke", "vern", "deli", "both", "brig", "daub", "sara", "sued", "bier", "noel", "olga", "dupe", "look", "pisa", "knox", "murk", "dame", "matt", "gold", "jame", "toge", "luck", "peck", "tass", "calf", "pill", "wore", "wadi", "thur", "parr", "maul", "tzar", "ones", "lees", "dark", "fake", "bast", "zoom", "here", "moro", "wine", "bums", "cows", "jean", "palm", "fume", "plop", "help", "tuba", "leap", "cans", "back", "avid", "lice", "lust", "polo", "dory", "stew", "kate", "rama", "coke", "bled", "mugs", "ajax", "arts", "drug", "pena", "cody", "hole", "sean", "deck", "guts", "kong", "bate", "pitt", "como", "lyle", "siam", "rook", "baby", "jigs", "bret", "bark", "lori", "reba", "sups", "made", "buzz", "gnaw", "alps", "clay", "post", "viol", "dina", "card", "lana", "doff", "yups", "tons", "live", "kids", "pair", "yawl", "name", "oven", "sirs", "gyms", "prig", "down", "leos", "noon", "nibs", "cook", "safe", "cobb", "raja", "awes", "sari", "nerd", "fold", "lots", "pete", "deal", "bias", "zeal", "girl", "rage", "cool", "gout", "whey", "soak", "thaw", "bear", "wing", "nagy", "well", "oink", "sven", "kurt", "etna", "held", "wood", "high", "feta", "twee", "ford", "cave", "knot", "tory", "ibis", "yaks", "vets", "foxy", "sank", "cone", "pius", "tall", "seem", "wool", "flap", "gird", "lore", "coot", "mewl", "sere", "real", "puts", "sell", "nuts", "foil", "lilt", "saga", "heft", "dyed", "goat", "spew", "daze", "frye", "adds", "glen", "tojo", "pixy", "gobi", "stop", "tile", "hiss", "shed", "hahn", "baku", "ahas", "sill", "swap", "also", "carr", "manx", "lime", "debs", "moat", "eked", "bola", "pods", "coon", "lacy", "tube", "minx", "buff", "pres", "clew", "gaff", "flee", "burn", "whom", "cola", "fret", "purl", "wick", "wigs", "donn", "guys", "toni", "oxen", "wite", "vial", "spam", "huts", "vats", "lima", "core", "eula", "thad", "peon", "erie", "oats", "boyd", "cued", "olaf", "tams", "secs", "urey", "wile", "penn", "bred", "rill", "vary", "sues", "mail", "feds", "aves", "code", "beam", "reed", "neil", "hark", "pols", "gris", "gods", "mesa", "test", "coup", "heed", "dora", "hied", "tune", "doze", "pews", "oaks", "bloc", "tips", "maid", "goof", "four", "woof", "silo", "bray", "zest", "kiss", "yong", "file", "hilt", "iris", "tuns", "lily", "ears", "pant", "jury", "taft", "data", "gild", "pick", "kook", "colt", "bohr", "anal", "asps", "babe", "bach", "mash", "biko", "bowl", "huey", "jilt", "goes", "guff", "bend", "nike", "tami", "gosh", "tike", "gees", "urge", "path", "bony", "jude", "lynn", "lois", "teas", "dunn", "elul", "bonn", "moms", "bugs", "slay", "yeah", "loan", "hulk", "lows", "damn", "nell", "jung", "avis", "mane", "waco", "loin", "knob", "tyke", "anna", "hire", "luau", "tidy", "nuns", "pots", "quid", "exec", "hans", "hera", "hush", "shag", "scot", "moan", "wald", "ursa", "lorn", "hunk", "loft", "yore", "alum", "mows", "slog", "emma", "spud", "rice", "worn", "erma", "need", "bags", "lark", "kirk", "pooh", "dyes", "area", "dime", "luvs", "foch", "refs", "cast", "alit", "tugs", "even", "role", "toed", "caph", "nigh", "sony", "bide", "robs", "folk", "daft", "past", "blue", "flaw", "sana", "fits", "barr", "riot", "dots", "lamp", "cock", "fibs", "harp", "tent", "hate", "mali", "togs", "gear", "tues", "bass", "pros", "numb", "emus", "hare", "fate", "wife", "mean", "pink", "dune", "ares", "dine", "oily", "tony", "czar", "spay", "push", "glum", "till", "moth", "glue", "dive", "scad", "pops", "woks", "andy", "leah", "cusp", "hair", "alex", "vibe", "bulb", "boll", "firm", "joys", "tara", "cole", "levy", "owen", "chow", "rump", "jail", "lapp", "beet", "slap", "kith", "more", "maps", "bond", "hick", "opus", "rust", "wist", "shat", "phil", "snow", "lott", "lora", "cary", "mote", "rift", "oust", "klee", "goad", "pith", "heep", "lupe", "ivan", "mimi", "bald", "fuse", "cuts", "lens", "leer", "eyry", "know", "razz", "tare", "pals", "geek", "greg", "teen", "clef", "wags", "weal", "each", "haft", "nova", "waif", "rate", "katy", "yale", "dale", "leas", "axum", "quiz", "pawn", "fend", "capt", "laws", "city", "chad", "coal", "nail", "zaps", "sort", "loci", "less", "spur", "note", "foes", "fags", "gulp", "snap", "bogs", "wrap", "dane", "melt", "ease", "felt", "shea", "calm", "star", "swam", "aery", "year", "plan", "odin", "curd", "mira", "mops", "shit", "davy", "apes", "inky", "hues", "lome", "bits", "vila", "show", "best", "mice", "gins", "next", "roan", "ymir", "mars", "oman", "wild", "heal", "plus", "erin", "rave", "robe", "fast", "hutu", "aver", "jodi", "alms", "yams", "zero", "revs", "wean", "chic", "self", "jeep", "jobs", "waxy", "duel", "seek", "spot", "raps", "pimp", "adan", "slam", "tool", "morn", "futz", "ewes", "errs", "knit", "rung", "kans", "muff", "huhs", "tows", "lest", "meal", "azov", "gnus", "agar", "sips", "sway", "otis", "tone", "tate", "epic", "trio", "tics", "fade", "lear", "owns", "robt", "weds", "five", "lyon", "terr", "arno", "mama", "grey", "disk", "sept", "sire", "bart", "saps", "whoa", "turk", "stow", "pyle", "joni", "zinc", "negs", "task", "leif", "ribs", "malt", "nine", "bunt", "grin", "dona", "nope", "hams", "some", "molt", "smit", "sacs", "joan", "slav", "lady", "base", "heck", "list", "take", "herd", "will", "nubs", "burg", "hugs", "peru", "coif", "zoos", "nick", "idol", "levi", "grub", "roth", "adam", "elma", "tags", "tote", "yaws", "cali", "mete", "lula", "cubs", "prim", "luna", "jolt", "span", "pita", "dodo", "puss", "deer", "term", "dolt", "goon", "gary", "yarn", "aims", "just", "rena", "tine", "cyst", "meld", "loki", "wong", "were", "hung", "maze", "arid", "cars", "wolf", "marx", "faye", "eave", "raga", "flow", "neal", "lone", "anne", "cage", "tied", "tilt", "soto", "opel", "date", "buns", "dorm", "kane", "akin", "ewer", "drab", "thai", "jeer", "grad", "berm", "rods", "saki", "grus", "vast", "late", "lint", "mule", "risk", "labs", "snit", "gala", "find", "spin", "ired", "slot", "oafs", "lies", "mews", "wino", "milk", "bout", "onus", "tram", "jaws", "peas", "cleo", "seat", "gums", "cold", "vang", "dewy", "hood", "rush", "mack", "yuan", "odes", "boos", "jami", "mare", "plot", "swab", "borg", "hays", "form", "mesh", "mani", "fife", "good", "gram", "lion", "myna", "moor", "skin", "posh", "burr", "rime", "done", "ruts", "pays", "stem", "ting", "arty", "slag", "iron", "ayes", "stub", "oral", "gets", "chid", "yens", "snub", "ages", "wide", "bail", "verb", "lamb", "bomb", "army", "yoke", "gels", "tits", "bork", "mils", "nary", "barn", "hype", "odom", "avon", "hewn", "rios", "cams", "tact", "boss", "oleo", "duke", "eris", "gwen", "elms", "deon", "sims", "quit", "nest", "font", "dues", "yeas", "zeta", "bevy", "gent", "torn", "cups", "worm", "baum", "axon", "purr", "vise", "grew", "govs", "meat", "chef", "rest", "lame" };
            hs = new HashSet<string>(dic);
            llResult = LadderLength("sand", "acne", hs);

            int mc = LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });

            mc = LongestConsecutive(new int[] { 0,-1 });
            mc = LongestConsecutive(new int[] { 1, 2, 0, 1 });

            ListNode lnH = CreateList(new int[] { 1, 2, 3, 4 });
            lnH = ReorderList(lnH);

            lnH = CreateList(new int[] { 1, 2, 3});
            lnH = ReorderList(lnH);

            lnH = CreateList(new int[] { 1, 2, 3,4,5 });
            lnH = ReorderList(lnH);

            var rowD = GetRow(1);
            rowD = GetRow(2);
            rowD = GetRow(3);
            rowD = GetRow(4);

            int nc = ArrangeCoins(5);
            nc = ArrangeCoins(8);
            nc = ArrangeCoins(1);

            int maxP = MaxProduct(new int[] { 2, 3, -2, 4 });

            var arr = new int[] { -1 };
            Rotate(arr, 2);

            arr = new int[] { 1, 2, 3 };
            Rotate(arr, 1);

            arr = new int[] { 1, 2 };
            Rotate(arr, 1);

            uint ru = reverseBits(43261596);
            ru = reverseBits(15);
            ru = reverseBits(2);

            int rc = Compare(123, 12);

            string sr = LargestNumber(new int[] { 3, 30, 34, 5, 9 });
            sr = LargestNumber(new int[] { 1,2,3,1 });
            sr = LargestNumber(new int[] { 0,0 });

            string str = ReverseVowels("hello");
            str = ReverseVowels("leetcode");

            string cctr = ConvertToTitle(27);

            int c = CalculateMinimumHP(new int[,] { { 0, 0 } });
            c = CalculateMinimumHP(new int[,] { { 0, -3 } });
            c = CalculateMinimumHP(new int[,] { { -3, 5 } });

            int maxR = MaxRotateFunction(new int[] { 4, 3, 2, 6 });

            int minRep = IntegerReplacement(8);
            minRep = IntegerReplacement(2147483647);

            int cR = CompareVersion("1.1.1", "1.2");
            cR = CompareVersion("1.0", "1");
        }
        //public int CompareVersion(string version1, string version2)
        //{
        //    var v1Values = CalculateVersion(version1);
        //    var v2Values = CalculateVersion(version2);
        //    int i = 0;
        //    for (; i < Math.Min(v1Values.Count, v2Values.Count); i++)
        //    {
        //        if (v1Values[i] < v2Values[i])
        //        {
        //            return -1;
        //        }
        //        else if (v1Values[i] > v2Values[i])
        //        {
        //            return 1;
        //        }
        //    }
        //    if (i < v1Values.Count)
        //    {
        //        return 1;
        //    }
        //    else if (i < v2Values.Count)
        //    {
        //        return -1;
        //    }
        //    return 0;
        //}
        //long CalculateVersion(string v)
        //{
        //    int i = 0;
        //    int num = 0;
        //    int ans = 0;
        //    for (i = 0; i <= v.Length; i++)
        //    {
        //        if (i == v.Length || v[i] == '.')
        //        {
        //            ans = ans*10 + num;
        //            continue;
        //        }
        //        else
        //        {
        //            num = num * 10 + (v[i] - '0');
        //        }

        //    }
        //    return list;
        //}
        public bool IsUgly(int num)
        {
            if (num == 0) return false;
            if (num == 1) return true;
            if(num % 2 == 0)
            {
                return IsUgly(num / 2);
            }
            if (num % 3 == 0)
            {
                return IsUgly(num / 3);
            }
            if (num % 5 == 0)
            {
                return IsUgly(num / 5);
            }
            return false;
        }
        public int AddDigits(int num)
        {
            if (num == 0) return 0;
            if (num % 9 == 0) return 9;
            return num % 9;

        }
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode pre = dummy;
            while(pre != null && pre.next != null)
            {
                if(pre.next.val == val)
                {
                    pre.next = pre.next.next;
                }else
                {
                    pre = pre.next;
                }
                
            }
            return dummy.next;
        }
        int digitSquareSum(int n)
        {
            int sum = 0, tmp;
            while (n > 0)
            {
                tmp = n % 10;
                sum += tmp * tmp;
                n /= 10;
            }
            return sum;
        }

        public bool IsHappy(int n)
        {
            int slow, fast;
            slow = fast = n;
            do
            {
                slow = digitSquareSum(slow);
                fast = digitSquareSum(fast);
                fast = digitSquareSum(fast);
            } while (slow != fast);
            if (slow == 1) return true;
            else return false;
        }

        public int CompareVersion(string version1, string version2)
        {
            var v1Values = CalculateVersion(version1);
            var v2Values = CalculateVersion(version2);
            int i = 0;
            for (; i < Math.Min(v1Values.Count, v2Values.Count); i++)
            {
                if (v1Values[i] < v2Values[i])
                {
                    return -1;
                }
                else if (v1Values[i] > v2Values[i])
                {
                    return 1;
                }
            }
            if (i < v1Values.Count)
            {

                return Evaluate(v1Values, i);
            }
            else if (i < v2Values.Count)
            {
                return -Evaluate(v2Values, i);
            }
            return 0;
        }
        int Evaluate(IList<int> list,int start)
        {
            for (int i = start; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    return 1;
                }
            }
            return 0;
        }
        IList<int> CalculateVersion(string v)
        {
            IList<int> list = new List<int>();
            int i = 0;
            int num = 0;
            for (i = 0; i <= v.Length; i++)
            {
                if (i == v.Length || v[i] == '.')
                {
                    list.Add(num);
                    num = 0;
                    continue;
                }
                else
                {
                    num = num * 10 + (v[i] - '0');
                }

            }
            return list;
        }

        //public int NumIslands(char[,] grid)
        //{
        //    int mR = grid.GetLength(0);
        //    int mC = grid.GetLength(1);

        //    bool[,] mark = new bool[mR, mC];
        //    int num = 0;
        //    for(int i = 0; i < mR; i ++)
        //    {
        //        for(int j = 0;j < mC;j ++)
        //        {
        //            if(!mark[i,j] && grid[i,j] == 1)
        //            {
        //                num++;
        //                DfsNumIsland(grid,mark,i,j, num);

        //            }
        //        }
        //    }
        //    return num;
        //}
        //void DfsNumIsland(char[,] grid, bool[,] mark,int i, int j)
        //{
        //    int mR = grid.GetLength(0);
        //    int mC = grid.GetLength(1);
        //    int[][] cors = new int[][] { new int[] { 0, -1 }, new int[] { 0, 11 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
        //    for(int k = 0; k < cors.Length; k++)
        //    {
        //        if(i + cors[k][0] >= 0 && i + cors[k][0] < mR )
        //    }
        //}

        int minIR;
        public int IntegerReplacement(int n)
        {
            minIR = int.MaxValue;
            IntegerReplacementRecursive(n, 0);
            return minIR;
        }
        void IntegerReplacementRecursive(long n, int step)
        {
            if(n == 1)
            {
                if (step < minIR)
                    minIR = step;
                return;
            }
            if(n%2 == 0)
            {
                IntegerReplacementRecursive(n/2, step + 1);
            }else
            {
                IntegerReplacementRecursive(n -1, step + 1);
                IntegerReplacementRecursive(n + 1, step + 1);
            }
        }

        public int MaxRotateFunction(int[] A)
        {
            if (A.Length == 0) return 0;
            int max = int.MinValue;
            int sum = 0;
            int cur = 0;
            for (int i = 0;i < A.Length;i ++)
            {
                sum += A[i];
                cur += i * A[i];
            }
            max = cur;

            for (int k = 0;k < A.Length - 1;k ++)
            {
                cur -= sum;
                cur += A[k] * A.Length;
                max = Math.Max(max, cur);
            }
            return max;
        }

        public int HammingWeight(uint n)
        {
            int count = 0;
            uint one = 1;
            while(n > 0)
            {
                if ((n & one) != 0) count++;

                n = n >> 1;
            }
            return count;
        }

        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null) return list;

            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();
            q1.Enqueue(root);
            while(q1.Count > 0)
            {
                TreeNode cur = q1.Dequeue();
                if(cur.left != null)
                {
                    q2.Enqueue(cur.left);
                }
                if (cur.right != null)
                {
                    q2.Enqueue(cur.right);
                }
                if(q1.Count == 0)
                {

                    list.Add(cur.val);
                    Queue<TreeNode> tmp = q1;
                    q1 = q2;
                    q2 = tmp;
                }
            }
            return list;
        }

        
        public int CalculateMinimumHP(int[,] dungeon)
        {
            int nR = dungeon.GetLength(0);
            int nC = dungeon.GetLength(1);
            int[,] dp = new int[nR + 1, nC + 1];

            for (int i = 0; i < nR + 1; i ++)
            {
                for (int j = 0; j < nC + 1; j ++)
                {
                    dp[i, j] = int.MaxValue;
                }
            }

            dp[nR, nC - 1] = 1;
            dp[nR - 1, nC] = 1;
            for (int i = nR - 1; i >= 0; i--)
            {
                for (int j = nC - 1; j >= 0; j--)
                {
                    int need = Math.Min(dp[i + 1, j], dp[i, j + 1]) - dungeon[i, j];
                    dp[i, j] = need <= 0 ? 1 : need;

                }
            }

            return dp[0, 0];
        }

        //for(int i = 1; i < nR;i ++)
        //{
        //    dp[i, 0] = dp[i - 1, 0] - dungeon[i,0];
        //    dp[i, 0] = Math.Max(dp[i, 0], 1);
        //}
        //for (int j = 1; j < nC; j++)
        //{
        //    dp[0, j] = dp[0, j - 1] - dungeon[0, j];
        //    dp[0, j] = Math.Max(dp[0, j], 1);
        //}
        //return dp[nR - 1, nC - 1] > 1 ? 1 : dp[nR - 1, nC - 1];
        public string ConvertToTitle(int n)
        {
            StringBuilder sb = new StringBuilder();
            while(n > 0)
            {
                n--;
                char c = (char)(n % 26 + 'A');
                sb.Insert(0,c);
                n /= 26;
            }
            return sb.ToString();
        }
        public string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                Swap(sb, i, j);
                i++;
                j--;
            }
            return sb.ToString();
        }

        public int FindPeakElement(int[] num)
        {
            return helper(num, 0, num.Length - 1);
        }

        public int helper(int[] num, int start, int end)
        {
            if (start == end)
            {
                return start;
            }
            else if (start + 1 == end)
            {
                if (num[start] > num[end]) return start;
                return end;
            }
            else {

                int m = (start + end) / 2;

                if (num[m] > num[m - 1] && num[m] > num[m + 1])
                {

                    return m;

                }
                else if (num[m - 1] > num[m] && num[m] > num[m + 1])
                {

                    return helper(num, start, m - 1);

                }
                else {

                    return helper(num, m + 1, end);

                }

            }
        }

        //public int FindPeakElement(int[] nums)
        //{
        //    int n = nums.Length;
        //    for(int i = 0; i < n; i ++)
        //    {
                
        //        if ((i == 0 || nums[i] > nums[i - 1]) && (i == n-1 || nums[i] > nums[i + 1]))
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        public string ReverseVowels(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int i = 0, j = s.Length - 1;

            while(i < j)
            {
                if(!IsVowel(sb[i]))
                {
                    i++;
                    continue;
                }

                if (!IsVowel(sb[j]))
                {
                    j--;
                    continue;
                }
                Swap(sb, i, j);
                i++;
                j--;
            }
            return sb.ToString();

        }
        bool IsVowel(char c)
        {
            c = Char.ToLower(c);
            if (c == 'a' || c == 'e' || c == 'o' || c == 'i' || c == 'a' || c == 'u')
                return true;
            return false;
        }
        void Swap(StringBuilder sb, int i, int j)
        {
            char tmp = sb[i];
            sb[i] = sb[j];
            sb[j] = tmp;
        }

        public string LargestNumber(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i - 1 ; j >= 0;j --)
                {
                    if(Compare(nums[j],nums[j+1]) > 0)
                    {
                        Swap(nums, j, j + 1);
                    }
                }
            }
            string ans = "";
            for(int i = nums.Length - 1; i >= 0; i --)
            {
                if(ans == "" && nums[i] == 0)
                {
                    continue;
                }
                var v = nums[i];
                ans += v.ToString();
            }
            return ans == "" ? "0" : ans;
        }

        int Compare(int a, int b)
        {
            string s1 = a + "" + b;
            string s2 = b + "" + a;
            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i] > s2[i])
                {
                    return 1;
                }else if (s1[i] < s2[i])
                {
                    return -1;
                }
            }
            return 0;

            
        }
        void Swap(int[] a, int i, int j)
        {
            int tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
        int[] intBuff1 = new int[15];
        int[] intBuff2 = new int[15];
        //int countA = 0,countB = 0;
        //while(a > 0)
        //{
        //    intBuff1[countA++] = a % 10;
        //    a /= 10;
        //}
        //while (b > 0)
        //{
        //    intBuff2[countB++] = b % 10;
        //    b /= 10;
        //}



        //int i = countA - 1;
        //int j = countB - 1;
        //while(i >= 0 && j >= 0)
        //{
        //    if(intBuff1[i] > intBuff2[j])
        //    {
        //        return 1;
        //    }else if (intBuff1[i] < intBuff2[j])
        //    {
        //        return -1;
        //    }
        //    i--;
        //    j--;
        //}
        //if (i < 0 && j < 0) return 0;

        //if(i >=0)
        //{
        //    return intBuff1[i] > intBuff1[i + 1] ? 1 : 0;
        //}

        //return intBuff2[j] > intBuff2[j + 1] ? 1 : 0;
        
        public uint reverseBits(uint n)
        {
            uint ans = 0;
            int i = 0;
            while (i < 32)
            {
                uint d = n % 2;
                ans = ans * 2 + d;
                n = n >> 1;
                i++;
            }
            return ans;
        }
        //public uint reverseBits(uint n)
        //{
        //    uint ans = 0;
        //    while(n > 0)
        //    {
        //        uint d = n % 2;
        //        ans = ans * 2 + d;
        //        n = n >> 1;
        //    }
        //    return ans;
        //}

        //160. Intersection of Two Linked Lists
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;
            int nA = 0;
            int nB = 0;
            ListNode cur = headA;
            while (cur != null)
            {
                nA++;
                cur = cur.next;
            }
            cur = headB;
            while (cur != null)
            {
                nB++;
                cur = cur.next;
            }
            if (nB < nA)
            {
                int tmp = nA;
                nA = nB;
                nB = tmp;

                ListNode tmpNode = headA;
                headA = headB;
                headB = tmpNode;
            }
            int i = 0;
            while(i < nB - nA)
            {
                headB = headB.next;
                i++;
            }
            while(headA != null && headA != headB)
            {
                headB = headB.next;
                headA = headA.next;
            }
            return headA == null || headA != headB ? null : headA;


        }
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            int[] arr = new int[k];
            for (int i = 0; i < k; i++)
            {
                arr[i] = nums[nums.Length - k + i];
            }
            for (int i = nums.Length - 1; i >= k; i --)
            {
                nums[i] = nums[i - k];
            }
            for (int i = 0; i < k; i++)
            {
                nums[i] = arr[i];
            }
        }

        //public void Rotate(int[] nums, int k)
        //{
        //    k = k % nums.Length;
        //    for (int i = 0; i < k; i++)
        //    {
        //        int start = i;
        //        int tmp = nums[nums.Length - 1];
        //        for (int j = nums.Length - 1; j > start; j--)
        //        {
        //            nums[j] = nums[j - 1];
        //        }
        //        for (int j = start; j > 0; j--)
        //        {
        //            nums[j] = nums[j - 1];
        //        }
        //        nums[0] = tmp;
        //    }
        //}



        //169. Majority Element
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach(var n in nums)
            {
                int count = 0;
                if (dic.ContainsKey(n))
                {
                    dic[n]++;
                    count = dic[n];
                }
                else
                {
                    count = 1;
                    dic.Add(n, 1);
                }
                if (count > nums.Length / 2)
                {
                    return n;
                }

            }
            return 0;
        }

        //public string LargestNumber(int[] nums)
        //{

        //}

        //public int TrailingZeroes(int n)
        //{

        //}

        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;
            for(;i < j;)
            {
                if(numbers[i] + numbers[j] > target)
                {
                    j--;
                }else if (numbers[i] + numbers[j] == target)
                {
                    return new int[] { i + 1, j + 1 };
                }else
                {
                    i++;
                }
            }
            return new int[] { -1, -1 };
        }

        //public string ConvertToTitle(int n)
        //{

        //}

        public int MaxProduct(int[] nums)
        {
            int maxP = nums[0];
            int dpMax = nums[0];
            int dpMin = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int tmp = dpMax;
                dpMax = Math.Max(nums[i], dpMax * nums[i]);
                dpMax = Math.Max(dpMax, dpMin * nums[i]);

                dpMin = Math.Min(nums[i], dpMin * nums[i]);
                dpMin = Math.Min(dpMin, tmp * nums[i]);

                maxP = Math.Max(maxP, dpMax);
            }
            return maxP;
        }

        //213. House Robber II
        public int Rob(int[] nums)
        {
            return 1;
        }

        //Kth Largest Element in an Array: need to solve by selective algorithm
        public int FindKthLargest(int[] nums, int k)
        {
            if (k > nums.Length) return 0;
            Array.Sort(nums);
            return nums[nums.Length-k];

        }

        //public ListNode InsertionSortList(ListNode head)
        //{
        //    ListNode dummy = new ListNode(0);

        //    while (head != null)
        //    {
        //        ListNode node = dummy;
        //        while (node.next != null && node.next.val < head.val)
        //        {
        //            node = node.next;
        //        }
        //        ListNode temp = head.next;
        //        head.next = node.next;
        //        node.next = head;
        //        head = temp;
        //    }

        //    return dummy.next;
        //}

        //public ListNode InsertionSortList(ListNode head)
        //{
        //    if (head == null) return head;
        //    ListNode dummy = new ListNode(0);
        //    while (head != null)
        //    {
        //        ListNode cur = dummy;
        //        while (cur.next != end)
        //        {
        //            if (cur.next.val > end.val)
        //            {
        //                ListNode tmp = cur.next.next;
        //                cur.next.next = end.next;
        //                end.next = tmp;

        //                //ListNode tmp = cur.next.next;
        //                //cur.next.next = end.next;
        //                //cur.next = end;
        //                //end.next = tmp;
        //                //break;

        //            }
        //            cur = cur.next;
        //        }

        //        end = end.next;
        //    }
        //    return dummy.next;
        //}
        void Swap(ListNode n1, ListNode n2)
        {
            int tmp = n1.val;
            n1.val = n2.val;
            n2.val = tmp;
        }
        //public ListNode InsertionSortList(ListNode head)
        //{
        //    ListNode start = head;
        //    while (start != null && start.next != null)
        //    {
        //        ListNode cur = start.next;
        //        ListNode minN = start;
        //        while (cur != null)
        //        {
        //            if(cur.val < minN.val)
        //            {
        //                minN = cur;
        //            }
        //            cur = cur.next;
        //        }
        //        int tmp = start.val;
        //        start.val = minN.val;
        //        minN.val = tmp;

        //        start = start.next;
        //    }
        //    return head;
        //}

        int minMt = 0;
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count == 0) return 0;
            minMt = int.MaxValue;
            MinimumTotal(triangle, 0,0,0);
            return minMt;
        }
        void MinimumTotal(IList<IList<int>> triangle, int row, int cur, int sum)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            stack.Push(cur);
            while(stack.Count > 0)
            {
                cur = stack.Pop();
                stack.Push(cur);
                stack.Push(cur+ 1);
            }

            int v = triangle[row][cur];
            if (row == triangle.Count - 1)
            {
                if (sum + v < minMt)
                {
                    minMt = sum + v;
                }
                return;
            }
            int[] nexts = new int[] { cur, cur + 1 };
            for (int i = 0; i < nexts.Length; i++)
            {
                MinimumTotal(triangle, row + 1, nexts[i], sum + v);
            }
        }

        //void MinimumTotal(IList<IList<int>> triangle,int row,int cur,int sum)
        //{
        //    int v = triangle[row][cur];
        //    if(row == triangle.Count - 1)
        //    {
        //        if(sum + v < minMt)
        //        {
        //            minMt = sum + v;
        //        }
        //        return;
        //    }
        //    int[] nexts = new int[] { cur,cur + 1};
        //    for(int i = 0; i < nexts.Length;i ++)
        //    {
        //        MinimumTotal(triangle, row + 1, nexts[i],sum + v);
        //    }
        //}

        IList<IList<int>> pathSumAns;
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            
            pathSumAns = new List<IList<int>>();
            if (root == null)
                return pathSumAns;
            IList<int> list = new List<int>();
            PathSumDfs(root, sum, list);
            return pathSumAns;
        }
        void PathSumDfs(TreeNode root, int sum,IList<int> list)
        {
            if(root.left == null && root.right == null && root.val == sum)
            {
                List<int> newList = new List<int>();
                newList.AddRange(list);
                pathSumAns.Add(newList);
                newList.Add(root.val);
                return;
            }
            if(root.left != null)
            {
                int index = list.Count;
                list.Add(root.val);
                PathSumDfs(root.left,sum- root.val,list);
                list.RemoveAt(index);
            }
            if (root.right != null)
            {
                int index = list.Count;
                list.Add(root.val);
                PathSumDfs(root.right, sum - root.val, list);
                list.RemoveAt(index);
            }
        }

        //77. Combinations
        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> list = new List<IList<int>>();
            Combine(n, k, 0, list);
            return list;
        }
        void Combine(int n, int k,int start, IList<IList<int>> list )
        {
            for(int i = start; i < n - k;i ++)
            {
                
            }
        }
        public int ArrangeCoins(int n)
        {

            int k = 1;
            while(n >= k)
            {
                n -= k;
                k++;
            }
            return  k - 1;
        }
        //437. Path Sum III
        //public int PathSum(TreeNode root, int sum)
        //{
        //    int countP = 0;
        //    if (root == null) return 0;

        //    countP += TrarvelDfs(root, sum);
        //    if(root.left != null)
        //        countP += PathSum(root.left, sum);
        //    if (root.right != null)
        //        countP += PathSum(root.right, sum);
        //    return countP;
        //}
        int TrarvelDfs(TreeNode root, int sum)
        {
            int countP = 0;
            if(root.val == sum)
            {
                countP++;
            }
            if(root.left != null)
            {
                countP += TrarvelDfs(root.left, sum - root.val);
            }
            if (root.right != null)
            {
                countP += TrarvelDfs(root.right, sum - root.val);
            }
            return countP;

        }

        //Pascal's Triangle II
        public IList<int> GetRow(int rowIndex)
        {
            
            if (rowIndex == 0 ) return new int[] { 1 };
            int len = rowIndex + 1;
            int[] arr = new int[len];
            arr[0] = 1; arr[1] = 1;
            for(int i = 2;i <= rowIndex;i ++)
            {
                int pre = 1;
                for(int j = 1;j < i ;j ++)
                {
                    int tmp = arr[j];
                    arr[j] = pre + arr[j];
                    pre = tmp;
                }
                arr[i] = 1;
            }
            return arr;
        }
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if(root != null)
                PreOrderDfs(root,list);
            return list;
        }
        private void PreOrderDfs(TreeNode root, List<int> list)
        {
            list.Add(root.val);
            if(root.left != null)
            {
                PreOrderDfs(root.left,list);
            }
            if (root.right != null)
            {
                PreOrderDfs(root.right, list);
            }
        }

        ListNode CreateList(int []arr)
        {
            ListNode head = new ListNode(arr[0]);
            ListNode cur = head;
            for(int i = 1;i < arr.Length;i ++)
            {
                cur.next = new ListNode(arr[i]);
                cur = cur.next;
            }
            return head;
        }

        public ListNode ReorderList(ListNode head)
        {
            ListNode cur = head;
            while (cur != null && cur.next != null && cur.next.next != null)
            {
                ListNode next = cur.next;
                ListNode preLast = cur.next;
                ListNode last = cur.next.next;
                while(last.next != null)
                {
                    preLast = preLast.next;
                    last = last.next;
                }
                cur.next = last;
                last.next = next;
                preLast.next = null;

                cur = next;
            }
            return head;
        }

        // need to work on O(n)
        //128. Longest Consecutive Sequence
        public int LongestConsecutive(int[] nums)
        {
            Array.Sort(nums);
            int max = 1;
            int count = 1;
            for(int i = 1;i < nums.Length; i++)
            {
                if(nums[i] == nums[i - 1])
                {
                    continue;
                }
                if (nums[i] == nums[i - 1] + 1)
                {
                    count++;
                }else
                {
                    max = Math.Max(count, max);
                    count = 1;
                }
            }
            max = Math.Max(count, max);
            return max;
        }

        public bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length- 1;
            while(i < j)
            {
                if(!IsChar(s[i]) )
                {
                    i++;
                    continue;
                }
                if(!IsChar(s[j]))
                {
                    j--;
                    continue;
                }
                if(Char.ToLower(s[i]) == Char.ToLower(s[j]))
                {
                    i++;
                    j--;
                }else
                {
                    return false;
                }
            }
            return true;
        }

        bool IsChar(char c)
        {
            c = Char.ToLower(c);
            if(c >= 'a' && c <= 'z')
            {
                return true;
            }else if (c >= '0' && c <= '9')
            {
                return true;
            }
            return false;
        }
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null) return null;
            ListNode slow = head;
            ListNode fast = head.next;

            // Search for loop using slow and fast pointers
            while (fast != null && fast.next != null)
            {
                if (slow == fast)
                    break;
                slow = slow.next;
                fast = fast.next.next;
            }

            /* If loop exists */
            if (slow == fast)
            {
                slow = head;
                while (slow != fast.next)
                {
                    slow = slow.next;
                    fast = fast.next;
                }

                /* since fast->next is the looping point */
                return fast.next; /* remove loop */
            }else
            {
                return null;
            }
        }

        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;
            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;
                slow = slow.next;
                fast = fast.next.next;
                
            }
            return true;
        }

        //102. Binary Tree Level Order Traversal
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            if (root == null) return ans;
            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();
            TreeNode current = root;
            q1.Enqueue(current);

            List<int> sameLevelList = new List<int>();
            while (q1.Count > 0)
            {
                current = q1.Dequeue();
                sameLevelList.Add(current.val);
                if(current.left != null)
                {
                    q2.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    q2.Enqueue(current.right);
                }

                if (q1.Count == 0)
                {
                    ans.Add(sameLevelList);
                    sameLevelList = new List<int>();

                    q1 = q2;
                    q2 = new Queue<TreeNode>();
                }
            }
            return ans;
        }
        //127. Word Ladder
        public int LadderLength(string beginWord, string endWord, ISet<string> wordList)
        {
            return BfsLadder(beginWord, endWord, wordList);
        }

        int BfsLadder(string current, string endWord, ISet<string> wordList)
        {
            HashSet<string> hsLadder = new HashSet<string>();

            Queue<string> q1 = new Queue<string>();
            Queue<string> q2 = new Queue<string>();
            q1.Enqueue(current);
            int depth = 1;
            hsLadder.Add(current);
            while (q1.Count > 0)
            {
                current = q1.Dequeue();
                
                if (current == endWord)
                {
                    return depth;
                }else if (DifferentOne( current,endWord))
                {
                    return depth + 1;
                }


                for (int i = 0; i < current.Length; i++)
                {
                    StringBuilder sb = new StringBuilder(current);
                    for (char c = 'a'; c < 'z'; c++)
                    {
                        if (c == current[i]) continue;

                        sb[i] = c;
                        string w = sb.ToString();
                        if (wordList.Contains(w))
                        {
                            if (!hsLadder.Contains(w))
                            {
                                hsLadder.Add(w);
                                q2.Enqueue(w);
                            }
                        }
                    }
                }
                if(q1.Count == 0)
                {
                    depth++;
                    q1 = q2;
                    q2 = new Queue<string>();
                }

            }
            return 0;
        }

        bool DifferentOne(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    count++;
                }
            }
            return count == 1;
        }


        //void BfsLadder(string current, string endWord, ISet<string> wordList)
        //{
        //    //if (minLengthLadder < int.MaxValue) return;
        //    if(current == endWord )
        //    {
        //        minLengthLadder = Math.Min(minLengthLadder, hsLadder.Count);
        //        return;
        //    }
        //    if (DifferentOne(current, endWord))
        //    {
        //        minLengthLadder = Math.Min(minLengthLadder, hsLadder.Count + 1 );
        //        return;
        //    }
        //    foreach (var w in wordList)
        //    {
        //        if (hsLadder.Count < minLengthLadder && !hsLadder.Contains(w) && DifferentOne(w, current))
        //        {
        //            hsLadder.Add(w);
        //            DfsLadder(w, endWord, wordList);
        //            hsLadder.Remove(w);
        //        }
        //    }


        //    //for(int i = 0;i < current.Length;i ++)
        //    //{
        //    //    StringBuilder sb = new StringBuilder(current);
        //    //    for (char c = 'a'; c < 'z'; c++)
        //    //    {
        //    //        if (c == current[i]) continue;

        //    //        sb[i] = c;
        //    //        string w = sb.ToString();
        //    //        if(wordList.Contains(w))
        //    //        {
        //    //            if (hsLadder.Count < minLengthLadder && !hsLadder.Contains(w))
        //    //            {
        //    //                hsLadder.Add(w);
        //    //                BfsLadder(w, endWord, wordList);
        //    //                hsLadder.Remove(w);
        //    //            }
        //    //        }
        //    //    }
        //    //}

        //    //foreach (var w in wordList)
        //    //{
        //    //    if (hsLadder.Count < minLengthLadder && !hsLadder.Contains(w) && DifferentOne(w, current))
        //    //    {
        //    //        hsLadder.Add(w);
        //    //        DfsLadder(w, endWord, wordList);
        //    //        hsLadder.Remove(w);
        //    //    }
        //    //}

        //}


        //public bool WordPattern(string pattern, string str)
        //{
        //    int n = 26;
        //    string[] allWords = new string[n];
        //    int[] allPatternCount = new int[n]; 
        //    int start = -1;

        //    Dictionary<char, string> dic = new Dictionary<char, string>();
        //    int wordCount = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (start == -1 && str[i] != ' ')
        //        {
        //            start = i;
        //        }
        //        if (start >= 0 && str[i] != ' ' && (i == str.Length - 1 || str[i + 1] == ' '))
        //        {
        //            string word = str.Substring(start, i - start + 1);


        //            if (pattern.Length < wordCount + 1)
        //            {
        //                return false;
        //            }
        //            int index = pattern[wordCount] - 'a';

        //            if (allPatternCount[index] > 0 )
        //            {
        //                if(allWords[index] != word)
        //                {
        //                    return false;
        //                }
        //                else
        //                {

        //                }
        //            }else
        //            {
        //                allPatternCount[index]++;
        //                allWords[index] = word;
        //            }

        //            for (int j = 0; j < n; j++)
        //            {
        //                if (j != index && allWords[j] == word)
        //                    return false;
        //            }


        //            wordCount++;

        //            start = -1;
        //        }
        //    }
        //    if (wordCount != pattern.Length) return false;
        //    return true;

        //}
        public bool WordPattern(string pattern, string str)
        {
            int start = -1;
            List<string> words = new List<string>();
            Dictionary<char, string> dic = new Dictionary<char, string>();
            Dictionary<string, char> dicInverse = new Dictionary<string, char>();
            int wordCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (start == -1 && str[i] != ' ')
                {
                    start = i;
                }
                if (start >= 0 && str[i] != ' ' && (i == str.Length - 1 || str[i + 1] == ' '))
                {
                    string word = str.Substring(start, i - start + 1);
                    if (pattern.Length < wordCount + 1)
                    {
                        return false;
                    }
                    if (!dic.ContainsKey(pattern[wordCount]))
                    {
                        dic.Add(pattern[wordCount], word);
                    }
                    else
                    {
                        if (dic[pattern[wordCount]] != word)
                        {
                            return false;
                        }
                    }
                    if (!dicInverse.ContainsKey(word))
                    {
                        dicInverse.Add(word,pattern[wordCount]);
                    }
                    else
                    {
                        if (dicInverse[word] != pattern[wordCount])
                        {
                            return false;
                        }
                    }

                    wordCount++;

                    start = -1;
                }
            }
            if (wordCount != pattern.Length) return false;
            return true;

        }

        //Length of Last Word
        public int LengthOfLastWord(string s)
        {
            int start = -1;
            for (int i = s.Length - 1; i >= 0 ; i --)
            {
                if(start == -1 && s[i] != ' ')
                {
                    start = i;
                }
                if(start > -1 && (i == 0 || s[i - 1] == ' ' ) )
                {
                    return start - i + 1;
                }
            }
            return 0;
        }

        //Reverse Words in a String
        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            ReverseString(sb, 0, s.Length - 1);

            int n = sb.Length;
            int start = n;
            char spc = ' ';
            for(int i = 0;i < sb.Length; i++)
            {
                if(start == n && sb[i] != spc)
                {
                    start = i;
                }

                if (start < n && (i == sb.Length - 1 || sb[i + 1] == spc))
                {
                    ReverseString(sb, start, i);
                    start = n;
                }

            }
            int newLen = ShiftBlank(sb);
            return sb.ToString().Substring(0,newLen);
        }
        void ReverseString(StringBuilder str,int start,int end)
        {
            while(start < end)
            {
                char c = str[start];
                str[start] = str[end];
                str[end] = c;
                start++;
                end--;
            }
        }

        int ShiftBlank(StringBuilder str)
        {
            if (str.Length < 1) return 0;
            char spc = ' ';
            int shift = str[0] == spc ? 1 : 0;
            int last = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if(( i + 1 < str.Length && str[i] == spc && str[i + 1] == spc))
                {
                    shift++;
                }
                if(str[i] != spc)
                {
                    last = i - shift;
                    str[i - shift] = str[i];
                    if(last != i)
                        str[i] = spc;
                }
            }
            return last + 1;
        }

        //https://roy3221.gitbooks.io/algorithms/content/CH5%20DP/leetcode_139_word_break.html
        public bool WordBreak(string s, ISet<string> wordDict)
        {
            int n = s.Length;
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for(int i = 1;i <= s.Length;i ++)
            {
                foreach(var w in wordDict)
                {
                    if(IsTail(w,s,i - 1))
                    {
                        if (dp[i - w.Length])
                        {
                            dp[i] = true;
                            break;
                        }
                    }
                }
            }
            return dp[n ];
        }
        bool IsTail(string w,string s,int end)
        {
            int len = s.Length;
            if (w.Length > end + 1) return false;
            for(int i = w.Length - 1; i >= 0; i --)
            {
                if (w[i] != s[end - (w.Length - 1 - i)]) return false;
            }
            return true;
        }


        //139. Word Break
        bool bFoundWB = false;
        TrieNode originalRoot = null;
        Trie trie;
        public bool WordBreak1(string s, ISet<string> wordDict)
        {
            bFoundWB = false;
            trie = new Trie(wordDict);
            originalRoot = trie.Root;
            DfsWord(originalRoot,s,0);
            return bFoundWB;
        }
        void DfsWord(TrieNode root,string s,int index)
        {
            if (bFoundWB) return;
            if(index == s.Length)
            {
                if(trie.HasEnd(root))
                {
                    bFoundWB = true;
                }
                
                return;
            }
         
            if(root.HasEnd)
            {
                DfsWord(originalRoot, s, index);
            }
            foreach(var n in root.Children)
            {
                if(n.Val == s[index])
                {
                    DfsWord(n, s, index + 1);
                }
            }
            
        }

        //https://leetcode.com/problems/word-break/

        
        public int SingleNumber(int[] nums)
        {
            int ans = nums[0];
            for(int i = 1;i < nums.Length;i ++)
            {
                ans ^= nums[i];
            }
            return ans;
        }

        int sumAll = 0;
        public int SumNumbers(TreeNode root)
        {
            sumAll = 0;
            if (root == null) return 0;

            DfsSumNumbers(root, 0);
            return sumAll;
        }
        void DfsSumNumbers(TreeNode root,int sum)
        {
            sum =sum*10 + root.val;
            if (root.left == null && root.right == null)
            {
                sumAll += sum;
                return;
            }
            if(root.left != null)
            {
                DfsSumNumbers(root.left, sum);
            }
            if (root.right != null)
            {
                DfsSumNumbers(root.right, sum);
            }
        }

        //Best Time to Buy and Sell Stock II
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 1) return 0;

            int minSoFar = prices[0];
            int maxProfit = 0;
            int n = prices.Length;
            for (int i = 1;i < n; i++)
            {
                if(i == n -1 ||  prices[i + 1] < prices[i])
                {
                    if(prices[i] - minSoFar > 0)
                    {
                        maxProfit += prices[i] - minSoFar;
                        minSoFar = prices[i];
                    }
                }
                minSoFar = Math.Min(minSoFar, prices[i]);
            }
            return maxProfit;
        }

        public int MaxProfit1(int[] prices)
        {
            int max = 0;
            if (prices.Length < 1) return 0;
            int minSoFar = prices[0];
            for(int i = 1;i < prices.Length;i ++)
            {
                if (prices[i] - minSoFar > max)
                    max = prices[i] - minSoFar;
                minSoFar = Math.Min(prices[i],minSoFar);
            }
            return max;
        }

        //108. Convert Sorted Array to Binary Search Tree
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return CreateBST(nums,0,nums.Length - 1);
        }
        public TreeNode CreateBST(int[] nums,int left,int right)
        {
            if (left > right) return null;
            int mid = (right - left) / 2 + left;
            TreeNode root = new TreeNode(nums[mid]);
            TreeNode leftN = CreateBST(nums,left, mid - 1);
            TreeNode rightN =CreateBST(nums, mid  + 1, right);
            root.left = leftN;
            root.right = rightN;
            return root;
        }

        //http://www.programcreek.com/2014/03/leetcode-gas-station-java/
        //has better solution
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int n = gas.Length;
            for(int i = 0;i < n; i++)
            {
                int gasRemain = 0;
                int j = 0;
                for(;j < n;j ++)
                {
                    int index = i + j;
                    if(index >= n)
                    {
                        index -= n;
                    }
                    if(gasRemain + gas[index] >= cost[index])
                    {
                        gasRemain += gas[index] - cost[index];
                    }else
                    {
                        break;
                    }
                }
                if (j >= n)
                    return i;

            }
            return -1;
        }
        //112. Path Sum
        public bool HasPathSum(TreeNode root, int sum)
        {
            bFoundCP = false;
            if (root == null) return false;
            CalculatePath(root,sum);
            return bFoundCP;
        }
        bool bFoundCP = false;
        void CalculatePath(TreeNode root, int sum)
        {
            if (bFoundCP) return;
            if(root.left == null && root.right == null)
            {
                if(sum == root.val)
                {
                    bFoundCP = true;
                }
                return;
            }
            if(root.left != null)
            {
                CalculatePath(root.left, sum - root.val);
            }
            if (root.right != null)
            {
                CalculatePath(root.right, sum - root.val);
            }
        }
    }
}
