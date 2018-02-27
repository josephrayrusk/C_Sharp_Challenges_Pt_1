using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";
            int mostBattles = 0;

            int leastBattles = 0;
      

            // Your Code Here!
            for (int i = 0; i < numbers.Length; i++)
            {
                //Most Battles
               
                if (numbers[i]> numbers[mostBattles] )
                {
                    mostBattles = i;
                }
                // Least Battles
                if (numbers[i] < numbers[leastBattles])
                {
                    leastBattles = i;
                }

            }

            result = String.Format("Most battles goes to {0} with {1}", names[mostBattles], numbers[mostBattles]);
            result += String.Format("<br /> Least battles goes to {0} with {1}", names[leastBattles], numbers[leastBattles]);
            resultLabel.Text = result;
        }
    }
}