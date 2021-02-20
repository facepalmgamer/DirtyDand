using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static DirtyDand.Globals.GlobalVariables;

using DirtyDand.Handlers;
using DirtyDand.Properties;

namespace DirtyDand
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            InitializeHandlers();

        }

        private void InitializeHandlers()
        {
            SpellHandler spell = new SpellHandler();

        }

        public async Task<List<Resources.Spell>> SearchAsync(/*List<classes?> classes,*/ int[] level, Components[] comps, School[] schools, Time[] time, int[] range, bool concitration, bool ritual, Source[] sources, string search)
        {
            
            List<Resources.Spell> temp = new List<Resources.Spell>();
            List<Resources.Spell> temp2 = new List<Resources.Spell>();

            foreach (Resources.Spell s in spellRegistry)
                foreach (int l in level)
                    if (l == s.GetLevel())
                    {
                        temp.Add(s);
                        break;
                    }
            foreach (Resources.Spell s in temp)
                if (s.GetComponents().ToArray().Equals(comps))
                {
                    temp2.Add(s);
                    break;
                }
            temp.Clear();
            foreach (Resources.Spell s in temp2)
                foreach (School sc in schools)
                    if (s.GetSchool() == sc)
                    {
                        temp.Add(s);
                        break;
                    }
            temp2.Clear();
            foreach (Resources.Spell s in temp)
                foreach (Time t in time)
                    if (s.GetTime() == t)
                    {
                        temp.Add(s);
                        break;
                    }
            temp.Clear();
            foreach (Resources.Spell s in temp2)
                foreach (int r in range)
                    if (s.GetRange() == r)
                    {
                        temp.Add(s);
                        break;
                    }
            temp2.Clear();
            foreach (Resources.Spell s in temp2)
                foreach (Source b in sources)
                    if (s.GetSource() == b)
                    {
                        temp2.Add(s);
                        break;
                    }
            temp.Clear();
            foreach (Resources.Spell s in temp2)
                if (s.GetSpellName().Contains(search))
                    temp.Add(s);
            if (concitration)
            {
                temp2.Clear();
                foreach (Resources.Spell s in temp)
                    if (s.GetConcentration())
                        temp2.Add(s);
            }
            if (ritual)
            {
                if (!concitration)
                {
                    temp2.Clear();
                    foreach (Resources.Spell s in temp)
                        if (s.GetRitual())
                            temp2.Add(s);
                    return temp2;
                }
                else
                {
                    temp.Clear();
                    foreach (Resources.Spell s in temp2)
                        if (s.GetRitual())
                            temp.Add(s);
                    return temp;
                }
            }
            return temp;

        }


    }
}
