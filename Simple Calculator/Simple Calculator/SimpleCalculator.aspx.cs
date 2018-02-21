using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Simple_Calculator
{
    public partial class SimpleCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstValue.Text);
            double j = double.Parse(secondValue.Text);

            double k = i + j;

            valueResult.Text = k.ToString();

        }

        protected void Subtract_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstValue.Text);
            double j = double.Parse(secondValue.Text);

            double k = i - j;

            valueResult.Text = k.ToString();
        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstValue.Text);
            double j = double.Parse(secondValue.Text);

            double k = i * j;

            valueResult.Text = k.ToString();
        }

        protected void Divide_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstValue.Text);
            double j = double.Parse(secondValue.Text);

            double k = i / j;

            valueResult.Text = k.ToString();
        }
    }
}