using DirtyDand.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static DirtyDand.Globals.GlobalVariables;


namespace DirtyDand
{
    public partial class SpellForm : Form
    {
        List<Spell> spellList = new List<Spell>(spellRegistry);
        DataTable spellTable;
        public SpellForm()
        {
            InitializeComponent();
            InitializeSpells();
        }

        private void InitializeSpells()
        {

            spellTable = new DataTable();
            spellTable.Columns.Add("Spell Name", typeof(string));
            spellTable.Columns.Add("Level", typeof(int));
            spellTable.Columns.Add("School", typeof(School));
            spellTable.Columns.Add("Ritual", typeof(bool));
            spellTable.Columns.Add("Cast Time", typeof(string));
            spellTable.Columns.Add("Range", typeof(string));
            spellTable.Columns.Add("Con.", typeof(bool));
            spellTable.Columns.Add("Duration", typeof(string));
            spellTable.Columns.Add("Source", typeof(Source));
            foreach (Spell spell in spellList)
            {
                spellTable.Rows.Add(spell.spellName, spell.level, spell.school, spell.ritual, spell.GetCastTime(), spell.GetRange(), spell.concentration, spell.duration, spell.source);
            }
            dataGridViewSpells.DataSource = spellTable;
            dataGridViewSpells.ReadOnly = true;



        }

        private void UpdateTable(string search)
        {
            List<Spell> temp = new List<Spell>(spellRegistry);
            spellList = new List<Spell>(spellRegistry);
            foreach (Spell spell in temp)
            {
                if (!spell.spellName.ToLower().Contains(search.ToLower()))
                        spellList.Remove(spell);
                    
            }
            spellTable.Clear();
            foreach (Spell spell in spellList)
            {
                spellTable.Rows.Add(spell.spellName, spell.level, spell.school, spell.ritual, spell.GetCastTime(), spell.GetRange(), spell.concentration, spell.duration, spell.source);
            }
            dataGridViewSpells.DataSource = spellTable;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            UpdateTable(textBoxSearchBar.Text);
        }
    }



}
