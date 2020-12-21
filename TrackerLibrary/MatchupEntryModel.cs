using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {

        /// <summary>
        /// represnts one team in the matchup
        /// </summary>
        public TeamModel teamCompeting { get; set; }
        /// <summary>
        /// represents score for a particular team
        /// </summary>
        public double score { get; set; }
        /// <summary>
        /// represensts the matchup that this form is the winner
        /// </summary>
        public MatchupModel parentMatchup { get; set; }

    }
}
