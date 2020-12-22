using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> connections { get; private set; } = new List<IDataConnection>();

        public static void initializeConnections(bool database, bool textfile)
        {
            if (database)
            {
                // TODO - set up the sql connection properly
                SqlConnector sql = new SqlConnector();
                connections.Add(sql);

            }

            if (textfile)
            {
                // something
                TextConnector text = new TextConnector();
                connections.Add(text);
            }
        }
    }
}
