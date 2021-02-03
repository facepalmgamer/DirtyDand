using DirtyDand.Resources;
using System.Collections.Generic;

namespace DirtyDand.Globals
{
    public static class GlobalVariables
    {
        public static List<Race> raceRegistry = new List<Race>();
        public static List<CClass> classRegistry = new List<CClass>();
        public static List<Spell> spellRegistry = new List<Spell>();
        public static List<Background> backgroundRegistry = new List<Background>();

        public enum School { Abjuration, Conjuration, Divination, Enchantment, Evocation, Illusion, Necromancy, Transmutation };
        public enum Caster { Artificer, Bard, Cleric, Druid, Paladin, Ranger, Sorcerer, Warlock, Wizard };
        public enum Time { A, Ba, R, M, Ms, H, Hs, day };
        public enum Alignment { lg, ln, le, ng, n, ne, cg, cn, ce };
        public enum AbilityScores { Str, Dex, Con, Int, Wis, Cha };
        public enum Components { V, S, M };
        public enum Source {AI, DMG, ERLW, EEPC, EGW, GGR, IDRotF, MTF, MOT, PHB, SCAG, TCE, VGM, XGE, AWM, LR, LLK, OGA, PS, TTP, UA, WGE };

    }
}
