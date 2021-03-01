using DirtyDand.Classes;
using DirtyDand.Handlers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static DirtyDand.Globals.GlobalVariables;

namespace DirtyDand
{
    public partial class MainForm : Form
    {

        public MainForm()
        {

            InitializeComponent();

            InitializeMainMenu();
            InitializeHandlers();

        }
        public void InitializeMainMenu()
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
                switch (spellRegistry.ElementAt(i).level)
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

        #region Character
        private void buttonCharacter_Click(object sender, EventArgs e)
        {
            panelCharacter.Visible = !panelCharacter.Visible;
        }

        private void buttonSelectCharacter_Click(object sender, EventArgs e)
        {
            openChildForm(new CharacterForm());
        }
        #region New Character
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
        #endregion
        #endregion

        #region Handbook
        private void buttonHandbook_Click(object sender, EventArgs e)
        {
            panelHandbook.Visible = !panelHandbook.Visible;
        }

        private void buttonSpellSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new SpellSearchForm(this));
        }
        #endregion

        private Stack<Form> activeForms = new Stack<Form>();
        private  void openChildForm(Form childForm)
        {
            if (activeForms.Count != 0)
                while (activeForms.Count > 0)
                    activeForms.Pop().Close();
            activeForms.Push(childForm);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void openSubChildForm(Form subChildForm)
        {
            activeForms.Peek().Hide();
            activeForms.Push(subChildForm);
            subChildForm.TopLevel = false;
            subChildForm.FormBorderStyle = FormBorderStyle.None;
            subChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(subChildForm);
            panelChildForm.Tag = subChildForm;
            subChildForm.BringToFront();
            subChildForm.Show();
        }

        public void OpenSpellForm(Spell spell)
        {
            openSubChildForm(new SpellForm(spell,this));
        }
        public void closeTopForm()
        {
            activeForms.Pop().Close();
            activeForms.Peek().Show();
        }

        #region Exit
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
        #endregion

    }
}
