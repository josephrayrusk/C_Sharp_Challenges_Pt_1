using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epic_Spies
{
    public partial class Epic_Spies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Today;
                Calendar2.SelectedDate = DateTime.Today.AddDays(14);
                Calendar3.SelectedDate = DateTime.Today.AddDays(21);
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void assignSpy_Click(object sender, EventArgs e)
        {
            if (spyName.Text.Length > 0 && assignmentName.Text.Length > 0) { 
                int vacation = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).Days;

                    if (vacation > 13)
                    {
                        int assignmentLength = Calendar3.SelectedDate.Subtract(Calendar1.SelectedDate).Days;
                        int budget = 0;
                        if (assignmentLength > 21)
                        {
                            budget = (assignmentLength * 500) + 1000;
                        }
                        else
                        {
                            budget = assignmentLength * 500;
                        }
                        assignment.Text = "Enjoy your time off " + spyName.Text + "!<br>" +
                                            "Your new assignment is " + assignmentName.Text + ".<br>" +
                                            "Your start date is " + Calendar2.SelectedDate.ToShortDateString() + "<br>" +
                                            "with your projected end date " + Calendar3.SelectedDate.ToShortDateString() + ".<br>" +
                                            "Budget is " + budget.ToString("C");



                    }
                    else
                    {
                        assignment.Text = "Error: <br>Please take 14 or more days off between assignments. <br> The earliest available day to start is " + Calendar1.SelectedDate.AddDays(14).ToShortDateString();
                        Calendar2.SelectedDate = Calendar1.SelectedDate.AddDays(14);
                    }
                }
            else
            {
                assignment.Text = "Please enter your name and assignment name";
            }
        }
    }
}