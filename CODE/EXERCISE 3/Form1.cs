using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            Data obj = new Data();
            try
            {
                obj.Weight = Int16.Parse(weight_box.Text);
                if (obj.Weight == 0)
                {
                    MessageBox.Show("Weight can't be Zero or Less than Zero", "Wrong Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch(System.FormatException ex)
            {
                if(weight_box.Text == "")
                    MessageBox.Show("Please enter some value in the Text box", "Wrong Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Please write corect input format", "Wrong Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox.Checked)
                result_box.Text = (Math.Round(((obj.Weight / 9.81) * 3.711), 3)).ToString();
            else
                result_box.Text = (((obj.Weight / 9.81) * 3.711)).ToString();
            }

    }
}
