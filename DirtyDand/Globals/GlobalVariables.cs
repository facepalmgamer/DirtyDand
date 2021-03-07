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
            this.key = key.ToLower().Trim();
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
        public static List<ToolTip> toolTips = new List<ToolTip>
        {
            new ToolTip("Incapacitated", "An incapacitated creature can't take Actions or Reactions"),
            new ToolTip("Deafened","A deafend creature can't hear and automatically fails any ability check that requires hearing")
        };


        #endregion


        #region colors
        public static Color red = Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        #endregion

        #region Enums
        public enum School
        {
            Abjuration,
            Conjuration,
            Divination,
            Enchantment,
            Evocation,
            Illusion,
            Necromancy,
            Transmutation
        }
        public enum Caster
        {
            Artificer,
            Bard,
            Cleric,
            Druid,
            Paladin,
            Ranger,
            Sorcerer,
            Warlock,
            Wizard
        }
        public enum Time
        {
            A,
            Ba,
            R,
            M,
            Ms,
            H,
            day
        }
        public enum Alignment
        {
            LG,
            LN,
            LE,
            NG,
            TN,
            NE,
            CG,
            CN,
            CE
        }
        public enum Abilities
        {
            Str,
            Dex,
            Con,
            Int,
            Wis,
            Cha
        }
        public enum Components
        {
            V,
            S,
            M
        }
        public enum Source
        {
            AI,
            DMG,
            ERLW,
            EEPC,
            EGW,
            GGR,
            IDRotF,
            MTF,
            MOT,
            PHB,
            SCAG,
            TCE,
            VGM,
            XGE,
            AWM,
            LR,
            LLK,
            OGA,
            PS,
            TTP,
            UA,
            WGE
        }
        public enum Dice
        {
            D4,
            D6,
            D8,
            D12,
            D20
        }
        public enum DamageType
        {
            Acid,
            Bludgeoning,
            Cold,
            Fire,
            Force,
            Lightning,
            Necrotic,
            Piercing,
            Poison,
            Psychic,
            Radiant,
            Slashing,
            Thunder
        }
        public enum WeaponProperty
        {
            Light,
            Finesse,
            Thrown,
            TwoHanded,
            Versitile,
            Loading,
            Ammunition,
            Heavy,
            Reach,
            Special
        }
        public enum ArtisiansTools
        {
            AlchemistsSupplies,
            BrewersSupplies,
            CalligraphersSupplies,
            CarpentersTools,
            CartographersTools,
            CobblersTools,
            CiijsUtensils,
            DisguiseKits,
            ForgeryKit,
            GlassblowersTools,
            HearbalismKit,
            JewelersTools,
            LeatherworkersTools,
            MasonsTools,
            NavigatorsTools,
            PaintersSupplies,
            PoisonersKit,
            PottersTools,
            SmithsTools,
            ThievesTools,
            TinkersTools,
            WeaversTools,
            WoodcarversTools
        }
        public enum Skills
        {
            Acrobatics,
            AnimalHandling,
            Arcana,
            Athletics,
            Deception,
            History,
            Insightm,
            Intimidation,
            Investigation,
            Medicine,
            Nature,
            Perception,
            Performance,
            Persuasion,
            Religion,
            SlightOfHand,
            Stealth,
            Survival
        }
        public enum Languages
        {
            Abyssal,
            Celestial,
            Common,
            DeepSpeech,
            Draconic,
            Dwarvish,
            Giant,
            Gnomish,
            Goblin,
            Halfling,
            Infernal,
            Orc,
            Primordial,
            UnderCommon
        }
        public enum ArmorType
        {
            Heavy,
            Light,
            Medium,
            Shield
        }
        public enum WeaponType
        {
            Impovrished,
            Martial,
            Simple,
            Unarmed,
            Firearm
        }
        #endregion

        
           

        


    }
}
