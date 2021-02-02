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
        private int duration { get; }
        private int level { get; }
        private int range { get; }
        private Caster casterList { get; }
        //private List<Components>() {get;}

        public Spell(String spellName, String spellDescript, School school, bool concentration, Time time, int duration, int level, int range, Caster casterList)
        {
            this.spellName = spellName;
            this.spellDescript = spellDescript;
            this.school = school;
            this.concentration = concentration;
            this.time = time;
            this.duration = duration;
            this.level = level;
            this.range = range;
            this.casterList = casterList;
        }
    }
}
