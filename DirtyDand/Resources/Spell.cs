using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DirtyDand.Globals.GlobalVariables;

namespace DirtyDand.Resources
{
    public class Spell
    {

        private String spellName { get; }
        private String spellDescript { get; }
        private School school { get; }
        private bool concentration { get; }
        private Time time { get; }
        private string duration { get; }
        private int level { get; }
        private int range { get; }
        private List<Caster> casterList { get; }
        private List<Components> componentsList{get;}
        string material;
        private bool ritual;

        public Spell(String spellName, String spellDescript, School school, bool ritual, bool concentration, Time time, string duration, int level, int range, List<Caster> casterList, List<Components> componentsList, string material = "")
        {
            this.spellName = spellName;
            this.spellDescript = spellDescript;
            this.school = school;
            this.ritual = ritual;
            this.concentration = concentration;
            this.time = time;
            this.duration = duration;
            this.level = level;
            this.range = range;
            this.casterList = casterList;
            this.componentsList = componentsList;
            this.material = material;
        }
    }
}
