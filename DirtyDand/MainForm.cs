using DirtyDand.Handlers;
using DirtyDand.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DirtyDand.Globals.GlobalVariables;

namespace DirtyDand
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            
            InitializeHandlers();
            hideSubMenus();

        }
        private void hideSubMenus()
        {
            panelCharacter.Visible = false;
            panelHandbook.Visible = false;
            panelNewCharacter.Visible = false;
            panelExit.Visible = false;
        }

        private void InitializeHandlers()
        {
            SpellHandler spell = new SpellHandler();

            List<List<Spell>> levels = new List<List<Spell>>();
            for (int i = 0; i < 10; i++)
                levels.Add(new List<Spell>());

            for (int i = 0; i < spellRegistry.Count(); i++)
            {
                switch (spellRegistry.ElementAt(i).GetLevel())
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

        private void buttonCharacter_Click(object sender, EventArgs e)
        {
            panelCharacter.Visible = !panelCharacter.Visible;
        }

        private void buttonSelectCharacter_Click(object sender, EventArgs e)
        {
            openChildForm(new CharacterForm());
        }

        private void buttonNewCharacter_Click(object sender, EventArgs e)
        {
            if (!panelNewCharacter.Visible)
            {
                panelNewCharacter.Visible = true;
                panelCharacter.Size += new Size(0, panelNewCharacter.Size.Height);
            }
            else
            {
                panelNewCharacter.Visible = false;
                panelCharacter.Size -= new Size(0, panelNewCharacter.Size.Height);
            }
        }

        private void buttonHandbook_Click(object sender, EventArgs e)
        {
            panelHandbook.Visible = !panelHandbook.Visible;
        }

       

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            panelExit.Visible = !panelExit.Visible;
            if (panelMenu.AutoScroll && panelExit.Visible)
                panelMenu.ScrollControlIntoView(panelExit);
        }

        private void buttonExitWithoutSaving_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSpellSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new SpellForm());
        }
    }
}
