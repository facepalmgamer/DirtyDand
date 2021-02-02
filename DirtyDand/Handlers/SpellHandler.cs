using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DirtyDand.Globals;

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
                string[] temp = lines[1].Split();
                //Gets the spell school
                string school = String.Empty;
                if (level == 0)
                    school = temp[0];
                else
                    school = temp[1];
                //Gets the spell casting time
                string castTime = lines[2].Substring(14, lines[2].Length-1);
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
                int start = 12;
                string compsWhole = String.Empty;
                while(lines[4].Substring(start + 1, start + 2).Equals(","))
                {
                    compsWhole.Remove(start + 1, start + 2);
                    compsWhole += lines[4].Substring(start, start + 2);
                    start += 2;
                }
                compsWhole += lines[4].Substring(start, start + 1);
                string[] comps = compsWhole.Split(' ');
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
                string classList = lines[count];
                //Gets the source the spell was published from
                string source = lines[lines.Count() - 2];

            }
        }
    }
}
