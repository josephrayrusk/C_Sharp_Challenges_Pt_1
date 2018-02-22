using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Conditional_Radio_Button
{
    public partial class Conditional_Radio_Button : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (Pencil.Checked)
            {
                resultLabel.Text = "Really? I have not used a pencil in years.";
                resultImage.ImageUrl = "pencil.png";

            }
            else if (Pen.Checked)
            {
                resultLabel.Text = "I love to use pens!";
                resultImage.ImageUrl = "pen.png";
            }
            else if (Tablet.Checked)
            {
                resultLabel.Text = "Great idea! You really know how to take notes.";
                resultImage.ImageUrl = "tablet.png";
            }
            else if (Phone.Checked)
            {
                resultLabel.Text = "You must type really fast with two fingers.";
                resultImage.ImageUrl = "phone.png";
            }
            else resultLabel.Text = "Please select an option.";
        }
    }
}