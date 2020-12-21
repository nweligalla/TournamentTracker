using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// reperents one match in the tournament
    /// </summary>
   public class MatchupModel
    {
        /// <summary>
        /// The list of teams involved in this match
        /// </summary>
        public List<MatchupEntryModel> entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// winner of the match
        /// </summary>
        public TeamModel winner { get; set; }
        /// <summary>
        /// which round this match is part of
        /// </summary>
        public int matchUpRound { get; set; }
        

    }
}
