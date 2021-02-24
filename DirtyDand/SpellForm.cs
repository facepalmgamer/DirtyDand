using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DirtyDand.Globals.GlobalVariables;


namespace DirtyDand
{
    public partial class SpellForm : Form
    {

        public SpellForm()
        {
            InitializeComponent();
            InitializeSpells();
        }
        
        public  void InitializeSpells()
        {


            DataTable spellTable = new DataTable();
            spellTable.Columns.Add("Spell Name", typeof(string));
            spellTable.Columns.Add("Level", typeof(int));
            spellTable.Columns.Add("School", typeof(School));
            spellTable.Columns.Add("Ritual", typeof(bool));
            spellTable.Columns.Add("Cast Time", typeof(string));
            spellTable.Columns.Add("Range", typeof(string));
            spellTable.Columns.Add("Con.", typeof(bool));
            spellTable.Columns.Add("Duration", typeof(string));
            spellTable.Columns.Add("Source", typeof(Source));
            foreach (Classes.Spell spell in spellRegistry)
            {
                spellTable.Rows.Add(spell.spellName, spell.level, spell.school, spell.ritual, spell.GetCastTime(), spell.GetRange(), spell.concentration,spell.duration,spell.source);
            }
            dataGridViewSpells.DataSource = spellTable;
            dataGridViewSpells.ReadOnly = true;



        }


    }

    class RowComparer : IComparer
    {
        private static int sortOrderModifier = 1;

        public RowComparer(SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.Descending)
                sortOrderModifier = -1;
        }

        public int Compare(object x, object y)
        {
            DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
            DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

            // Try to sort based on the Last Name column.
            int CompareResult = System.String.Compare(
                DataGridViewRow1.Cells[1].Value.ToString(),
                DataGridViewRow2.Cells[1].Value.ToString());

            // If the Last Names are equal, sort based on the First Name.
            if (CompareResult == 0)
            {
                CompareResult = System.String.Compare(
                    DataGridViewRow1.Cells[0].Value.ToString(),
                    DataGridViewRow2.Cells[0].Value.ToString());
            }
            return CompareResult * sortOrderModifier;
        }
    }
}
