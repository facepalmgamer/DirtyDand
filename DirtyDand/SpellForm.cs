using DirtyDand.Classes;
using System.Windows.Forms;

namespace DirtyDand
{
    public partial class SpellForm : Form
    {
        Spell spell;
        MainForm main;
        public SpellForm(Spell spell, MainForm main)
        {
            this.spell = spell;
            this.main = main;
            InitializeComponent();
            label1.Text = spell.spellName;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            main.closeTopForm();
        }
    }
}
