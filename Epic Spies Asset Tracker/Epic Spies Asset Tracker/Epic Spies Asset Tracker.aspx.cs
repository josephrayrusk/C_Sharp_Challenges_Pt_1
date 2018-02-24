using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epic_Spies_Asset_Tracker
{
    public partial class Epic_Spies_Asset_Tracker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] acts = new int[0];

                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("Acts", acts);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                // Ensure all boxes are filled out for array. 
            if (assetName.Text.Length > 0 && electionsRigged.Text.Length > 0 && actsPerformed.Text.Length > 0)
                {
                    string[] assets = (string[])ViewState["Assets"];
                    int[] elections = (int[])ViewState["Elections"];
                    int[] acts = (int[])ViewState["Acts"];

                    //Increase Array Size
                    int newLength = assets.Length + 1;

                        Array.Resize(ref assets, newLength);
                        Array.Resize(ref elections, newLength);
                        Array.Resize(ref acts, newLength);

                    int newIndex = assets.GetUpperBound(0);

                        assets[newIndex] = assetName.Text;
                        elections[newIndex] = int.Parse(electionsRigged.Text);
                        acts[newIndex] = int.Parse(actsPerformed.Text);

                    ViewState["Assets"] = assets;
                    ViewState["Elections"] = elections;
                    ViewState["acts"] = acts;

                    //Display results in "resultLabel"
                    resultLabel.Text = String.Format("Total Elections Rigged: {0} <br />Acts of Subterfuge Per Asset (Average): {1:N2}<br /> The Last Asset Added Was: {2}",
                        elections.Sum(), acts.Average(), assets[newIndex]);

                    assetName.Text = "";
                    electionsRigged.Text = "";
                    actsPerformed.Text = "";

                }
            else resultLabel.Text = "Please enter all information before continuing.";
        }
    }
}