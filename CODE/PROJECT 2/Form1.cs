using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape_Maker
{
    public partial class Form1 : Form
    {
        string str = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(date_check.Checked)
                str += DateTime.UtcNow.Date.ToString("dd/MM/yyyy") + "\n";
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red,4);
            System.Drawing.Brush myBrush = new SolidBrush(Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = shape_box.CreateGraphics();
            if (shape_combobox.Text == "Circle" )
            {
                if(name_check.Checked)
                    str += "Circle";
                if(is_outline.Checked)
                    formGraphics.DrawEllipse(myPen, shape_box.Width / 2 - 50, shape_box.Height / 2 - 50, 100, 100);
                else
                    formGraphics.FillEllipse(myBrush, shape_box.Width / 2 - 50, shape_box.Height / 2 - 50, 100, 100);
            }
            else if (shape_combobox.Text == "Triangle")
            {
                if(name_check.Checked)
                    str += "Triangle";
                Point[] pnt = new Point[3];
                pnt[0].X = (shape_box.Width/2);
                pnt[0].Y = 50;

                pnt[1].X = (shape_box.Width / 4);
                pnt[1].Y = 150;

                pnt[2].X = (shape_box.Width / 4)*3;
                pnt[2].Y = 150;
                if (is_outline.Checked)
                    formGraphics.DrawPolygon(myPen, pnt);
                else
                    formGraphics.FillPolygon(myBrush, pnt);
            }
            else if (shape_combobox.Text == "Rectangle")
            {
                if(name_check.Checked)
                    str += "Rectangle";
                if (is_outline.Checked)
                    formGraphics.DrawRectangle(myPen, new Rectangle(20, 20, 150, 150));
                else
                    formGraphics.FillRectangle(myBrush, new Rectangle(20, 20, 150, 150));
            }
            else if (shape_combobox.Text == "Pentagon")
            {
                if(name_check.Checked)
                    str += "Pentagon";
                var shape = new PointF[5];

                var r = 70; //70 px radius 

                //Create 6 points
                for (int a = 0; a < 5; a++)
                {
                    shape[a] = new PointF(
                        (shape_box.Width / 2) + r * (float)Math.Cos(((a * 72 * Math.PI) / 180f) + 6),
                        (shape_box.Height / 2) + r * (float)Math.Sin(((a * 72 * Math.PI) / 180f) + 6)
                        );
                }
                if (is_outline.Checked)
                    formGraphics.DrawPolygon(myPen, shape);
                else
                    formGraphics.FillPolygon(myBrush, shape);
            }
            else if (shape_combobox.Text == "Hexagon")
            {
                if(name_check.Checked)
                    str += "Hexagon";
                var shape = new PointF[6];

                var r = 70; //70 px radius 

                //Create 6 points
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        (shape_box.Width / 2) + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        (shape_box.Height / 2) + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                }
                if (is_outline.Checked)
                    formGraphics.DrawPolygon(myPen, shape);
                else
                    formGraphics.FillPolygon(myBrush, shape);
            }
            show_label.Text = str;
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            shape_box.Invalidate();
            show_label.Text = "";
            str = "";
        }
    }
}
