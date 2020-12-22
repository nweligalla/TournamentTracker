using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// reprensts a prize
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// unique id for prize
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// represnts a place number for prize
        /// </summary>
        public int placeNumber { get; set; }
        /// <summary>
        /// represents the name for the place 
        /// </summary>
        public string placeName { get; set; }
        /// <summary>
        /// represnts amount for the prize
        /// </summary>
        public decimal prizeAmount { get; set; }
        /// <summary>
        /// represents the prize precentage   
        /// </summary>
        public double prizePerecentage { get; set; }


        public PrizeModel()
        {

        }

        public PrizeModel(String placeNumber, String placeName, String prizeAmount, String prizePerecentage)
        {

            this.placeNumber = Int32.Parse(placeNumber);
            this.placeName = placeName;
            this.prizeAmount = decimal.Parse(prizeAmount);
            this.prizePerecentage = double.Parse(prizePerecentage);

        }

    }
}
