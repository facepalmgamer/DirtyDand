using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        public async void SearchAsync(int[] levels)
        {

        }


    }
}
