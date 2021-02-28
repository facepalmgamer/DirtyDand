using DirtyDand.Classes;
using System.Windows.Forms;

namespace DirtyDand
{
    public partial class SpellForm : Form
    {
        Spell spell;
        public SpellForm(Spell spell)
        {
            this.spell = spell;
            InitializeComponent();
            label1.Text = spell.spellName;
        }
    }
}
