using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using static DirtyDand.Globals.GlobalVariables;

namespace DirtyDand.Handlers
{
    public class SpellHandler
    {
        public SpellHandler()
        {
            string result;
            result = File.ReadAllText("./Resources\\Spells5e.txt");
            string[] spells = result.Split('~');

            foreach (string e in spells)
            {
                spellRegistry.Add(new Classes.Spell());
                //Splits file into spells
                string[] fakeLine = e.Split('\n');
                List<string> lines = fakeLine.ToList();
                lines.Remove("\r");


                //Gets the spell name

                spellRegistry.Last().spellName = lines[0];

                //Gets the spell level
                if (Int32.TryParse(lines[1].Substring(0, 1), out int strLevel))
                    spellRegistry.Last().level = strLevel;

                //Gets the spell school
                if (lines[1].IndexOf("Abjuration") >= 0 || lines[1].IndexOf("abjuration") >= 0)
                    spellRegistry.Last().school = School.Abjuration;
                else if (lines[1].IndexOf("Conjuration") >= 0 || lines[1].IndexOf("conjuration") >= 0)
                    spellRegistry.Last().school = School.Conjuration;
                else if (lines[1].IndexOf("Divination") >= 0 || lines[1].IndexOf("divination") >= 0)
                    spellRegistry.Last().school = School.Divination;
                else if (lines[1].IndexOf("Enchantment") >= 0 || lines[1].IndexOf("enchantment") >= 0)
                    spellRegistry.Last().school = School.Enchantment;
                else if (lines[1].IndexOf("Evocation") >= 0 || lines[1].IndexOf("evocation") >= 0)
                    spellRegistry.Last().school = School.Evocation;
                else if (lines[1].IndexOf("Illusion") >= 0 || lines[1].IndexOf("illusion") >= 0)
                    spellRegistry.Last().school = School.Illusion;
                else if (lines[1].IndexOf("Necromancy") >= 0 || lines[1].IndexOf("necromancy") >= 0)
                    spellRegistry.Last().school = School.Necromancy;
                else if (lines[1].IndexOf("Transmutation") >= 0 || lines[1].IndexOf("transmutation") >= 0)
                    spellRegistry.Last().school = School.Transmutation;

                //Determines if the spell can be ritual cast
                if (lines[1].Contains("(ritual)"))
                    spellRegistry.Last().ritual = true;

                //Gets the spell casting time
                if (lines[2].Contains("1 action"))
                    spellRegistry.Last().time = Time.A;
                else if (lines[2].Contains("1 bonus action"))
                    spellRegistry.Last().time = Time.Ba;
                else if (lines[2].Contains("1 reaction"))
                    spellRegistry.Last().time = Time.R;
                else if (lines[2].Contains("1 minute"))
                    spellRegistry.Last().time = Time.M;
                else if (lines[2].Contains("10 minutes"))
                    spellRegistry.Last().time = Time.Ms;
                else if (lines[2].Contains("1 hour"))
                    spellRegistry.Last().time = Time.H;
                // Gets the range of the spell
                int range = -1;
                if (!Int32.TryParse(lines[3].Substring(7, 3), out range))
                    if (!Int32.TryParse(lines[3].Substring(7, 2), out range))
                        if (!Int32.TryParse(lines[3].Substring(7, 1), out range))
                            if (lines[3].Substring(7, 1).Equals("T"))
                                spellRegistry.Last().range = -1;//Touch Range
                            else if (lines[3].Substring(7, 2).Equals("Sp"))
                            {
                                spellRegistry.Last().range = -1;
                                spellRegistry.Last().specialRange = "Special";
                            }
                            else if (lines[3].Substring(7, 2).Equals("Se") && lines[3].Length == 12)
                                spellRegistry.Last().range = 0;//Self Range
                            else if (lines[3].Substring(7, 2).Equals("Si"))
                            {
                                spellRegistry.Last().range = -1;
                                spellRegistry.Last().specialRange = "Sight"; //The damn sight ranges
                            }
                            else if (lines[3].Substring(7, 2).Equals("Un"))
                            {
                                spellRegistry.Last().range = -1;
                                spellRegistry.Last().specialRange = "Unlimited";
                            }
                            else
                            {
                                spellRegistry.Last().range = 0;
                                spellRegistry.Last().specialRange = " " + lines[3].Substring(lines[3].IndexOf("(")+1, lines[3].Length - lines[3].IndexOf("(")-3);
                            }
                if (range != -1)
                    spellRegistry.Last().range = range;
                if (lines[3].Contains("mile"))
                    spellRegistry.Last().specialRange = " mile";

                //Gets the spell components
                if (lines[4].IndexOf("V") >= 0)
                    spellRegistry.Last().componentsList.Add(Components.V);
                if (lines[4].IndexOf("S") >= 0)
                    spellRegistry.Last().componentsList.Add(Components.S);
                if (lines[4].IndexOf("M") >= 0)
                {
                    spellRegistry.Last().componentsList.Add(Components.M);
                    spellRegistry.Last().material = lines[4].Substring(lines[4].IndexOf("M") + 3,lines[4].Length - lines[4].IndexOf("M")-5);
                }

                //Gets the spell duration
                spellRegistry.Last().duration = lines[5].Substring(10);
                if (spellRegistry.Last().duration.Contains("Concentration"))
                {
                    spellRegistry.Last().concentration = true;
                    spellRegistry.Last().duration = spellRegistry.Last().duration.Remove(0, spellRegistry.Last().duration.IndexOf("to") + 3);
                }

                //Gets the full spell description
                int count = 6;
                while (!lines[count].Contains("Classes:") && !lines[count].Contains("Subclasses:") && !lines[count].Contains("Backgrounds:"))
                {
                    spellRegistry.Last().spellDescript += lines[count];
                    ++count;
                }

                //Gets the list of classes able to use the spell
                //Artificer, Bard, Cleric, Druid, Paladin, Ranger, Sorcerer, Warlock, Wizard
                string classList = lines[count];
                if (lines[count].Contains("Artificer"))
                    spellRegistry.Last().casterList.Add(Caster.Artificer);
                if (lines[count].Contains("Bard"))
                    spellRegistry.Last().casterList.Add(Caster.Bard);
                if (lines[count].Contains("Cleric"))
                    spellRegistry.Last().casterList.Add(Caster.Cleric);
                if (lines[count].Contains("Druid"))
                    spellRegistry.Last().casterList.Add(Caster.Druid);
                if (lines[count].Contains("Paladin"))
                    spellRegistry.Last().casterList.Add(Caster.Paladin);
                if (lines[count].Contains("Ranger"))
                    spellRegistry.Last().casterList.Add(Caster.Ranger);
                if (lines[count].Contains("Sorcerer"))
                    spellRegistry.Last().casterList.Add(Caster.Sorcerer);
                if (lines[count].Contains("Warlock"))
                    spellRegistry.Last().casterList.Add(Caster.Warlock);
                if (lines[count].Contains("Wizard"))
                    spellRegistry.Last().casterList.Add(Caster.Wizard);

                //Gets the source the spell was published from
                string fakeSource = lines[lines.Count() - 2].Substring(8);
                if (fakeSource.Contains("PHB"))
                    spellRegistry.Last().source = Source.PHB;
                else if (fakeSource.Contains("DMG"))
                    spellRegistry.Last().source = Source.DMG;
                else if (fakeSource.Contains("XGE"))
                    spellRegistry.Last().source = Source.XGE;
                else if (fakeSource.Contains("TCE"))
                    spellRegistry.Last().source = Source.TCE;
                else if (fakeSource.Contains("GGR"))
                    spellRegistry.Last().source = Source.GGR;
                else if (fakeSource.Contains("IDRotF"))
                    spellRegistry.Last().source = Source.IDRotF;
                else if (fakeSource.Contains("MTF"))
                    spellRegistry.Last().source = Source.MTF;
                else if (fakeSource.Contains("MOT"))
                    spellRegistry.Last().source = Source.MOT;
                else if (fakeSource.Contains("AI"))
                    spellRegistry.Last().source = Source.AI;
                else if (fakeSource.Contains("SCAG"))
                    spellRegistry.Last().source = Source.SCAG;
                else if (fakeSource.Contains("EEPC"))
                    spellRegistry.Last().source = Source.EEPC;
                else if (fakeSource.Contains("VGM"))
                    spellRegistry.Last().source = Source.VGM;
                else if (fakeSource.Contains("ERLW"))
                    spellRegistry.Last().source = Source.ERLW;
                else if (fakeSource.Contains("AWM"))
                    spellRegistry.Last().source = Source.AWM;
                else if (fakeSource.Contains("LR"))
                    spellRegistry.Last().source = Source.LR;
                else if (fakeSource.Contains("LLK"))
                    spellRegistry.Last().source = Source.LLK;
                else if (fakeSource.Contains("OGA"))
                    spellRegistry.Last().source = Source.OGA;
                else if (fakeSource.Contains("PS"))
                    spellRegistry.Last().source = Source.PS;
                else if (fakeSource.Contains("TTP"))
                    spellRegistry.Last().source = Source.TTP;
                else if (fakeSource.Contains("UA"))
                    spellRegistry.Last().source = Source.UA;
                else if (fakeSource.Contains("WGE"))
                    spellRegistry.Last().source = Source.WGE;
                
            }
        }
    }
}
