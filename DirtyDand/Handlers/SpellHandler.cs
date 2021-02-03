using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static DirtyDand.Globals.GlobalVariables;

namespace DirtyDand.Handlers
{
    public class SpellHandler
    {
        public SpellHandler()
        {
            string result;
            result = File.ReadAllText("Spells5e.txt");
            string[] spells = result.Split('~');

            foreach(string e in spells)
            {
                //Splits file into spells
                string[] lines = e.Split('\n');
                
                //Gets the spell name
                string name = lines[0];
                
                //Gets the spell level
                int level = 0;
                if (Int32.TryParse(lines[1].Substring(0, 1), out int strLevel))
                    level = strLevel;
                
                //Gets the spell lines[1]
                School eSchool;
                if (lines[1].IndexOf("Abjuration") >= 0 || lines[1].IndexOf("abjuration") >= 0)
                    eSchool = School.Abjuration;
                else if (lines[1].IndexOf("Conjuration") >= 0 || lines[1].IndexOf("conjuration") >= 0)
                    eSchool = School.Conjuration;
                else if (lines[1].IndexOf("Divination") >= 0 || lines[1].IndexOf("divination") >= 0)
                    eSchool = School.Divination;
                else if (lines[1].IndexOf("Enchantment") >= 0 || lines[1].IndexOf("enchantment") >= 0)
                    eSchool = School.Enchantment;
                else if (lines[1].IndexOf("Evocation") >= 0 || lines[1].IndexOf("evocation") >= 0)
                    eSchool = School.Evocation;
                else if (lines[1].IndexOf("Illusion") >= 0 || lines[1].IndexOf("illusion") >= 0)
                    eSchool = School.Illusion;
                else if (lines[1].IndexOf("Necromancy") >= 0 || lines[1].IndexOf("necromancy") >= 0)
                    eSchool = School.Necromancy;
                else if (lines[1].IndexOf("Transmutation") >= 0 || lines[1].IndexOf("transmutation") >= 0)
                    eSchool = School.Transmutation;
                
                //Gets the spell casting time
                Time time;
                if (lines[2].IndexOf("1 action") == 0)
                    time = Time.A;
                else if (lines[2].IndexOf("1 bonus action") == 0)
                    time = Time.Ba;
                else if (lines[2].IndexOf("1 reaction") == 0)
                    time = Time.R;
                else if (lines[2].IndexOf("1 minute") == 0)
                    time = Time.M;
                else if (lines[2].IndexOf("10 minutes") == 0)
                    time = Time.Ms;
                else if (lines[2].IndexOf("1 hour") == 0)
                    time = Time.H;
                // Gets the range of the spell
                string fRange = lines[3].Substring(7, 8);
                int range;
                if (Int32.TryParse(lines[1].Substring(0, 1), out int strRange))
                    range = strRange;
                else if (fRange.Equals("T"))
                    range = 1;
                else
                    range = 0;

                //Gets the spell components
                List<Components> compsList = new List<Components>();
                string materials = String.Empty;
                if (lines[4].IndexOf("M") >= 0)
                    compsList.Add(Components.M);
                else if (lines[4].IndexOf("S") >= 0)
                    compsList.Add(Components.S);
                else if(lines[4].IndexOf("M") >= 0)
                {
                    compsList.Add(Components.M);
                    materials = lines[4].Substring(lines[4].IndexOf("M") + 2);
                }
                
                //Gets the spell duration
                string duration = lines[5];
                
                //Gets the full spell description
                string description = String.Empty;
                int count = 7;
                while(!lines[count].Substring(0, 8).Equals("Classes: "))
                {
                    description += lines[count];
                    count++;
                }

                //Gets the list of classes able to use the spell
                //Artificer, Bard, Cleric, Druid, Paladin, Ranger, Sorcerer, Warlock, Wizard
                List<Caster> casterList = new List<Caster>();
                string classList = lines[count];
                if (lines[count].IndexOf("Artificer") >= 0)
                    casterList.Add(Caster.Artificer);
                else if (lines[count].IndexOf("Bard") >= 0)
                    casterList.Add(Caster.Bard);
                else if (lines[count].IndexOf("Cleric") >= 0)
                    casterList.Add(Caster.Cleric);
                else if (lines[count].IndexOf("Druid") >= 0)
                    casterList.Add(Caster.Druid);
                else if (lines[count].IndexOf("Paladin") >= 0)
                    casterList.Add(Caster.Paladin);
                else if (lines[count].IndexOf("Ranger") >= 0)
                    casterList.Add(Caster.Ranger);
                else if (lines[count].IndexOf("Sorcerer") >= 0)
                    casterList.Add(Caster.Sorcerer);
                else if (lines[count].IndexOf("Warlock") >= 0)
                    casterList.Add(Caster.Warlock);
                else if (lines[count].IndexOf("Wizard") >= 0)
                    casterList.Add(Caster.Wizard);

                //Gets the source the spell was published from
                string source = lines[lines.Count() - 2];

            }
        }
    }
}
