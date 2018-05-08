using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanning
{
    public partial class Form1 : Form
    {

        DinnerParty party;

        public Form1()
        {
            InitializeComponent();

            party = new DinnerParty() { NumberOfPeople = (int)NumberPeopleNumericUpDown.Value};
           
            DisplayChanged();
           
        }

        private void NumberPeopleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            party.NumberOfPeople = (int)NumberPeopleNumericUpDown.Value;
            DisplayChanged();
        }

        private void DisplayChanged()
        {
            party.SetHealthyOption(HealthyOptionCheckBox.Checked);
            party.CalculateCostOfDecorations(FantazyDecorationCheckBox.Checked);
            CostTextBox.Text = "" + party.CalculateCost(HealthyOptionCheckBox.Checked);

        }

        private void FantazyDecorationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayChanged();
        }

        private void HealthyOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayChanged();
        }
    }
}
