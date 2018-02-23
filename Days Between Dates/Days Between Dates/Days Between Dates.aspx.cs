using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Days_Between_Dates
{
    public partial class Days_Between_Dates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                elapsedDays.Text = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate).TotalDays.ToString() + " Days";
            }
            else if (Calendar2.SelectedDate > Calendar1.SelectedDate)
            {
                elapsedDays.Text = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays.ToString() + " Days";
            }
            else elapsedDays.Text = "0 Days. Who are you trying to fool?";
        }
    }
}