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
                string spellName = lines[0];
                
                //Gets the spell level
                int level = 0;
                if (Int32.TryParse(lines[1].Substring(0, 1), out int strLevel))
                    level = strLevel;
                
                //Gets the spell school
                School eSchool = School.Abjuration;
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
               
                //Determines if the spell can be ritual cast
                bool ritual = false;
                if (lines[1].Contains("(ritual)"))
                    ritual = true;
                
                //Gets the spell casting time
                Time time = Time.A;
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
                string fRange = lines[3].Substring(7, 1);
                int range;
                if (!Int32.TryParse(lines[1].Substring(0, 1), out range))
                {
                    if (fRange.Equals("T"))
                        range = 1;//Touch Range
                    else
                        range = 0;//Self Range
                }

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
                string duration = lines[5].Substring(10);
                bool concentration = false;
                if (duration.Contains("Concentration"))
                    concentration = true;
                
                //Gets the full spell description
                string description = String.Empty;
                int count = 7;
                while(!lines[count].Contains("Classes: "))
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
                Source source = Source.PHB;
                string fakeSource = lines[lines.Count() - 2].Substring(8);
                if (fakeSource.Contains("PHB"))
                    source = Source.PHB;
                else if (fakeSource.Contains("DMG"))
                    source = Source.DMG;
                else if (fakeSource.Contains("XGE"))
                    source = Source.XGE;
                else if (fakeSource.Contains("TCE"))
                    source = Source.TCE;
                else if (fakeSource.Contains("GGR"))
                    source = Source.GGR;
                else if (fakeSource.Contains("IDRotF"))
                    source = Source.IDRotF;
                else if (fakeSource.Contains("MTF"))
                    source = Source.MTF;
                else if (fakeSource.Contains("MOT"))
                    source = Source.MOT;
                else if (fakeSource.Contains("AI"))
                    source = Source.AI;
                else if (fakeSource.Contains("SCAG"))
                    source = Source.SCAG;
                else if (fakeSource.Contains("EEPC"))
                    source = Source.EEPC;
                else if (fakeSource.Contains("VGM"))
                    source = Source.VGM;
                else if (fakeSource.Contains("ERLW"))
                    source = Source.ERLW;
                else if (fakeSource.Contains("AWM"))
                    source = Source.AWM;
                else if (fakeSource.Contains("LR"))
                    source = Source.LR;
                else if (fakeSource.Contains("LLK"))
                    source = Source.LLK;
                else if (fakeSource.Contains("OGA"))
                    source = Source.OGA;
                else if (fakeSource.Contains("PS"))
                    source = Source.PS;
                else if (fakeSource.Contains("TTP"))
                    source = Source.TTP;
                else if (fakeSource.Contains("US"))
                    source = Source.UA;
                else if (fakeSource.Contains("WGE"))
                    source = Source.WGE;
                spellRegistry.Add(new Resources.Spell(spellName, description, eSchool, concentration, ritual, time, duration, level, range, casterList, compsList, source, materials));
            }
        }
    }
}
