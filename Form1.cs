using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Calculateanglebetween3Points
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        public void Btn_Angle_Click(object sender, EventArgs e)
        {
            double L1_X1 = double.Parse(Txt_L1_X1.Text);
            double L1_X2 = double.Parse(Txt_L1_X2.Text);
            double L1_Y1 = double.Parse(Txt_L1_Y1.Text);
            double L1_Y2 = double.Parse(Txt_L1_Y2.Text);
            //...
            double L2_X1 = double.Parse(Txt_L2_X1.Text);
            double L2_X2 = double.Parse(Txt_L2_X2.Text);
            double L2_Y1 = double.Parse(Txt_L2_Y1.Text);
            double L2_Y2 = double.Parse(Txt_L2_Y2.Text);

            double angle1 = Math.Atan2(L1_Y2 - L1_Y1,
                                       L1_X2 - L1_X1);
            double angle2 = Math.Atan2(L2_Y2 - L2_Y1,
                                       L2_X2 - L2_X1);
            double result = angle1 - angle2;
            Txt_Angle_Result.Text = result.ToString();
            
        }

        private void Btn_Slope_Click(object sender, EventArgs e)
        {
            double L1_X1 = double.Parse(Txt_L1_X1.Text);
            double L1_X2 = double.Parse(Txt_L1_X2.Text);
            double L1_Y1 = double.Parse(Txt_L1_Y1.Text);
            double L1_Y2 = double.Parse(Txt_L1_Y2.Text);
            //...
            double result= (L1_X2 - L1_X1) / (L1_Y2 - L1_Y1);
            Txt_L1_Slop.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double L2_X1 = double.Parse(Txt_L2_X1.Text);
            double L2_X2 = double.Parse(Txt_L2_X2.Text);
            double L2_Y1 = double.Parse(Txt_L2_Y1.Text);
            double L2_Y2 = double.Parse(Txt_L2_Y2.Text);

            double result = (L2_X2 - L2_X1) / (L2_Y2 - L2_Y1);
            Txt_L2_Slop.Text = result.ToString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //public static double angleBetween2Lines()//Line2D line1, Line2D line2)
        //{
            
        //    double angle1 = Math.Atan2(line1.getY1() - line1.getY2(),
        //                               line1.getX1() - line1.getX2());
        //    double angle2 = Math.Atan2(line2.getY1() - line2.getY2(),
        //                               line2.getX1() - line2.getX2());
        //    return angle1 - angle2;
        //}
        
    }
}
