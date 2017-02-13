using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string input = "Hello " + TextBoxName.Text;
            MessageBox.Show(input);
        }

        private void TextBoxNumberOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;
            int.TryParse(TextBoxNumberOne.Text, out first );
            int.TryParse( TextBoxNumberTwo.Text, out second );
            int total = first + second;
            MessageBox.Show(total.ToString());
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;
            int.TryParse(TextBoxNumberOne.Text, out first);
            int.TryParse(TextBoxNumberTwo.Text, out second);
            int total = first - second;
            MessageBox.Show(total.ToString());
        }
    }
}
