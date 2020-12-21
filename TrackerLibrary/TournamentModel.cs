using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        public string tournamentName { get; set; }
        public decimal entryFee { get; set; }
        public List<TeamModel> enteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
