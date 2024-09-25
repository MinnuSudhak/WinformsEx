using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleProject
{
    public partial class SquareCalcForm : Form
    {
        public SquareCalcForm()
        {
            InitializeComponent();
        }

       

        private void SquareCalcForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
