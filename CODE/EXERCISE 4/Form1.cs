using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seconds_Convertor
{
    public partial class Form1 : Form
    {
        Data obj = new Data();
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            obj.Clear_Data();
            obj.All_Seconds = Double.Parse(seconds_box.Text);
            if(Double.Parse(seconds_box.Text)>Double.MaxValue)
            {
                MessageBox.Show("Weight can't be Zero or Less than Zero", "Wrong Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            obj.Convert();
            answer_label.Text = obj.ToString();
        }
    }
}
