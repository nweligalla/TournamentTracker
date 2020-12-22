using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make create prize method to save data to th DB
        /// <summary>
        /// saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize Information</param>
        /// <returns>The prize informatio including unique identifier</returns>
        public PrizeModel createPrize(PrizeModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
