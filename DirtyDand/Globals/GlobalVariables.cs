using DirtyDand.Classes;
using System.Collections.Generic;
using System.Drawing;

namespace DirtyDand.Globals
{
    public struct ToolTip
    {
        string key { get; }
        string info { get; }
        public ToolTip(string key, string info)
        {
            this.key = key;
            this.info = info;
        }
    }
    public static class GlobalVariables
    {
        #region Registries
        public static List<Race> raceRegistry = new List<Race>();
        public static List<CClass> classRegistry = new List<CClass>();
        public static List<Spell> spellRegistry = new List<Spell>();
        public static List<Background> backgroundRegistry = new List<Background>();
        public static List<Character> characterRegistry = new List<Character>();
        #endregion

        #region colors
        public static Color red = Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        #endregion

        #region Enums
        public enum School { Abjuration, Conjuration, Divination, Enchantment, Evocation, Illusion, Necromancy, Transmutation };
        public enum Caster { Artificer, Bard, Cleric, Druid, Paladin, Ranger, Sorcerer, Warlock, Wizard };
        public enum Time { A, Ba, R, M, Ms, H, day };
        public enum Alignment { lg, ln, le, ng, n, ne, cg, cn, ce };
        public enum AbilityScores { Str, Dex, Con, Int, Wis, Cha };
        public enum Components { V, S, M };
        public enum Source { AI, DMG, ERLW, EEPC, EGW, GGR, IDRotF, MTF, MOT, PHB, SCAG, TCE, VGM, XGE, AWM, LR, LLK, OGA, PS, TTP, UA, WGE };
        #endregion

        #region ToolTip List
        public static ToolTip[] toolTips =
        {
            new ToolTip("test","test"),
            new ToolTip("test1","test"),
            new ToolTip("test2","test"),
            new ToolTip("test3","test"),
            new ToolTip("test4","test"),
            new ToolTip("test5","test")

        };
        #endregion



    }
}
