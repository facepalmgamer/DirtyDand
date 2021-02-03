using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DirtyDand.Resources;
using static DirtyDand.Globals.GlobalVariables;

using DirtyDand.Handlers;
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

            List<List<Spell>> levels = new List<List<Spell>>();
            for (int i = 0; i < 10; i++)
                levels.Add(new List<Spell>());

            for (int i = 0; i < spellRegistry.Count(); i++)
            {
                switch(spellRegistry.ElementAt(i).level)
                {
                    case 0:
                        levels.ElementAt(0).Add(spellRegistry.ElementAt(i));
                        break;
                    case 1:
                        levels.ElementAt(1).Add(spellRegistry.ElementAt(i));
                        break;
                    case 2:
                        levels.ElementAt(2).Add(spellRegistry.ElementAt(i));
                        break;
                    case 3:
                        levels.ElementAt(3).Add(spellRegistry.ElementAt(i));
                        break;
                    case 4:
                        levels.ElementAt(4).Add(spellRegistry.ElementAt(i));
                        break;
                    case 5:
                        levels.ElementAt(5).Add(spellRegistry.ElementAt(i));
                        break;
                    case 6:
                        levels.ElementAt(6).Add(spellRegistry.ElementAt(i));
                        break;
                    case 7:
                        levels.ElementAt(7).Add(spellRegistry.ElementAt(i));
                        break;
                    case 8:
                        levels.ElementAt(8).Add(spellRegistry.ElementAt(i));
                        break;
                    case 9:
                        levels.ElementAt(9).Add(spellRegistry.ElementAt(i));
                        break;
                }

            }
            spellRegistry.Clear();
            foreach (List<Spell> e in levels)
                spellRegistry.AddRange(e);

        }g

        public async void SearchAsync(List<Caster> castList, int[] level, Components[] comps, School[] schools, Time[] time, int[] range, bool concitration, )
        {


        }


    }
}
