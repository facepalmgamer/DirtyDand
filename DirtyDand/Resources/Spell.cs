using System;
using System.Collections.Generic;
using static DirtyDand.Globals.GlobalVariables;

namespace DirtyDand.Resources
{
    public class Spell
    {

        private String spellName;
        private String spellDescript;
        private School school;
        private bool concentration;
        private bool ritual;
        private Time time;
        private string duration;
        private int level;
        private int range;
        private List<Caster> casterList;
        private List<Components> componentsList;
        private string material;
        private Source source;

        public Spell(String spellName, String spellDescript, School school, bool concentration, bool ritual, Time time, string duration, int level, int range, List<Caster> casterList, List<Components> componentsList, Source source, string material = "")
        {
            this.spellName = spellName;
            this.spellDescript = spellDescript;
            this.school = school;
            this.concentration = concentration;
            this.ritual = ritual;
            this.time = time;
            this.duration = duration;
            this.level = level;
            this.range = range;
            this.casterList = casterList;
            this.componentsList = componentsList;
            this.material = material;
            this.source = source;
        }

        public string GetSpellName()
        {
            return spellName;
        }
        public string GetSpellDescription()
        {
            return spellDescript;
        }

        public School GetSchool()
        {
            return school;
        }

        public bool GetConcentration()
        {
            return concentration;
        }
        public bool GetRitual()
        {
            return ritual;
        }
        public Time GetTime()
        {
            return time;
        }

        public string GetDuration()
        {
            return duration;
        }
        public int GetLevel()
        {
            return level;
        }

        public int GetRange()
        {
            return range;
        }

        public List<Caster> GetCasters()
        {
            return casterList;
        }

        public List<Components> GetComponents()
        {
            return componentsList;
        }

        public string GetMaterial()
        {
            return material;
        }

        public Source GetSource()
        {
            return source;
        }
    }
}
